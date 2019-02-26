namespace GameKitty
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tpanel = new System.Windows.Forms.Panel();
            this.button_ResetConfig = new System.Windows.Forms.Button();
            this.txtBitness = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.GameKittyLogo = new System.Windows.Forms.PictureBox();
            this.button_RestartComputer = new System.Windows.Forms.Button();
            this.defineCommandDialog = new System.Windows.Forms.OpenFileDialog();
            this.defineProgramDialog = new System.Windows.Forms.OpenFileDialog();
            this.defineFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.defineFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineProgramIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineFolderIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineURLIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineFileIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineCommandIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_CloseGameKitty = new System.Windows.Forms.ToolStripButton();
            this.button_MinimizeGameKitty = new System.Windows.Forms.ToolStripButton();
            this.label_GameKitty = new System.Windows.Forms.ToolStripLabel();
            this.button_OpenUniversal = new System.Windows.Forms.Button();
            this.button_OpenWindows10 = new System.Windows.Forms.Button();
            this.button_OpenModernApps = new System.Windows.Forms.Button();
            this.button_OpenCleaner = new System.Windows.Forms.Button();
            this.button_OpenRegistry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_OpenDefragment = new System.Windows.Forms.Button();
            this.tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameKittyLogo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpanel
            // 
            this.tpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpanel.Controls.Add(this.button_ResetConfig);
            this.tpanel.Controls.Add(this.txtBitness);
            this.tpanel.Controls.Add(this.txtOS);
            this.tpanel.Controls.Add(this.txtVersion);
            this.tpanel.Controls.Add(this.GameKittyLogo);
            this.tpanel.Controls.Add(this.button_RestartComputer);
            this.tpanel.Location = new System.Drawing.Point(0, 41);
            this.tpanel.Margin = new System.Windows.Forms.Padding(2);
            this.tpanel.Name = "tpanel";
            this.tpanel.Size = new System.Drawing.Size(600, 65);
            this.tpanel.TabIndex = 1;
            // 
            // button_ResetConfig
            // 
            this.button_ResetConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ResetConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_ResetConfig.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_ResetConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_ResetConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_ResetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetConfig.ForeColor = System.Drawing.Color.White;
            this.button_ResetConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_ResetConfig.Location = new System.Drawing.Point(431, 15);
            this.button_ResetConfig.Margin = new System.Windows.Forms.Padding(2);
            this.button_ResetConfig.Name = "button_ResetConfig";
            this.button_ResetConfig.Size = new System.Drawing.Size(155, 31);
            this.button_ResetConfig.TabIndex = 56;
            this.button_ResetConfig.Text = "Reset configuration";
            this.button_ResetConfig.UseVisualStyleBackColor = false;
            this.button_ResetConfig.Click += new System.EventHandler(this.button_ResetConfig_Click);
            // 
            // txtBitness
            // 
            this.txtBitness.AutoSize = true;
            this.txtBitness.ForeColor = System.Drawing.Color.DimGray;
            this.txtBitness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBitness.Location = new System.Drawing.Point(68, 38);
            this.txtBitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBitness.Size = new System.Drawing.Size(44, 15);
            this.txtBitness.TabIndex = 4;
            this.txtBitness.Text = "bitness";
            // 
            // txtOS
            // 
            this.txtOS.AutoSize = true;
            this.txtOS.ForeColor = System.Drawing.Color.DimGray;
            this.txtOS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtOS.Location = new System.Drawing.Point(68, 23);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOS.Name = "txtOS";
            this.txtOS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOS.Size = new System.Drawing.Size(19, 15);
            this.txtOS.TabIndex = 3;
            this.txtOS.Text = "os";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.ForeColor = System.Drawing.Color.DimGray;
            this.txtVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVersion.Location = new System.Drawing.Point(68, 8);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(49, 15);
            this.txtVersion.TabIndex = 1;
            this.txtVersion.Text = "Version:";
            // 
            // GameKittyLogo
            // 
            this.GameKittyLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameKittyLogo.Image = global::GameKitty.Properties.Resources.kitty;
            this.GameKittyLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GameKittyLogo.Location = new System.Drawing.Point(10, 10);
            this.GameKittyLogo.Margin = new System.Windows.Forms.Padding(2);
            this.GameKittyLogo.Name = "GameKittyLogo";
            this.GameKittyLogo.Size = new System.Drawing.Size(44, 43);
            this.GameKittyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameKittyLogo.TabIndex = 1;
            this.GameKittyLogo.TabStop = false;
            this.GameKittyLogo.Click += new System.EventHandler(this.GameKittyLogo_Click);
            // 
            // button_RestartComputer
            // 
            this.button_RestartComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RestartComputer.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_RestartComputer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_RestartComputer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_RestartComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_RestartComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RestartComputer.ForeColor = System.Drawing.Color.White;
            this.button_RestartComputer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_RestartComputer.Location = new System.Drawing.Point(303, 15);
            this.button_RestartComputer.Margin = new System.Windows.Forms.Padding(2);
            this.button_RestartComputer.Name = "button_RestartComputer";
            this.button_RestartComputer.Size = new System.Drawing.Size(115, 31);
            this.button_RestartComputer.TabIndex = 30;
            this.button_RestartComputer.Text = "Restart Computer";
            this.button_RestartComputer.UseVisualStyleBackColor = false;
            this.button_RestartComputer.Click += new System.EventHandler(this.button_RestartComputer_Click);
            // 
            // defineCommandDialog
            // 
            this.defineCommandDialog.Filter = "Executables [*.exe]|*.exe";
            this.defineCommandDialog.Title = "GameKitty | Select a file...";
            // 
            // defineProgramDialog
            // 
            this.defineProgramDialog.Filter = "Executables [*.exe]|*.exe";
            this.defineProgramDialog.Title = "GameKitty | Select a file...";
            // 
            // defineFolderDialog
            // 
            this.defineFolderDialog.Description = "GameKitty | Select a folder...";
            // 
            // defineFileDialog
            // 
            this.defineFileDialog.Filter = "All files [*.*]|*.*";
            this.defineFileDialog.Title = "GameKitty | Select a file...";
            // 
            // DefineProgramIconDialog
            // 
            this.DefineProgramIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineProgramIconDialog.Title = "GameKitty | Select an icon or program...";
            // 
            // DefineFolderIconDialog
            // 
            this.DefineFolderIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineFolderIconDialog.Title = "GameKitty | Select an icon or program...";
            // 
            // DefineURLIconDialog
            // 
            this.DefineURLIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineURLIconDialog.Title = "GameKitty | Select an icon or program...";
            // 
            // DefineFileIconDialog
            // 
            this.DefineFileIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineFileIconDialog.Title = "GameKitty | Select a file...";
            // 
            // DefineCommandIconDialog
            // 
            this.DefineCommandIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineCommandIconDialog.Title = "GameKitty | Select an icon or program...";
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
            this.button_MinimizeGameKitty,
            this.label_GameKitty});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(600, 41);
            this.toolStrip1.TabIndex = 3;
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
            // button_MinimizeGameKitty
            // 
            this.button_MinimizeGameKitty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_MinimizeGameKitty.Image = global::GameKitty.Properties.Resources.minimize_window;
            this.button_MinimizeGameKitty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_MinimizeGameKitty.Name = "button_MinimizeGameKitty";
            this.button_MinimizeGameKitty.Size = new System.Drawing.Size(28, 28);
            this.button_MinimizeGameKitty.Text = "MinimizeButton";
            this.button_MinimizeGameKitty.Click += new System.EventHandler(this.button_MinimizeGameKitty_Click);
            // 
            // label_GameKitty
            // 
            this.label_GameKitty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.label_GameKitty.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_GameKitty.ForeColor = System.Drawing.Color.Tomato;
            this.label_GameKitty.Name = "label_GameKitty";
            this.label_GameKitty.Size = new System.Drawing.Size(103, 28);
            this.label_GameKitty.Text = "GameKitty";
            // 
            // button_OpenUniversal
            // 
            this.button_OpenUniversal.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenUniversal.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenUniversal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenUniversal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenUniversal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenUniversal.ForeColor = System.Drawing.Color.White;
            this.button_OpenUniversal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_OpenUniversal.Location = new System.Drawing.Point(215, 150);
            this.button_OpenUniversal.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenUniversal.Name = "button_OpenUniversal";
            this.button_OpenUniversal.Size = new System.Drawing.Size(170, 32);
            this.button_OpenUniversal.TabIndex = 50;
            this.button_OpenUniversal.Text = "UNIVERSAL";
            this.button_OpenUniversal.UseVisualStyleBackColor = false;
            this.button_OpenUniversal.Click += new System.EventHandler(this.button_OpenUniversal_Click);
            // 
            // button_OpenWindows10
            // 
            this.button_OpenWindows10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenWindows10.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenWindows10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenWindows10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenWindows10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenWindows10.ForeColor = System.Drawing.Color.White;
            this.button_OpenWindows10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_OpenWindows10.Location = new System.Drawing.Point(215, 350);
            this.button_OpenWindows10.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenWindows10.Name = "button_OpenWindows10";
            this.button_OpenWindows10.Size = new System.Drawing.Size(170, 32);
            this.button_OpenWindows10.TabIndex = 51;
            this.button_OpenWindows10.Text = "WINDOWS 10";
            this.button_OpenWindows10.UseVisualStyleBackColor = false;
            this.button_OpenWindows10.Click += new System.EventHandler(this.button_OpenWindows10_Click);
            // 
            // button_OpenModernApps
            // 
            this.button_OpenModernApps.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenModernApps.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenModernApps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenModernApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenModernApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenModernApps.ForeColor = System.Drawing.Color.White;
            this.button_OpenModernApps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_OpenModernApps.Location = new System.Drawing.Point(215, 250);
            this.button_OpenModernApps.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenModernApps.Name = "button_OpenModernApps";
            this.button_OpenModernApps.Size = new System.Drawing.Size(170, 32);
            this.button_OpenModernApps.TabIndex = 52;
            this.button_OpenModernApps.Text = "MODERN APPS";
            this.button_OpenModernApps.UseVisualStyleBackColor = false;
            this.button_OpenModernApps.Click += new System.EventHandler(this.button_OpenModernApps_Click);
            // 
            // button_OpenCleaner
            // 
            this.button_OpenCleaner.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenCleaner.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenCleaner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenCleaner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenCleaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenCleaner.ForeColor = System.Drawing.Color.White;
            this.button_OpenCleaner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_OpenCleaner.Location = new System.Drawing.Point(11, 250);
            this.button_OpenCleaner.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenCleaner.Name = "button_OpenCleaner";
            this.button_OpenCleaner.Size = new System.Drawing.Size(170, 32);
            this.button_OpenCleaner.TabIndex = 53;
            this.button_OpenCleaner.Text = "CLEANER";
            this.button_OpenCleaner.UseVisualStyleBackColor = false;
            this.button_OpenCleaner.Click += new System.EventHandler(this.button_OpenCleaner_Click);
            // 
            // button_OpenRegistry
            // 
            this.button_OpenRegistry.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenRegistry.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenRegistry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenRegistry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenRegistry.ForeColor = System.Drawing.Color.White;
            this.button_OpenRegistry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_OpenRegistry.Location = new System.Drawing.Point(419, 250);
            this.button_OpenRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenRegistry.Name = "button_OpenRegistry";
            this.button_OpenRegistry.Size = new System.Drawing.Size(170, 32);
            this.button_OpenRegistry.TabIndex = 54;
            this.button_OpenRegistry.Text = "REGISTRY";
            this.button_OpenRegistry.UseVisualStyleBackColor = false;
            this.button_OpenRegistry.Click += new System.EventHandler(this.button_OpenRegistry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(11, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Copyright© 2019 - Created by TheElvenTale Games";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(341, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(248, 15);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.patreon.com/theelventalegames";
            // 
            // button_OpenDefragment
            // 
            this.button_OpenDefragment.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenDefragment.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenDefragment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenDefragment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenDefragment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenDefragment.ForeColor = System.Drawing.Color.White;
            this.button_OpenDefragment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_OpenDefragment.Location = new System.Drawing.Point(11, 300);
            this.button_OpenDefragment.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenDefragment.Name = "button_OpenDefragment";
            this.button_OpenDefragment.Size = new System.Drawing.Size(170, 32);
            this.button_OpenDefragment.TabIndex = 57;
            this.button_OpenDefragment.Text = "DEFRAGMENT";
            this.button_OpenDefragment.UseVisualStyleBackColor = false;
            this.button_OpenDefragment.Click += new System.EventHandler(this.button_OpenDefragment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(600, 425);
            this.ControlBox = false;
            this.Controls.Add(this.button_OpenDefragment);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OpenRegistry);
            this.Controls.Add(this.button_OpenCleaner);
            this.Controls.Add(this.button_OpenModernApps);
            this.Controls.Add(this.button_OpenWindows10);
            this.Controls.Add(this.button_OpenUniversal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameKitty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tpanel.ResumeLayout(false);
            this.tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameKittyLogo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tpanel;
        private System.Windows.Forms.Label txtBitness;
        private System.Windows.Forms.Label txtOS;
        private System.Windows.Forms.Label txtVersion;
        private System.Windows.Forms.PictureBox GameKittyLogo;
        private System.Windows.Forms.Button button_RestartComputer;
        internal System.Windows.Forms.OpenFileDialog defineCommandDialog;
        internal System.Windows.Forms.OpenFileDialog defineProgramDialog;
        internal System.Windows.Forms.FolderBrowserDialog defineFolderDialog;
        internal System.Windows.Forms.OpenFileDialog defineFileDialog;
        internal System.Windows.Forms.OpenFileDialog DefineProgramIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineFolderIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineURLIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineFileIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineCommandIconDialog;
        private System.Windows.Forms.Button button_ResetConfig;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_CloseGameKitty;
        private System.Windows.Forms.ToolStripButton button_MinimizeGameKitty;
        private System.Windows.Forms.ToolStripLabel label_GameKitty;
        private System.Windows.Forms.Button button_OpenUniversal;
        private System.Windows.Forms.Button button_OpenWindows10;
        private System.Windows.Forms.Button button_OpenModernApps;
        private System.Windows.Forms.Button button_OpenCleaner;
        private System.Windows.Forms.Button button_OpenRegistry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_OpenDefragment;
    }
}

