namespace WindowsFormsERP
{
    partial class FrmARInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmARInv));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDoDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDuDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPoDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNBT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotBT = new System.Windows.Forms.TextBox();
            this.txtSta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCur = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpDoDate);
            this.groupBox1.Controls.Add(this.dtpDuDate);
            this.groupBox1.Controls.Add(this.dtpPoDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtTot);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtVS);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtNBT);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTotBT);
            this.groupBox1.Controls.Add(this.txtSta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInvNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCur);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(68, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 579);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpDoDate
            // 
            this.dtpDoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoDate.Location = new System.Drawing.Point(920, 181);
            this.dtpDoDate.Name = "dtpDoDate";
            this.dtpDoDate.Size = new System.Drawing.Size(198, 20);
            this.dtpDoDate.TabIndex = 7;
            // 
            // dtpDuDate
            // 
            this.dtpDuDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDuDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuDate.Location = new System.Drawing.Point(920, 149);
            this.dtpDuDate.Name = "dtpDuDate";
            this.dtpDuDate.Size = new System.Drawing.Size(198, 20);
            this.dtpDuDate.TabIndex = 6;
            this.dtpDuDate.ValueChanged += new System.EventHandler(this.dtpDuDate_ValueChanged);
            // 
            // dtpPoDate
            // 
            this.dtpPoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPoDate.Location = new System.Drawing.Point(920, 115);
            this.dtpPoDate.Name = "dtpPoDate";
            this.dtpPoDate.Size = new System.Drawing.Size(198, 20);
            this.dtpPoDate.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(834, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Document Date";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(835, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Posting Date";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(834, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "Due Date";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(933, 465);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 87;
            this.label22.Text = "Total";
            // 
            // txtTot
            // 
            this.txtTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTot.Location = new System.Drawing.Point(1022, 461);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(96, 20);
            this.txtTot.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(933, 439);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 85;
            this.label21.Text = "VAT / SVAT";
            // 
            // txtVS
            // 
            this.txtVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVS.Location = new System.Drawing.Point(1022, 435);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(96, 20);
            this.txtVS.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(933, 413);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 83;
            this.label20.Text = "NBT";
            // 
            // txtNBT
            // 
            this.txtNBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNBT.Location = new System.Drawing.Point(1022, 409);
            this.txtNBT.Name = "txtNBT";
            this.txtNBT.Size = new System.Drawing.Size(96, 20);
            this.txtNBT.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(932, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 81;
            this.label18.Text = "Total Before Tax";
            // 
            // txtTotBT
            // 
            this.txtTotBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotBT.Location = new System.Drawing.Point(1022, 383);
            this.txtTotBT.Name = "txtTotBT";
            this.txtTotBT.Size = new System.Drawing.Size(96, 20);
            this.txtTotBT.TabIndex = 9;
            // 
            // txtSta
            // 
            this.txtSta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSta.Location = new System.Drawing.Point(920, 80);
            this.txtSta.Name = "txtSta";
            this.txtSta.Size = new System.Drawing.Size(198, 20);
            this.txtSta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Invoice No.";
            // 
            // txtInvNo
            // 
            this.txtInvNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvNo.Location = new System.Drawing.Point(920, 47);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(198, 20);
            this.txtInvNo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(835, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Status";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Location = new System.Drawing.Point(92, 496);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 53);
            this.panel5.TabIndex = 75;
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
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Remarks";
            // 
            // txtRem
            // 
            this.txtRem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRem.Location = new System.Drawing.Point(92, 409);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(774, 20);
            this.txtRem.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Currency";
            // 
            // txtCur
            // 
            this.txtCur.Location = new System.Drawing.Point(95, 111);
            this.txtCur.Name = "txtCur";
            this.txtCur.Size = new System.Drawing.Size(393, 20);
            this.txtCur.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(393, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 155);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Customer";
            // 
            // txtCus
            // 
            this.txtCus.Location = new System.Drawing.Point(95, 47);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(393, 20);
            this.txtCus.TabIndex = 0;
            this.txtCus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCus_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Name";
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
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "A/R Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "User Level  :";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "User ID       :";
            this.label12.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(151, 36);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 48;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(151, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 47;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // FrmARInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmARInv";
            this.Text = "A/R Invoice";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmARInv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtVS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNBT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotBT;
        private System.Windows.Forms.TextBox txtSta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCur;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDoDate;
        private System.Windows.Forms.DateTimePicker dtpDuDate;
        private System.Windows.Forms.DateTimePicker dtpPoDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label lblUser1;
    }
}