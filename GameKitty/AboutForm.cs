using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GameKitty
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void button_about_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_opt_CheckUpdate_Click(object sender, EventArgs e)
        {
            Network.CheckForUpdate();
        }

        private void button_opt_ChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Network._changelogLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
