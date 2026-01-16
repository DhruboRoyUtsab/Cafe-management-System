namespace CMS.Cashier
{
    partial class CardPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPay));
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.btnCardPayBack = new System.Windows.Forms.Button();
            this.tbOrderIdCard = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashierUserName = new System.Windows.Forms.Label();
            this.btnCardPayNext = new System.Windows.Forms.Button();
            this.lblCardPayment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCardPayShow = new System.Windows.Forms.Button();
            this.gvCard = new System.Windows.Forms.DataGridView();
            this.btnCardPayUpdate = new System.Windows.Forms.Button();
            this.PaymentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCard)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.btnCardPayBack);
            this.PaymentPanel.Controls.Add(this.tbOrderIdCard);
            this.PaymentPanel.Controls.Add(this.lblOrderId);
            this.PaymentPanel.Controls.Add(this.tbPin);
            this.PaymentPanel.Controls.Add(this.label3);
            this.PaymentPanel.Controls.Add(this.panel3);
            this.PaymentPanel.Controls.Add(this.tbCard);
            this.PaymentPanel.Controls.Add(this.tbPhone);
            this.PaymentPanel.Controls.Add(this.tbName);
            this.PaymentPanel.Controls.Add(this.label2);
            this.PaymentPanel.Controls.Add(this.label1);
            this.PaymentPanel.Controls.Add(this.lblCashierUserName);
            this.PaymentPanel.Controls.Add(this.btnCardPayNext);
            this.PaymentPanel.Controls.Add(this.lblCardPayment);
            this.PaymentPanel.Controls.Add(this.panel1);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 5;
            // 
            // btnCardPayBack
            // 
            this.btnCardPayBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCardPayBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCardPayBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPayBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPayBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnCardPayBack.Location = new System.Drawing.Point(978, 527);
            this.btnCardPayBack.Name = "btnCardPayBack";
            this.btnCardPayBack.Size = new System.Drawing.Size(120, 40);
            this.btnCardPayBack.TabIndex = 25;
            this.btnCardPayBack.Text = "Back";
            this.btnCardPayBack.UseVisualStyleBackColor = false;
            this.btnCardPayBack.Click += new System.EventHandler(this.btnCardPayBack_Click);
            // 
            // tbOrderIdCard
            // 
            this.tbOrderIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderIdCard.Location = new System.Drawing.Point(766, 197);
            this.tbOrderIdCard.Name = "tbOrderIdCard";
            this.tbOrderIdCard.Size = new System.Drawing.Size(220, 31);
            this.tbOrderIdCard.TabIndex = 24;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderId.Location = new System.Drawing.Point(639, 197);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(91, 24);
            this.lblOrderId.TabIndex = 23;
            this.lblOrderId.Text = "Order ID :";
            this.lblOrderId.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPin.Location = new System.Drawing.Point(766, 382);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(220, 31);
            this.tbPin.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(609, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pin Number :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(630, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 52);
            this.panel3.TabIndex = 19;
            // 
            // tbCard
            // 
            this.tbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCard.Location = new System.Drawing.Point(766, 335);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(220, 31);
            this.tbCard.TabIndex = 18;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(766, 288);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(220, 31);
            this.tbPhone.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(766, 244);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 31);
            this.tbName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(596, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Card Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(654, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone :";
            // 
            // lblCashierUserName
            // 
            this.lblCashierUserName.AutoSize = true;
            this.lblCashierUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCashierUserName.Location = new System.Drawing.Point(659, 244);
            this.lblCashierUserName.Name = "lblCashierUserName";
            this.lblCashierUserName.Size = new System.Drawing.Size(71, 24);
            this.lblCashierUserName.TabIndex = 13;
            this.lblCashierUserName.Text = "Name :";
            // 
            // btnCardPayNext
            // 
            this.btnCardPayNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCardPayNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCardPayNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPayNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPayNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnCardPayNext.Location = new System.Drawing.Point(694, 527);
            this.btnCardPayNext.Name = "btnCardPayNext";
            this.btnCardPayNext.Size = new System.Drawing.Size(120, 40);
            this.btnCardPayNext.TabIndex = 7;
            this.btnCardPayNext.Text = "Next";
            this.btnCardPayNext.UseVisualStyleBackColor = false;
            // 
            // lblCardPayment
            // 
            this.lblCardPayment.AutoSize = true;
            this.lblCardPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblCardPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardPayment.ForeColor = System.Drawing.Color.White;
            this.lblCardPayment.Location = new System.Drawing.Point(705, 86);
            this.lblCardPayment.Name = "lblCardPayment";
            this.lblCardPayment.Size = new System.Drawing.Size(406, 55);
            this.lblCardPayment.TabIndex = 1;
            this.lblCardPayment.Text = "CARD PAYMENT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Controls.Add(this.btnCardPayShow);
            this.panel1.Controls.Add(this.gvCard);
            this.panel1.Controls.Add(this.btnCardPayUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 700);
            this.panel1.TabIndex = 0;
            // 
            // btnCardPayShow
            // 
            this.btnCardPayShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCardPayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCardPayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPayShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPayShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnCardPayShow.Location = new System.Drawing.Point(44, 596);
            this.btnCardPayShow.Name = "btnCardPayShow";
            this.btnCardPayShow.Size = new System.Drawing.Size(120, 40);
            this.btnCardPayShow.TabIndex = 22;
            this.btnCardPayShow.Text = "Show";
            this.btnCardPayShow.UseVisualStyleBackColor = false;
            // 
            // gvCard
            // 
            this.gvCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCard.Location = new System.Drawing.Point(44, 127);
            this.gvCard.Name = "gvCard";
            this.gvCard.Size = new System.Drawing.Size(490, 440);
            this.gvCard.TabIndex = 0;
            this.gvCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCardPayUpdate
            // 
            this.btnCardPayUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCardPayUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCardPayUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPayUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPayUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCardPayUpdate.Location = new System.Drawing.Point(414, 596);
            this.btnCardPayUpdate.Name = "btnCardPayUpdate";
            this.btnCardPayUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnCardPayUpdate.TabIndex = 22;
            this.btnCardPayUpdate.Text = "Update";
            this.btnCardPayUpdate.UseVisualStyleBackColor = false;
            // 
            // CardPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "CardPay";
            this.Text = "CardPay";
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCashierUserName;
        private System.Windows.Forms.Button btnCardPayNext;
        private System.Windows.Forms.Label lblCardPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvCard;
        private System.Windows.Forms.Button btnCardPayUpdate;
        private System.Windows.Forms.Button btnCardPayShow;
        private System.Windows.Forms.TextBox tbOrderIdCard;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button btnCardPayBack;
    }
}