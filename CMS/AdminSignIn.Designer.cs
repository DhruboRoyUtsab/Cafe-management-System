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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignIn));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnSignIn);
            this.panel1.Controls.Add(this.ShowPassword);
            this.panel1.Controls.Add(this.TBPassword);
            this.panel1.Controls.Add(this.TBUserName);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblSignIn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 670);
            this.panel1.TabIndex = 0;
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
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
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
            this.lblUserName.Size = new System.Drawing.Size(105, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName:";
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 666);
            this.panel2.TabIndex = 0;
            // 
            // AdminSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "AdminSignIn";
            this.Text = "Admin Sign In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}

