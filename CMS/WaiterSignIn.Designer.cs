namespace CMS
{
    partial class WaiterSignIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.waiterlblSignIn = new System.Windows.Forms.Label();
            this.waiterUserName = new System.Windows.Forms.TextBox();
            this.waiterlbUserName = new System.Windows.Forms.Label();
            this.waiterShowPassword = new System.Windows.Forms.CheckBox();
            this.WaiterPassword = new System.Windows.Forms.TextBox();
            this.waiterlblPassword = new System.Windows.Forms.Label();
            this.waiterBtnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(590, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // waiterlblSignIn
            // 
            this.waiterlblSignIn.AutoSize = true;
            this.waiterlblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.waiterlblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterlblSignIn.ForeColor = System.Drawing.Color.White;
            this.waiterlblSignIn.Location = new System.Drawing.Point(625, 109);
            this.waiterlblSignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waiterlblSignIn.Name = "waiterlblSignIn";
            this.waiterlblSignIn.Size = new System.Drawing.Size(503, 69);
            this.waiterlblSignIn.TabIndex = 2;
            this.waiterlblSignIn.Text = "WAITER SIGN IN";
            this.waiterlblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // waiterUserName
            // 
            this.waiterUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterUserName.Location = new System.Drawing.Point(782, 282);
            this.waiterUserName.Margin = new System.Windows.Forms.Padding(4);
            this.waiterUserName.Name = "waiterUserName";
            this.waiterUserName.Size = new System.Drawing.Size(292, 37);
            this.waiterUserName.TabIndex = 6;
            // 
            // waiterlbUserName
            // 
            this.waiterlbUserName.AutoSize = true;
            this.waiterlbUserName.BackColor = System.Drawing.Color.Transparent;
            this.waiterlbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterlbUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.waiterlbUserName.Location = new System.Drawing.Point(614, 287);
            this.waiterlbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waiterlbUserName.Name = "waiterlbUserName";
            this.waiterlbUserName.Size = new System.Drawing.Size(135, 29);
            this.waiterlbUserName.TabIndex = 5;
            this.waiterlbUserName.Text = "UserName:";
            // 
            // waiterShowPassword
            // 
            this.waiterShowPassword.AutoSize = true;
            this.waiterShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.waiterShowPassword.ForeColor = System.Drawing.Color.White;
            this.waiterShowPassword.Location = new System.Drawing.Point(780, 386);
            this.waiterShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.waiterShowPassword.Name = "waiterShowPassword";
            this.waiterShowPassword.Size = new System.Drawing.Size(125, 20);
            this.waiterShowPassword.TabIndex = 9;
            this.waiterShowPassword.Text = "Show Password";
            this.waiterShowPassword.UseVisualStyleBackColor = false;
            // 
            // WaiterPassword
            // 
            this.WaiterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaiterPassword.Location = new System.Drawing.Point(780, 342);
            this.WaiterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.WaiterPassword.Name = "WaiterPassword";
            this.WaiterPassword.PasswordChar = '*';
            this.WaiterPassword.Size = new System.Drawing.Size(292, 37);
            this.WaiterPassword.TabIndex = 8;
            // 
            // waiterlblPassword
            // 
            this.waiterlblPassword.AutoSize = true;
            this.waiterlblPassword.BackColor = System.Drawing.Color.Transparent;
            this.waiterlblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterlblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.waiterlblPassword.Location = new System.Drawing.Point(623, 346);
            this.waiterlblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waiterlblPassword.Name = "waiterlblPassword";
            this.waiterlblPassword.Size = new System.Drawing.Size(126, 29);
            this.waiterlblPassword.TabIndex = 7;
            this.waiterlblPassword.Text = "Password:";
            // 
            // waiterBtnSignIn
            // 
            this.waiterBtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.waiterBtnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.waiterBtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waiterBtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterBtnSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.waiterBtnSignIn.Location = new System.Drawing.Point(761, 462);
            this.waiterBtnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.waiterBtnSignIn.Name = "waiterBtnSignIn";
            this.waiterBtnSignIn.Size = new System.Drawing.Size(160, 49);
            this.waiterBtnSignIn.TabIndex = 10;
            this.waiterBtnSignIn.Text = "Sign In";
            this.waiterBtnSignIn.UseVisualStyleBackColor = false;
            this.waiterBtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // WaiterSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.waiterBtnSignIn);
            this.Controls.Add(this.waiterShowPassword);
            this.Controls.Add(this.WaiterPassword);
            this.Controls.Add(this.waiterlblPassword);
            this.Controls.Add(this.waiterUserName);
            this.Controls.Add(this.waiterlbUserName);
            this.Controls.Add(this.waiterlblSignIn);
            this.Controls.Add(this.panel1);
            this.Name = "WaiterSignIn";
            this.Text = "waiter";
            this.Load += new System.EventHandler(this.waiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label waiterlblSignIn;
        private System.Windows.Forms.TextBox waiterUserName;
        private System.Windows.Forms.Label waiterlbUserName;
        private System.Windows.Forms.CheckBox waiterShowPassword;
        private System.Windows.Forms.TextBox WaiterPassword;
        private System.Windows.Forms.Label waiterlblPassword;
        private System.Windows.Forms.Button waiterBtnSignIn;
    }
}