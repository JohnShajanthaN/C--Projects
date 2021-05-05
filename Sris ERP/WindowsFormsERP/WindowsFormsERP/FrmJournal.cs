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
    public partial class FrmJournal : Form
    {
        public static string uname = "";
        public static string ul = "";
        string PPP = "", CCC="";
        int count = 0;
        //int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            comCategory.Text = "";
            comPaticular.Text = "";
            txtAmount.Text = "";
            dtpJDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comOpc.Text = "Cash";
            comCashFlow.Text = "";
        }

        private void fromDGView()
        {
            comJNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpJDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comPaticular.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comOpc.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comPLACType.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comBalALType.Text= dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comCashFlow.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            double bb = 0.00;
            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString()=="0.0000")
            {
                comCategory.Text = "Credit";
                bb = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                txtAmount.Text = bb.ToString("#,###.00");                
            }
            else
            {                
                comCategory.Text = "Debit";
                bb = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                txtAmount.Text = bb.ToString("#,###.00");
            } 
        }

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].Width = 32;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 88;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;           
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select Particular from Journal where Jno Like '%" + TxtSer.Text + "%' GROUP BY Particular";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comPaticular.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comPaticular.Items.Add(dr["Particular"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select Jno from Journal where Particular Like '%" + TxtSer.Text + "%' GROUP BY Jno";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(dt2);
                comJNo.Items.Clear();
                foreach (DataRow dr2 in dt2.Rows)
                {
                      comJNo.Items.Add(dr2["Jno"].ToString());
                }
                con.Close();


                con.Open();
                OleDbCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select Opc from Journal where Particular Like '%" + TxtSer.Text + "%' GROUP BY Opc";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(dt3);
                comOpc.Items.Clear();
                foreach (DataRow dr3 in dt3.Rows)
                {
                      comOpc.Items.Add(dr3["Opc"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmJournal()
        {
            InitializeComponent();
        }

        private void FrmJournal_Load(object sender, EventArgs e)
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
                if (comCategory.Text == "Credit")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into Journal(Jno, JDate, Particular, Debit, Credit, Opc, PLACType, BalALType, CashFlow) values('"
                    + comJNo.Text + "', '" + dtpJDate.Value.ToString() + "', '" + comPaticular.Text + "', '" + "0.00" + "', '" + txtAmount.Text + "', '" + comOpc.Text + "', '" + comPLACType.Text + "', '" + comBalALType.Text + "', '" + comCashFlow.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comJNo.Text = "";
                    Blank();
                    comCategory.Text = "Debit";
                    comJNo.Focus();
                    TxtSer_TextChanged(null, null);
                    ComList();
                }
                else if (comCategory.Text == "Debit")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into Journal(Jno, JDate, Particular, Debit, Credit, Opc, PLACType, BalALType, CashFlow) values('"
                    + comJNo.Text + "', '" + dtpJDate.Value.ToString() + "', '" + comPaticular.Text + "', '" + txtAmount.Text + "', '" + "0.00" + "', '" + comOpc.Text + "', '" + comPLACType.Text + "', '" + comBalALType.Text + "', '" + comCashFlow.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //comJNo.Text = "";
                    //Blank();
                   
                    comCategory.Text = "Credit";
                    string kkk = "";
                    kkk = comPaticular.Text;
                    comPaticular.Text = comOpc.Text;
                    comOpc.Text = kkk;

                    TxtSer.Text = comJNo.Text;
                    TxtSer_TextChanged(null, null);
                    ComList();
                    comPaticular.SelectionStart = 0;
                    comPaticular.SelectionLength = comPaticular.Text.Length;
                    comPaticular.Focus();
                }
                else
                {
                    MessageBox.Show("Please Select Catogery! Don't Type!", "Typing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comJNo.Text)
                {
                    if (comCategory.Text == "Credit")
                    {
                        OleDbCommand cmd = new OleDbCommand("Update Journal SET Jno='" + comJNo.Text + "', JDate='" + dtpJDate.Value.ToString() + "', Particular='" + comPaticular.Text + "', Debit='" + "0.00" + "', Credit='" + txtAmount.Text + "', Opc='" + comOpc.Text + "', PLACType='" + comPLACType.Text + "', BalALType='" + comBalALType.Text + "', CashFlow='" + comCashFlow.Text
                        + "' WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (comCategory.Text == "Debit")
                    {
                        OleDbCommand cmd = new OleDbCommand("Update Journal SET Jno='" + comJNo.Text + "', JDate='" + dtpJDate.Value.ToString() + "', Particular='" + comPaticular.Text + "', Debit='" + txtAmount.Text + "', Credit='" + "0.00" + "', Opc='" + comOpc.Text + "', PLACType='" + comPLACType.Text + "', BalALType='" + comBalALType.Text + "', CashFlow='" + comCashFlow.Text
                        + "' WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comJNo.Text = "";
                    Blank();
                    comJNo.Focus();
                    TxtSer_TextChanged(null, null);
                    ComList();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Please Select the record(Index) on Grid List for Editing!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-115-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()==comJNo.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string txt = "DELETE FROM [Journal] Where [Index]=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                        OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comJNo.Text = "";
                        Blank();
                        ComList();
                        comJNo.Focus();
                        TxtSer_TextChanged(null, null);
                        ComList();
                    }
                    else
                    {
                        comJNo.Focus();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Please Select the record(Index) from Grid List for Deleting!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-150-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comJNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comJNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {                        
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Journal where Jno='" + comJNo.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            dtpJDate.Text = rdr["JDate"].ToString();
                            if (rdr["Debit"].ToString() != "0.0000")
                            {
                                comCategory.Text = "Credit";                                
                            }
                            else if (rdr["Credit"].ToString() != "0.0000")
                            {
                                comCategory.Text = "";
                            }
                            temp = true;
                        }
                        con.Close();
                        comPaticular.Focus();
                        TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            comCategory.Text = "Debit";
                            dtpJDate.Focus();
                        }
                        con.Close();
                        TxtSer.Text = comJNo.Text;
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
            try
            {
                string txt = "SELECT * FROM [Journal] Where Index=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-166-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Journal where Jno Like '%" + TxtSer.Text + "%' or Particular Like '%" + TxtSer.Text + "%' or PLACType Like '%" + TxtSer.Text + "%' or BalALType Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comCategory.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (comCategory.Text == "Debit" && TxtSer.Text == comJNo.Text)
                        {
                            txtAmount.Text = "";
                        }
                        else
                        {
                            if (comCategory.Text == "Debit" && comPaticular.Text=="Cash")
                            {
                                comOpc.Text = "Sales";
                            }
                            txtAmount.SelectionStart = 0;
                            txtAmount.SelectionLength = txtAmount.Text.Length;
                        }
                        txtAmount.Focus();
                    }                    
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpJDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comPaticular.Focus();
            }
        }

        private void comPaticular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPaticular.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PPP = comPaticular.Text;
                    PPP = PPP.Substring(PPP.Length - 4, 4);
                    CCC = comPaticular.Text;
                    CCC = CCC.Substring(CCC.Length - 7, 7);
                    if (comPaticular.Text=="Wages")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Wage")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Purchase")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Purchase Return")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Sales")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Sales Return")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Cash")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Insurance")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Rent")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Salary")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Stationery")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Stationeries")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Travelling Charges")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Travelling Charge")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Discunt Received")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Intrest Received")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Intrest Received on Debenture")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Factory Expenses")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Factory Rent")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Shipping Expenses")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Shipping")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Packing Expenses")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Packing Charge")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Packing Charges")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Packing")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Rent")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Liabilities";
                    }
                    else if (comPaticular.Text == "Office Rent")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Liabilities";
                    }
                    else if (comPaticular.Text == "Office Expenses")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Commission Issue")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Commission Issued")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Commission Received")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Liabilities"; ;
                    }
                    else if (comPaticular.Text == "Commission Receive")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Liabilities"; ;
                    }
                    else if (comPaticular.Text == "Tax Expenses")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Tax")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Liabilities";
                    }
                    else if (comPaticular.Text == "Salaries")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Liabilities";
                    }
                    else if (comPaticular.Text == "Interest")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Interest Received")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Interest Receive")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Bank Interest")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (PPP == "Bank")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (PPP == "Capital")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Capital - Equity";
                    }
                    else if (comPaticular.Text == "Carriage Inward")
                    {
                        comPLACType.Text = "Direct Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Deprecation")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Computer and Printers")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Computers and Printers")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Computer and Printer")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Computer & Printers")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Computer Accessories")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Furniture")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Furnitures")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Machinery")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Discount Received")
                    {
                        comPLACType.Text = "Indirect Incomes";
                        comBalALType.Text = "Others";
                    }
                    else if (comPaticular.Text == "Outstanding Exp")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Liabilities";
                    }
                    else if (comPaticular.Text == "Prepaid Insurance")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Petty Cash")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Debenture")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Current Assets";
                    }
                    else if (comPaticular.Text == "Land and Building")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Fiixed Assets";
                    }
                    else if (comPaticular.Text == "Postage Expenses")
                    {
                        comPLACType.Text = "Indirect Expenses";
                        comBalALType.Text = "Others";
                    }
                    else
                    {
                        comPLACType.Text = "";
                        comBalALType.Text = "";
                    }
                    comCategory.Focus();
                }                
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmount.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comOpc.Focus();
                }
            }
        }

        private void comOpc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comOpc.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comOpc.Text == "Purchase")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Others";
                    }
                    else if (comOpc.Text == "Sales")
                    {
                        comPLACType.Text = "Others";
                        comBalALType.Text = "Current Assets";
                    }
                    comPLACType.Focus();
                }
            }
        }

        private void comPLACType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPLACType.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comBalALType.Focus();
                }
            }
        }

        private void CmdOpenSt_Click(object sender, EventArgs e)
        {            
            FrmOpenSt FOpenSt = new FrmOpenSt();
            FOpenSt.Show();
        }

        private void CmdCloseSt_Click(object sender, EventArgs e)
        {
            FrmCloseSt FCloseSt = new FrmCloseSt();
            FCloseSt.Show();
        }

        private void comBalALType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comBalALType.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comCashFlow.Focus();
                }
            }
        }

        private void comCashFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCashFlow.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }
    }
}
