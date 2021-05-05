namespace WindowsFormsERP
{
    partial class FrmBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBank));
            this.txtBaName = new System.Windows.Forms.TextBox();
            this.txtBaCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrName = new System.Windows.Forms.TextBox();
            this.txtBrCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaName
            // 
            this.txtBaName.Location = new System.Drawing.Point(150, 79);
            this.txtBaName.MaxLength = 40;
            this.txtBaName.Name = "txtBaName";
            this.txtBaName.Size = new System.Drawing.Size(264, 20);
            this.txtBaName.TabIndex = 1;
            this.txtBaName.TextChanged += new System.EventHandler(this.txtBaName_TextChanged);
            this.txtBaName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBaName_KeyDown);
            // 
            // txtBaCode
            // 
            this.txtBaCode.Location = new System.Drawing.Point(150, 44);
            this.txtBaCode.MaxLength = 4;
            this.txtBaCode.Name = "txtBaCode";
            this.txtBaCode.Size = new System.Drawing.Size(264, 20);
            this.txtBaCode.TabIndex = 0;
            this.txtBaCode.TextChanged += new System.EventHandler(this.txtBaCode_TextChanged);
            this.txtBaCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBaCode_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Bank Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmdExit);
            this.groupBox3.Controls.Add(this.txtAccNo);
            this.groupBox3.Controls.Add(this.CmdDelete);
            this.groupBox3.Controls.Add(this.CmdUpdate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CmdSave);
            this.groupBox3.Controls.Add(this.txtBrName);
            this.groupBox3.Controls.Add(this.txtBrCode);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBaName);
            this.groupBox3.Controls.Add(this.txtBaCode);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(30, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 289);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(151, 188);
            this.txtAccNo.MaxLength = 20;
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(264, 20);
            this.txtAccNo.TabIndex = 4;
            this.txtAccNo.TextChanged += new System.EventHandler(this.txtAccNo_TextChanged);
            this.txtAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Account No";
            // 
            // txtBrName
            // 
            this.txtBrName.Location = new System.Drawing.Point(150, 150);
            this.txtBrName.MaxLength = 50;
            this.txtBrName.Name = "txtBrName";
            this.txtBrName.Size = new System.Drawing.Size(264, 20);
            this.txtBrName.TabIndex = 3;
            this.txtBrName.TextChanged += new System.EventHandler(this.txtBrName_TextChanged);
            this.txtBrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrName_KeyDown);
            // 
            // txtBrCode
            // 
            this.txtBrCode.Location = new System.Drawing.Point(150, 115);
            this.txtBrCode.MaxLength = 3;
            this.txtBrCode.Name = "txtBrCode";
            this.txtBrCode.Size = new System.Drawing.Size(265, 20);
            this.txtBrCode.TabIndex = 2;
            this.txtBrCode.TextChanged += new System.EventHandler(this.txtBrCode_TextChanged);
            this.txtBrCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Branch Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Branch Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Bank Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(-25, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 564);
            this.panel1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(29, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 200);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(506, 29);
            this.panel6.TabIndex = 18;
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
            this.TxtSer.Location = new System.Drawing.Point(57, 49);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(452, 20);
            this.TxtSer.TabIndex = 9;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "SEARCH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(508, 112);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(345, 233);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(103, 31);
            this.CmdExit.TabIndex = 8;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(242, 233);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(102, 31);
            this.CmdDelete.TabIndex = 7;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(140, 233);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(101, 31);
            this.CmdUpdate.TabIndex = 6;
            this.CmdUpdate.Text = "&Update";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(39, 233);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(100, 31);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bank Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "User Level  :";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "User ID       :";
            this.label7.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(390, 36);
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
            this.lblUser1.Location = new System.Drawing.Point(390, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 47;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // FrmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(528, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Registration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaName;
        private System.Windows.Forms.TextBox txtBaCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox txtBrName;
        private System.Windows.Forms.TextBox txtBrCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label lblUser1;
    }
}