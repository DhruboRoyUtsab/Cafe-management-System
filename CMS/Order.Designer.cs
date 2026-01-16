namespace CMS.Waiter
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.clrBtn = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.btnOrderShow = new System.Windows.Forms.Button();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.cbLatte = new System.Windows.Forms.CheckBox();
            this.cbAmericano = new System.Windows.Forms.CheckBox();
            this.CBMocca = new System.Windows.Forms.CheckBox();
            this.cbCappuccino = new System.Windows.Forms.CheckBox();
            this.cbBlueMountain = new System.Windows.Forms.CheckBox();
            this.cbCaramel = new System.Windows.Forms.CheckBox();
            this.cbBlackCoffee = new System.Windows.Forms.CheckBox();
            this.cbInstantCoffee = new System.Windows.Forms.CheckBox();
            this.btnOrderBack = new System.Windows.Forms.Button();
            this.btnOrderNext = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.PaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentPanel.BackgroundImage")));
            this.PaymentPanel.Controls.Add(this.clrBtn);
            this.PaymentPanel.Controls.Add(this.btnOrderDelete);
            this.PaymentPanel.Controls.Add(this.btnOrderUpdate);
            this.PaymentPanel.Controls.Add(this.btnOrderShow);
            this.PaymentPanel.Controls.Add(this.dataGridOrders);
            this.PaymentPanel.Controls.Add(this.cbLatte);
            this.PaymentPanel.Controls.Add(this.cbAmericano);
            this.PaymentPanel.Controls.Add(this.CBMocca);
            this.PaymentPanel.Controls.Add(this.cbCappuccino);
            this.PaymentPanel.Controls.Add(this.cbBlueMountain);
            this.PaymentPanel.Controls.Add(this.cbCaramel);
            this.PaymentPanel.Controls.Add(this.cbBlackCoffee);
            this.PaymentPanel.Controls.Add(this.cbInstantCoffee);
            this.PaymentPanel.Controls.Add(this.btnOrderBack);
            this.PaymentPanel.Controls.Add(this.btnOrderNext);
            this.PaymentPanel.Controls.Add(this.lblPayment);
            this.PaymentPanel.Location = new System.Drawing.Point(-8, -20);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(1200, 700);
            this.PaymentPanel.TabIndex = 4;
            this.PaymentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaymentPanel_Paint);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.Color.Transparent;
            this.clrBtn.Location = new System.Drawing.Point(874, 608);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(120, 40);
            this.clrBtn.TabIndex = 27;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrderDelete.Location = new System.Drawing.Point(720, 608);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(120, 40);
            this.btnOrderDelete.TabIndex = 26;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = false;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrderUpdate.Location = new System.Drawing.Point(578, 608);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnOrderUpdate.TabIndex = 25;
            this.btnOrderUpdate.Text = "Update";
            this.btnOrderUpdate.UseVisualStyleBackColor = false;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // btnOrderShow
            // 
            this.btnOrderShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrderShow.Location = new System.Drawing.Point(1045, 608);
            this.btnOrderShow.Name = "btnOrderShow";
            this.btnOrderShow.Size = new System.Drawing.Size(120, 40);
            this.btnOrderShow.TabIndex = 24;
            this.btnOrderShow.Text = "Show";
            this.btnOrderShow.UseVisualStyleBackColor = false;
            this.btnOrderShow.Click += new System.EventHandler(this.btnOrderShow_Click);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(578, 156);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(587, 418);
            this.dataGridOrders.TabIndex = 23;
            this.dataGridOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbLatte
            // 
            this.cbLatte.AutoSize = true;
            this.cbLatte.BackColor = System.Drawing.Color.Transparent;
            this.cbLatte.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLatte.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbLatte.Location = new System.Drawing.Point(245, 228);
            this.cbLatte.Name = "cbLatte";
            this.cbLatte.Size = new System.Drawing.Size(165, 29);
            this.cbLatte.TabIndex = 22;
            this.cbLatte.Text = "LATTE     $6";
            this.cbLatte.UseVisualStyleBackColor = false;
            this.cbLatte.CheckedChanged += new System.EventHandler(this.cbLatte_CheckedChanged);
            // 
            // cbAmericano
            // 
            this.cbAmericano.AutoSize = true;
            this.cbAmericano.BackColor = System.Drawing.Color.Transparent;
            this.cbAmericano.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmericano.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbAmericano.Location = new System.Drawing.Point(245, 263);
            this.cbAmericano.Name = "cbAmericano";
            this.cbAmericano.Size = new System.Drawing.Size(238, 29);
            this.cbAmericano.TabIndex = 21;
            this.cbAmericano.Text = "AMERICANO     $9";
            this.cbAmericano.UseVisualStyleBackColor = false;
            this.cbAmericano.CheckedChanged += new System.EventHandler(this.cbAmericano_CheckedChanged);
            // 
            // CBMocca
            // 
            this.CBMocca.AutoSize = true;
            this.CBMocca.BackColor = System.Drawing.Color.Transparent;
            this.CBMocca.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMocca.ForeColor = System.Drawing.Color.RosyBrown;
            this.CBMocca.Location = new System.Drawing.Point(245, 298);
            this.CBMocca.Name = "CBMocca";
            this.CBMocca.Size = new System.Drawing.Size(182, 29);
            this.CBMocca.TabIndex = 20;
            this.CBMocca.Text = "MOCCA     $6";
            this.CBMocca.UseVisualStyleBackColor = false;
            this.CBMocca.CheckedChanged += new System.EventHandler(this.CBMocca_CheckedChanged);
            // 
            // cbCappuccino
            // 
            this.cbCappuccino.AutoSize = true;
            this.cbCappuccino.BackColor = System.Drawing.Color.Transparent;
            this.cbCappuccino.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCappuccino.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbCappuccino.Location = new System.Drawing.Point(245, 333);
            this.cbCappuccino.Name = "cbCappuccino";
            this.cbCappuccino.Size = new System.Drawing.Size(246, 29);
            this.cbCappuccino.TabIndex = 19;
            this.cbCappuccino.Text = "CAPPUCCINO     $7";
            this.cbCappuccino.UseVisualStyleBackColor = false;
            // 
            // cbBlueMountain
            // 
            this.cbBlueMountain.AutoSize = true;
            this.cbBlueMountain.BackColor = System.Drawing.Color.Transparent;
            this.cbBlueMountain.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlueMountain.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbBlueMountain.Location = new System.Drawing.Point(245, 368);
            this.cbBlueMountain.Name = "cbBlueMountain";
            this.cbBlueMountain.Size = new System.Drawing.Size(294, 29);
            this.cbBlueMountain.TabIndex = 18;
            this.cbBlueMountain.Text = "BLUE MOUNTAIN     $4";
            this.cbBlueMountain.UseVisualStyleBackColor = false;
            this.cbBlueMountain.CheckedChanged += new System.EventHandler(this.cbBlueMountain_CheckedChanged);
            // 
            // cbCaramel
            // 
            this.cbCaramel.AutoSize = true;
            this.cbCaramel.BackColor = System.Drawing.Color.Transparent;
            this.cbCaramel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaramel.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbCaramel.Location = new System.Drawing.Point(245, 403);
            this.cbCaramel.Name = "cbCaramel";
            this.cbCaramel.Size = new System.Drawing.Size(205, 29);
            this.cbCaramel.TabIndex = 17;
            this.cbCaramel.Text = "CARAMEL     $7";
            this.cbCaramel.UseVisualStyleBackColor = false;
            this.cbCaramel.CheckedChanged += new System.EventHandler(this.cbCaramel_CheckedChanged);
            // 
            // cbBlackCoffee
            // 
            this.cbBlackCoffee.AutoSize = true;
            this.cbBlackCoffee.BackColor = System.Drawing.Color.Transparent;
            this.cbBlackCoffee.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlackCoffee.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbBlackCoffee.Location = new System.Drawing.Point(245, 438);
            this.cbBlackCoffee.Name = "cbBlackCoffee";
            this.cbBlackCoffee.Size = new System.Drawing.Size(258, 29);
            this.cbBlackCoffee.TabIndex = 16;
            this.cbBlackCoffee.Text = "BLACK COFFEE     5$";
            this.cbBlackCoffee.UseVisualStyleBackColor = false;
            this.cbBlackCoffee.CheckedChanged += new System.EventHandler(this.cbBlackCoffee_CheckedChanged);
            // 
            // cbInstantCoffee
            // 
            this.cbInstantCoffee.AutoSize = true;
            this.cbInstantCoffee.BackColor = System.Drawing.Color.Transparent;
            this.cbInstantCoffee.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstantCoffee.ForeColor = System.Drawing.Color.RosyBrown;
            this.cbInstantCoffee.Location = new System.Drawing.Point(245, 193);
            this.cbInstantCoffee.Name = "cbInstantCoffee";
            this.cbInstantCoffee.Size = new System.Drawing.Size(287, 29);
            this.cbInstantCoffee.TabIndex = 15;
            this.cbInstantCoffee.Text = "INSTANT COFFEE     $8";
            this.cbInstantCoffee.UseVisualStyleBackColor = false;
            this.cbInstantCoffee.CheckedChanged += new System.EventHandler(this.cbInstantCoffee_CheckedChanged);
            // 
            // btnOrderBack
            // 
            this.btnOrderBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrderBack.Location = new System.Drawing.Point(44, 608);
            this.btnOrderBack.Name = "btnOrderBack";
            this.btnOrderBack.Size = new System.Drawing.Size(120, 40);
            this.btnOrderBack.TabIndex = 14;
            this.btnOrderBack.Text = "Back";
            this.btnOrderBack.UseVisualStyleBackColor = false;
            this.btnOrderBack.Click += new System.EventHandler(this.btnOrderBack_Click);
            // 
            // btnOrderNext
            // 
            this.btnOrderNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrderNext.Location = new System.Drawing.Point(199, 608);
            this.btnOrderNext.Name = "btnOrderNext";
            this.btnOrderNext.Size = new System.Drawing.Size(120, 40);
            this.btnOrderNext.TabIndex = 7;
            this.btnOrderNext.Text = "Next";
            this.btnOrderNext.UseVisualStyleBackColor = false;
            this.btnOrderNext.Click += new System.EventHandler(this.btnOrderNext_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(498, 78);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(230, 55);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "ORDERS";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PaymentPanel);
            this.Name = "Order";
            this.Text = "Order";
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Button btnOrderBack;
        private System.Windows.Forms.Button btnOrderNext;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.CheckBox cbInstantCoffee;
        private System.Windows.Forms.CheckBox cbLatte;
        private System.Windows.Forms.CheckBox cbAmericano;
        private System.Windows.Forms.CheckBox CBMocca;
        private System.Windows.Forms.CheckBox cbCappuccino;
        private System.Windows.Forms.CheckBox cbBlueMountain;
        private System.Windows.Forms.CheckBox cbCaramel;
        private System.Windows.Forms.CheckBox cbBlackCoffee;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.Button btnOrderShow;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button clrBtn;
    }
}