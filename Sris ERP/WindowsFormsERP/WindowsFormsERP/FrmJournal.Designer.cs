namespace WindowsFormsERP
{
    partial class FrmJournal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comPLACType = new System.Windows.Forms.ComboBox();
            this.comCashFlow = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comBalALType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmdCloseSt = new System.Windows.Forms.Button();
            this.CmdOpenSt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comOpc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpJDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comPaticular = new System.Windows.Forms.ComboBox();
            this.comJNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 657);
            this.panel1.TabIndex = 58;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(10, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 233);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 29);
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
            this.TxtSer.Size = new System.Drawing.Size(367, 22);
            this.TxtSer.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 133);
            this.dataGridView1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dataGridView1, "Select record for Edit or Delete!");
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdDelete);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Controls.Add(this.CmdSave);
            this.panel5.Location = new System.Drawing.Point(39, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 37);
            this.panel5.TabIndex = 1;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(338, 1);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(111, 31);
            this.CmdExit.TabIndex = 3;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(225, 1);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(110, 31);
            this.CmdDelete.TabIndex = 2;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(113, 1);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(109, 31);
            this.CmdUpdate.TabIndex = 1;
            this.CmdUpdate.Text = "&Edit";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(2, 1);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(108, 31);
            this.CmdSave.TabIndex = 0;
            this.CmdSave.Text = "&Add";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.comPLACType);
            this.groupBox3.Controls.Add(this.comCashFlow);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comBalALType);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CmdCloseSt);
            this.groupBox3.Controls.Add(this.CmdOpenSt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comOpc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.dtpJDate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comCategory);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comPaticular);
            this.groupBox3.Controls.Add(this.comJNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(6, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 356);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // comPLACType
            // 
            this.comPLACType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPLACType.FormattingEnabled = true;
            this.comPLACType.Items.AddRange(new object[] {
            "Direct Expenses",
            "Indirect Expenses",
            "Indirect Incomes",
            "Others"});
            this.comPLACType.Location = new System.Drawing.Point(119, 216);
            this.comPLACType.Name = "comPLACType";
            this.comPLACType.Size = new System.Drawing.Size(367, 24);
            this.comPLACType.TabIndex = 6;
            this.comPLACType.Text = "Indirect Expenses";
            this.toolTip1.SetToolTip(this.comPLACType, "for Trade and Profit Loss Sub Division");
            this.comPLACType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comPLACType_KeyDown);
            // 
            // comCashFlow
            // 
            this.comCashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCashFlow.FormattingEnabled = true;
            this.comCashFlow.Items.AddRange(new object[] {
            "Operating Activities Inflows",
            "Operating Activities Outflows",
            "Investing Activities Inflows",
            "Investing Activities Outflows",
            "Financing Activities Inflows",
            "Financing Activities Outflows",
            "Others"});
            this.comCashFlow.Location = new System.Drawing.Point(119, 296);
            this.comCashFlow.Name = "comCashFlow";
            this.comCashFlow.Size = new System.Drawing.Size(367, 24);
            this.comCashFlow.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comCashFlow, "For Cash Flow Sub Division");
            this.comCashFlow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comCashFlow_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Cash Flow";
            this.toolTip1.SetToolTip(this.label11, "Oppersit Perticular (Double Entry)");
            // 
            // comBalALType
            // 
            this.comBalALType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBalALType.FormattingEnabled = true;
            this.comBalALType.Items.AddRange(new object[] {
            "Fiixed Assets",
            "Current Assets",
            "Capital - Equity",
            "Drawing - Equity",
            "Liabilities",
            "Others"});
            this.comBalALType.Location = new System.Drawing.Point(119, 256);
            this.comBalALType.Name = "comBalALType";
            this.comBalALType.Size = new System.Drawing.Size(367, 24);
            this.comBalALType.TabIndex = 7;
            this.toolTip1.SetToolTip(this.comBalALType, "For Balance Sheet (Assets , Liabilities) Sub Division");
            this.comBalALType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comBalALType_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "Bal. Sheet";
            this.toolTip1.SetToolTip(this.label10, "For Balance Sheet (Assets , Liabilities) Sub Division");
            // 
            // CmdCloseSt
            // 
            this.CmdCloseSt.Location = new System.Drawing.Point(377, 325);
            this.CmdCloseSt.Name = "CmdCloseSt";
            this.CmdCloseSt.Size = new System.Drawing.Size(109, 24);
            this.CmdCloseSt.TabIndex = 9;
            this.CmdCloseSt.Text = "Closing Stock";
            this.CmdCloseSt.UseVisualStyleBackColor = true;
            this.CmdCloseSt.Click += new System.EventHandler(this.CmdCloseSt_Click);
            // 
            // CmdOpenSt
            // 
            this.CmdOpenSt.Location = new System.Drawing.Point(265, 325);
            this.CmdOpenSt.Name = "CmdOpenSt";
            this.CmdOpenSt.Size = new System.Drawing.Size(109, 24);
            this.CmdOpenSt.TabIndex = 8;
            this.CmdOpenSt.Text = "Opening Stock";
            this.CmdOpenSt.UseVisualStyleBackColor = true;
            this.CmdOpenSt.Click += new System.EventHandler(this.CmdOpenSt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "PL A/C Type";
            this.toolTip1.SetToolTip(this.label9, "for Trade and Profit Loss Sub Division");
            // 
            // comOpc
            // 
            this.comOpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comOpc.FormattingEnabled = true;
            this.comOpc.Location = new System.Drawing.Point(119, 177);
            this.comOpc.Name = "comOpc";
            this.comOpc.Size = new System.Drawing.Size(367, 24);
            this.comOpc.TabIndex = 5;
            this.comOpc.Text = "Cash";
            this.toolTip1.SetToolTip(this.comOpc, "From / For");
            this.comOpc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comOpc_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Double Entry";
            this.toolTip1.SetToolTip(this.label8, "Oppersit Perticular (Double Entry)");
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(119, 142);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(367, 22);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // dtpJDate
            // 
            this.dtpJDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJDate.Location = new System.Drawing.Point(335, 33);
            this.dtpJDate.Name = "dtpJDate";
            this.dtpJDate.Size = new System.Drawing.Size(151, 22);
            this.dtpJDate.TabIndex = 1;
            this.dtpJDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpJDate_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Amount";
            // 
            // comCategory
            // 
            this.comCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCategory.FormattingEnabled = true;
            this.comCategory.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.comCategory.Location = new System.Drawing.Point(119, 106);
            this.comCategory.Name = "comCategory";
            this.comCategory.Size = new System.Drawing.Size(367, 24);
            this.comCategory.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comCategory, "Select Credit or Debit");
            this.comCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comCategory_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Category";
            // 
            // comPaticular
            // 
            this.comPaticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPaticular.FormattingEnabled = true;
            this.comPaticular.Location = new System.Drawing.Point(119, 70);
            this.comPaticular.Name = "comPaticular";
            this.comPaticular.Size = new System.Drawing.Size(367, 24);
            this.comPaticular.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comPaticular, "Journal Detail");
            this.comPaticular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comPaticular_KeyDown);
            // 
            // comJNo
            // 
            this.comJNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comJNo.FormattingEnabled = true;
            this.comJNo.Location = new System.Drawing.Point(119, 33);
            this.comJNo.Name = "comJNo";
            this.comJNo.Size = new System.Drawing.Size(144, 24);
            this.comJNo.TabIndex = 0;
            this.comJNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comJNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Partcular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "Journal No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(293, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Date";
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(395, 46);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 60;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 57;
            this.label1.Text = "Journal Entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "User ID       :";
            this.label3.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(395, 19);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 59;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "User Level  :";
            this.label2.Visible = false;
            // 
            // FrmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(531, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmJournal_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comPaticular;
        private System.Windows.Forms.ComboBox comJNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpJDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comOpc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comPLACType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CmdCloseSt;
        private System.Windows.Forms.Button CmdOpenSt;
        private System.Windows.Forms.ComboBox comBalALType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comCashFlow;
        private System.Windows.Forms.Label label11;
    }
}