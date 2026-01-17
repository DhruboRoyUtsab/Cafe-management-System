namespace CMS.Chef
{
    partial class Baristasignin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baristasignin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baristasiggnin = new System.Windows.Forms.Label();
            this.btnBaristaSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 649);
            this.panel1.TabIndex = 0;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(757, 250);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(113, 19);
            this.username.TabIndex = 1;
            this.username.Text = "USERNAME :";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(759, 303);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(101, 18);
            this.password.TabIndex = 2;
            this.password.Text = "PASSWORD :";
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(876, 250);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(149, 22);
            this.usernametxtbox.TabIndex = 3;
            this.usernametxtbox.TextChanged += new System.EventHandler(this.usernametxtbox_TextChanged);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(876, 303);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(149, 22);
            this.passwordtxtbox.TabIndex = 4;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            // 
            // baristasiggnin
            // 
            this.baristasiggnin.AutoSize = true;
            this.baristasiggnin.BackColor = System.Drawing.Color.Transparent;
            this.baristasiggnin.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baristasiggnin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baristasiggnin.Location = new System.Drawing.Point(731, 84);
            this.baristasiggnin.Name = "baristasiggnin";
            this.baristasiggnin.Size = new System.Drawing.Size(325, 58);
            this.baristasiggnin.TabIndex = 6;
            this.baristasiggnin.Text = "BARISTA SIGN IN";
            this.baristasiggnin.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBaristaSignIn
            // 
            this.btnBaristaSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBaristaSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBaristaSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaristaSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaristaSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnBaristaSignIn.Location = new System.Drawing.Point(865, 423);
            this.btnBaristaSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaristaSignIn.Name = "btnBaristaSignIn";
            this.btnBaristaSignIn.Size = new System.Drawing.Size(160, 49);
            this.btnBaristaSignIn.TabIndex = 8;
            this.btnBaristaSignIn.Text = "Sign In";
            this.btnBaristaSignIn.UseVisualStyleBackColor = false;
            this.btnBaristaSignIn.Click += new System.EventHandler(this.btnBaristaSignIn_Click);
            // 
            // Baristasignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 649);
            this.Controls.Add(this.btnBaristaSignIn);
            this.Controls.Add(this.baristasiggnin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Baristasignin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChefSignin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label baristasiggnin;
        private System.Windows.Forms.Button btnBaristaSignIn;
    }
}