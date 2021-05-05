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
    public partial class FrmSup : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            txtSAdd.Text = "";
            txtCmnt.Text = "";
            txtCPer.Text = "";
            txtSEMail.Text = "";
            txtSFax.Text = "";
            txtSMob.Text = "";
           // txtSCode.Text = "";
            txtSupN.Text = "";
            txtSTel.Text = "";
            comPTem.Text = "";
            comSType.Text = "";
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                txtSCode.Text = "0001";
                comSType.Focus();
            }

            else
            {
                int q = 0;
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from Supplier", con);
                cmd2.Connection = con;

                OleDbDataReader rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    if (q < Convert.ToInt32(rdr["SupplierCode"]))
                    {
                        q = Convert.ToInt32(rdr["SupplierCode"]);
                    }
                }
                con.Close();
                q = q + 1;
                txtSCode.Text = q.ToString("0000");
                comSType.Focus();
            }
        }

        private void fromDGView()
        {
            txtSCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtSupN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSAdd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCPer.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtSTel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtSEMail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comSType.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString(); 
            txtSMob.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtSFax.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString(); 
            comPTem.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtCmnt.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 60;
            dataGridView1.Columns[10].Width =60;

            dataGridView1.Columns[0].HeaderText = "S_Code";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Contact_Person";
            dataGridView1.Columns[4].HeaderText = "Tel_No";
            dataGridView1.Columns[5].HeaderText = "Email_Address";
            dataGridView1.Columns[6].HeaderText = "Type";
            dataGridView1.Columns[7].HeaderText = "Mobile_No";
            dataGridView1.Columns[8].HeaderText = "Fax_No";
            dataGridView1.Columns[9].HeaderText = "Payment_Term";
            //dataGridView1.Columns[10].HeaderText = "Comment";

            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;

            /*
            if (lblULevel1.Text == "USER")
            {
                dataGridView1.Columns[24].Visible = false;
                dataGridView1.Columns[25].Visible = false;
                dataGridView1.Columns[26].Visible = false;
                dataGridView1.Columns[27].Visible = false;
            }
            else
            {
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[20].Width = 35;
                dataGridView1.Columns[24].Width = 35;
                dataGridView1.Columns[25].Width = 45;
                dataGridView1.Columns[26].Width = 35;
                dataGridView1.Columns[27].Width = 45;
                dataGridView1.Columns[28].Width = 25;
            }
            */
        }

        public FrmSup()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comSType.Text != "" && txtSupN.Text != "" && txtSAdd.Text != "" && txtCPer.Text != "" &&  txtSTel.Text != "" && txtSMob.Text != "" && txtSFax.Text != "" && txtSEMail.Text != "" && comPTem.Text != "")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into Supplier (SupplierCode, SupplierType, SupplierName, SupplierAddress, ContactPerson, SupplierLandNo, SupplierMobileNO, SupplierFaxNo, SupplierEmail, PaymentTerms, Comments) values('"
                        + txtSCode.Text + "', '"
                        + comSType.Text + "', '"
                        + txtSupN.Text + "', '"
                        + txtSAdd.Text + "', '"
                        + txtCPer.Text + "', '"
                        + txtSTel.Text + "', '"
                        + txtSMob.Text + "', '"
                        + txtSFax.Text + "', '"
                        + txtSEMail.Text + "', '"
                        + comPTem.Text + "', '"
                        + txtCmnt.Text + "')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSCode.Text = "";
                    Blank();
                    comSType.Focus();
                }

                else
                {
                    MessageBox.Show("Fill The Required Fields!", "Invalid Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-137-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update Supplier SET SupplierCode='" + txtSCode.Text 
                    + "', SupplierType='" + comSType.Text 
                    + "', SupplierName='" + txtSupN.Text
                    + "', SupplierAddress='" + txtSAdd.Text 
                    + "', ContactPerson='" + txtCPer.Text 
                    + "', SupplierLandNo='" + txtSTel.Text 
                    + "', SupplierMobileNO='" + txtSMob.Text 
                    + "', SupplierFaxNo='" + txtSFax.Text
                    + "', SupplierEmail='" + txtSEMail.Text 
                    + "', PaymentTerms='" + comPTem.Text 
                    + "', Comments='" + txtCmnt.Text 
                    + "' WHERE SupplierCode='" + dataGridView1.SelectedRows[0].Cells[0].Value + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-167-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void FrmSup_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            Blank();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Supplier] Where [SupplierCode]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
                }
                else
                {
                    txtSCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-206-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Supplier] Where SupplierCode='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-222-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from Supplier where SupplierCode Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or SupplierName Like '%" + TxtSer.Text + "%' or SupplierAddress Like '%" + TxtSer.Text + "%' or SupplierType Like '%" + TxtSer.Text + "%' or SupplierLandNo Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                comPTem.Items.Clear();                     //For Combo box List
                comSType.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comPTem.Items.Add(dr["PaymentTerms"].ToString());
                    comSType.Items.Add(dr["SupplierType"].ToString());
                }
                con.Close();
                if (count == 0)
                {
                  //  MessageBox.Show("Record Not Found!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-257-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            FrmSupRep FSupRep = new FrmSupRep();
            FSupRep.Show();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

         private void txtSCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtSCode.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == txtSCode.Text)
                            {
                                string txt = "SELECT * FROM [Supplier] Where SupplierCode=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        comSType.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : SCOD-KDW-313-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void txtSCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comSType_SelectedIndexChanged(object sender, EventArgs e)
        {         
                if (comSType.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(comSType.Text, @"[^a-zA-Z]"))
                    {
                        MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comSType.Text = comSType.Text.Remove(comSType.Text.Length - 1);
                        comSType.Text = "";
                        comSType.Focus();
                    }

                    else
                    {
                        txtSupN.Focus();
                    }
                }          
        }

        private void txtSupN_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSupN.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupN.Text = txtSupN.Text.Remove(txtSupN.Text.Length - 1);
                txtSupN.Text = "";
            }
        }

        private void txtSAdd_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSAdd.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSAdd.Text = txtSAdd.Text.Remove(txtSAdd.Text.Length - 1);
                txtSAdd.Text = "";
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

        private void txtSTel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSTel.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTel.Text = txtSTel.Text.Remove(txtSTel.Text.Length - 1);
                txtSTel.Text = "";
            }
        }

        private void txtSMob_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSMob.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSMob.Text = txtSMob.Text.Remove(txtSMob.Text.Length - 1);
                txtSMob.Text = "";
            }
        }

        private void txtSFax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSFax.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSFax.Text = txtSFax.Text.Remove(txtSFax.Text.Length - 1);
                txtSFax.Text = "";
            }
        }

        private void txtSEMail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSEMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSEMail.Text == "")
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
            string email = txtSEMail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success)
            {
                comPTem.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid Email Address!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSEMail.Text = "";
            }
        }

        private void comSType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comSType.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(comSType.Text, @"[^a-zA-Z]"))
                    {
                        MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comSType.Text = comSType.Text.Remove(comSType.Text.Length - 1);
                        comSType.Text = "";
                        comSType.Focus();
                    }

                    else
                    {
                        txtSupN.Focus();
                    }

                }
            }
        }

        private void txtSupN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSupN.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSAdd.Focus();
                }
            }
        }

        private void txtSAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSAdd.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCPer.Focus();
                }
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
                    txtSTel.Focus();
                }
            }
        }

        private void txtSTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSTel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSMob.Focus();
                }
            }
        }

        private void txtSMob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSMob.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSFax.Focus();
                }
            }
        }

        private void txtSFax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSFax.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSEMail.Focus();
                }
            }
        }

        private void comPTem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comPTem.Text, @"[^a-zA-Z]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        comPTem.Text = "";
                        comPTem.Focus();
                    }

                    else
                    {
                        txtCmnt.Focus();
                    }

                }
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
                    CmdSave.Focus();                 
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

        private void txtSCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
