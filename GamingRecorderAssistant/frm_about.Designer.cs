namespace GamingRecorderAssistant
{
    partial class frm_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_about));
            this.rtb_about = new System.Windows.Forms.RichTextBox();
            this.la_version = new System.Windows.Forms.Label();
            this.la_version_exp = new System.Windows.Forms.Label();
            this.pb_gra_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gra_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_about
            // 
            this.rtb_about.Location = new System.Drawing.Point(12, 220);
            this.rtb_about.Name = "rtb_about";
            this.rtb_about.ReadOnly = true;
            this.rtb_about.Size = new System.Drawing.Size(538, 253);
            this.rtb_about.TabIndex = 4;
            this.rtb_about.Text = resources.GetString("rtb_about.Text");
            this.rtb_about.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_about_LinkClicked);
            // 
            // la_version
            // 
            this.la_version.AutoSize = true;
            this.la_version.Location = new System.Drawing.Point(78, 13);
            this.la_version.Name = "la_version";
            this.la_version.Size = new System.Drawing.Size(52, 17);
            this.la_version.TabIndex = 5;
            this.la_version.Text = "0.0.0.0";
            // 
            // la_version_exp
            // 
            this.la_version_exp.AutoSize = true;
            this.la_version_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_version_exp.Location = new System.Drawing.Point(9, 13);
            this.la_version_exp.Name = "la_version_exp";
            this.la_version_exp.Size = new System.Drawing.Size(63, 17);
            this.la_version_exp.TabIndex = 6;
            this.la_version_exp.Text = "Version";
            // 
            // pb_gra_logo
            // 
            this.pb_gra_logo.Image = global::GamingRecorderAssistant.Properties.Resources.gra_logo_526;
            this.pb_gra_logo.Location = new System.Drawing.Point(177, 13);
            this.pb_gra_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_gra_logo.Name = "pb_gra_logo";
            this.pb_gra_logo.Size = new System.Drawing.Size(200, 200);
            this.pb_gra_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gra_logo.TabIndex = 3;
            this.pb_gra_logo.TabStop = false;
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 485);
            this.Controls.Add(this.la_version_exp);
            this.Controls.Add(this.la_version);
            this.Controls.Add(this.rtb_about);
            this.Controls.Add(this.pb_gra_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GRA - About";
            this.Load += new System.EventHandler(this.frm_about_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_gra_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_gra_logo;
        private System.Windows.Forms.RichTextBox rtb_about;
        private System.Windows.Forms.Label la_version;
        private System.Windows.Forms.Label la_version_exp;
    }
}