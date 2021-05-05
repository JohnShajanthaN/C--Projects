using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsERP
{
    public partial class FrmTaxReg : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtTaxName.Text = "";
            txtTaxRate.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            txtTaxCode.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTaxName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTaxRate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 90;

            //dataGridView1.Columns[0].HeaderText ="ID";

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Tax_Code";
            dataGridView1.Columns[2].HeaderText = "Tax_Name";
            dataGridView1.Columns[3].HeaderText = "Tax_Rate";

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
        public FrmTaxReg()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into TaxReg(TaxCode, TaxName, TaxRate) values('"
                    + txtTaxCode.Text + "', '" + txtTaxName.Text + "', '" + txtTaxRate.Text.ToString() + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaxCode.Text = "";
                Blank();
                txtTaxCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-81-TAX-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update TaxReg SET TaxCode='" + txtTaxCode.Text + "', TaxName='" + txtTaxName.Text + "', TaxRate='" + txtTaxRate.Text.ToString()
                    + "' WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaxCode.Text = "";
                Blank();
                txtTaxCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-101-TAX-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void FrmTaxReg_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [TaxReg] Where [id]=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaxCode.Text = "";
                    Blank();
                    txtTaxCode.Focus();
                }
                else
                {
                    txtTaxCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-135-TAX-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [TaxReg] Where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-151-TAX-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
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
                cmd.CommandText = "select * from TaxReg where TaxCode Like '%" + TxtSer.Text + "%' or TaxName Like '%" + TxtSer.Text + "%'";
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
                MessageBox.Show("ERROR CODE : SER-CNG-186-TAX-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void txtTaxCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtTaxCode.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /*
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtTaxCode.Text)
                            {
                                string txt = "SELECT * FROM [TaxReg] Where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        txtTaxName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                        */
                        txtTaxName.Focus();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : TCOD-KDW-226-TAX-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void txtTaxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTaxName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTaxRate.Focus();
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTaxRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTaxRate.Text == "")
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
