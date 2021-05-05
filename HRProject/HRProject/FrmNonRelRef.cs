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
using System.Data.SqlClient;

namespace HRProject
{
    public partial class FrmNonRelRef : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";
            txtEmail.Text = "";
            txtMob.Text = "";
            txtName.Text = "";
            txtOAddress.Text = "";
            txtOffice.Text = "";
            txtTel.Text = "";
            comDesignation.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comDesignation.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtOffice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtOAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtTel.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtMob.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Emp_ID";
            dataGridView1.Columns[1].HeaderText = "Emp_Name";
            dataGridView1.Columns[2].HeaderText = "Ref_Name";
            dataGridView1.Columns[3].HeaderText = "Designation";
            dataGridView1.Columns[4].HeaderText = "Office";
            dataGridView1.Columns[5].HeaderText = "Off_Add";
            dataGridView1.Columns[7].HeaderText = "Mobile";
            dataGridView1.Columns[8].HeaderText = "Email_Add";

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[7].Width = 100;
            
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from EmpBasic where EmpID Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                comEmpID.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt.Rows)
                {
                    comEmpID.Items.Add(dr["EmpID"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-131-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public FrmNonRelRef()
        {
            InitializeComponent();
        }

        private void FrmNonRelRef_Load(object sender, EventArgs e)
        {
            ComList();
            TxtSer_TextChanged(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Ref values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + txtName.Text + "', '" + comDesignation.Text + "', '" + txtOffice.Text + "', '" + txtOAddress.Text + "', '" + txtTel.Text + "', '" + txtMob.Text + "', '" + txtEmail.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-98-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Ref where EmpID Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or RefName Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                comDesignation.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comDesignation.Items.Add(dr["Designation"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-196-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Ref] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void comEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comEmpID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Blank();
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("select * from EMPBasic where EMPID='" + comEmpID.Text.Trim() + "' ", con);
                        cmd2.Connection = con;
                        rdr = cmd2.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            temp = true;
                            txtEmpName.Text = rdr["IName"].ToString();
                        }
                        txtName.Focus();
                        if (temp == false)
                        {
                            MessageBox.Show("Record Not Found! Please Select from Drop Down List", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmpName.Text = "";
                            comEmpID.Focus();
                            Blank();
                        }
                        con.Close();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : BCD-KDW-236-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else
            {
                txtEmpName.Text = "";
                MessageBox.Show("Please Select from Drop Down List", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtName.Focus();
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (cmdEdit.Text == "UPDATE")
            {
                Modify();
                Blank();
            }
            else
            {
                Edit();
            }
            
        }

        private void Edit()
        {
            groupBox1.Enabled = true;
            cmdEdit.Text = "UPDATE";
        }

        private void Modify()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Ref SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', RefName='" + txtName.Text + "', Designation='" + comDesignation.Text + "', Office='" + txtOffice.Text + "', OAddress='" + txtOAddress.Text + "', Tell='" + txtTel.Text + "', Mobile='" + txtMob.Text + "', EMail='" + txtEmail.Text
                    + "' WHERE EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
                groupBox1.Enabled = true;
                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-118-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Ref] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comEmpID.Text = "";
                    Blank();
                    comEmpID.Focus();
                }
                else
                {
                    comEmpID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-145-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void comEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from EMPBasic where EMPID='" + comEmpID.Text.Trim() + "' ", con);
            cmd3.Connection = con;
            rdr = cmd3.ExecuteReader();

            if (rdr.Read())
            {
                txtEmpName.Text = rdr["IName"].ToString();
                groupBox1.Enabled = true;
                txtName.Focus();
            }

            else
            {

            }

            rdr.Close();
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand(" SELECT * FROM [Ref] Where EmpID='" + comEmpID.Text + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();

            if (rdr.Read())
            {
                txtName.Text = rdr["RefName"].ToString();
                txtTel.Text = rdr["Tell"].ToString();
                comDesignation.Text = rdr["Designation"].ToString();
                txtMob.Text = rdr["Mobile"].ToString();
                txtOffice.Text = rdr["Office"].ToString();
                txtEmail.Text = rdr["EMail"].ToString();
                txtOAddress.Text = rdr["OAddress"].ToString();

                groupBox1.Enabled = false;

                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
                cmdEdit.Focus();
            }
            else
            {
                txtName.Text ="";
                txtTel.Text ="";
                comDesignation.Text ="";
                txtMob.Text ="";
                txtOffice.Text = "";
                txtEmail.Text ="";
                txtOAddress.Text = "";

                groupBox1.Enabled = true;             
                cmdEdit.Enabled = false;
                cmdEdit.Text = "EDIT";
            }

            con.Close();
            rdr.Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTel.Focus();
                }
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comDesignation.Focus();
                }
            }
        }

        private void comDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {       
                if (txtTel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comDesignation.Focus();
                }           
        }

        private void txtMob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMob.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtOffice.Focus();
                }
            }
        }

        private void txtOffice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOffice.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtOAddress.Focus();
                }
            }
        }

        private void txtOAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOAddress.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void comDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comDesignation.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMob.Focus();
                }
            }
        }
    }
}
