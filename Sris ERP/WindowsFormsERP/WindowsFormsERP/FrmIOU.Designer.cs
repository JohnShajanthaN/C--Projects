namespace WindowsFormsERP
{
    partial class FrmIOU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIOU));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSerIOU = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdPDF = new System.Windows.Forms.Button();
            this.cmdRe = new System.Windows.Forms.Button();
            this.cmdClr = new System.Windows.Forms.Button();
            this.cmdBlank = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdVPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpStlDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPRDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSptDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSPfDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrAmount = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comItem = new System.Windows.Forms.ComboBox();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpIOUDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIOUNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIOUName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(926, 450);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSerIOU);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-18, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 693);
            this.panel1.TabIndex = 9;
            // 
            // txtSerIOU
            // 
            this.txtSerIOU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerIOU.Location = new System.Drawing.Point(1136, 614);
            this.txtSerIOU.Name = "txtSerIOU";
            this.txtSerIOU.Size = new System.Drawing.Size(113, 20);
            this.txtSerIOU.TabIndex = 21;
            this.txtSerIOU.Visible = false;
            this.txtSerIOU.TextChanged += new System.EventHandler(this.txtSerIOU_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmdPDF);
            this.panel5.Controls.Add(this.cmdRe);
            this.panel5.Controls.Add(this.cmdClr);
            this.panel5.Controls.Add(this.cmdBlank);
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdVPrint);
            this.panel5.Location = new System.Drawing.Point(97, 614);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(897, 47);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmdPDF
            // 
            this.cmdPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdPDF.Location = new System.Drawing.Point(155, 5);
            this.cmdPDF.Name = "cmdPDF";
            this.cmdPDF.Size = new System.Drawing.Size(147, 36);
            this.cmdPDF.TabIndex = 15;
            this.cmdPDF.Text = "&PDF Report";
            this.cmdPDF.UseVisualStyleBackColor = true;
            // 
            // cmdRe
            // 
            this.cmdRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdRe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdRe.Location = new System.Drawing.Point(599, 5);
            this.cmdRe.Name = "cmdRe";
            this.cmdRe.Size = new System.Drawing.Size(144, 36);
            this.cmdRe.TabIndex = 18;
            this.cmdRe.Text = "&Refresh";
            this.cmdRe.UseVisualStyleBackColor = true;
            this.cmdRe.Click += new System.EventHandler(this.cmdRe_Click);
            // 
            // cmdClr
            // 
            this.cmdClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdClr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdClr.Location = new System.Drawing.Point(305, 5);
            this.cmdClr.Name = "cmdClr";
            this.cmdClr.Size = new System.Drawing.Size(144, 36);
            this.cmdClr.TabIndex = 16;
            this.cmdClr.Text = "C&lear";
            this.cmdClr.UseVisualStyleBackColor = true;
            this.cmdClr.Click += new System.EventHandler(this.cmdClr_Click);
            // 
            // cmdBlank
            // 
            this.cmdBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdBlank.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdBlank.Location = new System.Drawing.Point(452, 5);
            this.cmdBlank.Name = "cmdBlank";
            this.cmdBlank.Size = new System.Drawing.Size(144, 36);
            this.cmdBlank.TabIndex = 17;
            this.cmdBlank.Text = "&Blank";
            this.cmdBlank.UseVisualStyleBackColor = true;
            this.cmdBlank.Click += new System.EventHandler(this.cmdBlank_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmdExit.Location = new System.Drawing.Point(746, 5);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(144, 36);
            this.CmdExit.TabIndex = 19;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click_1);
            // 
            // CmdVPrint
            // 
            this.CmdVPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CmdVPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmdVPrint.Location = new System.Drawing.Point(6, 5);
            this.CmdVPrint.Name = "CmdVPrint";
            this.CmdVPrint.Size = new System.Drawing.Size(146, 36);
            this.CmdVPrint.TabIndex = 14;
            this.CmdVPrint.Text = "&View && Print";
            this.CmdVPrint.UseVisualStyleBackColor = true;
            this.CmdVPrint.Click += new System.EventHandler(this.CmdVPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpStlDate);
            this.groupBox1.Controls.Add(this.dtpPRDate);
            this.groupBox1.Controls.Add(this.dtpSptDate);
            this.groupBox1.Controls.Add(this.dtpSPfDate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBrAmount);
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(64, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtpStlDate
            // 
            this.dtpStlDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStlDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStlDate.Location = new System.Drawing.Point(1027, 95);
            this.dtpStlDate.Name = "dtpStlDate";
            this.dtpStlDate.Size = new System.Drawing.Size(114, 22);
            this.dtpStlDate.TabIndex = 8;
            this.dtpStlDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpStlDate_KeyDown);
            // 
            // dtpPRDate
            // 
            this.dtpPRDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPRDate.Location = new System.Drawing.Point(593, 94);
            this.dtpPRDate.Name = "dtpPRDate";
            this.dtpPRDate.Size = new System.Drawing.Size(131, 22);
            this.dtpPRDate.TabIndex = 7;
            this.dtpPRDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpPRDate_KeyDown);
            // 
            // dtpSptDate
            // 
            this.dtpSptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSptDate.Location = new System.Drawing.Point(303, 94);
            this.dtpSptDate.Name = "dtpSptDate";
            this.dtpSptDate.Size = new System.Drawing.Size(112, 22);
            this.dtpSptDate.TabIndex = 6;
            this.dtpSptDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSptDate_KeyDown);
            // 
            // dtpSPfDate
            // 
            this.dtpSPfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSPfDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSPfDate.Location = new System.Drawing.Point(151, 94);
            this.dtpSPfDate.Name = "dtpSPfDate";
            this.dtpSPfDate.Size = new System.Drawing.Size(110, 22);
            this.dtpSPfDate.TabIndex = 5;
            this.dtpSPfDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSPfDate_KeyDown);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(750, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(273, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Date of Settlement (Bill / Petty Cash Voucher)";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(442, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Payment Request Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(274, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Borrowed Amount";
            // 
            // txtBrAmount
            // 
            this.txtBrAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrAmount.Location = new System.Drawing.Point(150, 62);
            this.txtBrAmount.Name = "txtBrAmount";
            this.txtBrAmount.Size = new System.Drawing.Size(265, 22);
            this.txtBrAmount.TabIndex = 3;
            this.txtBrAmount.Text = "0.00";
            this.txtBrAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrAmount_KeyDown);
            this.txtBrAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrAmount_KeyPress);
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(593, 62);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(550, 22);
            this.txtReason.TabIndex = 4;
            this.txtReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReason_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(442, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Reason";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Statement Period";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 29);
            this.panel2.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(253, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Content (Limit Amount : 10, 000 LKR)";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(63, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1190, 345);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.comItem);
            this.groupBox3.Controls.Add(this.cmdDel);
            this.groupBox3.Controls.Add(this.cmdAdd);
            this.groupBox3.Location = new System.Drawing.Point(12, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(516, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Amount (Rs.)";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAmount.Location = new System.Drawing.Point(605, 29);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(87, 22);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(22, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 16);
            this.label20.TabIndex = 47;
            this.label20.Text = "Item";
            // 
            // comItem
            // 
            this.comItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comItem.FormattingEnabled = true;
            this.comItem.Location = new System.Drawing.Point(61, 30);
            this.comItem.Name = "comItem";
            this.comItem.Size = new System.Drawing.Size(427, 24);
            this.comItem.TabIndex = 9;
            this.comItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comItem_KeyDown);
            // 
            // cmdDel
            // 
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdDel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdDel.Location = new System.Drawing.Point(823, 26);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(95, 26);
            this.cmdDel.TabIndex = 12;
            this.cmdDel.Text = "&Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdAdd.Location = new System.Drawing.Point(720, 27);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(95, 26);
            this.cmdAdd.TabIndex = 11;
            this.cmdAdd.Text = "&Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(997, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 16);
            this.label22.TabIndex = 54;
            this.label22.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1047, 279);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(103, 22);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1184, 29);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 188);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpIOUDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIOUNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIOUName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(65, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dtpIOUDate
            // 
            this.dtpIOUDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIOUDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIOUDate.Location = new System.Drawing.Point(370, 36);
            this.dtpIOUDate.Name = "dtpIOUDate";
            this.dtpIOUDate.Size = new System.Drawing.Size(135, 22);
            this.dtpIOUDate.TabIndex = 1;
            this.dtpIOUDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpIOUDate_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total Amount";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(926, 418);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "IOU Amount";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(926, 385);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 20);
            this.textBox6.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(841, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Sub Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "IOU No";
            // 
            // txtIOUNo
            // 
            this.txtIOUNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIOUNo.Location = new System.Drawing.Point(87, 36);
            this.txtIOUNo.Name = "txtIOUNo";
            this.txtIOUNo.Size = new System.Drawing.Size(211, 22);
            this.txtIOUNo.TabIndex = 0;
            this.txtIOUNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIOUNo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Date";
            // 
            // txtIOUName
            // 
            this.txtIOUName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIOUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIOUName.Location = new System.Drawing.Point(592, 36);
            this.txtIOUName.Name = "txtIOUName";
            this.txtIOUName.Size = new System.Drawing.Size(548, 22);
            this.txtIOUName.TabIndex = 2;
            this.txtIOUName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIName_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Name";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "IOU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(35, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 16);
            this.label23.TabIndex = 72;
            this.label23.Text = "User Level  :";
            this.label23.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(35, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 16);
            this.label24.TabIndex = 71;
            this.label24.Text = "User ID       :";
            this.label24.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(133, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 69;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(133, 36);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 70;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // FrmIOU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIOU";
            this.Text = "IOU";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIOU_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FrmIOU_ClientSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIOUName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpSptDate;
        private System.Windows.Forms.DateTimePicker dtpSPfDate;
        private System.Windows.Forms.DateTimePicker dtpStlDate;
        private System.Windows.Forms.DateTimePicker dtpPRDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comItem;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSerIOU;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cmdPDF;
        private System.Windows.Forms.Button cmdRe;
        private System.Windows.Forms.Button cmdClr;
        private System.Windows.Forms.Button cmdBlank;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdVPrint;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblULevel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpIOUDate;
        private System.Windows.Forms.TextBox txtIOUNo;
    }
}