namespace WindowsFormsERP
{
    partial class FrmChqPayment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChqPayment));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comSup = new System.Windows.Forms.ComboBox();
            this.comAccNo = new System.Windows.Forms.ComboBox();
            this.comBranch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comBank = new System.Windows.Forms.ComboBox();
            this.comChqNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.comSupID = new System.Windows.Forms.ComboBox();
            this.dtpPVDate = new System.Windows.Forms.DateTimePicker();
            this.comPVNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpCDate = new System.Windows.Forms.DateTimePicker();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmdExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.CmdComplete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.butRefresh = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comSup
            // 
            this.comSup.Enabled = false;
            this.comSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comSup.FormattingEnabled = true;
            this.comSup.Location = new System.Drawing.Point(259, 70);
            this.comSup.Name = "comSup";
            this.comSup.Size = new System.Drawing.Size(377, 24);
            this.comSup.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comSup, "Journal Detail");
            // 
            // comAccNo
            // 
            this.comAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comAccNo.FormattingEnabled = true;
            this.comAccNo.Location = new System.Drawing.Point(27, 155);
            this.comAccNo.Name = "comAccNo";
            this.comAccNo.Size = new System.Drawing.Size(377, 24);
            this.comAccNo.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comAccNo, "Select Credit or Debit");
            // 
            // comBranch
            // 
            this.comBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBranch.FormattingEnabled = true;
            this.comBranch.Location = new System.Drawing.Point(320, 96);
            this.comBranch.Name = "comBranch";
            this.comBranch.Size = new System.Drawing.Size(310, 24);
            this.comBranch.TabIndex = 7;
            this.toolTip1.SetToolTip(this.comBranch, "Select Credit or Debit");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(419, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Amount";
            this.toolTip1.SetToolTip(this.label11, "Oppersit Perticular (Double Entry)");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Account No";
            this.toolTip1.SetToolTip(this.label9, "Oppersit Perticular (Double Entry)");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Branch";
            this.toolTip1.SetToolTip(this.label7, "Oppersit Perticular (Double Entry)");
            // 
            // comBank
            // 
            this.comBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBank.FormattingEnabled = true;
            this.comBank.Location = new System.Drawing.Point(27, 96);
            this.comBank.Name = "comBank";
            this.comBank.Size = new System.Drawing.Size(274, 24);
            this.comBank.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comBank, "Select Credit or Debit");
            this.comBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comBank_KeyDown);
            // 
            // comChqNo
            // 
            this.comChqNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comChqNo.FormattingEnabled = true;
            this.comChqNo.Location = new System.Drawing.Point(189, 39);
            this.comChqNo.Name = "comChqNo";
            this.comChqNo.Size = new System.Drawing.Size(441, 24);
            this.comChqNo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comChqNo, "From / For");
            this.comChqNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comChqNo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cheque No";
            this.toolTip1.SetToolTip(this.label8, "Oppersit Perticular (Double Entry)");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 133);
            this.dataGridView1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.dataGridView1, "Select record for Edit or Delete!");
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(498, 33);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 89;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "User Level  :";
            this.label2.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(596, 9);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 90;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // comSupID
            // 
            this.comSupID.Enabled = false;
            this.comSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comSupID.FormattingEnabled = true;
            this.comSupID.Location = new System.Drawing.Point(101, 70);
            this.comSupID.Name = "comSupID";
            this.comSupID.Size = new System.Drawing.Size(140, 24);
            this.comSupID.TabIndex = 2;
            // 
            // dtpPVDate
            // 
            this.dtpPVDate.Enabled = false;
            this.dtpPVDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPVDate.Location = new System.Drawing.Point(326, 34);
            this.dtpPVDate.Name = "dtpPVDate";
            this.dtpPVDate.Size = new System.Drawing.Size(310, 22);
            this.dtpPVDate.TabIndex = 1;
            // 
            // comPVNo
            // 
            this.comPVNo.Enabled = false;
            this.comPVNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPVNo.FormattingEnabled = true;
            this.comPVNo.Location = new System.Drawing.Point(101, 33);
            this.comPVNo.Name = "comPVNo";
            this.comPVNo.Size = new System.Drawing.Size(140, 24);
            this.comPVNo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Supplier";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "PV No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(261, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "PV Date";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(198, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 30);
            this.label1.TabIndex = 87;
            this.label1.Text = "Voucher Cheque Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comAccNo);
            this.groupBox1.Controls.Add(this.comBranch);
            this.groupBox1.Controls.Add(this.dtpCDate);
            this.groupBox1.Controls.Add(this.CmdDelete);
            this.groupBox1.Controls.Add(this.CmdSave);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comBank);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comChqNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtpCDate
            // 
            this.dtpCDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCDate.Location = new System.Drawing.Point(28, 40);
            this.dtpCDate.Name = "dtpCDate";
            this.dtpCDate.Size = new System.Drawing.Size(145, 22);
            this.dtpCDate.TabIndex = 4;
            this.dtpCDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpCDate_KeyDown);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(133, 198);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(102, 27);
            this.CmdDelete.TabIndex = 11;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(27, 198);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(100, 27);
            this.CmdSave.TabIndex = 10;
            this.CmdSave.Text = "&Add";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(422, 156);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(208, 22);
            this.txtAmount.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cheque Date";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.comSupID);
            this.groupBox3.Controls.Add(this.dtpPVDate);
            this.groupBox3.Controls.Add(this.comSup);
            this.groupBox3.Controls.Add(this.comPVNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(6, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 348);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(338, 2);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(111, 31);
            this.CmdExit.TabIndex = 15;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "User ID       :";
            this.label3.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CmdComplete
            // 
            this.CmdComplete.Location = new System.Drawing.Point(4, 3);
            this.CmdComplete.Name = "CmdComplete";
            this.CmdComplete.Size = new System.Drawing.Size(109, 31);
            this.CmdComplete.TabIndex = 12;
            this.CmdComplete.Text = "&Complete";
            this.CmdComplete.UseVisualStyleBackColor = true;
            this.CmdComplete.Click += new System.EventHandler(this.CmdComplete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 651);
            this.panel1.TabIndex = 88;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(10, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(659, 233);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(654, 29);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Updated Details";
            // 
            // TxtSer
            // 
            this.TxtSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSer.Location = new System.Drawing.Point(115, 54);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(519, 22);
            this.TxtSer.TabIndex = 16;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Search";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.butRefresh);
            this.panel5.Controls.Add(this.CmdClear);
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdComplete);
            this.panel5.Location = new System.Drawing.Point(12, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 38);
            this.panel5.TabIndex = 2;
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(227, 2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(109, 31);
            this.butRefresh.TabIndex = 14;
            this.butRefresh.Text = "&Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(116, 2);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(109, 31);
            this.CmdClear.TabIndex = 13;
            this.CmdClear.Text = "&Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // FrmChqPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(675, 702);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmChqPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Cheque Payment";
            this.Load += new System.EventHandler(this.FrmChqPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comSup;
        private System.Windows.Forms.ComboBox comAccNo;
        private System.Windows.Forms.ComboBox comBranch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comBank;
        private System.Windows.Forms.ComboBox comChqNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.ComboBox comSupID;
        private System.Windows.Forms.DateTimePicker dtpPVDate;
        private System.Windows.Forms.ComboBox comPVNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpCDate;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button CmdComplete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button CmdClear;
    }
}