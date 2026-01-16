namespace CMS.Admin
{
    partial class AdminPanel
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
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.CBtn = new System.Windows.Forms.Button();
            this.WBtn = new System.Windows.Forms.Button();
            this.ChfBtn = new System.Windows.Forms.Button();
            this.bckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(388, 49);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(466, 73);
            this.lblAdminPanel.TabIndex = 3;
            this.lblAdminPanel.Text = "ADMIN PANEL";
            // 
            // CBtn
            // 
            this.CBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CBtn.Location = new System.Drawing.Point(468, 169);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(250, 50);
            this.CBtn.TabIndex = 26;
            this.CBtn.Text = "Manage Cashier";
            this.CBtn.UseVisualStyleBackColor = false;
            // 
            // WBtn
            // 
            this.WBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WBtn.ForeColor = System.Drawing.Color.Transparent;
            this.WBtn.Location = new System.Drawing.Point(468, 283);
            this.WBtn.Name = "WBtn";
            this.WBtn.Size = new System.Drawing.Size(250, 50);
            this.WBtn.TabIndex = 27;
            this.WBtn.Text = "Manage Waiter";
            this.WBtn.UseVisualStyleBackColor = false;
            // 
            // ChfBtn
            // 
            this.ChfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChfBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ChfBtn.Location = new System.Drawing.Point(468, 388);
            this.ChfBtn.Name = "ChfBtn";
            this.ChfBtn.Size = new System.Drawing.Size(250, 50);
            this.ChfBtn.TabIndex = 28;
            this.ChfBtn.Text = "Manage Chef";
            this.ChfBtn.UseVisualStyleBackColor = false;
            // 
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckBtn.ForeColor = System.Drawing.Color.Transparent;
            this.bckBtn.Location = new System.Drawing.Point(508, 497);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(150, 50);
            this.bckBtn.TabIndex = 29;
            this.bckBtn.Text = "Back";
            this.bckBtn.UseVisualStyleBackColor = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.ChfBtn);
            this.Controls.Add(this.WBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.lblAdminPanel);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button WBtn;
        private System.Windows.Forms.Button ChfBtn;
        private System.Windows.Forms.Button bckBtn;
    }
}