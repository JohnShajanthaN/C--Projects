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
using System.Text.RegularExpressions;

namespace WindowsFormsERP
{
    public partial class FrmCus : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            comCType.Text = "";
            txtCName.Text = "";
            txtCAdd.Text="";
            txtVatNo.Text = "";
            txtSVatNo.Text = "";
            txtCPer.Text = "";
            txtCTel.Text = "";
            txtCMob.Text = "";
            txtCFax.Text = "";
            txtCEMail.Text = "";
            comPTem.Text = "";
            txtCmnt.Text = "";
            comHAbtUs.Text = "";
            txtFbkAbtUs.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                txtCCode.Text = "0001";
                comCType.Focus();
            }

            else
            {
                int q = 0;
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from customer", con);
                cmd2.Connection = con;

                OleDbDataReader rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    if (q < Convert.ToInt32(rdr["CustomerCode"]))
                    {
                        q = Convert.ToInt32(rdr["CustomerCode"]);
                    }
                }
                con.Close();
                q = q + 1;
                txtCCode.Text = q.ToString("0000");
                comCType.Focus();
            }
        }

        private void fromDGView()
        {
            txtCCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comCType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtVatNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtSVatNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCAdd.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtCPer.Text= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCTel.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtCMob.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtCFax.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtCEMail.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            comPTem.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtCmnt.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            comHAbtUs.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
            txtFbkAbtUs.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[10].Width = 70;
            dataGridView1.Columns[11].Width = 70;

            dataGridView1.Columns[0].HeaderText = "C_Code";
            dataGridView1.Columns[1].HeaderText = "Type";
            dataGridView1.Columns[2].HeaderText = "VAT_NO";
            dataGridView1.Columns[3].HeaderText = "SVAT_NO";
            dataGridView1.Columns[4].HeaderText = "Name";
            dataGridView1.Columns[5].HeaderText = "Address";
            dataGridView1.Columns[6].HeaderText = "Contact_Person";
            dataGridView1.Columns[7].HeaderText = "Tel_No";
            dataGridView1.Columns[8].HeaderText = "Mobile_No";
            dataGridView1.Columns[9].HeaderText = "Fax_No";
            dataGridView1.Columns[10].HeaderText = "Email_Address";
            dataGridView1.Columns[11].HeaderText = "Payment_Term";

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
            
           
            //if (lblULevel1.Text == "USER")
            //{
            //    dataGridView1.Columns[24].Visible = false;
            //    dataGridView1.Columns[25].Visible = false;
            //    dataGridView1.Columns[26].Visible = false;
            //    dataGridView1.Columns[27].Visible = false;
            //}
            //else
            //{
            //    dataGridView1.Columns[4].Visible = false;
            //    dataGridView1.Columns[25].Width = 45;
            //    dataGridView1.Columns[26].Width = 35;
            //    dataGridView1.Columns[27].Width = 45;
            //    dataGridView1.Columns[28].Width = 25;
            //}
        }
        public FrmCus()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comCType.Text!="" && txtCName.Text!="" && txtCAdd.Text != "" && txtVatNo.Text != "" && txtSVatNo.Text != "" && txtCPer.Text != "" && txtCTel.Text != "" && txtCMob.Text != "" && txtCEMail.Text != "" && comPTem.Text != "")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into customer(CustomerCode, CustomerType, CustomerName, customeraddress, VATNumber, SVATNumber, ContactPerson, CustomerLandNo, CustomerMobileNo, CustomerFaxNo, customeremail, PaymentTerms, Comments, IntroducedBy, FeedBack) values('"
                        + txtCCode.Text + "', '" + comCType.Text + "', '" + txtCName.Text + "', '" + txtCAdd.Text + "', '"
                        + txtVatNo.Text + "', '" + txtSVatNo.Text + "', '" + txtCPer.Text + "', '" + txtCTel.Text + "', '"
                        + txtCMob.Text + "', '" + txtCFax.Text + "', '" + txtCEMail.Text + "', '" + comPTem.Text + "', '"
                        + txtCmnt.Text + "', '" + comHAbtUs.Text + "', '" + txtFbkAbtUs.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Sucessfully!", "Invalid Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCCode.Text = "";
                    Blank();
                    txtCCode.Focus();
                }

                else
                {
                    MessageBox.Show("Fill The Required Fields!", "Invalid Info", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-115-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update customer SET CustomerCode='" + txtCCode.Text.ToString() 
                    + "', CustomerType='" + comCType.Text 
                    + "', CustomerName='" + txtCName.Text 
                    + "', customeraddress='" + txtCAdd.Text
                    + "', VATNumber='" + txtVatNo.Text 
                    + "', SVATNumber='" + txtSVatNo.Text 
                    + "', ContactPerson='" + txtCPer.Text 
                    + "', CustomerLandNo='" + txtCTel.Text 
                    + "', CustomerMobileNo='" + txtCMob.Text
                    + "', CustomerFaxNo='" + txtCFax.Text 
                    + "', customeremail='" + txtCEMail.Text 
                    + "', PaymentTerms='" + comPTem.Text 
                    + "', Comments='" + txtCmnt.Text
                    + "', IntroducedBy='" + comHAbtUs.Text
                    + "', FeedBack='" + txtFbkAbtUs.Text
                    + "' WHERE CustomerCode='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCCode.Text = "";
                Blank();
                comCType.Focus();              
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-149-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void FrmCus_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            Blank();
            comCType.Focus();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [customer] Where [CustomerCode]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCCode.Text = "";
                    Blank();
                    txtCCode.Focus();
                }
                else
                {
                    txtCCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-183-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [customer] Where CustomerCode='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-199-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from customer where CustomerCode Like '%" + TxtSer.Text + "%' or CustomerType Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or customeraddress Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or CustomerLandNo Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                comCType.Items.Clear();                     //For Combo box List
                comHAbtUs.Items.Clear();
                comPTem.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comCType.Items.Add(dr["CustomerType"].ToString());
                    comHAbtUs.Items.Add(dr["IntroducedBy"].ToString());
                    comPTem.Items.Add(dr["PaymentTerms"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-232-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void txtCCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtCCode.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == txtCCode.Text)
                            {
                                string txt = "SELECT * FROM [customer] Where CustomerCode=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        comCType.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : CCOD-KDW-277-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void comCType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCType.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(comCType.Text, @"[^a-zA-Z]"))
                    {
                        MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comCType.Text = comCType.Text.Remove(comCType.Text.Length - 1);                      
                        comCType.Text = "";
                        comCType.Focus();
                    }

                    else
                    {
                        txtCName.Focus();
                    }
                    
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            uname = lblUser1.Text;
            ul = lblULevel1.Text;
            FrmCusRep FCusRep = new FrmCusRep();
            FCusRep.Show();
        }

        private void txtCCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comCType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comCType.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comCType.Text = comCType.Text.Remove(comCType.Text.Length - 1);
            }
        }

        private void txtCName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCName.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCName.Text = txtCName.Text.Remove(txtCName.Text.Length - 1);
                txtCName.Text = "";
            }
        }

        private void txtCName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /*
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtCName.Text, @"[^a-zA-Z]"))
                    {
                        MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCName.Text = txtCName.Text.Remove(txtCName.Text.Length - 1);
                        txtCName.Text = "";
                        txtCName.Focus();
                    }

                    else
                    {
                        txtCAdd.Focus();
                    }
                    */
                    txtCAdd.Focus();
                }
            }       
        }

        private void txtCAdd_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCAdd.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCAdd.Text = txtCAdd.Text.Remove(txtCAdd.Text.Length - 1);
                txtCAdd.Text = "";
            }
        }

        private void txtCAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCAdd.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtVatNo.Focus();
                }
            }
           
        }

        private void txtVatNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVatNo.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVatNo.Text = txtVatNo.Text.Remove(txtVatNo.Text.Length - 1);
                txtVatNo.Text = "";
            }
        }

        private void txtVatNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtVatNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSVatNo.Focus();
                }
            }
        }

        private void txtSVatNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSVatNo.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSVatNo.Text = txtSVatNo.Text.Remove(txtSVatNo.Text.Length - 1);
                txtCPer.Text = "";
            }
        }

        private void txtSVatNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSVatNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCPer.Focus();
                }
            }
        }

        private void txtCPer_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCPer.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPer.Text = txtCPer.Text.Remove(txtCPer.Text.Length - 1);
                txtCPer.Text = "";
            }
        }

        private void txtCPer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPer.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCTel.Focus();
                }
            }
        }

        private void txtCTel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCTel.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCTel.Text = txtCTel.Text.Remove(txtCTel.Text.Length - 1);
                txtCTel.Text = "";
            }
        }

        private void txtCTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCTel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCMob.Focus();
                }
            }
        }

        private void txtCFax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCFax.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCFax.Text = txtCFax.Text.Remove(txtCFax.Text.Length - 1);
                txtCFax.Text = "";
            }
        }

        private void txtCFax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCFax.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCEMail.Focus();
                }
            }
        }

        private void txtCEMail_TextChanged(object sender, EventArgs e)
        {         
            
        }

        private void txtCEMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCEMail.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                        ValidateEmail();                 
                }
            }
        }

        private void ValidateEmail()
        {
            string email = txtCEMail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success)
            {

                comPTem.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid Email Address!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEMail.Text = "";
            }
        }

        private void comPTem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comPTem.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comPTem.Text = comPTem.Text.Remove(comPTem.Text.Length - 1);
                comPTem.Text = "";
            }
        }

        private void comPTem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPTem.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(comPTem.Text, @"[^a-zA-Z]"))
                    {
                        MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comPTem.Text = comPTem.Text.Remove(comPTem.Text.Length - 1);
                        txtCFax.Text = "";
                    }
                    else
                    {
                        txtCmnt.Focus();
                    }
                }
            }
        }

        private void txtCmnt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCmnt.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCmnt.Text = txtCmnt.Text.Remove(txtCmnt.Text.Length - 1);
                txtCmnt.Text = "";
            }
        }

        private void txtCmnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCmnt.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comHAbtUs.Focus();
                }
            }
        }

        private void comHAbtUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comHAbtUs.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comHAbtUs.Text = comHAbtUs.Text.Remove(comHAbtUs.Text.Length - 1);
                comHAbtUs.Text = "";
            }
        }

        private void txtFbkAbtUs_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFbkAbtUs.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFbkAbtUs.Text = txtFbkAbtUs.Text.Remove(txtFbkAbtUs.Text.Length - 1);
                txtFbkAbtUs.Text = "";
            }
        }

        private void comHAbtUs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comHAbtUs.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(comHAbtUs.Text, @"[^a-zA-Z]"))
                    {
                        MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comHAbtUs.Text = comHAbtUs.Text.Remove(comHAbtUs.Text.Length - 1);
                        comHAbtUs.Text = "";
                    }
                    else
                    {
                        txtFbkAbtUs.Focus();
                    }
                }
            }
        }

        private void txtFbkAbtUs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFbkAbtUs.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void txtCMob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCMob.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCFax.Focus();
                }
            }
        }

        private void txtCMob_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCMob.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMob.Text = txtCMob.Text.Remove(txtCMob.Text.Length - 1);
                txtCMob.Text = "";
            }
        }

        private void txtCCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
