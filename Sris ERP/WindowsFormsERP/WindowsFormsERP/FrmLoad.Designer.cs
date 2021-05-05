namespace WindowsFormsERP
{
    partial class FrmLoad
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPWHint = new System.Windows.Forms.Label();
            this.lblULevel = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPWHint
            // 
            this.lblPWHint.AutoSize = true;
            this.lblPWHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPWHint.Location = new System.Drawing.Point(295, 138);
            this.lblPWHint.Name = "lblPWHint";
            this.lblPWHint.Size = new System.Drawing.Size(41, 13);
            this.lblPWHint.TabIndex = 13;
            this.lblPWHint.Text = "pw-hint";
            this.lblPWHint.Visible = false;
            // 
            // lblULevel
            // 
            this.lblULevel.AutoSize = true;
            this.lblULevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblULevel.Location = new System.Drawing.Point(233, 139);
            this.lblULevel.Name = "lblULevel";
            this.lblULevel.Size = new System.Drawing.Size(52, 13);
            this.lblULevel.TabIndex = 12;
            this.lblULevel.Text = "user level";
            this.lblULevel.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(232, 123);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(27, 13);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "user";
            this.lblUser.Visible = false;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPW.Location = new System.Drawing.Point(232, 107);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(21, 13);
            this.lblPW.TabIndex = 10;
            this.lblPW.Text = "pw";
            this.lblPW.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(232, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblColor.Location = new System.Drawing.Point(295, 107);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 13);
            this.lblColor.TabIndex = 44;
            this.lblColor.Text = "-16776961";
            this.lblColor.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsERP.Properties.Resources._116997991;
            this.pictureBox1.Location = new System.Drawing.Point(236, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblPWHint);
            this.panel1.Controls.Add(this.lblULevel);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblPW);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 280);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 47);
            this.panel2.TabIndex = 46;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "ERP System";
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(520, 280);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLoad";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoad";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPWHint;
        private System.Windows.Forms.Label lblULevel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}