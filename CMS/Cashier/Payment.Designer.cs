namespace CMS.Cashier
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.AdminSignInPanel = new System.Windows.Forms.Panel();
            this.btnPaymentNext = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AdminSignInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminSignInPanel
            // 
            this.AdminSignInPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminSignInPanel.BackgroundImage")));
            this.AdminSignInPanel.Controls.Add(this.panel4);
            this.AdminSignInPanel.Controls.Add(this.panel3);
            this.AdminSignInPanel.Controls.Add(this.panel2);
            this.AdminSignInPanel.Controls.Add(this.radioButton4);
            this.AdminSignInPanel.Controls.Add(this.radioButton2);
            this.AdminSignInPanel.Controls.Add(this.radioButton1);
            this.AdminSignInPanel.Controls.Add(this.btnPaymentNext);
            this.AdminSignInPanel.Controls.Add(this.lblPayment);
            this.AdminSignInPanel.Controls.Add(this.panel1);
            this.AdminSignInPanel.Location = new System.Drawing.Point(-8, -20);
            this.AdminSignInPanel.Name = "AdminSignInPanel";
            this.AdminSignInPanel.Size = new System.Drawing.Size(1200, 700);
            this.AdminSignInPanel.TabIndex = 3;
            // 
            // btnPaymentNext
            // 
            this.btnPaymentNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentNext.Location = new System.Drawing.Point(837, 537);
            this.btnPaymentNext.Name = "btnPaymentNext";
            this.btnPaymentNext.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentNext.TabIndex = 7;
            this.btnPaymentNext.Text = "Next";
            this.btnPaymentNext.UseVisualStyleBackColor = false;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(774, 90);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(256, 55);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "PAYMENT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(686, 261);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(686, 332);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(686, 400);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(734, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 52);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(734, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 52);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(734, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(69, 52);
            this.panel4.TabIndex = 13;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.AdminSignInPanel);
            this.Name = "Payment";
            this.Text = "Payment";
            this.AdminSignInPanel.ResumeLayout(false);
            this.AdminSignInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminSignInPanel;
        private System.Windows.Forms.Button btnPaymentNext;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}