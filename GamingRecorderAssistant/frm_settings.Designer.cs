namespace GamingRecorderAssistant
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.gb_deadline = new System.Windows.Forms.GroupBox();
            this.tb_deadline_ss = new System.Windows.Forms.TextBox();
            this.la_deadline_mm_split = new System.Windows.Forms.Label();
            this.tb_deadline_mm = new System.Windows.Forms.TextBox();
            this.la_deadline_hh_split = new System.Windows.Forms.Label();
            this.tb_deadline_hh = new System.Windows.Forms.TextBox();
            this.la_deadline_exp = new System.Windows.Forms.Label();
            this.cb_deadline = new System.Windows.Forms.CheckBox();
            this.bt_settings_save = new System.Windows.Forms.Button();
            this.la_settings_exp = new System.Windows.Forms.Label();
            this.gb_precut = new System.Windows.Forms.GroupBox();
            this.tb_precut_ss = new System.Windows.Forms.TextBox();
            this.tb_precut_mm_split = new System.Windows.Forms.Label();
            this.tb_precut_mm = new System.Windows.Forms.TextBox();
            this.tb_precut_hh_split = new System.Windows.Forms.Label();
            this.tb_precut_hh = new System.Windows.Forms.TextBox();
            this.cb_precut_start = new System.Windows.Forms.CheckBox();
            this.gb_deadline.SuspendLayout();
            this.gb_precut.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_deadline
            // 
            this.gb_deadline.Controls.Add(this.tb_deadline_ss);
            this.gb_deadline.Controls.Add(this.la_deadline_mm_split);
            this.gb_deadline.Controls.Add(this.tb_deadline_mm);
            this.gb_deadline.Controls.Add(this.la_deadline_hh_split);
            this.gb_deadline.Controls.Add(this.tb_deadline_hh);
            this.gb_deadline.Controls.Add(this.la_deadline_exp);
            this.gb_deadline.Controls.Add(this.cb_deadline);
            this.gb_deadline.Location = new System.Drawing.Point(12, 43);
            this.gb_deadline.Name = "gb_deadline";
            this.gb_deadline.Size = new System.Drawing.Size(415, 86);
            this.gb_deadline.TabIndex = 0;
            this.gb_deadline.TabStop = false;
            this.gb_deadline.Text = "Deadline";
            // 
            // tb_deadline_ss
            // 
            this.tb_deadline_ss.Location = new System.Drawing.Point(106, 55);
            this.tb_deadline_ss.Name = "tb_deadline_ss";
            this.tb_deadline_ss.Size = new System.Drawing.Size(28, 20);
            this.tb_deadline_ss.TabIndex = 6;
            this.tb_deadline_ss.Text = "00";
            // 
            // la_deadline_mm_split
            // 
            this.la_deadline_mm_split.AutoSize = true;
            this.la_deadline_mm_split.Location = new System.Drawing.Point(90, 58);
            this.la_deadline_mm_split.Name = "la_deadline_mm_split";
            this.la_deadline_mm_split.Size = new System.Drawing.Size(10, 13);
            this.la_deadline_mm_split.TabIndex = 5;
            this.la_deadline_mm_split.Text = ":";
            // 
            // tb_deadline_mm
            // 
            this.tb_deadline_mm.Location = new System.Drawing.Point(56, 55);
            this.tb_deadline_mm.Name = "tb_deadline_mm";
            this.tb_deadline_mm.Size = new System.Drawing.Size(28, 20);
            this.tb_deadline_mm.TabIndex = 4;
            this.tb_deadline_mm.Text = "00";
            // 
            // la_deadline_hh_split
            // 
            this.la_deadline_hh_split.AutoSize = true;
            this.la_deadline_hh_split.Location = new System.Drawing.Point(40, 58);
            this.la_deadline_hh_split.Name = "la_deadline_hh_split";
            this.la_deadline_hh_split.Size = new System.Drawing.Size(10, 13);
            this.la_deadline_hh_split.TabIndex = 3;
            this.la_deadline_hh_split.Text = ":";
            // 
            // tb_deadline_hh
            // 
            this.tb_deadline_hh.Location = new System.Drawing.Point(6, 55);
            this.tb_deadline_hh.Name = "tb_deadline_hh";
            this.tb_deadline_hh.Size = new System.Drawing.Size(28, 20);
            this.tb_deadline_hh.TabIndex = 2;
            this.tb_deadline_hh.Text = "00";
            // 
            // la_deadline_exp
            // 
            this.la_deadline_exp.AutoSize = true;
            this.la_deadline_exp.Location = new System.Drawing.Point(3, 39);
            this.la_deadline_exp.Name = "la_deadline_exp";
            this.la_deadline_exp.Size = new System.Drawing.Size(106, 13);
            this.la_deadline_exp.TabIndex = 1;
            this.la_deadline_exp.Text = "Deadline HH:MM:SS";
            // 
            // cb_deadline
            // 
            this.cb_deadline.AutoSize = true;
            this.cb_deadline.Location = new System.Drawing.Point(6, 19);
            this.cb_deadline.Name = "cb_deadline";
            this.cb_deadline.Size = new System.Drawing.Size(115, 17);
            this.cb_deadline.TabIndex = 0;
            this.cb_deadline.Text = "Deadline activated";
            this.cb_deadline.UseVisualStyleBackColor = true;
            // 
            // bt_settings_save
            // 
            this.bt_settings_save.Location = new System.Drawing.Point(12, 210);
            this.bt_settings_save.Name = "bt_settings_save";
            this.bt_settings_save.Size = new System.Drawing.Size(415, 38);
            this.bt_settings_save.TabIndex = 1;
            this.bt_settings_save.Text = "Save and continue";
            this.bt_settings_save.UseVisualStyleBackColor = true;
            this.bt_settings_save.Click += new System.EventHandler(this.bt_settings_save_Click);
            // 
            // la_settings_exp
            // 
            this.la_settings_exp.AutoSize = true;
            this.la_settings_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_settings_exp.Location = new System.Drawing.Point(15, 9);
            this.la_settings_exp.Name = "la_settings_exp";
            this.la_settings_exp.Size = new System.Drawing.Size(201, 31);
            this.la_settings_exp.TabIndex = 2;
            this.la_settings_exp.Text = "Project settings";
            // 
            // gb_precut
            // 
            this.gb_precut.Controls.Add(this.cb_precut_start);
            this.gb_precut.Controls.Add(this.tb_precut_ss);
            this.gb_precut.Controls.Add(this.tb_precut_mm_split);
            this.gb_precut.Controls.Add(this.tb_precut_mm);
            this.gb_precut.Controls.Add(this.tb_precut_hh_split);
            this.gb_precut.Controls.Add(this.tb_precut_hh);
            this.gb_precut.Location = new System.Drawing.Point(12, 135);
            this.gb_precut.Name = "gb_precut";
            this.gb_precut.Size = new System.Drawing.Size(415, 69);
            this.gb_precut.TabIndex = 3;
            this.gb_precut.TabStop = false;
            this.gb_precut.Text = "Pre-cut";
            // 
            // tb_precut_ss
            // 
            this.tb_precut_ss.Location = new System.Drawing.Point(109, 43);
            this.tb_precut_ss.Name = "tb_precut_ss";
            this.tb_precut_ss.Size = new System.Drawing.Size(28, 20);
            this.tb_precut_ss.TabIndex = 11;
            this.tb_precut_ss.Text = "00";
            // 
            // tb_precut_mm_split
            // 
            this.tb_precut_mm_split.AutoSize = true;
            this.tb_precut_mm_split.Location = new System.Drawing.Point(93, 46);
            this.tb_precut_mm_split.Name = "tb_precut_mm_split";
            this.tb_precut_mm_split.Size = new System.Drawing.Size(10, 13);
            this.tb_precut_mm_split.TabIndex = 10;
            this.tb_precut_mm_split.Text = ":";
            // 
            // tb_precut_mm
            // 
            this.tb_precut_mm.Location = new System.Drawing.Point(59, 43);
            this.tb_precut_mm.Name = "tb_precut_mm";
            this.tb_precut_mm.Size = new System.Drawing.Size(28, 20);
            this.tb_precut_mm.TabIndex = 9;
            this.tb_precut_mm.Text = "00";
            // 
            // tb_precut_hh_split
            // 
            this.tb_precut_hh_split.AutoSize = true;
            this.tb_precut_hh_split.Location = new System.Drawing.Point(43, 46);
            this.tb_precut_hh_split.Name = "tb_precut_hh_split";
            this.tb_precut_hh_split.Size = new System.Drawing.Size(10, 13);
            this.tb_precut_hh_split.TabIndex = 8;
            this.tb_precut_hh_split.Text = ":";
            // 
            // tb_precut_hh
            // 
            this.tb_precut_hh.Location = new System.Drawing.Point(9, 43);
            this.tb_precut_hh.Name = "tb_precut_hh";
            this.tb_precut_hh.Size = new System.Drawing.Size(28, 20);
            this.tb_precut_hh.TabIndex = 7;
            this.tb_precut_hh.Text = "00";
            // 
            // cb_precut_start
            // 
            this.cb_precut_start.AutoSize = true;
            this.cb_precut_start.Checked = true;
            this.cb_precut_start.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_precut_start.Location = new System.Drawing.Point(6, 19);
            this.cb_precut_start.Name = "cb_precut_start";
            this.cb_precut_start.Size = new System.Drawing.Size(118, 17);
            this.cb_precut_start.TabIndex = 12;
            this.cb_precut_start.Text = "Removed from start";
            this.cb_precut_start.UseVisualStyleBackColor = true;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 260);
            this.Controls.Add(this.gb_precut);
            this.Controls.Add(this.la_settings_exp);
            this.Controls.Add(this.bt_settings_save);
            this.Controls.Add(this.gb_deadline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GRA - Project Settings";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.gb_deadline.ResumeLayout(false);
            this.gb_deadline.PerformLayout();
            this.gb_precut.ResumeLayout(false);
            this.gb_precut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_deadline;
        private System.Windows.Forms.CheckBox cb_deadline;
        private System.Windows.Forms.Label la_deadline_exp;
        private System.Windows.Forms.TextBox tb_deadline_ss;
        private System.Windows.Forms.Label la_deadline_mm_split;
        private System.Windows.Forms.TextBox tb_deadline_mm;
        private System.Windows.Forms.Label la_deadline_hh_split;
        private System.Windows.Forms.TextBox tb_deadline_hh;
        private System.Windows.Forms.Button bt_settings_save;
        private System.Windows.Forms.Label la_settings_exp;
        private System.Windows.Forms.GroupBox gb_precut;
        private System.Windows.Forms.TextBox tb_precut_ss;
        private System.Windows.Forms.Label tb_precut_mm_split;
        private System.Windows.Forms.TextBox tb_precut_mm;
        private System.Windows.Forms.Label tb_precut_hh_split;
        private System.Windows.Forms.TextBox tb_precut_hh;
        private System.Windows.Forms.CheckBox cb_precut_start;
    }
}