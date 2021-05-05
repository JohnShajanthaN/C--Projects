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
    public partial class FrmIncomeStatement : Form
    {
        // int count = 0;
        string ProfitLoss1 = "";
        int dgvRows = 0, dgvRows2 = 0, dgvRows3 = 0, dgvRows4;
        double Sale = 0.00, Pur = 0.00, II1=0.00, EE1=0.00, NP = 0.00, NL = 0.00;

        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;

            dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].HeaderText = "Particular";
            dataGridView1.Columns[1].HeaderText = " Amount";
            dataGridView1.Columns[2].HeaderText = "  Amount";
            dataGridView1.Columns[0].Width = 1130;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 110;
            

            var row1 = new DataGridViewRow();

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Revenues";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            //Sales   
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from TB where Particular='" + "Sales" + "' ", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                Sale = Convert.ToDouble(rdr["Credit"].ToString());
            }
            con.Close();
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Sales";
            dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Sale.ToString("#,##0.00");
            II1 = II1 + Sale;

           // var row777 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from TB where PLACType='" + "Indirect Incomes" + "' ", con);
            cmd2.Connection = con;
            rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;

                // var row555 = new DataGridViewRow();
                row1 = new DataGridViewRow();
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                II1 = II1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
            }
            con.Close();

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Total Revenues";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(II1.ToString());
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);


            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Expenses";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            //Purchase  
            con.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from TB where Particular='" + "Purchase" + "' ", con);
            cmd3.Connection = con;
            rdr = cmd3.ExecuteReader();
            while (rdr.Read())
            {
                Pur = Convert.ToDouble(rdr["Debit"].ToString());
            }
            con.Close();
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Purchase";
            dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Pur.ToString("#,##0.00");
            EE1 = EE1 + Pur;


            con.Open();
            OleDbCommand cmd4 = new OleDbCommand("select * from TB where PLACType Like '%" + "Expenses" + "%' ", con);
           // OleDbCommand cmd2 = new OleDbCommand("select * from Journal where Debit > 0 AND Opc Like '%" + lg1 + "%'", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;

                // var row555 = new DataGridViewRow();
                row1 = new DataGridViewRow();
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                EE1 = EE1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
            }
            con.Close();

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Total Expenses";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(EE1.ToString());
           // dataGridView1.Rows[dgvRows - 1].Cells[2].Value = "(" + dataGridView1.Rows[dgvRows - 1].Cells[2].Value + ")";
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            if (II1 > EE1)
            {
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Net Income";
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble((II1-EE1).ToString());
                ProfitLoss1 = "Profit";
                NP = II1 - EE1;
            }
            else
            {
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Net Loss";
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble((EE1-II1).ToString());
                ProfitLoss1 = "Loss";
                NL = EE1 - II1;
            }            
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke, ForeColor = Color.Brown };

            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { Font = label7.Font, BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows - 1].Cells[1].Style = new DataGridViewCellStyle { Font = label7.Font, BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { Font = label7.Font, BackColor = Color.Linen };

            dataGridView1.ClearSelection();
        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProfitLoss1 == "Profit")
                {
                    OleDbCommand cmd = new OleDbCommand("Update IncomeStatement SET Particular='" + "Net Income" + "', Amount='" + NP
                        + "' WHERE ID=" + "1" + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Posting Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ProfitLoss1 == "Loss")
                {
                    OleDbCommand cmd = new OleDbCommand("Update IncomeStatement SET Particular='" + "Net Loss" + "', Amount='" + NL
                        + "' WHERE ID=" + "1" + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Posting Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGViewSize();               

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-102-IOU-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, " Income Statement - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (" Income Statement - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                axAcroPDF1.LoadFile(dlg.FileName);
                axAcroPDF1.Visible = true;
                CmdPDFExit.BackColor = Color.Red;
                CmdPDFExit.ForeColor = Color.White;
            }
        }

        private void CmdPDFExit_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            CmdPDFExit.BackColor = Color.Gainsboro;
            CmdPDFExit.ForeColor = Color.Black;
            CmdPDFExit.UseVisualStyleBackColor = true;
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.TotalWidth = 580f;
            pdftable.LockedWidth = true;
            float[] widths = new float[] { 100f, 20f, 20f };
            pdftable.SetWidths(widths);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);//
                pdftable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string s = cell.FormattedValue.ToString();
                    PdfPCell cell1 = new PdfPCell(new Phrase(s, text));
                    if (cell.ColumnIndex.ToString() == "1" || cell.ColumnIndex.ToString() == "2")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                    }
                    else
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                    }
                    pdftable.AddCell(cell1);
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
                    Paragraph para = new Paragraph(" Income Statement ");
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

        public FrmIncomeStatement()
        {
            InitializeComponent();
        }

        private void FrmIncomeStatement_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            //  count = 0;
        }
    }
}
