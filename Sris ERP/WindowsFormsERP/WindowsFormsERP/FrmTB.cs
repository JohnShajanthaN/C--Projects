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
    public partial class FrmTB : Form
    {
        // int count = 0;
        // int count1 = 0;
        int dgvRows = 0;
        double LL1 = 0.00, RR1 = 0.00;

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
            dataGridView1.Columns[0].HeaderText = "  Particular";
            dataGridView1.Columns[1].HeaderText = " Debit";
            dataGridView1.Columns[2].HeaderText = "  Credit";
            dataGridView1.Columns[0].Width = 1130;
            dataGridView1.Columns[1].Width = 85;
            dataGridView1.Columns[2].Width = 105;

            var row1 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from TB", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = rdr["Particular"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Convert.ToDouble(rdr["Debit"].ToString());
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                if (Convert.ToDouble(rdr["Debit"].ToString()) < 1.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.White };
                }
                if (Convert.ToDouble(rdr["Credit"].ToString()) < 1.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.White };
                }
                LL1 = LL1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[1].Value);
                RR1 = RR1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[2].Value);
            }
            con.Close();

            dgvRows = dataGridView1.RowCount;
            var row3 = new DataGridViewRow();
            row3 = new DataGridViewRow();
            dataGridView1.Rows.Add(row3);

            dataGridView1.Rows[dgvRows].Cells[0].Value = "Grand Total";
            dataGridView1.Rows[dgvRows].Cells[1].Value = Convert.ToDouble(LL1.ToString());
            dataGridView1.Rows[dgvRows].Cells[2].Value = Convert.ToDouble(RR1.ToString());

            dataGridView1.Rows[dgvRows].Cells[0].Style = new DataGridViewCellStyle { Font = label7.Font, BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows].Cells[1].Style = new DataGridViewCellStyle { Font = label7.Font, BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows].Cells[2].Style = new DataGridViewCellStyle { Font = label7.Font, BackColor = Color.Linen };
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
                    Paragraph para = new Paragraph(" Trail Balance ");
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

        public FrmTB()
        {
            InitializeComponent();
        }

        private void FrmTB_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
          //  count = 0;
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
            EPDFReport(dataGridView1, " Trail Balance - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (" Trail Balance - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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
    }
}
