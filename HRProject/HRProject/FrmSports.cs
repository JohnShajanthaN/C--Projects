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
    public partial class FrmSports : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";
            txtOrganization.Text = "";
            txtSports.Text = "";
            comCategory.Text = "";
            comLevel.Text = "";
            comPlace.Text = "";
            comRecords.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSports.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comCategory.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtOrganization.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comLevel.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comPlace.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comRecords.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Emp_ID";
            dataGridView1.Columns[1].HeaderText = "Emp_Name";
            dataGridView1.Columns[2].HeaderText = "Sports_Type";
            dataGridView1.Columns[3].HeaderText = "Sports_Cat";
            dataGridView1.Columns[4].HeaderText = "Organization";
            /*
            dataGridView1.Columns[5].HeaderText = "Level";
            dataGridView1.Columns[6].HeaderText = "Place";
            dataGridView1.Columns[7].HeaderText = "Records";  
            */

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            /*
        dataGridView1.Columns[5].Width = 80;
        dataGridView1.Columns[6].Width = 80;
        dataGridView1.Columns[7].Width = 80;
            */

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

        public FrmSports()
        {
            InitializeComponent();
        }

        private void FrmSports_Load(object sender, EventArgs e)
        {
            ComList();
            TxtSer_TextChanged(null, null);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Sports values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + txtSports.Text + "', '" + comCategory.Text + "', '" + txtOrganization.Text + "', '" + comLevel.Text + "', '" + comPlace.Text + "', '" + comRecords.Text+ "')", con);
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
                cmd.CommandText = "select * from Sports where Category Like '%" + TxtSer.Text + "%' or  EmpID Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or SType Like '%" + TxtSer.Text + "%' or Category Like '%" + TxtSer.Text + "%' or Organization Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                comLevel.Items.Clear();
                comCategory.Items.Clear();
                comPlace.Items.Clear();
                comRecords.Items.Clear();
                txtSports.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comLevel.Items.Add(dr["SLevel"].ToString());
                    comCategory.Items.Add(dr["Category"].ToString());
                    comPlace.Items.Add(dr["Place"].ToString());
                    comRecords.Items.Add(dr["Records"].ToString());
                    txtSports.Items.Add(dr["SType"].ToString());
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
                string txt = "SELECT * FROM [Sports] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                groupBox1.Enabled = false;
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
                            txtSports.Focus();
                        }
                        txtSports.Focus();
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

        private void txtSports_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comLevel.Focus();
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
            cmdEdit.Text = "UPDATE";
            groupBox1.Enabled = true;
        }

        private void Modify()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Sports SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', SType='" + txtSports.Text + "', Category='" + comCategory.Text + "', Organization='" + txtOrganization.Text + "', SLevel='" + comLevel.Text + "', Place='" + comPlace.Text + "', Records='" + comRecords.Text
                    + "' WHERE EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                cmdEdit.Text = "EDIT";
                Blank();
                comEmpID.Focus();
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
                    string txt = "DELETE FROM [Sports] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
                    txtSports.Focus();
                }
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmSportsRep FSportsrep = new FrmSportsRep();
            FSportsrep.Show();
        }

        private void comEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from EMPBasic where EmpID='" + comEmpID.Text.Trim() + "' ", con);
            cmd3.Connection = con;
            rdr = cmd3.ExecuteReader();

            if (rdr.Read())
            {
                txtEmpName.Text = rdr["IName"].ToString();
                txtSports.Focus();
                groupBox1.Enabled = false;            
            }

            else
            {
                
                 
            }

            rdr.Close();
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand(" SELECT * FROM [Sports] Where EmpID='" + comEmpID.Text + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();

            if (rdr.Read())
            {

                txtSports.Text = rdr["SType"].ToString();
                comLevel.Text = rdr["SLevel"].ToString();
                comCategory.Text = rdr["Category"].ToString();
                comPlace.Text = rdr["Place"].ToString();
                txtOrganization.Text = rdr["Organization"].ToString();
                comRecords.Text = rdr["Records"].ToString();
                
                groupBox1.Enabled = false;
                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
                txtSports.Focus();
            }
            else
            {
                txtSports.Text = "";
                comLevel.Text = "";
                comCategory.Text = "";
                comPlace.Text = "";
                txtOrganization.Text = "";
                comRecords.Text = "";

                groupBox1.Enabled = true;
                cmdEdit.Enabled = false;
                cmdEdit.Text = "EDIT";
            }

            con.Close();
            rdr.Close();
        }

        private void comLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comLevel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                comCategory.Focus();
               }   
            
        }

        private void comCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comCategory.Text == "")
            {
                MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comPlace.Focus();
            }
            
        }

        private void comPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comPlace.Text == "")
            {
                MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtOrganization.Focus();
            }
            
        }

        private void txtOrganization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOrganization.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comRecords.Focus();
                }

            }
        }

        private void comLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comLevel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comCategory.Focus();
                }
            }

        }

        private void comCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCategory.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comPlace.Focus();
                }
            }
        }

        private void comPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (comPlace.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtOrganization.Focus();
                }
            }
        }

        private void comRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comRecords.Text == "")
            {
                MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmdAdd.Focus();
            }
            
        }

        private void comRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comRecords.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void txtOrganization_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSports_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSports.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comLevel.Focus();
                }
            }
        }

        private void txtSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSports.Text == "")
            {
                MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comLevel.Focus();
            }
        }
    }
}
