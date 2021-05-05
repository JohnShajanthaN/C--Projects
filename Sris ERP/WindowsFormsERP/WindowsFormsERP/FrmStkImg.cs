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
    public partial class FrmStkImg : Form
    {
        int count = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void ImgSize()
        {
          //  this.Controls.Add(dataGridView1);

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Name = "dataGridView1";
           // dataGridView1.Location = new Point(1000, 1000);
          //  dataGridView1.Size = new Size(500, 250);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
             dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
          //  dataGridView1.Dock = DockStyle.Fill;

        }

        private void DGViewSize()
        {
           // dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 16);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false; //.Width = 150;
            dataGridView1.Columns[2].Visible = false; //.Width = 250;
            dataGridView1.Columns[3].Visible = false; //.Width = 200;
            dataGridView1.Columns[4].Visible = false; //.Width = 200;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
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
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[28].Width = 600;
            dataGridView1.Columns[26].Width = 549;
            dataGridView1.Columns[26].HeaderText = " Full Details";
            dataGridView1.Columns[28].HeaderText = " Image";
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;
            string ca2 = "", ca3 = "";
            for (int ca1 = 0; ca1 < count; ca1++)
            {
                double aa = 0.00;
                aa = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[29].Value.ToString());
                ca3 = aa.ToString("#,###.00");

                ca2 = dataGridView1.Rows[ca1].Cells[3].Value.ToString()
                    + " " + dataGridView1.Rows[ca1].Cells[2].Value.ToString()
                    + " (" + dataGridView1.Rows[ca1].Cells[4].Value.ToString()
                    + ") - " + dataGridView1.Rows[ca1].Cells[1].Value.ToString()
                    + "  Rs. " + ca3.ToString();
                dataGridView1.Rows[ca1].Cells[26].Value = (ca2).ToString();
            }
            dataGridView1.ClearSelection();
        }
        public FrmStkImg()
        {
            InitializeComponent();
        }

        private void FrmStkImg_Load(object sender, EventArgs e)
        {
            ImgSize();
            TxtSer_TextChanged_1(null, null);
        }

        private void TxtSer_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Item where StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
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
                MessageBox.Show("ERROR CODE : SER-CNG-131-STK-IMG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdSer_Click(object sender, EventArgs e)
        {
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();
        }
    }
}
