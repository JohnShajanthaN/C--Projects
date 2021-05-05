namespace WindowsFormsERP
{
    partial class FrmOgPay1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgPay1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNBT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotBT = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.OptAcc = new System.Windows.Forms.RadioButton();
            this.OptCus = new System.Windows.Forms.RadioButton();
            this.OptVen = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCur = new System.Windows.Forms.TextBox();
            this.TxtInvNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpPDate);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtNBT);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTotBT);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRem);
            this.groupBox1.Controls.Add(this.OptAcc);
            this.groupBox1.Controls.Add(this.OptCus);
            this.groupBox1.Controls.Add(this.OptVen);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCur);
            this.groupBox1.Controls.Add(this.TxtInvNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtRefNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(68, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 598);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dtpPDate
            // 
            this.dtpPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPDate.Location = new System.Drawing.Point(933, 88);
            this.dtpPDate.Name = "dtpPDate";
            this.dtpPDate.Size = new System.Drawing.Size(183, 20);
            this.dtpPDate.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(882, 420);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 90;
            this.label20.Text = "Total Amount";
            // 
            // txtNBT
            // 
            this.txtNBT.Location = new System.Drawing.Point(994, 416);
            this.txtNBT.Name = "txtNBT";
            this.txtNBT.Size = new System.Drawing.Size(122, 20);
            this.txtNBT.TabIndex = 89;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(884, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Payment on Account";
            // 
            // txtTotBT
            // 
            this.txtTotBT.Location = new System.Drawing.Point(994, 390);
            this.txtTotBT.Name = "txtTotBT";
            this.txtTotBT.Size = new System.Drawing.Size(122, 20);
            this.txtTotBT.TabIndex = 87;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Location = new System.Drawing.Point(92, 502);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 53);
            this.panel5.TabIndex = 86;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(128, 9);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(109, 35);
            this.CmdExit.TabIndex = 23;
            this.CmdExit.Text = "&Cancel";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(10, 8);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(108, 36);
            this.CmdUpdate.TabIndex = 21;
            this.CmdUpdate.Text = "&Save";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Remarks";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(91, 416);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(759, 20);
            this.txtRem.TabIndex = 84;
            // 
            // OptAcc
            // 
            this.OptAcc.AutoSize = true;
            this.OptAcc.Location = new System.Drawing.Point(486, 121);
            this.OptAcc.Name = "OptAcc";
            this.OptAcc.Size = new System.Drawing.Size(65, 17);
            this.OptAcc.TabIndex = 6;
            this.OptAcc.TabStop = true;
            this.OptAcc.Text = "Account";
            this.OptAcc.UseVisualStyleBackColor = true;
            // 
            // OptCus
            // 
            this.OptCus.AutoSize = true;
            this.OptCus.Location = new System.Drawing.Point(486, 92);
            this.OptCus.Name = "OptCus";
            this.OptCus.Size = new System.Drawing.Size(69, 17);
            this.OptCus.TabIndex = 5;
            this.OptCus.TabStop = true;
            this.OptCus.Text = "Customer";
            this.OptCus.UseVisualStyleBackColor = true;
            // 
            // OptVen
            // 
            this.OptVen.AutoSize = true;
            this.OptVen.Location = new System.Drawing.Point(486, 59);
            this.OptVen.Name = "OptVen";
            this.OptVen.Size = new System.Drawing.Size(59, 17);
            this.OptVen.TabIndex = 4;
            this.OptVen.TabStop = true;
            this.OptVen.Text = "Vender";
            this.OptVen.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Currency";
            // 
            // txtCur
            // 
            this.txtCur.Location = new System.Drawing.Point(95, 147);
            this.txtCur.Name = "txtCur";
            this.txtCur.Size = new System.Drawing.Size(347, 20);
            this.txtCur.TabIndex = 3;
            // 
            // TxtInvNo
            // 
            this.TxtInvNo.Location = new System.Drawing.Point(95, 117);
            this.TxtInvNo.Name = "TxtInvNo";
            this.TxtInvNo.Size = new System.Drawing.Size(347, 20);
            this.TxtInvNo.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 186);
            this.dataGridView1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(840, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Posting Date";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(933, 57);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(185, 20);
            this.txtRefNo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Supplier";
            // 
            // txtSup
            // 
            this.txtSup.Location = new System.Drawing.Point(95, 57);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(347, 20);
            this.txtSup.TabIndex = 0;
            this.txtSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSup_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Invoice No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "No.";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Outgoing Payment 1";
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
            this.panel1.Size = new System.Drawing.Size(1303, 702);
            this.panel1.TabIndex = 10;
            // 
            // FrmOgPay1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOgPay1";
            this.Text = "Outgoing Payment 1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOgPay1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCur;
        private System.Windows.Forms.TextBox TxtInvNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton OptAcc;
        private System.Windows.Forms.RadioButton OptCus;
        private System.Windows.Forms.RadioButton OptVen;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNBT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotBT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.DateTimePicker dtpPDate;
    }
}