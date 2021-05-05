using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsERP
{
    public partial class FrmLoad : Form
    {
        int i = 0;
        public FrmLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 70)
            {
                FrmMain FMain = new FrmMain();
               // FMain.Text = "ERP System - User : " + lblUser.Text;
                FMain.Text = "ERP System";

                Control[] ctrlsID = FMain.Controls.Find("lblUser", false);
                Label lbl1 = (Label)ctrlsID[0];
                lbl1.Text = lblUser.Text;

                Control[] ctrlsUL = FMain.Controls.Find("lblULevel", false);
                Label lbl2 = (Label)ctrlsUL[0];
                lbl2.Text = lblULevel.Text;

                Control[] ctrlsIDD = FMain.Controls.Find("lblID", false);
                Label lbl3 = (Label)ctrlsIDD[0];
                lbl3.Text = lblID.Text;

                Control[] ctrlsPW = FMain.Controls.Find("lblPW", false);
                Label lbl4 = (Label)ctrlsPW[0];
                lbl4.Text = lblPW.Text;

                Control[] ctrlsPWh = FMain.Controls.Find("lblPWHint", false);
                Label lbl5 = (Label)ctrlsPWh[0];
                lbl5.Text = lblPWHint.Text;

                Control[] ctrlsClr = FMain.Controls.Find("lblColor", false);
                Label lbl6 = (Label)ctrlsClr[0];
                lbl6.Text = lblColor.Text;

                FMain.Show();
                timer1.Enabled = false;
                this.Visible = false;
            }
            else
            {
                i = i + 1;
            }
        }
    }
}
