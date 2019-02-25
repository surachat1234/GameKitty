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
            this.tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameKittyLogo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpanel
            // 
            resources.ApplyResources(this.tpanel, "tpanel");
            this.tpanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpanel.Controls.Add(this.button_ResetConfig);
            this.tpanel.Controls.Add(this.txtBitness);
            this.tpanel.Controls.Add(this.txtOS);
            this.tpanel.Controls.Add(this.txtVersion);
            this.tpanel.Controls.Add(this.GameKittyLogo);
            this.tpanel.Controls.Add(this.button_RestartComputer);
            this.tpanel.Name = "tpanel";
            // 
            // button_ResetConfig
            // 
            resources.ApplyResources(this.button_ResetConfig, "button_ResetConfig");
            this.button_ResetConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_ResetConfig.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_ResetConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_ResetConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_ResetConfig.ForeColor = System.Drawing.Color.White;
            this.button_ResetConfig.Name = "button_ResetConfig";
            this.button_ResetConfig.UseVisualStyleBackColor = false;
            this.button_ResetConfig.Click += new System.EventHandler(this.button_ResetConfig_Click);
            // 
            // txtBitness
            // 
            resources.ApplyResources(this.txtBitness, "txtBitness");
            this.txtBitness.ForeColor = System.Drawing.Color.DimGray;
            this.txtBitness.Name = "txtBitness";
            // 
            // txtOS
            // 
            resources.ApplyResources(this.txtOS, "txtOS");
            this.txtOS.ForeColor = System.Drawing.Color.DimGray;
            this.txtOS.Name = "txtOS";
            // 
            // txtVersion
            // 
            resources.ApplyResources(this.txtVersion, "txtVersion");
            this.txtVersion.ForeColor = System.Drawing.Color.DimGray;
            this.txtVersion.Name = "txtVersion";
            // 
            // GameKittyLogo
            // 
            this.GameKittyLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameKittyLogo.Image = global::GameKitty.Properties.Resources.kitty;
            resources.ApplyResources(this.GameKittyLogo, "GameKittyLogo");
            this.GameKittyLogo.Name = "GameKittyLogo";
            this.GameKittyLogo.TabStop = false;
            this.GameKittyLogo.Click += new System.EventHandler(this.GameKittyLogo_Click);
            // 
            // button_RestartComputer
            // 
            resources.ApplyResources(this.button_RestartComputer, "button_RestartComputer");
            this.button_RestartComputer.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_RestartComputer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_RestartComputer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_RestartComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_RestartComputer.ForeColor = System.Drawing.Color.White;
            this.button_RestartComputer.Name = "button_RestartComputer";
            this.button_RestartComputer.UseVisualStyleBackColor = false;
            this.button_RestartComputer.Click += new System.EventHandler(this.button_RestartComputer_Click);
            // 
            // defineCommandDialog
            // 
            resources.ApplyResources(this.defineCommandDialog, "defineCommandDialog");
            // 
            // defineProgramDialog
            // 
            resources.ApplyResources(this.defineProgramDialog, "defineProgramDialog");
            // 
            // defineFolderDialog
            // 
            resources.ApplyResources(this.defineFolderDialog, "defineFolderDialog");
            // 
            // defineFileDialog
            // 
            resources.ApplyResources(this.defineFileDialog, "defineFileDialog");
            // 
            // DefineProgramIconDialog
            // 
            resources.ApplyResources(this.DefineProgramIconDialog, "DefineProgramIconDialog");
            // 
            // DefineFolderIconDialog
            // 
            resources.ApplyResources(this.DefineFolderIconDialog, "DefineFolderIconDialog");
            // 
            // DefineURLIconDialog
            // 
            resources.ApplyResources(this.DefineURLIconDialog, "DefineURLIconDialog");
            // 
            // DefineFileIconDialog
            // 
            resources.ApplyResources(this.DefineFileIconDialog, "DefineFileIconDialog");
            // 
            // DefineCommandIconDialog
            // 
            resources.ApplyResources(this.DefineCommandIconDialog, "DefineCommandIconDialog");
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(4);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_CloseGameKitty,
            this.button_MinimizeGameKitty,
            this.label_GameKitty});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            // 
            // button_CloseGameKitty
            // 
            this.button_CloseGameKitty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_CloseGameKitty.Image = global::GameKitty.Properties.Resources.close_window;
            resources.ApplyResources(this.button_CloseGameKitty, "button_CloseGameKitty");
            this.button_CloseGameKitty.Name = "button_CloseGameKitty";
            this.button_CloseGameKitty.Click += new System.EventHandler(this.button_CloseGameKitty_Click);
            // 
            // button_MinimizeGameKitty
            // 
            this.button_MinimizeGameKitty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_MinimizeGameKitty.Image = global::GameKitty.Properties.Resources.minimize_window;
            resources.ApplyResources(this.button_MinimizeGameKitty, "button_MinimizeGameKitty");
            this.button_MinimizeGameKitty.Name = "button_MinimizeGameKitty";
            this.button_MinimizeGameKitty.Click += new System.EventHandler(this.button_MinimizeGameKitty_Click);
            // 
            // label_GameKitty
            // 
            this.label_GameKitty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.label_GameKitty, "label_GameKitty");
            this.label_GameKitty.ForeColor = System.Drawing.Color.Tomato;
            this.label_GameKitty.Name = "label_GameKitty";
            // 
            // button_OpenUniversal
            // 
            this.button_OpenUniversal.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenUniversal.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenUniversal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenUniversal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.button_OpenUniversal, "button_OpenUniversal");
            this.button_OpenUniversal.ForeColor = System.Drawing.Color.White;
            this.button_OpenUniversal.Name = "button_OpenUniversal";
            this.button_OpenUniversal.UseVisualStyleBackColor = false;
            this.button_OpenUniversal.Click += new System.EventHandler(this.button_OpenUniversal_Click);
            // 
            // button_OpenWindows10
            // 
            this.button_OpenWindows10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenWindows10.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenWindows10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenWindows10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.button_OpenWindows10, "button_OpenWindows10");
            this.button_OpenWindows10.ForeColor = System.Drawing.Color.White;
            this.button_OpenWindows10.Name = "button_OpenWindows10";
            this.button_OpenWindows10.UseVisualStyleBackColor = false;
            this.button_OpenWindows10.Click += new System.EventHandler(this.button_OpenWindows10_Click);
            // 
            // button_OpenModernApps
            // 
            this.button_OpenModernApps.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenModernApps.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenModernApps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenModernApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.button_OpenModernApps, "button_OpenModernApps");
            this.button_OpenModernApps.ForeColor = System.Drawing.Color.White;
            this.button_OpenModernApps.Name = "button_OpenModernApps";
            this.button_OpenModernApps.UseVisualStyleBackColor = false;
            this.button_OpenModernApps.Click += new System.EventHandler(this.button_OpenModernApps_Click);
            // 
            // button_OpenCleaner
            // 
            this.button_OpenCleaner.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenCleaner.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenCleaner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenCleaner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.button_OpenCleaner, "button_OpenCleaner");
            this.button_OpenCleaner.ForeColor = System.Drawing.Color.White;
            this.button_OpenCleaner.Name = "button_OpenCleaner";
            this.button_OpenCleaner.UseVisualStyleBackColor = false;
            this.button_OpenCleaner.Click += new System.EventHandler(this.button_OpenCleaner_Click);
            // 
            // button_OpenRegistry
            // 
            this.button_OpenRegistry.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenRegistry.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenRegistry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_OpenRegistry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.button_OpenRegistry, "button_OpenRegistry");
            this.button_OpenRegistry.ForeColor = System.Drawing.Color.White;
            this.button_OpenRegistry.Name = "button_OpenRegistry";
            this.button_OpenRegistry.UseVisualStyleBackColor = false;
            this.button_OpenRegistry.Click += new System.EventHandler(this.button_OpenRegistry_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OpenRegistry);
            this.Controls.Add(this.button_OpenCleaner);
            this.Controls.Add(this.button_OpenModernApps);
            this.Controls.Add(this.button_OpenWindows10);
            this.Controls.Add(this.button_OpenUniversal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
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
    }
}

