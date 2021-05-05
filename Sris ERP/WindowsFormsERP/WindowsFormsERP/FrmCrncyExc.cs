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
    public partial class FrmCrncyExc : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtCrName.Text = "";
            dtpRCDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtRate.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comCrCode.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCrName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dtpRCDate.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            double aa = 0.00;
            aa = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            txtRate.Text = aa.ToString("#,###.00");
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 68;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.Columns[3].Width = 88;
            dataGridView1.Columns[4].Width = 95;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
        }

        private void ComList()
        {
            try
            {                
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from CurrencyReg where CrCode Like '%" + TxtSer.Text + "%'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comCrCode.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt1.Rows)
                {
                    comCrCode.Items.Add(dr["CrCode"].ToString());
                }
                con.Close();                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-73-CCY-EXC" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmCrncyExc()
        {
            InitializeComponent();
        }

        private void FrmCrncyExc_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from CurrencyReg where CrCode='" + comCrCode.Text.Trim() + "'", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                txtCrName.Text = rdr["CrName"].ToString();
                temp = true;
            }
            dtpRCDate.Focus();
            if (temp == false)
            {
                MessageBox.Show("Record Not Found! Click Drop Down List and Select the Currency Code.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Blank();
                comCrCode.Text = "";
                comCrCode.Focus();
            }
            con.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into CurrencyExc(CrCode, CrName, RCDate, Rate) values('"
                    + comCrCode.Text + "', '" + txtCrName.Text + "', '" + dtpRCDate.Value.ToString() + "', '" + txtRate.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comCrCode.Text = "";
                Blank();
                comCrCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-129-CCY-EXC" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update CurrencyExc SET CrCode='" + comCrCode.Text + "', CrName='" + txtCrName.Text + "', RCDate='" + dtpRCDate.Value.ToString() + "', Rate='" + txtRate.Text.ToString()
                    + "' WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comCrCode.Text = "";
                Blank();
                comCrCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-149-CCY-EXC" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [CurrencyExc] Where [id]=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comCrCode.Text = "";
                    Blank();
                    comCrCode.Focus();
                }
                else
                {
                    comCrCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-176-CCY-EXC" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [CurrencyExc] Where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-192-CCY-EXC" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from CurrencyExc where CrCode Like '%" + TxtSer.Text + "%' or CrName Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-216-CCY-EXC" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comCrCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comCrCode.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        comboBox1_SelectedIndexChanged(null, null);
                    }
                }
                catch (Exception x)
                {
                 //   MessageBox.Show(x + "  Error No:CrnExkedw01 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCrName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpRCDate.Focus();
                }
            }
        }

        private void dtpRCDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                txtRate.Focus();
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRate.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double aa = 0.00;
                    aa = Convert.ToDouble(txtRate.Text.ToString());
                    txtRate.Text = aa.ToString("#,###.00");
                    CmdSave.Focus();
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comCrCode_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
