namespace GameKitty
{
    partial class ContentModernApps
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
            this.label_uwp_Header = new System.Windows.Forms.Label();
            this.listModernApps = new System.Windows.Forms.CheckedListBox();
            this.radio_uwp_SelectAll = new System.Windows.Forms.CheckBox();
            this.label_uwp_Side = new System.Windows.Forms.Label();
            this.button_uwp_Uninstall = new System.Windows.Forms.Button();
            this.button_uwp_Refresh = new System.Windows.Forms.Button();
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
            this.label_GameKitty.Size = new System.Drawing.Size(311, 28);
            this.label_GameKitty.Text = "GameKitty - Modern Apps Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_uwp_Header);
            this.panel1.Controls.Add(this.listModernApps);
            this.panel1.Controls.Add(this.radio_uwp_SelectAll);
            this.panel1.Controls.Add(this.label_uwp_Side);
            this.panel1.Controls.Add(this.button_uwp_Uninstall);
            this.panel1.Controls.Add(this.button_uwp_Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 345);
            this.panel1.TabIndex = 5;
            // 
            // label_uwp_Header
            // 
            this.label_uwp_Header.AutoSize = true;
            this.label_uwp_Header.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label_uwp_Header.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_uwp_Header.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_uwp_Header.Location = new System.Drawing.Point(10, 11);
            this.label_uwp_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_uwp_Header.Name = "label_uwp_Header";
            this.label_uwp_Header.Size = new System.Drawing.Size(291, 28);
            this.label_uwp_Header.TabIndex = 99;
            this.label_uwp_Header.Tag = "themeable";
            this.label_uwp_Header.Text = "Uninstall unwanted UWP Apps";
            // 
            // listModernApps
            // 
            this.listModernApps.BackColor = System.Drawing.Color.LavenderBlush;
            this.listModernApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listModernApps.CheckOnClick = true;
            this.listModernApps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listModernApps.ForeColor = System.Drawing.Color.DimGray;
            this.listModernApps.FormattingEnabled = true;
            this.listModernApps.HorizontalScrollbar = true;
            this.listModernApps.Location = new System.Drawing.Point(15, 52);
            this.listModernApps.Name = "listModernApps";
            this.listModernApps.Size = new System.Drawing.Size(485, 264);
            this.listModernApps.Sorted = true;
            this.listModernApps.TabIndex = 98;
            // 
            // radio_uwp_SelectAll
            // 
            this.radio_uwp_SelectAll.AutoSize = true;
            this.radio_uwp_SelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radio_uwp_SelectAll.ForeColor = System.Drawing.Color.DimGray;
            this.radio_uwp_SelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radio_uwp_SelectAll.Location = new System.Drawing.Point(529, 122);
            this.radio_uwp_SelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.radio_uwp_SelectAll.Name = "radio_uwp_SelectAll";
            this.radio_uwp_SelectAll.Size = new System.Drawing.Size(94, 25);
            this.radio_uwp_SelectAll.TabIndex = 103;
            this.radio_uwp_SelectAll.Text = "Select all";
            this.radio_uwp_SelectAll.UseVisualStyleBackColor = true;
            this.radio_uwp_SelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAllModernApps_CheckedChanged);
            // 
            // label_uwp_Side
            // 
            this.label_uwp_Side.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_uwp_Side.ForeColor = System.Drawing.Color.DimGray;
            this.label_uwp_Side.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_uwp_Side.Location = new System.Drawing.Point(525, 149);
            this.label_uwp_Side.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_uwp_Side.Name = "label_uwp_Side";
            this.label_uwp_Side.Size = new System.Drawing.Size(160, 64);
            this.label_uwp_Side.TabIndex = 102;
            this.label_uwp_Side.Tag = "";
            this.label_uwp_Side.Text = "Some apps can\'t be uninstalled.";
            // 
            // button_uwp_Uninstall
            // 
            this.button_uwp_Uninstall.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_uwp_Uninstall.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_uwp_Uninstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_uwp_Uninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_uwp_Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_uwp_Uninstall.ForeColor = System.Drawing.Color.White;
            this.button_uwp_Uninstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_uwp_Uninstall.Location = new System.Drawing.Point(529, 87);
            this.button_uwp_Uninstall.Margin = new System.Windows.Forms.Padding(2);
            this.button_uwp_Uninstall.Name = "button_uwp_Uninstall";
            this.button_uwp_Uninstall.Size = new System.Drawing.Size(169, 31);
            this.button_uwp_Uninstall.TabIndex = 101;
            this.button_uwp_Uninstall.Text = "Uninstall";
            this.button_uwp_Uninstall.UseVisualStyleBackColor = false;
            this.button_uwp_Uninstall.Click += new System.EventHandler(this.button_uwp_Uninstall_Click);
            // 
            // button_uwp_Refresh
            // 
            this.button_uwp_Refresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_uwp_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_uwp_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_uwp_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_uwp_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_uwp_Refresh.ForeColor = System.Drawing.Color.White;
            this.button_uwp_Refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_uwp_Refresh.Location = new System.Drawing.Point(529, 52);
            this.button_uwp_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_uwp_Refresh.Name = "button_uwp_Refresh";
            this.button_uwp_Refresh.Size = new System.Drawing.Size(169, 31);
            this.button_uwp_Refresh.TabIndex = 100;
            this.button_uwp_Refresh.Text = "Refresh";
            this.button_uwp_Refresh.UseVisualStyleBackColor = false;
            this.button_uwp_Refresh.Click += new System.EventHandler(this.button_uwp_Refresh_Click);
            // 
            // ContentModernApps
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
            this.Name = "ContentModernApps";
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
        private System.Windows.Forms.Label label_uwp_Header;
        private System.Windows.Forms.CheckedListBox listModernApps;
        private System.Windows.Forms.CheckBox radio_uwp_SelectAll;
        private System.Windows.Forms.Label label_uwp_Side;
        private System.Windows.Forms.Button button_uwp_Uninstall;
        private System.Windows.Forms.Button button_uwp_Refresh;
    }
}