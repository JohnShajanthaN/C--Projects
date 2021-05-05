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
    public partial class FrmIOU : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            txtAmount.Text = "0.00";
        }

        private void Blank2()
        {
            Blank();
            txtIOUName.Text = "";
            txtBrAmount.Text = "0.00";
            txtReason.Text = "";
            comItem.Text = "";
            txtTotal.Text = "0.00";
            dtpIOUDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpPRDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpSPfDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpSptDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpStlDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Arial", 11);           

            dataGridView1.Columns[11].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[10].HeaderText = " Item";
            dataGridView1.Columns[11].HeaderText = " Amount (Rs.)";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[12].Visible = false;

            dataGridView1.Columns[10].Width = 800;
            dataGridView1.Columns[11].Width = 316;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from IOU ";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                da5.Fill(dt5);
                comItem.Items.Clear();
                foreach (DataRow dr in dt5.Rows)
                {
                    comItem.Items.Add(dr["Item"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-88-IOU" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmIOU()
        {
            InitializeComponent();
        }

         private void FrmIOU_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            ComList();
            count = 0;
            txtSerIOU_TextChanged(null, null);

            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
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
                    txtSerIOU_TextChanged(null, null);
                    dtpIOUDate.Focus();
                }
            }
        }

        private void txtIName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIOUName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtBrAmount.Focus();
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIOU_ClientSizeChanged(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void dtpStlDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                   // txtPNo.Text = (count + 1).ToString("00");
                    comItem.Focus();
            }
        }

        private void dtpIOUDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIOUName.Focus();
            }
        }

        private void dtpSPfDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpSptDate.Focus();
            }
        }

        private void dtpSptDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpPRDate.Focus();
            }
        }

        private void dtpPRDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpStlDate.Focus();
            }
        }

        private void txtBrAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double bbb = 0.00;
                bbb = Convert.ToDouble(txtBrAmount.Text.ToString());
                if (txtBrAmount.Text == "" || bbb<1)
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double aaa = 0.00;
                    aaa = Convert.ToDouble(txtBrAmount.Text.ToString());
                    txtBrAmount.Text = aaa.ToString("#,###.00");
                    txtReason.Focus();
                }
            }
        }

        private void txtReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtReason.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpSPfDate.Focus();
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into IOU(IOUNo, IOUDate, IOUName, BrAmount, Reason, SPfDate, SptDate, PRDate, StlDate, Item, Amount, Total) values('"
                  + txtIOUNo.Text + "', '"
                  + dtpIOUDate.Value.ToString() + "', '"
                  + txtIOUName.Text + "', '"
                  + txtBrAmount.Text.ToString() + "', '"
                  + txtReason.Text + "', '"
                  + dtpSPfDate.Value.ToString() + "', '"
                  + dtpSptDate.Value.ToString() + "', '"
                  + dtpPRDate.Value.ToString() + "', '"
                  + dtpStlDate.Value.ToString() + "', '"
                  + comItem.Text + "', '"
                  + txtAmount.Text.ToString() + "', '"
                  + txtTotal.Text.ToString()
                  + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSerIOU_TextChanged(null, null);

                OleDbCommand cmd2 = new OleDbCommand("Update IOU SET Total='" + txtTotal.Text.ToString()
                    + "' WHERE IOUNo='" + txtIOUNo.Text + "'", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                comItem.Text = "";
               // txtIOUNo.Text = "";
                Blank();
              //  txtPNo.Text = (count + 1).ToString("00");
                comItem.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-ADD-325-IOU" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string txt = "DELETE FROM [IOU] Where [ID]=" + selectedRow.Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSerIOU_TextChanged(null, null);
                    // txtStNo.Enabled = true;
                    comItem.Focus();
                }
                else
                {
                    comItem.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-355-IOU" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double bbb = 0.00;
                bbb = Convert.ToDouble(txtAmount.Text.ToString());
                if (txtAmount.Text == "" || bbb < 1)
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double aaa = 0.00;
                    aaa = Convert.ToDouble(txtAmount.Text.ToString());
                    txtAmount.Text = aaa.ToString("#,###.00");
                    cmdAdd.Focus();
                }
            }
        }

        private void txtSerIOU_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from IOU where IOUNo='" + txtIOUNo.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    double ddd = 0.00;
                    txtIOUNo.Text = rdr["IOUNo"].ToString();
                    dtpIOUDate.Text = rdr["IOUDate"].ToString();
                    txtIOUName.Text = rdr["IOUName"].ToString();

                    txtBrAmount.Text = rdr["BrAmount"].ToString();
                    ddd = Convert.ToDouble(txtBrAmount.Text.ToString());
                    txtBrAmount.Text = ddd.ToString("#,##0.00");

                    txtReason.Text = rdr["Reason"].ToString();
                    dtpSPfDate.Text = rdr["SPfDate"].ToString();
                    dtpSptDate.Text = rdr["SptDate"].ToString();
                    dtpPRDate.Text = rdr["PRDate"].ToString();
                    dtpStlDate.Text = rdr["StlDate"].ToString();
                    txtTotal.Text = rdr["Total"].ToString();
                    ddd = Convert.ToDouble(txtTotal.Text.ToString());
                    txtTotal.Text = ddd.ToString("#,##0.00");
                    // txtStNo.Enabled = false;
                }
                con.Close();
                if (count > 0)
                {
                    double ca2 = 0.00, ca3 = 0.00;
                    for (int ca1 = 0; ca1 < count; ca1++)
                    {
                        ca2 = Convert.ToDouble(dataGridView1.Rows[ca1].Cells[11].Value.ToString());
                        ca3 = ca3 + ca2;
                        txtTotal.Text = ca3.ToString("#,###.00");
                    }
                }
                else
                {
                    //if (txtRefNo.Text != "")
                    //{
                    Blank2();
                    dtpIOUDate.Focus();
                    //    txtStNo.Enabled = true;
                    //}
                }
                DGViewSize();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-440-IOU" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            comItem.Text = "";
            comItem.Focus();
        }

        private void cmdBlank_Click(object sender, EventArgs e)
        {
            Blank2();
            txtIOUNo.Text = "";
            txtIOUNo.Focus();
        }

        private void cmdRe_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Refresh();
            txtSerIOU_TextChanged(null, null);
            dataGridView1.Refresh();
            // comDes.Enabled = true;
            comItem.Focus();
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

        private void CmdExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void comItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comItem.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtAmount.Focus();
                }
            }
        }

        private void txtBrAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)189 && e.KeyChar != (char)46 && e.KeyChar != (char)108 && e.KeyChar != (char)44;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)189 && e.KeyChar != (char)46 && e.KeyChar != (char)108 && e.KeyChar != (char)44;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
