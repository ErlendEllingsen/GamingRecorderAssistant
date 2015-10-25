using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingRecorderAssistant
{
    public partial class frm_main : Form
    {

        public frm_about aboutInst = null;
        

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Load program settings file.
            if (!File.Exists(Application.UserAppDataPath + "\\GamingRecorderAssistant.gracfg")) {
                TimeTracking.programConfig = new programConfig();
            } else {
                //The program file exists, load the program config.
                string configContent = "";
                using (StreamReader sr = new StreamReader(Application.UserAppDataPath + "\\GamingRecorderAssistant.gracfg"))
                {
                    configContent = sr.ReadToEnd();
                }

                programConfig loadedConfig = (programConfig)programConfig.DeserializeObject<programConfig>(configContent);
                TimeTracking.programConfig = loadedConfig;
                //Config loaded.

            }


            RegisterHotKey(Handle, 1, TimeTracking.programConfig.keyBindModifierSumRecording, TimeTracking.programConfig.keyBindSumRecording);
            RegisterHotKey(Handle, 2, TimeTracking.programConfig.keyBindModifierSumBreak, TimeTracking.programConfig.keyBindSumBreak);
            


            TimeTracking.newProject();
            
            
        }


        #region hotkeys-code 

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        public const int MOD_ALT = 0x0001;
        public const int MOD_CONTROL = 0x0002;
        public const int MOD_SHIFT = 0x0004;
        public const int WM_HOTKEY = 0x0312;

        protected override void WndProc(ref Message m)
        {
            /*if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
               MessageBox.Show("Hotkey X pressed.");
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
                MessageBox.Show("Hotkey Y pressed.");
           */


            //START/STOP TRACKING
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
            {
                //NUMPAD1
                if (TimeTracking.currentTrackingState == TimeTracking.timeTrackingStates.inactive)
                {
                    TimeTracking.recording_start();
                } else if (TimeTracking.currentTrackingState == TimeTracking.timeTrackingStates.tracking)
                {
                    TimeTracking.recording_stop();
                }
            }

            //BREAKS!
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
            {
                if (TimeTracking.currentlyBreaking)
                {
                    TimeTracking.break_stop();
                } else
                {
                    TimeTracking.break_start();
                }
            }


            //MARKS!

            base.WndProc(ref m);
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
        }

        #endregion

        #region hidden
        private void timer_tracker_Tick(object sender, EventArgs e)
        {
            TimeTracking.tracker_tick();
        }

        private void tm_blinkTimer_Tick(object sender, EventArgs e)
        {

            //BLINKTIMER: BREAK
            if (TimeTracking.currentlyBreaking)
            {
                la_status_break.Visible = (la_status_break.Visible ? false : true);
            } else
            {
                if (!la_status_break.Visible) la_status_break.Visible = true;
            }

            //BLINKTIMER: DEADLINE
            if (TimeTracking.currentDeadlineState == TimeTracking.deadlineStates.redblink || TimeTracking.currentDeadlineState == TimeTracking.deadlineStates.yellowblink)
            {
                la_status_deadline.Visible = (la_status_deadline.Visible ? false : true);
            }
      
                
        }

        #endregion

        #region GUI 
        private void menu_file_new_Click(object sender, EventArgs e)
        {
            TimeTracking.newProject();
        }

        public void resetGUI()
        {
            //Reset GUI
            dgv_marks.Rows.Clear();

            //GUI: status
            la_breakTimer.Text = "00:00:00";
            la_totalTimer.Text = "00:00:00";
            la_episodeTimer.Text = "00:00:00";
            la_status_inactive.ForeColor = System.Drawing.Color.White;
            la_status_tracking.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            la_status_break.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            la_status_deadline.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

    #endregion

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TRIGGERS
        private void menu_file_save_Click(object sender, EventArgs e)
        {
            sfd_saveTracking.ShowDialog();
        }

        private void menu_file_load_Click(object sender, EventArgs e)
        {
            ofd_openTracking.ShowDialog();
        }

        //ACTUAL EVENTS
        private void ofd_openTracking_FileOk(object sender, CancelEventArgs e)
        {

            string filePath = ofd_openTracking.FileName;
            TimeTracking.openProject(filePath);

        }

        private void sfd_saveTracking_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = sfd_saveTracking.FileName;
            TimeTracking.saveProject(filePath);
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            aboutInst = new frm_about();
            aboutInst.Show();
        }

        private void menu_file_projectSettings_Click(object sender, EventArgs e)
        {
            if (TimeTracking.settingsInstance != null && TimeTracking.settingsInstance.Visible)
            {
                TimeTracking.settingsInstance.Close();
            }

            TimeTracking.settingsInstance = new frm_settings();
            TimeTracking.settingsInstance.Show();

        }

        private void menu_file_programSettings_Click(object sender, EventArgs e)
        {
            if (TimeTracking.programSettingsInstance != null && TimeTracking.programSettingsInstance.Visible)
            {
                TimeTracking.programSettingsInstance.Close();
            }

            TimeTracking.programSettingsInstance = new frm_programSettings();
            TimeTracking.programSettingsInstance.Show();
        }

        private void menu_precut_set_Click(object sender, EventArgs e)
        {

        }

        public void dgv_marks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = dgv_marks.CurrentRow.Index;
            if (dgv_marks.CurrentCell == dgv_marks.Rows[dgv_marks.CurrentRow.Index].Cells["Removed"])
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dgv_marks.CurrentCell;
                
                bool isChecked = (bool)checkbox.EditedFormattedValue;
                
                TimeTracking.marks[dgv_marks.CurrentRow.Index].removed = Convert.ToBoolean(isChecked);

                

                //Tell the system that the mark was removed.
                //MessageBox.Show(Convert.ToString(TimeTracking.marks[dgv_marks.CurrentRow.Index].timeStamp)); 
                TimeTracking.redrawMarks();
                dgv_marks.Rows[currentIndex].Selected = true;
            }
            
            
        }

        
    }



}
