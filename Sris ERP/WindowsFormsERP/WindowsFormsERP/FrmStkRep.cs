using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Data.OleDb;


namespace WindowsFormsERP
{
    public partial class FrmStkRep : Form
    {
        int count = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            if (label1.Text == "Inventory Quantity Sumarry")
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Visible = false;
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
                dataGridView1.Columns[26].Visible = false;
                dataGridView1.Columns[27].Visible = false;
                dataGridView1.Columns[28].Visible = false;
                dataGridView1.Columns[29].Visible = false;
                dataGridView1.Columns[30].Width = 100;
                dataGridView1.Columns[31].Visible = false;
            }
            else if (label1.Text == "Inventory Value Sumarry")
            {
                lbls.Visible = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Visible = false;
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
                dataGridView1.Columns[26].Visible = false;
                dataGridView1.Columns[27].Visible = false;
                dataGridView1.Columns[28].Visible = false;
                dataGridView1.Columns[29].Visible = false;
                dataGridView1.Columns[30].Width = 100;
                dataGridView1.Columns[31].Visible = false;

                //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                //buttonColumn.Name = "Details";
                //buttonColumn.HeaderText = "Details";
                //buttonColumn.Text = "View Details";
                //buttonColumn.UseColumnTextForButtonValue = true;
                //dataGridView1.Columns.Insert(31, buttonColumn);
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = "Inventory Value";
                dataGridView1.Columns.Insert(31, col);
                dataGridView1.Columns[31].Width = 160;
                double p = 0.00, q = 0.00, r = 0.00, s = 0.00;
                for (int ca1 = 0; ca1 < count; ca1++)
                {
                    p = Convert.ToInt32(dataGridView1.Rows[ca1].Cells[29].Value);
                    q = Convert.ToInt32(dataGridView1.Rows[ca1].Cells[30].Value);
                    r = p * q;
                    s = s + r;
                    dataGridView1.Rows[ca1].Cells[31].Value = r.ToString("#,##0.00");
                    lbls.Text = "Total : Rs." + s.ToString("#,##0.00");
                }
                dataGridView1.Columns[31].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[31].DefaultCellStyle.Format = "N2";
            }
            else if (label1.Text == "Inventory Profit Sumarry")
            {
                //lbls.Visible = true;
                dataGridView1.Columns[0].Width = 960;
                dataGridView1.Columns[1].Width = 170;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                double s = 0.00, t = 0.00;
                for (int ca1 = 0; ca1 < count; ca1++)
                {
                    t = Convert.ToDouble(dataGridView1.Rows[ca1].Cells[1].Value);
                    s = s + t;
                    lbls.Text = "Total : Rs." + s.ToString("#,##0.00");
                }
            }
            else
            {
                // dataGridView1.Font = new Font("Arial", 11);
                //  dataGridView1.Columns[29].DefaultCellStyle.Format = "D2";
                dataGridView1.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dataGridView1.Columns[20].HeaderText = " Expire";
                dataGridView1.Columns[21].HeaderText = " Min";
                dataGridView1.Columns[22].HeaderText = " Max";
                dataGridView1.Columns[29].HeaderText = " Price";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 60;

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
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[20].Width = 80;
                dataGridView1.Columns[21].Width = 40;
                dataGridView1.Columns[22].Width = 40;
                dataGridView1.Columns[23].Width = 40;
                dataGridView1.Columns[28].Visible = false;
                dataGridView1.Columns[29].Width = 60;
                dataGridView1.Columns[30].Width = 60;
                dataGridView1.Columns[29].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[29].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[30].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[31].Visible = false;


                if (lblULevel1.Text == "Administrator")
                {
                    string ca2 = "";
                    for (int ca1 = 0; ca1 < count; ca1++)
                    {
                        ca2 = dataGridView1.Rows[ca1].Cells[2].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[3].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[4].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[5].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[6].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[7].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[8].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[9].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[10].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[11].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[12].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[13].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[14].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[15].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[16].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[17].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[18].Value.ToString();
                        dataGridView1.Rows[ca1].Cells[2].Value = (ca2).ToString();
                    }
                    dataGridView1.Columns[2].HeaderText = " Full Details";
                    dataGridView1.Columns[2].Width = 437;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[17].Visible = false;
                    dataGridView1.Columns[18].Visible = false;

                    dataGridView1.Columns[24].Width = 60;
                    dataGridView1.Columns[25].Width = 120;
                    dataGridView1.Columns[26].Width = 60;
                    dataGridView1.Columns[27].Width = 110;
                }
                else
                {
                    panel1.Visible = true;
                    dataGridView1.Columns[2].HeaderText = " Description";
                    dataGridView1.Columns[4].HeaderText = " Other Details";

                    dataGridView1.Columns[24].Visible = false;
                    dataGridView1.Columns[25].Visible = false;
                    dataGridView1.Columns[26].Visible = false;
                    dataGridView1.Columns[27].Visible = false;

                    dataGridView1.Columns[2].Width = 170;
                    dataGridView1.Columns[3].Width = 120;
                    dataGridView1.Columns[4].Width = 297;
                    dataGridView1.Columns[17].Width = 70;
                    dataGridView1.Columns[18].Width = 130;

                    string ca2 = "";
                    for (int ca1 = 0; ca1 < count; ca1++)
                    {
                        ca2 = dataGridView1.Rows[ca1].Cells[4].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[5].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[6].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[7].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[8].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[9].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[10].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[11].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[12].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[13].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[14].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[15].Value.ToString()
                            + " " + dataGridView1.Rows[ca1].Cells[16].Value.ToString();
                        dataGridView1.Rows[ca1].Cells[4].Value = (ca2).ToString();
                    }

                }
            }
        }

        private void MultiSearch()
        {
            try
            {
                con.Open();
                String userLevel = lblULevel1.Text;
                //"SELECT ID, StNo, Des, Kwl, Gr, SNum , PNum, CPC, CPMn, MPYs, MPTs, MPEI, PPWt,"
                //    + "PPWidth, PPThick, UOMes, Grade, Model, Manu, DoMFR, DOE, Min1, Max1, ROL, AddUser, AddTime, EditUser, EditTime, IImg, CashPrice"
                //    + "FROM Item WHERE"

                //String admin_sql = "SELECT StNo, CONCAT(Des, Kwl, Gr, SNum , PNum, CPC, CPMn, MPYs, MPTs, MPEI, PPWt, PPWidth, PPThick, UOMes, Grade, Model, Manu) AS Full Details "
                //    + " DoMFR, DOE, Min1, Max1, ROL, AddUser, AddTime, EditUser, EditTime, IImg, CashPrice"
                //    + "FROM Item WHERE";

                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Item where StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
                //Multi search
                if (chkDes.Checked && chkKw.Checked && chkManu.Checked && chkMod.Checked)
                {
                    cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
                }
                else
                {
                    if (chkDes.Checked && chkKw.Checked && chkManu.Checked)
                    {
                        cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "' and Manu='" + txtManu.Text + "'";
                    }
                    else if (chkDes.Checked && chkKw.Checked && chkMod.Checked)
                    {
                        cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "'";
                    }
                    else if (chkDes.Checked && chkManu.Checked && chkMod.Checked)
                    {
                        cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
                    }
                    else if (chkKw.Checked && chkManu.Checked && chkMod.Checked)
                    {
                        cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
                    }
                    else
                    {
                        if (chkDes.Checked && chkKw.Checked)
                        {
                            cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "'";
                        }
                        else if (chkDes.Checked && chkMod.Checked)
                        {
                            cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Model='" + txtMod.Text + "'";
                        }
                        else if (chkDes.Checked && chkManu.Checked)
                        {
                            cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Manu='" + txtManu.Text + "'";
                        }
                        else if (chkKw.Checked && chkMod.Checked)
                        {
                            cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "'";
                        }
                        else if (chkKw.Checked && chkManu.Checked)
                        {
                            cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "' and Manu='" + txtManu.Text + "'";
                        }
                        else if (chkManu.Checked && chkMod.Checked)
                        {
                            cmd.CommandText = "select * from Item where Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
                        }
                        else
                        {
                            if (chkDes.Checked)
                            {
                                cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "'";
                            }
                            else if (chkKw.Checked)
                            {
                                cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "'";
                            }
                            else if (chkMod.Checked)
                            {
                                cmd.CommandText = "select * from Item where Model='" + txtMod.Text + "'";
                            }
                            else if (chkManu.Checked)
                            {
                                cmd.CommandText = "select * from Item where Manu='" + txtManu.Text + "'";
                            }
                        }
                    }
                }
                //cmd.CommandText = "select * from Item where sname='" + textBox1.Text + "' and city='"+textBox2.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //DGViewSize(userLevel);
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : MLTY-SER-223-STK-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.TotalWidth = 580f;
            pdftable.LockedWidth = true;
            if (label1.Text == "Inventory Profit Sumarry")
            {
                float[] widths = new float[] { 960f, 170f };
                pdftable.SetWidths(widths);
            }
            else if (label1.Text == "Inventory Value Sumarry")
            {
                float[] widths = new float[] { 0f, 80f, 400f, 150f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 80f, 130f, 0f };
                pdftable.SetWidths(widths);
            }
            else if (label1.Text == "Inventory Quantity Sumarry")
            {
                float[] widths = new float[] { 0f, 80f, 400f, 150f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 80f, 0f };
                pdftable.SetWidths(widths);
            }
            else
            {
                float[] widths = new float[] { 0f, 60f, 170f, 120f, 300f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 70f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 80f, 40f, 0f };
                pdftable.SetWidths(widths);
            }
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add Header            
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);//
                pdftable.AddCell(cell);
            }

            //Add Data Row            
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string s = cell.FormattedValue.ToString();
                    PdfPCell cell1 = new PdfPCell(new Phrase(s, text));
                    if (label1.Text == "Inventory Profit Sumarry")
                    {
                        if (cell.ColumnIndex.ToString() == "0")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        }
                        else
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                        }
                        pdftable.AddCell(cell1);
                    }
                    else
                    {
                        if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "30" || cell.ColumnIndex.ToString() == "31" || cell.ColumnIndex.ToString() == "21" || cell.ColumnIndex.ToString() == "22" || cell.ColumnIndex.ToString() == "23" || cell.ColumnIndex.ToString() == "29")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                        }
                        else if (cell.ColumnIndex.ToString() == "20")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                        }
                        else
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        }
                        pdftable.AddCell(cell1);
                    }
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    Paragraph para = new Paragraph("Stock Report ");
                    Paragraph para0 = new Paragraph(DateTime.Now.ToString("dd.MM.yyyy"));
                    Paragraph para1 = new Paragraph(" ");
                    para.Alignment = Element.ALIGN_CENTER;
                    para0.Alignment = Element.ALIGN_CENTER;
                    pdfdoc.Add(para);
                    pdfdoc.Add(para0);
                    pdfdoc.Add(para1);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        public FrmStkRep()
        {
            InitializeComponent();
        }

        private void FrmStkRep_Load(object sender, EventArgs e)
        {
            count = 0;
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            
            label1.Text = this.Text;
            if (this.Text == "Inventory Quantity Sumarry" || this.Text == "Inventory Quantity Sumarry" || this.Text == "Inventory Quantity Sumarry")
            {
                this.label4.Text = "Item";
            }
            TxtSer_TextChanged(null, null);
        }

        private void TxtSer_KeyDown(object sender, KeyEventArgs e)
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
                if (label1.Text == "Inventory Profit Sumarry")
                {
                    cmd.CommandText = "select Des, sum((CashPrice - CostPrice) * Qty) as Profit from Item GROUP BY Des";
                }
                else
                {
                    cmd.CommandText = "select * from Item where StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
                }
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
                MessageBox.Show("ERROR CODE : SER-CNG-316-STK-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDes_CheckedChanged(object sender, EventArgs e)
        {
            txtDes.Text = "";
            txtDes.Focus();
        }

        private void chkKw_CheckedChanged(object sender, EventArgs e)
        {
            txtKw.Text = "";
            txtKw.Focus();
        }

        private void chkMod_CheckedChanged(object sender, EventArgs e)
        {
            txtMod.Text = "";
            txtMod.Focus();
        }

        private void chkManu_CheckedChanged(object sender, EventArgs e)
        {
            txtManu.Text = "";
            txtManu.Focus();
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void txtKw_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void txtMod_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void txtManu_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, "Stock Report-" + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = ("Stock Report-" + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                axAcroPDF1.LoadFile(dlg.FileName);
                axAcroPDF1.Visible = true;
                CmdPDFExit.BackColor = Color.Red;
                CmdPDFExit.ForeColor = Color.White;
                // CmdPDFExit.UseVisualStyleBackColor = true;
            }
        }

        private void CmdPDFExit_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            CmdPDFExit.BackColor = Color.Gainsboro;
            CmdPDFExit.ForeColor = Color.Black;
            CmdPDFExit.UseVisualStyleBackColor = true;
        }

        private void CmdImage_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }
    }
}
