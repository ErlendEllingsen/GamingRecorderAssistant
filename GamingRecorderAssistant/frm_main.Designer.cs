namespace GamingRecorderAssistant
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.la_episodeTimer = new System.Windows.Forms.Label();
            this.la_totalTimer = new System.Windows.Forms.Label();
            this.la_status_inactive = new System.Windows.Forms.Label();
            this.la_status_tracking = new System.Windows.Forms.Label();
            this.la_status_break = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_tracker = new System.Windows.Forms.Timer(this.components);
            this.la_status_deadline = new System.Windows.Forms.Label();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.la_breakTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tm_blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_marks = new System.Windows.Forms.DataGridView();
            this.menu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Removed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // la_episodeTimer
            // 
            this.la_episodeTimer.AutoSize = true;
            this.la_episodeTimer.BackColor = System.Drawing.Color.Black;
            this.la_episodeTimer.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_episodeTimer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.la_episodeTimer.Location = new System.Drawing.Point(62, 0);
            this.la_episodeTimer.Name = "la_episodeTimer";
            this.la_episodeTimer.Size = new System.Drawing.Size(179, 43);
            this.la_episodeTimer.TabIndex = 0;
            this.la_episodeTimer.Text = "00:00:00";
            // 
            // la_totalTimer
            // 
            this.la_totalTimer.AutoSize = true;
            this.la_totalTimer.BackColor = System.Drawing.Color.Transparent;
            this.la_totalTimer.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_totalTimer.ForeColor = System.Drawing.Color.Gray;
            this.la_totalTimer.Location = new System.Drawing.Point(64, 41);
            this.la_totalTimer.Name = "la_totalTimer";
            this.la_totalTimer.Size = new System.Drawing.Size(135, 32);
            this.la_totalTimer.TabIndex = 1;
            this.la_totalTimer.Text = "00:00:00";
            // 
            // la_status_inactive
            // 
            this.la_status_inactive.AutoSize = true;
            this.la_status_inactive.Font = new System.Drawing.Font("Verdana", 20F);
            this.la_status_inactive.ForeColor = System.Drawing.Color.White;
            this.la_status_inactive.Location = new System.Drawing.Point(267, 11);
            this.la_status_inactive.Name = "la_status_inactive";
            this.la_status_inactive.Size = new System.Drawing.Size(146, 32);
            this.la_status_inactive.TabIndex = 3;
            this.la_status_inactive.Text = "INACTIVE";
            // 
            // la_status_tracking
            // 
            this.la_status_tracking.AutoSize = true;
            this.la_status_tracking.Font = new System.Drawing.Font("Verdana", 20F);
            this.la_status_tracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.la_status_tracking.Location = new System.Drawing.Point(267, 51);
            this.la_status_tracking.Name = "la_status_tracking";
            this.la_status_tracking.Size = new System.Drawing.Size(159, 32);
            this.la_status_tracking.TabIndex = 4;
            this.la_status_tracking.Text = "TRACKING";
            // 
            // la_status_break
            // 
            this.la_status_break.AutoSize = true;
            this.la_status_break.Font = new System.Drawing.Font("Verdana", 20F);
            this.la_status_break.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.la_status_break.Location = new System.Drawing.Point(430, 11);
            this.la_status_break.Name = "la_status_break";
            this.la_status_break.Size = new System.Drawing.Size(107, 32);
            this.la_status_break.TabIndex = 5;
            this.la_status_break.Text = "BREAK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GamingRecorderAssistant.Properties.Resources.gra_logo_526;
            this.pictureBox1.Location = new System.Drawing.Point(680, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer_tracker
            // 
            this.timer_tracker.Interval = 1000;
            this.timer_tracker.Tick += new System.EventHandler(this.timer_tracker_Tick);
            // 
            // la_status_deadline
            // 
            this.la_status_deadline.AutoSize = true;
            this.la_status_deadline.Font = new System.Drawing.Font("Verdana", 20F);
            this.la_status_deadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.la_status_deadline.Location = new System.Drawing.Point(432, 51);
            this.la_status_deadline.Name = "la_status_deadline";
            this.la_status_deadline.Size = new System.Drawing.Size(155, 32);
            this.la_status_deadline.TabIndex = 8;
            this.la_status_deadline.Text = "DEADLINE";
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.helpToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(794, 24);
            this.menu_main.TabIndex = 9;
            this.menu_main.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_new});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(37, 20);
            this.menu_file.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // la_breakTimer
            // 
            this.la_breakTimer.AutoSize = true;
            this.la_breakTimer.BackColor = System.Drawing.Color.Transparent;
            this.la_breakTimer.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_breakTimer.ForeColor = System.Drawing.Color.Gray;
            this.la_breakTimer.Location = new System.Drawing.Point(64, 73);
            this.la_breakTimer.Name = "la_breakTimer";
            this.la_breakTimer.Size = new System.Drawing.Size(135, 32);
            this.la_breakTimer.TabIndex = 10;
            this.la_breakTimer.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 43);
            this.label3.TabIndex = 11;
            this.label3.Text = "EP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "TOT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "BRK";
            // 
            // tm_blinkTimer
            // 
            this.tm_blinkTimer.Enabled = true;
            this.tm_blinkTimer.Interval = 500;
            this.tm_blinkTimer.Tick += new System.EventHandler(this.tm_blinkTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.la_episodeTimer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.la_totalTimer);
            this.panel1.Controls.Add(this.la_breakTimer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.la_status_deadline);
            this.panel1.Controls.Add(this.la_status_inactive);
            this.panel1.Controls.Add(this.la_status_break);
            this.panel1.Controls.Add(this.la_status_tracking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 121);
            this.panel1.TabIndex = 14;
            // 
            // dgv_marks
            // 
            this.dgv_marks.AllowUserToAddRows = false;
            this.dgv_marks.AllowUserToDeleteRows = false;
            this.dgv_marks.AllowUserToResizeColumns = false;
            this.dgv_marks.AllowUserToResizeRows = false;
            this.dgv_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Time,
            this.Reason,
            this.Removed});
            this.dgv_marks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_marks.Location = new System.Drawing.Point(0, 145);
            this.dgv_marks.MultiSelect = false;
            this.dgv_marks.Name = "dgv_marks";
            this.dgv_marks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_marks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_marks.Size = new System.Drawing.Size(794, 136);
            this.dgv_marks.TabIndex = 15;
            // 
            // menu_file_new
            // 
            this.menu_file_new.Name = "menu_file_new";
            this.menu_file_new.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menu_file_new.Size = new System.Drawing.Size(152, 22);
            this.menu_file_new.Text = "New";
            this.menu_file_new.Click += new System.EventHandler(this.menu_file_new_Click);
            // 
            // Nr
            // 
            this.Nr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "N/A";
            this.Nr.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nr.HeaderText = "Nr";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.NullValue = "N/A";
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.FillWeight = 300F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.NullValue = "N/A";
            this.Reason.DefaultCellStyle = dataGridViewCellStyle3;
            this.Reason.FillWeight = 300F;
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            // 
            // Removed
            // 
            this.Removed.HeaderText = "Removed";
            this.Removed.Name = "Removed";
            this.Removed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Removed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 281);
            this.Controls.Add(this.dgv_marks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_main);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_main;
            this.Name = "frm_main";
            this.Text = "GRA - Gaming Recording Assistant";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer_tracker;
        public System.Windows.Forms.Label la_episodeTimer;
        public System.Windows.Forms.Label la_totalTimer;
        public System.Windows.Forms.Label la_status_inactive;
        public System.Windows.Forms.Label la_status_tracking;
        public System.Windows.Forms.Label la_status_break;
        public System.Windows.Forms.Label la_status_deadline;
        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.Label la_breakTimer;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tm_blinkTimer;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgv_marks;
        private System.Windows.Forms.ToolStripMenuItem menu_file_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Removed;
    }
}

