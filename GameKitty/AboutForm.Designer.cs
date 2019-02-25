namespace GameKitty
{
    partial class AboutForm
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
            this.GameKittyLogo = new System.Windows.Forms.PictureBox();
            this.button_about_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_opt_CheckUpdate = new System.Windows.Forms.Button();
            this.button_opt_ChangeLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameKittyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GameKittyLogo
            // 
            this.GameKittyLogo.Image = global::GameKitty.Properties.Resources.kitty;
            this.GameKittyLogo.Location = new System.Drawing.Point(11, 11);
            this.GameKittyLogo.Margin = new System.Windows.Forms.Padding(2);
            this.GameKittyLogo.Name = "GameKittyLogo";
            this.GameKittyLogo.Size = new System.Drawing.Size(88, 86);
            this.GameKittyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameKittyLogo.TabIndex = 2;
            this.GameKittyLogo.TabStop = false;
            // 
            // button_about_close
            // 
            this.button_about_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about_close.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_about_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_about_close.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_about_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_about_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_about_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about_close.ForeColor = System.Drawing.Color.White;
            this.button_about_close.Location = new System.Drawing.Point(305, 140);
            this.button_about_close.Margin = new System.Windows.Forms.Padding(2);
            this.button_about_close.Name = "button_about_close";
            this.button_about_close.Size = new System.Drawing.Size(71, 31);
            this.button_about_close.TabIndex = 36;
            this.button_about_close.Tag = "themeable";
            this.button_about_close.Text = "OK";
            this.button_about_close.UseVisualStyleBackColor = false;
            this.button_about_close.Click += new System.EventHandler(this.button_about_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(106, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "GameKitty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(107, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "created by TheElvenTale Games";
            // 
            // button_opt_CheckUpdate
            // 
            this.button_opt_CheckUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_opt_CheckUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_opt_CheckUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_opt_CheckUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_opt_CheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_opt_CheckUpdate.ForeColor = System.Drawing.Color.White;
            this.button_opt_CheckUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_opt_CheckUpdate.Location = new System.Drawing.Point(11, 105);
            this.button_opt_CheckUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.button_opt_CheckUpdate.Name = "button_opt_CheckUpdate";
            this.button_opt_CheckUpdate.Size = new System.Drawing.Size(155, 31);
            this.button_opt_CheckUpdate.TabIndex = 58;
            this.button_opt_CheckUpdate.Text = "Check for update";
            this.button_opt_CheckUpdate.UseVisualStyleBackColor = false;
            this.button_opt_CheckUpdate.Click += new System.EventHandler(this.button_opt_CheckUpdate_Click);
            // 
            // button_opt_ChangeLog
            // 
            this.button_opt_ChangeLog.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_opt_ChangeLog.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_opt_ChangeLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_opt_ChangeLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button_opt_ChangeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_opt_ChangeLog.ForeColor = System.Drawing.Color.White;
            this.button_opt_ChangeLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_opt_ChangeLog.Location = new System.Drawing.Point(11, 140);
            this.button_opt_ChangeLog.Margin = new System.Windows.Forms.Padding(2);
            this.button_opt_ChangeLog.Name = "button_opt_ChangeLog";
            this.button_opt_ChangeLog.Size = new System.Drawing.Size(155, 31);
            this.button_opt_ChangeLog.TabIndex = 59;
            this.button_opt_ChangeLog.Text = "View changes";
            this.button_opt_ChangeLog.UseVisualStyleBackColor = false;
            this.button_opt_ChangeLog.Click += new System.EventHandler(this.button_opt_ChangeLog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(107, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Copyright© 2019 - TheElvenTale Games";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.button_about_close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.button_about_close;
            this.ClientSize = new System.Drawing.Size(387, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_opt_ChangeLog);
            this.Controls.Add(this.button_opt_CheckUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_about_close);
            this.Controls.Add(this.GameKittyLogo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About GameKitty";
            ((System.ComponentModel.ISupportInitialize)(this.GameKittyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameKittyLogo;
        private System.Windows.Forms.Button button_about_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_opt_CheckUpdate;
        private System.Windows.Forms.Button button_opt_ChangeLog;
        private System.Windows.Forms.Label label3;
    }
}