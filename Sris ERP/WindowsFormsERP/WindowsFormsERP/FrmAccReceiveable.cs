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
using System.Net.Configuration;

namespace WindowsFormsERP
{
    public partial class FrmAccReceiveable : Form
    {
        int dgvRows = 0;
        double rr1;
        public static string cus = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Microsoft Sans Serif", 9);
            //dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9);
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;

            dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[0].Width = 1000;
            dataGridView1.Columns[1].Width = 149;
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
            float[] widths = new float[] { 320f, 50f };
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
                    if (cell.ColumnIndex.ToString() == "1")
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
                    Paragraph para = new Paragraph("Account Receivable Report");
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
        public FrmAccReceiveable()
        {
            InitializeComponent();
        }

        private void FrmAccReceiveable_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, "Account Receivable Report - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = ("Account Receivable Report - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rr1 = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                // cmd.CommandText = "select CustomerCode, sum(ItemTotal) as Total_Amount from JOPayment GROUP BY CustomerCode";
                cmd.CommandText = "select CustomerName, sum(Bal) as Receiveable from JOPayment where CustomerName Like '%" + TxtSer.Text + "%' GROUP BY CustomerName";
                // cmd.CommandText = "select CustomerName, sum(ItemTotal) as Amount from InvoiceCompletedDetails where CustomerName Like '%" + TxtSer.Text + "%' GROUP BY CustomerName";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dgvRows = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                ////************************************************************************** 


                DGViewSize();
                con.Close();

                for (int k = 0; k < dgvRows; k++)
                {
                    rr1 = rr1 + Convert.ToDouble(dataGridView1.Rows[k].Cells[1].Value);
                }
                lblTot.Text = "Rs. " + rr1.ToString("#,###.00");
                // dgvRows = dataGridView1.RowCount;
                // var row2 = new DataGridViewRow();
                // row2 = new DataGridViewRow();
                // dataGridView1.Rows.Add(row2);

                // dataGridView1.Rows[dgvRows].Cells[0].Value = "Total Reveaveable";
                //// dataGridView1.Rows[dgvRows].Cells[1].Value = Convert.ToDouble(rr1.ToString());
                // dataGridView1.Rows[dgvRows].Cells[1].Style.Font = label7.Font;
                // dataGridView1.Rows[dgvRows].Cells[0].Style.Font = label7.Font;
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-103-STAX-INVR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
