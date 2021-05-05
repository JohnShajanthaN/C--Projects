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
    public partial class FrmBank : Form
    {
        //public static string uname = "";
        //public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtBaName.Text = "";
            txtAccNo.Text = "";
            txtBrCode.Text = "";
            txtBrName.Text = "";      
            TxtSer.Text = "";
             TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            txtBaCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBaName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBrCode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBrName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtAccNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();  
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 80;

            dataGridView1.Columns[0].HeaderText = "Bank_Code";
            dataGridView1.Columns[1].HeaderText = "Bank_Name";
            dataGridView1.Columns[2].HeaderText = "Branch_Code";
            dataGridView1.Columns[3].HeaderText = "Branch_Name";
            dataGridView1.Columns[4].HeaderText = "Account_No";

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            
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
        public FrmBank()
        {
            InitializeComponent();
        }

        private void FrmBank_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into Bank(BankCode, BankName, BankAccountNo, BranchCode, BranchName,CreatedBy, CreatedOn, UpdatedBy, UpdatedOn) values('"
                    + txtBaCode.Text + "', '" + txtBaName.Text + "', '" + txtAccNo.Text + "', '" + txtBrCode.Text + "', '" + txtBrName.Text + "', '" + "." + "', '" + DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + "', '" + "Not Changed!" + "', '" + DateTime.Now.ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBaCode.Text = "";
                Blank();
                txtBaCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-98-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Open();
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update Bank SET BankCode='" + txtBaCode.Text + "', BankName='" + txtBaName.Text + "', BankAccountNo='" + txtAccNo.Text + "', BranchCode='" + txtBrCode.Text + "', BranchName='" + txtBrName.Text
                    + "' WHERE BankCode='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBaCode.Text = "";
                Blank();
                txtBaCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-118-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Open();
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Bank] Where [BankCode]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBaCode.Text = "";
                    Blank();
                    txtBaCode.Focus();
                }
                else
                {
                    txtBaCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-145-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Open();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Bank] Where BankCode='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Open();
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
                cmd.CommandText = "select * from Bank where BankCode Like '%" + TxtSer.Text + "%' or BankName Like '%" + TxtSer.Text + "%' or BankAccountNo Like '%" + TxtSer.Text + "%' or BranchCode Like '%" + TxtSer.Text + "%' or BranchName Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                // comKW.Items.Clear();
                // comGr.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    //    comKW.Items.Add(dr["Kw"].ToString());
                    //    comGr.Items.Add(dr["Gr"].ToString());
                }

                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-196-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Open();
            }
        }

        private void txtBaCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtBaCode.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtBaCode.Text)
                            {
                                string txt = "SELECT * FROM [Bank] Where BankCode='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        txtBaName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : BCD-KDW-236-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   con.Open();
                }
            }
        }

        private void txtBaName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBaName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtBrCode.Focus();
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBaCode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBaCode.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaCode.Text = txtBaCode.Text.Remove(txtBaCode.Text.Length - 1);
                txtBaCode.Text = "";
            }
        }

        private void txtBaName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBaName.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaName.Text = txtBaName.Text.Remove(txtBaName.Text.Length - 1);
                txtBaName.Text = "";
            }
        }

        private void txtBrCode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrCode.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrCode.Text = txtBrCode.Text.Remove(txtBrCode.Text.Length - 1);
                txtBrCode.Text = "";
            }
        }

        private void txtBrName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrName.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrName.Text = txtBrName.Text.Remove(txtBrName.Text.Length - 1);
                txtBrName.Text = "";
            }
        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAccNo.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccNo.Text = txtAccNo.Text.Remove(txtAccNo.Text.Length - 1);
                txtAccNo.Text = "";
            }
        }

        private void txtBrCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBrCode.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtBrName.Focus();
                }
            }
        }

        private void txtBrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBrName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtAccNo.Focus();
                }
            }
        }

        private void txtAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAccNo.Text == "")
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

