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
    public partial class FrmSupSta : Form
    {
        int dgvRows = 0;
        string sup1 = "";
        double pp1;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            pp1 = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[0].HeaderText = "   SNo";
            dataGridView1.Columns[1].HeaderText = " GRN / PV No.";
            dataGridView1.Columns[2].HeaderText = " GRN / PV Date";
            dataGridView1.Columns[3].HeaderText = " Description";
            dataGridView1.Columns[4].HeaderText = " Amount";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 249;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 450;
            dataGridView1.Columns[4].Width = 200;

            var row1 = new DataGridViewRow();
            con.Open();            
            OleDbCommand cmd1 = new OleDbCommand("select * from Outstanding where Sup='" + sup1 + "' AND (GRNPVNo Like '%" + TxtSer.Text + "%' OR Des Like '%" + TxtSer.Text + "%') ", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = dgvRows.ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[1].Value = rdr["GRNPVNo"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDateTime(rdr["GRNPVDate"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[dgvRows - 1].Cells[3].Value = rdr["Des"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[4].Value = Convert.ToDouble(rdr["Amount"].ToString());

                pp1 = pp1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[4].Value);
                //py1 = py1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[8].Value);

            }
            con.Close();

            dgvRows = dataGridView1.RowCount;
            var row2 = new DataGridViewRow();
            row2 = new DataGridViewRow();
            dataGridView1.Rows.Add(row2);

            for (int k = 0; k < 4; k++)
            {
                dataGridView1.Rows[dgvRows].Cells[k].Value = " ";
            }

            dataGridView1.Rows[dgvRows].Cells[3].Value = "Total Outstanding";
            dataGridView1.Rows[dgvRows].Cells[4].Value = Convert.ToDouble(pp1.ToString());
            dataGridView1.Rows[dgvRows].Cells[3].Style.Font = label7.Font;
            dataGridView1.Rows[dgvRows].Cells[4].Style.Font = label7.Font;

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
            float[] widths = new float[] { 100f, 250f, 150f, 450f, 200f };
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
                    if (cell.ColumnIndex.ToString() == "2")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    else if (cell.ColumnIndex.ToString() == "4")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                    }
                    else
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                    }
                    if (cell.RowIndex == dgw.RowCount-1)
                    {
                        iTextSharp.text.Font text2 = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);
                        PdfPCell cell2 = new PdfPCell(new Phrase(s, text2));

                        if (cell.ColumnIndex.ToString() == "4")
                        {
                            cell2.HorizontalAlignment = Element.ALIGN_RIGHT;
                        }
                        pdftable.AddCell(cell2);
                    }
                    else
                    {
                        //cell1.Rowspan = 3;
                        //pdftable.AddCell(cell1);
                        //pdftable.AddCell(new PdfPCell(new Phrase("1,2")));
                        //pdftable.AddCell(new PdfPCell(new Phrase("1,3")));
                        pdftable.AddCell(cell1);
                    }                    
                }
            }
            //PdfPCell cellWithRowspan = new PdfPCell(new Phrase("1,1"));
            //// The first cell spans 3 rows
            //cellWithRowspan.Rowspan = 2;
            //pdftable.AddCell(cellWithRowspan);
          //  pdftable.AddCell(new PdfPCell(new Phrase("1,2")));
            //pdftable.AddCell(new PdfPCell(new Phrase("1,3")));

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
                    Paragraph para = new Paragraph(sup1);
                    Paragraph para0 = new Paragraph("Statement on " + DateTime.Now.ToString("dd.MM.yyyy"));
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
        public FrmSupSta()
        {
            InitializeComponent();
        }

        private void FrmSupSta_Load(object sender, EventArgs e)
        {
            sup1 = FrmSupStatement.sup;
            this.label1.Text = "Statement for " + this.Text;
            Refresh();
            this.Refresh();
            Refresh();
            this.Refresh();
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            this.Show();
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, sup1 + " - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (sup1 + " - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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

        private void FrmSupSta_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmSupStatement FSupStatement = new FrmSupStatement();
            FSupStatement.Visible = true;
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
    }
}
