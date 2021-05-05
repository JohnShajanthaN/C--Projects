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
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void comRegID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(comRegID.Text=="")
                {
                    MessageBox.Show("Enter The Value", "Sample Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    txtPay.Focus();
                }
            }
        }

        private void txtPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPay.Text == "")
                {
                    MessageBox.Show("Enter The Value", "Sample Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    dtpPayDate.Focus();
                }
            }

        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPay.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only numbers!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPay.Text = txtPay.Text.Remove(txtPay.Text.Length - 1);
            }
        }
    }
}
