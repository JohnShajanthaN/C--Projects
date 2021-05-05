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
    public partial class FrmVoucherRep : Form
    {
        int dgvRows = 0;
        double aa = 0.00;
        //public static string cus = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            //dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView1.Columns[10].DefaultCellStyle.Format = "#,###.00";
            //dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 80;
            //dataGridView1.Columns[4].Width = 129;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 210;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 140;
           // dataGridView1.Columns[10].Width = 100;
          //  dataGridView1.Columns[11].Width = 100;
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 2;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            //pdftable.DefaultCell.BorderWidth = 1;
            pdftable.TotalWidth = 580f;
            pdftable.LockedWidth = true;
            float[] widths = new float[] { 0f, 60f, 80f, 60f, 80f, 0f, 180f, 60f, 60f };
            pdftable.SetWidths(widths);

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dgw.Columns)//Add Header  
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
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
                    else if(cell.ColumnIndex.ToString() == "8")
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
                    Paragraph para = new Paragraph("Voucher Payment Report");
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
        public FrmVoucherRep()
        {
            InitializeComponent();
        }

        private void FrmVoucherRep_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, "Voucher Payment Report - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = ("Voucher Payment Report - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "select * from Voucher ";
               // cmd.CommandText = "select PurchaseGRN.PONO, PurchaseGRN.GRNNo, PurchaseGRN.GRNDate, PurchaseGRN.SupplierCode, PurchaseGRN.Supplier, PurchaseGRN.StockNumber,  PurchaseGRN.Description, PurchaseGRN.Weight, PurchaseGRN.RvdQty, PurchaseGRN.Unit, Purchase.CostPrice, (Purchase.CostPrice*PurchaseGRN.RvdQty) As Payable from PurchaseGRN INNER JOIN Purchase ON PurchaseGRN.PONO=Purchase.PONO;";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dgvRows = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;


                con.Close();
                DGViewSize();

                for (int k = 0; k < dgvRows; k++)
                {
                    aa = aa + Convert.ToDouble(dataGridView1.Rows[k].Cells[8].Value);
                }
                lblTot.Text = "Rs. " + aa.ToString("#,###.00");
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-103-STAX-INVR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
