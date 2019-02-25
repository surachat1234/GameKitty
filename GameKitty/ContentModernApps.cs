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
    public partial class ContentModernApps : Form
    {
        private List<string> _modernApps = new List<string>();

        private readonly string _removeModernAppsMessage = "Are you sure you want to uninstall the following app(s)?";
        private readonly string _errorModernAppsMessage = "The following app(s) couldn't be uninstalled:\n";

        public ContentModernApps()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
            GetModernApps();
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void GetModernApps()
        {
            button_uwp_Uninstall.Enabled = false;
            button_uwp_Refresh.Enabled = false;
            listModernApps.Enabled = false;

            listModernApps.Items.Clear();
            _modernApps = Utilities.GetModernApps();

            foreach (string x in _modernApps)
            {
                listModernApps.Items.Add(x);
            }

            button_uwp_Uninstall.Enabled = true;
            button_uwp_Refresh.Enabled = true;
            listModernApps.Enabled = true;
        }

        private async void UninstallModernApps()
        {
            string selectedApps = string.Empty;

            if (listModernApps.CheckedItems.Count > 0)
            {
                foreach (string x in listModernApps.CheckedItems)
                {
                    if (string.IsNullOrEmpty(selectedApps))
                    {
                        selectedApps = x;
                    }
                    else
                    {
                        selectedApps += Environment.NewLine + x;
                    }
                }

                if (MessageBox.Show(_removeModernAppsMessage + "\n\n" + selectedApps, "GameKitty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button_uwp_Uninstall.Enabled = false;
                    button_uwp_Refresh.Enabled = false;
                    listModernApps.Enabled = false;

                    bool errorOccured = false;
                    string failedApps = string.Empty;

                    foreach (string app in listModernApps.CheckedItems)
                    {
                        await Task.Run(() => errorOccured = Utilities.UninstallModernApp(app));

                        if (errorOccured)
                        {
                            failedApps += Environment.NewLine + app;
                        }
                    }

                    if (!string.IsNullOrEmpty(failedApps))
                    {
                        MessageBox.Show(_errorModernAppsMessage + failedApps, "GameKitty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    GetModernApps();
                }
            }
        }

        private void button_uwp_Refresh_Click(object sender, EventArgs e)
        {
            GetModernApps();
        }

        private void button_uwp_Uninstall_Click(object sender, EventArgs e)
        {
            UninstallModernApps();
        }

        private void chkSelectAllModernApps_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listModernApps.Items.Count; i++)
            {
                listModernApps.SetItemChecked(i, radio_uwp_SelectAll.Checked);
            }
        }
    }
}
