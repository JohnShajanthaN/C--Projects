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
    public partial class FrmLeadger : Form
    {
     //   int count = 0;
       // int count1 = 0;
        int dgvRows = 0, dgvRows2 = 0, dgvRows3 = 0, dgvRows4;
        double DD1 = 0.00, LL1 = 0.00, RR1 = 0.00;
        string lg1 = "", AType = "", BalType = "", CFType = "", CreditDebit = "";//, DEParticular="";
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void PLAC()
        {
            con.Open();
            OleDbCommand cmd4 = new OleDbCommand("select * from Journal where Particular='" + lg1 + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();
            while (rdr.Read())
            {
                AType = rdr["PLACType"].ToString();
            }
            con.Close();//////////////////////////////
        }
        private void BalAL()
        {
            con.Open();
            OleDbCommand cmd5 = new OleDbCommand("select * from Journal where Particular='" + lg1 + "' ", con);
            cmd5.Connection = con;
            rdr = cmd5.ExecuteReader();
            while (rdr.Read())
            {
                BalType = rdr["BalALType"].ToString();
            }
            con.Close();//////////////////////////////
        }

        private void CFlow()
        {
            con.Open();
            OleDbCommand cmd6 = new OleDbCommand("select * from Journal where Particular='" + lg1 + "' ", con);
            cmd6.Connection = con;
            rdr = cmd6.ExecuteReader();
            while (rdr.Read())
            {
                CFType = rdr["CashFlow"].ToString();
            }
            con.Close();//////////////////////////////
        }

        private void DGViewSize()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].HeaderText = "   Date";
            dataGridView1.Columns[1].HeaderText = " Particular";
            dataGridView1.Columns[2].HeaderText = "  Amount";
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 410;
            dataGridView1.Columns[2].Width = 81;

            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[0].HeaderText = "   Date";
            dataGridView2.Columns[1].HeaderText = " Particular";
            dataGridView2.Columns[2].HeaderText = "  Amount";
            dataGridView2.Columns[0].Width = 75;
            dataGridView2.Columns[1].Width = 418;
            dataGridView2.Columns[2].Width = 81;

            var row1 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from Journal where Debit > 0 AND Particular='" + lg1 + "' ", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                row1 = new DataGridViewRow();
                dataGridView1.Rows.Add(row1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = Convert.ToDateTime(rdr["JDate"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[dgvRows - 1].Cells[1].Value = rdr["Opc"].ToString();
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                LL1 = LL1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[2].Value);
            }
            con.Close();

            var row2 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from Journal where Credit > 0 AND Particular='" + lg1 + "' ", con);
            cmd2.Connection = con;
            rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                row2 = new DataGridViewRow();
                dataGridView2.Rows.Add(row2);

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = Convert.ToDateTime(rdr["JDate"].ToString()).ToString("dd/MM/yyyy");
                dataGridView2.Rows[dgvRows2 - 1].Cells[1].Value = rdr["Opc"].ToString();
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                RR1 = RR1 + Convert.ToDouble(dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value);
            }
            con.Close();


            dgvRows = dataGridView1.RowCount;
            dgvRows2 = dataGridView2.RowCount;
            if (dgvRows > dgvRows2)
            {
                dgvRows3 = dgvRows - dgvRows2;
                dgvRows4 = dgvRows;

                var row3 = new DataGridViewRow();
                for (int k = 1; k < dgvRows3 + 2; k++)
                {
                    row3 = new DataGridViewRow();
                    dataGridView2.Rows.Add(row3);
                }
                row3 = new DataGridViewRow();
                dataGridView1.Rows.Add(row3);

            }
            else
            {
                dgvRows3 = dgvRows2 - dgvRows;
                dgvRows4 = dgvRows2;

                var row4 = new DataGridViewRow();
                for (int k = 1; k < dgvRows3 + 2; k++)
                {
                    row4 = new DataGridViewRow();
                    dataGridView1.Rows.Add(row4);
                }
                row4 = new DataGridViewRow();
                dataGridView2.Rows.Add(row4);

            }
            var row5 = new DataGridViewRow();
            row5 = new DataGridViewRow();
            dataGridView1.Rows.Add(row5);
            row5 = new DataGridViewRow();
            dataGridView2.Rows.Add(row5);

            row5 = new DataGridViewRow();
            dataGridView1.Rows.Add(row5);
            row5 = new DataGridViewRow();
            dataGridView2.Rows.Add(row5);

            if (LL1 > RR1)
            {
                DD1 = LL1 - RR1;
                dataGridView2.Rows[dgvRows4].Cells[1].Value = "Balance C/d";
                dataGridView2.Rows[dgvRows4].Cells[2].Value = Convert.ToDouble(DD1.ToString());

                dataGridView1.Rows[dgvRows4 + 1].Cells[2].Value = Convert.ToDouble(LL1.ToString());
                dataGridView2.Rows[dgvRows4 + 1].Cells[2].Value = Convert.ToDouble(LL1.ToString());

                dataGridView1.Rows[dgvRows4 + 2].Cells[1].Value = "Balance B/d";
                dataGridView1.Rows[dgvRows4 + 2].Cells[2].Value = Convert.ToDouble(DD1.ToString());
                CreditDebit = "Debit";
            }
            else
            {
                DD1 = RR1 - LL1;
                dataGridView1.Rows[dgvRows4].Cells[1].Value = "Balance C/d";
                dataGridView1.Rows[dgvRows4].Cells[2].Value = Convert.ToDouble(DD1.ToString());

                dataGridView1.Rows[dgvRows4 + 1].Cells[2].Value = Convert.ToDouble(RR1.ToString());
                dataGridView2.Rows[dgvRows4 + 1].Cells[2].Value = Convert.ToDouble(RR1.ToString());


                dataGridView2.Rows[dgvRows4 + 2].Cells[1].Value = "Balance B/d";
                dataGridView2.Rows[dgvRows4 + 2].Cells[2].Value = Convert.ToDouble(DD1.ToString());
                CreditDebit = "Credit";
            }

            dataGridView1.Rows[dgvRows4 + 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows4 + 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView1.Rows[dgvRows4 + 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView2.Rows[dgvRows4 + 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView2.Rows[dgvRows4 + 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
            dataGridView2.Rows[dgvRows4 + 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };

            dataGridView1.Rows[dgvRows4 + 1].Cells[2].Style.Font = label7.Font;
            dataGridView2.Rows[dgvRows4 + 1].Cells[2].Style.Font = label7.Font;
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void DGView3()
        {
            dataGridView3.Font = label7.Font;
            dataGridView3.DefaultCellStyle.Font = label8.Font;

            dataGridView3.ColumnCount = 7;
            dataGridView3.Columns[0].Width = 60;
            dataGridView3.Columns[1].Width = 415;
            dataGridView3.Columns[2].Width = 75;
            dataGridView3.Columns[0].HeaderText = "   Date";
            dataGridView3.Columns[1].HeaderText = " Particular";
            dataGridView3.Columns[2].HeaderText = "  Amount";
            dataGridView3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView3.Columns[3].Width = 0;

            dataGridView3.Columns[4].Width = 60;
            dataGridView3.Columns[5].Width = 415;
            dataGridView3.Columns[6].Width = 120;
            dataGridView3.Columns[4].HeaderText = "   Date";
            dataGridView3.Columns[5].HeaderText = " Particular";
            dataGridView3.Columns[6].HeaderText = "  Amount";
            dataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns[6].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var row1 = new DataGridViewRow();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row1 = new DataGridViewRow();
                dataGridView3.Rows.Add(row1);
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    dataGridView1.Rows[i].Cells[0].Value = " ";
                }
                if (dataGridView1.Rows[i].Cells[1].Value == null)
                {
                    dataGridView1.Rows[i].Cells[1].Value = " ";
                }
                if (dataGridView1.Rows[i].Cells[2].Value == null)
                {
                    dataGridView1.Rows[i].Cells[2].Value = " ";
                }

                dataGridView3.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                dataGridView3.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                dataGridView3.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;

                dataGridView3.Rows[i].Cells[0].Style = dataGridView1.Rows[i].Cells[0].Style;
                dataGridView3.Rows[i].Cells[1].Style = dataGridView1.Rows[i].Cells[1].Style;
                dataGridView3.Rows[i].Cells[2].Style = dataGridView1.Rows[i].Cells[2].Style;

                if (dataGridView2.Rows[i].Cells[0].Value == null)
                {
                    dataGridView2.Rows[i].Cells[0].Value = " ";
                }
                if (dataGridView2.Rows[i].Cells[1].Value == null)
                {
                    dataGridView2.Rows[i].Cells[1].Value = " ";
                }
                if (dataGridView2.Rows[i].Cells[2].Value == null)
                {
                    dataGridView2.Rows[i].Cells[2].Value = " ";
                }

                dataGridView3.Rows[i].Cells[4].Value = dataGridView2.Rows[i].Cells[0].Value;
                dataGridView3.Rows[i].Cells[5].Value = dataGridView2.Rows[i].Cells[1].Value;
                dataGridView3.Rows[i].Cells[6].Value = dataGridView2.Rows[i].Cells[2].Value;

                dataGridView3.Rows[i].Cells[4].Style = dataGridView2.Rows[i].Cells[0].Style;
                dataGridView3.Rows[i].Cells[5].Style = dataGridView2.Rows[i].Cells[1].Style;
                dataGridView3.Rows[i].Cells[6].Style = dataGridView2.Rows[i].Cells[2].Style;

                dataGridView3.Rows[i].Cells[3].Value = " ";
                dataGridView3.ClearSelection();
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
            float[] widths = new float[] { 33f, 100f, 44f, 1f, 33f, 100f, 44f };
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
                    if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "4")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    else if (cell.ColumnIndex.ToString() == "2" || cell.ColumnIndex.ToString() == "6")
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
                    Paragraph para = new Paragraph(this.Text);
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
        public FrmLeadger()
        {
            InitializeComponent();
        }

        private void FrmLeadger_Load(object sender, EventArgs e)
        {
            lg1 = FrmLedgerList.lg;            
            this.label1.Text = this.Text + " Leadger";
            Refresh();
            this.Refresh();
            Refresh();
            this.Refresh();
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            AType = "Others";            
            PLAC();
            BalType = "";
            BalAL();
            CFType = "";
            CFlow();
            label6.Visible = false;
            //count = 0;
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGViewSize();
                DGView3();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-102-IOU-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreditDebit == "Credit")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into TB(Particular, Debit, Credit, PLACType, BalALType, CashFlow) values('"
                   + lg1 + "', '" + "0.00" + "', '" + DD1 + "', '" + AType + "', '" + BalType + "', '" + CFType + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Posting Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CreditDebit == "Debit")
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into TB(Particular, Debit, Credit, PLACType, BalALType, CashFlow) values('"
                    + lg1 + "', '" + DD1 + "', '" + "0.00" + "', '" + AType + "', '" + BalType + "', '" + CFType + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();                    
                    MessageBox.Show("Record Posting Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else
                //{
                //    MessageBox.Show("Please Select Catogery! Don't Type!", "Typing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView3, label1.Text + " - " + DateTime.Now.ToString("dd.MM.yyyy"));
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
