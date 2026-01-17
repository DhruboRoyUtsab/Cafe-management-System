namespace CMS
{
    partial class AdminSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignIn));
            this.AdminSignInPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BckBtn = new System.Windows.Forms.Button();
            this.BtnAdminSIgnIn = new System.Windows.Forms.Button();
            this.TBAdminPassword = new System.Windows.Forms.TextBox();
            this.TBAdminUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.AdminSignInPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminSignInPanel
            // 
            this.AdminSignInPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminSignInPanel.BackgroundImage")));
            this.AdminSignInPanel.Controls.Add(this.panel1);
            this.AdminSignInPanel.Controls.Add(this.BtnSignIn);
            this.AdminSignInPanel.Controls.Add(this.ShowPassword);
            this.AdminSignInPanel.Controls.Add(this.TBPassword);
            this.AdminSignInPanel.Controls.Add(this.TBUserName);
            this.AdminSignInPanel.Controls.Add(this.lblPassword);
            this.AdminSignInPanel.Controls.Add(this.lblUserName);
            this.AdminSignInPanel.Controls.Add(this.lblSignIn);
            this.AdminSignInPanel.Controls.Add(this.LogoPanel);
            this.AdminSignInPanel.Location = new System.Drawing.Point(-3, -5);
            this.AdminSignInPanel.Name = "AdminSignInPanel";
            this.AdminSignInPanel.Size = new System.Drawing.Size(1200, 700);
            this.AdminSignInPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BckBtn);
            this.panel1.Controls.Add(this.BtnAdminSIgnIn);
            this.panel1.Controls.Add(this.TBAdminPassword);
            this.panel1.Controls.Add(this.TBAdminUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BckBtn
            // 
            this.BckBtn.BackColor = System.Drawing.Color.Gray;
            this.BckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BckBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BckBtn.Location = new System.Drawing.Point(805, 511);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(100, 35);
            this.BckBtn.TabIndex = 54;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = false;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // BtnAdminSIgnIn
            // 
            this.BtnAdminSIgnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAdminSIgnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdminSIgnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminSIgnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdminSIgnIn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAdminSIgnIn.Location = new System.Drawing.Point(793, 346);
            this.BtnAdminSIgnIn.Name = "BtnAdminSIgnIn";
            this.BtnAdminSIgnIn.Size = new System.Drawing.Size(120, 40);
            this.BtnAdminSIgnIn.TabIndex = 7;
            this.BtnAdminSIgnIn.Text = "Sign In";
            this.BtnAdminSIgnIn.UseVisualStyleBackColor = false;
            this.BtnAdminSIgnIn.Click += new System.EventHandler(this.BtnAdminSIgnIn_Click);
            // 
            // TBAdminPassword
            // 
            this.TBAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAdminPassword.Location = new System.Drawing.Point(772, 238);
            this.TBAdminPassword.Name = "TBAdminPassword";
            this.TBAdminPassword.PasswordChar = '*';
            this.TBAdminPassword.Size = new System.Drawing.Size(220, 31);
            this.TBAdminPassword.TabIndex = 5;
            // 
            // TBAdminUsername
            // 
            this.TBAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAdminUsername.Location = new System.Drawing.Point(772, 170);
            this.TBAdminUsername.Name = "TBAdminUsername";
            this.TBAdminUsername.Size = new System.Drawing.Size(220, 31);
            this.TBAdminUsername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(654, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(646, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(690, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADMIN SIGN IN";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 700);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSignIn.Location = new System.Drawing.Point(793, 346);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(120, 40);
            this.BtnSignIn.TabIndex = 7;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.ForeColor = System.Drawing.Color.White;
            this.ShowPassword.Location = new System.Drawing.Point(772, 275);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = false;
            // 
            // TBPassword
            // 
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(772, 238);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(220, 31);
            this.TBPassword.TabIndex = 5;
            // 
            // TBUserName
            // 
            this.TBUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserName.Location = new System.Drawing.Point(772, 170);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(220, 31);
            this.TBUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(654, 242);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password :";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(646, 174);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(107, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username :";
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(690, 55);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(370, 55);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "ADMIN SIGN IN";
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(590, 700);
            this.LogoPanel.TabIndex = 0;
            // 
            // AdminSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.AdminSignInPanel);
            this.Name = "AdminSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Sign In";
            this.AdminSignInPanel.ResumeLayout(false);
            this.AdminSignInPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AdminSignInPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAdminSIgnIn;
        private System.Windows.Forms.TextBox TBAdminPassword;
        private System.Windows.Forms.TextBox TBAdminUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BckBtn;
    }
}

