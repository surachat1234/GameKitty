namespace GameKitty
{
    partial class ContentUniversal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_CloseGameKitty = new System.Windows.Forms.ToolStripButton();
            this.label_GameKitty = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switch_univ_DisableSmartScreen = new GameKitty.ToggleSwitch();
            this.switch_univ_FaxService = new GameKitty.ToggleSwitch();
            this.switch_univ_CompatibilityAssistant = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableOff2016Telemetry = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableTelemetryTasks = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableSuperfetch = new GameKitty.ToggleSwitch();
            this.switch_univ_HomeGroup = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableErrReport = new GameKitty.ToggleSwitch();
            this.switch_univ_BlockSkypeAds = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableMediaPlayerSharing = new GameKitty.ToggleSwitch();
            this.switch_univ_DisablePrintService = new GameKitty.ToggleSwitch();
            this.switch_univ_SystemRestore = new GameKitty.ToggleSwitch();
            this.switch_univ_EnablePerformanceTweaks = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableWindowsDefender = new GameKitty.ToggleSwitch();
            this.switch_univ_DisableNetworkThrottling = new GameKitty.ToggleSwitch();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(4);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_CloseGameKitty,
            this.label_GameKitty});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(712, 41);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_CloseGameKitty
            // 
            this.button_CloseGameKitty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_CloseGameKitty.Image = global::GameKitty.Properties.Resources.close_window;
            this.button_CloseGameKitty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_CloseGameKitty.Name = "button_CloseGameKitty";
            this.button_CloseGameKitty.Size = new System.Drawing.Size(28, 28);
            this.button_CloseGameKitty.Text = "CloseButton";
            this.button_CloseGameKitty.Click += new System.EventHandler(this.button_CloseGameKitty_Click);
            // 
            // label_GameKitty
            // 
            this.label_GameKitty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.label_GameKitty.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_GameKitty.ForeColor = System.Drawing.Color.Tomato;
            this.label_GameKitty.Name = "label_GameKitty";
            this.label_GameKitty.Size = new System.Drawing.Size(274, 28);
            this.label_GameKitty.Text = "GameKitty - Universal Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switch_univ_DisableSmartScreen);
            this.panel1.Controls.Add(this.switch_univ_FaxService);
            this.panel1.Controls.Add(this.switch_univ_CompatibilityAssistant);
            this.panel1.Controls.Add(this.switch_univ_DisableOff2016Telemetry);
            this.panel1.Controls.Add(this.switch_univ_DisableTelemetryTasks);
            this.panel1.Controls.Add(this.switch_univ_DisableSuperfetch);
            this.panel1.Controls.Add(this.switch_univ_HomeGroup);
            this.panel1.Controls.Add(this.switch_univ_DisableErrReport);
            this.panel1.Controls.Add(this.switch_univ_BlockSkypeAds);
            this.panel1.Controls.Add(this.switch_univ_DisableMediaPlayerSharing);
            this.panel1.Controls.Add(this.switch_univ_DisablePrintService);
            this.panel1.Controls.Add(this.switch_univ_SystemRestore);
            this.panel1.Controls.Add(this.switch_univ_EnablePerformanceTweaks);
            this.panel1.Controls.Add(this.switch_univ_DisableWindowsDefender);
            this.panel1.Controls.Add(this.switch_univ_DisableNetworkThrottling);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 345);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(480, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 85;
            this.label2.Tag = "themeable";
            this.label2.Text = "Enable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 84;
            this.label1.Tag = "themeable";
            this.label1.Text = "Stop";
            // 
            // switch_univ_DisableSmartScreen
            // 
            this.switch_univ_DisableSmartScreen.Location = new System.Drawing.Point(247, 233);
            this.switch_univ_DisableSmartScreen.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableSmartScreen.Name = "switch_univ_DisableSmartScreen";
            this.switch_univ_DisableSmartScreen.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableSmartScreen.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableSmartScreen.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableSmartScreen.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableSmartScreen.OnText = "SmartScreens";
            this.switch_univ_DisableSmartScreen.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableSmartScreen.TabIndex = 83;
            this.switch_univ_DisableSmartScreen.Tag = "themeable";
            this.switch_univ_DisableSmartScreen.Click += new System.EventHandler(this.switch_univ_SmartScreen_Click);
            // 
            // switch_univ_FaxService
            // 
            this.switch_univ_FaxService.Location = new System.Drawing.Point(247, 198);
            this.switch_univ_FaxService.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_FaxService.Name = "switch_univ_FaxService";
            this.switch_univ_FaxService.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_FaxService.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_FaxService.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_FaxService.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_FaxService.OnText = "Fax Services";
            this.switch_univ_FaxService.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_FaxService.TabIndex = 82;
            this.switch_univ_FaxService.Tag = "themeable";
            this.switch_univ_FaxService.Click += new System.EventHandler(this.switch_univ_FaxService_Click);
            // 
            // switch_univ_CompatibilityAssistant
            // 
            this.switch_univ_CompatibilityAssistant.Location = new System.Drawing.Point(25, 90);
            this.switch_univ_CompatibilityAssistant.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_CompatibilityAssistant.Name = "switch_univ_CompatibilityAssistant";
            this.switch_univ_CompatibilityAssistant.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_CompatibilityAssistant.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_CompatibilityAssistant.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_CompatibilityAssistant.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_CompatibilityAssistant.OnText = "Compatibility Assistant";
            this.switch_univ_CompatibilityAssistant.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_CompatibilityAssistant.TabIndex = 81;
            this.switch_univ_CompatibilityAssistant.Tag = "themeable";
            this.switch_univ_CompatibilityAssistant.Click += new System.EventHandler(this.switch_univ_CompatibilityAssistant_Click);
            // 
            // switch_univ_DisableOff2016Telemetry
            // 
            this.switch_univ_DisableOff2016Telemetry.Location = new System.Drawing.Point(247, 163);
            this.switch_univ_DisableOff2016Telemetry.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableOff2016Telemetry.Name = "switch_univ_DisableOff2016Telemetry";
            this.switch_univ_DisableOff2016Telemetry.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableOff2016Telemetry.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableOff2016Telemetry.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableOff2016Telemetry.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableOff2016Telemetry.OnText = "Office 2016 Telemetry";
            this.switch_univ_DisableOff2016Telemetry.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableOff2016Telemetry.TabIndex = 80;
            this.switch_univ_DisableOff2016Telemetry.Tag = "themeable";
            this.switch_univ_DisableOff2016Telemetry.Click += new System.EventHandler(this.switch_univ_Office2016_Click);
            // 
            // switch_univ_DisableTelemetryTasks
            // 
            this.switch_univ_DisableTelemetryTasks.Location = new System.Drawing.Point(247, 128);
            this.switch_univ_DisableTelemetryTasks.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableTelemetryTasks.Name = "switch_univ_DisableTelemetryTasks";
            this.switch_univ_DisableTelemetryTasks.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableTelemetryTasks.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableTelemetryTasks.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableTelemetryTasks.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableTelemetryTasks.OnText = "Telemetry Tasks";
            this.switch_univ_DisableTelemetryTasks.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableTelemetryTasks.TabIndex = 79;
            this.switch_univ_DisableTelemetryTasks.Tag = "themeable";
            this.switch_univ_DisableTelemetryTasks.Click += new System.EventHandler(this.switch_univ_TelemetryTasks_Click);
            // 
            // switch_univ_DisableSuperfetch
            // 
            this.switch_univ_DisableSuperfetch.Location = new System.Drawing.Point(25, 233);
            this.switch_univ_DisableSuperfetch.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableSuperfetch.Name = "switch_univ_DisableSuperfetch";
            this.switch_univ_DisableSuperfetch.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableSuperfetch.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableSuperfetch.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableSuperfetch.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableSuperfetch.OnText = "Superfetchs";
            this.switch_univ_DisableSuperfetch.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableSuperfetch.TabIndex = 78;
            this.switch_univ_DisableSuperfetch.Tag = "themeable";
            this.switch_univ_DisableSuperfetch.Click += new System.EventHandler(this.switch_univ_Superfetch_Click);
            // 
            // switch_univ_HomeGroup
            // 
            this.switch_univ_HomeGroup.Location = new System.Drawing.Point(247, 90);
            this.switch_univ_HomeGroup.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_HomeGroup.Name = "switch_univ_HomeGroup";
            this.switch_univ_HomeGroup.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_HomeGroup.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_HomeGroup.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_HomeGroup.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_HomeGroup.OnText = "HomeGroup";
            this.switch_univ_HomeGroup.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_HomeGroup.TabIndex = 77;
            this.switch_univ_HomeGroup.Tag = "themeable";
            this.switch_univ_HomeGroup.Click += new System.EventHandler(this.switch_univ_ErrorReport_Click);
            // 
            // switch_univ_DisableErrReport
            // 
            this.switch_univ_DisableErrReport.Location = new System.Drawing.Point(247, 54);
            this.switch_univ_DisableErrReport.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableErrReport.Name = "switch_univ_DisableErrReport";
            this.switch_univ_DisableErrReport.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableErrReport.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableErrReport.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableErrReport.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableErrReport.OnText = "Error Reporting";
            this.switch_univ_DisableErrReport.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableErrReport.TabIndex = 76;
            this.switch_univ_DisableErrReport.Tag = "themeable";
            this.switch_univ_DisableErrReport.Click += new System.EventHandler(this.switch_univ_ErrorReport_Click);
            // 
            // switch_univ_BlockSkypeAds
            // 
            this.switch_univ_BlockSkypeAds.Location = new System.Drawing.Point(485, 90);
            this.switch_univ_BlockSkypeAds.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_BlockSkypeAds.Name = "switch_univ_BlockSkypeAds";
            this.switch_univ_BlockSkypeAds.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_BlockSkypeAds.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_BlockSkypeAds.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_BlockSkypeAds.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_BlockSkypeAds.OnText = "Block Skype Ads";
            this.switch_univ_BlockSkypeAds.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_BlockSkypeAds.TabIndex = 75;
            this.switch_univ_BlockSkypeAds.Tag = "themeable";
            this.switch_univ_BlockSkypeAds.Click += new System.EventHandler(this.switch_univ_SkypeAds_Click);
            // 
            // switch_univ_DisableMediaPlayerSharing
            // 
            this.switch_univ_DisableMediaPlayerSharing.Location = new System.Drawing.Point(25, 198);
            this.switch_univ_DisableMediaPlayerSharing.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableMediaPlayerSharing.Name = "switch_univ_DisableMediaPlayerSharing";
            this.switch_univ_DisableMediaPlayerSharing.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableMediaPlayerSharing.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableMediaPlayerSharing.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableMediaPlayerSharing.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableMediaPlayerSharing.OnText = "Media Player Sharing";
            this.switch_univ_DisableMediaPlayerSharing.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableMediaPlayerSharing.TabIndex = 74;
            this.switch_univ_DisableMediaPlayerSharing.Tag = "themeable";
            this.switch_univ_DisableMediaPlayerSharing.Click += new System.EventHandler(this.switch_univ_MediaSharing_Click);
            // 
            // switch_univ_DisablePrintService
            // 
            this.switch_univ_DisablePrintService.Location = new System.Drawing.Point(247, 268);
            this.switch_univ_DisablePrintService.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisablePrintService.Name = "switch_univ_DisablePrintService";
            this.switch_univ_DisablePrintService.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisablePrintService.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisablePrintService.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisablePrintService.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisablePrintService.OnText = "Print Services";
            this.switch_univ_DisablePrintService.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisablePrintService.TabIndex = 73;
            this.switch_univ_DisablePrintService.Tag = "themeable";
            this.switch_univ_DisablePrintService.Click += new System.EventHandler(this.switch_univ_PrintService_Click);
            // 
            // switch_univ_SystemRestore
            // 
            this.switch_univ_SystemRestore.Location = new System.Drawing.Point(25, 128);
            this.switch_univ_SystemRestore.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_SystemRestore.Name = "switch_univ_SystemRestore";
            this.switch_univ_SystemRestore.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_SystemRestore.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_SystemRestore.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_SystemRestore.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_SystemRestore.OnText = "System Restore";
            this.switch_univ_SystemRestore.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_SystemRestore.TabIndex = 72;
            this.switch_univ_SystemRestore.Tag = "themeable";
            this.switch_univ_SystemRestore.Click += new System.EventHandler(this.switch_univ_SystemRestore_Click);
            // 
            // switch_univ_EnablePerformanceTweaks
            // 
            this.switch_univ_EnablePerformanceTweaks.Location = new System.Drawing.Point(485, 54);
            this.switch_univ_EnablePerformanceTweaks.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_EnablePerformanceTweaks.Name = "switch_univ_EnablePerformanceTweaks";
            this.switch_univ_EnablePerformanceTweaks.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_EnablePerformanceTweaks.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_EnablePerformanceTweaks.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_EnablePerformanceTweaks.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_EnablePerformanceTweaks.OnText = "Performance Tweaks";
            this.switch_univ_EnablePerformanceTweaks.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_EnablePerformanceTweaks.TabIndex = 71;
            this.switch_univ_EnablePerformanceTweaks.Tag = "themeable";
            this.switch_univ_EnablePerformanceTweaks.Click += new System.EventHandler(this.switch_univ_PerformanceTweaks_Click);
            // 
            // switch_univ_DisableWindowsDefender
            // 
            this.switch_univ_DisableWindowsDefender.Location = new System.Drawing.Point(25, 54);
            this.switch_univ_DisableWindowsDefender.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableWindowsDefender.Name = "switch_univ_DisableWindowsDefender";
            this.switch_univ_DisableWindowsDefender.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableWindowsDefender.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableWindowsDefender.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableWindowsDefender.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableWindowsDefender.OnText = "Windows Defender";
            this.switch_univ_DisableWindowsDefender.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableWindowsDefender.TabIndex = 70;
            this.switch_univ_DisableWindowsDefender.Tag = "themeable";
            this.switch_univ_DisableWindowsDefender.Click += new System.EventHandler(this.switch_univ_WindowsDefender_Click);
            // 
            // switch_univ_DisableNetworkThrottling
            // 
            this.switch_univ_DisableNetworkThrottling.Location = new System.Drawing.Point(25, 163);
            this.switch_univ_DisableNetworkThrottling.Margin = new System.Windows.Forms.Padding(2);
            this.switch_univ_DisableNetworkThrottling.Name = "switch_univ_DisableNetworkThrottling";
            this.switch_univ_DisableNetworkThrottling.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableNetworkThrottling.OffForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableNetworkThrottling.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_univ_DisableNetworkThrottling.OnForeColor = System.Drawing.Color.White;
            this.switch_univ_DisableNetworkThrottling.OnText = "Network Throttling";
            this.switch_univ_DisableNetworkThrottling.Size = new System.Drawing.Size(208, 31);
            this.switch_univ_DisableNetworkThrottling.TabIndex = 69;
            this.switch_univ_DisableNetworkThrottling.Tag = "themeable";
            this.switch_univ_DisableNetworkThrottling.Click += new System.EventHandler(this.switch_univ_NetworkThrottling_Click);
            // 
            // ContentUniversal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(712, 386);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContentUniversal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About GameKitty";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_CloseGameKitty;
        private System.Windows.Forms.ToolStripLabel label_GameKitty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToggleSwitch switch_univ_DisableSmartScreen;
        private ToggleSwitch switch_univ_FaxService;
        private ToggleSwitch switch_univ_CompatibilityAssistant;
        private ToggleSwitch switch_univ_DisableOff2016Telemetry;
        private ToggleSwitch switch_univ_DisableTelemetryTasks;
        private ToggleSwitch switch_univ_DisableSuperfetch;
        private ToggleSwitch switch_univ_HomeGroup;
        private ToggleSwitch switch_univ_DisableErrReport;
        private ToggleSwitch switch_univ_BlockSkypeAds;
        private ToggleSwitch switch_univ_DisableMediaPlayerSharing;
        private ToggleSwitch switch_univ_DisablePrintService;
        private ToggleSwitch switch_univ_SystemRestore;
        private ToggleSwitch switch_univ_EnablePerformanceTweaks;
        private ToggleSwitch switch_univ_DisableWindowsDefender;
        private ToggleSwitch switch_univ_DisableNetworkThrottling;
    }
}