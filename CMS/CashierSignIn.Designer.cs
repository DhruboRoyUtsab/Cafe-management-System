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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCashierPassword = new System.Windows.Forms.TextBox();
            this.lblCashierLogin = new System.Windows.Forms.Label();
            this.txtCashierUsername = new System.Windows.Forms.TextBox();
            this.lblCashierUsername = new System.Windows.Forms.Label();
            this.lblCashierPassword = new System.Windows.Forms.Label();
            this.btnCashierSignIn = new System.Windows.Forms.Button();
            this.cbCashierShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 661);
            this.panel1.TabIndex = 0;
            // 
            // txtCashierPassword
            // 
            this.txtCashierPassword.BackColor = System.Drawing.Color.White;
            this.txtCashierPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierPassword.Location = new System.Drawing.Point(792, 263);
            this.txtCashierPassword.Name = "txtCashierPassword";
            this.txtCashierPassword.Size = new System.Drawing.Size(200, 31);
            this.txtCashierPassword.TabIndex = 2;
            // 
            // lblCashierLogin
            // 
            this.lblCashierLogin.AutoSize = true;
            this.lblCashierLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierLogin.ForeColor = System.Drawing.Color.White;
            this.lblCashierLogin.Location = new System.Drawing.Point(739, 111);
            this.lblCashierLogin.Name = "lblCashierLogin";
            this.lblCashierLogin.Size = new System.Drawing.Size(299, 39);
            this.lblCashierLogin.TabIndex = 3;
            this.lblCashierLogin.Text = "CASHIER LOGIN";
            this.lblCashierLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCashierUsername
            // 
            this.txtCashierUsername.BackColor = System.Drawing.Color.White;
            this.txtCashierUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierUsername.Location = new System.Drawing.Point(792, 200);
            this.txtCashierUsername.Name = "txtCashierUsername";
            this.txtCashierUsername.Size = new System.Drawing.Size(200, 31);
            this.txtCashierUsername.TabIndex = 4;
            // 
            // lblCashierUsername
            // 
            this.lblCashierUsername.AutoSize = true;
            this.lblCashierUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierUsername.ForeColor = System.Drawing.Color.White;
            this.lblCashierUsername.Location = new System.Drawing.Point(635, 206);
            this.lblCashierUsername.Name = "lblCashierUsername";
            this.lblCashierUsername.Size = new System.Drawing.Size(122, 25);
            this.lblCashierUsername.TabIndex = 6;
            this.lblCashierUsername.Text = "Username :";
            // 
            // lblCashierPassword
            // 
            this.lblCashierPassword.AutoSize = true;
            this.lblCashierPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierPassword.ForeColor = System.Drawing.Color.White;
            this.lblCashierPassword.Location = new System.Drawing.Point(639, 269);
            this.lblCashierPassword.Name = "lblCashierPassword";
            this.lblCashierPassword.Size = new System.Drawing.Size(118, 25);
            this.lblCashierPassword.TabIndex = 7;
            this.lblCashierPassword.Text = "Password :";
            // 
            // btnCashierSignIn
            // 
            this.btnCashierSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashierSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashierSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashierSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnCashierSignIn.Location = new System.Drawing.Point(826, 369);
            this.btnCashierSignIn.Name = "btnCashierSignIn";
            this.btnCashierSignIn.Size = new System.Drawing.Size(120, 40);
            this.btnCashierSignIn.TabIndex = 9;
            this.btnCashierSignIn.Text = "Sign In";
            this.btnCashierSignIn.UseVisualStyleBackColor = false;
            this.btnCashierSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // cbCashierShowPass
            // 
            this.cbCashierShowPass.AutoSize = true;
            this.cbCashierShowPass.BackColor = System.Drawing.Color.Transparent;
            this.cbCashierShowPass.ForeColor = System.Drawing.Color.White;
            this.cbCashierShowPass.Location = new System.Drawing.Point(792, 300);
            this.cbCashierShowPass.Name = "cbCashierShowPass";
            this.cbCashierShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbCashierShowPass.TabIndex = 10;
            this.cbCashierShowPass.Text = "Show Password";
            this.cbCashierShowPass.UseVisualStyleBackColor = false;
            // 
            // CashierSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.cbCashierShowPass);
            this.Controls.Add(this.btnCashierSignIn);
            this.Controls.Add(this.lblCashierPassword);
            this.Controls.Add(this.lblCashierUsername);
            this.Controls.Add(this.txtCashierUsername);
            this.Controls.Add(this.lblCashierLogin);
            this.Controls.Add(this.txtCashierPassword);
            this.Controls.Add(this.panel1);
            this.Name = "CashierSignIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCashierPassword;
        private System.Windows.Forms.Label lblCashierLogin;
        private System.Windows.Forms.TextBox txtCashierUsername;
        private System.Windows.Forms.Label lblCashierUsername;
        private System.Windows.Forms.Label lblCashierPassword;
        private System.Windows.Forms.Button btnCashierSignIn;
        private System.Windows.Forms.CheckBox cbCashierShowPass;
    }
}