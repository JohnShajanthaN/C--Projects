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

namespace Dewmas_Job_Bank
{
    public partial class FrmStaffRegistration : Form
    {

        int count = 0;
        int found1 = 0;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=Dewmas;Integrated Security=True");
        private void Blank()
        {
            comStfID.Text = "";
            txtFName.Text = "";
            txtNIC.Text = "";
            comCat.Text = "";
            txtEMail.Text = "";
            txtMOB.Text = "";
            txtTel.Text = "";
            txtPAddress.Text = "";
            txtTAddress.Text = "";
            dtpDOB.Text ="";
            txtAge.Text = "";
            comCSta.Text = "";
            comRel.Text = "";
            comNat.Text = "";
            dtpJDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtGen.Text = "";
            txtOL.Text = "";
            txtAL.Text = "";
            comPro.Text = "";
            txtWrkExp.Text = "";
            txtDes.Text = "";
            comWrkDet.Text = "";
            txtSal.Text = "";
            PicImg.Image = Image.FromFile("user.png");
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                comStfID.Text = "DEW-STA-001";
            }

            else
            {
                SqlCommand cmd1 = new SqlCommand("SELECT TOP(1) StfID FROM StfReg ORDER BY 1 DESC", con);
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();

                reader.Read();

                string ID = reader["StfID"].ToString().Substring(8, 3);
                int ID1 = Convert.ToInt32(ID);
                ID1++;
                comStfID.Text = "DEW-STA-" + ID1.ToString("000");

                con.Close();
                reader.Close();
            }

        }
        private void fromDGView()
        {
            comStfID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtNIC.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comCat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtMOB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtTel.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEMail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString(); 
            txtPAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtTAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtGen.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            comCSta.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            comRel.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            comNat.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            dtpJDate.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[15].Value);
            txtOL.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            txtAL.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            comPro.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
            txtWrkExp.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
            txtDes.Text = dataGridView1.SelectedRows[0].Cells[20].Value.ToString();
            comWrkDet.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
            txtSal.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
            
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Staff ID";
            dataGridView1.Columns[1].HeaderText = "Full Name";
            dataGridView1.Columns[2].HeaderText = "NIC";
            dataGridView1.Columns[3].HeaderText = "Staff Category";
            dataGridView1.Columns[4].HeaderText = "Mobile No";
            dataGridView1.Columns[9].HeaderText = "Gender";
            dataGridView1.Columns[23].HeaderText = "Image";


            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[23].Width = 150;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;

        }

        public FrmStaffRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Blank();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtIName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtMOB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMOB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMOB.Text = txtMOB.Text.Remove(txtMOB.Text.Length - 1);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTel.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTel.Text = txtTel.Text.Remove(txtTel.Text.Length - 1);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dtpJDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comCSta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void comCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("Insert into StfReg values ('"
                    + comStfID.Text + "', '" + txtFName.Text + "', '" + txtNIC.Text + "', '" + comCat.Text + "', '" + txtMOB.Text + "', '" + txtTel.Text + "', '" + txtEMail.Text + "', '" + txtPAddress.Text + "', '" + txtTAddress.Text + "', '" + txtGen.Text + "', '" + dtpDOB.Text + "' ,'" + txtAge.Text + "', '" + comCSta.Text + "', '" + comRel.Text + "', '" + comNat.Text + "', '" + dtpJDate.Value.ToString() + "', '" + txtOL.Text + "', '" + txtAL.Text + "','" + comPro.Text + "','" + txtWrkExp.Text + "','" + txtDes.Text + "','" + comWrkDet.Text + "','" + txtSal.Text + "',@photo)", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); 

                MessageBox.Show("Record Added Successfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comStfID.Text = "";
                Blank();
                comStfID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-ADD-158-EBI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
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

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from StfReg where StfID Like '%" + TxtSer.Text + "%' or FName Like '%" + TxtSer.Text + "%' or NIC Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                //comCSta.Items.Clear();
                comStfID.Items.Clear();
                comWrkDet.Items.Clear();
                comPro.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    // comCSta.Items.Add(dr["CSta"].ToString());
                    comStfID.Items.Add(dr["StfID"].ToString());
                    comWrkDet.Items.Add(dr["WorkDet"].ToString());
                    comPro.Items.Add(dr["ProQua"].ToString());
                    // comGender.Items.Add(dr["Gender"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : Txt-SER-196-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comStfID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comStfID.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtFName.Focus();
                }
            }
        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
            

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
                        txtGen.Text = "";
                        dtpDOB.Text = "";
                        txtAge.Text = "";
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
                                cal_age();
                                comCat.Focus();
                            }
                            else
                            {
                                if (len == 12 && (chkdig1 < 367 || (500 < chkdig1 && chkdig1 < 867)))
                                {
                                    cal_year();
                                    cal_gender();
                                    cal_month();
                                    cal_age();
                                    comCat.Focus();
                                }

                                else
                                {
                                    MessageBox.Show("Please Enter Correct NIC Format!", "Invalied NIC Format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            catch(Exception x)
            {
                MessageBox.Show("ERROR CODE : 000000000V-000000000X-000000000000"+ "\n" + "MORE DETAILS :- Please Contact Admin For further Clarifications!!" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIC.Text = "";
            }

        }

        private void cal_year()
        {
            string nic = txtNIC.Text;
            int len = nic.Length;
            int year;

            if (len==10)
            {
                year =1900+Convert.ToInt32(nic.Substring(0, 2));
                dtpDOB.Text = year.ToString();
            }
            else
            {
               year = Convert.ToInt32(nic.Substring(0, 4));
                dtpDOB.Text = year.ToString();
            }
        }

        private void cal_age()
        {
            string nic = txtNIC.Text;
            int len = nic.Length;
            int age,year; 

            if (len == 10)
            {
                year = 1900 + Convert.ToInt32(nic.Substring(0, 2));
                age = DateTime.Now.Year - year;
                txtAge.Text = age.ToString();
            }
            else
            {
                year = Convert.ToInt32(nic.Substring(0, 4));
                age = DateTime.Now.Year - year;
                txtAge.Text = age.ToString();
            }
        }

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
                        date = chkdig-31;
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
                    if ( (chkdig-500) < 32)
                    {
                        month = 01;
                        date = chkdig-500;
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

            if(len==10)
            {
                if(chkdig<367)
                {
                    gen = "Male";
                    txtGen.Text = gen;
                }
                else
                {
                    gen = "Female";
                    txtGen.Text = gen;
                }
            }
            else
            {
                if (chkdig1 < 367)
                {
                    gen = "Male";
                    txtGen.Text = gen;
                }
                else
                {
                    gen = "Female";
                    txtGen.Text = gen;
                }
            }
        }

        private void comCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCat.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMOB.Focus();
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
                    
                    int len = txtMOB.Text.Length;
                    
                    if (len == 10 && txtMOB.Text.StartsWith("0"))
                    {
                        txtEMail.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Valid Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int len = txtTel.Text.Length;

                    if (len == 10 && txtTel.Text.StartsWith("0") )
                    {
                        txtPAddress.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Valid Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                if (txtPAddress.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comCSta.Focus();
                }
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAge.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comCSta.Focus();
                }
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
                    comRel.Focus();
                }
            }
        }

        private void comRel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comRel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comNat.Focus();
                }
            }
        }

        private void comNat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comNat.Text == "")
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
                    txtOL.Focus();
                }
            }
        }

        private void txtOL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOL.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtAL.Focus();
                }
            }
        }

        private void txtAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAL.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comPro.Focus();
                }
            }
        }

        private void comPro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPro.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtWrkExp.Focus();
                }
            }
        }

        private void txtWrkExp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtWrkExp.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtDes.Focus();
                }
            }
        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comWrkDet.Focus();
                }
            }
        }

        private void comWrkDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comWrkDet.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSal.Focus();
                }
            }
        }

        private void txtSal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSal.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void cmdAdd_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];

                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                SqlCommand cmd = new SqlCommand("Update StfReg SET StfID='" + comStfID.Text + "', FName='" + txtFName.Text + "', NIC='" + txtNIC.Text + "', StfCat='" + comCat.Text + "', Mobile='" + txtMOB.Text + "', LandNo='" + txtTel.Text + "', Email='" + txtEMail.Text + "', PAddress='" + txtPAddress.Text + "', TAddress='" + txtTAddress.Text + "', Gender='" + txtGen.Text + "', DOB='" + dtpDOB.Text + "', Age='" + txtAge.Text + "', CivilSta='" + comCSta.Text + "', Religion='" + comRel.Text + "', Nationality='" + comNat.Text + "', JoinDate='" + dtpJDate.Text + "'" +
                    ", OL='" + txtOL.Text + "', AL='" + txtAL.Text + "', ProQua='" + comPro.Text + "', WorkExp='" + txtWrkExp.Text + "', Designation='" + txtDes.Text + "', WorkDet='" + comWrkDet.Text + "',Salary='" + txtSal.Text + "',Img=@photo WHERE StfID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comStfID.Text = "";
                Blank();
                comStfID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-305-EBI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {              
                PicImg.Image = Image.FromFile("user.png");
                string txt = "SELECT * FROM [StfReg] Where StfID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["Img"]);
                MemoryStream ms = new MemoryStream(Photo);
                PicImg.Image = Image.FromStream(ms);
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {              
                PicImg.Image = Image.FromFile("user.png");
                string txt = "SELECT * FROM [StfReg] Where StfID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["Img"]);
                MemoryStream ms = new MemoryStream(Photo);
                PicImg.Image = Image.FromStream(ms);
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [StfReg] Where [StfID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comStfID.Text = "";
                    Blank();
                    comStfID.Focus();
                }
                else
                {
                    comStfID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-130-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();      
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmStfPerInfoRep stfrep = new FrmStfPerInfoRep();
            stfrep.Show();
        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSal.Text = txtSal.Text.Remove(txtSal.Text.Length - 1);
            }
            */
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            Blank();
            txtFName.Focus();
        }
    }
}
