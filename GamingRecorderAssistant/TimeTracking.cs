using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingRecorderAssistant
{

    public static class TimeTracking
    {

        public enum timeTrackingStates
        {
            inactive, tracking
        }

        #region vars
        public static frm_main mainInstance = null;
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



        #endregion

        #region functions
        #region common-functions
        public static Tuple<string, string, string> timeVisualiser(int totalseconds)
        {

            //HOURS
            int totalTimerWorking = totalseconds;

            int hours = (int)Math.Floor((decimal)(totalTimer / 60 / 60));
            totalTimerWorking = (totalTimerWorking - (hours * 60 * 60));

            int minutes = (int)Math.Floor((decimal)(totalTimer / 60));
            totalTimerWorking = (totalTimerWorking - (minutes * 60));

            int seconds = totalTimerWorking;

            //Convert to string and (add leading zeroes)
            Tuple<string, string, string> returnvalue = new Tuple<string, string, string>((hours >= 10 ? Convert.ToString(hours) : "0" + Convert.ToString(hours)), (minutes >= 10 ? Convert.ToString(minutes) : "0" + Convert.ToString(minutes)), (seconds >= 10 ? Convert.ToString(seconds) : "0" + Convert.ToString(seconds)));
            return returnvalue;
        }
        #endregion

        public static void recording_start()
        {
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
            Tuple<string, string, string> timeVisualized = timeVisualiser(totalTimer);


            //Update the visuals.

            //Totaltimer
            mainInstance.la_totalTimer.Text = timeVisualized.Item1 + ":" + timeVisualized.Item2 + ":" + timeVisualized.Item3;

            //Episodetimer
            //Episodetimer may depend on wether we are breaking right now
            int episodeTimer = (totalTimer - breakingTimeAccumulated);
            if (currentlyBreaking) episodeTimer -= (totalTimer - currentBreak.totTimeStart);
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
    }

    public class timeTrackingBreak {

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
        public timeTrackingMark(int time, string reason = "N/A")
        {
            timeTrackingMark.index++;
            Tuple<string, string, string> markTimeVisualized = TimeTracking.timeVisualiser(time);
            TimeTracking.mainInstance.dgv_marks.Rows.Add(Convert.ToString(timeTrackingMark.index), markTimeVisualized.Item1 + ":" + markTimeVisualized.Item2 + ":" + markTimeVisualized.Item3, reason);
        }
    }
}
