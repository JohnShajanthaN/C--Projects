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
    public partial class FrmBMaster : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            txtACBal.Text = "";
            txtAddress.Text = "";
            txtCurrency.Text = "";
            txtEMail.Text = "";
            txtGRNDel.Text = "";
            txtName.Text = "";
            txtOrder.Text = "";
            txtTel.Text = "";
            txtVATRegNo.Text = "";
            comGroup.Text = "";
            //TxtSer.Text = "";
            //TxtSer_TextChanged(null, null);
        }
        public FrmBMaster()
        {
            InitializeComponent();
        }

        private void FrmBMaster_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            // TxtSer_TextChanged(null, null);
            //ComList();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from customer where CustomerCode=" + txtCode.Text.Trim() + " ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtName.Text = rdr["CustomerName"].ToString();
                        comGroup.Text = "Customer";
                        txtAddress.Text = rdr["customeraddress"].ToString();
                        txtEMail.Text = rdr["customeremail"].ToString();
                        txtTel.Text = rdr["CustomerLandNo"].ToString();
                        txtVATRegNo.Text = rdr["VATNumber"].ToString();
                    }
                    con.Close();
                    txtCurrency.Focus();
                    if (temp == false)
                    {
                        con.Open();
                        OleDbCommand cmd2 = new OleDbCommand("select * from Supplier where SupplierCode=" + txtCode.Text.Trim() + " ", con);
                        cmd2.Connection = con;
                        rdr = cmd2.ExecuteReader();
                        bool temp2 = false;
                        while (rdr.Read())
                        {
                            temp2 = true;
                            txtName.Text = rdr["SupplierName"].ToString();
                            comGroup.Text = "Supplier";
                            txtAddress.Text = rdr["SupplierAddress"].ToString();
                            txtEMail.Text = rdr["SupplierEmail"].ToString();
                            txtTel.Text = rdr["SupplierLandNo"].ToString();
                            //  txtVATRegNo.Text = rdr["VATNumber"].ToString();
                        }
                        con.Close();
                        txtCurrency.Focus();
                        if (temp2 == false)
                        {
                            MessageBox.Show("Record Not Found!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Blank();
                            txtCode.Text = "";
                            txtCode.Focus();
                        }
                    }
                }
            }
        }
    }
}
