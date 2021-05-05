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
    public partial class FrmPayment : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";
            txtMSalary.Text = "";
            txtBonus.Text = "";
            txtOT.Text = "";
            txtAllow.Text = "";
            txtDouble.Text = "";
            txtTrAllow.Text = "";
            txtIncenve.Text = "";
            txtMAllow.Text = "";
            txtTarget.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtMSalary.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBonus.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtOT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtAllow.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtDouble.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtTrAllow.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtIncenve.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtMAllow.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtTarget.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Emp_ID";
            dataGridView1.Columns[1].HeaderText = "Emp_Name";
            dataGridView1.Columns[2].HeaderText = " Bas_Sal";
            dataGridView1.Columns[3].HeaderText = "Bonus";
            dataGridView1.Columns[4].HeaderText = "OT";          

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
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
                MessageBox.Show("ERROR CODE : COM-LST-98-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            ComList();
            TxtSer_TextChanged(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPaymentRep FPaymentrep = new FrmPaymentRep();
            FPaymentrep.Show();

        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Payment1] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comEmpID.Text = "";
                    Blank();
                    comEmpID.Focus();
                    groupBox1.Enabled = true;
                    cmdEdit.Enabled = true;
                }
                else
                {
                    comEmpID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-142-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Payment1 values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + txtMSalary.Text + "', '" + txtBonus.Text + "', '" + txtOT.Text + "', '" + txtAllow.Text + "', '" + txtDouble.Text + "', '" + txtTrAllow.Text + "', '" + txtIncenve.Text + "', '" + txtMAllow.Text + "', '" + txtTarget.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
                groupBox1.Enabled = true;
                cmdEdit.Enabled = true;
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-163-PAY" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from Payment1 where EmpID Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or MSalary Like '%" + TxtSer.Text + "%'"; 
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
             
                con.Close();             
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : TXT-SER-201-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Payment1] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
                groupBox1.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-217-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        txtMSalary.Focus();
                        if (temp == false)
                        {
                            MessageBox.Show("Record Not Found! Please Select from Drop Down List", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmpName.Text = "";
                            comEmpID.Focus();
                            Blank();
                            con.Close();
                        }
                        con.Close();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : COM-KDW-257-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else
            {
                txtEmpName.Text = "";
                MessageBox.Show("Please Select from Drop Down List", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtMSalary.Focus();
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
                SqlCommand cmd = new SqlCommand("Update Payment1 SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', MSalary='" + txtMSalary.Text + "', Bonus='" + txtBonus.Text + "', OT='" + txtOT.Text + "', Allow1='" + txtAllow.Text + "', Double1='" + txtDouble.Text + "', TrAllow='" + txtTrAllow.Text + "', Incenve='" + txtIncenve.Text + "', MAllow='" + txtMAllow.Text + "', Target='" + txtTarget.Text
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
                MessageBox.Show("ERROR CODE : CMD-UPD-304-PAY" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void txtMSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMSalary.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtBonus.Focus();
                }
            }
        }

        private void txtOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOT.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtAllow.Focus();
                }
            }
        }

        private void txtAllow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAllow.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtDouble.Focus();
                }
            }
        }

        private void txtDouble_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDouble.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTrAllow.Focus();
                }
            }
        }

        private void txtTrAllow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTrAllow.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtIncenve.Focus();
                }
            }
        }

        private void txtIncenve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIncenve.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMAllow.Focus();
                }
            }
        }

        private void txtMAllow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMAllow.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTarget.Focus();
                }
            }
        }

        private void txtTarget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTarget.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmPaymentRep FPaymentrep = new FrmPaymentRep();
            FPaymentrep.Show();

        }

        private void txtBonus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBonus.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtOT.Focus();
                }
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
                txtMSalary.Focus();
            }

            else
            {
                
            }

            rdr.Close();
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand(" SELECT * FROM [Payment1] Where EmpID='" + comEmpID.Text + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();

            if (rdr.Read())
            {

                txtMSalary.Text = rdr["MSalary"].ToString();
                txtBonus.Text = rdr["Bonus"].ToString();
                txtOT.Text = rdr["OT"].ToString();
                txtAllow.Text = rdr["Allow1"].ToString();
                txtDouble.Text = rdr["Double1"].ToString();
                txtTrAllow.Text = rdr["TrAllow"].ToString();
                txtIncenve.Text = rdr["Incenve"].ToString();
                txtMAllow.Text = rdr["MAllow"].ToString();
                txtTarget.Text = rdr["Target"].ToString();
  
                groupBox1.Enabled = false;
                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
                txtMSalary.Focus();
            }
            else
            {
                txtMSalary.Text ="";
                txtBonus.Text = "";
                txtOT.Text ="";
                txtAllow.Text ="";
                txtDouble.Text ="";
                txtTrAllow.Text ="";
                txtIncenve.Text ="";
                txtMAllow.Text ="";
                txtTarget.Text ="";

                groupBox1.Enabled = true;
                cmdEdit.Enabled = false;
                cmdEdit.Text = "EDIT";
            }

            con.Close();
            rdr.Close();
        }



        private void txtMSalary_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtMSalary.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMSalary.Text = txtMSalary.Text.Remove(txtMSalary.Text.Length - 1);
            //}
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtBonus.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtBonus.Text = txtBonus.Text.Remove(txtBonus.Text.Length - 1);
            //}
        }

        private void txtOT_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtOT.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtOT.Text = txtOT.Text.Remove(txtOT.Text.Length - 1);
            //}
        }

        private void txtAllow_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtAllow.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtAllow.Text = txtAllow.Text.Remove(txtAllow.Text.Length - 1);
            //}
        }

        private void txtDouble_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtDouble.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDouble.Text = txtDouble.Text.Remove(txtDouble.Text.Length - 1);
            //}
        }

        private void txtTrAllow_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtTrAllow.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtTrAllow.Text = txtTrAllow.Text.Remove(txtTrAllow.Text.Length - 1);
            //}
        }

        private void txtIncenve_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtIncenve.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtIncenve.Text = txtIncenve.Text.Remove(txtIncenve.Text.Length - 1);
            //}
        }

        private void txtMAllow_TextChanged(object sender, EventArgs e)
        {
        //    if (System.Text.RegularExpressions.Regex.IsMatch(txtMAllow.Text, "[^0-9]"))
        //    {
        //        MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtMAllow.Text = txtMAllow.Text.Remove(txtMAllow.Text.Length - 1);
        //    }
        }

        private void txtTarget_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtTarget.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtTarget.Text = txtTarget.Text.Remove(txtTarget.Text.Length - 1);
            //}
        }
    }
}
