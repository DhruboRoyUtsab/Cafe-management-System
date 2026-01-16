namespace CMS.Cashier
{
    partial class CurrentOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentOrder));
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.btnPaymentHistoryBack = new System.Windows.Forms.Button();
            this.btnTakePayment = new System.Windows.Forms.Button();
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
            this.PaymentPanel.Controls.Add(this.btnPaymentHistoryBack);
            this.PaymentPanel.Controls.Add(this.btnTakePayment);
            this.PaymentPanel.Controls.Add(this.gvAllPay);
            this.PaymentPanel.Controls.Add(this.btnPaymentHistoryShow);
            this.PaymentPanel.Controls.Add(this.btnPayDelete);
            this.PaymentPanel.Controls.Add(this.lblPaymentHistory);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 6;
            this.PaymentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaymentPanel_Paint);
            // 
            // btnPaymentHistoryBack
            // 
            this.btnPaymentHistoryBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentHistoryBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentHistoryBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentHistoryBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoryBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentHistoryBack.Location = new System.Drawing.Point(770, 597);
            this.btnPaymentHistoryBack.Name = "btnPaymentHistoryBack";
            this.btnPaymentHistoryBack.Size = new System.Drawing.Size(120, 40);
            this.btnPaymentHistoryBack.TabIndex = 15;
            this.btnPaymentHistoryBack.Text = "Back";
            this.btnPaymentHistoryBack.UseVisualStyleBackColor = false;
            this.btnPaymentHistoryBack.Click += new System.EventHandler(this.btnPaymentHistoryBack_Click);
            // 
            // btnTakePayment
            // 
            this.btnTakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTakePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnTakePayment.Location = new System.Drawing.Point(931, 597);
            this.btnTakePayment.Name = "btnTakePayment";
            this.btnTakePayment.Size = new System.Drawing.Size(203, 40);
            this.btnTakePayment.TabIndex = 23;
            this.btnTakePayment.Text = "Take Payment";
            this.btnTakePayment.UseVisualStyleBackColor = false;
            this.btnTakePayment.Click += new System.EventHandler(this.btnTakePayment_Click);
            // 
            // gvAllPay
            // 
            this.gvAllPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllPay.Location = new System.Drawing.Point(142, 127);
            this.gvAllPay.Name = "gvAllPay";
            this.gvAllPay.Size = new System.Drawing.Size(911, 440);
            this.gvAllPay.TabIndex = 0;
            this.gvAllPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAllPay_CellContentClick);
            // 
            // btnPaymentHistoryShow
            // 
            this.btnPaymentHistoryShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaymentHistoryShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentHistoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentHistoryShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoryShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentHistoryShow.Location = new System.Drawing.Point(76, 597);
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
            this.btnPayDelete.Location = new System.Drawing.Point(241, 597);
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
            this.lblPaymentHistory.Location = new System.Drawing.Point(424, 56);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(345, 55);
            this.lblPaymentHistory.TabIndex = 1;
            this.lblPaymentHistory.Text = "Current Orders";
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "PaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentHistory";
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Button btnPayDelete;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.DataGridView gvAllPay;
        private System.Windows.Forms.Button btnPaymentHistoryShow;
        private System.Windows.Forms.Button btnTakePayment;
        private System.Windows.Forms.Button btnPaymentHistoryBack;
    }
}