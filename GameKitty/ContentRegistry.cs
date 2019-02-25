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
    public partial class ContentRegistry : Form
    {
        public ContentRegistry()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private bool FixRegistry()
        {
            bool changeDetected = false;

            try
            {
                if (radio_reg_Firewall.Checked)
                {
                    Utilities.EnableFirewall();
                    changeDetected = true;
                }
                if (radio_reg_Cmd.Checked)
                {
                    Utilities.EnableCommandPrompt();
                    changeDetected = true;
                }
                if (radio_reg_ControlPanel.Checked)
                {
                    Utilities.EnableControlPanel();
                    changeDetected = true;
                }
                if (radio_reg_FolderOptions.Checked)
                {
                    Utilities.EnableFolderOptions();
                    changeDetected = true;
                }
                if (radio_reg_RunDialog.Checked)
                {
                    Utilities.EnableRunDialog();
                    changeDetected = true;
                }
                if (radio_reg_RightClickMenu.Checked)
                {
                    Utilities.EnableContextMenu();
                    changeDetected = true;
                }
                if (radio_reg_TaskManager.Checked)
                {
                    Utilities.EnableTaskManager();
                    changeDetected = true;
                }
                if (radio_reg_RegEdit.Checked)
                {
                    Utilities.EnableRegistryEditor();
                    changeDetected = true;
                }
            }
            catch { }

            return changeDetected;
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void button_reg_Fix_Click(object sender, EventArgs e)
        {
            bool flag = FixRegistry();

            if (flag)
            {
                button_reg_Fix.Enabled = false;

                if (radio_reg_RestartExplorer.Checked)
                {
                    Utilities.RestartExplorer();
                }
                
                button_reg_Fix.Enabled = true;
            }
        }

        private void checkEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            radio_reg_TaskManager.Checked = radio_reg_EnableAll.Checked;
            radio_reg_Cmd.Checked = radio_reg_EnableAll.Checked;
            radio_reg_ControlPanel.Checked = radio_reg_EnableAll.Checked;
            radio_reg_FolderOptions.Checked = radio_reg_EnableAll.Checked;
            radio_reg_RunDialog.Checked = radio_reg_EnableAll.Checked;
            radio_reg_RightClickMenu.Checked = radio_reg_EnableAll.Checked;
            radio_reg_Firewall.Checked = radio_reg_EnableAll.Checked;
            radio_reg_RegEdit.Checked = radio_reg_EnableAll.Checked;
        }
    }
}
