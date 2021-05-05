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
    public partial class FrmChqPaySupList : Form
    {
        public static string Lst = ""; // Selection Name
        int count = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[0].DefaultCellStyle.Format = "D2";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 240;

            dataGridView1.Columns[0].HeaderText = " SNo";
            dataGridView1.Columns[1].HeaderText = " Supplier Name";

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Suppliers";
            buttonColumn.HeaderText = " Details";
            buttonColumn.Text = " Report";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(2, buttonColumn);
            dataGridView1.Columns[2].Width = 95;

            for (int ca1 = 0; ca1 < count; ca1++)
            {
                dataGridView1.Rows[ca1].Cells[0].Value = ca1 + 1;
            }
        }

        public FrmChqPaySupList()
        {
            InitializeComponent();
        }

        private void FrmChqPaySupList_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Height = FrmMain.ActiveForm.Height;
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Lst = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FrmChkPaySupRep FChkPaySupRep = new FrmChkPaySupRep();
            FChkPaySupRep.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FChkPaySupRep.Show();
            this.Visible = false;
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select COUNT(PVNo), Sup from VoucherChequePayment GROUP BY Sup";
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
                MessageBox.Show("ERROR CODE : SER-CNG-103-STAX-INVR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
