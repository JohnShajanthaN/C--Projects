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
    public partial class FrmJobOdr : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            comCCode.Text = "";
            comCName.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                comJONo.Text = "000001";
                comCName.Focus();
            }

            else
            {
                int q = 0;
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from JobOrder", con);
                cmd2.Connection = con;

                OleDbDataReader rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    if (q < Convert.ToInt32(rdr["JobOrderNo"]))
                    {
                        q = Convert.ToInt32(rdr["JobOrderNo"]);
                    }
                }
                con.Close();
                q = q + 1;
                comJONo.Text = q.ToString("000000");
                comCName.Focus();
            }
        }

        private void fromDGView()
        {
            comJONo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comCName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comCCode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 60;

            dataGridView1.Columns[0].HeaderText = "Job_Ord_No";
            dataGridView1.Columns[1].HeaderText = "Cus_Name";
            dataGridView1.Columns[2].HeaderText = "Cus_Code";

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void ComList()
        {
            try
            {             
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from customer where CustomerCode Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or customeraddress Like '%" + TxtSer.Text + "%'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comCName.Items.Clear();
                comCCode.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comCName.Items.Add(dr["CustomerName"].ToString());
                    comCCode.Items.Add(dr["CustomerCode"].ToString());
                }
                con.Close();                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmJobOdr()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into JobOrder(JobOrderNo, CustomerName, CustomerCode) values('"
                    + comJONo.Text + "', '" + comCName.Text + "', '" + comCCode.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comJONo.Text = "";
                Blank();
                comJONo.Focus();
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
                OleDbCommand cmd = new OleDbCommand("Update JobOrder SET JobOrderNo='" + comJONo.Text + "', CustomerName='" + comCName.Text + "', CustomerCode='" + comCCode.Text
                    + "' WHERE JobOrderNo='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comJONo.Text = "";
                Blank();
                comJONo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-115-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmJobOdr_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();
            Blank();    
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [JobOrder] Where [JobOrderNo]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comJONo.Text = "";
                    Blank();
                    comJONo.Focus();
                }
                else
                {
                    comJONo.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-150-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [JobOrder] Where JobOrderNo='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
                cmd.CommandText = "select * from JobOrder where JobOrderNo Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or CustomerCode Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                //comJONo.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    //comJONo.Items.Add(dr["JobOrderNo"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == comJONo.Text)
                            {
                                string txt = "SELECT * FROM [JobOrder] Where JobOrderNo='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        comCName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
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

        private void comCName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from customer where CustomerName='" + comCName.Text.Trim() + "' ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        comCCode.Text = rdr["CustomerCode"].ToString();
                        temp = true;
                    }
                    comCCode.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Please Select Customer from in this Combo box List!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comCCode.Text = "";
                        comCName.Text = "";
                        comCName.Focus();
                    }
                    con.Close();
                }
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
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from customer where CustomerCode=" + comCCode.Text.Trim() + " ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        comCName.Text = rdr["CustomerName"].ToString();
                        temp = true;
                    }
                    CmdSave.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comCCode.Text = "";
                        comCName.Text = "";
                        comCCode.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comJONo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comJONo.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comJONo.Text = comJONo.Text.Remove(comJONo.Text.Length - 1);
                comJONo.Text = "";
            }
        }
    }
}
