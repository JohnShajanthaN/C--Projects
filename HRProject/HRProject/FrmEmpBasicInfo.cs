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
    public partial class FrmEmpBasicInfo : Form
    {
        int count = 0;
        int found1 = 0;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
           //comEmpID.Text = "";
            txtFName.Text = "";
            txtIName.Text = "";
            txtSName.Text = "";
            txtNIC.Text = "";
            txtEMail.Text = "";
            txtMOB.Text = "";
            txtTel.Text = "";
            txtPAddress.Text = "";
            txtTAddress.Text = "";
            comGender.Text = "";
            dtpDOB.Text ="";
            dtpJDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comDes.Text = "";
            comCSta.Text = "";
            chkS.Checked = false;
            chkT.Checked = false;
            chkE.Checked = false;
            txtLanguages.Text = "";
            PicImg.Image =Image.FromFile("user.png");
            //PicLeft.Image = Image.FromFile("left1.png");
            //PicRight.Image = Image.FromFile("right1.png");
            TxtSer_TextChanged(null, null);
        }
        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtIName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtNIC.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtEMail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtMOB.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtTel.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtPAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtTAddress.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            comGender.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            dtpJDate.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[12].Value);
            comDes.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            comCSta.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            txtLanguages.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            //dataGridView1.Columns[0].HeaderText = " ID";
            dataGridView1.Columns[3].HeaderText = " Name with Initial";
            dataGridView1.Columns[13].HeaderText = " Designation";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[10].Width = 70;
            dataGridView1.Columns[13].Width = 130;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            //dataGridView1.Columns[17].Visible = false;
            //dataGridView1.Columns[18].Visible = false;
        }
        public FrmEmpBasicInfo()
        {
            InitializeComponent();
        }

        private void FrmEmpBasicInfo_Load(object sender, EventArgs e)
        {
            TxtSer_TextChanged(null, null);
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [EMPBasic] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
                MessageBox.Show("ERROR CODE : CMD-DEL-130-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];

                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                SqlCommand cmd = new SqlCommand("Insert into EMPBasic(EMPID, FName, SName, IName, NIC, EMail, Mob, Tel, PAddress, TAddress, Gender, DOB, JDate, Des, CSta, Languages, IImg) values('"
                    + comEmpID.Text + "', '" + txtFName.Text + "', '" + txtSName.Text + "', '" + txtIName.Text + "', '" + txtNIC.Text + "', '" + txtEMail.Text + "', '" + txtMOB.Text + "', '" + txtTel.Text + "', '" + txtPAddress.Text + "', '" + txtTAddress.Text + "', '" + comGender.Text + "', '" + dtpDOB.Text + "', '" + dtpJDate.Value.ToString() + "', '" + comDes.Text + "', '" + comCSta.Text + "', '" + txtLanguages.Text + "', @photo)", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
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
                MessageBox.Show("ERROR CODE : CMD-ADD-158-EBI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from EMPBasic where EMPID Like '%" + TxtSer.Text + "%' or FName Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                //comCSta.Items.Clear();
                comDes.Items.Clear();
                comEmpID.Items.Clear();
                //comGender.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                   // comCSta.Items.Add(dr["CSta"].ToString());
                    comDes.Items.Add(dr["Des"].ToString());
                    comEmpID.Items.Add(dr["EmpID"].ToString());
                   // comGender.Items.Add(dr["Gender"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : Txt-SER-196-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               
                PicImg.Image = Image.FromFile("user.png");
                string txt = "SELECT * FROM [EMPBASIC] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                MemoryStream ms = new MemoryStream(Photo);
                PicImg.Image = Image.FromStream(ms);

                txtFName.Enabled = false;
                txtSName.Enabled = false;
                txtIName.Enabled = false;
                txtNIC.Enabled = false;
                txtEMail.Enabled = false;
                txtMOB.Enabled = false;
                txtPAddress.Enabled = false;
                txtTel.Enabled = false;
                comGender.Enabled = false;
                txtTAddress.Enabled = false;
                dtpDOB.Enabled = false;
                dtpJDate.Enabled = false;
                comDes.Enabled = false;
                comCSta.Enabled = false;
                txtLanguages.Enabled = false;
                PicImg.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtsname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtIName.Focus();
                }
            }

        }

        private void txtNWI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtNIC.Focus();
                }
            }
        }

        private void Edit()
        {         
            cmdEdit.Text = "UPDATE";         

            txtFName.Enabled = true;
            txtSName.Enabled = true;
            txtIName.Enabled = true;
            txtNIC.Enabled = true;
            txtEMail.Enabled = true;
            txtMOB.Enabled = true;
            txtPAddress.Enabled = true;
            txtTel.Enabled = true;
            comGender.Enabled = true;
            txtTAddress.Enabled = true;
            dtpDOB.Enabled = true;
            dtpJDate.Enabled = true;
            comDes.Enabled = true;
            comCSta.Enabled = true;
            txtLanguages.Enabled = true;
            PicImg.Enabled = true;
            chkS.Enabled = true;
            chkT.Enabled = true;
            chkE.Enabled = true;
        }

        private void Modify()
        {
            try

            {
                MemoryStream ms = new MemoryStream();
                PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];

                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                SqlCommand cmd = new SqlCommand("Update empbasic SET EmpID='" + comEmpID.Text + "', FName='" + txtFName.Text + "', SName='" + txtSName.Text + "', IName='" + txtIName.Text + "', NIC='" + txtNIC.Text + "', EMail='" + txtEMail.Text + "', Mob='" + txtMOB.Text + "', Tel='" + txtTel.Text + "', PAddress='" + txtPAddress.Text + "', TAddress='" + txtTAddress.Text + "', Gender='" + comGender.Text + "', DOB='" + dtpDOB.Text + "', JDate='" + dtpJDate.Value.ToString() + "', Des='" + comDes.Text + "', CSta='" + comCSta.Text + "', Languages='" + txtLanguages.Text
                    + "', IImg=@photo WHERE EmpID='" + comEmpID.Text + "'", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
                cmdEdit.Text = "EDIT";

            }

            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-305-EBI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTel.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTel.Text = txtTel.Text.Remove(txtTel.Text.Length - 1);
            }
        }

        private void dtpJDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmBasicInformationRep FBasicInformationRep = new FrmBasicInformationRep();
            FBasicInformationRep.Show();
        }

        private void comEmpID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comEmpID.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == comEmpID.Text)
                            {
                                string txt = "SELECT * FROM [EMPBasic] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                                MemoryStream ms = new MemoryStream(Photo);
                                PicImg.Image = Image.FromStream(ms);
                            }
                        }
                        txtFName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : BCD-KDW-236-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSName.Focus();
                }
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PicImg.Image = Image.FromFile(fd.FileName);
                cmdAdd.Focus();
            }
        }

        private void cmdLBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PicLeft.Image = Image.FromFile(fd.FileName);
            }
        }

        private void cmdRBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PicRight.Image = Image.FromFile(fd.FileName);
            }
        }

        private void comCSta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCSta.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkS.Focus();
                    chkS.BackColor = Color.Teal;
                }
            }
        }

        private void txtMOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMOB.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTel.Focus();
                }
            }
        }

        private void chkS_Click(object sender, EventArgs e)
        {
            if(chkS.Checked ==true)
            {
                if(txtLanguages.Text.Contains("Sinhala"))
                {
                    txtLanguages.Text = txtLanguages.Text;
                }
                else
                {
                    txtLanguages.Text = txtLanguages.Text + "Sinhala ";
                }              
            }

            else
            {
                if (chkS.Checked == true)
                {
                    if (txtLanguages.Text.Contains("Sinhala"))
                    {
                        txtLanguages.Text = txtLanguages.Text;
                    }
                    else
                    {
                        txtLanguages.Text = txtLanguages.Text + "Sinhala ";
                    }
                }
            }

            
        }

        private void txtEMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEMail.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(txtEMail.Text.Contains("@"))
                    { 
                        txtMOB.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Please Enter the Valid Email Address!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

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
                    txtPAddress.Focus();
                }
            }
        }

        private void txtPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPAddress.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTAddress.Focus();
                }
            }
        }

        private void txtTAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTAddress.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpJDate.Focus();
                }
            }
        }

        private void comGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGender.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpDOB.Focus();
                }
            }
        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtpDOB.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpJDate.Focus();
                }
            }
        }

        private void dtpJDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtpJDate.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comDes.Focus();
                }
            }
        }

        private void comDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comCSta.Focus();
                }
            }
        }

        private void chkS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkS.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkT.Focus();
                    chkS.BackColor = Color.AliceBlue;
                    chkT.BackColor = Color.Teal;
                }
            }
        }

        private void chkT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkT.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkE.Focus();
                    chkT.BackColor = Color.AliceBlue;
                    chkE.BackColor = Color.Teal;
                }
            }
        }

        private void chkE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkE.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkE.BackColor = Color.AliceBlue;
                    txtLanguages.Focus();
                }
            }
        }

        private void txtLanguages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLanguages.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdBrowse.Focus();
                }
            }
        }

        private void chkT_Click(object sender, EventArgs e)
        {
            if (chkT.Checked == true)
            {
                if (txtLanguages.Text.Contains("Tamil"))
                {
                    txtLanguages.Text = txtLanguages.Text;
                }
                else
                {
                    txtLanguages.Text = txtLanguages.Text + "Tamil ";
                }
            }

            else
            {
                if (chkE.Checked == true)
                {
                    if (txtLanguages.Text.Contains("English"))
                    {
                        txtLanguages.Text = txtLanguages.Text;
                    }
                    else
                    {
                        txtLanguages.Text = txtLanguages.Text + "English ";
                    }
                }

                else
                {

                }
            }

        }

        private void chkE_Click(object sender, EventArgs e)
        {
            if (chkE.Checked == true)
            {
                if (txtLanguages.Text.Contains("English"))
                {
                    txtLanguages.Text = txtLanguages.Text;
                }
                else
                {
                    txtLanguages.Text = txtLanguages.Text + "English ";
                }
            }

            else
            {

            }

        }

        private void chkT_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;           
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txtNIC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    if (txtNIC.Text == "")
                    {
                        MessageBox.Show("Please Enter NIC Number!", "NIC Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comGender.Text = "";
                        dtpDOB.Text = "";
                        //txtAge.Text = "";
                    }

                    else
                    {
                        string nic = txtNIC.Text;
                        int len = nic.Length;
                        int chkdig = Convert.ToInt32(nic.Substring(2, 3));
                        int chkdig1 = Convert.ToInt32(nic.Substring(4, 3));

                        if (len == 10 || len == 12)
                        {
                            if (len == 10 && (nic.Substring(9, 1) == "v" || nic.Substring(9, 1) == "V" || nic.Substring(9, 1) == "x" || nic.Substring(9, 1) == "X") && (chkdig < 367 || (500 < chkdig && chkdig < 867)))
                            {
                                cal_year();
                                cal_gender();
                                cal_month();
                                //cal_age();
                                txtEMail.Focus();
                            }
                            else
                            {
                                if (len == 12 && (chkdig1 < 367 || (500 < chkdig1 && chkdig1 < 867)))
                                {
                                    cal_year();
                                    cal_gender();
                                    cal_month();
                                    // cal_age();
                                    txtEMail.Focus();
                                }

                                else
                                {
                                    MessageBox.Show("Please Enter Correct NIC Format!", "Invalid NIC Format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid NIC Number.The New format NIC Number should be 12 Digits & OLD format NIC Number should be 10 Char", "Invalid NIC Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }

                }

            }

            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : 000000000V-000000000X-000000000000" + "\n" + "MORE DETAILS :- Please Contact Admin For further Clarifications!!" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIC.Text = "";
                con.Close();
            }
        }


        private void cal_year()
        {
            string nic = txtNIC.Text;
            int len = nic.Length;
            int year;

            if (len == 10)
            {
                year = 1900 + Convert.ToInt32(nic.Substring(0, 2));
                dtpDOB.Text = year.ToString();
            }
            else
            {
                year = Convert.ToInt32(nic.Substring(0, 4));
                dtpDOB.Text = year.ToString();
            }
        }

        /*
        private void cal_age()
        {
            string nic = txtNIC.Text;
            int len = nic.Length;
            int age, year;

            if (len == 10)
            {
                year = 1900 + Convert.ToInt32(nic.Substring(0, 2));
                age = DateTime.Now.Year - year;
               // txtAge.Text = age.ToString();
            }
            else
            {
                year = Convert.ToInt32(nic.Substring(0, 4));
                age = DateTime.Now.Year - year;
               // txtAge.Text = age.ToString();
            }
        }
        */

        private void cal_month()
        {
            string nic = txtNIC.Text;
            int len = nic.Length;
            int chkdig = Convert.ToInt32(nic.Substring(2, 3));
            int chkdig1 = Convert.ToInt32(nic.Substring(4, 3));
            int month;
            int date;

            /*31 29 31 30 31 30 31 31 30 31 30 31 
                31 60 91 121 152 182 213 244 274 305 335 366 */

            if (len == 10)
            {
                if (chkdig < 367)
                {
                    if (chkdig < 32)
                    {
                        month = 01;
                        date = chkdig;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 61)
                    {
                        month = 02;
                        date = chkdig - 31;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 92)
                    {
                        month = 03;
                        date = chkdig - 60;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 122)
                    {
                        month = 04;
                        date = chkdig - 91;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 153)
                    {
                        month = 05;
                        date = chkdig - 121;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 183)
                    {
                        month = 06;
                        date = chkdig - 152;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 214)
                    {
                        month = 07;
                        date = chkdig - 182;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 245)
                    {
                        month = 08;
                        date = chkdig - 213;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 275)
                    {
                        month = 09;
                        date = chkdig - 244;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 306)
                    {
                        month = 10;
                        date = chkdig - 274;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 336)
                    {
                        month = 11;
                        date = chkdig - 305;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig < 367)
                    {
                        month = 12;
                        date = chkdig - 335;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                }

                else
                {
                    if ((chkdig - 500) < 32)
                    {
                        month = 01;
                        date = chkdig - 500;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 61)
                    {
                        month = 02;
                        date = chkdig - 500 - 31;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 92)
                    {
                        month = 03;
                        date = chkdig - 500 - 60;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 122)
                    {
                        month = 04;
                        date = chkdig - 500 - 91;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 153)
                    {
                        month = 05;
                        date = chkdig - 500 - 121;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 183)
                    {
                        month = 06;
                        date = chkdig - 500 - 152;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 214)
                    {
                        month = 07;
                        date = chkdig - 182;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 245)
                    {
                        month = 08;
                        date = chkdig - 500 - 213;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 275)
                    {
                        month = 09;
                        date = chkdig - 500 - 244;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 306)
                    {
                        month = 10;
                        date = chkdig - 500 - 274;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 336)
                    {
                        month = 11;
                        date = chkdig - 500 - 305;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 367)
                    {
                        month = 12;
                        date = chkdig - 500 - 335;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                }
            }

            else
            {
                if (chkdig1 < 367)
                {
                    if (chkdig1 < 32)
                    {
                        month = 01;
                        date = chkdig1;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 61)
                    {
                        month = 02;
                        date = chkdig1 - 31;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 92)
                    {
                        month = 03;
                        date = chkdig1 - 60;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 122)
                    {
                        month = 04;
                        date = chkdig1 - 91;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 153)
                    {
                        month = 05;
                        date = chkdig1 - 121;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 183)
                    {
                        month = 06;
                        date = chkdig1 - 152;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 214)
                    {
                        month = 07;
                        date = chkdig1 - 182;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 245)
                    {
                        month = 08;
                        date = chkdig1 - 213;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 275)
                    {
                        month = 09;
                        date = chkdig1 - 244;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 306)
                    {
                        month = 10;
                        date = chkdig1 - 274;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 336)
                    {
                        month = 11;
                        date = chkdig1 - 305;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if (chkdig1 < 367)
                    {
                        month = 12;
                        date = chkdig1 - 335;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                }

                else
                {
                    if ((chkdig1 - 500) < 32)
                    {
                        month = 01;
                        date = chkdig1;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 61)
                    {
                        month = 02;
                        date = chkdig1 - 500 - 31;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 92)
                    {
                        month = 03;
                        date = chkdig1 - 500 - 60;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 122)
                    {
                        month = 04;
                        date = chkdig1 - 500 - 91;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 153)
                    {
                        month = 05;
                        date = chkdig1 - 500 - 121;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig - 500) < 183)
                    {
                        month = 06;
                        date = chkdig1 - 500 - 152;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 214)
                    {
                        month = 07;
                        date = chkdig1 - 500 - 182;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 245)
                    {
                        month = 08;
                        date = chkdig1 - 500 - 213;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 275)
                    {
                        month = 09;
                        date = chkdig1 - 500 - 244;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 306)
                    {
                        month = 10;
                        date = chkdig1 - 500 - 274;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 336)
                    {
                        month = 11;
                        date = chkdig1 - 500 - 305;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                    else if ((chkdig1 - 500) < 367)
                    {
                        month = 12;
                        date = chkdig1 - 500 - 335;
                        dtpDOB.Text = dtpDOB.Text + "-" + month + "-" + date;
                    }
                }
            }
        }



        private void cal_gender()
        {
            string nic = txtNIC.Text;
            int len = nic.Length;
            int chkdig = Convert.ToInt32(nic.Substring(2, 3));
            int chkdig1 = Convert.ToInt32(nic.Substring(4, 3));
            string gen;

            if (len == 10)
            {
                if (chkdig < 367)
                {
                    gen = "Male";
                    comGender.Text = gen;
                }
                else
                {
                    gen = "Female";
                    comGender.Text = gen;
                }
            }
            else
            {
                if (chkdig1 < 367)
                {
                    gen = "Male";
                    comGender.Text = gen;
                }
                else
                {
                    gen = "Female";
                    comGender.Text = gen;
                }
            }
        }

        private void chkS_CheckedChanged(object sender, EventArgs e)
        {            
            
        }

        private void chkE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdBrowse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    cmdAdd.Focus();
            }
        }

        private void txtMOB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMOB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only numbers!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMOB.Text = txtMOB.Text.Remove(txtMOB.Text.Length - 1);
            }
        }

        private void comCSta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blank();
            Refresh();
            groupBox1.Enabled = true;
            cmdEdit.Text = "EDIT";
            comEmpID.Enabled = true;        

            txtFName.Enabled = true;
            txtSName.Enabled = true;
            txtIName.Enabled = true;
            txtNIC.Enabled = true;
            txtEMail.Enabled = true;
            txtMOB.Enabled = true;
            txtPAddress.Enabled = true;
            txtTel.Enabled = true;
            comGender.Enabled = true;
            txtTAddress.Enabled = true;
            dtpDOB.Enabled = true;
            dtpJDate.Enabled = true;
            comDes.Enabled = true;
            comCSta.Enabled = true;
            txtLanguages.Enabled = true;
            PicImg.Enabled = true;
        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLanguages_TextChanged(object sender, EventArgs e)
        {

        }

        private void comEmpID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from EMPBasic where EMPID='" + comEmpID.Text.Trim() + "' ", con);
            cmd3.Connection = con;
            SqlDataReader rdr = cmd3.ExecuteReader();

            if (rdr.Read())
            {
                txtFName.Text = rdr["FName"].ToString();
                txtSName.Text = rdr["SName"].ToString();
                txtIName.Text = rdr["IName"].ToString();
                txtNIC.Text = rdr["NIC"].ToString();
                txtEMail.Text = rdr["EMail"].ToString();
                txtMOB.Text = rdr["Mob"].ToString();
                txtPAddress.Text = rdr["PAddress"].ToString();
                txtTel.Text = rdr["Tel"].ToString();
                comGender.Text = rdr["Gender"].ToString();
                txtTAddress.Text = rdr["TAddress"].ToString();
                dtpDOB.Text = rdr["DOB"].ToString();
                dtpJDate.Text = rdr["JDate"].ToString();
                comDes.Text = rdr["Des"].ToString();
                comCSta.Text = rdr["CSta"].ToString();
                txtLanguages.Text = rdr["Languages"].ToString();

                
                //PicImg.Image= rdr["IImg"];

                txtFName.Enabled=false;
                txtSName.Enabled = false;
                txtIName.Enabled = false;
                txtNIC.Enabled = false;
                txtEMail.Enabled = false;
                txtMOB.Enabled = false;
                txtPAddress.Enabled = false;
                txtTel.Enabled = false;
                comGender.Enabled = false;
                txtTAddress.Enabled = false;
                dtpDOB.Enabled = false;
                dtpJDate.Enabled = false;
                comDes.Enabled = false;
                comCSta.Enabled = false;
                txtLanguages.Enabled = false;
                PicImg.Enabled = false;
                chkS.Enabled = false;
                chkT.Enabled = false;
                chkE.Enabled = false;

                cmdEdit.Text = "EDIT";
            }

            else
            {
                comEmpID.Focus();
            }

            rdr.Close();
            con.Close();

            /*
            try
            {
                if (comEmpID.Text == "")
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
                        if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == comEmpID.Text)
                        {
                            string txt = "SELECT * FROM [EMPBasic] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                            SqlDataAdapter da = new SqlDataAdapter(txt, con);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            found1 = 1;
                            fromDGView();
                            byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                            MemoryStream ms = new MemoryStream(Photo);
                            PicImg.Image = Image.FromStream(ms);
                        }
                    }
                    txtFName.Focus();
                    if (found1 == 0)
                    {
                        Blank();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : BCD-KDW-236-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
