namespace HRProject
{
    partial class FrmQualification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQualification));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtARemark = new System.Windows.Forms.TextBox();
            this.comHQ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPRemark = new System.Windows.Forms.TextBox();
            this.comQT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdRep = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comEmpID = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtARemark);
            this.groupBox1.Controls.Add(this.comHQ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Academic";
            // 
            // txtARemark
            // 
            this.txtARemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtARemark.Location = new System.Drawing.Point(231, 63);
            this.txtARemark.Multiline = true;
            this.txtARemark.Name = "txtARemark";
            this.txtARemark.Size = new System.Drawing.Size(518, 68);
            this.txtARemark.TabIndex = 3;
            this.txtARemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtARemark_KeyDown);
            // 
            // comHQ
            // 
            this.comHQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comHQ.FormattingEnabled = true;
            this.comHQ.Location = new System.Drawing.Point(231, 26);
            this.comHQ.Name = "comHQ";
            this.comHQ.Size = new System.Drawing.Size(518, 26);
            this.comHQ.TabIndex = 2;
            this.comHQ.SelectedIndexChanged += new System.EventHandler(this.comHQ_SelectedIndexChanged);
            this.comHQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comHQ_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Any other relevant information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Higher Qualification";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPRemark);
            this.groupBox2.Controls.Add(this.comQT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professional";
            // 
            // txtPRemark
            // 
            this.txtPRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRemark.Location = new System.Drawing.Point(231, 61);
            this.txtPRemark.Multiline = true;
            this.txtPRemark.Name = "txtPRemark";
            this.txtPRemark.Size = new System.Drawing.Size(518, 65);
            this.txtPRemark.TabIndex = 5;
            this.txtPRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPRemark_KeyDown);
            // 
            // comQT
            // 
            this.comQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comQT.FormattingEnabled = true;
            this.comQT.Location = new System.Drawing.Point(231, 24);
            this.comQT.Name = "comQT";
            this.comQT.Size = new System.Drawing.Size(518, 26);
            this.comQT.TabIndex = 4;
            this.comQT.SelectedIndexChanged += new System.EventHandler(this.comQT_SelectedIndexChanged);
            this.comQT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comQT_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Any other relevant information";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Qualification  && Training";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 50);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qualifications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(44, 477);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(765, 196);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(3, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(762, 29);
            this.panel6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Updated Details";
            // 
            // TxtSer
            // 
            this.TxtSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSer.Location = new System.Drawing.Point(85, 51);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(664, 22);
            this.TxtSer.TabIndex = 11;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 103);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdExit);
            this.panel2.Controls.Add(this.cmdRep);
            this.panel2.Controls.Add(this.cmdDel);
            this.panel2.Controls.Add(this.cmdEdit);
            this.panel2.Controls.Add(this.cmdAdd);
            this.panel2.Location = new System.Drawing.Point(44, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 45);
            this.panel2.TabIndex = 3;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.White;
            this.cmdExit.Location = new System.Drawing.Point(614, 3);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(145, 37);
            this.cmdExit.TabIndex = 10;
            this.cmdExit.Text = "&EXIT";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdRep
            // 
            this.cmdRep.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRep.ForeColor = System.Drawing.Color.White;
            this.cmdRep.Location = new System.Drawing.Point(460, 3);
            this.cmdRep.Name = "cmdRep";
            this.cmdRep.Size = new System.Drawing.Size(150, 37);
            this.cmdRep.TabIndex = 9;
            this.cmdRep.Text = "&REPORT";
            this.cmdRep.UseVisualStyleBackColor = false;
            this.cmdRep.Click += new System.EventHandler(this.cmdRep_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDel.ForeColor = System.Drawing.Color.White;
            this.cmdDel.Location = new System.Drawing.Point(306, 3);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(150, 37);
            this.cmdDel.TabIndex = 8;
            this.cmdDel.Text = "&DELETE";
            this.cmdDel.UseVisualStyleBackColor = false;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.ForeColor = System.Drawing.Color.White;
            this.cmdEdit.Location = new System.Drawing.Point(153, 3);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(150, 37);
            this.cmdEdit.TabIndex = 7;
            this.cmdEdit.Text = "&EDIT";
            this.cmdEdit.UseVisualStyleBackColor = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.Color.White;
            this.cmdAdd.Location = new System.Drawing.Point(4, 3);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(145, 37);
            this.cmdAdd.TabIndex = 6;
            this.cmdAdd.Text = "&ADD";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmpID";
            // 
            // comEmpID
            // 
            this.comEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comEmpID.FormattingEnabled = true;
            this.comEmpID.Location = new System.Drawing.Point(89, 13);
            this.comEmpID.Name = "comEmpID";
            this.comEmpID.Size = new System.Drawing.Size(114, 26);
            this.comEmpID.TabIndex = 0;
            this.comEmpID.SelectedIndexChanged += new System.EventHandler(this.comEmpID_SelectedIndexChanged);
            this.comEmpID.TextChanged += new System.EventHandler(this.comEmpID_TextChanged);
            this.comEmpID.Click += new System.EventHandler(this.comEmpID_Click);
            this.comEmpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comEmpID_KeyDown);
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(237, 14);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(518, 26);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpName_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtEmpName);
            this.groupBox3.Controls.Add(this.comEmpID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(44, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 369);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // FrmQualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(855, 684);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQualification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qualifications";
            this.Load += new System.EventHandler(this.FrmQualification_Load);
            this.Click += new System.EventHandler(this.FrmQualification_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtARemark;
        private System.Windows.Forms.ComboBox comHQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPRemark;
        private System.Windows.Forms.ComboBox comQT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdRep;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}