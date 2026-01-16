namespace CMS.Cashier
{
    partial class CashPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashPay));
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.btnCashPayBack = new System.Windows.Forms.Button();
            this.tbOrderIdCash = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCashierUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashierUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCashPayNext = new System.Windows.Forms.Button();
            this.lblCashPayment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCashPayShow = new System.Windows.Forms.Button();
            this.gvCash = new System.Windows.Forms.DataGridView();
            this.btnCashPayUpdate = new System.Windows.Forms.Button();
            this.PaymentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCash)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.btnCashPayBack);
            this.PaymentPanel.Controls.Add(this.tbOrderIdCash);
            this.PaymentPanel.Controls.Add(this.lblOrderId);
            this.PaymentPanel.Controls.Add(this.textBox2);
            this.PaymentPanel.Controls.Add(this.textBox1);
            this.PaymentPanel.Controls.Add(this.tbCashierUserName);
            this.PaymentPanel.Controls.Add(this.label2);
            this.PaymentPanel.Controls.Add(this.label1);
            this.PaymentPanel.Controls.Add(this.lblCashierUserName);
            this.PaymentPanel.Controls.Add(this.panel2);
            this.PaymentPanel.Controls.Add(this.btnCashPayNext);
            this.PaymentPanel.Controls.Add(this.lblCashPayment);
            this.PaymentPanel.Controls.Add(this.panel1);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 4;
            // 
            // btnCashPayBack
            // 
            this.btnCashPayBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashPayBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashPayBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashPayBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashPayBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnCashPayBack.Location = new System.Drawing.Point(977, 537);
            this.btnCashPayBack.Name = "btnCashPayBack";
            this.btnCashPayBack.Size = new System.Drawing.Size(120, 40);
            this.btnCashPayBack.TabIndex = 24;
            this.btnCashPayBack.Text = "Back";
            this.btnCashPayBack.UseVisualStyleBackColor = false;
            this.btnCashPayBack.Click += new System.EventHandler(this.btnCashPayBack_Click);
            // 
            // tbOrderIdCash
            // 
            this.tbOrderIdCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderIdCash.Location = new System.Drawing.Point(766, 202);
            this.tbOrderIdCash.Name = "tbOrderIdCash";
            this.tbOrderIdCash.Size = new System.Drawing.Size(220, 31);
            this.tbOrderIdCash.TabIndex = 25;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderId.Location = new System.Drawing.Point(639, 202);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(91, 24);
            this.lblOrderId.TabIndex = 24;
            this.lblOrderId.Text = "Order ID :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(766, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 31);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(766, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 31);
            this.textBox1.TabIndex = 17;
            // 
            // tbCashierUserName
            // 
            this.tbCashierUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashierUserName.Location = new System.Drawing.Point(766, 244);
            this.tbCashierUserName.Name = "tbCashierUserName";
            this.tbCashierUserName.Size = new System.Drawing.Size(220, 31);
            this.tbCashierUserName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(644, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount :";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(631, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 52);
            this.panel2.TabIndex = 12;
            // 
            // btnCashPayNext
            // 
            this.btnCashPayNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashPayNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashPayNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashPayNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashPayNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnCashPayNext.Location = new System.Drawing.Point(705, 537);
            this.btnCashPayNext.Name = "btnCashPayNext";
            this.btnCashPayNext.Size = new System.Drawing.Size(120, 40);
            this.btnCashPayNext.TabIndex = 7;
            this.btnCashPayNext.Text = "Next";
            this.btnCashPayNext.UseVisualStyleBackColor = false;
            this.btnCashPayNext.Click += new System.EventHandler(this.btnCashPayNext_Click);
            // 
            // lblCashPayment
            // 
            this.lblCashPayment.AutoSize = true;
            this.lblCashPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblCashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashPayment.ForeColor = System.Drawing.Color.White;
            this.lblCashPayment.Location = new System.Drawing.Point(705, 86);
            this.lblCashPayment.Name = "lblCashPayment";
            this.lblCashPayment.Size = new System.Drawing.Size(403, 55);
            this.lblCashPayment.TabIndex = 1;
            this.lblCashPayment.Text = "CASH PAYMENT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Controls.Add(this.btnCashPayShow);
            this.panel1.Controls.Add(this.gvCash);
            this.panel1.Controls.Add(this.btnCashPayUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 700);
            this.panel1.TabIndex = 0;
            // 
            // btnCashPayShow
            // 
            this.btnCashPayShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashPayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashPayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashPayShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashPayShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnCashPayShow.Location = new System.Drawing.Point(50, 609);
            this.btnCashPayShow.Name = "btnCashPayShow";
            this.btnCashPayShow.Size = new System.Drawing.Size(120, 40);
            this.btnCashPayShow.TabIndex = 23;
            this.btnCashPayShow.Text = "Show";
            this.btnCashPayShow.UseVisualStyleBackColor = false;
            // 
            // gvCash
            // 
            this.gvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCash.Location = new System.Drawing.Point(50, 130);
            this.gvCash.Name = "gvCash";
            this.gvCash.Size = new System.Drawing.Size(490, 440);
            this.gvCash.TabIndex = 1;
            // 
            // btnCashPayUpdate
            // 
            this.btnCashPayUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashPayUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashPayUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashPayUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashPayUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCashPayUpdate.Location = new System.Drawing.Point(420, 609);
            this.btnCashPayUpdate.Name = "btnCashPayUpdate";
            this.btnCashPayUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnCashPayUpdate.TabIndex = 23;
            this.btnCashPayUpdate.Text = "Update";
            this.btnCashPayUpdate.UseVisualStyleBackColor = false;
            // 
            // CashPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "CashPay";
            this.Text = "CashPay";
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCashPayNext;
        private System.Windows.Forms.Label lblCashPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCashierUserName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCashierUserName;
        private System.Windows.Forms.DataGridView gvCash;
        private System.Windows.Forms.Button btnCashPayShow;
        private System.Windows.Forms.Button btnCashPayUpdate;
        private System.Windows.Forms.Button btnCashPayBack;
        private System.Windows.Forms.TextBox tbOrderIdCash;
        private System.Windows.Forms.Label lblOrderId;
    }
}