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
    public partial class ContentCleaner : Form
    {
        public ContentCleaner()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void CleanPC()
        {
            try
            {
                if (radio_cleaner_Temp.Checked)
                {
                    CleanHelper.CleanTemporaries();
                }
                if (radio_cleaner_UTorrentCache.Checked)
                {
                    CleanHelper.CleanUTorrent();
                }
                if (radio_cleaner_FileZillaSVList.Checked)
                {
                    CleanHelper.CleanFileZilla();
                }
                if (radio_cleaner_Minidumps.Checked)
                {
                    CleanHelper.CleanMiniDumps();
                }
                if (radio_cleaner_Prefetch.Checked)
                {
                    CleanHelper.CleanPrefetch();
                }
                if (radio_cleaner_MediaCache.Checked)
                {
                    CleanHelper.CleanMediaPlayersCache();
                }
                if (radio_cleaner_Logs.Checked)
                {
                    CleanHelper.CleanLogs();
                }
                if (radio_cleaner_ErrorReports.Checked)
                {
                    CleanHelper.CleanErrorReports();
                }
                if (radio_cleaner_RecycleBin.Checked)
                {
                    CleanHelper.EmptyRecycleBin();
                }
            }
            catch { }
            finally
            {
                CleaningAnimation(false);
            }
        }

        private void CleaningAnimation(bool start)
        {
            if (start)
            {
                Utilities.SetControlPropertyThreadSafe(cleaningpanel, "Visible", true);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "Visible", true);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "Style", ProgressBarStyle.Marquee);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "MarqueeAnimationSpeed", 1);
                Utilities.SetControlPropertyThreadSafe(label_cleaner_Footer, "Visible", true);
                Utilities.SetControlPropertyThreadSafe(button_cleaner_Clean, "Enabled", false);
                Utilities.SetControlPropertyThreadSafe(panel1, "Enabled", false);
            }
            else
            {
                Utilities.SetControlPropertyThreadSafe(cleaningpanel, "Visible", false);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "Visible", false);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "Value", 0);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "Style", ProgressBarStyle.Blocks);
                Utilities.SetControlPropertyThreadSafe(progress_cleaner_Cleaning, "MarqueeAnimationSpeed", 1);
                Utilities.SetControlPropertyThreadSafe(label_cleaner_Footer, "Visible", false);
                Utilities.SetControlPropertyThreadSafe(button_cleaner_Clean, "Enabled", true);
                Utilities.SetControlPropertyThreadSafe(panel1, "Enabled", true);
            }
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void button_cleaner_Clean_Click(object sender, EventArgs e)
        {
            CleaningAnimation(true);
            Task t = new Task(() => CleanPC());
            t.Start();
        }

        private void checkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            radio_cleaner_Temp.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_UTorrentCache.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_FileZillaSVList.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_Minidumps.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_Prefetch.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_MediaCache.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_Logs.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_RecycleBin.Checked = radio_cleaner_SelectAll.Checked;
            radio_cleaner_ErrorReports.Checked = radio_cleaner_SelectAll.Checked;
        }
    }
}
