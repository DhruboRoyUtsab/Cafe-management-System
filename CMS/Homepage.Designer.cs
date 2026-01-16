namespace CMS.Assets
{
    partial class Homepage
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
            this.ChfBtn = new System.Windows.Forms.Button();
            this.WBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChfBtn
            // 
            this.ChfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChfBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ChfBtn.Location = new System.Drawing.Point(726, 466);
            this.ChfBtn.Name = "ChfBtn";
            this.ChfBtn.Size = new System.Drawing.Size(250, 50);
            this.ChfBtn.TabIndex = 33;
            this.ChfBtn.Text = "Go to Chef";
            this.ChfBtn.UseVisualStyleBackColor = false;
            this.ChfBtn.Click += new System.EventHandler(this.ChfBtn_Click);
            // 
            // WBtn
            // 
            this.WBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WBtn.ForeColor = System.Drawing.Color.Transparent;
            this.WBtn.Location = new System.Drawing.Point(726, 361);
            this.WBtn.Name = "WBtn";
            this.WBtn.Size = new System.Drawing.Size(250, 50);
            this.WBtn.TabIndex = 32;
            this.WBtn.Text = "Go to Waiter";
            this.WBtn.UseVisualStyleBackColor = false;
            this.WBtn.Click += new System.EventHandler(this.WBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CBtn.Location = new System.Drawing.Point(726, 247);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(250, 50);
            this.CBtn.TabIndex = 31;
            this.CBtn.Text = "Go to Cashier";
            this.CBtn.UseVisualStyleBackColor = false;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(726, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 35;
            this.button1.Text = "Go to Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 661);
            this.panel1.TabIndex = 36;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(679, 22);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(363, 73);
            this.lblAdminPanel.TabIndex = 31;
            this.lblAdminPanel.Text = "WELCOME";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChfBtn);
            this.Controls.Add(this.WBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChfBtn;
        private System.Windows.Forms.Button WBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminPanel;
    }
}