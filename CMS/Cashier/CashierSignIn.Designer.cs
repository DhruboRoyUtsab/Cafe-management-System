namespace CMS
{
    partial class CashierSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierSignIn));
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.AdminSignInPanel = new System.Windows.Forms.Panel();
            this.btnCashierSignIn = new System.Windows.Forms.Button();
            this.cbCashierShowPassword = new System.Windows.Forms.CheckBox();
            this.tbCashierPassword = new System.Windows.Forms.TextBox();
            this.tbCashierUserName = new System.Windows.Forms.TextBox();
            this.lblCashierPassword = new System.Windows.Forms.Label();
            this.lblCashierUserName = new System.Windows.Forms.Label();
            this.lblCashierSignIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminSignInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(590, 661);
            this.LogoPanel.TabIndex = 1;
            // 
            // AdminSignInPanel
            // 
            this.AdminSignInPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminSignInPanel.BackgroundImage")));
            this.AdminSignInPanel.Controls.Add(this.btnCashierSignIn);
            this.AdminSignInPanel.Controls.Add(this.cbCashierShowPassword);
            this.AdminSignInPanel.Controls.Add(this.tbCashierPassword);
            this.AdminSignInPanel.Controls.Add(this.tbCashierUserName);
            this.AdminSignInPanel.Controls.Add(this.lblCashierPassword);
            this.AdminSignInPanel.Controls.Add(this.lblCashierUserName);
            this.AdminSignInPanel.Controls.Add(this.lblCashierSignIn);
            this.AdminSignInPanel.Controls.Add(this.panel1);
            this.AdminSignInPanel.Location = new System.Drawing.Point(-8, -20);
            this.AdminSignInPanel.Name = "AdminSignInPanel";
            this.AdminSignInPanel.Size = new System.Drawing.Size(1200, 700);
            this.AdminSignInPanel.TabIndex = 2;
            // 
            // btnCashierSignIn
            // 
            this.btnCashierSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashierSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashierSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashierSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnCashierSignIn.Location = new System.Drawing.Point(837, 366);
            this.btnCashierSignIn.Name = "btnCashierSignIn";
            this.btnCashierSignIn.Size = new System.Drawing.Size(120, 40);
            this.btnCashierSignIn.TabIndex = 7;
            this.btnCashierSignIn.Text = "Sign In";
            this.btnCashierSignIn.UseVisualStyleBackColor = false;
            // 
            // cbCashierShowPassword
            // 
            this.cbCashierShowPassword.AutoSize = true;
            this.cbCashierShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbCashierShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbCashierShowPassword.Location = new System.Drawing.Point(837, 287);
            this.cbCashierShowPassword.Name = "cbCashierShowPassword";
            this.cbCashierShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cbCashierShowPassword.TabIndex = 6;
            this.cbCashierShowPassword.Text = "Show Password";
            this.cbCashierShowPassword.UseVisualStyleBackColor = false;
            this.cbCashierShowPassword.CheckedChanged += new System.EventHandler(this.cbCashierShowPassword_CheckedChanged);
            // 
            // tbCashierPassword
            // 
            this.tbCashierPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashierPassword.Location = new System.Drawing.Point(837, 250);
            this.tbCashierPassword.Name = "tbCashierPassword";
            this.tbCashierPassword.PasswordChar = '*';
            this.tbCashierPassword.Size = new System.Drawing.Size(220, 31);
            this.tbCashierPassword.TabIndex = 5;
            // 
            // tbCashierUserName
            // 
            this.tbCashierUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashierUserName.Location = new System.Drawing.Point(837, 193);
            this.tbCashierUserName.Name = "tbCashierUserName";
            this.tbCashierUserName.Size = new System.Drawing.Size(220, 31);
            this.tbCashierUserName.TabIndex = 4;
            // 
            // lblCashierPassword
            // 
            this.lblCashierPassword.AutoSize = true;
            this.lblCashierPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCashierPassword.Location = new System.Drawing.Point(703, 250);
            this.lblCashierPassword.Name = "lblCashierPassword";
            this.lblCashierPassword.Size = new System.Drawing.Size(102, 24);
            this.lblCashierPassword.TabIndex = 3;
            this.lblCashierPassword.Text = "Password :";
            // 
            // lblCashierUserName
            // 
            this.lblCashierUserName.AutoSize = true;
            this.lblCashierUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCashierUserName.Location = new System.Drawing.Point(698, 193);
            this.lblCashierUserName.Name = "lblCashierUserName";
            this.lblCashierUserName.Size = new System.Drawing.Size(107, 24);
            this.lblCashierUserName.TabIndex = 2;
            this.lblCashierUserName.Text = "Username :";
            // 
            // lblCashierSignIn
            // 
            this.lblCashierSignIn.AutoSize = true;
            this.lblCashierSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierSignIn.ForeColor = System.Drawing.Color.White;
            this.lblCashierSignIn.Location = new System.Drawing.Point(679, 88);
            this.lblCashierSignIn.Name = "lblCashierSignIn";
            this.lblCashierSignIn.Size = new System.Drawing.Size(429, 55);
            this.lblCashierSignIn.TabIndex = 1;
            this.lblCashierSignIn.Text = "CASHIER SIGN IN";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 700);
            this.panel1.TabIndex = 0;
            // 
            // CashierSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.AdminSignInPanel);
            this.Controls.Add(this.LogoPanel);
            this.Name = "CashierSignIn";
            this.Text = "Form1";
            this.AdminSignInPanel.ResumeLayout(false);
            this.AdminSignInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel AdminSignInPanel;
        private System.Windows.Forms.Button btnCashierSignIn;
        private System.Windows.Forms.CheckBox cbCashierShowPassword;
        private System.Windows.Forms.TextBox tbCashierPassword;
        private System.Windows.Forms.TextBox tbCashierUserName;
        private System.Windows.Forms.Label lblCashierPassword;
        private System.Windows.Forms.Label lblCashierUserName;
        private System.Windows.Forms.Label lblCashierSignIn;
        private System.Windows.Forms.Panel panel1;
    }
}