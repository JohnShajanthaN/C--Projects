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
    public partial class FrmSStaff : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtSName.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                txtSCode.Text = "0001";
                txtSName.Focus();
            }

            else
            {
                int q = 0;
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from Salesman", con);
                cmd2.Connection = con;

                OleDbDataReader rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    if (q < Convert.ToInt32(rdr["BrokerNO"]))
                    {
                        q = Convert.ToInt32(rdr["BrokerNO"]);
                    }
                }
                con.Close();
                q = q + 1;
                txtSCode.Text = q.ToString("0000");
                txtSName.Focus();
            }
        }

        private void fromDGView()
        {
            txtSCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtSName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 120;

            dataGridView1.Columns[0].HeaderText = "Sales Staff Code";
            dataGridView1.Columns[1].HeaderText = "Sales Staff Name";

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            //if (lblULevel1.Text == "USER")
            //{
            //    dataGridView1.Columns[24].Visible = false;
            //    dataGridView1.Columns[25].Visible = false;
            //    dataGridView1.Columns[26].Visible = false;
            //    dataGridView1.Columns[27].Visible = false;
            //}
            //else
            //{
            //    dataGridView1.Columns[4].Visible = false;
            //    dataGridView1.Columns[25].Width = 45;
            //    dataGridView1.Columns[26].Width = 35;
            //    dataGridView1.Columns[27].Width = 45;
            //    dataGridView1.Columns[28].Width = 25;
            //}
        }
        public FrmSStaff()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into Salesman(BrokerNO, BrokerName) values('"
                    + txtSCode.Text + "', '" + txtSName.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-77-SSTF" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update Salesman SET BrokerNO='" + txtSCode.Text + "', BrokerName='" + txtSName.Text
                    + "' WHERE BrokerNO='" + dataGridView1.SelectedRows[0].Cells[0].Value + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-97-SSTF" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Salesman] Where [BrokerNO]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSCode.Text = "";
                    Blank();
                    txtSCode.Focus();
                }
                else
                {
                    txtSCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-124-SSTF" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Salesman] Where BrokerNO='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-140-SSTF" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from Salesman where BrokerNO Like '%" + TxtSer.Text + "%' or BrokerName Like '%" + TxtSer.Text + "%'";
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
                MessageBox.Show("ERROR CODE : SER-CNG-164-SSTF" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtSCode.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtSCode.Text)
                            {
                                string txt = "SELECT * FROM [Salesman] Where BrokerNO=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        txtSName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : SCOD-KDW-204-SSTF" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            // uname = lblUser1.Text;
            //  ul = lblULevel1.Text;
            //  FrmStkRep FStkRep = new FrmStkRep();
            // FStkRep.Show();
        }

        private void FrmSStaff_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            Blank();
            txtSName.Focus();
        }

        private void txtSCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSName.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Text = txtSName.Text.Remove(txtSName.Text.Length - 1);
                txtSName.Text = "";
            }
        }
    }
}
