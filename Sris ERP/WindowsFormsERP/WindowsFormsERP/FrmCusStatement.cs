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
    public partial class FrmCusStatement : Form
    {
        public static string cus = "";
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
            dataGridView1.Columns[1].HeaderText = " Customer Name";

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Customers";
            buttonColumn.HeaderText = " Details";
            buttonColumn.Text = " Statement";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(2, buttonColumn);
            dataGridView1.Columns[2].Width = 95;

            for (int ca1 = 0; ca1 < count; ca1++)
            {
                dataGridView1.Rows[ca1].Cells[0].Value = ca1 + 1;
            }           
        }

       
        public FrmCusStatement()
        {
            InitializeComponent();
        }

        private void FrmCusStatement_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Height = FrmMain.ActiveForm.Height;
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdPDFExit_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select COUNT(JobOrderNo), CustomerName from JOPayment GROUP BY CustomerName";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cus = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FrmCusSta FCusSta = new FrmCusSta();
            FCusSta.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FCusSta.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cus = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //MessageBox.Show(cus);
            FrmCusSta FCusSta = new FrmCusSta();
            FCusSta.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FCusSta.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cus = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //MessageBox.Show(cus);
            FrmCusSta FCusSta = new FrmCusSta();
            FCusSta.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FCusSta.Show();
            this.Visible = false;
        }
    }
}
