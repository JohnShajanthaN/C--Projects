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
    public partial class FrmPassword : Form
    {
        public static string uname = "";
        public static string ul = "";
        //int count = 0;
        //int found1 = 0;
        string scolour;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {           
            txtNewPW.Text = "";
            txtOldPW.Text = "";
            txtPHint.Text = "";
            txtUserName.Text = "";
            txtUserName.Items.Clear();
            comList();
            txtConPW.Text = "";
            PicImg.Image = null;
        }

        private void UserIDKW()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserName='" + txtUserName.Text + "'", con);
                cmd1.Connection = con;
                rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    txtUserName.Text = rdr["UserName"].ToString();         
                    lblOPW.Text = rdr["Password1"].ToString();
                    txtPHint.Text = rdr["PWHint"].ToString();
                    if (PicImg.Image == null)
                    {

                    }
                    else
                    {
                        byte[] Photo = (byte[])(rdr["IImg"]);
                        MemoryStream ms = new MemoryStream(Photo);
                        PicImg.Image = Image.FromStream(ms);
                    }
                }
                txtOldPW.Focus();
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                return;
            }            
        }

        public FrmPassword()
        {
            InitializeComponent();
        }


     
        private void txtConPW_KeyDown(object sender, KeyEventArgs e)
        {       
            if (e.KeyCode == Keys.Enter)
            {
                if (txtConPW.Text == txtNewPW.Text)
                {
                    txtPHint.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConPW.Focus();
                    txtConPW.Text = "";
                }
            }                
        }

        private void txtOldPW_KeyDown(object sender, KeyEventArgs e)
        {
            UserIDKW();

            if (e.KeyCode == Keys.Enter)
            {
                if (txtOldPW.Text == lblOPW.Text)
                {
                    groupBox1.Enabled = true;
                    panel5.Enabled = true;
                    panel2.Enabled = true;
                    //txtNewPW.Text = txtOldPW.Text;
                    txtNewPW.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Correct Old Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPW.Focus();
                    txtOldPW.Text = "";
                }
            }                
        }

        private void txtNewPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPW.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtNewPW.Text.Length >=8  && txtNewPW.Text.Length <= 15)
                    {
                        if (txtNewPW.Text == txtOldPW.Text)
                        {
                            txtConPW.Text = txtNewPW.Text;
                        }
                        else
                        {
                            txtConPW.Text = "";
                        }
                        txtConPW.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Password Length Should Be Between 8 & 15 Characters!!!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtPHint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPHint.Text =="")
                {
                    MessageBox.Show("Please Enter the Word or Remember this Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
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

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;          
            comList();
            UserIDKW();
        }

        private void comList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select UserName from UserDetails";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                txtUserName.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt.Rows)
                {
                    txtUserName.Items.Add(dr["UserName"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                con.Close();
                MessageBox.Show("ERROR CODE : COM-LST-118-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


private void CmdSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtOldPW.Text == "" || txtNewPW.Text == "" || txtConPW.Text == "" || txtPHint.Text == "")
                {
                    MessageBox.Show("All Fields Should Be Mandatory Fields.Please Check The Blank Fields.!! and Enter the same new password in comfirm password box!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (txtConPW.Text == "")
                    {
                        MessageBox.Show("Please Enter the Valid Password! and Enter the same new password in confirm password box!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPW.Focus();
                        txtNewPW.Text = "";
                        txtConPW.Text = "";
                        return;
                    }

                    if (txtOldPW.Text == lblOPW.Text && txtConPW.Text == txtNewPW.Text)
                    {
                        OleDbCommand cmd = new OleDbCommand("Update UserDetails SET Password1='" + txtNewPW.Text + "', PWHint='" + txtPHint.Text
                        + "' WHERE UserName='" + txtUserName.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CmdExit.Focus();
                        Blank();

                    }
                    else if (txtOldPW.Text != lblOPW.Text && txtConPW.Text != txtNewPW.Text)
                    {
                        MessageBox.Show("Please Try Again! Please Enter the Correct Old Password! and Enter the same new password in comfirm password box!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPW.Focus();
                        txtNewPW.Text = "";
                        txtConPW.Text = "";
                        txtOldPW.Text = "";
                    }
                    else if (txtOldPW.Text != lblOPW.Text)
                    {
                        MessageBox.Show("Please Enter the Correct Old Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPW.Focus();
                        txtNewPW.Text = "";
                        txtOldPW.Text = "";
                    }
                    else if (txtConPW.Text != txtNewPW.Text)
                    {
                        MessageBox.Show("Please Enter the Same Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConPW.Focus();
                        txtConPW.Text = "";
                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-309-PSW" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);
                OleDbCommand cmd = new OleDbCommand("Update UserDetails SET BGColor='" + txtCol.Text
                + "', IImg=@photo WHERE UserName='" + txtUserName.Text + "'", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmdExit.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("  Error No:PWCS01 Please Select Valied Profile Photo", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdColor_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            scolour = colorDialog1.Color.ToArgb().ToString();
            txtCol.Text = colorDialog1.Color.ToArgb().ToString();
        }

        private void CmdExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            this.Width = 800;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtOldPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtUserName.Text=="")
            {
                MessageBox.Show("Invalid Data", "Reset User Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                txtOldPW.Focus();
            }
        }

        private void cmdClear_Click_1(object sender, EventArgs e)
        {
            Blank();
            txtUserName.Text = "";
            txtUserName.Focus();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtUserName.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Blank();
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + txtUserName.Text.Trim() + "'", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            temp = true;
                            txtUserName.Text = rdr["UserName"].ToString();
                            lblOPW.Text = rdr["Password1"].ToString();
                            txtPHint.Text = rdr["PWHint"].ToString();

                            byte[] Photo = (byte[])(rdr["IImg"]);
                            MemoryStream ms = new MemoryStream(Photo);
                            PicImg.Image = Image.FromStream(ms);
                        }
                        txtOldPW.Focus();
                        con.Close();
                        if (temp == false)
                        {
                            MessageBox.Show("Record Not Found! Please Enter the Correct User Name.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUserName.Text = "";
                            txtUserName.Focus();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Please Fill All Fields and Select Profile Picture!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPW.Focus();
                con.Close();
            }
        }

        private void txtOldPW_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="")
            {
                MessageBox.Show("Choose The UserName From DropDown List!!!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else
            {
                txtOldPW.Focus();
            }
        }

        private void txtNewPW_Click(object sender, EventArgs e)
        {

            if(txtOldPW.Text=="")
            {
                MessageBox.Show("Old Password Can't Be Blank.Type Valid Old Password!!!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPW.Focus();
            }
            else
            {
                UserIDKW();

                if (txtOldPW.Text == lblOPW.Text)
                {
                    groupBox1.Enabled = true;
                    panel5.Enabled = true;
                    panel2.Enabled = true;
                    //txtNewPW.Text = txtOldPW.Text;
                    txtNewPW.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Correct Old Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPW.Focus();
                    txtOldPW.Text = "";
                }
            }
                 
        }

        private void txtConPW_Click(object sender, EventArgs e)
        {           
                if (txtNewPW.Text == "")
                {
                    MessageBox.Show("Password Field Can't Be Blank.Please Enter New Password !!!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPW.Focus();
                }
                else
                {
                    if (txtNewPW.Text.Length >= 8 && txtNewPW.Text.Length <= 15)
                    {
                        if (txtNewPW.Text == txtOldPW.Text)
                        {
                            txtConPW.Text = txtNewPW.Text;
                        }
                        else
                        {
                            txtConPW.Text = "";
                        }
                        txtConPW.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Password Length Should Be Between 8 & 15 Characters!!!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }           
        }

        private void txtPHint_Click(object sender, EventArgs e)
        {
            if (txtConPW.Text == "")
            {
                MessageBox.Show("Password Field Can't Be Blank.Please Enter Confirm Password !!!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConPW.Focus();
            }
            else
            {
                if (txtConPW.Text == txtNewPW.Text)
                {
                    txtPHint.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConPW.Focus();
                    txtConPW.Text = "";
                }
            }
        }
    }
}
