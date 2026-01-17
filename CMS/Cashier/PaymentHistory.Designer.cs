namespace CMS.Cashier
{
    partial class PaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistory));
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.CurrentOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashierUserName = new System.Windows.Forms.Label();
            this.btnPaymentHistoryBack = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.gvAllPay = new System.Windows.Forms.DataGridView();
            this.btnPaymentHistoryShow = new System.Windows.Forms.Button();
            this.btnPayDelete = new System.Windows.Forms.Button();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.PaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllPay)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.CurrentOrder);
            this.PaymentPanel.Controls.Add(this.btnClear);
            this.PaymentPanel.Controls.Add(this.tbPhone);
            this.PaymentPanel.Controls.Add(this.tbName);
            this.PaymentPanel.Controls.Add(this.label1);
            this.PaymentPanel.Controls.Add(this.lblCashierUserName);
            this.PaymentPanel.Controls.Add(this.btnPaymentHistoryBack);
            this.PaymentPanel.Controls.Add(this.btnUpdatePayment);
            this.PaymentPanel.Controls.Add(this.gvAllPay);
            this.PaymentPanel.Controls.Add(this.btnPaymentHistoryShow);
            this.PaymentPanel.Controls.Add(this.btnPayDelete);
            this.PaymentPanel.Controls.Add(this.lblPaymentHistory);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 7;
            this.PaymentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaymentPanel_Paint);
            // 
            // CurrentOrder
            // 
            this.CurrentOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrentOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentOrder.ForeColor = System.Drawing.Color.Transparent;
            this.CurrentOrder.Location = new System.Drawing.Point(815, 597);
            this.CurrentOrder.Name = "CurrentOrder";
            this.CurrentOrder.Size = new System.Drawing.Size(200, 40);
            this.CurrentOrder.TabIndex = 35;
            this.CurrentOrder.Text = "Current Order";
            this.CurrentOrder.UseVisualStyleBackColor = false;
            this.CurrentOrder.Click += new System.EventHandler(this.CurrentOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(482, 597);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 40);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(923, 230);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(220, 31);
            this.tbPhone.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(923, 186);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 31);
            this.tbName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(811, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone :";
            // 
            // lblCashierUserName
            // 
            this.lblCashierUserName.AutoSize = true;
            this.lblCashierUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCashierUserName.Location = new System.Drawing.Point(816, 190);
            this.lblCashierUserName.Name = "lblCashierUserName";
            this.lblCashierUserName.Size = new System.Drawing.Size(71, 24);
            this.lblCashierUserName.TabIndex = 30;
            this.lblCashierUserName.Text = "Name :";
            // 
            // btnPaymentHistoryBack
            // 
            this.btnPaymentHistoryBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentHistoryBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentHistoryBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentHistoryBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoryBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentHistoryBack.Location = new System.Drawing.Point(1043, 597);
            this.btnPaymentHistoryBack.Name = "btnPaymentHistoryBack";
            this.btnPaymentHistoryBack.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentHistoryBack.TabIndex = 15;
            this.btnPaymentHistoryBack.Text = "Back";
            this.btnPaymentHistoryBack.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdatePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdatePayment.Location = new System.Drawing.Point(637, 597);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(137, 40);
            this.btnUpdatePayment.TabIndex = 23;
            this.btnUpdatePayment.Text = "Update";
            this.btnUpdatePayment.UseVisualStyleBackColor = false;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // gvAllPay
            // 
            this.gvAllPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllPay.Location = new System.Drawing.Point(20, 117);
            this.gvAllPay.Name = "gvAllPay";
            this.gvAllPay.Size = new System.Drawing.Size(754, 446);
            this.gvAllPay.TabIndex = 0;
            this.gvAllPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAllPay_CellClick);
            // 
            // btnPaymentHistoryShow
            // 
            this.btnPaymentHistoryShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentHistoryShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentHistoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentHistoryShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoryShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentHistoryShow.Location = new System.Drawing.Point(30, 597);
            this.btnPaymentHistoryShow.Name = "btnPaymentHistoryShow";
            this.btnPaymentHistoryShow.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentHistoryShow.TabIndex = 22;
            this.btnPaymentHistoryShow.Text = "Show";
            this.btnPaymentHistoryShow.UseVisualStyleBackColor = false;
            this.btnPaymentHistoryShow.Click += new System.EventHandler(this.btnPaymentHistoryShow_Click);
            // 
            // btnPayDelete
            // 
            this.btnPayDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPayDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPayDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnPayDelete.Location = new System.Drawing.Point(172, 597);
            this.btnPayDelete.Name = "btnPayDelete";
            this.btnPayDelete.Size = new System.Drawing.Size(120, 40);
            this.btnPayDelete.TabIndex = 22;
            this.btnPayDelete.Text = "Delete";
            this.btnPayDelete.UseVisualStyleBackColor = false;
            this.btnPayDelete.Click += new System.EventHandler(this.btnPayDelete_Click);
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.lblPaymentHistory.Location = new System.Drawing.Point(348, 47);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(482, 55);
            this.lblPaymentHistory.TabIndex = 1;
            this.lblPaymentHistory.Text = "PAYMENT HISTORY";
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "PaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.PaymentHistory_Load);
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Button btnPaymentHistoryBack;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.DataGridView gvAllPay;
        private System.Windows.Forms.Button btnPaymentHistoryShow;
        private System.Windows.Forms.Button btnPayDelete;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCashierUserName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button CurrentOrder;
    }
}