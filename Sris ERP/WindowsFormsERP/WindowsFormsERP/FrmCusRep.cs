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
    public partial class FrmCusRep : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[18].Visible = false;

            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 190;
            dataGridView1.Columns[3].Width = 330;
            dataGridView1.Columns[4].Width = 380;
            dataGridView1.Columns[5].Width = 260;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 170;
            dataGridView1.Columns[8].Width = 170;
            dataGridView1.Columns[9].Width = 170;
            dataGridView1.Columns[10].Width = 220;
            dataGridView1.Columns[11].Width = 290;
            dataGridView1.Columns[12].Width = 190;

            dataGridView1.Columns[0].HeaderText = " C.Code";
            dataGridView1.Columns[1].HeaderText = " C.Type";
            dataGridView1.Columns[2].HeaderText = " Vat No";
            dataGridView1.Columns[3].HeaderText = " Customer";
            dataGridView1.Columns[4].HeaderText = " Address";
            dataGridView1.Columns[5].HeaderText = " C.Person";
            dataGridView1.Columns[6].HeaderText = " Land No";
            dataGridView1.Columns[7].HeaderText = " Mobile";
            dataGridView1.Columns[8].HeaderText = " Fax";
            dataGridView1.Columns[9].HeaderText = " E-Mail";
            dataGridView1.Columns[10].HeaderText = " P.Terms";
            dataGridView1.Columns[11].HeaderText = " Comments";
            dataGridView1.Columns[12].HeaderText = " C.Category";


            if (lblULevel1.Text == "Administrator")
            {
                //
                //dataGridView1.Columns[24].Width = 29;
                //dataGridView1.Columns[25].Width = 46;
                //dataGridView1.Columns[26].Width = 29;
                //dataGridView1.Columns[27].Width = 70;                
            }
            else 
            {
                // dataGridView1.Columns[24].Visible = false;
                // dataGridView1.Columns[25].Visible = false;
                // dataGridView1.Columns[26].Visible = false;
                // dataGridView1.Columns[27].Visible = false;
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
            float[] widths = new float[] { 50f, 0f, 70f, 0f, 130f, 150f, 0f, 70f, 70f, 0, 0f, 70f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
            pdftable.SetWidths(widths);
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
                    if (cell.ColumnIndex.ToString() == "7" || cell.ColumnIndex.ToString() == "8" || cell.ColumnIndex.ToString() == "0")
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
                    Paragraph para = new Paragraph("Customer Report ");
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

        public FrmCusRep()
        {
            InitializeComponent();
        }

        private void FrmCusRep_Load(object sender, EventArgs e)
        {
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
                cmd.CommandText = "select * from customer where CustomerCode Like '%" + TxtSer.Text + "%' or CustomerType Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or customeraddress Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or CustomerLandNo Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-139-CUS-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, "Customer Report-" + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = ("Customer Report-" + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
