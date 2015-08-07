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
        }

        private void bt_settings_save_Click(object sender, EventArgs e)
        {
            config newConfig = new config();
            newConfig.deadline = cb_deadline.Checked;

            //Convert hours, minutes, seconds to seconds
            int hours = 0, minutes = 0, seconds = 0;
            int totalSeconds = 0;

            //Validate that the numbers are numerical (int) values
            if ((!int.TryParse(tb_deadline_hh.Text, out hours)) || (!int.TryParse(tb_deadline_mm.Text, out minutes)) || (!int.TryParse(tb_deadline_ss.Text, out seconds)))
            {
                //Some of the vars are not acceptable.
                MessageBox.Show("Deadline hours, minutes and seconds must be numerical", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Convert to totalSeconds
            totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            newConfig.deadlineTimer = totalSeconds;

            
            //Config done, save and close
            TimeTracking.projectConfig = newConfig;
            TimeTracking.configLoaded();
            this.Close();

        }
    }
}
