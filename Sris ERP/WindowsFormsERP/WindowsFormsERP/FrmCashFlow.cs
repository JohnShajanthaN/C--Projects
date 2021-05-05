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
    public partial class FrmCashFlow : Form
    {
        // int count = 0;
        int dgvRows = 0;
        double OA1 = 0.00, IA1 = 0.00, FA1 = 0.00, CC1 = 0.00, CB1 = 0.00, CE1 = 0.00;

        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");


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
            EPDFReport(dataGridView1, " Cash Flow Statement - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (" Cash Flow Statement - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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

        private void DGViewSize()
        {
            dataGridView1.ColumnCount = 3;
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
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Operating Activities";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            //Sales   
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from IncomeStatement where ID=" + "1" + "", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
               // Sale = Convert.ToDouble(rdr["Credit"].ToString());
                if (rdr["Particular"].ToString() == "Net Income")
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + rdr["Particular"].ToString();
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Amount"].ToString());
                    OA1 = OA1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    " + rdr["Particular"].ToString() + " (-)";
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Amount"].ToString());
                    OA1 = OA1 - Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
                }
            }
            con.Close();
            ///////////////////////////***********Operating Activities

            ///***********************************
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Net Cash from Operating Activities";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(OA1.ToString());

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Investing Activities";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            ///////////////////////////***********Investing Activities

            ///***********************************
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Net Cash from Investing Activities";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(IA1.ToString());

            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Financing Activities";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            ///////////////////////////***********Financing Activities

            ///***********************************
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    Net Cash from Financing Activities";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(FA1.ToString());

            CC1 = OA1 + IA1 + FA1;
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Change in Cash";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(CC1.ToString());



            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Cash at Begining";
            con.Open();
            OleDbCommand cmd5 = new OleDbCommand("select * from TB where Particular='" + "Cash" + "' ", con);
            cmd5.Connection = con;
            rdr = cmd5.ExecuteReader();
            while (rdr.Read())
            {
               // row1 = new DataGridViewRow();
               // dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;
                //dataGridView1.Rows[dgvRows - 1].Cells[0].Value = rdr["Particular"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Credit"].ToString());
                CB1 = CB1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
            }
            con.Close();

            

            CE1 = CC1 + CB1;
            row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  Cash at End";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(CE1.ToString());
            dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };

            dataGridView1.ClearSelection();
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.TotalWidth = 580f;
            pdftable.LockedWidth = true;
            float[] widths = new float[] { 70f, 100f, 130f };
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
                    if (cell.ColumnIndex.ToString() == "4")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    else if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "6" || cell.ColumnIndex.ToString() == "7" || cell.ColumnIndex.ToString() == "8")
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
                    Paragraph para = new Paragraph(" Cash Flow Statement ");
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

        public FrmCashFlow()
        {
            InitializeComponent();
        }

        private void FrmCashFlow_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            //  count = 0;
        }
    }
}
