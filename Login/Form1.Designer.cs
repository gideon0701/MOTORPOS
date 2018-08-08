using System;

namespace PointOfSalesApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msmForm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.appName1 = new System.Windows.Forms.Label();
            this.appName2 = new System.Windows.Forms.Label();
            this.lblSignIn = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.passWrdIcon = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new MetroFramework.Controls.MetroButton();
            this.lblDisc1 = new MetroFramework.Controls.MetroLabel();
            this.lblDisc2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmForm)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passWrdIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // msmForm
            // 
            this.msmForm.Owner = this;
            this.msmForm.Style = MetroFramework.MetroColorStyle.Silver;
            this.msmForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // appName1
            // 
            this.appName1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appName1.AutoSize = true;
            this.appName1.BackColor = System.Drawing.Color.Transparent;
            this.appName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.appName1.Location = new System.Drawing.Point(42, 128);
            this.appName1.Name = "appName1";
            this.appName1.Size = new System.Drawing.Size(240, 38);
            this.appName1.TabIndex = 8;
            this.appName1.Text = "MOTORPOINT";
            this.appName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appName2
            // 
            this.appName2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appName2.AutoSize = true;
            this.appName2.BackColor = System.Drawing.Color.Transparent;
            this.appName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.appName2.Location = new System.Drawing.Point(50, 161);
            this.appName2.Name = "appName2";
            this.appName2.Size = new System.Drawing.Size(216, 18);
            this.appName2.TabIndex = 2;
            this.appName2.Text = "motorcyle parts and accesories";
            this.appName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignIn
            // 
            this.lblSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSignIn.Location = new System.Drawing.Point(49, 222);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(66, 25);
            this.lblSignIn.TabIndex = 4;
            this.lblSignIn.Text = "Sign-In";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel1.Controls.Add(this.userIcon);
            this.metroPanel1.Controls.Add(this.txtUserName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(53, 250);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(218, 30);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.Image = global::PointOfSalesApp.Properties.Resources.user_icon_2x;
            this.userIcon.Location = new System.Drawing.Point(0, 3);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(24, 26);
            this.userIcon.TabIndex = 6;
            this.userIcon.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Location = new System.Drawing.Point(27, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PromptText = "Please input";
            this.txtUserName.Size = new System.Drawing.Size(185, 23);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "username";
            this.txtUserName.UseWaitCursor = true;
            this.txtUserName.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel2.Controls.Add(this.passWrdIcon);
            this.metroPanel2.Controls.Add(this.txtPassword);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(53, 295);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(218, 30);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // passWrdIcon
            // 
            this.passWrdIcon.BackColor = System.Drawing.Color.Transparent;
            this.passWrdIcon.Image = global::PointOfSalesApp.Properties.Resources.lock_ico_2x;
            this.passWrdIcon.Location = new System.Drawing.Point(0, 3);
            this.passWrdIcon.Name = "passWrdIcon";
            this.passWrdIcon.Size = new System.Drawing.Size(24, 26);
            this.passWrdIcon.TabIndex = 6;
            this.passWrdIcon.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Location = new System.Drawing.Point(27, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // appLogo
            // 
            this.appLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.appLogo.Image = global::PointOfSalesApp.Properties.Resources.cabildo_motor_parts_pos;
            this.appLogo.Location = new System.Drawing.Point(129, 63);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(63, 62);
            this.appLogo.TabIndex = 3;
            this.appLogo.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.Location = new System.Drawing.Point(117, 359);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.Enter += new System.EventHandler(this.btnSignIn_Enter);
            // 
            // lblDisc1
            // 
            this.lblDisc1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDisc1.AutoSize = true;
            this.lblDisc1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDisc1.Location = new System.Drawing.Point(66, 552);
            this.lblDisc1.Name = "lblDisc1";
            this.lblDisc1.Size = new System.Drawing.Size(191, 15);
            this.lblDisc1.TabIndex = 9;
            this.lblDisc1.Text = "MOTORPOINT Point of Sales System";
            // 
            // lblDisc2
            // 
            this.lblDisc2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDisc2.AutoSize = true;
            this.lblDisc2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDisc2.Location = new System.Drawing.Point(91, 567);
            this.lblDisc2.Name = "lblDisc2";
            this.lblDisc2.Size = new System.Drawing.Size(140, 15);
            this.lblDisc2.TabIndex = 10;
            this.lblDisc2.Text = "All Rights Reserved ©2018";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 600);
            this.Controls.Add(this.lblDisc2);
            this.Controls.Add(this.lblDisc1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.appLogo);
            this.Controls.Add(this.appName2);
            this.Controls.Add(this.appName1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 600);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Point-of-Sales";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmForm)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passWrdIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmForm;
        private MetroFramework.Controls.MetroLabel lblDisc2;
        private MetroFramework.Controls.MetroLabel lblDisc1;
        private System.Windows.Forms.Label appName1;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label appName2;
        private MetroFramework.Controls.MetroLabel lblSignIn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox userIcon;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox passWrdIcon;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnSignIn;

    }
}

