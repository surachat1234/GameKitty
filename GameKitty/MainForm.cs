using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;

namespace GameKitty
{
    public partial class MainForm : Form
    {
        readonly string _restartMessage = "Do you want to restart your computer?";

        readonly string _resetMessage = "Do you want to reset your configuration?";

        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            txtVersion.Text = "Version: " + Program.GetCurrentVersionTostring();
            Program.MainForm = this;

            txtOS.Text = Utilities.GetOS();
            txtBitness.Text = Utilities.GetBitness();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Tomato;
            Options.ApplyTheme(this);
        }

        private void Main_FormClosing(object sender, EventArgs e)
        {
            Options.SaveSettings();
        }

        private void GameKittyLogo_Click(object sender, EventArgs e)
        {
            if(Network.networkAvailable)
            {
                AboutForm f = new AboutForm();
                f.ShowDialog(this);
            }
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_MinimizeGameKitty_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_RestartComputer_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button_ResetConfig_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Reset, _resetMessage);
            f.ShowDialog();
        }

        private void button_OpenUniversal_Click(object sender, EventArgs e)
        {
            ContentUniversal cu = new ContentUniversal();
            cu.Show();
        }

        private void button_OpenWindows10_Click(object sender, EventArgs e)
        {
            ContentWindows10 cw = new ContentWindows10();
            cw.Show();
        }

        private void button_OpenModernApps_Click(object sender, EventArgs e)
        {
            ContentModernApps cm = new ContentModernApps();
            cm.Show();
        }

        private void button_OpenCleaner_Click(object sender, EventArgs e)
        {
            ContentCleaner cc = new ContentCleaner();
            cc.Show();
        }

        private void button_OpenRegistry_Click(object sender, EventArgs e)
        {
            ContentRegistry cr = new ContentRegistry();
            cr.Show();
        }
    }
}
