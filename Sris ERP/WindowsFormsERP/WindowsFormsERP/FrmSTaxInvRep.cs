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
    public partial class FrmSTaxInvRep : Form
    {
        int count = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void DGViewSize()
        {
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            double s = 0.00;
            lbls.Text = "";
            if (this.label4.Text == "Item")
            {
                dataGridView1.Columns[0].Width = 900;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 170;
                dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                for (int ca1 = 0; ca1 < count; ca1++)
                {
                    s = s + Convert.ToInt32(dataGridView1.Rows[ca1].Cells[2].Value);
                    lbls.Text = "Total : Rs." + s.ToString("#,##0.00");
                }
            }
            else if (this.label4.Text == "Customer Name")
            {
                dataGridView1.Columns[0].Width = 1000;
                dataGridView1.Columns[1].Width = 170;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int ca1 = 0; ca1 < count; ca1++)
                {
                    s = s + Convert.ToInt32(dataGridView1.Rows[ca1].Cells[1].Value);
                    lbls.Text = "Total : Rs." + s.ToString("#,##0.00");
                    //dataGridView1.Columns[15].Visible = false;
                    //dataGridView1.Columns[16].Visible = false;
                    //dataGridView1.Columns[17].Visible = false;
                    //dataGridView1.Columns[18].Visible = false;
                }
            }
            else
            {
                lbls.Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            if (this.label4.Text == "Item")
            {
                float[] widths = new float[] { 500f, 100f, 150f };
                pdftable.SetWidths(widths);
            }
            else if (this.label4.Text == "Customer Name")
            {
                float[] widths = new float[] { 600f, 100f };
                pdftable.SetWidths(widths);
            }
            else
            {
                float[] widths = new float[] { 0f, 65f, 80f, 0f, 80f, 0f, 0f, 0f, 240f, 0f, 0f, 50f, 75f, 85f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 120f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
                pdftable.SetWidths(widths);
            }
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
                    if (this.label4.Text == "Item")
                    {
                        if (cell.ColumnIndex.ToString() == "1" || cell.ColumnIndex.ToString() == "2")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                        }
                        else
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        }
                    }
                    else if (this.label4.Text == "Customer Name")
                    {
                        if (cell.ColumnIndex.ToString() == "1")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                        }
                        else
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        }
                    }
                    else
                    {
                        if (cell.ColumnIndex.ToString() == "2")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                        }
                        else if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "11" || cell.ColumnIndex.ToString() == "12" || cell.ColumnIndex.ToString() == "13" || cell.ColumnIndex.ToString() == "21")
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                        }
                        else
                        {
                            cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        }
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
                    Paragraph para = new Paragraph(label1.Text);
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
        public FrmSTaxInvRep()
        {
            InitializeComponent();
        }

        private void FrmSTaxInvRep_Load(object sender, EventArgs e)
        {
            count = 0;
            this.label1.Text = this.Text;
            if (this.Text == "Suspended Tax Invoice Report (Total by Item)")
            {
                this.label4.Text = "Item";
            }
            else if (this.Text == "Suspended Tax Invoice Report (Total by Customer)")
            {
                this.label4.Text = "Customer Name";
            }

            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (this.label4.Text == "Item")
                {
                    //cmd.CommandText = "select * from SuspendedCompletedDetails where Description Like '%" + TxtSer.Text + "%'";
                    cmd.CommandText = "select Description, sum(BillQuantity) as Qty, sum(ItemTotal) as Total_Amount from SuspendedCompletedDetails where Description Like '%" + TxtSer.Text + "%' GROUP BY Description";
                }
                else if (this.label4.Text == "Customer Name")
                {
                   // cmd.CommandText = "select * from SuspendedCompletedDetails where CustomerName Like '%" + TxtSer.Text + "%'";
                    cmd.CommandText = "select CustomerName, sum(ItemTotal) as Amount from InvoiceCompletedDetails where CustomerName Like '%" + TxtSer.Text + "%' GROUP BY CustomerName";
                }
                else
                {
                    cmd.CommandText = "select * from SuspendedCompletedDetails where BillNumber Like '%" + TxtSer.Text + "%' or BillCategory Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or Description Like '%" + TxtSer.Text + "%' or LocationID Like '%" + TxtSer.Text + "%' or ManualReferenceNo Like '%" + TxtSer.Text + "%' or SalesCategoryKeyword Like '%" + TxtSer.Text + "%' or StockNumber Like '%" + TxtSer.Text
                        + "%' or MarketingStaffName Like '%" + TxtSer.Text + "%' or CustomerAddress Like '%" + TxtSer.Text + "%' or PONumber Like '%" + TxtSer.Text + "%' or PaymentTerms Like '%" + TxtSer.Text + "%' or JobOrderNo Like '%" + TxtSer.Text + "%' or CreatedBy Like '%" + TxtSer.Text + "%' or VATNumber Like '%" + TxtSer.Text + "%' or SVATNumber Like '%" + TxtSer.Text + "%'";
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
                MessageBox.Show("ERROR CODE : SER-CNG-103-STAX-INVR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, label1.Text + " - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (label1.Text + " - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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
