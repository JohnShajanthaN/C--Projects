namespace WindowsFormsERP
{
    partial class FrmAPInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAPInv));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDoDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDuDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPoDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCur = new System.Windows.Forms.TextBox();
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
            this.txtINo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Name = "panel1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.dtpDoDate);
            this.groupBox1.Controls.Add(this.dtpDuDate);
            this.groupBox1.Controls.Add(this.dtpPoDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCur);
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
            this.groupBox1.Controls.Add(this.txtINo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInvNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpDoDate
            // 
            resources.ApplyResources(this.dtpDoDate, "dtpDoDate");
            this.dtpDoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoDate.Name = "dtpDoDate";
            // 
            // dtpDuDate
            // 
            resources.ApplyResources(this.dtpDuDate, "dtpDuDate");
            this.dtpDuDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuDate.Name = "dtpDuDate";
            this.dtpDuDate.ValueChanged += new System.EventHandler(this.dtpDuDate_ValueChanged);
            // 
            // dtpPoDate
            // 
            resources.ApplyResources(this.dtpPoDate, "dtpPoDate");
            this.dtpPoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPoDate.Name = "dtpPoDate";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtCur
            // 
            resources.ApplyResources(this.txtCur, "txtCur");
            this.txtCur.Name = "txtCur";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // txtTot
            // 
            resources.ApplyResources(this.txtTot, "txtTot");
            this.txtTot.Name = "txtTot";
            this.txtTot.TextChanged += new System.EventHandler(this.txtTot_TextChanged);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // txtVS
            // 
            resources.ApplyResources(this.txtVS, "txtVS");
            this.txtVS.Name = "txtVS";
            this.txtVS.TextChanged += new System.EventHandler(this.txtVS_TextChanged);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // txtNBT
            // 
            resources.ApplyResources(this.txtNBT, "txtNBT");
            this.txtNBT.Name = "txtNBT";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // txtTotBT
            // 
            resources.ApplyResources(this.txtTotBT, "txtTotBT");
            this.txtTotBT.Name = "txtTotBT";
            // 
            // txtSta
            // 
            resources.ApplyResources(this.txtSta, "txtSta");
            this.txtSta.Name = "txtSta";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtINo
            // 
            resources.ApplyResources(this.txtINo, "txtINo");
            this.txtINo.Name = "txtINo";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Name = "panel5";
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // CmdExit
            // 
            this.CmdExit.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.CmdExit, "CmdExit");
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.CmdUpdate, "CmdUpdate");
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.UseVisualStyleBackColor = false;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtRem
            // 
            resources.ApplyResources(this.txtRem, "txtRem");
            this.txtRem.Name = "txtRem";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtInvNo
            // 
            resources.ApplyResources(this.txtInvNo, "txtInvNo");
            this.txtInvNo.Name = "txtInvNo";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtVen
            // 
            resources.ApplyResources(this.txtVen, "txtVen");
            this.txtVen.Name = "txtVen";
            this.txtVen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVen_KeyDown);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // lblULevel1
            // 
            resources.ApplyResources(this.lblULevel1, "lblULevel1");
            this.lblULevel1.Name = "lblULevel1";
            // 
            // lblUser1
            // 
            resources.ApplyResources(this.lblUser1, "lblUser1");
            this.lblUser1.Name = "lblUser1";
            // 
            // FrmAPInv
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAPInv";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmAPInv_Activated);
            this.Load += new System.EventHandler(this.FrmAPInv_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FrmAPInv_ClientSizeChanged);
            this.Click += new System.EventHandler(this.FrmAPInv_Click);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.TextBox txtINo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCur;
        private System.Windows.Forms.DateTimePicker dtpDoDate;
        private System.Windows.Forms.DateTimePicker dtpDuDate;
        private System.Windows.Forms.DateTimePicker dtpPoDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label lblUser1;
    }
}