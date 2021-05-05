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
    public partial class FrmUControl : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            txtAge.Text = "";
            txtDes.Text = "";
            txtFName.Text = "";
            txtGen.Text = "";
            txtName.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            /*
            comUID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();            
            txtULevel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtFName.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtDes.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();            
            txtGen.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            treeView1.Nodes[0].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[16].Value.ToString());
            treeView1.Nodes[0].Nodes[0].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[17].Value.ToString());
            treeView1.Nodes[0].Nodes[1].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[18].Value.ToString());
            treeView1.Nodes[0].Nodes[2].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[19].Value.ToString());
            treeView1.Nodes[0].Nodes[3].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[20].Value.ToString());
            treeView1.Nodes[0].Nodes[4].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[35].Value.ToString());
            treeView1.Nodes[1].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[21].Value.ToString());
            treeView1.Nodes[2].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[22].Value.ToString());
            treeView1.Nodes[3].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[23].Value.ToString());
            treeView1.Nodes[4].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[24].Value.ToString());
            treeView1.Nodes[5].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[25].Value.ToString());
            treeView1.Nodes[6].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[26].Value.ToString());
            treeView1.Nodes[7].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[27].Value.ToString());
            treeView1.Nodes[8].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[28].Value.ToString());
            treeView1.Nodes[9].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[29].Value.ToString());
            treeView1.Nodes[10].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[30].Value.ToString());
            treeView1.Nodes[11].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[31].Value.ToString());
            treeView1.Nodes[12].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[32].Value.ToString());
            treeView1.Nodes[13].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[33].Value.ToString());
            treeView1.Nodes[14].Checked = bool.Parse(dataGridView1.SelectedRows[0].Cells[34].Value.ToString());
            */
        }

        private void DGViewSize()
        {
            /*
            dataGridView1.Columns[0].HeaderText = " INo";
            dataGridView1.Columns[1].HeaderText = " ID";
            dataGridView1.Columns[2].HeaderText = " Name";
            dataGridView1.Columns[4].HeaderText = " U.Level";
            //dataGridView1.Columns[6].HeaderText = " Full Name";
            dataGridView1.Columns[7].HeaderText = " Designation";
            //dataGridView1.Columns[8].HeaderText = " Gender";
            //dataGridView1.Columns[9].HeaderText = " Age";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 155;
            dataGridView1.Columns[4].Width = 122;
            dataGridView1.Columns[7].Width = 165;            
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
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
            */
        }

        public FrmUControl()
        {
            InitializeComponent();
        }

        private void FrmUControl_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer.Text = "A";
            TxtSer_TextChanged(null, null);
            TxtSer.Text = "";
            comList();
           
            //  comUID_KeyDown(null, null);
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [UserDetails] Where Index=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-159-USR-CTRL" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                comUID.Items.Clear();
                //comPlace.Items.Clear();
                //comUserLevel.Items.Clear();
                foreach (DataRow dr6 in dt6.Rows)
                {
                    comUID.Items.Add(dr6["UserName"].ToString());
                    // comPlace.Items.Add(dr6["Place"].ToString());
                    //comUserLevel.Items.Add(dr6["UserLevel"].ToString());
                }
                con.Close();
            }
            catch (Exception)
            {
                //  MessageBox.Show(x + "  Error No:URser01 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comUID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comUID.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comUID.Text)
                            {
                                string txt = "SELECT * FROM [UserDetails] Where UserID='" + comUID.Text.ToString() + "'";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                fromDGView();
                            }
                        }
                        treeView1.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : UID-KDW-233-USR-CTRL" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update UserDetails SET NSystem='" + treeView1.Nodes[0].Checked.ToString()
                + "', NNewUser='" + treeView1.Nodes[0].Nodes[0].Checked.ToString()
                    + "', NUserLogin='" + treeView1.Nodes[0].Nodes[1].Checked.ToString()
                    + "', NUserControl='" + treeView1.Nodes[0].Nodes[2].Checked.ToString()
                    + "', NUserLevel='" + treeView1.Nodes[0].Nodes[3].Checked.ToString()
                    + "', NExit='" + treeView1.Nodes[0].Nodes[4].Checked.ToString()
                    + "', NInvoice='" + treeView1.Nodes[1].Checked.ToString()
                    + "', NPurchase='" + treeView1.Nodes[2].Checked.ToString()
                    + "', NJobOrder='" + treeView1.Nodes[3].Checked.ToString()
                    + "', NPayments='" + treeView1.Nodes[4].Checked.ToString()
                    + "', NCheque='" + treeView1.Nodes[5].Checked.ToString()
                    + "', NBank='" + treeView1.Nodes[6].Checked.ToString()
                    + "', NAccounts='" + treeView1.Nodes[7].Checked.ToString()
                    + "', NStockItem='" + treeView1.Nodes[8].Checked.ToString()
                    + "', NCustomer='" + treeView1.Nodes[9].Checked.ToString()
                    + "', NVendor='" + treeView1.Nodes[10].Checked.ToString()
                    + "', NInventoryItems='" + treeView1.Nodes[11].Checked.ToString()
                    + "', NFixedAssets='" + treeView1.Nodes[12].Checked.ToString()
                    + "', NMiscellaneous='" + treeView1.Nodes[13].Checked.ToString()
                    + "', NReports='" + treeView1.Nodes[14].Checked.ToString()
                        + "' WHERE UserName='" + comUID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comUID.Text = "";
                Blank();
                comUID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-272-USR-CTRL" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                comUID.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt.Rows)
                {
                    comUID.Items.Add(dr["UserName"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                con.Close();
                MessageBox.Show("ERROR CODE : COM-LST-118-MEI" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void user_permission()
        {           
            //string user_level;

            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserName='" + comUID.Text.ToString() + "' ", con);
            cmd1.Connection = con;
            OleDbDataReader rdr = cmd1.ExecuteReader();

            rdr.Read();
            //user_level = rdr["UserLevel"].ToString();

            treeView1.Nodes[0].Checked = false;
            treeView1.Nodes[0].Nodes[0].Checked = false;
            treeView1.Nodes[0].Nodes[1].Checked = true;
            treeView1.Nodes[0].Nodes[2].Checked = false;
            treeView1.Nodes[0].Nodes[3].Checked = false;
            treeView1.Nodes[0].Nodes[4].Checked =Convert.ToBoolean(rdr["NExit"].ToString());
            treeView1.Nodes[1].Checked = Convert.ToBoolean(rdr["NInvoice"].ToString());
            treeView1.Nodes[2].Checked = Convert.ToBoolean(rdr["NPurchase"].ToString());
            treeView1.Nodes[3].Checked = Convert.ToBoolean(rdr["NJobOrder"].ToString());
            treeView1.Nodes[4].Checked = Convert.ToBoolean(rdr["NPayments"].ToString());
            treeView1.Nodes[5].Checked = Convert.ToBoolean(rdr["NCheque"].ToString());
            treeView1.Nodes[6].Checked = Convert.ToBoolean(rdr["NBank"].ToString());
            treeView1.Nodes[7].Checked = Convert.ToBoolean(rdr["NAccounts"].ToString());
            treeView1.Nodes[8].Checked = Convert.ToBoolean(rdr["NStockItem"].ToString());
            treeView1.Nodes[9].Checked = Convert.ToBoolean(rdr["NCustomer"].ToString());
            treeView1.Nodes[10].Checked = Convert.ToBoolean(rdr["NVendor"].ToString());
            treeView1.Nodes[11].Checked = Convert.ToBoolean(rdr["NInventoryItems"].ToString());
            treeView1.Nodes[12].Checked = Convert.ToBoolean(rdr["NFixedAssets"].ToString());
            treeView1.Nodes[13].Checked = Convert.ToBoolean(rdr["NMiscellaneous"].ToString());
            treeView1.Nodes[14].Checked = Convert.ToBoolean(rdr["NReports"].ToString());

            con.Close();
         
            
        }

        private void comUID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comUID.Text == "")
            {
                MessageBox.Show("Choose The UserName From DropDown List!!!" + "\n" + "\n" + "\n" + "MORE DETAILS :- ", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user_permission();
            }
        }

        private void cmdDefolt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blank();
            Refresh();
            this.Refresh();
        }
    }
}     
