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
    public partial class FrmJOPayment : Form
    {
        public static string JONO ="", JODate="", CUSID="", CUS="", Amount="";
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            comCCode.Text = "";
            comInvNo.Text = "";
            txtInvAmo.Text = "";
            dtpPDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtPAmo.Text = "";
            comPayType.Text = "";
            txtPaid.Text = "";
            comPSta.Text = "";
            txtBal.Text = "";
        }

         private void fromDGView()
        {
            comJONo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comCCode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comInvNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtInvAmo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpPDate.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            comPayType.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            comPSta.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();            
            txtInvAmo.Text = string.Format("{0:N}", Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()));
            txtPaid.Text = string.Format("{0:N}", Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[9].Value.ToString()));
           // txtPAmo.Text = string.Format("{0:N}", Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[11].Value.ToString()));
            txtBal.Text = string.Format("{0:N}", Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[12].Value.ToString()));
            txtPAmo.Text = txtBal.Text;
        }

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9);
           // dataGridView1.Columns[6].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 110;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[1].HeaderText = " JO.No";
            dataGridView1.Columns[3].HeaderText = " Customer";
            dataGridView1.Columns[6].HeaderText = " Inv.Date";
            dataGridView1.Columns[7].HeaderText = " Category";
           // dataGridView1.Columns[8].HeaderText = " InvAmo";

        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select JobOrderNo from JOPayment where JobOrderNo Like '%" + TxtSer.Text + "%' GROUP BY JobOrderNo";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comJONo.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comJONo.Items.Add(dr["JobOrderNo"].ToString());
                }
                con.Close();
                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JnoKdwn()
        {
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from JOPayment where JobOrderNo='" + comJONo.Text.Trim() + "' ", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                comCCode.Text = rdr["CustomerCode"].ToString();
                comInvNo.Text = rdr["InvoiceNumber"].ToString();
                txtInvAmo.Text = rdr["InvAmo"].ToString();
                txtPaid.Text = rdr["PaidAmount"].ToString();
                dtpPDate.Text = rdr["PayDate"].ToString();
                txtPAmo.Text = rdr["PayAmount"].ToString();
                txtBal.Text = rdr["Bal"].ToString();
                comPayType.Text = rdr["PayType"].ToString();
                comPSta.Text = rdr["PayStatus"].ToString();
                temp = true;
            }
            con.Close();
            dtpPDate.Focus();
            TxtSer.Text = "";
            if (temp == false)
            {
                Blank();
            }
            con.Close();
        }

        public FrmJOPayment()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmJOPayment_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comJONo.Text)
                {
                  //  OleDbCommand cmd = new OleDbCommand("Update JOPayment SET PayDate='" + dtpPDate.Value.ToString() + "', PayAmount='" + txtPAmo.Text + "', Bal='" + txtBal.Text + "', comPayType='" + comPayType.Text + "', PayStatus='" + comPSta.Text
                    OleDbCommand cmd = new OleDbCommand("Update JOPayment SET PaidAmount='" + txtPaid.Text + "', PayDate='" + dtpPDate.Value.ToString() + "', PayAmount='" + txtPAmo.Text + "', Bal='" + txtBal.Text + "', PayType='" + comPayType.Text + "', PayStatus='" + comPSta.Text
                        + "' WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comJONo.Text = "";
                    Blank();
                    comJONo.Focus();
                    TxtSer_TextChanged(null, null);
                    ComList();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Please Select the record(Index) on Grid List for Save!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-115-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comJONo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comJONo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        JnoKdwn();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
               // count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from JOPayment where JobOrderNo Like '%" + TxtSer.Text + "%' or CustomerCode Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or RefNo Like '%" + TxtSer.Text + "%' or InvoiceNumber Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
               // count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpPDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPAmo.Focus();
            }
        }

        private void comCCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCCode.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comInvNo.Focus();
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [JOPayment] Where Index=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                txtPAmo.SelectionLength = txtPAmo.TextLength ;
                txtPAmo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-166-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPAmo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPAmo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    double aa = 0.00, bb = 0.00, pp = 0.00, pid=0.00;
                    pp = Convert.ToDouble(txtPAmo.Text);
                    JnoKdwn();
                    pid = Convert.ToDouble(txtPaid.Text);                    
                    aa = Convert.ToDouble(txtBal.Text);
                    bb = aa - pp;
                    pid = pid + pp;
                    if (bb < 1)
                        comPSta.Text = "Full Paid";
                    else if (bb == Convert.ToDouble(txtInvAmo.Text))
                        comPSta.Text = "Not Paid";
                    else
                        comPSta.Text = "Part Paid";

                    txtPAmo.Text = string.Format("{0:N}", Convert.ToDouble(pp));
                    txtBal.Text = string.Format("{0:N}", Convert.ToDouble(bb));
                    txtPaid.Text = string.Format("{0:N}", Convert.ToDouble(pid));
                    comPayType.Focus();
                }
            }            
        }

        private void comPayType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPayType.Text == "Cheque")
                {
                    JONO = comJONo.Text.ToString();
                    JODate = dtpPDate.Text.ToString();
                    CUSID = comCCode.Text.ToString();
                    // CUS=ComCu
                    Amount = txtPAmo.Text.ToString();
                    FrmChqReceived FChqReceived = new FrmChqReceived();
                    CmdSave.Focus();
                    FChqReceived.Show();
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }
    }
}
