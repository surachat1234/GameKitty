namespace GameKitty
{
    partial class ContentRegistry
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
            this.button_reg_Fix = new System.Windows.Forms.Button();
            this.label_reg_Footer = new System.Windows.Forms.Label();
            this.radio_reg_RestartExplorer = new System.Windows.Forms.CheckBox();
            this.radio_reg_RegEdit = new System.Windows.Forms.CheckBox();
            this.radio_reg_EnableAll = new System.Windows.Forms.CheckBox();
            this.radio_reg_RightClickMenu = new System.Windows.Forms.CheckBox();
            this.radio_reg_TaskManager = new System.Windows.Forms.CheckBox();
            this.radio_reg_Cmd = new System.Windows.Forms.CheckBox();
            this.radio_reg_Firewall = new System.Windows.Forms.CheckBox();
            this.radio_reg_RunDialog = new System.Windows.Forms.CheckBox();
            this.radio_reg_FolderOptions = new System.Windows.Forms.CheckBox();
            this.radio_reg_ControlPanel = new System.Windows.Forms.CheckBox();
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
            this.label_GameKitty.Size = new System.Drawing.Size(265, 28);
            this.label_GameKitty.Text = "GameKitty - Registry Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_reg_Fix);
            this.panel1.Controls.Add(this.label_reg_Footer);
            this.panel1.Controls.Add(this.radio_reg_RestartExplorer);
            this.panel1.Controls.Add(this.radio_reg_RegEdit);
            this.panel1.Controls.Add(this.radio_reg_EnableAll);
            this.panel1.Controls.Add(this.radio_reg_RightClickMenu);
            this.panel1.Controls.Add(this.radio_reg_TaskManager);
            this.panel1.Controls.Add(this.radio_reg_Cmd);
            this.panel1.Controls.Add(this.radio_reg_Firewall);
            this.panel1.Controls.Add(this.radio_reg_RunDialog);
            this.panel1.Controls.Add(this.radio_reg_FolderOptions);
            this.panel1.Controls.Add(this.radio_reg_ControlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 345);
            this.panel1.TabIndex = 5;
            // 
            // button_reg_Fix
            // 
            this.button_reg_Fix.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_reg_Fix.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_reg_Fix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_reg_Fix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_reg_Fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg_Fix.ForeColor = System.Drawing.Color.White;
            this.button_reg_Fix.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_reg_Fix.Location = new System.Drawing.Point(630, 303);
            this.button_reg_Fix.Margin = new System.Windows.Forms.Padding(2);
            this.button_reg_Fix.Name = "button_reg_Fix";
            this.button_reg_Fix.Size = new System.Drawing.Size(71, 31);
            this.button_reg_Fix.TabIndex = 61;
            this.button_reg_Fix.Text = "Fix";
            this.button_reg_Fix.UseVisualStyleBackColor = false;
            this.button_reg_Fix.Click += new System.EventHandler(this.button_reg_Fix_Click);
            // 
            // label_reg_Footer
            // 
            this.label_reg_Footer.AutoSize = true;
            this.label_reg_Footer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_reg_Footer.ForeColor = System.Drawing.Color.DimGray;
            this.label_reg_Footer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_reg_Footer.Location = new System.Drawing.Point(113, 205);
            this.label_reg_Footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_reg_Footer.Name = "label_reg_Footer";
            this.label_reg_Footer.Size = new System.Drawing.Size(242, 21);
            this.label_reg_Footer.TabIndex = 63;
            this.label_reg_Footer.Tag = "";
            this.label_reg_Footer.Text = "(some changes might need this)";
            // 
            // radio_reg_RestartExplorer
            // 
            this.radio_reg_RestartExplorer.AutoSize = true;
            this.radio_reg_RestartExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_RestartExplorer.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_RestartExplorer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_RestartExplorer.Location = new System.Drawing.Point(20, 178);
            this.radio_reg_RestartExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_RestartExplorer.Name = "radio_reg_RestartExplorer";
            this.radio_reg_RestartExplorer.Size = new System.Drawing.Size(336, 25);
            this.radio_reg_RestartExplorer.TabIndex = 62;
            this.radio_reg_RestartExplorer.Tag = "";
            this.radio_reg_RestartExplorer.Text = "Also restart explorer.exe to apply changes";
            this.radio_reg_RestartExplorer.UseVisualStyleBackColor = true;
            // 
            // radio_reg_RegEdit
            // 
            this.radio_reg_RegEdit.AutoSize = true;
            this.radio_reg_RegEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_RegEdit.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_RegEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_RegEdit.Location = new System.Drawing.Point(247, 139);
            this.radio_reg_RegEdit.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_RegEdit.Name = "radio_reg_RegEdit";
            this.radio_reg_RegEdit.Size = new System.Drawing.Size(138, 25);
            this.radio_reg_RegEdit.TabIndex = 55;
            this.radio_reg_RegEdit.Text = "Registry Editor";
            this.radio_reg_RegEdit.UseVisualStyleBackColor = true;
            // 
            // radio_reg_EnableAll
            // 
            this.radio_reg_EnableAll.AutoSize = true;
            this.radio_reg_EnableAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_EnableAll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radio_reg_EnableAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_EnableAll.Location = new System.Drawing.Point(20, 17);
            this.radio_reg_EnableAll.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_EnableAll.Name = "radio_reg_EnableAll";
            this.radio_reg_EnableAll.Size = new System.Drawing.Size(97, 25);
            this.radio_reg_EnableAll.TabIndex = 52;
            this.radio_reg_EnableAll.Tag = "themeable";
            this.radio_reg_EnableAll.Text = "Enable all";
            this.radio_reg_EnableAll.UseVisualStyleBackColor = true;
            this.radio_reg_EnableAll.CheckedChanged += new System.EventHandler(this.checkEnableAll_CheckedChanged);
            // 
            // radio_reg_RightClickMenu
            // 
            this.radio_reg_RightClickMenu.AutoSize = true;
            this.radio_reg_RightClickMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_RightClickMenu.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_RightClickMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_RightClickMenu.Location = new System.Drawing.Point(247, 78);
            this.radio_reg_RightClickMenu.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_RightClickMenu.Name = "radio_reg_RightClickMenu";
            this.radio_reg_RightClickMenu.Size = new System.Drawing.Size(151, 25);
            this.radio_reg_RightClickMenu.TabIndex = 60;
            this.radio_reg_RightClickMenu.Text = "Right Click menu";
            this.radio_reg_RightClickMenu.UseVisualStyleBackColor = true;
            // 
            // radio_reg_TaskManager
            // 
            this.radio_reg_TaskManager.AutoSize = true;
            this.radio_reg_TaskManager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_TaskManager.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_TaskManager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_TaskManager.Location = new System.Drawing.Point(46, 48);
            this.radio_reg_TaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_TaskManager.Name = "radio_reg_TaskManager";
            this.radio_reg_TaskManager.Size = new System.Drawing.Size(128, 25);
            this.radio_reg_TaskManager.TabIndex = 53;
            this.radio_reg_TaskManager.Text = "Task Manager";
            this.radio_reg_TaskManager.UseVisualStyleBackColor = true;
            // 
            // radio_reg_Cmd
            // 
            this.radio_reg_Cmd.AutoSize = true;
            this.radio_reg_Cmd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_Cmd.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_Cmd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_Cmd.Location = new System.Drawing.Point(46, 78);
            this.radio_reg_Cmd.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_Cmd.Name = "radio_reg_Cmd";
            this.radio_reg_Cmd.Size = new System.Drawing.Size(163, 25);
            this.radio_reg_Cmd.TabIndex = 59;
            this.radio_reg_Cmd.Text = "Command Prompt";
            this.radio_reg_Cmd.UseVisualStyleBackColor = true;
            // 
            // radio_reg_Firewall
            // 
            this.radio_reg_Firewall.AutoSize = true;
            this.radio_reg_Firewall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_Firewall.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_Firewall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_Firewall.Location = new System.Drawing.Point(247, 109);
            this.radio_reg_Firewall.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_Firewall.Name = "radio_reg_Firewall";
            this.radio_reg_Firewall.Size = new System.Drawing.Size(155, 25);
            this.radio_reg_Firewall.TabIndex = 54;
            this.radio_reg_Firewall.Text = "Windows Firewall";
            this.radio_reg_Firewall.UseVisualStyleBackColor = true;
            // 
            // radio_reg_RunDialog
            // 
            this.radio_reg_RunDialog.AutoSize = true;
            this.radio_reg_RunDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_RunDialog.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_RunDialog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_RunDialog.Location = new System.Drawing.Point(247, 48);
            this.radio_reg_RunDialog.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_RunDialog.Name = "radio_reg_RunDialog";
            this.radio_reg_RunDialog.Size = new System.Drawing.Size(108, 25);
            this.radio_reg_RunDialog.TabIndex = 58;
            this.radio_reg_RunDialog.Text = "Run Dialog";
            this.radio_reg_RunDialog.UseVisualStyleBackColor = true;
            // 
            // radio_reg_FolderOptions
            // 
            this.radio_reg_FolderOptions.AutoSize = true;
            this.radio_reg_FolderOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_FolderOptions.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_FolderOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_FolderOptions.Location = new System.Drawing.Point(46, 139);
            this.radio_reg_FolderOptions.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_FolderOptions.Name = "radio_reg_FolderOptions";
            this.radio_reg_FolderOptions.Size = new System.Drawing.Size(138, 25);
            this.radio_reg_FolderOptions.TabIndex = 56;
            this.radio_reg_FolderOptions.Text = "Folder Options";
            this.radio_reg_FolderOptions.UseVisualStyleBackColor = true;
            // 
            // radio_reg_ControlPanel
            // 
            this.radio_reg_ControlPanel.AutoSize = true;
            this.radio_reg_ControlPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_reg_ControlPanel.ForeColor = System.Drawing.Color.DimGray;
            this.radio_reg_ControlPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_reg_ControlPanel.Location = new System.Drawing.Point(46, 109);
            this.radio_reg_ControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.radio_reg_ControlPanel.Name = "radio_reg_ControlPanel";
            this.radio_reg_ControlPanel.Size = new System.Drawing.Size(127, 25);
            this.radio_reg_ControlPanel.TabIndex = 57;
            this.radio_reg_ControlPanel.Text = "Control Panel";
            this.radio_reg_ControlPanel.UseVisualStyleBackColor = true;
            // 
            // ContentRegistry
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
            this.Name = "ContentRegistry";
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
        private System.Windows.Forms.Button button_reg_Fix;
        private System.Windows.Forms.Label label_reg_Footer;
        private System.Windows.Forms.CheckBox radio_reg_RestartExplorer;
        private System.Windows.Forms.CheckBox radio_reg_RegEdit;
        private System.Windows.Forms.CheckBox radio_reg_EnableAll;
        private System.Windows.Forms.CheckBox radio_reg_RightClickMenu;
        private System.Windows.Forms.CheckBox radio_reg_TaskManager;
        private System.Windows.Forms.CheckBox radio_reg_Cmd;
        private System.Windows.Forms.CheckBox radio_reg_Firewall;
        private System.Windows.Forms.CheckBox radio_reg_RunDialog;
        private System.Windows.Forms.CheckBox radio_reg_FolderOptions;
        private System.Windows.Forms.CheckBox radio_reg_ControlPanel;
    }
}