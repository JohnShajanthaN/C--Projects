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
    public partial class FrmMnuInv : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            comItm.Text = "";
            txtUM.Text = "";
            txtOdrQty.Text = "";
            txtURate.Text = "0.00";
            txtINo.Text = (count + 1).ToString("00");
            txtStNo.Enabled = true;
            cmdRe.Enabled = true;
        }
        private void Blank2()
        {
            Blank();
            txtCCode.Text = "";
            comCus.Text = "";
            txtCAdd.Text = "";
            txtSSCode.Text = "";
            comSStf.Text = "";
            txtPONo.Text = "";
            comTem.Text = "";
            dtpInvDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comInvCat.Text = "";
            txtTAmo.Text = "0.00";
            txtRefNo.Text = "";
            comJONo.Text = "";
        }

        private void DGViewSize()
        {
            dataGridView2.Font = new Font("Arial", 12);
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 14);
            if (label19.Text == "Customer Details")
            {
                dataGridView2.Columns[0].HeaderText = " Code";
                dataGridView2.Columns[1].HeaderText = " Type";
                dataGridView2.Columns[2].HeaderText = " VAT No";
                dataGridView2.Columns[3].HeaderText = " SVAT No";
                dataGridView2.Columns[4].HeaderText = " Name";
                dataGridView2.Columns[5].HeaderText = " Address";
                dataGridView2.Columns[6].HeaderText = " C.Person";
                dataGridView2.Columns[7].HeaderText = " Tell";
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[2].Width = 76;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Width = 210;
                dataGridView2.Columns[5].Width = 240;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Width = 100;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                dataGridView2.Columns[10].Visible = false;
                dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                dataGridView2.Columns[13].Visible = false;
                dataGridView2.Columns[14].Visible = false;
                dataGridView2.Columns[15].Visible = false;
                dataGridView2.Columns[16].Visible = false;
                dataGridView2.Columns[17].Visible = false;
                dataGridView2.Columns[18].Visible = false;
                dataGridView2.Columns[19].Visible = false;
                dataGridView2.Columns[20].Visible = false;
                dataGridView2.Columns[21].Visible = false;
                dataGridView2.Columns[22].Visible = false;
            }
            else if (label19.Text == "Sales Staffs Details")
            {
                dataGridView2.Columns[0].Width = 100;
                dataGridView2.Columns[1].Width = 750;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[3].Visible = false;
            }
            else if (label19.Text == "Stock Items Details")
            {
                dataGridView2.Columns[29].DefaultCellStyle.Format = "N2";
                dataGridView2.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[2].Width = 220;
                dataGridView2.Columns[3].Width = 90;
                dataGridView2.Columns[15].Width = 40;
                dataGridView2.Columns[16].Width = 55;
                dataGridView2.Columns[17].Width = 67;
                dataGridView2.Columns[18].Width = 75;
                dataGridView2.Columns[19].Visible = false;
                dataGridView2.Columns[29].Width = 120;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                dataGridView2.Columns[10].Visible = false;
                dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                dataGridView2.Columns[13].Visible = false;
                dataGridView2.Columns[14].Visible = false;
                dataGridView2.Columns[20].Visible = false;
                dataGridView2.Columns[21].Visible = false;
                dataGridView2.Columns[22].Visible = false;
                dataGridView2.Columns[23].Visible = false;
                dataGridView2.Columns[24].Visible = false;
                dataGridView2.Columns[25].Visible = false;
                dataGridView2.Columns[26].Visible = false;
                dataGridView2.Columns[27].Visible = false;
                dataGridView2.Columns[28].Visible = false;
            }
            else if (label19.Text == "Locations Details")
            {
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Width = 80;
                dataGridView2.Columns[2].Width = 600;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[5].Visible = false;
            }
            else if (label19.Text == "Job Order Details")
            {
                dataGridView2.Columns[0].Visible = true;
                dataGridView2.Columns[1].Visible = true;
                dataGridView2.Columns[2].Visible = true;
                dataGridView2.Columns[0].Width = 201;
                dataGridView2.Columns[1].Width = 780;
                dataGridView2.Columns[2].Width = 200;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
            }
        }

        private void DGViewSizeS()
        {
            dataGridView1.Font = new Font("Arial", 11);
            dataGridView1.Columns[6].DefaultCellStyle.Format = "D2";
            dataGridView1.Columns[12].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[13].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].HeaderText = " I/No";
            dataGridView1.Columns[7].HeaderText = " Stock No";
            dataGridView1.Columns[8].HeaderText = " Description";
            dataGridView1.Columns[9].HeaderText = " U/M";
            dataGridView1.Columns[11].HeaderText = " Qty";
            dataGridView1.Columns[12].HeaderText = " U/Rate (Rs.)";
            dataGridView1.Columns[13].HeaderText = " Amount (Rs.)";
            dataGridView1.Columns[14].HeaderText = " Location";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Width = 48;
            dataGridView1.Columns[7].Width = 107;
            dataGridView1.Columns[8].Width = 370;
            dataGridView1.Columns[9].Width = 80;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Width = 93;
            dataGridView1.Columns[12].Width = 135;
            dataGridView1.Columns[13].Width = 146;
            dataGridView1.Columns[14].Width = 107;
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
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from customer where CustomerCode Like '%" + TxtSer.Text + "%' or CustomerType Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or customeraddress Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or CustomerLandNo Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                comCus.Items.Clear();                     //For Combo box List
                comTem.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comCus.Items.Add(dr["CustomerName"].ToString());
                    comTem.Items.Add(dr["PaymentTerms"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Salesman where BrokerNO Like '%" + TxtSer.Text + "%'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comSStf.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt1.Rows)
                {
                    comSStf.Items.Add(dr["BrokerName"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from ManufactureCompletedDetails ";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(dt2);
                comInvCat.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt2.Rows)
                {
                    comInvCat.Items.Add(dr["BillCategory"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from Item ";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(dt3);
                comItm.Items.Clear();
                foreach (DataRow dr in dt3.Rows)
                {
                    comItm.Items.Add(dr["Des"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select * from Location ";
                cmd4.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
                da4.Fill(dt4);
                comLOC.Items.Clear();
                foreach (DataRow dr in dt4.Rows)
                {
                    comLOC.Items.Add(dr["LocationNo"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from JobOrder ";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                da5.Fill(dt5);
                comJONo.Items.Clear();
                foreach (DataRow dr in dt5.Rows)
                {
                    comJONo.Items.Add(dr["JobOrderNo"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-297-MNU-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NextInvNo()
        {
            try
            {
                int q = 0;
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from ManufactureCompletedDetails ", con);
                cmd2.Connection = con;

                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    if (q < Convert.ToInt32(rdr["BillNumber"]))
                    {
                        q = Convert.ToInt32(rdr["BillNumber"]);
                    }
                }
                con.Close();
                q = q + 1;
                txtInvNo.Text = q.ToString();
            }
            catch (Exception x)
            {
                // MessageBox.Show(x + "  Error No:Invcomlst01 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BillSave()
        {
            try
            {
                string PS = "";
                double PA = 0.00, PB = 0.00;
                if (comTem.Text != "Credit")
                {
                    PS = "Full Paid";
                    PA = Convert.ToDouble(txtTAmo.Text);
                    PB = 0.00;
                }
                else
                {
                    PS = "Not Paid";
                    PA = 0.00;
                    PB = Convert.ToDouble(txtTAmo.Text);
                }
                OleDbCommand cmd = new OleDbCommand("Insert into JOPayment(JobOrderNo, CustomerCode, CustomerName, RefNo, InvoiceNumber, InvoiceDate, InvoiceCategory, GrandTotal, PayDate, PayAmount, PayBal, PayType, PayStatus) values('"
                  + comJONo.Text + "', '"
                  + txtCCode.Text + "', '"
                  + comCus.Text + "', '"
                  + txtRefNo.Text + "', '"
                  + txtInvNo.Text + "', '"
                  + dtpInvDate.Value.ToString() + "', '"
                  + "Manufacture Invoice" + "', '"
                  + txtTAmo.Text + "', '"
                  + dtpInvDate.Value.ToString() + "', '"
                  + PA.ToString() + "', '"
                  + PB.ToString() + "', '"
                  + comTem.Text + "', '"
                  + PS.ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-492-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmMnuInv()
        {
            InitializeComponent();
        }

        private void FrmMnuInv_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            ComList();
            count = 0;
            txtSerSale_TextChanged(null, null);

            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdVPrint_Click(object sender, EventArgs e)
        {
            BillSave();
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void comCus_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCus.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from customer where CustomerName='" + comCus.Text.Trim() + "' ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        txtCCode.Text = rdr["CustomerCode"].ToString();
                        comCus.Text = rdr["CustomerName"].ToString();
                        txtCAdd.Text = rdr["customeraddress"].ToString();
                        txtPONo.Text = rdr["CustomerLandNo"].ToString();
                        comTem.Text = rdr["PaymentTerms"].ToString();
                        temp = true;
                    }
                    comJONo.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Sales Staff Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCCode.Text = "";
                        comCus.Text = "";
                        txtCAdd.Text = "";
                        txtPONo.Text = "";
                        comTem.Text = "";
                        txtCCode.Focus();
                    }
                    con.Close();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 3 / 4;
                TxtSer.Focus();
                label19.Text = "Customer Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
            }
        }

        private void txtCCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCCode.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from customer where CustomerCode=" + txtCCode.Text.Trim() + " ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        txtCCode.Text = rdr["CustomerCode"].ToString();
                        comCus.Text = rdr["CustomerName"].ToString();
                        txtCAdd.Text = rdr["customeraddress"].ToString();
                        txtPONo.Text = rdr["CustomerLandNo"].ToString();
                        comTem.Text = rdr["PaymentTerms"].ToString();
                        temp = true;
                    }
                    comJONo.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Sales Staff Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCCode.Text = "";
                        comCus.Text = "";
                        txtCAdd.Text = "";
                        txtPONo.Text = "";
                        comTem.Text = "";
                        txtCCode.Focus();
                    }
                    con.Close();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 3 / 4;
                TxtSer.Focus();
                label19.Text = "Customer Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
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
                    txtSSCode.Focus();
                }
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            txtCCode.Focus();
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (label19.Text == "Customer Details")
                {
                    cmd.CommandText = "select * from customer where CustomerCode Like '%" + TxtSer.Text + "%' or VATNumber Like '%" + TxtSer.Text + "%' or SVATNumber Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or customeraddress Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or CustomerLandNo Like '%" + TxtSer.Text + "%'";
                }
                else if (label19.Text == "Sales Staffs Details")
                {
                    cmd.CommandText = "select * from Salesman where BrokerNO Like '%" + TxtSer.Text + "%' or BrokerName Like '%" + TxtSer.Text + "%'";
                }
                else if (label19.Text == "Stock Items Details")
                {
                    cmd.CommandText = "select * from Item where StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
                }
                else if (label19.Text == "Locations Details")
                {
                    cmd.CommandText = "select * from Location where LocationNo Like '%" + TxtSer.Text + "%' or LocationName Like '%" + TxtSer.Text + "%'";
                }
                else if (label19.Text == "Job Order Details")
                {
                    cmd.CommandText = "select * from JobOrder where JobOrderNo Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or CustomerCode Like '%" + TxtSer.Text + "%'";
                }
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                DGViewSize();
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-553-MNU-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView2_DoubleClick(null, null);
            }
            else if (e.KeyCode == Keys.Down)
            {
                dataGridView2.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                groupBox2.Visible = false;
                txtCCode.Focus();
            }
        }

        private void txtSSCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSSCode.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from Salesman where BrokerNO=" + txtSSCode.Text.Trim() + " ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtSSCode.Text = rdr["BrokerNO"].ToString();
                        comSStf.Text = rdr["BrokerName"].ToString();
                    }
                    txtInvNo.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Sales Staff Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSSCode.Text = "";
                        comSStf.Text = "";
                        txtSSCode.Focus();
                    }
                    con.Close();
                    NextInvNo();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 3 / 4;
                TxtSer.Focus();
                label19.Text = "Sales Staffs Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
            }
        }

        private void comSStf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comSStf.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from Salesman where BrokerName='" + comSStf.Text.Trim() + "' ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtSSCode.Text = rdr["BrokerNO"].ToString();
                        comSStf.Text = rdr["BrokerName"].ToString();
                    }
                    txtInvNo.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Sales Staff Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSSCode.Text = "";
                        comSStf.Text = "";
                        txtSSCode.Focus();
                    }
                    con.Close();
                    NextInvNo();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 3 / 4;
                TxtSer.Focus();
                label19.Text = "Sales Staffs Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (label19.Text == "Customer Details")
            {
                txtCCode.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                comCus.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                txtCAdd.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                txtPONo.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                comTem.Text = dataGridView2.SelectedRows[0].Cells[11].Value.ToString();
                groupBox2.Visible = false;
                comJONo.Focus();
            }
            else if (label19.Text == "Sales Staffs Details")
            {
                txtSSCode.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                comSStf.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                groupBox2.Visible = false;
                NextInvNo();
                txtInvNo.Focus();
            }
            else if (label19.Text == "Stock Items Details")
            {
                txtStNo.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                comItm.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                txtUM.Text = dataGridView2.SelectedRows[0].Cells[15].Value.ToString();
                double aa = 0.00;
                aa = Convert.ToDouble(dataGridView2.SelectedRows[0].Cells[29].Value.ToString());
                txtURate.Text = aa.ToString("#,###.00");
                groupBox2.Visible = false;
                txtOdrQty.Focus();
            }
            else if (label19.Text == "Locations Details")
            {
                comLOC.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                groupBox2.Visible = false;
                CmdSave.Focus();
            }
            else if (label19.Text == "Job Order Details")
            {
                comJONo.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                groupBox2.Visible = false;
                txtSSCode.Focus();
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView2_DoubleClick(null, null);
            }
            else if (e.KeyCode == Keys.Down)
            {
                dataGridView2.Focus();
            }
        }

        private void txtRefNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRefNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comInvCat.Focus();
                }
            }
        }

        private void comInvCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comInvCat.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtINo.Text = (count + 1).ToString("00");
                    txtStNo.Focus();
                }
            }
        }

        private void txtInvNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInvNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtRefNo.Focus();
                    txtSerSale_TextChanged(null, null);
                }
            }
        }

        private void txtStNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtStNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from Item where StNo='" + txtStNo.Text.Trim() + "' ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        txtStNo.Text = rdr["StNo"].ToString();
                        comItm.Text = rdr["Des"].ToString();
                        txtUM.Text = rdr["UOMes"].ToString();
                        double aa = 0.00;
                        aa = Convert.ToDouble(rdr["CashPrice"].ToString());
                        txtURate.Text = aa.ToString("#,###.00");
                        temp = true;
                    }
                    txtOdrQty.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Sales Staff Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStNo.Text = "";
                        comItm.Text = "";
                        txtUM.Text = "";
                        txtURate.Text = "";
                        txtStNo.Focus();
                    }
                    con.Close();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 3 / 4;
                TxtSer.Focus();
                label19.Text = "Stock Items Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
            }
        }

        private void txtOdrQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txtOdrQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOdrQty.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double aaa = 0.00, bbb = 0.00, ccc = 0.00;
                    aaa = Convert.ToDouble(txtURate.Text.ToString());
                    bbb = Convert.ToDouble(txtOdrQty.Text.ToString());
                    ccc = aaa * bbb;
                    txtItmTotaa.Text = ccc.ToString("#,###.00");
                    comLOC.Focus();
                }
            }
        }

        private void comLOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comLOC.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from Location where LocationNo='" + comLOC.Text.Trim() + "' ", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                    }
                    CmdSave.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Sales Staff Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comLOC.Text = "";
                        comLOC.Focus();
                    }
                    con.Close();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 3 / 4;
                TxtSer.Focus();
                label19.Text = "Locations Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [ManufactureCompletedDetails] Where [Index]=" + selectedRow.Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSerSale_TextChanged(null, null);
                    txtStNo.Enabled = true;
                    cmdRe.Enabled = true;
                    txtStNo.Focus();
                }
                else
                {
                    txtStNo.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-DEL-915-MNU-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSerSale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ManufactureCompletedDetails where BillNumber='" + txtInvNo.Text + "'";
                //cmd.CommandText = "select * from table1 where sname='" + textBox1.Text + "' and city='"+textBox2.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtCCode.Text = rdr["CustomerCode"].ToString();
                    comCus.Text = rdr["CustomerName"].ToString();
                    txtCAdd.Text = rdr["customeraddress"].ToString();
                    txtSSCode.Text = rdr["MarketingStaffCode"].ToString();
                    comSStf.Text = rdr["MarketingStaffName"].ToString();
                    dtpInvDate.Text = rdr["BillDate"].ToString();
                    txtRefNo.Text = rdr["ManualReferenceNo"].ToString();
                    comInvCat.Text = rdr["BillCategory"].ToString();
                    txtTAmo.Text = rdr["ItemTotal"].ToString();
                    txtPONo.Text = rdr["PONumber"].ToString();
                    comTem.Text = rdr["PaymentTerms"].ToString();
                    comJONo.Text = rdr["JobOrderNo"].ToString();
                    txtStNo.Enabled = false;
                    cmdRe.Enabled = false;
                }
                con.Close();
                if (count > 0)
                {
                    double ca2 = 0.00, ca3 = 0.00, ca4 = 0.00, ca5 = 0.00;
                    double cq = 0;
                    for (int ca1 = 0; ca1 < count; ca1++)
                    {
                        ca2 = Convert.ToDouble(dataGridView1.Rows[ca1].Cells[13].Value.ToString());
                        ca3 = ca3 + ca2;
                        txtTAmo.Text = ca3.ToString("#,###.00");
                        ca4 = ca3 * 8 / 100;
                        txtEOVAT.Text = ca4.ToString("#,###.00");
                        txtVAT.Text = ca4.ToString("#,###.00");
                        ca5 = ca3 - 2 * ca4;
                        txtGraTot.Text = ca5.ToString("#,###.00");
                        dataGridView1.Rows[ca1].Cells[6].Value = (ca1 + 1).ToString();
                        txtINo.Text = (ca1 + 2).ToString("00");
                        lblLItm.Text = (ca1 + 1).ToString();
                        cq = cq + Convert.ToDouble(dataGridView1.Rows[ca1].Cells[11].Value.ToString());
                    }
                    lblTQty.Text = cq.ToString();
                }
                else
                {
                    if (txtRefNo.Text != "")
                    {
                        Blank2();
                        txtINo.Text = "";
                        txtCCode.Focus();
                        txtStNo.Enabled = true;
                        cmdRe.Enabled = true;
                    }
                }
                DGViewSizeS();
                DGViewSizeS();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SERS-CNG-991-MNU-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                x.MinimumHeight = 21;
            }
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dataGridView2.Rows)
            {
                x.MinimumHeight = 24;
            }
        }

        private void cmdClr_Click(object sender, EventArgs e)
        {
            Blank();
            txtStNo.Text = "";
            comLOC.Text = "";
            txtStNo.Focus();
        }

        private void cmdBlank_Click(object sender, EventArgs e)
        {
            Blank2();
            txtCCode.Text = "";
            txtCCode.Focus();
        }

        private void cmdRe_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Refresh();
            txtSerSale_TextChanged(null, null);
            TxtSer_TextChanged(null, null);
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            txtStNo.Enabled = true;
            cmdRe.Enabled = true;
            txtStNo.Focus();
            this.Refresh();
            Refresh();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into ManufactureCompletedDetails(BillNumber, BillDate, BillCategory, CustomerCode, CustomerName, BillItemNumber, StockNumber, Description, UnitOfMeasure, BillQuantity, ItemAmount, ItemTotal, LocationID, ManualReferenceNo, GrandTotal, MarketingStaffCode, MarketingStaffName, CustomerAddress, PONumber, PaymentTerms, JobOrderNo) values('"
                  + txtInvNo.Text + "', '"
                  + dtpInvDate.Value.ToString() + "', '"
                  + comInvCat.Text + "', '"
                  + txtCCode.Text.ToString() + "', '"
                  + comCus.Text + "', '"
                  + txtINo.Text.ToString() + "', '"
                  + txtStNo.Text + "', '"
                  + comItm.Text + "', '"
                  + txtUM.Text + "', '"
                  + txtOdrQty.Text.ToString() + "', '"
                  + txtURate.Text.ToString() + "', '"
                  + txtItmTotaa.Text + "', '"
                    + comLOC.Text + "', '"
                    + txtRefNo.Text + "', '"
                    + txtTAmo.Text.ToString() + "', '"
                    + txtSSCode.Text.ToString() + "', '"
                    + comSStf.Text + "', '"
                    + txtCAdd.Text + "', '"
                    + txtPONo.Text + "', '"
                    + comTem.Text + "', '"
                    + comJONo.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSerSale_TextChanged(null, null);
                txtStNo.Text = "";
                Blank();
                txtINo.Text = (count + 1).ToString("00");
                txtStNo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-1093-MNU-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void txtSSCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void FrmMnuInv_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
        }

        private void comJONo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comJONo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from JobOrder where JobOrderNo='" + comJONo.Text.Trim() + "'", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                    }
                    txtSSCode.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Press F2 Key for Job Order Selection List.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comJONo.Text = "";
                        comJONo.Focus();
                    }
                    con.Close();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                groupBox2.Visible = true;
                groupBox2.Location = groupBox1.Location;
                groupBox2.Size = groupBox1.Size;
                dataGridView2.Height = (groupBox2.Height) * 8 / 10;
                TxtSer.Focus();
                label19.Text = "Job Order Details";
                TxtSer.Text = "";
                TxtSer_TextChanged(null, null);
            }
        }
    }
}
