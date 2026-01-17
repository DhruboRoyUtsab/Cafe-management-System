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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterSignIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BckBtn = new System.Windows.Forms.Button();
            this.BtnWaiterSIgnIn = new System.Windows.Forms.Button();
            this.TBWaiterPassword = new System.Windows.Forms.TextBox();
            this.TBWaiterUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BckBtn);
            this.panel1.Controls.Add(this.BtnWaiterSIgnIn);
            this.panel1.Controls.Add(this.TBWaiterPassword);
            this.panel1.Controls.Add(this.TBWaiterUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-8, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 9;
            // 
            // BckBtn
            // 
            this.BckBtn.BackColor = System.Drawing.Color.Gray;
            this.BckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BckBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BckBtn.Location = new System.Drawing.Point(860, 468);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(100, 35);
            this.BckBtn.TabIndex = 54;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = false;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // BtnWaiterSIgnIn
            // 
            this.BtnWaiterSIgnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnWaiterSIgnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnWaiterSIgnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWaiterSIgnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWaiterSIgnIn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnWaiterSIgnIn.Location = new System.Drawing.Point(850, 357);
            this.BtnWaiterSIgnIn.Name = "BtnWaiterSIgnIn";
            this.BtnWaiterSIgnIn.Size = new System.Drawing.Size(120, 40);
            this.BtnWaiterSIgnIn.TabIndex = 7;
            this.BtnWaiterSIgnIn.Text = "Sign In";
            this.BtnWaiterSIgnIn.UseVisualStyleBackColor = false;
            this.BtnWaiterSIgnIn.Click += new System.EventHandler(this.BtnWaiterSIgnIn_Click);
            // 
            // TBWaiterPassword
            // 
            this.TBWaiterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBWaiterPassword.Location = new System.Drawing.Point(772, 238);
            this.TBWaiterPassword.Name = "TBWaiterPassword";
            this.TBWaiterPassword.PasswordChar = '*';
            this.TBWaiterPassword.Size = new System.Drawing.Size(220, 31);
            this.TBWaiterPassword.TabIndex = 5;
            // 
            // TBWaiterUsername
            // 
            this.TBWaiterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBWaiterUsername.Location = new System.Drawing.Point(772, 170);
            this.TBWaiterUsername.Name = "TBWaiterUsername";
            this.TBWaiterUsername.Size = new System.Drawing.Size(220, 31);
            this.TBWaiterUsername.TabIndex = 4;
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
            this.label3.Size = new System.Drawing.Size(401, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "WAITER SIGN IN";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 700);
            this.panel2.TabIndex = 0;
            // 
            // WaiterSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Name = "WaiterSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaiterSignIn";
            this.Load += new System.EventHandler(this.WaiterSignIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button BtnWaiterSIgnIn;
        private System.Windows.Forms.TextBox TBWaiterPassword;
        private System.Windows.Forms.TextBox TBWaiterUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}