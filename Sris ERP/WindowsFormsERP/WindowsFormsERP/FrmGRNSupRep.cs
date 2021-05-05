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
    public partial class FrmGRNSupRep : Form
    {
        int dgvRows = 0;
        string Lst1 = "";
        double pp1, qq1;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
           // pp1 = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            dataGridView1.ColumnCount = 9;
            //dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[6].DefaultCellStyle.Format = "N2";
            //dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[7].DefaultCellStyle.Format = "N2";
            //dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
            //dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[0].HeaderText = "   SNo";
            dataGridView1.Columns[1].HeaderText = " PO-No";
            dataGridView1.Columns[2].HeaderText = " GRN-No";
            dataGridView1.Columns[3].HeaderText = " GRN-Date";
            dataGridView1.Columns[4].HeaderText = " Stock-No";
            dataGridView1.Columns[5].HeaderText = " Description";
            dataGridView1.Columns[6].HeaderText = " Weight";
            dataGridView1.Columns[7].HeaderText = " RvdQty";
            dataGridView1.Columns[8].HeaderText = " Location";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 85;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 240;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 280;

            var row1 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from PurchaseGRN where Supplier='" + Lst1 + "' AND (PONO Like '%" + TxtSer.Text + "%' OR GRNNo Like '%" + TxtSer.Text + "%' OR Description Like '%" + TxtSer.Text + "%' OR StockNumber Like '%" + TxtSer.Text + "%') ", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = dgvRows.ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[1].Value = rdr["PONO"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = rdr["GRNNo"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[3].Value = Convert.ToDateTime(rdr["GRNDate"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[dgvRows - 1].Cells[4].Value = rdr["StockNumber"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[5].Value = rdr["Description"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[6].Value = rdr["Weight"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[7].Value = rdr["RvdQty"].ToString() + " " + rdr["Unit"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[8].Value = rdr["LOC"].ToString();
            }
            con.Close();
            dgvRows = dataGridView1.RowCount;
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
            float[] widths = new float[] { 60f, 100f, 100f, 100f, 70f, 240f, 70f, 100f, 280f };
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
                    if (cell.ColumnIndex.ToString() == "3")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    //else if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "6" || cell.ColumnIndex.ToString() == "7" || cell.ColumnIndex.ToString() == "8")
                    //{
                    //    cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                    //}
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
                    Paragraph para = new Paragraph(Lst1);
                    Paragraph para0 = new Paragraph("GRN Report - " + DateTime.Now.ToString("dd.MM.yyyy"));
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
        public FrmGRNSupRep()
        {
            InitializeComponent();
        }

        private void FrmGRNSupRep_Load(object sender, EventArgs e)
        {
            Lst1 = FrmGRNSupList.Lst;
            this.label1.Text = "GRN Report - " + this.Text;
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
            EPDFReport(dataGridView1, Lst1 + " - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (Lst1 + " - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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

        private void FrmGRNSupRep_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmGRNSupList FGRNSupList = new FrmGRNSupList();
            FGRNSupList.Visible = true;
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
