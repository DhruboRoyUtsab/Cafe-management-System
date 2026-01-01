namespace CMS
{
    partial class AddCashier
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
            this.lblAddCashier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblDateofBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerJD = new System.Windows.Forms.DateTimePicker();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddCashier
            // 
            this.lblAddCashier.AutoSize = true;
            this.lblAddCashier.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCashier.ForeColor = System.Drawing.Color.White;
            this.lblAddCashier.Location = new System.Drawing.Point(688, 30);
            this.lblAddCashier.Name = "lblAddCashier";
            this.lblAddCashier.Size = new System.Drawing.Size(353, 55);
            this.lblAddCashier.TabIndex = 2;
            this.lblAddCashier.Text = "ADD CASHIER";
            this.lblAddCashier.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CMS.Properties.Resources.logo;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 661);
            this.panel1.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(734, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 24);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Name :";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJoiningDate.Location = new System.Drawing.Point(681, 361);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(124, 24);
            this.lblJoiningDate.TabIndex = 8;
            this.lblJoiningDate.Text = "Joining Date :";
            // 
            // lblDateofBirth
            // 
            this.lblDateofBirth.AutoSize = true;
            this.lblDateofBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofBirth.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateofBirth.Location = new System.Drawing.Point(685, 319);
            this.lblDateofBirth.Name = "lblDateofBirth";
            this.lblDateofBirth.Size = new System.Drawing.Size(120, 24);
            this.lblDateofBirth.TabIndex = 9;
            this.lblDateofBirth.Text = "Date of Birth :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGender.Location = new System.Drawing.Point(721, 211);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 24);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(715, 248);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(90, 24);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(738, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 24);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email :";
            // 
            // TBUserName
            // 
            this.TBUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserName.Location = new System.Drawing.Point(821, 120);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(220, 31);
            this.TBUserName.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(821, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 31);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(821, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 31);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(821, 452);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 31);
            this.textBox3.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(703, 405);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(633, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Confirm Password :";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(821, 319);
            this.dateTimePickerDOB.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(220, 29);
            this.dateTimePickerDOB.TabIndex = 19;
            // 
            // dateTimePickerJD
            // 
            this.dateTimePickerJD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJD.Location = new System.Drawing.Point(821, 361);
            this.dateTimePickerJD.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerJD.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerJD.Name = "dateTimePickerJD";
            this.dateTimePickerJD.Size = new System.Drawing.Size(220, 29);
            this.dateTimePickerJD.TabIndex = 20;
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.BackColor = System.Drawing.Color.Transparent;
            this.RBMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMale.ForeColor = System.Drawing.Color.White;
            this.RBMale.Location = new System.Drawing.Point(821, 217);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(69, 28);
            this.RBMale.TabIndex = 21;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = false;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.BackColor = System.Drawing.Color.Transparent;
            this.RBFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFemale.ForeColor = System.Drawing.Color.White;
            this.RBFemale.Location = new System.Drawing.Point(911, 217);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(92, 28);
            this.RBFemale.TabIndex = 22;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(821, 251);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 49);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(784, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add Cashier";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AddCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.RBFemale);
            this.Controls.Add(this.RBMale);
            this.Controls.Add(this.dateTimePickerJD);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDateofBirth);
            this.Controls.Add(this.lblJoiningDate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddCashier);
            this.Name = "AddCashier";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCashier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblDateofBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerJD;
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
    }
}