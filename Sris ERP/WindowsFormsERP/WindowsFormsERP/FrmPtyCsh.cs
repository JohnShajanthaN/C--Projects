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
    public partial class FrmPtyCsh : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {            
            txtPNo.Text = (count + 1).ToString("00");
            dtpPaidDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comDes.Text = "";
            txtPCS.Text = "";
            txtUPri.Text = "";
            txtAmo.Text = "";
            // txtStNo.Enabled = true;
        }

        private void Blank2()
        {
            Blank();
            txtVNo.Text = "";
            dtpPDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtPName.Text = "";
            //txtIOUAmo.Text = "0.00";
            //txtSTot.Text = "0.00";
            //txtTAmo.Text = "0.00";
           // txtUPri.Text = bbb.ToString("#,###.00");
        }        

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 12);
            //dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14);
            dataGridView1.Font = new Font("Arial", 11);
            dataGridView1.Columns[4].DefaultCellStyle.Format = "D2";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "D2";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[9].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[4].HeaderText = " No";
            dataGridView1.Columns[5].HeaderText = " Payment Date";
            dataGridView1.Columns[6].HeaderText = " Description";
            dataGridView1.Columns[7].HeaderText = " PCS";
            dataGridView1.Columns[8].HeaderText = " UnitPrice (Rs.)";
            dataGridView1.Columns[9].HeaderText = " Amount (Rs.)";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;

            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[5].Width = 165;
            dataGridView1.Columns[6].Width = 469;
            dataGridView1.Columns[7].Width = 65;
            dataGridView1.Columns[8].Width = 155;
            dataGridView1.Columns[9].Width = 155;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from PettyCash ";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                da5.Fill(dt5);
                comDes.Items.Clear();
                foreach (DataRow dr in dt5.Rows)
                {
                    comDes.Items.Add(dr["Des"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-104-PTY-CSH" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmPtyCsh()
        {
            InitializeComponent();
        }

        private void FrmPtyCsh_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            ComList();
            count = 0;
            txtSerP_TextChanged(null, null);

            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void txtVNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtVNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSerP_TextChanged(null, null);
                    txtIOUNo.Focus();
                }
            }            
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPNo.Text = (count + 1).ToString("00");
                    dtpPaidDate.Focus();
                }
            }
        }

        private void CmdVPrint_Click(object sender, EventArgs e)
        {
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

        private void dtpPDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPName.Focus();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
              //  OleDbCommand cmd = new OleDbCommand("Insert into PettyCash(VoucherNo, PDate, PName, PNo, PaidDate, Des, PCS, UPri, Amount, IOUAmo, STot, TAmo) values('"
                OleDbCommand cmd = new OleDbCommand("Insert into PettyCash(VoucherNo, PDate, PName, PNo, PaidDate, Des, PCS, UPri, Amount, IOUAmo, STot, TAmo) values('"
                  + txtVNo.Text + "', '"
                  + dtpPDate.Value.ToString() + "', '"
                  + txtPName.Text + "', '"
                  + txtPNo.Text.ToString() + "', '"
                  + dtpPaidDate.Value.ToString() + "', '"
                  + comDes.Text + "', '"
                  + txtPCS.Text.ToString() + "', '"
                  + txtUPri.Text.ToString() + "', '"
                  + txtAmo.Text.ToString() + "', '"
                  + txtIOUAmo.Text.ToString() + "', '"
                  + txtSTot.Text.ToString() + "', '"
                  + txtTAmo.Text.ToString()
                  + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSerP_TextChanged(null, null);
                // comDes.Text = "";
                Blank();
                txtPNo.Text = (count + 1).ToString("00");
                dtpPaidDate.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-ADD-300-PTY-CSH" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [PettyCash] Where [ID]=" + selectedRow.Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSerP_TextChanged(null, null);
                   // txtStNo.Enabled = true;
                    dtpPaidDate.Focus();
                }
                else
                {
                    dtpPaidDate.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-330-PTY-CSH" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPCS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)189 && e.KeyChar != (char)46 && e.KeyChar != (char)108 && e.KeyChar != (char)44;
        }

        private void txtUPri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUPri.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double aaa = 0.00, bbb = 0.00, ccc = 0.00;
                    aaa = Convert.ToDouble(txtPCS.Text.ToString());
                    bbb = Convert.ToDouble(txtUPri.Text.ToString());
                    ccc = aaa * bbb;
                    txtUPri.Text = bbb.ToString("#,###.00");
                    txtAmo.Text = ccc.ToString("#,###.00");
                    cmdAdd.Focus();
                }
            }
        }

        private void txtSerP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from PettyCash where VoucherNo='" + txtVNo.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtVNo.Text = rdr["VoucherNo"].ToString();
                    dtpPDate.Text = rdr["PDate"].ToString();
                    txtPName.Text = rdr["PName"].ToString();                    
                    txtIOUAmo.Text = rdr["IOUAmo"].ToString();
                    txtSTot.Text = rdr["STot"].ToString();
                    txtTAmo.Text = rdr["TAmo"].ToString();
                    double ddd = 0.00;
                    ddd = Convert.ToDouble(txtIOUAmo.Text.ToString());
                    txtIOUAmo.Text = ddd.ToString("#,##0.00");
                    ddd = Convert.ToDouble(txtSTot.Text.ToString());
                    txtSTot.Text = ddd.ToString("#,##0.00");
                    ddd = Convert.ToDouble(txtTAmo.Text.ToString());
                    txtTAmo.Text = ddd.ToString("#,##0.00");
                    // txtStNo.Enabled = false;
                }
                con.Close();
                if (count > 0)
                {

                    double ca2 = 0.00, ca3 = 0.00, ca4 = 0.00, ca5 = 0.00;
                    for (int ca1 = 0; ca1 < count; ca1++)
                    {
                        ca2 = Convert.ToDouble(dataGridView1.Rows[ca1].Cells[9].Value.ToString());
                        ca3 = ca3 + ca2;
                        txtSTot.Text = ca3.ToString("#,###.00");
                        ca4 = Convert.ToDouble(dataGridView1.Rows[ca1].Cells[10].Value.ToString());
                        ca5 = ca4 - ca3;
                        txtTAmo.Text = ca5.ToString("#,###.00");
                    }
                }
                else
                {
                    //if (txtRefNo.Text != "")
                    //{
                    //    Blank2();
                    //    txtINo.Text = "";
                    //    txtCCode.Focus();
                    //    txtStNo.Enabled = true;
                    //}
                }
                DGViewSize();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SERP-CNG-429-PTY-CSH" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                x.MinimumHeight = 24;
            }
        }

        private void cmdClr_Click(object sender, EventArgs e)
        {
            Blank();
            comDes.Text = "";
            dtpPaidDate.Focus();
        }

        private void cmdBlank_Click(object sender, EventArgs e)
        {
            Blank2();
            txtVNo.Text = "";
            txtVNo.Focus();
        }

        private void cmdRe_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Refresh();
            txtSerP_TextChanged(null, null);
            dataGridView1.Refresh();
           // comDes.Enabled = true;
            dtpPaidDate.Focus();
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

        private void FrmPtyCsh_ClientSizeChanged(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void CmdExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpPaidDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comDes.Focus();
            }
        }

        private void comDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPCS.Focus();
                }
            }
        }

        private void txtPCS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPCS.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtUPri.Focus();
                }
            }
        }

        private void txtIOUNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIOUNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from IOU where IOUNo='" + txtIOUNo.Text.Trim() + "'", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                        txtIOUAmo.Text = rdr["Total"].ToString();
                        txtPName.Text = rdr["IOUName"].ToString();
                    }
                    dtpPDate.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Please Check this IOU No on IOU Details.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIOUAmo.Text = "";
                      //  comSStf.Text = "";
                        txtIOUNo.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
