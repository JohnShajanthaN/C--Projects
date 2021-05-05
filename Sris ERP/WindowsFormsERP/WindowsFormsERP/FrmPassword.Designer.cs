namespace WindowsFormsERP
{
    partial class FrmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOldPW = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.ComboBox();
            this.txtConPW = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPHint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdPicSave = new System.Windows.Forms.Button();
            this.cmdColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBrowser = new System.Windows.Forms.Button();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.lblOPW = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(116, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Reset User Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "User Level  :";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "User ID       :";
            this.label7.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(581, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 53;
            this.lblUser1.Text = "User ID";
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(581, 36);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 54;
            this.lblULevel1.Text = "User Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Old Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNewPW
            // 
            this.txtNewPW.Location = new System.Drawing.Point(109, 117);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.Size = new System.Drawing.Size(267, 20);
            this.txtNewPW.TabIndex = 3;
            this.txtNewPW.UseSystemPasswordChar = true;
            this.txtNewPW.Click += new System.EventHandler(this.txtNewPW_Click);
            this.txtNewPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPW_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "New Password";
            // 
            // txtOldPW
            // 
            this.txtOldPW.BackColor = System.Drawing.SystemColors.Window;
            this.txtOldPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPW.Location = new System.Drawing.Point(109, 72);
            this.txtOldPW.Name = "txtOldPW";
            this.txtOldPW.Size = new System.Drawing.Size(267, 20);
            this.txtOldPW.TabIndex = 2;
            this.txtOldPW.UseSystemPasswordChar = true;
            this.txtOldPW.Click += new System.EventHandler(this.txtOldPW_Click);
            this.txtOldPW.TextChanged += new System.EventHandler(this.txtOldPW_TextChanged);
            this.txtOldPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOldPW_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Location = new System.Drawing.Point(38, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 363);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password Change";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.txtConPW);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtPHint);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNewPW);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtOldPW);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(22, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 257);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUserName.FormattingEnabled = true;
            this.txtUserName.Location = new System.Drawing.Point(109, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(267, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.SelectedIndexChanged += new System.EventHandler(this.txtUserName_SelectedIndexChanged);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtConPW
            // 
            this.txtConPW.Location = new System.Drawing.Point(109, 164);
            this.txtConPW.Name = "txtConPW";
            this.txtConPW.Size = new System.Drawing.Size(267, 20);
            this.txtConPW.TabIndex = 4;
            this.txtConPW.UseSystemPasswordChar = true;
            this.txtConPW.Click += new System.EventHandler(this.txtConPW_Click);
            this.txtConPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConPW_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Confirm Password";
            // 
            // txtPHint
            // 
            this.txtPHint.Location = new System.Drawing.Point(109, 208);
            this.txtPHint.Name = "txtPHint";
            this.txtPHint.Size = new System.Drawing.Size(267, 20);
            this.txtPHint.TabIndex = 5;
            this.txtPHint.Click += new System.EventHandler(this.txtPHint_Click);
            this.txtPHint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPHint_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Password Hint";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "User Name";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdSave);
            this.panel5.Location = new System.Drawing.Point(22, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 43);
            this.panel5.TabIndex = 49;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(135, 5);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(115, 31);
            this.CmdExit.TabIndex = 8;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click_1);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(6, 5);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(113, 31);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(-25, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 388);
            this.panel1.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(485, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 364);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Modify";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdPicSave);
            this.panel2.Controls.Add(this.cmdColor);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(28, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 43);
            this.panel2.TabIndex = 48;
            // 
            // cmdPicSave
            // 
            this.cmdPicSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPicSave.Location = new System.Drawing.Point(122, 5);
            this.cmdPicSave.Name = "cmdPicSave";
            this.cmdPicSave.Size = new System.Drawing.Size(113, 31);
            this.cmdPicSave.TabIndex = 39;
            this.cmdPicSave.Text = "S&ave";
            this.cmdPicSave.UseVisualStyleBackColor = true;
            this.cmdPicSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdColor
            // 
            this.cmdColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdColor.Location = new System.Drawing.Point(6, 5);
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(113, 31);
            this.cmdColor.TabIndex = 38;
            this.cmdColor.Text = "&Back Colour";
            this.cmdColor.UseVisualStyleBackColor = true;
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdBrowser);
            this.groupBox2.Controls.Add(this.PicImg);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Photo ";
            // 
            // cmdBrowser
            // 
            this.cmdBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowser.Location = new System.Drawing.Point(19, 225);
            this.cmdBrowser.Name = "cmdBrowser";
            this.cmdBrowser.Size = new System.Drawing.Size(198, 28);
            this.cmdBrowser.TabIndex = 12;
            this.cmdBrowser.Text = "Browse";
            this.cmdBrowser.UseVisualStyleBackColor = true;
            this.cmdBrowser.Click += new System.EventHandler(this.cmdBrowser_Click);
            // 
            // PicImg
            // 
            this.PicImg.BackColor = System.Drawing.Color.Gainsboro;
            this.PicImg.Image = ((System.Drawing.Image)(resources.GetObject("PicImg.Image")));
            this.PicImg.Location = new System.Drawing.Point(19, 23);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(198, 194);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImg.TabIndex = 3;
            this.PicImg.TabStop = false;
            // 
            // lblOPW
            // 
            this.lblOPW.AutoSize = true;
            this.lblOPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPW.Location = new System.Drawing.Point(18, 12);
            this.lblOPW.Name = "lblOPW";
            this.lblOPW.Size = new System.Drawing.Size(92, 16);
            this.lblOPW.TabIndex = 57;
            this.lblOPW.Text = "Old Password";
            this.lblOPW.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblID.Location = new System.Drawing.Point(678, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 58;
            this.lblID.Text = "ID";
            // 
            // txtCol
            // 
            this.txtCol.Enabled = false;
            this.txtCol.Location = new System.Drawing.Point(661, 29);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(58, 20);
            this.txtCol.TabIndex = 59;
            this.txtCol.Text = ".";
            this.txtCol.Visible = false;
            // 
            // FrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(460, 441);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblOPW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset User Password";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPassword_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOldPW;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPHint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConPW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOPW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdBrowser;
        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdPicSave;
        private System.Windows.Forms.Button cmdColor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txtUserName;
    }
}