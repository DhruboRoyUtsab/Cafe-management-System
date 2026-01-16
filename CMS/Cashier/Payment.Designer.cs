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
            this.btnPaymentBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnCardPay = new System.Windows.Forms.RadioButton();
            this.rbtnCashPay = new System.Windows.Forms.RadioButton();
            this.btnPaymentNext = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashierUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCardPayShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.label5);
            this.PaymentPanel.Controls.Add(this.tbOrderId);
            this.PaymentPanel.Controls.Add(this.button1);
            this.PaymentPanel.Controls.Add(this.btnClear);
            this.PaymentPanel.Controls.Add(this.btnCardPayShow);
            this.PaymentPanel.Controls.Add(this.dataGridView1);
            this.PaymentPanel.Controls.Add(this.tbAmount);
            this.PaymentPanel.Controls.Add(this.label4);
            this.PaymentPanel.Controls.Add(this.tbPin);
            this.PaymentPanel.Controls.Add(this.label3);
            this.PaymentPanel.Controls.Add(this.tbCard);
            this.PaymentPanel.Controls.Add(this.tbPhone);
            this.PaymentPanel.Controls.Add(this.tbName);
            this.PaymentPanel.Controls.Add(this.label2);
            this.PaymentPanel.Controls.Add(this.label1);
            this.PaymentPanel.Controls.Add(this.lblCashierUserName);
            this.PaymentPanel.Controls.Add(this.btnPaymentBack);
            this.PaymentPanel.Controls.Add(this.panel3);
            this.PaymentPanel.Controls.Add(this.panel2);
            this.PaymentPanel.Controls.Add(this.rbtnCardPay);
            this.PaymentPanel.Controls.Add(this.rbtnCashPay);
            this.PaymentPanel.Controls.Add(this.btnPaymentNext);
            this.PaymentPanel.Controls.Add(this.lblPayment);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 3;
            // 
            // btnPaymentBack
            // 
            this.btnPaymentBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentBack.Location = new System.Drawing.Point(221, 586);
            this.btnPaymentBack.Name = "btnPaymentBack";
            this.btnPaymentBack.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentBack.TabIndex = 14;
            this.btnPaymentBack.Text = "Back";
            this.btnPaymentBack.UseVisualStyleBackColor = false;
            this.btnPaymentBack.Click += new System.EventHandler(this.btnPaymentBack_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(556, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 52);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(417, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 52);
            this.panel2.TabIndex = 12;
            // 
            // rbtnCardPay
            // 
            this.rbtnCardPay.AutoSize = true;
            this.rbtnCardPay.Location = new System.Drawing.Point(536, 319);
            this.rbtnCardPay.Name = "rbtnCardPay";
            this.rbtnCardPay.Size = new System.Drawing.Size(14, 13);
            this.rbtnCardPay.TabIndex = 9;
            this.rbtnCardPay.TabStop = true;
            this.rbtnCardPay.UseVisualStyleBackColor = true;
            // 
            // rbtnCashPay
            // 
            this.rbtnCashPay.AutoSize = true;
            this.rbtnCashPay.Location = new System.Drawing.Point(397, 319);
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
            this.btnPaymentNext.Location = new System.Drawing.Point(59, 586);
            this.btnPaymentNext.Name = "btnPaymentNext";
            this.btnPaymentNext.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentNext.TabIndex = 7;
            this.btnPaymentNext.Text = "Next";
            this.btnPaymentNext.UseVisualStyleBackColor = false;
            this.btnPaymentNext.Click += new System.EventHandler(this.btnPaymentNext_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(475, 52);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(256, 55);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "PAYMENT";
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPin.Location = new System.Drawing.Point(397, 476);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(220, 31);
            this.tbPin.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(240, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Pin Number :";
            // 
            // tbCard
            // 
            this.tbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCard.Location = new System.Drawing.Point(397, 427);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(220, 31);
            this.tbCard.TabIndex = 30;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(397, 236);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(220, 31);
            this.tbPhone.TabIndex = 29;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(397, 192);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 31);
            this.tbName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(227, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Card Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(285, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phone :";
            // 
            // lblCashierUserName
            // 
            this.lblCashierUserName.AutoSize = true;
            this.lblCashierUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCashierUserName.Location = new System.Drawing.Point(290, 192);
            this.lblCashierUserName.Name = "lblCashierUserName";
            this.lblCashierUserName.Size = new System.Drawing.Size(71, 24);
            this.lblCashierUserName.TabIndex = 25;
            this.lblCashierUserName.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(275, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Amount :";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(397, 377);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(220, 31);
            this.tbAmount.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(665, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 368);
            this.dataGridView1.TabIndex = 35;
            // 
            // btnCardPayShow
            // 
            this.btnCardPayShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCardPayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCardPayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPayShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPayShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnCardPayShow.Location = new System.Drawing.Point(1043, 586);
            this.btnCardPayShow.Name = "btnCardPayShow";
            this.btnCardPayShow.Size = new System.Drawing.Size(120, 40);
            this.btnCardPayShow.TabIndex = 36;
            this.btnCardPayShow.Text = "Show";
            this.btnCardPayShow.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(802, 586);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(665, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 38;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbOrderId
            // 
            this.tbOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderId.Location = new System.Drawing.Point(397, 146);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(220, 31);
            this.tbOrderId.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(275, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "OrderID :";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Button btnPaymentNext;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.RadioButton rbtnCardPay;
        private System.Windows.Forms.RadioButton rbtnCashPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPaymentBack;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCashierUserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCardPayShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrderId;
    }
}