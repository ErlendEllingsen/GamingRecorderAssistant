using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingRecorderAssistant
{
    public partial class frm_programSettings : Form
    {
        public frm_programSettings()
        {
            InitializeComponent();
        }

        public static Dictionary<string, int> nameToKey = new Dictionary<string, int>()
        {
            //Letters
            {"A", (int)Keys.A},  {"B", (int)Keys.B},  {"C", (int)Keys.C},  {"D", (int)Keys.D},  {"E", (int)Keys.E},  {"F", (int)Keys.F},
            {"G", (int)Keys.G},  {"H", (int)Keys.H},  {"I", (int)Keys.I},  {"J", (int)Keys.J},  {"K", (int)Keys.K}, {"L", (int)Keys.L},
            {"M", (int)Keys.M},  {"N", (int)Keys.N},  {"O", (int)Keys.O},  {"P", (int)Keys.P},  {"Q", (int)Keys.Q},  {"R", (int)Keys.R},
            {"S", (int)Keys.S},  {"T", (int)Keys.T},  {"U", (int)Keys.U},  {"V", (int)Keys.V},  {"W", (int)Keys.W},  {"X", (int)Keys.X},
            {"Y", (int)Keys.Y},  {"Z", (int)Keys.Z},

            //Numbers
            {"0", (int)Keys.D0 },{"1", (int)Keys.D1 },{"2", (int)Keys.D2 },{"3", (int)Keys.D3 },{"4", (int)Keys.D4 },{"5", (int)Keys.D5 },
            {"6", (int)Keys.D6 },{"7", (int)Keys.D7 },{"8", (int)Keys.D8 },{"9", (int)Keys.D9 },

            //Numpad 
            {"Numpad 0", (int)Keys.NumPad0 },{"Numpad 1", (int)Keys.NumPad1 },{"Numpad 2", (int)Keys.NumPad2 },{"Numpad 3", (int)Keys.NumPad3 },{"Numpad 4", (int)Keys.NumPad4 },{"Numpad 5", (int)Keys.NumPad5 },
            {"Numpad 6", (int)Keys.NumPad6},{"Numpad 7", (int)Keys.NumPad7 },{"Numpad 8", (int)Keys.NumPad8 },{"Numpad 9", (int)Keys.NumPad9},
        };

        public static Tuple<int, int> getKeyBindSum(bool ctrl, bool shift, bool alt, string mainKey)
        {
            int keySum = 0;
            int modifiserSum = 0;

            if (ctrl) modifiserSum += frm_main.MOD_CONTROL;
            if (shift) modifiserSum += frm_main.MOD_SHIFT;
            if (alt) modifiserSum += frm_main.MOD_ALT;
            keySum += frm_programSettings.nameToKey[mainKey.Trim()];
            return new Tuple<int, int>(keySum, modifiserSum);
        }

        private void frm_programSettings_Load(object sender, EventArgs e)
        {
            //Load values.
            cb_keybind_recording_ctrl.Checked = TimeTracking.programConfig.recording_ctrl;
            cb_keybind_recording_shift.Checked = TimeTracking.programConfig.recording_shift;
            cb_keybind_recording_alt.Checked = TimeTracking.programConfig.recording_alt;
            cmbx_keybind_recording_mainKey.Text = TimeTracking.programConfig.recording_mainKey;

            cb_keybind_break_ctrl.Checked = TimeTracking.programConfig.break_ctrl;
            cb_keybind_break_shift.Checked = TimeTracking.programConfig.break_shift;
            cb_keybind_break_alt.Checked = TimeTracking.programConfig.break_alt;
            cmbx_keybind_break_mainKey.Text = TimeTracking.programConfig.break_mainkey;
        }

        private void bt_settings_save_Click(object sender, EventArgs e)
        {
            Tuple<int, int> keybind_recording = getKeyBindSum(cb_keybind_recording_ctrl.Checked, cb_keybind_recording_shift.Checked, cb_keybind_recording_alt.Checked, cmbx_keybind_recording_mainKey.Text);
            Tuple<int, int> keybind_break = getKeyBindSum(cb_keybind_break_ctrl.Checked, cb_keybind_break_shift.Checked, cb_keybind_break_alt.Checked, cmbx_keybind_break_mainKey.Text);

         
            //Write config to file.
            //Write values 
            TimeTracking.programConfig.keyBindSumRecording = keybind_recording.Item1;
            TimeTracking.programConfig.keyBindModifierSumRecording = keybind_recording.Item2;
            TimeTracking.programConfig.keyBindSumBreak = keybind_break.Item1;
            TimeTracking.programConfig.keyBindModifierSumBreak = keybind_break.Item2;

            //Connect controls
            TimeTracking.programConfig.recording_ctrl = cb_keybind_recording_ctrl.Checked;
            TimeTracking.programConfig.recording_shift = cb_keybind_recording_shift.Checked;
            TimeTracking.programConfig.recording_alt = cb_keybind_recording_alt.Checked;
            TimeTracking.programConfig.recording_mainKey = cmbx_keybind_recording_mainKey.Text;

            TimeTracking.programConfig.break_ctrl = cb_keybind_break_ctrl.Checked;
            TimeTracking.programConfig.break_shift = cb_keybind_break_shift.Checked;
            TimeTracking.programConfig.break_alt = cb_keybind_break_alt.Checked;
            TimeTracking.programConfig.break_mainkey = cmbx_keybind_break_mainKey.Text;

            using (StreamWriter sw = new StreamWriter(Application.UserAppDataPath + "\\GamingRecorderAssistant.gracfg"))
            {
                sw.Write(programConfig.SerializeObject(TimeTracking.programConfig));
            }

            MessageBox.Show("Program settings saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult sr = MessageBox.Show("Keybindings will require a application restart, restart now?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sr == DialogResult.Yes)
            {
                Application.Restart();
            }

            this.Close();

        }
    }
}
