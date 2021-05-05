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
    public partial class FrmBankRecnRep : Form
    {
        public int r, x, y;
        public OleDbDataAdapter ada = new OleDbDataAdapter();
        public OleDbCommandBuilder cmd = new OleDbCommandBuilder();
        public DataRow drow;
        public DataTable dt = new DataTable();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void txtbankname_TextChanged(object sender, EventArgs e)
        {
            comaccno.Items.Clear();
            dt.Clear();
            ada = new OleDbDataAdapter("SELECT accno FROM [BankReconciliation] WHERE [bankname] = '" + txtbankname.Text + "'", con);
            dt = new DataTable();
            cmd = new OleDbCommandBuilder(ada);
            ada.Fill(dt);
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
                comaccno.Items.Add(dt.Rows[i]["accno"].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                ada = new OleDbDataAdapter("SELECT accno,bankname,checkno,payment,deposit FROM [BankReconciliation] WHERE [bankname] = '" + txtbankname.Text + "' and  [accno] ='" + comaccno.Text + "'", con);

                dt = new DataTable();
                cmd = new OleDbCommandBuilder(ada);
                ada.Fill(dt);
                dataGridView2.DataSource = dt;
            }

            catch
            {

            }
        }

        //private void DGViewSize()
        //{
        //    dataGridView1.Columns[0].Visible = false;
        //    dataGridView1.Columns[1].Width = 28;
        //    dataGridView1.Columns[2].Width = 57;
        //    if (lblULevel1.Text == "USER")
        //    {
        //        // dataGridView1.Columns[24].Visible = false;
        //        // dataGridView1.Columns[25].Visible = false;
        //        // dataGridView1.Columns[26].Visible = false;
        //        // dataGridView1.Columns[27].Visible = false;
        //    }
        //    else
        //    {
        //        //dataGridView1.Columns[2].Width = 50;
        //        //dataGridView1.Columns[24].Width = 29;
        //        //dataGridView1.Columns[25].Width = 46;
        //        //dataGridView1.Columns[26].Width = 29;
        //        //dataGridView1.Columns[27].Width = 70;
        //    }
        //}

        //public void EPDFReport(DataGridView dgw, string filename)
        //{
        //    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
        //    PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
        //    pdftable.DefaultCell.Padding = 3;
        //    pdftable.WidthPercentage = 100;
        //    pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    pdftable.DefaultCell.BorderWidth = 1;

        //    iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
        //    //Add Header            
        //    foreach (DataGridViewColumn column in dgw.Columns)
        //    {
        //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
        //        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);//
        //        pdftable.AddCell(cell);
        //    }

        //    //Add Data Row            
        //    foreach (DataGridViewRow row in dgw.Rows)
        //    {
        //        foreach (DataGridViewCell cell in row.Cells)
        //        {
        //            pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
        //        }
        //    }
        //    var savefiledialoge = new SaveFileDialog();
        //    savefiledialoge.FileName = filename;
        //    savefiledialoge.DefaultExt = ".pdf";
        //    if (savefiledialoge.ShowDialog() == DialogResult.OK)
        //    {
        //        using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
        //        {
        //            Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        //            PdfWriter.GetInstance(pdfdoc, stream);
        //            pdfdoc.Open();
        //            Paragraph para = new Paragraph("Stock Report ");
        //            Paragraph para0 = new Paragraph(DateTime.Now.ToString("dd.MM.yyyy"));
        //            Paragraph para1 = new Paragraph(" ");
        //            para.Alignment = Element.ALIGN_CENTER;
        //            para0.Alignment = Element.ALIGN_CENTER;
        //            pdfdoc.Add(para);
        //            pdfdoc.Add(para0);
        //            pdfdoc.Add(para1);
        //            pdfdoc.Add(pdftable);
        //            pdfdoc.Close();
        //            stream.Close();
        //        }
        //    }
        //}
        public FrmBankRecnRep()
        {
            InitializeComponent();
        }

        private void FrmBankRecnRep_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            // TxtSer_TextChanged(null, null);

            con.Open();
            ada = new OleDbDataAdapter("select * from BankReconciliation", con);

            cmd = new OleDbCommandBuilder(ada);

            dt = new DataTable();

            cmd = new OleDbCommandBuilder(ada);

            ada.Fill(dt);

            //  dataGridView1.DataSource = dt;

            try
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    txtbankname.AutoCompleteCustomSource.Add(dt.Rows[i]["bankname"].ToString());
            }
            catch
            {

            }
        }
    }
}
