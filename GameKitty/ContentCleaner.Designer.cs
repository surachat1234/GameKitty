namespace GameKitty
{
    partial class ContentCleaner
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
            this.cleaningpanel = new System.Windows.Forms.Panel();
            this.label_cleaner_Footer = new System.Windows.Forms.Label();
            this.progress_cleaner_Cleaning = new System.Windows.Forms.ProgressBar();
            this.radio_cleaner_ErrorReports = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_FileZillaSVList = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_SelectAll = new System.Windows.Forms.CheckBox();
            this.button_cleaner_Clean = new System.Windows.Forms.Button();
            this.radio_cleaner_MediaCache = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_Temp = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_Logs = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_UTorrentCache = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_RecycleBin = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_Minidumps = new System.Windows.Forms.CheckBox();
            this.radio_cleaner_Prefetch = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cleaningpanel.SuspendLayout();
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
            this.label_GameKitty.Size = new System.Drawing.Size(260, 28);
            this.label_GameKitty.Text = "GameKitty - Cleaner Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cleaningpanel);
            this.panel1.Controls.Add(this.radio_cleaner_ErrorReports);
            this.panel1.Controls.Add(this.radio_cleaner_FileZillaSVList);
            this.panel1.Controls.Add(this.radio_cleaner_SelectAll);
            this.panel1.Controls.Add(this.button_cleaner_Clean);
            this.panel1.Controls.Add(this.radio_cleaner_MediaCache);
            this.panel1.Controls.Add(this.radio_cleaner_Temp);
            this.panel1.Controls.Add(this.radio_cleaner_Logs);
            this.panel1.Controls.Add(this.radio_cleaner_UTorrentCache);
            this.panel1.Controls.Add(this.radio_cleaner_RecycleBin);
            this.panel1.Controls.Add(this.radio_cleaner_Minidumps);
            this.panel1.Controls.Add(this.radio_cleaner_Prefetch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 345);
            this.panel1.TabIndex = 5;
            // 
            // cleaningpanel
            // 
            this.cleaningpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cleaningpanel.Controls.Add(this.label_cleaner_Footer);
            this.cleaningpanel.Controls.Add(this.progress_cleaner_Cleaning);
            this.cleaningpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cleaningpanel.Location = new System.Drawing.Point(0, 235);
            this.cleaningpanel.Name = "cleaningpanel";
            this.cleaningpanel.Size = new System.Drawing.Size(712, 110);
            this.cleaningpanel.TabIndex = 58;
            // 
            // label_cleaner_Footer
            // 
            this.label_cleaner_Footer.AutoSize = true;
            this.label_cleaner_Footer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_cleaner_Footer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_cleaner_Footer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_cleaner_Footer.Location = new System.Drawing.Point(31, 31);
            this.label_cleaner_Footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cleaner_Footer.Name = "label_cleaner_Footer";
            this.label_cleaner_Footer.Size = new System.Drawing.Size(85, 21);
            this.label_cleaner_Footer.TabIndex = 57;
            this.label_cleaner_Footer.Tag = "themeable";
            this.label_cleaner_Footer.Text = "Cleaning...";
            this.label_cleaner_Footer.Visible = false;
            // 
            // progress_cleaner_Cleaning
            // 
            this.progress_cleaner_Cleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progress_cleaner_Cleaning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progress_cleaner_Cleaning.Location = new System.Drawing.Point(35, 63);
            this.progress_cleaner_Cleaning.Margin = new System.Windows.Forms.Padding(2);
            this.progress_cleaner_Cleaning.MarqueeAnimationSpeed = 1;
            this.progress_cleaner_Cleaning.Name = "progress_cleaner_Cleaning";
            this.progress_cleaner_Cleaning.Size = new System.Drawing.Size(454, 11);
            this.progress_cleaner_Cleaning.TabIndex = 56;
            this.progress_cleaner_Cleaning.Visible = false;
            // 
            // radio_cleaner_ErrorReports
            // 
            this.radio_cleaner_ErrorReports.AutoSize = true;
            this.radio_cleaner_ErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_ErrorReports.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_ErrorReports.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_ErrorReports.Location = new System.Drawing.Point(61, 170);
            this.radio_cleaner_ErrorReports.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_ErrorReports.Name = "radio_cleaner_ErrorReports";
            this.radio_cleaner_ErrorReports.Size = new System.Drawing.Size(123, 25);
            this.radio_cleaner_ErrorReports.TabIndex = 55;
            this.radio_cleaner_ErrorReports.Text = "Error reports";
            this.radio_cleaner_ErrorReports.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_FileZillaSVList
            // 
            this.radio_cleaner_FileZillaSVList.AutoSize = true;
            this.radio_cleaner_FileZillaSVList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_FileZillaSVList.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_FileZillaSVList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_FileZillaSVList.Location = new System.Drawing.Point(262, 140);
            this.radio_cleaner_FileZillaSVList.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_FileZillaSVList.Name = "radio_cleaner_FileZillaSVList";
            this.radio_cleaner_FileZillaSVList.Size = new System.Drawing.Size(191, 25);
            this.radio_cleaner_FileZillaSVList.TabIndex = 49;
            this.radio_cleaner_FileZillaSVList.Text = "FileZilla recent servers";
            this.radio_cleaner_FileZillaSVList.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_SelectAll
            // 
            this.radio_cleaner_SelectAll.AutoSize = true;
            this.radio_cleaner_SelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_SelectAll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radio_cleaner_SelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_SelectAll.Location = new System.Drawing.Point(35, 18);
            this.radio_cleaner_SelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_SelectAll.Name = "radio_cleaner_SelectAll";
            this.radio_cleaner_SelectAll.Size = new System.Drawing.Size(94, 25);
            this.radio_cleaner_SelectAll.TabIndex = 46;
            this.radio_cleaner_SelectAll.Tag = "themeable";
            this.radio_cleaner_SelectAll.Text = "Select all";
            this.radio_cleaner_SelectAll.UseVisualStyleBackColor = true;
            this.radio_cleaner_SelectAll.CheckedChanged += new System.EventHandler(this.checkSelectAll_CheckedChanged);
            // 
            // button_cleaner_Clean
            // 
            this.button_cleaner_Clean.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_cleaner_Clean.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_cleaner_Clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_cleaner_Clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_cleaner_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cleaner_Clean.ForeColor = System.Drawing.Color.White;
            this.button_cleaner_Clean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_cleaner_Clean.Location = new System.Drawing.Point(604, 199);
            this.button_cleaner_Clean.Margin = new System.Windows.Forms.Padding(2);
            this.button_cleaner_Clean.Name = "button_cleaner_Clean";
            this.button_cleaner_Clean.Size = new System.Drawing.Size(71, 31);
            this.button_cleaner_Clean.TabIndex = 45;
            this.button_cleaner_Clean.Text = "Clean";
            this.button_cleaner_Clean.UseVisualStyleBackColor = false;
            this.button_cleaner_Clean.Click += new System.EventHandler(this.button_cleaner_Clean_Click);
            // 
            // radio_cleaner_MediaCache
            // 
            this.radio_cleaner_MediaCache.AutoSize = true;
            this.radio_cleaner_MediaCache.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_MediaCache.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_MediaCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_MediaCache.Location = new System.Drawing.Point(262, 79);
            this.radio_cleaner_MediaCache.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_MediaCache.Name = "radio_cleaner_MediaCache";
            this.radio_cleaner_MediaCache.Size = new System.Drawing.Size(176, 25);
            this.radio_cleaner_MediaCache.TabIndex = 54;
            this.radio_cleaner_MediaCache.Text = "Media Players cache";
            this.radio_cleaner_MediaCache.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_Temp
            // 
            this.radio_cleaner_Temp.AutoSize = true;
            this.radio_cleaner_Temp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_Temp.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_Temp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_Temp.Location = new System.Drawing.Point(61, 49);
            this.radio_cleaner_Temp.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_Temp.Name = "radio_cleaner_Temp";
            this.radio_cleaner_Temp.Size = new System.Drawing.Size(142, 25);
            this.radio_cleaner_Temp.TabIndex = 47;
            this.radio_cleaner_Temp.Text = "Temporary files";
            this.radio_cleaner_Temp.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_Logs
            // 
            this.radio_cleaner_Logs.AutoSize = true;
            this.radio_cleaner_Logs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_Logs.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_Logs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_Logs.Location = new System.Drawing.Point(61, 79);
            this.radio_cleaner_Logs.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_Logs.Name = "radio_cleaner_Logs";
            this.radio_cleaner_Logs.Size = new System.Drawing.Size(169, 25);
            this.radio_cleaner_Logs.TabIndex = 53;
            this.radio_cleaner_Logs.Text = "Windows + IIS logs";
            this.radio_cleaner_Logs.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_UTorrentCache
            // 
            this.radio_cleaner_UTorrentCache.AutoSize = true;
            this.radio_cleaner_UTorrentCache.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_UTorrentCache.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_UTorrentCache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_UTorrentCache.Location = new System.Drawing.Point(262, 110);
            this.radio_cleaner_UTorrentCache.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_UTorrentCache.Name = "radio_cleaner_UTorrentCache";
            this.radio_cleaner_UTorrentCache.Size = new System.Drawing.Size(137, 25);
            this.radio_cleaner_UTorrentCache.TabIndex = 48;
            this.radio_cleaner_UTorrentCache.Text = "uTorrent cache";
            this.radio_cleaner_UTorrentCache.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_RecycleBin
            // 
            this.radio_cleaner_RecycleBin.AutoSize = true;
            this.radio_cleaner_RecycleBin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_RecycleBin.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_RecycleBin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_RecycleBin.Location = new System.Drawing.Point(262, 49);
            this.radio_cleaner_RecycleBin.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_RecycleBin.Name = "radio_cleaner_RecycleBin";
            this.radio_cleaner_RecycleBin.Size = new System.Drawing.Size(162, 25);
            this.radio_cleaner_RecycleBin.TabIndex = 52;
            this.radio_cleaner_RecycleBin.Text = "Empty Recycle Bin";
            this.radio_cleaner_RecycleBin.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_Minidumps
            // 
            this.radio_cleaner_Minidumps.AutoSize = true;
            this.radio_cleaner_Minidumps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_Minidumps.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_Minidumps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_Minidumps.Location = new System.Drawing.Point(61, 140);
            this.radio_cleaner_Minidumps.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_Minidumps.Name = "radio_cleaner_Minidumps";
            this.radio_cleaner_Minidumps.Size = new System.Drawing.Size(157, 25);
            this.radio_cleaner_Minidumps.TabIndex = 50;
            this.radio_cleaner_Minidumps.Text = "BSOD Minidumps";
            this.radio_cleaner_Minidumps.UseVisualStyleBackColor = true;
            // 
            // radio_cleaner_Prefetch
            // 
            this.radio_cleaner_Prefetch.AutoSize = true;
            this.radio_cleaner_Prefetch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_cleaner_Prefetch.ForeColor = System.Drawing.Color.DimGray;
            this.radio_cleaner_Prefetch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_cleaner_Prefetch.Location = new System.Drawing.Point(61, 110);
            this.radio_cleaner_Prefetch.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cleaner_Prefetch.Name = "radio_cleaner_Prefetch";
            this.radio_cleaner_Prefetch.Size = new System.Drawing.Size(137, 25);
            this.radio_cleaner_Prefetch.TabIndex = 51;
            this.radio_cleaner_Prefetch.Text = "Prefetch cache";
            this.radio_cleaner_Prefetch.UseVisualStyleBackColor = true;
            // 
            // ContentCleaner
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
            this.Name = "ContentCleaner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About GameKitty";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cleaningpanel.ResumeLayout(false);
            this.cleaningpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_CloseGameKitty;
        private System.Windows.Forms.ToolStripLabel label_GameKitty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox radio_cleaner_ErrorReports;
        private System.Windows.Forms.CheckBox radio_cleaner_FileZillaSVList;
        private System.Windows.Forms.Button button_cleaner_Clean;
        private System.Windows.Forms.CheckBox radio_cleaner_MediaCache;
        private System.Windows.Forms.CheckBox radio_cleaner_Temp;
        private System.Windows.Forms.CheckBox radio_cleaner_Logs;
        private System.Windows.Forms.CheckBox radio_cleaner_UTorrentCache;
        private System.Windows.Forms.CheckBox radio_cleaner_RecycleBin;
        private System.Windows.Forms.CheckBox radio_cleaner_Minidumps;
        private System.Windows.Forms.CheckBox radio_cleaner_Prefetch;
        private System.Windows.Forms.ProgressBar progress_cleaner_Cleaning;
        private System.Windows.Forms.Label label_cleaner_Footer;
        private System.Windows.Forms.CheckBox radio_cleaner_SelectAll;
        private System.Windows.Forms.Panel cleaningpanel;
    }
}