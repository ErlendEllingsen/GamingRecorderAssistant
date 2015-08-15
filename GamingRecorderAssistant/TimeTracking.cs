using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingRecorderAssistant
{

    public static class TimeTracking
    {

        public enum timeTrackingStates
        {
            inactive, tracking
        }

        public enum deadlineStates
        {
            normal, yellow, yellowblink, redblink
        }

        #region vars

        //Important vars
        public static frm_main mainInstance = null;
        public static frm_settings settingsInstance = null;
        public static bool settingsShown = false;
        public static config projectConfig = null;

        //Timetracking states

        public static timeTrackingStates currentTrackingState = timeTrackingStates.inactive;


        //Current tracking tick
        public static int totalTimer = 0;
        //Breaking vars
        public static int breakingTimeAccumulated = 0;
        public static bool currentlyBreaking = false;
        public static timeTrackingBreak currentBreak = null;
        public static List<timeTrackingBreak> previousBreaks = new List<timeTrackingBreak>();
        //Mark vars
        public static List<timeTrackingMark> marks = new List<timeTrackingMark>();

        //DEADLINE vars
        public const int deadline_yellow = (3 * 60);
        public const int deadline_yellowBlink = (2 * 60);
        public const int deadline_redBlink = (0);
        public static deadlineStates currentDeadlineState = deadlineStates.normal;


        #endregion

        #region functions
        #region common-functions
        public static Tuple<string, string, string> timeVisualiser(int totalseconds)
        {

            //HOURS
            int totalTimerWorking = totalseconds;

            int hours = (int)Math.Floor((decimal)(totalTimerWorking / 60 / 60));
            totalTimerWorking = (totalTimerWorking - (hours * 60 * 60));

            int minutes = (int)Math.Floor((decimal)(totalTimerWorking / 60));
            totalTimerWorking = (totalTimerWorking - (minutes * 60));
            
            int seconds = totalTimerWorking;

            //Convert to string and (add leading zeroes)
            Tuple<string, string, string> returnvalue = new Tuple<string, string, string>((hours >= 10 ? Convert.ToString(hours) : "0" + Convert.ToString(hours)), (minutes >= 10 ? Convert.ToString(minutes) : "0" + Convert.ToString(minutes)), (seconds >= 10 ? Convert.ToString(seconds) : "0" + Convert.ToString(seconds)));
            return returnvalue;
        }
        #endregion

        #region Project, save and load 
        public static void newProject()
        {
            //Reset vars
            currentTrackingState = timeTrackingStates.inactive;
            totalTimer = 0;
            breakingTimeAccumulated = 0;
            currentlyBreaking = false;
            currentBreak = null;
            previousBreaks = new List<timeTrackingBreak>();
            marks = new List<timeTrackingMark>();
            currentDeadlineState = deadlineStates.normal;

            mainInstance.dgv_marks.Rows.Clear();

            //Reset vars for other classes
            timeTrackingBreak.index = 0;
            timeTrackingMark.index = 0;


            //Reset timers and vars
            mainInstance.timer_tracker.Enabled = false;
            mainInstance.la_totalTimer.Text = "00:00:00";
            mainInstance.la_episodeTimer.Text = "00:00:00";
            mainInstance.la_breakTimer.Text = "00:00:00";
            mainInstance.la_deadlineTimer.Text = "00:00:00";

            //Set colors to normal.
            mainInstance.la_status_tracking.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            mainInstance.la_status_inactive.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            mainInstance.la_status_break.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            mainInstance.la_status_deadline.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);


            //SHOW Settings form
            settingsInstance = new frm_settings();
            settingsInstance.Show();
            settingsShown = true;
            mainInstance.SendToBack();
            settingsInstance.Activate();

        }

        public static void saveProject(string savePath)
        {
            projectConfig.breakingTimeAccumulated = TimeTracking.breakingTimeAccumulated;
            projectConfig.previousBreaks = TimeTracking.previousBreaks;
            projectConfig.marks = TimeTracking.marks;
            projectConfig.totalTimer = TimeTracking.totalTimer;

            using (StreamWriter sw = new StreamWriter(savePath))
            {
                sw.Write(config.SerializeObject(projectConfig));
            }

            MessageBox.Show("Project saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void openProject(string openPath)
        {

            //CLEAR VARS PRE_LOAD
            //Clear the breaks and marks.
            mainInstance.dgv_marks.Rows.Clear();


            //Get the config file from the path
            string configContent = "";
            using (StreamReader sr = new StreamReader(openPath))
            {
                configContent = sr.ReadToEnd();
            }

            config loadedConfig = (config)config.DeserializeObject<config>(configContent);
            projectConfig = loadedConfig;

            //Convert config-file to timetracking vals
            TimeTracking.breakingTimeAccumulated = projectConfig.breakingTimeAccumulated;
            TimeTracking.totalTimer = projectConfig.totalTimer;
            TimeTracking.marks = projectConfig.marks;
            TimeTracking.previousBreaks = projectConfig.previousBreaks;
            
            
            //Process, do visuals and stuff...
            //Visualize totaltimer, episodetimer and deadlinetimer (if activated).
            int episodeTimer = (totalTimer - breakingTimeAccumulated);
            if (currentlyBreaking) episodeTimer -= (totalTimer - currentBreak.totTimeStart);

            Tuple<string, string, string> timeVisualized = timeVisualiser(totalTimer);
            Tuple<string, string, string> episodeTimeVisualized= timeVisualiser(episodeTimer);

            mainInstance.la_totalTimer.Text = timeVisualized.Item1 + ":" + timeVisualized.Item2 + ":" + timeVisualized.Item3;
            mainInstance.la_episodeTimer.Text = episodeTimeVisualized.Item1 + ":" + episodeTimeVisualized.Item2 + ":" + episodeTimeVisualized.Item3;

         
            //Check for deadlinetimer
            if (projectConfig.deadline)
            {
                Tuple<string, string, string> deadlineTimeVisualized = timeVisualiser(projectConfig.deadlineTimer);
                mainInstance.la_deadlineTimer.Text = deadlineTimeVisualized.Item1 + ":" + deadlineTimeVisualized.Item2 + ":" + deadlineTimeVisualized.Item3;
            }

            
        }

        public static void configLoaded()
        {
            Tuple<string, string, string> deadlineVisualized = timeVisualiser(projectConfig.deadlineTimer);
            mainInstance.la_deadlineTimer.Text = deadlineVisualized.Item1 + ":" + deadlineVisualized.Item2 + ":" + deadlineVisualized.Item3;
            

           

        }
        #endregion

        #region Tracker functions

        public static void recording_start()
        {
            if (projectConfig == null) MessageBox.Show("Configuration is not set. Please use setup first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            mainInstance.timer_tracker.Interval = 1000;
            mainInstance.timer_tracker.Stop();
            mainInstance.timer_tracker.Start();

            //Update visuals
            currentTrackingState = timeTrackingStates.tracking;
            mainInstance.la_status_tracking.ForeColor = System.Drawing.Color.Red;
            mainInstance.la_status_inactive.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        public static void recording_stop()
        {
            mainInstance.timer_tracker.Stop();

            //Update visuals

            break_stop();
            currentTrackingState = timeTrackingStates.inactive;
            mainInstance.la_status_inactive.ForeColor = System.Drawing.Color.White;
            mainInstance.la_status_tracking.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);


        }

        public static void tracker_tick()
        {

            totalTimer++;

            //CALCULATE EPISODETIMER
            int episodeTimer = (totalTimer - breakingTimeAccumulated);
            if (currentlyBreaking) episodeTimer -= (totalTimer - currentBreak.totTimeStart);

            Tuple<string, string, string> timeVisualized = timeVisualiser(totalTimer);

            //Check if approaching deadline
            if (projectConfig.deadline)
            {
                int timeToDeadline = (projectConfig.deadlineTimer - episodeTimer);

                //Set blinking status (and color) properly to deadline-timer.
                if (timeToDeadline < deadline_redBlink)
                {
                    if (currentDeadlineState != deadlineStates.redblink)
                    {
                        currentDeadlineState = deadlineStates.redblink;
                        mainInstance.la_status_deadline.ForeColor = System.Drawing.Color.Red;
                    }
                    
                } else if (timeToDeadline < deadline_yellowBlink)
                {
                    if (currentDeadlineState != deadlineStates.yellowblink)
                    {
                        currentDeadlineState = deadlineStates.yellowblink;
                        mainInstance.la_status_deadline.ForeColor = System.Drawing.Color.Yellow;
                    }
                    
                } else if (timeToDeadline < deadline_yellow)
                {
                    if (currentDeadlineState != deadlineStates.yellow)
                    {
                        currentDeadlineState = deadlineStates.yellow;
                        mainInstance.la_status_deadline.ForeColor = System.Drawing.Color.Yellow;
                    }
                    
                }

                //end deadline
            }


            //Update the visuals.

            //Totaltimer
            mainInstance.la_totalTimer.Text = timeVisualized.Item1 + ":" + timeVisualized.Item2 + ":" + timeVisualized.Item3;

            //Episodetimer
            //Episodetimer may depend on wether we are breaking right now
           
            Tuple<string, string, string> episodeTimerVisualized = timeVisualiser(episodeTimer);
            mainInstance.la_episodeTimer.Text = episodeTimerVisualized.Item1 + ":" + episodeTimerVisualized.Item2 + ":" + episodeTimerVisualized.Item3;

            //Breaktimer
            if (currentlyBreaking)
            {
                int breakTimer = (totalTimer - currentBreak.totTimeStart);
                Tuple<string, string, string> breakTimerVisualized = timeVisualiser(breakTimer);
                mainInstance.la_breakTimer.Text = breakTimerVisualized.Item1 + ":" + breakTimerVisualized.Item2 + ":" + breakTimerVisualized.Item3;
            } else
            {
                //Breaktimer - is not breaking
                if (mainInstance.la_breakTimer.Text != "00:00:00") mainInstance.la_breakTimer.Text = "00:00:00";
            }

        }

        public static void break_start()
        {
            if (!currentlyBreaking)
            {
                //Create new breaking object
                timeTrackingBreak newBreak = new timeTrackingBreak();
                currentBreak = newBreak;

                //Add mark (break start)
                timeTrackingMark newMark = new timeTrackingMark(totalTimer, "Break #" + Convert.ToString(newBreak.breakIndex) + " started");
            }

            currentlyBreaking = true;
            mainInstance.la_status_break.ForeColor = System.Drawing.Color.Red;
        }

        public static void break_stop()
        {
            if (currentlyBreaking)
            {
                currentBreak.endBreak();
                previousBreaks.Add(currentBreak);
                

                //Add mark (break end)
                timeTrackingMark newMark = new timeTrackingMark(totalTimer, "Break #" + Convert.ToString(currentBreak.breakIndex) + " ended");

                //Reset currentbreak
                currentBreak = null;
            }

           
            currentlyBreaking = false;
            mainInstance.la_status_break.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        #endregion


        #endregion
    }

    public class timeTrackingBreak
    {

        public static int index = 0;

        public int breakIndex = 0;
        public int totTimeStart = 0;
        public int totTimeEnd = 0;


        public timeTrackingBreak()
        {
            timeTrackingBreak.index++;
            breakIndex = timeTrackingBreak.index;
            totTimeStart = TimeTracking.totalTimer;
        }

        public void endBreak()
        {
            this.totTimeEnd = TimeTracking.totalTimer; 
            TimeTracking.breakingTimeAccumulated += (this.totTimeEnd - this.totTimeStart); //Add the period of break to accumulated break time
        }

  
    }

    public class timeTrackingMark
    {


        public static int index = 0;

        public int localIndex = 0;
        public int time = 0;
        public string timeStamp = "";
        public string reason = "";

        public timeTrackingMark(int time, string reason = "N/A")
        {
            timeTrackingMark.index++;
            Tuple<string, string, string> markTimeVisualized = TimeTracking.timeVisualiser(time);

            this.localIndex = timeTrackingMark.index;
            this.time = time;
            this.reason = reason;
            this.timeStamp = markTimeVisualized.Item1 + ":" + markTimeVisualized.Item2 + ":" + markTimeVisualized.Item3;




            TimeTracking.mainInstance.dgv_marks.Rows.Add(Convert.ToString(this.localIndex), this.timeStamp, this.reason);
            TimeTracking.marks.Add(this);
        }

       
    }
}
