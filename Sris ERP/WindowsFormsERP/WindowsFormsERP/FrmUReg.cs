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
    public partial class FrmUReg : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        int kk = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtAge1.Text = "";
            txtCPassword.Text = "";
            txtFullName1.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtDes.Text = "";
            txtPlace.Text = "";     
            
            comGender1.Items.Clear();
            comUserLevel.Items.Clear();

            comGender1.Items.Add("Male");
            comGender1.Items.Add("Female");
            comUserLevel.Items.Add("Administrator");
            comUserLevel.Items.Add("Account Staff");
            comUserLevel.Items.Add("DataEntry Staff");
            comUserLevel.Items.Add("Sales Staff");
            // PicImg.Image = null;
            //grpPD11.Visible = false;
            //grpUD.Visible = true;
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                txtUserID.Text = "0001";
                txtUserName.Focus();
            }

            else
            {
                int q = 0;
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from UserDetails ", con);
                cmd2.Connection = con;

                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    if (q < Convert.ToInt32(rdr["UserID"]))
                    {
                        q = Convert.ToInt32(rdr["UserID"]);
                    }
                }
                con.Close();
                q = q + 1;
                txtUserID.Text = q.ToString("0000");
                txtUserName.Focus();
            }
        }

        private void fromDGView()
        {
            txtUserID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCPassword.Text = txtPassword.Text;
            comUserLevel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            txtFullName1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPlace.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtDes.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comGender1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAge1.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].HeaderText = "Usr_Lev";
            dataGridView1.Columns[5].HeaderText = "Fullname";
            dataGridView1.Columns[6].HeaderText = "Place";
            dataGridView1.Columns[7].HeaderText = "Desg";
            dataGridView1.Columns[8].HeaderText = "Gen";
            dataGridView1.Columns[9].HeaderText = "Age";

            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 80;
           // dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 40;
            dataGridView1.Columns[9].Width = 40;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
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
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;
            dataGridView1.Columns[32].Visible = false;
            dataGridView1.Columns[33].Visible = false;
            dataGridView1.Columns[34].Visible = false;
            dataGridView1.Columns[35].Visible = false;
        }
  

        public FrmUReg()
        {
            InitializeComponent();
        }

        private void lnklblPD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpPD11.Visible = true;
            grpUD.Visible = false;
            txtFullName1.Focus();
        }    

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(txtUserName.Text.Length<=10)
                    {
                        txtPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Username Length Should Be Below 10 Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Text = "";
                        txtUserName.Focus();
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter the Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPassword.Text.Length >=8 && txtPassword.Text.Length <= 15)
                    {
                        txtCPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Password Length Should Be Between 8 & 15!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtCPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPassword.Text == "")
                {
                    MessageBox.Show("Please Enter the Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPassword.Focus();
                }
                else
                {
                    if (txtCPassword.Text == txtPassword.Text)
                    {
                        comUserLevel.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Confirm Password Doesn't Match With Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);                     
                        txtCPassword.Text = ""; 
                        txtCPassword.Focus();
                    }
                }
            }
        }

        private void comUserLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comUserLevel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //grpPD11.Visible = true;
                    //grpUD.Visible = false;
                    txtFullName1.Focus();
                }
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGender.Focus();
                }
            }
        }

        private void comGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGender.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comGender.Text == "Male" || comGender.Text == "Female" || comGender.Text == "Custom")
                    {
                        txtAge.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Select from List Male or Female!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comGender.Text = "";
                    }
                }
            }
        }

        private void cmdBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PicImg.Image = Image.FromFile(fd.FileName);
            }
        }

        private void FrmUReg_Load(object sender, EventArgs e)
        {

            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            Blank();         
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void user_level()
        {
            //con.Open();
            //OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserName='" + comUID.Text.ToString() + "' ", con);
            //cmd1.Connection = con;
            //OleDbDataReader rdr = cmd1.ExecuteReader();

            //rdr.Read();
            //if (comUserLevel.Text == "Administrator")
            //{
              
            //}
            //else if (user_level == "SK Staff")
            //{
            //    treeView1.Nodes[0].Nodes[4].Checked = true;
            //    treeView1.Nodes[1].Checked = false;
            //    treeView1.Nodes[2].Checked = false;
            //    treeView1.Nodes[3].Checked = false;
            //    treeView1.Nodes[4].Checked = false;
            //    treeView1.Nodes[5].Checked = false;
            //    treeView1.Nodes[6].Checked = false;
            //    treeView1.Nodes[7].Checked = false;
            //    treeView1.Nodes[8].Checked = true;
            //    treeView1.Nodes[9].Checked = false;
            //    treeView1.Nodes[10].Checked = false;
            //    treeView1.Nodes[11].Checked = false;
            //    treeView1.Nodes[12].Checked = false;
            //    treeView1.Nodes[13].Checked = false;
            //    treeView1.Nodes[14].Checked = true;
            //}
            //else if (user_level == "Sales Staff")
            //{
            //    treeView1.Nodes[0].Nodes[4].Checked = false;
            //    treeView1.Nodes[1].Checked = true;
            //    treeView1.Nodes[2].Checked = false;
            //    treeView1.Nodes[3].Checked = true;
            //    treeView1.Nodes[4].Checked = true;
            //    treeView1.Nodes[5].Checked = false;
            //    treeView1.Nodes[6].Checked = false;
            //    treeView1.Nodes[7].Checked = false;
            //    treeView1.Nodes[8].Checked = false;
            //    treeView1.Nodes[9].Checked = true;
            //    treeView1.Nodes[10].Checked = false;
            //    treeView1.Nodes[11].Checked = false;
            //    treeView1.Nodes[12].Checked = false;
            //    treeView1.Nodes[13].Checked = false;
            //    treeView1.Nodes[14].Checked = true;
            //}
            //else if (user_level == "DataEntry Staff")
            //{
            //    treeView1.Nodes[0].Nodes[4].Checked = false;
            //    treeView1.Nodes[1].Checked = false;
            //    treeView1.Nodes[2].Checked = true;
            //    treeView1.Nodes[3].Checked = false;
            //    treeView1.Nodes[4].Checked = false;
            //    treeView1.Nodes[5].Checked = false;
            //    treeView1.Nodes[6].Checked = false;
            //    treeView1.Nodes[7].Checked = false;
            //    treeView1.Nodes[8].Checked = true;
            //    treeView1.Nodes[9].Checked = true;
            //    treeView1.Nodes[10].Checked = true;
            //    treeView1.Nodes[11].Checked = true;
            //    treeView1.Nodes[12].Checked = true;
            //    treeView1.Nodes[13].Checked = true;
            //    treeView1.Nodes[14].Checked = true;
            //}
            //else if (user_level == "Account Staff")
            //{
            //    treeView1.Nodes[0].Nodes[4].Checked = true;
            //    treeView1.Nodes[1].Checked = false;
            //    treeView1.Nodes[2].Checked = false;
            //    treeView1.Nodes[3].Checked = false;
            //    treeView1.Nodes[4].Checked = true;
            //    treeView1.Nodes[5].Checked = true;
            //    treeView1.Nodes[6].Checked = true;
            //    treeView1.Nodes[7].Checked = true;
            //    treeView1.Nodes[8].Checked = false;
            //    treeView1.Nodes[9].Checked = true;
            //    treeView1.Nodes[10].Checked = true;
            //    treeView1.Nodes[11].Checked = false;
            //    treeView1.Nodes[12].Checked = false;
            //    treeView1.Nodes[13].Checked = false;
            //    treeView1.Nodes[14].Checked = true;
            //}
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            try 
            {
                //MemoryStream ms = new MemoryStream();
                //PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] Photo = new byte[ms.Length];
                //ms.Position = 0;
                //ms.Read(Photo, 0, Photo.Length);


                //if (txtUserName.Text=="")
                //{
                //    MessageBox.Show("Username Can't Be Empty.Enter The Username!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtUserName.Focus();
                //}

                //if (txtPassword.Text == "")
                //{
                //    MessageBox.Show("Password Can't Be Empty.Enter The Password!Password Length Should Be Above 8 Characters!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtPassword.Focus();
                //}

                //if (txtCPassword.Text == "")
                //{
                //    MessageBox.Show("Confirm Password Can't Be Empty.Enter The Confirm Password!Password Length Should Be Above 8 Characters!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtCPassword.Focus();
                //}

                //if (comUserLevel.Text == "")
                //{
                //    MessageBox.Show("UserLevel Can't Be Empty.Choose From Drop Down List!Password Length Should Be Above 8 Characters!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    comUserLevel.Focus();
                //}


                //if (txtFullName.Text == "")
                //{
                //    MessageBox.Show("Fullname Can't Be Empty.Enter The Fullname!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtFullName.Focus();
                //}

                //if (comPlace.Text == "")
                //{
                //    MessageBox.Show("Place Can't Be Empty.Enter The Place!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    comPlace.Focus();
                //}

                //if (comDes.Text == "")
                //{
                //    MessageBox.Show("Designation Can't Be Empty.Enter The Designation!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    comDes.Focus();
                //}

                //if (comGender.Text == "")
                //{
                //    MessageBox.Show("Gender Can't Be Empty.Choose From Drop Down List!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    comGender.Focus();
                //}

                //if (txtAge.Text == "")
                //{
                //    MessageBox.Show("Age Can't Be Empty.Enter Valid Age!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtAge.Focus();
                //}


                //if (txtCPassword.Text == txtPassword.Text)
                // {

                if (txtUserName.Text!="" && txtPassword.Text!="" && txtCPassword.Text!=""  && comUserLevel.Text!="" && txtFullName1.Text!="" && txtPlace.Text!="" && txtDes.Text!="" && comGender1.Text != "" && txtAge1.Text!="")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into UserDetails (UserID, UserName, Password1, UserLevel, FullName, Place, Designation, Gender, Age, NSystem, NNewUser, NUserLogin, NUserControl, NExit, NInvoice, NPurchase, NJobOrder, NPayments, NCheque, NBank, NAccounts, NStockItem, NCustomer, NVendor, NInventoryItems, NFixedAssets, NMiscellaneous, NReports, NUserLevel) values('"
                        + txtUserID.Text
                        + "', '" + txtUserName.Text
                        + "', '" + txtPassword.Text
                        + "', '" + comUserLevel.Text
                        + "', '" + txtFullName1.Text
                        + "', '" + txtPlace.Text
                        + "', '" + txtDes.Text
                        + "', '" + comGender1.Text
                        + "', '" + txtAge1.Text
                        //+ "', @photo, '" 
                        //  + "', '" + "-16776961"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "True"
                        + "', '" + "False"
                        + "', '" + "True"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "', '" + "False"
                        + "')", con);
                    //cmd.Parameters.AddWithValue("@photo", Photo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // txtUserID.Text = "";
                    Blank();               
                    txtUserID.Focus();
                }              

                else
                {
                    MessageBox.Show("Please Fill The Required Fields!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }
            }

            catch (Exception x)
            {
                 MessageBox.Show("Please Fill Other Details!"+x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //MemoryStream ms = new MemoryStream();
                //PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] Photo = new byte[ms.Length];
                //ms.Position = 0;
                //ms.Read(Photo, 0, Photo.Length);

                if (txtCPassword.Text == txtPassword.Text)
                {
                    if (kk==1)
                    {
                        OleDbCommand cmd = new OleDbCommand("Update UserDetails SET UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', Password1='" + txtPassword.Text + "', UserLevel='" + comUserLevel.Text + "', FullName='" + txtFullName1.Text + "', Place='" + txtPlace.Text + "', Designation='" + txtDes.Text + "', Gender='" + comGender1.Text + "', Age='" + txtAge1.Text
                        + "' WHERE UserID='" + txtUserID.Text + "'", con);
                        //+"', IImg=@photo WHERE UserID='" + txtUserID.Text + "'", con);
                        //cmd.Parameters.AddWithValue("@photo", Photo);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand("Update UserDetails SET UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', Password1='" + txtPassword.Text + "', UserLevel='" + comUserLevel.Text + "', FullName='" + txtFullName1.Text + "', Place='" + txtPlace.Text + "', Designation='" + txtDes.Text + "', Gender='" + comGender1.Text + "', Age='" + txtAge1.Text
                         + "' WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                        //cmd.Parameters.AddWithValue("@photo", Photo);

                        //OleDbCommand cmd = new OleDbCommand("Update UserDetails SET UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', Password1='" + txtPassword.Text + "', UserLevel='" + comUserLevel.Text + "', FullName='" + txtFullName.Text + "', Place='" + comPlace.Text + "', Designation='" + comDes.Text + "', Gender='" + comGender.Text + "', Age='" + txtAge.Text
                        // + "', IImg=@photo WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                        //cmd.Parameters.AddWithValue("@photo", Photo);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    
                    MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    Blank();
                    txtUserID.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    txtCPassword.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-462-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [UserDetails] Where [UserID]='" + txtUserID.Text + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    Blank();
                    txtUserID.Focus();
                }
                else
                {
                    txtUserID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-489-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kk = 2;
                string txt = "SELECT * FROM [UserDetails] Where UserID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);               
                fromDGView();
                //byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                //MemoryStream ms = new MemoryStream(Photo);
                //PicImg.Image = Image.FromStream(ms);                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-509-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "select * from UserDetails where UserID Like '%" + TxtSer.Text + "%' or UserName Like '%" + TxtSer.Text + "%' or UserLevel Like '%" + TxtSer.Text + "%' or Place Like '%" + TxtSer.Text + "%' or Designation Like '%" + TxtSer.Text + "%'";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
                da6.Fill(dt6);
                count = Convert.ToInt32(dt6.Rows.Count.ToString());
                dataGridView1.DataSource = dt6;
                DGViewSize();                         
                con.Close();
            }
            catch (Exception x)
            {
              //  MessageBox.Show(x + "  Error No:URser01 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtUserID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        kk = 1;
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtUserID.Text)
                            {
                                string txt = "SELECT * FROM [UserDetails] Where UserID='" + txtUserID.Text.ToString() + "'";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                //byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                                //MemoryStream ms = new MemoryStream(Photo);
                                //PicImg.Image = Image.FromStream(ms);
                            }
                        }
                        txtUserName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : UID-KDW-587-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAge.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUControl FUControl = new FrmUControl();
            FUControl.Show();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            FrmUsersRep FUsersRep = new FrmUsersRep();
            FUsersRep.Show();
        }

        private void comUserLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void comUserLevel_Click(object sender, EventArgs e)
        {
            //if (comUserLevel.Text == "")
            //{
            //    MessageBox.Show("Please Choose The User Level!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCPassword.Focus();
            //}
            //else
            //{
            //    //grpPD11.Visible = true;
            //    // grpUD.Visible = false;
            //    txtFullName1.Focus();
            //}
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
                       
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text, @"[^a-zA-Z]"))               
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = txtUserName.Text.Remove(txtUserName.Text.Length - 1);
            }        
          
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUserName.Text != "")
            {
                if (txtUserName.Text.Length <= 10)
                {
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Username Length Should Be Below 10 Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }
            }

            else
            {
                MessageBox.Show("Username Cannot Be Blank!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }

        }    

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            grpPD11.Visible = false;
            grpUD.Visible = true;
        }

        private void lnklblPD_Click(object sender, EventArgs e)
        {
            grpPD11.Visible = true;
            grpUD.Visible = false;
            txtFullName1.Focus();
        }

        private void grpUD_Enter(object sender, EventArgs e)
        {

        }

        private void comUserLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comUserLevel.Text == "")
            //{
            //    MessageBox.Show("Please Choose The User Level!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCPassword.Focus();
            //}
            //else
            //{
            //    //grpPD11.Visible = true;
            //    // grpUD.Visible = false;
            //    txtFullName1.Focus();
            //}
        }

        private void txtFullName1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFullName1.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtFullName1.Text.Length <= 75)
                    {
                        txtPlace.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Full Name Length Should Be 75 Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void txtPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPlace.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGender1.Focus();
                }
            }
        }

        private void comGender1_SelectedIndexChanged(object sender, EventArgs e)
        {            
                         
        }

        private void txtAge1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAge1.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {

                        if (System.Text.RegularExpressions.Regex.IsMatch(txtAge1.Text, @"[^0-9]"))
                        {
                            MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAge1.Text = txtAge1.Text.Remove(txtAge1.Text.Length - 1);
                        }

                        if (Convert.ToInt32(txtAge1.Text) > 9 && Convert.ToInt32(txtAge1.Text) < 100 && txtAge1.Text.Length == 2)
                        {
                            CmdSave.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Please Enter The Valid Age!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                    catch(Exception x)
                    {
                        MessageBox.Show("Please Enter The Valid Age!"+x, "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

                }
            }
        }

        private void txtFullName1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFullName1.Text, @"[^a-zA-Z|^\s]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName1.Text = txtFullName1.Text.Remove(txtFullName1.Text.Length - 1);
            }
        }

        private void txtPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAge1.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge1.Text = txtAge1.Text.Remove(txtAge1.Text.Length - 1);
            }
        }

        private void lnklblPD_Enter(object sender, EventArgs e)
        {
            grpPD11.Visible = true;
            grpUD.Visible = false;
            txtFullName1.Focus();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Blank();
            Refresh();
            this.Refresh();
        }

        private void comGender1_Click(object sender, EventArgs e)
        {
            //if (comGender1.Text == "")
            //{
            //    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    txtAge1.Focus();
            //}
        }

        private void comUserLevel_MouseClick(object sender, MouseEventArgs e)
        {
            //if (comUserLevel.Text == "")
            //{
            //    MessageBox.Show("Please Choose The User Level!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCPassword.Focus();
            //}
            //else
            //{
            //    //grpPD11.Visible = true;
            //    // grpUD.Visible = false;
            //    txtFullName1.Focus();
            //}
        }

        private void comGender1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGender1.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //grpPD11.Visible = true;
                    //grpUD.Visible = false;
                    txtAge1.Focus();
                }
            }
        }
    }
}
