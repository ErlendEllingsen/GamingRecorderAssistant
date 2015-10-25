using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingRecorderAssistant
{
    public partial class frm_about : Form
    {
        public Dictionary<string, string> versionNames = new Dictionary<string, string>(){
            {"1.0", "Caramel Popcorn"},
            {"1.1", "Soledad Almonds"},
            {"1.2", "Multigrain Waffle"},
            {"1.3", "Aged Gouda" },
            {"1.4", "Handful of grapes" }
        };

        public frm_about()
        {
            InitializeComponent();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
            string versionName = versionNames[Application.ProductVersion.Substring(0, 3)];
            la_versionName.Text = versionName;

            la_version.Text = Application.ProductVersion;
        }

        private void rtb_about_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
