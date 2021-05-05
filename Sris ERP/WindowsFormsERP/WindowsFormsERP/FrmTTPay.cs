using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsERP
{
    public partial class FrmTTPay : Form
    {
        public static string uname = "";
        public static string ul = "";
        // int count = 0;
        // int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtBankAcNo.Text = "";
            txtAmount.Text = "0.00";
            txtBankCharges.Text = "0.00";
            txtExchangeRate.Text = "0.00";
            txtTotalAmount.Text = "0.00";
            comBankName.Text = "";
            comCurrency.Text = "";
            comGLAccount.Text = "";
            txtBankAcNo.Text = "";
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from Bank ";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                da5.Fill(dt5);
                comBankName.Items.Clear();
                foreach (DataRow dr in dt5.Rows)
                {
                    comBankName.Items.Add(dr["BankName"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "select * from COAccounts ";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
                da6.Fill(dt6);
                comGLAccount.Items.Clear();
                foreach (DataRow dr in dt6.Rows)
                {
                    comGLAccount.Items.Add(dr["AName"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd7 = con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "select * from CurrencyReg ";
                cmd7.ExecuteNonQuery();
                DataTable dt7 = new DataTable();
                OleDbDataAdapter da7 = new OleDbDataAdapter(cmd7);
                da7.Fill(dt7);
                comCurrency.Items.Clear();
                foreach (DataRow dr in dt7.Rows)
                {
                    comCurrency.Items.Add(dr["CrName"].ToString());
                }
                con.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-88-TTPAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmTTPay()
        {
            InitializeComponent();
        }

        private void FrmTTPay_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            // TxtSer_TextChanged(null, null);
            ComList();
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //  OleDbCommand cmd = new OleDbCommand("Insert into TTPayment(TTDate, BankName, BankACNo, GLAccount, TTCurrency, ExchangeRate, TTAmount) values('"
                OleDbCommand cmd = new OleDbCommand("Insert into TTPayment(TTDate, BankName, BankACNo, GLAccount, TTCurrency, ExchangeRate, TTAmount, BankCharges, TotalAmount) values('"
                    + dtpTTDate.Value.ToString()
                    + "', '" + comBankName.Text
                    + "', '" + txtBankAcNo.Text
                    + "', '" + comGLAccount.Text
                    + "', '" + comCurrency.Text.ToString()
                    + "', '" + txtExchangeRate.Text.ToString()
                    + "', '" + txtTotalAmount.Text.ToString()
                    + "', '" + txtBankCharges.Text.ToString()
                    + "', '" + txtTotalAmount.Text.ToString()
                    + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpTTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Blank();
                dtpTTDate.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-136-TTPAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comBankName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from Bank where BankName='" + comBankName.Text.Trim() + "'", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtBankAcNo.Text = rdr["BankAccountNo"].ToString();
                    }
                    comGLAccount.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Please Select Bank Name from List!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBankAcNo.Text = "";
                        comBankName.Text = "";
                        comBankName.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void comGLAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGLAccount.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from COAccounts where AName='" + comGLAccount.Text.Trim() + "'", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtAmount.Text = rdr["Bal"].ToString();
                    }
                    comCurrency.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Please Select G/L Account from List!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comGLAccount.Text = "";
                        txtAmount.Text = "0.00";
                        comGLAccount.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void comCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCurrency.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from CurrencyExc where CrName='" + comCurrency.Text.Trim() + "'", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtExchangeRate.Text = rdr["Rate"].ToString();
                    }
                    txtBankCharges.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Currency Not Updated on Currency Exchange!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comCurrency.Text = "";
                        txtExchangeRate.Text = "0.00";
                        comCurrency.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void txtBankCharges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankCharges.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdUpdate.Focus();
                    double aaa = 0.00, bbb = 0.00, ccc = 0.00;
                    aaa = Convert.ToDouble(txtAmount.Text.ToString());
                    bbb = Convert.ToDouble(txtBankCharges.Text.ToString());
                    ccc = aaa + bbb;
                    txtTotalAmount.Text= ccc.ToString("#,###.00");
                }
            }
        }

        private void FrmTTPay_Resize(object sender, EventArgs e)
        {
            panel1.Left = 0;
            groupBox1.Left = 0;
        }
    }
}
