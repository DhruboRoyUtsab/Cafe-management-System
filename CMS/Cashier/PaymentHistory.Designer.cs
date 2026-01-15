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
            this.gvAllPay = new System.Windows.Forms.DataGridView();
            this.btnPaymentHistoryShow = new System.Windows.Forms.Button();
            this.btnPayDelete = new System.Windows.Forms.Button();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.btnTakePayment = new System.Windows.Forms.Button();
            this.PaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllPay)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.btnTakePayment);
            this.PaymentPanel.Controls.Add(this.gvAllPay);
            this.PaymentPanel.Controls.Add(this.btnPaymentHistoryShow);
            this.PaymentPanel.Controls.Add(this.btnPayDelete);
            this.PaymentPanel.Controls.Add(this.lblPaymentHistory);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 6;
            // 
            // gvAllPay
            // 
            this.gvAllPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllPay.Location = new System.Drawing.Point(142, 127);
            this.gvAllPay.Name = "gvAllPay";
            this.gvAllPay.Size = new System.Drawing.Size(911, 440);
            this.gvAllPay.TabIndex = 0;
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
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.lblPaymentHistory.Location = new System.Drawing.Point(369, 52);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(482, 55);
            this.lblPaymentHistory.TabIndex = 1;
            this.lblPaymentHistory.Text = "PAYMENT HISTORY";
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
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "PaymentHistory";
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
    }
}