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
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnCardPay = new System.Windows.Forms.RadioButton();
            this.rbtnCashPay = new System.Windows.Forms.RadioButton();
            this.btnPaymentNext = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPaymentBack = new System.Windows.Forms.Button();
            this.PaymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.btnPaymentBack);
            this.PaymentPanel.Controls.Add(this.panel3);
            this.PaymentPanel.Controls.Add(this.panel2);
            this.PaymentPanel.Controls.Add(this.rbtnCardPay);
            this.PaymentPanel.Controls.Add(this.rbtnCashPay);
            this.PaymentPanel.Controls.Add(this.btnPaymentNext);
            this.PaymentPanel.Controls.Add(this.lblPayment);
            this.PaymentPanel.Controls.Add(this.panel1);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(734, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 52);
            this.panel3.TabIndex = 13;
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
            // rbtnCardPay
            // 
            this.rbtnCardPay.AutoSize = true;
            this.rbtnCardPay.Location = new System.Drawing.Point(686, 369);
            this.rbtnCardPay.Name = "rbtnCardPay";
            this.rbtnCardPay.Size = new System.Drawing.Size(14, 13);
            this.rbtnCardPay.TabIndex = 9;
            this.rbtnCardPay.TabStop = true;
            this.rbtnCardPay.UseVisualStyleBackColor = true;
            // 
            // rbtnCashPay
            // 
            this.rbtnCashPay.AutoSize = true;
            this.rbtnCashPay.Location = new System.Drawing.Point(686, 261);
            this.rbtnCashPay.Name = "rbtnCashPay";
            this.rbtnCashPay.Size = new System.Drawing.Size(14, 13);
            this.rbtnCashPay.TabIndex = 8;
            this.rbtnCashPay.TabStop = true;
            this.rbtnCashPay.UseVisualStyleBackColor = true;
            // 
            // btnPaymentNext
            // 
            this.btnPaymentNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentNext.Location = new System.Drawing.Point(683, 547);
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
            // btnPaymentBack
            // 
            this.btnPaymentBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentBack.Location = new System.Drawing.Point(984, 547);
            this.btnPaymentBack.Name = "btnPaymentBack";
            this.btnPaymentBack.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentBack.TabIndex = 14;
            this.btnPaymentBack.Text = "Back";
            this.btnPaymentBack.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "Payment";
            this.Text = "Payment";
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Button btnPaymentNext;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCardPay;
        private System.Windows.Forms.RadioButton rbtnCashPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPaymentBack;
    }
}