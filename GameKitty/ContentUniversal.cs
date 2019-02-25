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
    public partial class ContentUniversal : Form
    {
        public ContentUniversal()
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            LoadUniversalToggleStates();
        }

        private void LoadUniversalToggleStates()
        {
            switch_univ_EnablePerformanceTweaks.Checked = Options.CurrentOptions.EnablePerformanceTweaks;
            switch_univ_DisableNetworkThrottling.Checked = Options.CurrentOptions.DisableNetworkThrottling;
            switch_univ_DisableWindowsDefender.Checked = Options.CurrentOptions.DisableWindowsDefender;
            switch_univ_SystemRestore.Checked = Options.CurrentOptions.DisableSystemRestore;
            switch_univ_DisablePrintService.Checked = Options.CurrentOptions.DisablePrintService;
            switch_univ_DisableMediaPlayerSharing.Checked = Options.CurrentOptions.DisableMediaPlayerSharing;
            switch_univ_BlockSkypeAds.Checked = Options.CurrentOptions.BlockSkypeAds;
            switch_univ_DisableErrReport.Checked = Options.CurrentOptions.DisableErrorReporting;
            switch_univ_HomeGroup.Checked = Options.CurrentOptions.DisableHomeGroup;
            switch_univ_DisableSuperfetch.Checked = Options.CurrentOptions.DisableSuperfetch;
            switch_univ_DisableTelemetryTasks.Checked = Options.CurrentOptions.DisableTelemetryTasks;
            switch_univ_DisableOff2016Telemetry.Checked = Options.CurrentOptions.DisableOffice2016Telemetry;
            switch_univ_CompatibilityAssistant.Checked = Options.CurrentOptions.DisableCompatibilityAssistant;
            switch_univ_FaxService.Checked = Options.CurrentOptions.DisableFaxService;
            switch_univ_DisableSmartScreen.Checked = Options.CurrentOptions.DisableSmartScreen;
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void switch_univ_WindowsDefender_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableWindowsDefender.Checked)
            {
                Optimize.DisableDefender();
            }
            else
            {
                Optimize.EnableDefender();
            }
            Options.CurrentOptions.DisableWindowsDefender = !switch_univ_DisableWindowsDefender.Checked;
        }

        private void switch_univ_CompatibilityAssistant_Click(object sender, EventArgs e)
        {
            if (!switch_univ_CompatibilityAssistant.Checked)
            {
                Optimize.DisableCompatibilityAssistant();
            }
            else
            {
                Optimize.EnableCompatibilityAssistant();
            }
            Options.CurrentOptions.DisableCompatibilityAssistant = !switch_univ_CompatibilityAssistant.Checked;
        }

        private void switch_univ_SystemRestore_Click(object sender, EventArgs e)
        {
            if (!switch_univ_SystemRestore.Checked)
            {
                Optimize.DisableSystemRestore();
            }
            else
            {
                Optimize.EnableSystemRestore();
            }
            Options.CurrentOptions.DisableSystemRestore = !switch_univ_SystemRestore.Checked;
        }

        private void switch_univ_NetworkThrottling_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableNetworkThrottling.Checked)
            {
                Optimize.DisableNetworkThrottling();
            }
            else
            {
                Optimize.EnableNetworkThrottling();
            }
            Options.CurrentOptions.DisableNetworkThrottling = !switch_univ_DisableNetworkThrottling.Checked;
        }

        private void switch_univ_MediaSharing_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableMediaPlayerSharing.Checked)
            {
                Optimize.DisableMediaPlayerSharing();
            }
            else
            {
                Optimize.EnableMediaPlayerSharing();
            }
            Options.CurrentOptions.DisableMediaPlayerSharing = !switch_univ_DisableMediaPlayerSharing.Checked;
        }

        private void switch_univ_Superfetch_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableSuperfetch.Checked)
            {
                Optimize.DisableSuperfetch();
            }
            else
            {
                Optimize.EnableSuperfetch();
            }
            Options.CurrentOptions.DisableSuperfetch = !switch_univ_DisableSuperfetch.Checked;
        }

        private void switch_univ_ErrorReport_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableErrReport.Checked)
            {
                Optimize.DisableErrorReporting();
            }
            else
            {
                Optimize.EnableErrorReporting();
            }
            Options.CurrentOptions.DisableErrorReporting = !switch_univ_DisableErrReport.Checked;
        }

        private void switch_univ_HomeGroup_Click(object sender, EventArgs e)
        {
            if (!switch_univ_HomeGroup.Checked)
            {
                Optimize.DisableHomeGroup();
            }
            else
            {
                Optimize.EnableHomeGroup();
            }
            Options.CurrentOptions.DisableHomeGroup = !switch_univ_HomeGroup.Checked;
        }

        private void switch_univ_TelemetryTasks_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableTelemetryTasks.Checked)
            {
                Optimize.DisableTelemetryTasks();
            }
            else
            {
                Optimize.EnableTelemetryTasks();
            }
            Options.CurrentOptions.DisableTelemetryTasks = !switch_univ_DisableTelemetryTasks.Checked;
        }

        private void switch_univ_Office2016_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableOff2016Telemetry.Checked)
            {
                Optimize.DisableOffice2016Telemetry();
            }
            else
            {
                Optimize.EnableOffice2016Telemetry();
            }
            Options.CurrentOptions.DisableOffice2016Telemetry = !switch_univ_DisableOff2016Telemetry.Checked;
        }

        private void switch_univ_FaxService_Click(object sender, EventArgs e)
        {
            if (!switch_univ_FaxService.Checked)
            {
                Optimize.DisableFaxService();
            }
            else
            {
                Optimize.EnableFaxService();
            }
            Options.CurrentOptions.DisableFaxService = !switch_univ_FaxService.Checked;
        }

        private void switch_univ_SmartScreen_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisableSmartScreen.Checked)
            {
                Optimize.DisableSmartScreen();
            }
            else
            {
                Optimize.EnableSmartScreen();
            }
            Options.CurrentOptions.DisableSmartScreen = !switch_univ_DisableSmartScreen.Checked;
        }

        private void switch_univ_PrintService_Click(object sender, EventArgs e)
        {
            if (!switch_univ_DisablePrintService.Checked)
            {
                Optimize.DisablePrintService();
            }
            else
            {
                Optimize.EnablePrintService();
            }
            Options.CurrentOptions.DisablePrintService = !switch_univ_DisablePrintService.Checked;
        }

        private void switch_univ_PerformanceTweaks_Click(object sender, EventArgs e)
        {
            if (!switch_univ_EnablePerformanceTweaks.Checked)
            {
                Optimize.EnablePerformanceTweaks();
            }
            else
            {
                Optimize.DisablePerformanceTweaks();
            }
            Options.CurrentOptions.EnablePerformanceTweaks = !switch_univ_EnablePerformanceTweaks.Checked;
        }

        private void switch_univ_SkypeAds_Click(object sender, EventArgs e)
        {
            if (!switch_univ_BlockSkypeAds.Checked)
            {
                Optimize.DisableSkypeAds();
            }
            else
            {
                Optimize.EnableSkypeAds();
            }
            Options.CurrentOptions.BlockSkypeAds = !switch_univ_BlockSkypeAds.Checked;
        }
    }
}
