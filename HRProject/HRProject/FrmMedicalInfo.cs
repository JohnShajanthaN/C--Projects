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
    public partial class FrmMedicalInfo : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";         
            textDiabetic.Text = "";
            textPressure.Text = "";
            textAllergy.Text = "";
            textFit.Text = "";
            textSurgery.Text = "";
            textSUsage.Text = "";
            txtAOMI.Text = "";
            txtBG.Text = "";

            OptBloodAP.Checked = false;
            OptBloodAM.Checked = false;
            OptBloodBP.Checked = false;
            OptBloodBM.Checked = false;
            OptBloodABP.Checked = false;
            OptBloodABM.Checked = false;
            OptBloodOP.Checked = false;
            OptBloodOM.Checked = false;

            OptDY.Checked = false;
            OptDN.Checked = false;
            OptPY.Checked = false;
            OptPN.Checked = false;
            OptAY.Checked = false;
            OptAN.Checked = false;
            OptFitY.Checked = false;
            OptFitN.Checked = false;
            OptSurgeryY.Checked = false;
            OptSurgeryN.Checked = false;
            OptSUsageY.Checked = false;
            OptSUsageN.Checked = false;
            TxtSer_TextChanged(null, null);
        }



        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                      
            if ( dataGridView1.SelectedRows[0].Cells[2].Value.ToString()=="A+" )
            {
                OptBloodAP.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "A-")
            {
                OptBloodAM.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "B+")
            {
                OptBloodBP.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "B-")
            {
                OptBloodBM.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "AB+")
            {
                OptBloodABP.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "AB-")
            {
                OptBloodABM.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "O+")
            {
                OptBloodOP.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "O-")
            {
                OptBloodOM.Checked = true;
            }
            else
            {

            }

            textDiabetic.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textPressure.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textAllergy.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textFit.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textSurgery.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textSUsage.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAOMI.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }
        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Emp_ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Blood Group";
            dataGridView1.Columns[3].HeaderText = "Diabetic";
            dataGridView1.Columns[4].HeaderText = "Pressure";
            dataGridView1.Columns[5].HeaderText = "Allergy";
            dataGridView1.Columns[6].HeaderText = "Fits";
            dataGridView1.Columns[7].HeaderText = "Surgery";
            dataGridView1.Columns[8].HeaderText = "Spectacle";

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;


            dataGridView1.Columns[9].Visible = false;
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
                con.Close();
                MessageBox.Show("ERROR CODE : COM-LST-118-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmMedicalInfo()
        {
            InitializeComponent();
        }

        private void FrmMedicalInfo_Load(object sender, EventArgs e)
        {
            ComList();
            TxtSer_TextChanged(null, null);

        }


        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
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
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == comEmpID.Text)
                            {
                                string txt = "SELECT * FROM [MedicalInfo] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        txtEmpName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : COM-KDW-179-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmMedicalInformationRep FMedicalInformationrep = new FrmMedicalInformationRep();
            FMedicalInformationrep.Show();


        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                string Blood_Group;              

                if(OptBloodAP.Checked)
                {
                    Blood_Group = OptBloodAP.Text;
                }
                else if (OptBloodAM.Checked)
                {
                    Blood_Group = OptBloodAM.Text;
                }
                else if (OptBloodBP.Checked)
                {
                    Blood_Group = OptBloodBP.Text;
                }
                else if (OptBloodBM.Checked)
                {
                    Blood_Group = OptBloodBM.Text;
                }
                else if (OptBloodABP.Checked)
                {
                    Blood_Group = OptBloodABP.Text;
                }
                else if (OptBloodABM.Checked)
                {
                    Blood_Group = OptBloodABM.Text;
                }
                else if (OptBloodOP.Checked)
                {
                    Blood_Group = OptBloodOP.Text;
                }
                else if (OptBloodOM.Checked)
                {
                    Blood_Group = OptBloodOM.Text;
                }
                else
                {

                }
                */

                SqlCommand cmd = new SqlCommand("Insert into MedicalInfo values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + txtBG.Text + "', '" + textDiabetic.Text + "', '" + textPressure.Text + "', '" + textAllergy.Text + "', '" + textFit.Text + "', '" + textSurgery.Text + "', '" + textSUsage.Text + "', '" + txtAOMI.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Successfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
            }
            catch (Exception x)
            {
                con.Close();
                MessageBox.Show("ERROR CODE : CMD-SAV-214-MEI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Edit()
        {
            groupBox1.Enabled = true;
            cmdEdit.Text = "UPDATE";
        }
           
        private void Modify()
        {
            try
            {

                /*
                String Blood_Group;

                if (OptBloodAP.Checked)
                {
                    Blood_Group = OptBloodAP.Text;
                }
                else if (OptBloodAM.Checked)
                {
                    Blood_Group = OptBloodAM.Text;
                }
                else if (OptBloodBP.Checked)
                {
                    Blood_Group = OptBloodBP.Text;
                }
                else if (OptBloodBM.Checked)
                {
                    Blood_Group = OptBloodBM.Text;
                }
                else if (OptBloodABP.Checked)
                {
                    Blood_Group = OptBloodABP.Text;
                }
                else if (OptBloodABM.Checked)
                {
                    Blood_Group = OptBloodABM.Text;
                }
                else if (OptBloodOP.Checked)
                {
                    Blood_Group = OptBloodOP.Text;
                }
                else if (OptBloodOM.Checked)
                {
                    Blood_Group = OptBloodOM.Text;
                }
                else
                {

                }
                */

                SqlCommand cmd = new SqlCommand("Update MedicalInfo SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', BGroup='" + txtBG.Text + "', Diabetic='" + textDiabetic.Text + "', Pressure='" + textPressure.Text + "', Allergy='" + textAllergy.Text + "', Filts='" + textFit.Text + "', Surgery='" + textSurgery.Text + "', SUsage='" + textSUsage.Text + "', AOMI='" + txtAOMI.Text
                    + "' WHERE EmpID='" + comEmpID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
                cmdEdit.Text = "EDIT";
                groupBox1.Enabled = true;

            }

            catch (Exception x)
            {          
                MessageBox.Show("ERROR CODE : CMD-UPD-236-MEI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string txt = "DELETE FROM [MedicalInfo] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
                MessageBox.Show("ERROR CODE : CMD-DEL-263-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from MedicalInfo where EmpID Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or BGroup Like '%" + TxtSer.Text + "%' or Diabetic Like '%" + TxtSer.Text + "%' or Pressure Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                //comBank.Items.Clear();
                //comAccNo.Items.Clear();
                //comBranch.Items.Clear();
                //comTOA.Items.Clear();
                //foreach (DataRow dr in dt.Rows)
                //{
                //    comBank.Items.Add(dr["BankName"].ToString());
                //    comAccNo.Items.Add(dr["AccNo"].ToString());
                //    comBranch.Items.Add(dr["Branch"].ToString());
                //    comTOA.Items.Add(dr["TOA"].ToString());
                //}
                    con.Close();
            }
            catch (Exception x)
            {
                con.Close();
                MessageBox.Show("ERROR CODE : TXT-SER-301-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        groupBox1.Enabled = false;
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
                        panel4.Focus();
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
                    con.Close();
                    MessageBox.Show("ERROR CODE : COM-KDW-342-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    panel4.Focus();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [MedicalInfo] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                cmdEdit.Text = "EDIT";

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-379-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMedicalInfo_Load_1(object sender, EventArgs e)
        {
            ComList();
            Blank();         
        }


        private void OptBloodAP_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "A+";
        }

        private void OptBloodAM_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "A-";
        }

        private void OptBloodBP_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "B+";
        }

        private void OptBloodBM_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "B-";
        }

        private void OptBloodABP_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "AB+";
        }

        private void OptBloodABM_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "AB-";
        }

        private void OptBloodOP_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "O+";
        }

        private void OptBloodOM_CheckedChanged(object sender, EventArgs e)
        {
            txtBG.Text = "O-";
        }

        private void OptDY_CheckedChanged(object sender, EventArgs e)
        {
            textDiabetic.Text = "Yes";
        }

        private void OptDN_CheckedChanged(object sender, EventArgs e)
        {
            textDiabetic.Text = "No";

        }

        private void OptPY_CheckedChanged(object sender, EventArgs e)
        {
            textPressure.Text = "Yes";

        }

        private void OptPN_CheckedChanged(object sender, EventArgs e)
        {
            textPressure.Text = "No";

        }

        private void OptAY_CheckedChanged(object sender, EventArgs e)
        {
            textAllergy.Text = "Yes";

        }

        private void OptAN_CheckedChanged(object sender, EventArgs e)
        {
            textAllergy.Text = "No";
        }

       
        private void OptSurgeryY_CheckedChanged(object sender, EventArgs e)
        {
            textSurgery.Text = "Yes";

        }

        private void OptSurgeryN_CheckedChanged(object sender, EventArgs e)
        {
            textSurgery.Text = "No";

        }

        private void OptSUsageY_CheckedChanged(object sender, EventArgs e)
        {
            textSUsage.Text = "Yes";

        }

        private void OptSUsageN_CheckedChanged(object sender, EventArgs e)
        {
            textSUsage.Text = "No";
        }

        private void OptFitY_CheckedChanged(object sender, EventArgs e)
        {
            textFit.Text = "Yes";
        }

        private void OptFitN_CheckedChanged(object sender, EventArgs e)
        {
            textFit.Text = "No";
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
            }
            else
            {

            }

            rdr.Close();
            con.Close();


            groupBox1.Enabled = true;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from MedicalInfo where EmpID='" + comEmpID.Text.Trim() + "' ", con);
            cmd2.Connection = con;
            rdr = cmd2.ExecuteReader();

            if (rdr.Read())
            {
                cmdEdit.Enabled = true;
                cmdEdit.Text = "EDIT";
                txtEmpName.Text = rdr["EmpName"].ToString();
                txtBG.Text = rdr["BGroup"].ToString();

                if (txtBG.Text == "A+")
                {
                    OptBloodAP.Checked = true;
                }
                else if (txtBG.Text == "A-")
                {
                    OptBloodAM.Checked = true;
                }
                else if (txtBG.Text == "B+")
                {
                    OptBloodBP.Checked = true;
                }
                else if (txtBG.Text == "B-")
                {
                    OptBloodBM.Checked = true;
                }
                else if (txtBG.Text == "AB+")
                {
                    OptBloodABP.Checked = true;
                }
                else if (txtBG.Text == "AB-")
                {
                    OptBloodABM.Checked = true;
                }
                else if (txtBG.Text == "O+")
                {
                    OptBloodOP.Checked = true;
                }
                else if (txtBG.Text == "O-")
                {
                    OptBloodOM.Checked = true;
                }
                else
                {

                }

                textDiabetic.Text = rdr["Diabetic"].ToString();
                textPressure.Text = rdr["Pressure"].ToString();
                textAllergy.Text = rdr["Allergy"].ToString();
                textFit.Text = rdr["Filts"].ToString();
                textSurgery.Text = rdr["Surgery"].ToString();
                textSUsage.Text = rdr["SUsage"].ToString();
                txtAOMI.Text = rdr["AOMI"].ToString();

                if (textDiabetic.Text == "Yes")
                {
                    OptDY.Checked = true;
                }
                else
                {
                    OptDN.Checked = true;
                }

                if (textPressure.Text == "Yes")
                {
                    OptPY.Checked = true;
                }
                else
                {
                    OptPN.Checked = true;
                }

                if (textAllergy.Text == "Yes")
                {
                    OptAY.Checked = true;
                }
                else
                {
                    OptAN.Checked = true;
                }

                if (textFit.Text == "Yes")
                {
                    OptFitY.Checked = true;
                }
                else
                {
                    OptFitN.Checked = true;
                }

                if (textSurgery.Text == "Yes")
                {
                    OptSurgeryY.Checked = true;
                }
                else
                {
                    OptSurgeryN.Checked = true;
                }

                if (textSUsage.Text == "Yes")
                {
                    OptSUsageY.Checked = true;
                }
                else
                {
                    OptSUsageN.Checked = true;
                }

                groupBox1.Enabled = false;
            }

            else
            {
                cmdEdit.Text = "EDIT";
                cmdEdit.Enabled = false;

                groupBox1.Enabled = true;

                OptBloodAP.Checked = false;
                OptBloodAM.Checked = false;
                OptBloodBP.Checked = false;
                OptBloodBM.Checked = false;
                OptBloodABP.Checked = false;
                OptBloodABM.Checked = false;
                OptBloodOP.Checked = false;
                OptBloodOM.Checked = false;

                OptDY.Checked = false;
                OptDN.Checked = false;
                OptPY.Checked = false;
                OptPN.Checked = false;
                OptAY.Checked = false;
                OptAN.Checked = false;
                OptFitY.Checked = false;
                OptFitN.Checked = false;
                OptSurgeryY.Checked = false;
                OptSurgeryN.Checked = false;
                OptSUsageY.Checked = false;
                OptSUsageN.Checked = false;

                txtEmpName.Text = "";
                txtBG.Text = "";
                textDiabetic.Text = "";
                textPressure.Text = "";
                textAllergy.Text = "";
                textFit.Text = "";
                textSurgery.Text = "";
                textSUsage.Text = "";
                txtAOMI.Text = "";
            }

            rdr.Close();
            con.Close();
            panel4.Focus();

            
          
        }
    }
}






