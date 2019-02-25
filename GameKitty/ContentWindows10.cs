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
    public partial class ContentWindows10 : Form
    {
        public ContentWindows10()
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            LoadWindowsXToggleStates();
        }

        private void LoadWindowsXToggleStates()
        {
            switch_w10_UninsOneDrive.Checked = Options.CurrentOptions.UninstallOneDrive;
            switch_w10_DisableGamebar.Checked = Options.CurrentOptions.DisableGameBar;
            switch_w10_DisableCortana.Checked = Options.CurrentOptions.DisableCortana;
            switch_w10_DisableXBoxLive.Checked = Options.CurrentOptions.DisableXboxLive;
            switch_w10_DisableQuickAccHist.Checked = Options.CurrentOptions.DisableQuickAccessHistory;
            switch_w10_DisableSensorService.Checked = Options.CurrentOptions.DisableSensorServices;
            switch_w10_DisablePrivacyOptions.Checked = Options.CurrentOptions.DisablePrivacyOptions;
            switch_w10_DisableSilentAppInstall.Checked = Options.CurrentOptions.DisableSilentAppInstall;
            switch_w10_DisableTelemetry.Checked = Options.CurrentOptions.DisableTelemetryServices;
            switch_w10_DisableAutoUpdates.Checked = Options.CurrentOptions.DisableAutomaticUpdates;
            switch_w10_DisableMyPeople.Checked = Options.CurrentOptions.DisableMyPeople;
            switch_w10_DisableStartMenuAds.Checked = Options.CurrentOptions.DisableStartMenuAds;
            switch_w10_DisableSpellType.Checked = Options.CurrentOptions.DisableSpellingTyping;
            switch_w10_DisableWindowsInk.Checked = Options.CurrentOptions.DisableWindowsInk;
            switch_w10_ExcludeDriverUpdate.Checked = Options.CurrentOptions.ExcludeDrivers;
            switch_w10_DisableInsiderService.Checked = Options.CurrentOptions.DisableInsiderService;
            switch_w10_DisableFeatureUpdates.Checked = Options.CurrentOptions.DisableFeatureUpdates;
            switch_w10_CloudClipboard.Checked = Options.CurrentOptions.DisableCloudClipboard;
            switch_w10_DisableOneDrive.Checked = Options.CurrentOptions.DisableOneDrive;
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void switch_w10_DisableStartMenuAds_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableStartMenuAds.Checked)
            {
                Optimize.DisableStartMenuAds();
            }
            else
            {
                Optimize.EnableStartMenuAds();
            }
            Options.CurrentOptions.DisableStartMenuAds = !switch_w10_DisableStartMenuAds.Checked;
        }

        private void switch_w10_DisableAutoUpdates_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableAutoUpdates.Checked)
            {
                Optimize.DisableAutomaticUpdates();
            }
            else
            {
                Optimize.EnableAutomaticUpdates();
            }
            Options.CurrentOptions.DisableAutomaticUpdates = !switch_w10_DisableAutoUpdates.Checked;
        }

        private void switch_w10_DisableInsiderService_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableInsiderService.Checked)
            {
                Optimize.DisableInsiderService();
            }
            else
            {
                Optimize.EnableInsiderService();
            }
            Options.CurrentOptions.DisableInsiderService = !switch_w10_DisableInsiderService.Checked;
        }

        private void switch_w10_DisableFeatureUpdates_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableFeatureUpdates.Checked)
            {
                Optimize.DisableForcedFeatureUpdates();
            }
            else
            {
                Optimize.EnableForcedFeatureUpdates();
            }
            Options.CurrentOptions.DisableFeatureUpdates = !switch_w10_DisableFeatureUpdates.Checked;
        }

        private void switch_w10_DisableTelemetry_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableTelemetry.Checked)
            {
                Optimize.DisableTelemetryServices();
            }
            else
            {
                Optimize.EnableTelemetryServices();
            }
            Options.CurrentOptions.DisableTelemetryServices = !switch_w10_DisableTelemetry.Checked;
        }

        private void switch_w10_DisableOneDrive_Clicked(object sender, EventArgs e)
        {
            if (!switch_w10_DisableOneDrive.Checked)
            {
                Optimize.DisableOneDrive();
            }
            else
            {
                Optimize.EnableOneDrive();
            }
            Options.CurrentOptions.DisableOneDrive = !switch_w10_DisableOneDrive.Checked;
        }

        private void switch_w10_DisableWindowsInk_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableWindowsInk.Checked)
            {
                Optimize.DisableWindowsInk();
            }
            else
            {
                Optimize.EnableWindowsInk();
            }
            Options.CurrentOptions.DisableWindowsInk = !switch_w10_DisableWindowsInk.Checked;
        }

        private void switch_w10_DisableQuickAccHist_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableQuickAccHist.Checked)
            {
                Optimize.DisableQuickAccessHistory();
            }
            else
            {
                Optimize.EnableQuickAccessHistory();
            }
            Options.CurrentOptions.DisableQuickAccessHistory = !switch_w10_DisableQuickAccHist.Checked;
        }

        private void switch_w10_DisableSpellType_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableSpellType.Checked)
            {
                Optimize.DisableSpellingAndTypingFeatures();
            }
            else
            {
                Optimize.EnableSpellingAndTypingFeatures();
            }
            Options.CurrentOptions.DisableSpellingTyping = !switch_w10_DisableSpellType.Checked;
        }

        private void switch_w10_DisablePrivacyOptions_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisablePrivacyOptions.Checked)
            {
                Optimize.DisablePrivacyOptions();
            }
            else
            {
                Optimize.EnablePrivacyOptions();
            }
            Options.CurrentOptions.DisablePrivacyOptions = !switch_w10_DisablePrivacyOptions.Checked;
        }

        private void switch_w10_DisableMyPeople_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableMyPeople.Checked)
            {
                Optimize.DisableMyPeople();
            }
            else
            {
                Optimize.EnableMyPeople();
            }
            Options.CurrentOptions.DisableMyPeople = !switch_w10_DisableMyPeople.Checked;
        }

        private void switch_w10_DisableCortana_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableCortana.Checked)
            {
                Optimize.DisableCortana();
            }
            else
            {
                Optimize.EnableCortana();
            }
            Options.CurrentOptions.DisableCortana = !switch_w10_DisableCortana.Checked;
        }

        private void switch_w10_DisableSensorService_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableSensorService.Checked)
            {
                Optimize.DisableSensorServices();
            }
            else
            {
                Optimize.EnableSensorServices();
            }
            Options.CurrentOptions.DisableSensorServices = !switch_w10_DisableSensorService.Checked;
        }

        private void switch_w10_DisableXBoxLive_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableXBoxLive.Checked)
            {
                Optimize.DisableXboxLive();
            }
            else
            {
                Optimize.EnableXboxLive();
            }
            Options.CurrentOptions.DisableXboxLive = !switch_w10_DisableXBoxLive.Checked;
        }

        private void switch_w10_DisableGamebar_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableGamebar.Checked)
            {
                Optimize.DisableGameBar();
            }
            else
            {
                Optimize.EnableGameBar();
            }
            Options.CurrentOptions.DisableGameBar = !switch_w10_DisableGamebar.Checked;
        }

        private void switch_w10_DisableSilentAppInstall_Click(object sender, EventArgs e)
        {
            if (!switch_w10_DisableSilentAppInstall.Checked)
            {
                Optimize.DisableSilentAppInstall();
            }
            else
            {
                Optimize.EnableSilentAppInstall();
            }
            Options.CurrentOptions.DisableSilentAppInstall = !switch_w10_DisableSilentAppInstall.Checked;
        }

        private void switch_w10_CloudClipboard_Click(object sender, EventArgs e)
        {
            if (!switch_w10_CloudClipboard.Checked)
            {
                Optimize.DisableCloudClipboard();
            }
            else
            {
                Optimize.EnableCloudClipboard();
            }
            Options.CurrentOptions.DisableCloudClipboard = !switch_w10_CloudClipboard.Checked;
        }

        private void switch_w10_ExcludeDriverUpdate_Click(object sender, EventArgs e)
        {
            if (!switch_w10_ExcludeDriverUpdate.Checked)
            {
                Optimize.ExcludeDrivers();
            }
            else
            {
                Optimize.IncludeDrivers();
            }
            Options.CurrentOptions.ExcludeDrivers = !switch_w10_ExcludeDriverUpdate.Checked;
        }

        private void switch_w10_UninsOneDrive_Clicked(object sender, EventArgs e)
        {
            if (!switch_w10_UninsOneDrive.Checked)
            {
                Task t = new Task(() => Optimize.UninstallOneDrive());
                t.Start();
            }
            else
            {
                Task t = new Task(() => Optimize.InstallOneDrive());
                t.Start();
            }
            Options.CurrentOptions.UninstallOneDrive = !switch_w10_UninsOneDrive.Checked;
        }
    }
}
