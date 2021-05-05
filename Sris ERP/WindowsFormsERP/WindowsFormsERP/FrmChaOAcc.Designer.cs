namespace WindowsFormsERP
{
    partial class FrmChaOAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChaOAcc));
            this.label1 = new System.Windows.Forms.Label();
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
            this.CmdReport = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comAsof = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comSAcc = new System.Windows.Forms.ComboBox();
            this.chkSAccs = new System.Windows.Forms.CheckBox();
            this.comAType = new System.Windows.Forms.ComboBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(129, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chart of Account Creation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-18, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 513);
            this.panel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(22, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 195);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 29);
            this.panel6.TabIndex = 18;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Updated Details";
            // 
            // TxtSer
            // 
            this.TxtSer.Location = new System.Drawing.Point(73, 49);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(437, 20);
            this.TxtSer.TabIndex = 11;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 112);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdDelete);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Controls.Add(this.CmdReport);
            this.panel5.Controls.Add(this.CmdSave);
            this.panel5.Location = new System.Drawing.Point(24, 261);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 37);
            this.panel5.TabIndex = 20;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(425, 2);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(105, 31);
            this.CmdExit.TabIndex = 10;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(213, 2);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(105, 31);
            this.CmdDelete.TabIndex = 8;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(107, 2);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(105, 31);
            this.CmdUpdate.TabIndex = 7;
            this.CmdUpdate.Text = "&Edit";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdReport
            // 
            this.CmdReport.Location = new System.Drawing.Point(319, 2);
            this.CmdReport.Name = "CmdReport";
            this.CmdReport.Size = new System.Drawing.Size(105, 31);
            this.CmdReport.TabIndex = 9;
            this.CmdReport.Text = "&Report";
            this.CmdReport.UseVisualStyleBackColor = true;
            this.CmdReport.Click += new System.EventHandler(this.CmdReport_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(1, 2);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(105, 31);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "&Add";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comAsof);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comSAcc);
            this.groupBox2.Controls.Add(this.chkSAccs);
            this.groupBox2.Controls.Add(this.comAType);
            this.groupBox2.Controls.Add(this.txtBal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(23, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 251);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // comAsof
            // 
            this.comAsof.FormattingEnabled = true;
            this.comAsof.Location = new System.Drawing.Point(113, 202);
            this.comAsof.Name = "comAsof";
            this.comAsof.Size = new System.Drawing.Size(373, 21);
            this.comAsof.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "as of";
            // 
            // comSAcc
            // 
            this.comSAcc.FormattingEnabled = true;
            this.comSAcc.Location = new System.Drawing.Point(113, 136);
            this.comSAcc.Name = "comSAcc";
            this.comSAcc.Size = new System.Drawing.Size(373, 21);
            this.comSAcc.TabIndex = 3;
            // 
            // chkSAccs
            // 
            this.chkSAccs.AutoSize = true;
            this.chkSAccs.Location = new System.Drawing.Point(114, 115);
            this.chkSAccs.Name = "chkSAccs";
            this.chkSAccs.Size = new System.Drawing.Size(100, 17);
            this.chkSAccs.TabIndex = 2;
            this.chkSAccs.Text = "Sub Account of";
            this.chkSAccs.UseVisualStyleBackColor = true;
            // 
            // comAType
            // 
            this.comAType.FormattingEnabled = true;
            this.comAType.Location = new System.Drawing.Point(113, 44);
            this.comAType.Name = "comAType";
            this.comAType.Size = new System.Drawing.Size(373, 21);
            this.comAType.TabIndex = 0;
            this.comAType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comAType_KeyDown);
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(114, 169);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(371, 20);
            this.txtBal.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Balance";
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(113, 76);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(372, 20);
            this.txtAName.TabIndex = 1;
            this.txtAName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAName_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Account Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "User Level  :";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "User ID       :";
            this.label5.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(511, 36);
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
            this.lblUser1.Location = new System.Drawing.Point(511, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 47;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // FrmChaOAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(545, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmChaOAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart of Account Creation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmChaOAcc_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button CmdReport;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comAType;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comAsof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comSAcc;
        private System.Windows.Forms.CheckBox chkSAccs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label lblUser1;
    }
}