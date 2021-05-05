namespace Dewmas_Job_Bank
{
    partial class FrmStaffRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaffRegistration));
            this.comNat = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comRel = new System.Windows.Forms.ComboBox();
            this.dtpJDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comCSta = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdRep = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTAddress = new System.Windows.Forms.TextBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.txtMOB = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comWrkDet = new System.Windows.Forms.ComboBox();
            this.txtWrkExp = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comPro = new System.Windows.Forms.ComboBox();
            this.txtOL = new System.Windows.Forms.TextBox();
            this.txtAL = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comCat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.comStfID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comNat
            // 
            this.comNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comNat.FormattingEnabled = true;
            this.comNat.Items.AddRange(new object[] {
            "Sinhalese",
            "Tamils",
            "Moor ",
            "Burgher",
            "Malay",
            "Vedda "});
            this.comNat.Location = new System.Drawing.Point(101, 349);
            this.comNat.Name = "comNat";
            this.comNat.Size = new System.Drawing.Size(188, 24);
            this.comNat.TabIndex = 11;
            this.comNat.SelectedIndexChanged += new System.EventHandler(this.comCourse_SelectedIndexChanged);
            this.comNat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comNat_KeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 350);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 18);
            this.label22.TabIndex = 75;
            this.label22.Text = "Nationality";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // comRel
            // 
            this.comRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comRel.FormattingEnabled = true;
            this.comRel.Items.AddRange(new object[] {
            "Buddhism ",
            "Hinduism ",
            "Christianity ",
            "Islam "});
            this.comRel.Location = new System.Drawing.Point(431, 313);
            this.comRel.Name = "comRel";
            this.comRel.Size = new System.Drawing.Size(229, 24);
            this.comRel.TabIndex = 10;
            this.comRel.SelectedIndexChanged += new System.EventHandler(this.comDes_SelectedIndexChanged);
            this.comRel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comRel_KeyDown);
            // 
            // dtpJDate
            // 
            this.dtpJDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJDate.Location = new System.Drawing.Point(431, 349);
            this.dtpJDate.Name = "dtpJDate";
            this.dtpJDate.Size = new System.Drawing.Size(229, 22);
            this.dtpJDate.TabIndex = 12;
            this.dtpJDate.ValueChanged += new System.EventHandler(this.dtpJDate_ValueChanged);
            this.dtpJDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpJDate_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(314, 350);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 18);
            this.label20.TabIndex = 71;
            this.label20.Text = "Join Date";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(4, 237);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 18);
            this.label21.TabIndex = 70;
            this.label21.Text = "Date of Birth";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // comCSta
            // 
            this.comCSta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCSta.FormattingEnabled = true;
            this.comCSta.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Divorced"});
            this.comCSta.Location = new System.Drawing.Point(101, 312);
            this.comCSta.Name = "comCSta";
            this.comCSta.Size = new System.Drawing.Size(188, 24);
            this.comCSta.TabIndex = 9;
            this.toolTip5.SetToolTip(this.comCSta, "Please Select Married Or Unmarried");
            this.comCSta.SelectedIndexChanged += new System.EventHandler(this.comCSta_SelectedIndexChanged);
            this.comCSta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comCSta_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtClear);
            this.panel2.Controls.Add(this.cmdExit);
            this.panel2.Controls.Add(this.cmdRep);
            this.panel2.Controls.Add(this.cmdDel);
            this.panel2.Controls.Add(this.cmdEdit);
            this.panel2.Controls.Add(this.cmdAdd);
            this.panel2.Location = new System.Drawing.Point(44, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 47);
            this.panel2.TabIndex = 48;
            // 
            // txtClear
            // 
            this.txtClear.BackColor = System.Drawing.Color.CadetBlue;
            this.txtClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.ForeColor = System.Drawing.Color.White;
            this.txtClear.Location = new System.Drawing.Point(846, 5);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(146, 37);
            this.txtClear.TabIndex = 25;
            this.txtClear.Text = "&CLEAR";
            this.txtClear.UseVisualStyleBackColor = false;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.White;
            this.cmdExit.Location = new System.Drawing.Point(1055, 5);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(146, 37);
            this.cmdExit.TabIndex = 24;
            this.cmdExit.Text = "&EXIT";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdRep
            // 
            this.cmdRep.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRep.ForeColor = System.Drawing.Color.White;
            this.cmdRep.Location = new System.Drawing.Point(636, 5);
            this.cmdRep.Name = "cmdRep";
            this.cmdRep.Size = new System.Drawing.Size(146, 37);
            this.cmdRep.TabIndex = 23;
            this.cmdRep.Text = "&REPORT";
            this.cmdRep.UseVisualStyleBackColor = false;
            this.cmdRep.Click += new System.EventHandler(this.cmdRep_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDel.ForeColor = System.Drawing.Color.White;
            this.cmdDel.Location = new System.Drawing.Point(427, 5);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(146, 37);
            this.cmdDel.TabIndex = 22;
            this.cmdDel.Text = "&DELETE";
            this.cmdDel.UseVisualStyleBackColor = false;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.ForeColor = System.Drawing.Color.White;
            this.cmdEdit.Location = new System.Drawing.Point(220, 5);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(146, 37);
            this.cmdEdit.TabIndex = 21;
            this.cmdEdit.Text = "&EDIT";
            this.cmdEdit.UseVisualStyleBackColor = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.Color.White;
            this.cmdAdd.Location = new System.Drawing.Point(7, 4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(146, 37);
            this.cmdAdd.TabIndex = 21;
            this.cmdAdd.Text = "&ADD";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            this.cmdAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdAdd_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 315);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 18);
            this.label19.TabIndex = 68;
            this.label19.Text = "Civil Status";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 18);
            this.label18.TabIndex = 66;
            this.label18.Text = "Gender";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtTAddress
            // 
            this.txtTAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAddress.Location = new System.Drawing.Point(431, 232);
            this.txtTAddress.Multiline = true;
            this.txtTAddress.Name = "txtTAddress";
            this.txtTAddress.Size = new System.Drawing.Size(229, 63);
            this.txtTAddress.TabIndex = 8;
            this.toolTip6.SetToolTip(this.txtTAddress, "Please Press Tab Key For Next TextBox");
            this.txtTAddress.TextChanged += new System.EventHandler(this.txtTAddress_TextChanged);
            this.txtTAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTAddress_KeyDown);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(101, 153);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(189, 22);
            this.txtTel.TabIndex = 6;
            this.toolTip3.SetToolTip(this.txtTel, "Please Enter Numbers Only");
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTel_KeyDown);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(100, 236);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.ReadOnly = true;
            this.dtpDOB.Size = new System.Drawing.Size(189, 22);
            this.dtpDOB.TabIndex = 52;
            this.toolTip3.SetToolTip(this.dtpDOB, "Please Enter Numbers Only");
            // 
            // txtGen
            // 
            this.txtGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGen.Location = new System.Drawing.Point(100, 195);
            this.txtGen.Name = "txtGen";
            this.txtGen.ReadOnly = true;
            this.txtGen.Size = new System.Drawing.Size(189, 22);
            this.txtGen.TabIndex = 51;
            this.toolTip3.SetToolTip(this.txtGen, "Please Enter Numbers Only");
            // 
            // txtMOB
            // 
            this.txtMOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOB.Location = new System.Drawing.Point(101, 113);
            this.txtMOB.Name = "txtMOB";
            this.txtMOB.Size = new System.Drawing.Size(188, 22);
            this.txtMOB.TabIndex = 4;
            this.toolTip2.SetToolTip(this.txtMOB, "Please Enter Numbers Only\r\n");
            this.txtMOB.TextChanged += new System.EventHandler(this.txtMOB_TextChanged);
            this.txtMOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMOB_KeyDown);
            // 
            // txtPAddress
            // 
            this.txtPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAddress.Location = new System.Drawing.Point(431, 153);
            this.txtPAddress.Multiline = true;
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.Size = new System.Drawing.Size(230, 61);
            this.txtPAddress.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtPAddress, "Please Press Tab Key For Next TextBox");
            this.txtPAddress.TextChanged += new System.EventHandler(this.txtPAddress_TextChanged);
            this.txtPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPAddress_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(314, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 57;
            this.label12.Text = "Religion";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 18);
            this.label16.TabIndex = 61;
            this.label16.Text = "Mobile No";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtEMail
            // 
            this.txtEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMail.Location = new System.Drawing.Point(431, 112);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(230, 22);
            this.txtEMail.TabIndex = 5;
            this.txtEMail.TextChanged += new System.EventHandler(this.txtEMail_TextChanged);
            this.txtEMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEMail_KeyDown);
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(101, 72);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(189, 22);
            this.txtNIC.TabIndex = 2;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            this.txtNIC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNIC_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 18);
            this.label17.TabIndex = 65;
            this.label17.Text = "NIC No";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 18);
            this.label15.TabIndex = 63;
            this.label15.Text = "Tel (Land) No";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(314, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 18);
            this.label13.TabIndex = 59;
            this.label13.Text = "Email";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "T Address";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TxtSer
            // 
            this.TxtSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSer.Location = new System.Drawing.Point(85, 51);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(1113, 22);
            this.TxtSer.TabIndex = 29;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 107);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Updated Details";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1208, 29);
            this.panel6.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(44, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1211, 201);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 50);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Registration Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1211, 395);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.cmdBrowse);
            this.groupBox6.Controls.Add(this.PicImg);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1043, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 377);
            this.groupBox6.TabIndex = 80;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Images";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.AliceBlue;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(113, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 16);
            this.label24.TabIndex = 16;
            this.label24.Text = "Photo";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.ForeColor = System.Drawing.Color.White;
            this.cmdBrowse.Location = new System.Drawing.Point(8, 264);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(151, 32);
            this.cmdBrowse.TabIndex = 20;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = false;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // PicImg
            // 
            this.PicImg.BackColor = System.Drawing.Color.AliceBlue;
            this.PicImg.Image = ((System.Drawing.Image)(resources.GetObject("PicImg.Image")));
            this.PicImg.Location = new System.Drawing.Point(8, 97);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(149, 154);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImg.TabIndex = 13;
            this.PicImg.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSal);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.comWrkDet);
            this.groupBox5.Controls.Add(this.txtWrkExp);
            this.groupBox5.Controls.Add(this.txtDes);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(685, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 211);
            this.groupBox5.TabIndex = 79;
            this.groupBox5.TabStop = false;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(148, 160);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(189, 22);
            this.txtSal.TabIndex = 19;
            this.txtSal.TextChanged += new System.EventHandler(this.txtSal_TextChanged);
            this.txtSal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSal_KeyDown);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(4, 160);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 18);
            this.label23.TabIndex = 78;
            this.label23.Text = "Basic Salary";
            // 
            // comWrkDet
            // 
            this.comWrkDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comWrkDet.FormattingEnabled = true;
            this.comWrkDet.Items.AddRange(new object[] {
            "Software Development",
            "Driver",
            "Cashier",
            "Pharmasist",
            "Data Entry Operator",
            "Harware Technicians",
            "Sales Rep"});
            this.comWrkDet.Location = new System.Drawing.Point(148, 115);
            this.comWrkDet.Name = "comWrkDet";
            this.comWrkDet.Size = new System.Drawing.Size(189, 24);
            this.comWrkDet.TabIndex = 18;
            this.comWrkDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comWrkDet_KeyDown);
            // 
            // txtWrkExp
            // 
            this.txtWrkExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrkExp.Location = new System.Drawing.Point(148, 33);
            this.txtWrkExp.Name = "txtWrkExp";
            this.txtWrkExp.Size = new System.Drawing.Size(189, 22);
            this.txtWrkExp.TabIndex = 16;
            this.txtWrkExp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWrkExp_KeyDown);
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(148, 73);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(189, 22);
            this.txtDes.TabIndex = 17;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Desgination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Work Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Work Experience";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comPro);
            this.groupBox3.Controls.Add(this.txtOL);
            this.groupBox3.Controls.Add(this.txtAL);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Location = new System.Drawing.Point(685, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 150);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Qualifications";
            // 
            // comPro
            // 
            this.comPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPro.FormattingEnabled = true;
            this.comPro.Items.AddRange(new object[] {
            "Diploma",
            "High National Diploma",
            "Degree",
            "Master Degree"});
            this.comPro.Location = new System.Drawing.Point(148, 116);
            this.comPro.Name = "comPro";
            this.comPro.Size = new System.Drawing.Size(189, 24);
            this.comPro.TabIndex = 15;
            this.comPro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comPro_KeyDown);
            // 
            // txtOL
            // 
            this.txtOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOL.Location = new System.Drawing.Point(148, 33);
            this.txtOL.Name = "txtOL";
            this.txtOL.Size = new System.Drawing.Size(189, 22);
            this.txtOL.TabIndex = 13;
            this.txtOL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOL_KeyDown);
            // 
            // txtAL
            // 
            this.txtAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAL.Location = new System.Drawing.Point(148, 74);
            this.txtAL.Name = "txtAL";
            this.txtAL.Size = new System.Drawing.Size(189, 22);
            this.txtAL.TabIndex = 14;
            this.txtAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAL_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(4, 76);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 18);
            this.label25.TabIndex = 65;
            this.label25.Text = "A/L Result";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(4, 116);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(123, 18);
            this.label27.TabIndex = 61;
            this.label27.Text = "Professional Qua";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(4, 33);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 18);
            this.label33.TabIndex = 48;
            this.label33.Text = "O/L Result";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGen);
            this.groupBox2.Controls.Add(this.dtpDOB);
            this.groupBox2.Controls.Add(this.comCat);
            this.groupBox2.Controls.Add(this.comNat);
            this.groupBox2.Controls.Add(this.dtpJDate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.comRel);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.comCSta);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtNIC);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtMOB);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtEMail);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTAddress);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.comStfID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 377);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info";
            // 
            // comCat
            // 
            this.comCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCat.FormattingEnabled = true;
            this.comCat.Items.AddRange(new object[] {
            "Permanent Staff",
            "Trainee Staff",
            "Visiting Staff",
            ""});
            this.comCat.Location = new System.Drawing.Point(432, 71);
            this.comCat.Name = "comCat";
            this.comCat.Size = new System.Drawing.Size(229, 24);
            this.comCat.TabIndex = 3;
            this.comCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comCat_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(314, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 53;
            this.label10.Text = "P Address";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Full Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFName.Location = new System.Drawing.Point(431, 30);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(230, 22);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            this.txtFName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFName_KeyDown);
            // 
            // comStfID
            // 
            this.comStfID.Enabled = false;
            this.comStfID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStfID.FormattingEnabled = true;
            this.comStfID.Location = new System.Drawing.Point(101, 30);
            this.comStfID.Name = "comStfID";
            this.comStfID.Size = new System.Drawing.Size(188, 24);
            this.comStfID.TabIndex = 0;
            this.comStfID.SelectedIndexChanged += new System.EventHandler(this.comEmpID_SelectedIndexChanged);
            this.comStfID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comStfID_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(102, 273);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(188, 22);
            this.txtAge.TabIndex = 53;
            this.txtAge.TextChanged += new System.EventHandler(this.txtSName_TextChanged);
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Staff Category";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmStaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1276, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmStaffRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comNat;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comRel;
        private System.Windows.Forms.DateTimePicker dtpJDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comCSta;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdRep;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.TextBox txtTAddress;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox txtMOB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ComboBox comStfID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAL;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comWrkDet;
        private System.Windows.Forms.TextBox txtWrkExp;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comPro;
        private System.Windows.Forms.TextBox txtOL;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.ComboBox comCat;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox dtpDOB;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Button txtClear;
    }
}

