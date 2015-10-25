namespace GamingRecorderAssistant
{
    partial class frm_programSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_programSettings));
            this.la_settings_exp = new System.Windows.Forms.Label();
            this.gb_keybinds = new System.Windows.Forms.GroupBox();
            this.la_keybind_record_exp = new System.Windows.Forms.Label();
            this.cb_keybind_recording_ctrl = new System.Windows.Forms.CheckBox();
            this.cb_keybind_recording_shift = new System.Windows.Forms.CheckBox();
            this.cb_keybind_recording_alt = new System.Windows.Forms.CheckBox();
            this.cmbx_keybind_recording_mainKey = new System.Windows.Forms.ComboBox();
            this.cmbx_keybind_break_mainKey = new System.Windows.Forms.ComboBox();
            this.cb_keybind_break_alt = new System.Windows.Forms.CheckBox();
            this.cb_keybind_break_shift = new System.Windows.Forms.CheckBox();
            this.cb_keybind_break_ctrl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_settings_save = new System.Windows.Forms.Button();
            this.gb_keybinds.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_settings_exp
            // 
            this.la_settings_exp.AutoSize = true;
            this.la_settings_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_settings_exp.Location = new System.Drawing.Point(13, 9);
            this.la_settings_exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_settings_exp.Name = "la_settings_exp";
            this.la_settings_exp.Size = new System.Drawing.Size(362, 39);
            this.la_settings_exp.TabIndex = 3;
            this.la_settings_exp.Text = "GRA Program Settings";
            // 
            // gb_keybinds
            // 
            this.gb_keybinds.Controls.Add(this.cmbx_keybind_break_mainKey);
            this.gb_keybinds.Controls.Add(this.cb_keybind_break_alt);
            this.gb_keybinds.Controls.Add(this.cb_keybind_break_shift);
            this.gb_keybinds.Controls.Add(this.cb_keybind_break_ctrl);
            this.gb_keybinds.Controls.Add(this.label1);
            this.gb_keybinds.Controls.Add(this.cmbx_keybind_recording_mainKey);
            this.gb_keybinds.Controls.Add(this.cb_keybind_recording_alt);
            this.gb_keybinds.Controls.Add(this.cb_keybind_recording_shift);
            this.gb_keybinds.Controls.Add(this.cb_keybind_recording_ctrl);
            this.gb_keybinds.Controls.Add(this.la_keybind_record_exp);
            this.gb_keybinds.Location = new System.Drawing.Point(20, 51);
            this.gb_keybinds.Name = "gb_keybinds";
            this.gb_keybinds.Size = new System.Drawing.Size(529, 137);
            this.gb_keybinds.TabIndex = 4;
            this.gb_keybinds.TabStop = false;
            this.gb_keybinds.Text = "Keybinds";
            // 
            // la_keybind_record_exp
            // 
            this.la_keybind_record_exp.AutoSize = true;
            this.la_keybind_record_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_keybind_record_exp.Location = new System.Drawing.Point(6, 18);
            this.la_keybind_record_exp.Name = "la_keybind_record_exp";
            this.la_keybind_record_exp.Size = new System.Drawing.Size(168, 17);
            this.la_keybind_record_exp.TabIndex = 0;
            this.la_keybind_record_exp.Text = "Recording (start/stop)";
            // 
            // cb_keybind_recording_ctrl
            // 
            this.cb_keybind_recording_ctrl.AutoSize = true;
            this.cb_keybind_recording_ctrl.Location = new System.Drawing.Point(9, 38);
            this.cb_keybind_recording_ctrl.Name = "cb_keybind_recording_ctrl";
            this.cb_keybind_recording_ctrl.Size = new System.Drawing.Size(75, 21);
            this.cb_keybind_recording_ctrl.TabIndex = 1;
            this.cb_keybind_recording_ctrl.Text = "Control";
            this.cb_keybind_recording_ctrl.UseVisualStyleBackColor = true;
            // 
            // cb_keybind_recording_shift
            // 
            this.cb_keybind_recording_shift.AutoSize = true;
            this.cb_keybind_recording_shift.Location = new System.Drawing.Point(90, 38);
            this.cb_keybind_recording_shift.Name = "cb_keybind_recording_shift";
            this.cb_keybind_recording_shift.Size = new System.Drawing.Size(58, 21);
            this.cb_keybind_recording_shift.TabIndex = 2;
            this.cb_keybind_recording_shift.Text = "Shift";
            this.cb_keybind_recording_shift.UseVisualStyleBackColor = true;
            // 
            // cb_keybind_recording_alt
            // 
            this.cb_keybind_recording_alt.AutoSize = true;
            this.cb_keybind_recording_alt.Location = new System.Drawing.Point(154, 38);
            this.cb_keybind_recording_alt.Name = "cb_keybind_recording_alt";
            this.cb_keybind_recording_alt.Size = new System.Drawing.Size(46, 21);
            this.cb_keybind_recording_alt.TabIndex = 3;
            this.cb_keybind_recording_alt.Text = "Alt";
            this.cb_keybind_recording_alt.UseVisualStyleBackColor = true;
            // 
            // cmbx_keybind_recording_mainKey
            // 
            this.cmbx_keybind_recording_mainKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbx_keybind_recording_mainKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbx_keybind_recording_mainKey.FormattingEnabled = true;
            this.cmbx_keybind_recording_mainKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "Numpad 0 ",
            "Numpad 1",
            "Numpad 2",
            "Numpad 3",
            "Numpad 4 ",
            "Numpad 5",
            "Numpad 6",
            "Numpad 7",
            "Numpad 8 ",
            "Numpad 9"});
            this.cmbx_keybind_recording_mainKey.Location = new System.Drawing.Point(206, 36);
            this.cmbx_keybind_recording_mainKey.Name = "cmbx_keybind_recording_mainKey";
            this.cmbx_keybind_recording_mainKey.Size = new System.Drawing.Size(121, 24);
            this.cmbx_keybind_recording_mainKey.TabIndex = 4;
            this.cmbx_keybind_recording_mainKey.Text = "Numpad 1";
            // 
            // cmbx_keybind_break_mainKey
            // 
            this.cmbx_keybind_break_mainKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbx_keybind_break_mainKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbx_keybind_break_mainKey.FormattingEnabled = true;
            this.cmbx_keybind_break_mainKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "Numpad 0 ",
            "Numpad 1",
            "Numpad 2",
            "Numpad 3",
            "Numpad 4 ",
            "Numpad 5",
            "Numpad 6",
            "Numpad 7",
            "Numpad 8 ",
            "Numpad 9"});
            this.cmbx_keybind_break_mainKey.Location = new System.Drawing.Point(206, 80);
            this.cmbx_keybind_break_mainKey.Name = "cmbx_keybind_break_mainKey";
            this.cmbx_keybind_break_mainKey.Size = new System.Drawing.Size(121, 24);
            this.cmbx_keybind_break_mainKey.TabIndex = 9;
            this.cmbx_keybind_break_mainKey.Text = "Numpad 2";
            // 
            // cb_keybind_break_alt
            // 
            this.cb_keybind_break_alt.AutoSize = true;
            this.cb_keybind_break_alt.Location = new System.Drawing.Point(154, 82);
            this.cb_keybind_break_alt.Name = "cb_keybind_break_alt";
            this.cb_keybind_break_alt.Size = new System.Drawing.Size(46, 21);
            this.cb_keybind_break_alt.TabIndex = 8;
            this.cb_keybind_break_alt.Text = "Alt";
            this.cb_keybind_break_alt.UseVisualStyleBackColor = true;
            // 
            // cb_keybind_break_shift
            // 
            this.cb_keybind_break_shift.AutoSize = true;
            this.cb_keybind_break_shift.Location = new System.Drawing.Point(90, 82);
            this.cb_keybind_break_shift.Name = "cb_keybind_break_shift";
            this.cb_keybind_break_shift.Size = new System.Drawing.Size(58, 21);
            this.cb_keybind_break_shift.TabIndex = 7;
            this.cb_keybind_break_shift.Text = "Shift";
            this.cb_keybind_break_shift.UseVisualStyleBackColor = true;
            // 
            // cb_keybind_break_ctrl
            // 
            this.cb_keybind_break_ctrl.AutoSize = true;
            this.cb_keybind_break_ctrl.Location = new System.Drawing.Point(9, 82);
            this.cb_keybind_break_ctrl.Name = "cb_keybind_break_ctrl";
            this.cb_keybind_break_ctrl.Size = new System.Drawing.Size(75, 21);
            this.cb_keybind_break_ctrl.TabIndex = 6;
            this.cb_keybind_break_ctrl.Text = "Control";
            this.cb_keybind_break_ctrl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Break (start/stop)";
            // 
            // bt_settings_save
            // 
            this.bt_settings_save.Location = new System.Drawing.Point(20, 195);
            this.bt_settings_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_settings_save.Name = "bt_settings_save";
            this.bt_settings_save.Size = new System.Drawing.Size(529, 47);
            this.bt_settings_save.TabIndex = 5;
            this.bt_settings_save.Text = "Save and continue";
            this.bt_settings_save.UseVisualStyleBackColor = true;
            this.bt_settings_save.Click += new System.EventHandler(this.bt_settings_save_Click);
            // 
            // frm_programSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 259);
            this.Controls.Add(this.bt_settings_save);
            this.Controls.Add(this.gb_keybinds);
            this.Controls.Add(this.la_settings_exp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_programSettings";
            this.Text = "GRA Program Settings";
            this.Load += new System.EventHandler(this.frm_programSettings_Load);
            this.gb_keybinds.ResumeLayout(false);
            this.gb_keybinds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_settings_exp;
        private System.Windows.Forms.GroupBox gb_keybinds;
        private System.Windows.Forms.Label la_keybind_record_exp;
        private System.Windows.Forms.CheckBox cb_keybind_recording_ctrl;
        private System.Windows.Forms.CheckBox cb_keybind_recording_alt;
        private System.Windows.Forms.CheckBox cb_keybind_recording_shift;
        private System.Windows.Forms.ComboBox cmbx_keybind_recording_mainKey;
        private System.Windows.Forms.ComboBox cmbx_keybind_break_mainKey;
        private System.Windows.Forms.CheckBox cb_keybind_break_alt;
        private System.Windows.Forms.CheckBox cb_keybind_break_shift;
        private System.Windows.Forms.CheckBox cb_keybind_break_ctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_settings_save;
    }
}