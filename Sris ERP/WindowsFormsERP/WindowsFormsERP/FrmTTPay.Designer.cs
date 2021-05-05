namespace WindowsFormsERP
{
    partial class FrmTTPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTTPay));
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBankCharges = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comCurrency = new System.Windows.Forms.ComboBox();
            this.comGLAccount = new System.Windows.Forms.ComboBox();
            this.comBankName = new System.Windows.Forms.ComboBox();
            this.dtpTTDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankAcNo = new System.Windows.Forms.TextBox();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(128, 9);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(109, 35);
            this.CmdExit.TabIndex = 10;
            this.CmdExit.Text = "&Cancel";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(10, 8);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(108, 36);
            this.CmdUpdate.TabIndex = 9;
            this.CmdUpdate.Text = "&OK";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 381);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 20);
            this.label20.TabIndex = 90;
            this.label20.Text = "Total Amount";
            // 
            // txtBankCharges
            // 
            this.txtBankCharges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBankCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankCharges.Location = new System.Drawing.Point(161, 345);
            this.txtBankCharges.Name = "txtBankCharges";
            this.txtBankCharges.Size = new System.Drawing.Size(422, 26);
            this.txtBankCharges.TabIndex = 7;
            this.txtBankCharges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankCharges_KeyDown);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 88;
            this.label18.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(161, 312);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(422, 26);
            this.txtAmount.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Location = new System.Drawing.Point(48, 456);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 53);
            this.panel5.TabIndex = 86;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(44, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 20);
            this.label23.TabIndex = 56;
            this.label23.Text = "Bank Name";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1215, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "TT Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-18, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 583);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comCurrency);
            this.groupBox1.Controls.Add(this.comGLAccount);
            this.groupBox1.Controls.Add(this.comBankName);
            this.groupBox1.Controls.Add(this.dtpTTDate);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtBankCharges);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBankAcNo);
            this.groupBox1.Controls.Add(this.txtExchangeRate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 553);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comCurrency
            // 
            this.comCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comCurrency.FormattingEnabled = true;
            this.comCurrency.Location = new System.Drawing.Point(853, 57);
            this.comCurrency.Name = "comCurrency";
            this.comCurrency.Size = new System.Drawing.Size(263, 28);
            this.comCurrency.TabIndex = 4;
            this.comCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comCurrency_KeyDown);
            // 
            // comGLAccount
            // 
            this.comGLAccount.FormattingEnabled = true;
            this.comGLAccount.Location = new System.Drawing.Point(161, 165);
            this.comGLAccount.Name = "comGLAccount";
            this.comGLAccount.Size = new System.Drawing.Size(422, 28);
            this.comGLAccount.TabIndex = 3;
            this.comGLAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comGLAccount_KeyDown);
            // 
            // comBankName
            // 
            this.comBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBankName.FormattingEnabled = true;
            this.comBankName.Location = new System.Drawing.Point(161, 93);
            this.comBankName.Name = "comBankName";
            this.comBankName.Size = new System.Drawing.Size(422, 28);
            this.comBankName.TabIndex = 1;
            this.comBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comBankName_KeyDown);
            // 
            // dtpTTDate
            // 
            this.dtpTTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTTDate.Location = new System.Drawing.Point(161, 57);
            this.dtpTTDate.Name = "dtpTTDate";
            this.dtpTTDate.Size = new System.Drawing.Size(422, 26);
            this.dtpTTDate.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(161, 378);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(422, 26);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Bank Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "G/L Account";
            // 
            // txtBankAcNo
            // 
            this.txtBankAcNo.Enabled = false;
            this.txtBankAcNo.Location = new System.Drawing.Point(161, 130);
            this.txtBankAcNo.Name = "txtBankAcNo";
            this.txtBankAcNo.Size = new System.Drawing.Size(422, 26);
            this.txtBankAcNo.TabIndex = 2;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExchangeRate.Location = new System.Drawing.Point(853, 93);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(263, 26);
            this.txtExchangeRate.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(715, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Exchange Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Bank A/C No";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "User Level  :";
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "User ID       :";
            this.label7.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(186, 36);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 52;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(186, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 51;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // FrmTTPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1215, 634);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTTPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TT Payment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmTTPay_Load);
            this.Resize += new System.EventHandler(this.FrmTTPay_Resize);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBankCharges;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankAcNo;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTTDate;
        private System.Windows.Forms.ComboBox comCurrency;
        private System.Windows.Forms.ComboBox comGLAccount;
        private System.Windows.Forms.ComboBox comBankName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}