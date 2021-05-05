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
    public partial class FrmBalanceSheet : Form
    {
        int count = 0;
       // int count1 = 0;

        int dgvRows = 0, dgvRows2 = 0, dgvRows3 = 0, dgvRows4;
        double aa = 0.00, bb = 0.00, LL1=0.00, AA1=0.00; // cc = 0.00;

        // string ProfitLoss1 = "";
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Width = 365;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns[0].HeaderText = "Liabilities";
            dataGridView1.Columns[1].HeaderText = "  Amount";
            dataGridView1.Columns[2].HeaderText = "  Amount";

            dataGridView2.Font = label7.Font;
            dataGridView2.DefaultCellStyle.Font = label6.Font;
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Width = 375;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView2.Columns[0].HeaderText = "Assets";
            dataGridView2.Columns[1].HeaderText = "  Amount";
            dataGridView2.Columns[2].HeaderText = "  Amount";



            var row1 = new DataGridViewRow();


            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = " Capital Accounts";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;

            con.Open();
            OleDbCommand cmd4 = new OleDbCommand("select * from TB where BalALType='" + "Capital - Equity" + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                LL1 = LL1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
            }
            con.Close();


            var row2 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from ProfitLoss where ID=" + "1" + "", con);
            cmd2.Connection = con;
            rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                row2 = new DataGridViewRow();
                dataGridView1.Rows.Add(row2);

                dgvRows = dataGridView1.RowCount;                
                if (rdr["Particular"].ToString() =="Net Profit")
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + " (+) " + rdr["Particular"].ToString();
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Amount"].ToString());
                    LL1 = LL1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + " (-) " + rdr["Particular"].ToString();
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Amount"].ToString());
                    LL1 = LL1 - Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
                }                
            }
            con.Close();
            row2 = new DataGridViewRow();
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows[dgvRows].Cells[1].Value = Convert.ToDouble(LL1.ToString());
            dataGridView1.Rows[dgvRows].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke };


            var row3 = new DataGridViewRow();
            int Dra = 0;
            con.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from TB where BalALType='" + "Drawing - Equity" + "' ", con);
            cmd3.Connection = con;
            rdr = cmd3.ExecuteReader();
            while (rdr.Read())
            {
                row3 = new DataGridViewRow();
                dataGridView1.Rows.Add(row3);
                Dra = 1;

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + " (-) " + rdr["Particular"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Debit"].ToString());
                LL1 = LL1 - Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value); 
            }
            con.Close();
            
            if (Dra==1)
            {
                row3 = new DataGridViewRow();
                dataGridView1.Rows.Add(row3);
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(LL1.ToString());
                dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke };
                //Dra = 0;
            }   
            else
            {
                dataGridView1.Rows[dgvRows].Cells[1].Value = "";
                dataGridView1.Rows[dgvRows].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.White };
                dataGridView1.Rows[dgvRows-1].Cells[2].Value = Convert.ToDouble(LL1.ToString());
                dataGridView1.Rows[dgvRows-1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke };
            }


            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = " Liabilities";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;

            var row4 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd44 = new OleDbCommand("select * from TB where BalALType='" + "Liabilities" + "' ", con);
            cmd44.Connection = con;
            rdr = cmd44.ExecuteReader();
            while (rdr.Read())
            {
                row4 = new DataGridViewRow();
                dataGridView1.Rows.Add(row4);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }                    
                LL1 = LL1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[2].Value);
            }
            con.Close();//////////////////////////////

            row1 = new DataGridViewRow();
            dataGridView2.Rows.Add(row1);
            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = " Fixed Assets";
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style.Font = label7.Font;

            var row5 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd5 = new OleDbCommand("select * from TB where BalALType='" + "Fiixed Assets" + "' ", con);
            cmd5.Connection = con;
            rdr = cmd5.ExecuteReader();
            while (rdr.Read())
            {
                row5 = new DataGridViewRow();
                dataGridView2.Rows.Add(row5);

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                AA1 = AA1 + Convert.ToDouble(dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value);
            }
            con.Close();//////////////////////////////


            
            //row6 = new DataGridViewRow();
            //dataGridView2.Rows.Add(row6);
            //dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(LL1.ToString());

            row1 = new DataGridViewRow();
            dataGridView2.Rows.Add(row1);
            row1 = new DataGridViewRow();
            dataGridView2.Rows.Add(row1);
            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = " Current Assets";
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style.Font = label7.Font;

            var row7 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd7 = new OleDbCommand("select * from TB where BalALType='" + "Current Assets" + "' ", con);
            cmd7.Connection = con;
            rdr = cmd7.ExecuteReader();
            while (rdr.Read())
            {
                row7 = new DataGridViewRow();
                dataGridView2.Rows.Add(row7);

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                AA1 = AA1 + Convert.ToDouble(dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value);
            }
            con.Close();//////////////////////////////

            var row6 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd6 = new OleDbCommand("select * from CloseSt ", con);
            cmd6.Connection = con;
            rdr = cmd6.ExecuteReader();
            while (rdr.Read())
            {
                row6 = new DataGridViewRow();
                dataGridView2.Rows.Add(row6);

                dgvRows2 = dataGridView2.RowCount;
                // dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = rdr["CDate"].ToString() + " Closing Stock";
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "    " + "Closing Stock";
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(rdr["Amount"].ToString());
                AA1 = AA1 + Convert.ToDouble(dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value);
            }
            con.Close();

            dgvRows = dataGridView1.RowCount;
            dgvRows2 = dataGridView2.RowCount;
            if (dgvRows > dgvRows2)
            {
                dgvRows3 = dgvRows - dgvRows2;
                dgvRows4 = dgvRows;

                var row8 = new DataGridViewRow();
                for (int k = 1; k < dgvRows3 + 2; k++)
                {
                    row8 = new DataGridViewRow();
                    dataGridView2.Rows.Add(row8);
                }
                row8 = new DataGridViewRow();
                dataGridView1.Rows.Add(row8);
                //row8 = new DataGridViewRow();
                //dataGridView1.Rows.Add(row8);
            }
            else
            {
                dgvRows3 = dgvRows2 - dgvRows;
                dgvRows4 = dgvRows2;

                var row9 = new DataGridViewRow();
                for (int k = 1; k < dgvRows3 + 2; k++)
                {
                    row9 = new DataGridViewRow();
                    dataGridView1.Rows.Add(row9);
                }
                row9 = new DataGridViewRow();
                dataGridView2.Rows.Add(row9);

            }

            dataGridView1.Rows[dgvRows4].Cells[2].Value = Convert.ToDouble(LL1.ToString());
           // dataGridView1.Rows[dgvRows4].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke, ForeColor = Color.DarkRed };

            dataGridView2.Rows[dgvRows4].Cells[2].Value = Convert.ToDouble(AA1.ToString());
           // dataGridView2.Rows[dgvRows4].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke, ForeColor = Color.DarkRed };
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            dataGridView1.Rows[dgvRows4].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows4].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows4].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView2.Rows[dgvRows4].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView2.Rows[dgvRows4].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView2.Rows[dgvRows4].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };

            dataGridView1.Rows[dgvRows4].Cells[2].Style.Font = label7.Font;
            dataGridView2.Rows[dgvRows4].Cells[2].Style.Font = label7.Font;
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void DGView3()
        {
            dataGridView3.Font = label7.Font;
            dataGridView3.DefaultCellStyle.Font = label6.Font;

            dataGridView3.ColumnCount = 7;
            dataGridView3.Columns[0].Width = 365;
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[0].HeaderText = "Liabilities";
            dataGridView3.Columns[1].HeaderText = "  Amount";
            dataGridView3.Columns[2].HeaderText = "  Amount";
            dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView3.Columns[3].Width = 1;

            dataGridView3.Columns[4].Width = 355;
            dataGridView3.Columns[5].Width = 100;
            dataGridView3.Columns[6].Width = 125;
            dataGridView3.Columns[4].HeaderText = "Assets";
            dataGridView3.Columns[5].HeaderText = "  Amount";
            dataGridView3.Columns[6].HeaderText = "  Amount";
            dataGridView3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[6].DefaultCellStyle.Format = "N2";

            var row1 = new DataGridViewRow();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row1 = new DataGridViewRow();
                dataGridView3.Rows.Add(row1);
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    dataGridView1.Rows[i].Cells[0].Value = " ";
                }
                if (dataGridView1.Rows[i].Cells[1].Value == null)
                {
                    dataGridView1.Rows[i].Cells[1].Value = " ";
                }
                if (dataGridView1.Rows[i].Cells[2].Value == null)
                {
                    dataGridView1.Rows[i].Cells[2].Value = " ";
                }

                dataGridView3.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                dataGridView3.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                dataGridView3.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;

                dataGridView3.Rows[i].Cells[0].Style = dataGridView1.Rows[i].Cells[0].Style;
                dataGridView3.Rows[i].Cells[1].Style = dataGridView1.Rows[i].Cells[1].Style;
                dataGridView3.Rows[i].Cells[2].Style = dataGridView1.Rows[i].Cells[2].Style;

                if (dataGridView2.Rows[i].Cells[0].Value == null)
                {
                    dataGridView2.Rows[i].Cells[0].Value = " ";
                }
                if (dataGridView2.Rows[i].Cells[1].Value == null)
                {
                    dataGridView2.Rows[i].Cells[1].Value = " ";
                }
                if (dataGridView2.Rows[i].Cells[2].Value == null)
                {
                    dataGridView2.Rows[i].Cells[2].Value = " ";
                }

                dataGridView3.Rows[i].Cells[4].Value = dataGridView2.Rows[i].Cells[0].Value;
                dataGridView3.Rows[i].Cells[5].Value = dataGridView2.Rows[i].Cells[1].Value;
                dataGridView3.Rows[i].Cells[6].Value = dataGridView2.Rows[i].Cells[2].Value;

                dataGridView3.Rows[i].Cells[4].Style = dataGridView2.Rows[i].Cells[0].Style;
                dataGridView3.Rows[i].Cells[5].Style = dataGridView2.Rows[i].Cells[1].Style;
                dataGridView3.Rows[i].Cells[6].Style = dataGridView2.Rows[i].Cells[2].Style;

                dataGridView3.Rows[i].Cells[3].Value = " ";
                dataGridView3.ClearSelection();
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
            float[] widths = new float[] { 150f, 53f, 60f, 1f, 150f, 53f, 60f };
            pdftable.SetWidths(widths);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgw.Columns)//Add Header  
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgw.Rows)//Add Data Row  
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string s = cell.FormattedValue.ToString();
                    PdfPCell cell1 = new PdfPCell(new Phrase(s, text));
                    if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "4")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                    }
                    else
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
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
                    Paragraph para = new Paragraph("Balance Sheet Report ");
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
        public FrmBalanceSheet()
        {
            InitializeComponent();
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            DGViewSize();
            DGView3();
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView3, "Balance Sheet - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = ("Balance Sheet - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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

        private void FrmBalanceSheet_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
           // OCStock();
            TxtSer_TextChanged(null, null);
        }
    }
}
