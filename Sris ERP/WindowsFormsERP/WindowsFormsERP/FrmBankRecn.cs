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
    public partial class FrmBankRecn : Form
    {
        public int r, x, y;
        public OleDbDataAdapter ada = new OleDbDataAdapter();
        public OleDbCommandBuilder cmd = new OleDbCommandBuilder();
        public DataRow drow;
        public DataTable dt = new DataTable();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;

        private void Blank()
        {
            //  txtDes.Text = "";            
            //  dtpDoMFR.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //  picImg.Image = null;
            //TxtSer.Text = "";
            //  TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            //   txtStNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //   dtpDoMFR.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[19].Value);
        }

        private void DGViewSize()
        {
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Width = 30;
            //dataGridView1.Columns[2].Width = 70;
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

        public FrmBankRecn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBankRecn_Load(object sender, EventArgs e)
        {
            con.Open();
            ada = new OleDbDataAdapter("select * from BankReconciliation", con);

            cmd = new OleDbCommandBuilder(ada);

            dt = new DataTable();

            cmd = new OleDbCommandBuilder(ada);

            ada.Fill(dt);

            dataGridView1.DataSource = dt;

            //  lblUser1.Text = FrmMain.uname;
            // lblULevel1.Text = FrmMain.ul;
            // TxtSer_TextChanged(null, null);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {

        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtGLAcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGLAcNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtAcNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAcNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //comKW.Focus();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 9)
            //{
            //    if (e.Value is bool)
            //    {
            //        bool value = (bool)e.Value;
            //        e.Value = (value) ? "Yes" : "No";
            //        e.FormattingApplied = true;
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (comboBox1.SelectedIndex == 0)
            {
                dt.Clear();
                ada = new OleDbDataAdapter("SELECT * FROM [BankReconciliation] WHERE [Datee] between #" + dtpFDate.Text + "# and #" + dtpTDate.Text + "# and [accno]  Like  '%" + txtFind.Text + "%'", con);
                cmd = new OleDbCommandBuilder(ada);
                dt = new DataTable();
                cmd = new OleDbCommandBuilder(ada);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                dt.Clear();
                ada = new OleDbDataAdapter("SELECT * FROM [BankReconciliation] WHERE [Datee] between #" + dtpFDate.Text + "# and #" + dtpTDate.Text + "# and [bankname]  Like  '%" + txtFind.Text + "%'", con);
                cmd = new OleDbCommandBuilder(ada);
                dt = new DataTable();
                cmd = new OleDbCommandBuilder(ada);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                dt.Clear();
                ada = new OleDbDataAdapter("SELECT * FROM [BankReconciliation] WHERE [Datee] between #" + dtpFDate.Text + "# and #" + dtpTDate.Text + "# and [transno]  Like  '%" + txtFind.Text + "%'", con);
                cmd = new OleDbCommandBuilder(ada);
                dt = new DataTable();
                cmd = new OleDbCommandBuilder(ada);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                dt.Clear();
                ada = new OleDbDataAdapter("SELECT * FROM [BankReconciliation] WHERE [Datee] between #" + dtpFDate.Text + "# and #" + dtpTDate.Text + "# and [glaccno]  Like  '%" + txtFind.Text + "%'", con);
                cmd = new OleDbCommandBuilder(ada);
                dt = new DataTable();
                cmd = new OleDbCommandBuilder(ada);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               // r = dataGridView1.CurrentCell.RowIndex;
                txtGLAcNo.Text = "" + dt.Rows[r]["glaccno"].ToString();
                txtAcNo.Text = "" + dt.Rows[r]["accno"].ToString();
                txtBAc.Text = "" + dt.Rows[r]["bankname"].ToString();

                decimal Totalpay = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Totalpay += Convert.ToDecimal(dataGridView1.Rows[i].Cells["payment"].Value);
                }
                payta.Text = " " + Totalpay.ToString();

                decimal Totalde = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Totalde += Convert.ToDecimal(dataGridView1.Rows[i].Cells["deposit"].Value);
                }
                deta.Text = " " + Totalde.ToString();

                decimal Totalnopay = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(dataGridView1.Rows[i].Cells["payment"].Value) == 0)
                    {

                    }
                    else
                    {
                        Totalnopay += 1;
                    }
                }
                paytno.Text = " " + Totalnopay.ToString();

                decimal Totalnodepo = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(dataGridView1.Rows[i].Cells["deposit"].Value) == 0)
                    {

                    }
                    else
                    {
                        Totalnodepo += 1;
                    }
                }
                detno.Text = " " + Totalnodepo.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            ada = new OleDbDataAdapter("select * from BankReconciliation", con);
            cmd = new OleDbCommandBuilder(ada);
            dt = new DataTable();
            cmd = new OleDbCommandBuilder(ada);
            ada.Fill(dt);

            if (comboBox1.SelectedIndex == 0)
            {
                txtFind.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    txtFind.Items.Add(dt.Rows[i]["accno"].ToString());
            }

            if (comboBox1.SelectedIndex == 1)
            {
                txtFind.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    txtFind.Items.Add(dt.Rows[i]["bankname"].ToString());
            }

            if (comboBox1.SelectedIndex == 2)
            {
                txtFind.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    txtFind.Items.Add(dt.Rows[i]["transno"].ToString());
            }

            if (comboBox1.SelectedIndex == 3)
            {
                txtFind.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    txtFind.Items.Add(dt.Rows[i]["glaccno"].ToString());
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            //  uname = lblUser1.Text;
            //  ul = lblULevel1.Text;
            //  FrmStkRep FStkRep = new FrmStkRep();
            // FStkRep.Show();
        }
    }
}
