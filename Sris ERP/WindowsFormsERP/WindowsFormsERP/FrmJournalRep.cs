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
    public partial class FrmJournalRep : Form
    {
        int count = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void DGViewSize()
        {
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            //dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            //dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 124;
            dataGridView1.Columns[2].Width = 145;
            dataGridView1.Columns[3].Width =600;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            string aa = "", bb = "", ab = "", tt = "0";            
            for (int ca1 = 0; ca1 < count; ca1++)
            {
                aa = dataGridView1.Rows[ca1].Cells[4].Value.ToString();
                ab = dataGridView1.Rows[ca1].Cells[5].Value.ToString();


                for (int ca2=0; ca2<4; ca2++)
                {
                    dataGridView1.Rows[0].Cells[ca2].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                }

                if (aa == "0.0000")
                {
                    dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.Lavender, BackColor = Color.Lavender };
                    dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                }
                if (ab == "0.0000")
                {
                    dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                    dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.Lavender, BackColor = Color.Lavender };
                }

                if (ca1==0)
                {
                    bb = "Green";
                }
                
                if (ca1>0)
                {
                    if (dataGridView1.Rows[ca1 - 1].Cells[1].Value.ToString() != "" && dataGridView1.Rows[ca1 - 1].Cells[1].Value.ToString() != "0")
                    {
                        tt = dataGridView1.Rows[ca1].Cells[1].Value.ToString();
                    }

                    if (dataGridView1.Rows[ca1 - 1].Cells[1].Value.ToString() == dataGridView1.Rows[ca1].Cells[1].Value.ToString() || (dataGridView1.Rows[ca1 - 1].Cells[1].Value.ToString() =="" && tt== dataGridView1.Rows[ca1].Cells[1].Value.ToString()))
                    {   
                        dataGridView1.Rows[ca1].Cells[1].Value = "";
                        if (bb == "Green")
                        {
                            bb = "Green";
                            for (int ca2 = 0; ca2 < 4; ca2++)
                            {
                                dataGridView1.Rows[ca1].Cells[ca2].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                            }

                            if (aa == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.Lavender, BackColor = Color.Lavender };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                            }
                            if (ab == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.Lavender, BackColor = Color.Lavender };
                            }
                        }
                        else 
                        {
                            bb = "Blue";
                            for (int ca2 = 0; ca2 < 4; ca2++)
                            {
                                dataGridView1.Rows[ca1].Cells[ca2].Style = new DataGridViewCellStyle { BackColor = Color.AliceBlue };
                            }

                            if (aa == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.AliceBlue, BackColor = Color.AliceBlue };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { BackColor = Color.AliceBlue };
                            }
                            if (ab == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { BackColor = Color.AliceBlue };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.AliceBlue, BackColor = Color.AliceBlue };
                            }
                        }
                    }
                    else
                    {
                        if (bb == "Blue")
                        {
                            bb = "Green";
                            for (int ca2 = 0; ca2 < 4; ca2++)
                            {
                                dataGridView1.Rows[ca1].Cells[ca2].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                            }

                            if (aa == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.Lavender, BackColor = Color.Lavender };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                            }
                            if (ab == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { BackColor = Color.Lavender };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.Lavender, BackColor = Color.Lavender };
                            }
                        }
                        else
                        {
                            bb = "Blue";
                            for (int ca2 = 0; ca2 < 4; ca2++)
                            {
                                dataGridView1.Rows[ca1].Cells[ca2].Style = new DataGridViewCellStyle { BackColor = Color.AliceBlue };
                            }

                            if (aa == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { ForeColor = Color.AliceBlue, BackColor = Color.AliceBlue };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { BackColor = Color.AliceBlue };
                            }
                            if (ab == "0.0000")
                            {
                                dataGridView1.Rows[ca1].Cells[4].Style = new DataGridViewCellStyle { BackColor = Color.AliceBlue };
                                dataGridView1.Rows[ca1].Cells[5].Style = new DataGridViewCellStyle { ForeColor = Color.AliceBlue, BackColor = Color.AliceBlue };
                            }
                        }
                    }
                }                   
            }
            dataGridView1.ClearSelection();
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 2;
           // pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            // pdftable.DefaultCell.BorderWidth = 1;
            pdftable.TotalWidth = 580f;
            pdftable.LockedWidth = true;
            float[] widths = new float[] { 0f, 20f, 40f, 160f, 40f, 40f, 0f, 0f, 0f, 0f };
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
                    //pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    string s = cell.FormattedValue.ToString();
                    PdfPCell cell1 = new PdfPCell(new Phrase(s, text));
                    if (cell.ColumnIndex.ToString() == "2")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    else if (cell.ColumnIndex.ToString() == "4" || cell.ColumnIndex.ToString() == "5")
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
                    Paragraph para = new Paragraph("General Journal Report ");
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

        public FrmJournalRep()
        {
            InitializeComponent();
        }

        private void FrmJournalRep_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            count = 0;
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Journal where Jno Like '%" + TxtSer.Text + "%' or Particular Like '%" + TxtSer.Text + "%'";
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
                MessageBox.Show("ERROR CODE : SER-CNG-102-IOU-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, "General Journal Report-" + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = ("General Journal Report-" + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
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
