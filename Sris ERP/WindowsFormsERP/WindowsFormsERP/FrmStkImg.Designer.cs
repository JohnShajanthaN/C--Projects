namespace WindowsFormsERP
{
    partial class FrmStkImg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStkImg));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.CmdSer = new System.Windows.Forms.Button();
            this.txtManu = new System.Windows.Forms.TextBox();
            this.chkManu = new System.Windows.Forms.CheckBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.chkMod = new System.Windows.Forms.CheckBox();
            this.txtKw = new System.Windows.Forms.TextBox();
            this.chkKw = new System.Windows.Forms.CheckBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.chkDes = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stock Image View";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 692);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtSer);
            this.groupBox1.Controls.Add(this.CmdSer);
            this.groupBox1.Controls.Add(this.txtManu);
            this.groupBox1.Controls.Add(this.chkManu);
            this.groupBox1.Controls.Add(this.txtMod);
            this.groupBox1.Controls.Add(this.chkMod);
            this.groupBox1.Controls.Add(this.txtKw);
            this.groupBox1.Controls.Add(this.chkKw);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.chkDes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(65, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 92);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // TxtSer
            // 
            this.TxtSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSer.Location = new System.Drawing.Point(164, 55);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(805, 22);
            this.TxtSer.TabIndex = 0;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged_1);
            // 
            // CmdSer
            // 
            this.CmdSer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSer.Location = new System.Drawing.Point(983, 55);
            this.CmdSer.Name = "CmdSer";
            this.CmdSer.Size = new System.Drawing.Size(136, 24);
            this.CmdSer.TabIndex = 9;
            this.CmdSer.Text = "Normal Search";
            this.CmdSer.UseVisualStyleBackColor = true;
            this.CmdSer.Click += new System.EventHandler(this.CmdSer_Click);
            // 
            // txtManu
            // 
            this.txtManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManu.Location = new System.Drawing.Point(983, 25);
            this.txtManu.Name = "txtManu";
            this.txtManu.Size = new System.Drawing.Size(136, 20);
            this.txtManu.TabIndex = 8;
            this.txtManu.Visible = false;
            // 
            // chkManu
            // 
            this.chkManu.AutoSize = true;
            this.chkManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManu.Location = new System.Drawing.Point(878, 25);
            this.chkManu.Name = "chkManu";
            this.chkManu.Size = new System.Drawing.Size(99, 19);
            this.chkManu.TabIndex = 7;
            this.chkManu.Text = "Manufacturer";
            this.chkManu.UseVisualStyleBackColor = true;
            this.chkManu.Visible = false;
            // 
            // txtMod
            // 
            this.txtMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMod.Location = new System.Drawing.Point(754, 25);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(107, 20);
            this.txtMod.TabIndex = 6;
            this.txtMod.Visible = false;
            // 
            // chkMod
            // 
            this.chkMod.AutoSize = true;
            this.chkMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMod.Location = new System.Drawing.Point(690, 25);
            this.chkMod.Name = "chkMod";
            this.chkMod.Size = new System.Drawing.Size(61, 19);
            this.chkMod.TabIndex = 5;
            this.chkMod.Text = "Model";
            this.chkMod.UseVisualStyleBackColor = true;
            this.chkMod.Visible = false;
            // 
            // txtKw
            // 
            this.txtKw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKw.Location = new System.Drawing.Point(539, 25);
            this.txtKw.Name = "txtKw";
            this.txtKw.Size = new System.Drawing.Size(130, 20);
            this.txtKw.TabIndex = 4;
            this.txtKw.Visible = false;
            // 
            // chkKw
            // 
            this.chkKw.AutoSize = true;
            this.chkKw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKw.Location = new System.Drawing.Point(466, 25);
            this.chkKw.Name = "chkKw";
            this.chkKw.Size = new System.Drawing.Size(73, 19);
            this.chkKw.TabIndex = 3;
            this.chkKw.Text = "Keyword";
            this.chkKw.UseVisualStyleBackColor = true;
            this.chkKw.Visible = false;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(256, 25);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(187, 20);
            this.txtDes.TabIndex = 2;
            this.txtDes.Visible = false;
            // 
            // chkDes
            // 
            this.chkDes.AutoSize = true;
            this.chkDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDes.Location = new System.Drawing.Point(164, 25);
            this.chkDes.Name = "chkDes";
            this.chkDes.Size = new System.Drawing.Size(88, 19);
            this.chkDes.TabIndex = 1;
            this.chkDes.Text = "Description";
            this.chkDes.UseVisualStyleBackColor = true;
            this.chkDes.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Multi Search";
            this.label5.Visible = false;
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 200;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 500);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmStkImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStkImg";
            this.Text = "Stock Image View";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStkImg_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdSer;
        private System.Windows.Forms.TextBox txtManu;
        private System.Windows.Forms.CheckBox chkManu;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.CheckBox chkMod;
        private System.Windows.Forms.TextBox txtKw;
        private System.Windows.Forms.CheckBox chkKw;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.CheckBox chkDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label4;
    }
}