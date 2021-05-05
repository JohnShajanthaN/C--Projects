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
    public partial class FrmPhysicalInfo : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";
            txtHeight.Text = "";
            comHUnit.Text = "";
            txtWeight.Text = "";
            comWUnit.Text = "";
            comColor.Text = "";
            comHColor.Text = "";
            comBShape.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtHeight.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comHUnit.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comWUnit.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comColor.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comHColor.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comBShape.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Emp_ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Height";
            dataGridView1.Columns[3].HeaderText = "In_Unit";
            dataGridView1.Columns[4].HeaderText = "Weight";
            dataGridView1.Columns[5].HeaderText = "In_Unit";
            dataGridView1.Columns[6].HeaderText = "Body_Color";
            dataGridView1.Columns[7].HeaderText = "Hair_Color";
            dataGridView1.Columns[8].HeaderText = "Body_Shape";           

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width =50;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 100;
         
            dataGridView1.Columns[7].Visible = false;
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

        public FrmPhysicalInfo()
        {
            InitializeComponent();
        }

        private void FrmPhysicalInfo_Load(object sender, EventArgs e)
        {
            ComList();
            TxtSer_TextChanged(null, null);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Physical values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + txtHeight.Text + "', '" + comHUnit.Text + "', '" + txtWeight.Text + "', '" + comWUnit.Text + "', '" + comColor.Text + "', '" + comHColor.Text + "', '" + comBShape.Text + "')", con);
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
                cmd.CommandText = "select * from Physical where EmpID Like '%" + TxtSer.Text + "%' or EHeight Like '%" + TxtSer.Text + "%' or EWeight Like '%" + TxtSer.Text + "%' or EColor Like '%" + TxtSer.Text + "%' or Hair Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or BShape Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                comBShape.Items.Clear();
                comColor.Items.Clear();
                comHColor.Items.Clear();
                comHUnit.Items.Clear();
                comWUnit.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comBShape.Items.Add(dr["BShape"].ToString());
                    comColor.Items.Add(dr["EColor"].ToString());
                    comHColor.Items.Add(dr["Hair"].ToString());
                    comHUnit.Items.Add(dr["HUnit"].ToString());
                    comWUnit.Items.Add(dr["WUnit"].ToString());
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
                string txt = "SELECT * FROM [Physical] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                groupBox1.Enabled = false;             
                cmdEdit.Enabled = true;
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
                            txtHeight.Focus();
                        }
                        txtHeight.Focus();
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
                    txtHeight.Focus();
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
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
                SqlCommand cmd = new SqlCommand("Update Physical SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', EHeight='" + txtHeight.Text + "', HUnit='" + comHUnit.Text + "', EWeight='" + txtWeight.Text + "', WUnit='" + comWUnit.Text + "', EColor='" + comColor.Text + "', Hair='" + comHColor.Text + "', BShape='" + comBShape.Text
                    + "' WHERE EmpID='" + comEmpID.Text  + "'", con);
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

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Physical] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmPhysicalInformationRep FPhysicalInformationrep = new FrmPhysicalInformationRep();
            FPhysicalInformationrep.Show();

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
                txtHeight.Focus();
            }

            else
            {

            }

            rdr.Close();
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand(" SELECT * FROM [Physical] Where EmpID='" + comEmpID.Text + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();

            if (rdr.Read())
            {

                txtHeight.Text = rdr["EHeight"].ToString();
                comHUnit.Text = rdr["HUnit"].ToString();
                txtWeight.Text = rdr["EWeight"].ToString();
                comWUnit.Text = rdr["WUnit"].ToString();
                comHColor.Text = rdr["Hair"].ToString();
                comColor.Text = rdr["EColor"].ToString();
                comBShape.Text = rdr["BShape"].ToString();
           
                groupBox1.Enabled = false;
                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
                txtHeight.Focus();
            }
            else
            {
                txtHeight.Text = "";
                comHUnit.Text = "";
                txtWeight.Text = "";
                comWUnit.Text = "";
                comHColor.Text = "";
                comColor.Text = "";
                comBShape.Text = "";
                
                groupBox1.Enabled = true;
                cmdEdit.Enabled = false;
                cmdEdit.Text = "EDIT";
            }

            con.Close();
            rdr.Close();         
        }

        private void txtHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtHeight.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comHUnit.Focus();
                }
            }
        }

        private void comHUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comHUnit.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comHColor.Focus();
                }
            }
        }

        private void comHColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comHColor.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtWeight.Focus();
                }
            }
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtWeight.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comWUnit.Focus();
                }
            }
        }

        private void comWUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comWUnit.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comBShape.Focus();
                }
            }
        }

        private void comBShape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comBShape.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comColor.Focus();
                }
            }
        }

        private void comColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comColor.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
