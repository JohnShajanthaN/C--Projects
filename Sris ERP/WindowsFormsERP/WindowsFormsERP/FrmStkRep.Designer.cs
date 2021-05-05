namespace WindowsFormsERP
{
    partial class FrmStkRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStkRep));
            this.label1 = new System.Windows.Forms.Label();
            this.Pannel1 = new System.Windows.Forms.Panel();
            this.lbls = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtManu = new System.Windows.Forms.TextBox();
            this.chkManu = new System.Windows.Forms.CheckBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.chkMod = new System.Windows.Forms.CheckBox();
            this.txtKw = new System.Windows.Forms.TextBox();
            this.chkKw = new System.Windows.Forms.CheckBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.chkDes = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdPDFExit = new System.Windows.Forms.Button();
            this.CmdImage = new System.Windows.Forms.Button();
            this.CmdPDF = new System.Windows.Forms.Button();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataDataSet1 = new WindowsFormsERP.DataDataSet1();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new WindowsFormsERP.DataDataSet1TableAdapters.ItemTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pannel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pannel1
            // 
            this.Pannel1.BackColor = System.Drawing.Color.White;
            this.Pannel1.Controls.Add(this.lbls);
            this.Pannel1.Controls.Add(this.axAcroPDF1);
            this.Pannel1.Controls.Add(this.groupBox1);
            this.Pannel1.Controls.Add(this.dataGridView1);
            this.Pannel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pannel1.Location = new System.Drawing.Point(0, 62);
            this.Pannel1.Name = "Pannel1";
            this.Pannel1.Size = new System.Drawing.Size(1276, 687);
            this.Pannel1.TabIndex = 3;
            // 
            // lbls
            // 
            this.lbls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(1034, 636);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(46, 18);
            this.lbls.TabIndex = 37;
            this.lbls.Text = "Total";
            this.lbls.Visible = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(69, 115);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1142, 518);
            this.axAcroPDF1.TabIndex = 34;
            this.axAcroPDF1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.CmdPDFExit);
            this.groupBox1.Controls.Add(this.CmdImage);
            this.groupBox1.Controls.Add(this.CmdPDF);
            this.groupBox1.Controls.Add(this.TxtSer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(69, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 92);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtManu);
            this.panel1.Controls.Add(this.chkManu);
            this.panel1.Controls.Add(this.txtMod);
            this.panel1.Controls.Add(this.chkMod);
            this.panel1.Controls.Add(this.txtKw);
            this.panel1.Controls.Add(this.chkKw);
            this.panel1.Controls.Add(this.txtDes);
            this.panel1.Controls.Add(this.chkDes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 32);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // txtManu
            // 
            this.txtManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManu.Location = new System.Drawing.Point(966, 9);
            this.txtManu.Name = "txtManu";
            this.txtManu.Size = new System.Drawing.Size(136, 20);
            this.txtManu.TabIndex = 8;
            this.txtManu.TextChanged += new System.EventHandler(this.txtManu_TextChanged);
            // 
            // chkManu
            // 
            this.chkManu.AutoSize = true;
            this.chkManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManu.Location = new System.Drawing.Point(861, 9);
            this.chkManu.Name = "chkManu";
            this.chkManu.Size = new System.Drawing.Size(99, 19);
            this.chkManu.TabIndex = 7;
            this.chkManu.Text = "Manufacturer";
            this.chkManu.UseVisualStyleBackColor = true;
            this.chkManu.CheckedChanged += new System.EventHandler(this.chkManu_CheckedChanged);
            // 
            // txtMod
            // 
            this.txtMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMod.Location = new System.Drawing.Point(737, 9);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(107, 20);
            this.txtMod.TabIndex = 6;
            this.txtMod.TextChanged += new System.EventHandler(this.txtMod_TextChanged);
            // 
            // chkMod
            // 
            this.chkMod.AutoSize = true;
            this.chkMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMod.Location = new System.Drawing.Point(673, 9);
            this.chkMod.Name = "chkMod";
            this.chkMod.Size = new System.Drawing.Size(61, 19);
            this.chkMod.TabIndex = 5;
            this.chkMod.Text = "Model";
            this.chkMod.UseVisualStyleBackColor = true;
            this.chkMod.CheckedChanged += new System.EventHandler(this.chkMod_CheckedChanged);
            // 
            // txtKw
            // 
            this.txtKw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKw.Location = new System.Drawing.Point(522, 9);
            this.txtKw.Name = "txtKw";
            this.txtKw.Size = new System.Drawing.Size(130, 20);
            this.txtKw.TabIndex = 4;
            this.txtKw.TextChanged += new System.EventHandler(this.txtKw_TextChanged);
            // 
            // chkKw
            // 
            this.chkKw.AutoSize = true;
            this.chkKw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKw.Location = new System.Drawing.Point(449, 9);
            this.chkKw.Name = "chkKw";
            this.chkKw.Size = new System.Drawing.Size(73, 19);
            this.chkKw.TabIndex = 3;
            this.chkKw.Text = "Keyword";
            this.chkKw.UseVisualStyleBackColor = true;
            this.chkKw.CheckedChanged += new System.EventHandler(this.chkKw_CheckedChanged);
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(239, 9);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(187, 20);
            this.txtDes.TabIndex = 2;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            // 
            // chkDes
            // 
            this.chkDes.AutoSize = true;
            this.chkDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDes.Location = new System.Drawing.Point(147, 9);
            this.chkDes.Name = "chkDes";
            this.chkDes.Size = new System.Drawing.Size(88, 19);
            this.chkDes.TabIndex = 1;
            this.chkDes.Text = "Description";
            this.chkDes.UseVisualStyleBackColor = true;
            this.chkDes.CheckedChanged += new System.EventHandler(this.chkDes_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Multi Search";
            // 
            // CmdPDFExit
            // 
            this.CmdPDFExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdPDFExit.BackColor = System.Drawing.Color.Gainsboro;
            this.CmdPDFExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdPDFExit.Location = new System.Drawing.Point(1026, 54);
            this.CmdPDFExit.Name = "CmdPDFExit";
            this.CmdPDFExit.Size = new System.Drawing.Size(100, 24);
            this.CmdPDFExit.TabIndex = 35;
            this.CmdPDFExit.Text = "PDF &Close";
            this.toolTip1.SetToolTip(this.CmdPDFExit, "To Close This PDF Documnt and Show Search List.");
            this.CmdPDFExit.UseVisualStyleBackColor = true;
            this.CmdPDFExit.Click += new System.EventHandler(this.CmdPDFExit_Click);
            // 
            // CmdImage
            // 
            this.CmdImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdImage.Location = new System.Drawing.Point(794, 54);
            this.CmdImage.Name = "CmdImage";
            this.CmdImage.Size = new System.Drawing.Size(108, 24);
            this.CmdImage.TabIndex = 36;
            this.CmdImage.Text = "&Image Search";
            this.toolTip1.SetToolTip(this.CmdImage, "To Export Print or Save in PDF Format.");
            this.CmdImage.UseVisualStyleBackColor = true;
            this.CmdImage.Click += new System.EventHandler(this.CmdImage_Click);
            // 
            // CmdPDF
            // 
            this.CmdPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdPDF.Location = new System.Drawing.Point(911, 54);
            this.CmdPDF.Name = "CmdPDF";
            this.CmdPDF.Size = new System.Drawing.Size(106, 24);
            this.CmdPDF.TabIndex = 9;
            this.CmdPDF.Text = "PDF &Report";
            this.toolTip1.SetToolTip(this.CmdPDF, "To Export Print or Save in PDF Format.");
            this.CmdPDF.UseVisualStyleBackColor = true;
            this.CmdPDF.Click += new System.EventHandler(this.CmdPDF_Click);
            // 
            // TxtSer
            // 
            this.TxtSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSer.Location = new System.Drawing.Point(164, 54);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(603, 22);
            this.TxtSer.TabIndex = 0;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
            this.TxtSer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSer_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "All in One Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 518);
            this.dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "User Level  :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "User ID       :";
            this.label3.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(136, 48);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 36;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(136, 21);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 35;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dataDataSet1;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(945, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 90;
            this.label7.Text = "Grid Heading Font";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(802, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 89;
            this.label6.Text = "Grid Font";
            this.label6.Visible = false;
            // 
            // FrmStkRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pannel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStkRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStkRep_Load);
            this.Pannel1.ResumeLayout(false);
            this.Pannel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pannel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.TextBox txtKw;
        private System.Windows.Forms.CheckBox chkKw;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.CheckBox chkDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManu;
        private System.Windows.Forms.CheckBox chkManu;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.CheckBox chkMod;
        private System.Windows.Forms.Button CmdPDF;
        private System.Windows.Forms.ToolTip toolTip1;
        private DataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataDataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button CmdPDFExit;
        private System.Windows.Forms.Button CmdImage;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}