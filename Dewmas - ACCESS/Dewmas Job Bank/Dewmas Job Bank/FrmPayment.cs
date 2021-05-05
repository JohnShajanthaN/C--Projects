using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Dewmas_Job_Bank
{
    
    public partial class FrmPayment : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Dewmas.mdb");
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void Blank()
        {
            comRegID.Text = "";
            chkOffReg.Checked = false;
            chkWrkReg.Checked = false;
            chkWrkCon.Checked = false;
            txtPay.Text = "";
            dtpPayDate.Text = "";
            TxtSer_TextChanged(null, null);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TxtSer_TextChanged(null, null);
            ComList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comRegID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int found1 = 0;
                        int count = 0; ;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == comRegID.Text)
                            {
                                string txt = "SELECT * FROM [StuReg] Where StuID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["Img"]);
                                MemoryStream ms = new MemoryStream(Photo);
                                //PicImg.Image = Image.FromStream(ms);
                            }
                        }
                        groupBox2.Focus();
                        if (found1 == 0)
                        {
                           Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : BCD-KDW-236-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select StuID from StuReg";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                comRegID.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt.Rows)
                {
                    comRegID.Items.Add(dr["StuID"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-131-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        


        private void fromDGView()
        {
            comRegID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtPay.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpPayDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Student ID";
            /*
            dataGridView1.Columns[1].HeaderText = "Payment";
            dataGridView1.Columns[2].HeaderText = "Payment Date";
         
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;
            */
        }



        private void txtPay_MouseMove(object sender, MouseEventArgs e)
        {
            if (chkOffReg.Checked == true)
            {
                txtPay.Text = "500";   
            }
            else
            {
                if (chkWrkCon.Checked == true || chkWrkReg.Checked == true)
                {
                    MessageBox.Show("Choose The Only Registration Fees or ( Registration Fees+Office Registration Fees) or ( Registration Fees+Office Work Confirmation Fees) ", "Student Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtPay.Text = "";
                    chkOffReg.Checked =false;
                    chkWrkReg.Checked =false;
                    chkWrkCon.Checked = false;
                    groupBox2.Focus();
                }
            }
          
            if(chkOffReg.Checked == true && chkWrkReg.Checked == true)
            {
                txtPay.Text = "2500";
            }

            if(chkOffReg.Checked == true && chkWrkCon.Checked == true)
            {
                txtPay.Text = "5500";
            }

            if (chkOffReg.Checked == true && chkWrkCon.Checked == true && chkWrkReg.Checked == true)
            {
                MessageBox.Show("Choose The Only Registration Fees or ( Registration Fees+Office Registration Fees) or ( Registration Fees+Office Work Confirmation Fees) ", "Student Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtPay.Text = "";
                chkOffReg.Checked = false;
                chkWrkReg.Checked = false;
                chkWrkCon.Checked = false;
                groupBox2.Focus();             
            }

        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from StuPay where StuID Like '%" + TxtSer.Text + "%' or Payment Like '%" + TxtSer.Text + "%' or PayDate Like '%" + TxtSer.Text + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                /*For Combo box List
                comRegID.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    comRegID.Items.Add(dr["StuID"].ToString());
                }
                */
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-196-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dtpPayDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtpPayDate.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into StuPay values('"
                    + comRegID.Text + "', '" + txtPay.Text + "','" + dtpPayDate.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comRegID.Text = "";
                Blank();
                comRegID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-155-SHI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update StuPay SET StuID='" + comRegID.Text + "', Payment='" + txtPay.Text + "', PayDate='" + dtpPayDate.Text + "' WHERE StuID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comRegID.Text = "";
                Blank();
                comRegID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-299-SHI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string txt = "DELETE FROM [StuPay] Where [StuID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comRegID.Text = "";
                    Blank();
                    comRegID.Focus();
                }
                else
                {
                    comRegID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-135-SHI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmStuPayRep SPR = new FrmStuPayRep();
            SPR.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [StuPay] Where StuID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();                    
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}
