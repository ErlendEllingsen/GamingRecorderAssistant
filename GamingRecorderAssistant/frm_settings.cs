using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingRecorderAssistant
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            //LOAD from config
            if (TimeTracking.projectConfig == null) return;

            //DEADLINE
            cb_deadline.Checked = TimeTracking.projectConfig.deadline;

            //Convert from totalSeconds to hours
            Tuple<string, string, string> deadlineTimerVisualized = TimeTracking.timeVisualiser(TimeTracking.projectConfig.deadlineTimer);
            //Set the visuals.
            tb_deadline_hh.Text = deadlineTimerVisualized.Item1;
            tb_deadline_mm.Text = deadlineTimerVisualized.Item2;
            tb_deadline_ss.Text = deadlineTimerVisualized.Item3;

            //PRECUT
            cb_precut_start.Checked = TimeTracking.projectConfig.precutFromStart;

            Tuple<string, string, string> precutTimerVisualized = TimeTracking.timeVisualiser(TimeTracking.projectConfig.precutTimer);
            //Set the visuals.
            tb_precut_hh.Text = precutTimerVisualized.Item1;
            tb_precut_mm.Text = precutTimerVisualized.Item2;
            tb_precut_ss.Text = precutTimerVisualized.Item3;

        }

        private void bt_settings_save_Click(object sender, EventArgs e)
        {
            if (TimeTracking.projectConfig == null) { TimeTracking.projectConfig = new config();  }
            TimeTracking.projectConfig.deadline = cb_deadline.Checked;

            //DEADLINE 
            //Convert hours, minutes, seconds to seconds
            int hours = 0, minutes = 0, seconds = 0;
            int deadLineTotalSeconds = 0, precutTotalSeconds = 0;

            //Validate that the numbers are numerical (int) values
            if ((!int.TryParse(tb_deadline_hh.Text, out hours)) || (!int.TryParse(tb_deadline_mm.Text, out minutes)) || (!int.TryParse(tb_deadline_ss.Text, out seconds)))
            {
                //Some of the vars are not acceptable.
                MessageBox.Show("Deadline hours, minutes and seconds must be numerical", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Convert to totalSeconds
            deadLineTotalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            TimeTracking.projectConfig.deadlineTimer = deadLineTotalSeconds;

            //PRE-CUT
            TimeTracking.projectConfig.precutFromStart = cb_precut_start.Checked;
            
            //Validate that the numbers are numerical (int) values
            if ((!int.TryParse(tb_precut_hh.Text, out hours)) || (!int.TryParse(tb_precut_mm.Text, out minutes)) || (!int.TryParse(tb_precut_ss.Text, out seconds)))
            {
                //Some of the vars are not acceptable.
                MessageBox.Show("Pre-cut hours, minutes and seconds must be numerical", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Convert to totalSeconds
            precutTotalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            TimeTracking.projectConfig.precutTimer = precutTotalSeconds;

            //Config done, save and close
            TimeTracking.configLoaded();
            this.Close();

        }
    }
}
