using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewmas_Job_Bank
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmStuReg StuReg = new FrmStuReg();
            StuReg.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPayment Payment = new FrmPayment();
            Payment.Show();
        }

        private void jobBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void basicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStaffRegistration FRegistration = new FrmStaffRegistration();
            FRegistration.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmJobSeekReg Job = new FrmJobSeekReg();
            Job.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJobSekPay JSP = new FrmJobSekPay();
            JSP.Show();
        }

        private void staffsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previousWorkExperenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStfSal StfSal = new FrmStfSal();
            StfSal.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobDetails JD = new FrmJobDetails();
            JD.Show();
        }
    }
}
