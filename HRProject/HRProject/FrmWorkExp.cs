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
    public partial class FrmWorkExp : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";
            comDesignation.Text = "";            
            dtpPFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpPTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtYears.Text = "";
            txtRemarks.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comDesignation.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dtpPFrom.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            dtpPTo.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value);
            txtYears.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtRemarks.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = " EmpID";
            dataGridView1.Columns[1].HeaderText = " EmpName";
            dataGridView1.Columns[2].HeaderText = " Designation";
            dataGridView1.Columns[5].HeaderText = " Years";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[5].Width = 80;

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;
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
            }
        }

        public FrmWorkExp()
        {
            InitializeComponent();
        }

        private void FrmWorkExp_Load(object sender, EventArgs e)
        {
            ComList();
            TxtSer_TextChanged(null, null);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into WorkExperience values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + comDesignation.Text + "', '" + dtpPFrom.Value.ToString() + "', '" + dtpPTo.Value.ToString() + "', '" + txtYears.Text + "', '" + txtRemarks.Text + "')", con);
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
                cmd.CommandText = "select * from WorkExperience where EmpID Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or Designation Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                comDesignation.Items.Clear();
                //comManager.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    comDesignation.Items.Add(dr["Designation"].ToString());
                    // comManager.Items.Add(dr["Manager"].ToString());
                }

                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-196-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == "" || dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "" || dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "" || dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "")
                {

                }
                else
                {
                    string txt = "SELECT * FROM [WorkExperience] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    fromDGView();
                    groupBox3.Enabled = false;
                }
                            
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
                        comDesignation.Focus();
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
                    comDesignation.Focus();
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit()
        {
            groupBox3.Enabled = true;
            comEmpID.Enabled = false;
            cmdEdit.Text = "UPDATE";
        }

        private void Modify()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update WorkExperience SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', Designation='" + comDesignation.Text + "', PFrom='" + dtpPFrom.Value.ToString() + "', PTo='" + dtpPTo.Value.ToString() + "', Years='" + txtYears.Text + "', Remark='" + txtRemarks.Text
                    + "' WHERE EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
                groupBox3.Enabled = true;
                comEmpID.Enabled = true;
                cmdEdit.Text = "EDIT";
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-118-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {        
            if (cmdEdit.Text == "UPDATE")
            {
                Modify();
            }
            else
            {
                Edit();
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [WorkExperience] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmWorkExpRep FWorkExprep = new FrmWorkExpRep();
            FWorkExprep.Show();

        }

        private void comEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comEmpID.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    comDesignation.Focus();
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
            }

        }

        private void comDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
            {
                if (comDesignation.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpPFrom.Focus();
                }
            }

        }

        private void comDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {          
                if (comDesignation.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpPFrom.Focus();
                }          
        }

        private void dtpPFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtpPFrom.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpPTo.Focus();
                }
            }
        }

        private void dtpPTo_KeyDown(object sender, KeyEventArgs e)
        {           
                if (e.KeyCode == Keys.Enter)
            {
                if (dtpPTo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtYears.Focus();
                }
            }
        }

        private void txtYears_KeyDown(object sender, KeyEventArgs e)
        {            
                  if (e.KeyCode == Keys.Enter)
            {
                if (txtYears.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtRemarks.Focus();
                }
            }
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRemarks.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void FrmWorkExp_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            cmdEdit.Text = "EDIT";
            comEmpID.Enabled = true;
            Blank();
        }
    }
}
