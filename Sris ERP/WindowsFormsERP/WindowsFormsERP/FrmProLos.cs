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
    public partial class FrmProLos : Form
    {
        int count = 0;
        //int count1 = 0;
        //double aa = 0.00, bb = 0.00, cc = 0.00;
        string ProfitLoss1 = "";// lg1 = "";
        int dgvRows = 0, dgvRows2 = 0, dgvRows3 = 0, dgvRows4;
        double Pur = 0.00, PurRet = 0.00, Sale=0.00, SlRet=0.00, PP1=0.00, SS1=0.00, tot=0.00, PPPP1 = 0.00, SSSS1 = 0.00, GP=0.00, GL=0.00, NP=0.00, NL=0.00, OPS=0.00, CLS=0.00;

        private void CmdPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProfitLoss1 == "Profit")
                {
                    OleDbCommand cmd = new OleDbCommand("Update ProfitLoss SET Particular='" + "Net Profit" + "', Amount='" + NP 
                        + "' WHERE ID=" + "1" + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Posting Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ProfitLoss1 == "Loss")
                {
                    OleDbCommand cmd = new OleDbCommand("Update ProfitLoss SET Particular='" + "Net Loss" + "', Amount='" + NL
                        + "' WHERE ID=" + "1" + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Posting Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            
            dataGridView1.Font = label7.Font;
            dataGridView1.DefaultCellStyle.Font = label6.Font;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Width = 341;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 115;
            dataGridView1.Columns[0].HeaderText = "Particular";
            dataGridView1.Columns[1].HeaderText = "    Amount";
            dataGridView1.Columns[2].HeaderText = "    Amount";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView2.Font = label7.Font;
            dataGridView2.DefaultCellStyle.Font = label6.Font;
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Width = 341;
            dataGridView2.Columns[1].Width = 115;
            dataGridView2.Columns[2].Width = 115;
            dataGridView2.Columns[0].HeaderText = "Particular";
            dataGridView2.Columns[1].HeaderText = "    Amount";
            dataGridView2.Columns[2].HeaderText = "    Amount";
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N2";

            PP1 = OPS + Pur - PurRet;
            SS1 = Sale - SlRet + CLS;

            var rown1 = new DataGridViewRow();

            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "   Opening Stock";
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = OPS.ToString("#,##0.00");
            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);

            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = " Purchase Accounts";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;

            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "   Purchase";
            dataGridView1.Rows[dgvRows - 1].Cells[1].Value = Pur.ToString("#,##0.00");


            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "    (-) Purchase Return";
            dataGridView1.Rows[dgvRows - 1].Cells[1].Value = PurRet.ToString("#,##0.00");
            dataGridView1.Rows[dgvRows - 1].Cells[2].Value = (Pur - PurRet).ToString("#,##0.00");
            dataGridView1.Rows[dgvRows - 1].Cells[2].Style.Font = label7.Font;
            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);


            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = " Direct Expenses";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;

            var row444 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd4 = new OleDbCommand("select * from TB where PLACType='" + "Direct Expenses" + "' ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();
            while (rdr.Read())
            {
                row444 = new DataGridViewRow();
                dataGridView1.Rows.Add(row444);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                PP1 = PP1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[2].Value);
            }
            con.Close();


            //DGView 2
            rown1 = new DataGridViewRow();
            dataGridView2.Rows.Add(rown1);
            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = " Sales Accounts";
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style.Font = label7.Font;


            rown1 = new DataGridViewRow();
            dataGridView2.Rows.Add(rown1);

            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "   Sales";
            dataGridView2.Rows[dgvRows2 - 1].Cells[1].Value = Sale.ToString("#,##0.00");

            rown1 = new DataGridViewRow();
            dataGridView2.Rows.Add(rown1);

            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "    (-) Sales Return";
            dataGridView2.Rows[dgvRows2 - 1].Cells[1].Value = SlRet.ToString("#,##0.00");
            dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = (Sale - SlRet).ToString("#,##0.00");
            dataGridView2.Rows[dgvRows2 - 1].Cells[2].Style.Font = label7.Font;

            rown1 = new DataGridViewRow();
            dataGridView2.Rows.Add(rown1);
            rown1 = new DataGridViewRow();
            dataGridView2.Rows.Add(rown1);

            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "   Closing Stock";
            dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = CLS.ToString("#,##0.00");



            if (SS1 > PP1)
            {
                rown1 = new DataGridViewRow();
                dataGridView1.Rows.Add(rown1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "   Gross Profit C/d";
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = (SS1 - PP1).ToString("#,##0.00");
                dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
                dataGridView1.Rows[dgvRows - 1].Cells[2].Style.Font = label7.Font;
                dataGridView1.Rows[dgvRows - 1].Cells[1].Style.Font = label7.Font;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;

                GP = SS1 - PP1;

                rown1 = new DataGridViewRow();
                dataGridView1.Rows.Add(rown1);
                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = SS1.ToString("#,##0.00");

                dgvRows = dataGridView1.RowCount;
                dgvRows2 = dataGridView2.RowCount;
                if (dgvRows > dgvRows2)
                {
                    dgvRows3 = dgvRows - dgvRows2;
                    dgvRows4 = dgvRows;
                }
                else
                {
                    dgvRows3 = dgvRows2 - dgvRows;
                    dgvRows4 = dgvRows2;
                }
                dataGridView1.Rows[dgvRows - 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView1.Rows[dgvRows - 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView1.Rows[dgvRows - 1].Cells[2].Style.Font = label7.Font;
            }
            dataGridView1.ClearSelection();

            
            if (PP1 > SS1)
            {
                dgvRows = dataGridView1.RowCount;
                dgvRows2 = dataGridView2.RowCount;
                if (dgvRows > dgvRows2)
                {
                    dgvRows3 = dgvRows - dgvRows2;
                    dgvRows4 = dgvRows;
                }
                else
                {
                    dgvRows3 = dgvRows2 - dgvRows;
                    dgvRows4 = dgvRows2;
                }
                var row5551 = new DataGridViewRow();
                for (int k = 1; k < dgvRows3 - 1; k++)
                {
                    row5551 = new DataGridViewRow();
                    dataGridView2.Rows.Add(row5551);
                }

                rown1 = new DataGridViewRow();
                dataGridView2.Rows.Add(rown1);
                dgvRows = dataGridView1.RowCount;
                dgvRows2 = dataGridView2.RowCount;
                if (dgvRows > dgvRows2)
                {
                    dgvRows3 = dgvRows - dgvRows2;
                    dgvRows4 = dgvRows;
                }
                else
                {
                    dgvRows3 = dgvRows2 - dgvRows;
                    dgvRows4 = dgvRows2;
                }
                var row555A = new DataGridViewRow();
                for (int k = 1; k < dgvRows3 + 1; k++)
                {
                    row555A = new DataGridViewRow();
                    dataGridView2.Rows.Add(row555A);
                }

                dataGridView2.Rows[dgvRows4 - 1].Cells[0].Value = "   Gross Loss C/d";
                dataGridView2.Rows[dgvRows4 - 1].Cells[2].Value = (PP1 - SS1).ToString("#,##0.00");
                dataGridView2.Rows[dgvRows4 - 1].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                dataGridView2.Rows[dgvRows4 - 1].Cells[2].Style.Font = label7.Font;
                dataGridView2.Rows[dgvRows4 - 1].Cells[1].Style.Font = label7.Font;
                dataGridView2.Rows[dgvRows4 - 1].Cells[0].Style.Font = label7.Font;

                GL = PP1 - SS1;
                //////////////////////////////////////////////////////////////
                rown1 = new DataGridViewRow();
                dataGridView1.Rows.Add(rown1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = PP1.ToString("#,##0.00");

                dgvRows = dataGridView1.RowCount;
                dgvRows2 = dataGridView2.RowCount;
                if (dgvRows > dgvRows2)
                {
                    dgvRows3 = dgvRows - dgvRows2;
                    dgvRows4 = dgvRows;
                }
                else
                {
                    dgvRows3 = dgvRows2 - dgvRows;
                    dgvRows4 = dgvRows2;
                }

                //var row555 = new DataGridViewRow();
                //for (int k = 1; k < dgvRows3-1; k++)
                //{
                //    row555 = new DataGridViewRow();
                //    dataGridView2.Rows.Add(row555);
                //}
                var row555 = new DataGridViewRow();
                row555 = new DataGridViewRow();
                dataGridView2.Rows.Add(row555);

               // dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows4 - 1].Cells[2].Value = PP1.ToString("#,##0.00");

                rown1 = new DataGridViewRow();
                dataGridView1.Rows.Add(rown1);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "   Gross Loss B/d";
                dataGridView1.Rows[dgvRows - 1].Cells[2].Value = (PP1 - SS1).ToString("#,##0.00");
                dataGridView1.Rows[dgvRows - 1].Cells[2].Style.Font = label7.Font;
                dataGridView1.Rows[dgvRows - 1].Cells[1].Style.Font = label7.Font;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;

                GL = PP1 - SS1;

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2-1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView2.Rows[dgvRows2 - 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Style.Font = label7.Font;

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows-2].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView1.Rows[dgvRows - 2].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView1.Rows[dgvRows - 2].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView1.Rows[dgvRows - 2].Cells[2].Style.Font = label7.Font;
            }
            else
            {
                dgvRows2 = dataGridView2.RowCount;
                var row555 = new DataGridViewRow();
                for (int k =1; k < dgvRows - dgvRows2+1; k++)
                {
                    row555 = new DataGridViewRow();
                    dataGridView2.Rows.Add(row555);
                }

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = SS1.ToString("#,##0.00");

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2-1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView2.Rows[dgvRows2 - 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen };
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Style.Font = label7.Font;

                rown1 = new DataGridViewRow();
                dataGridView2.Rows.Add(rown1);

                dgvRows2 = dataGridView2.RowCount;
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = "   Gross Profit B/d";
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Value = (SS1 - PP1).ToString("#,##0.00");
                dataGridView2.Rows[dgvRows2 - 1].Cells[2].Style.Font = label7.Font;
                dataGridView2.Rows[dgvRows2 - 1].Cells[1].Style.Font = label7.Font;
                dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style.Font = label7.Font;

                GP = SS1 - PP1;
            }

            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            rown1 = new DataGridViewRow();
            dataGridView1.Rows.Add(rown1);
            dgvRows = dataGridView1.RowCount;
            dataGridView1.Rows[dgvRows - 1].Cells[0].Value = " Indirect Expenses";
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView1.Rows[dgvRows - 1].Cells[0].Style.Font = label7.Font;


            var row666 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd41 = new OleDbCommand("select * from TB where PLACType='" + "Indirect Expenses" + "' ", con);
            cmd41.Connection = con;
            rdr = cmd41.ExecuteReader();
            while (rdr.Read())
            {
                row666 = new DataGridViewRow();
                dataGridView1.Rows.Add(row666);

                dgvRows = dataGridView1.RowCount;
                dataGridView1.Rows[dgvRows - 1].Cells[0].Value = "  " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView1.Rows[dgvRows - 1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                PPPP1 = PPPP1 + Convert.ToDouble(dataGridView1.Rows[dgvRows - 1].Cells[2].Value);
            }
            con.Close();

            rown1 = new DataGridViewRow();
            dataGridView2.Rows.Add(rown1);
            dgvRows2 = dataGridView2.RowCount;
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Value = " Indirect Incomes";
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
            dataGridView2.Rows[dgvRows2 - 1].Cells[0].Style.Font = label7.Font;

            var row777 = new DataGridViewRow();
            con.Open();
            OleDbCommand cmd5 = new OleDbCommand("select * from TB where PLACType='" + "Indirect Incomes" + "' ", con);
            cmd5.Connection = con;
            rdr = cmd5.ExecuteReader();
            while (rdr.Read())
            {
                row777 = new DataGridViewRow();
                dataGridView2.Rows.Add(row777);

                dgvRows2 = dataGridView2.RowCount;
                dgvRows = dataGridView1.RowCount;

                if (dgvRows > dgvRows2)
                {
                    dgvRows4 = dgvRows;
                    dgvRows3 = dgvRows - dgvRows2;
                }
                else
                {
                    dgvRows4 = dgvRows2;
                    dgvRows3 = dgvRows2 - dgvRows;
                }

                var row555 = new DataGridViewRow();
                row555 = new DataGridViewRow();
                dataGridView2.Rows[dgvRows2-1].Cells[0].Value = "  " + rdr["Particular"].ToString();
                if (Convert.ToDouble(rdr["Debit"].ToString()) > 0.00)
                {
                    dataGridView2.Rows[dgvRows2-1].Cells[2].Value = Convert.ToDouble(rdr["Debit"].ToString());
                }
                else
                {
                    dataGridView2.Rows[dgvRows2-1].Cells[2].Value = Convert.ToDouble(rdr["Credit"].ToString());
                }
                SSSS1 = SSSS1 + Convert.ToDouble(dataGridView2.Rows[dgvRows2-1].Cells[2].Value);
            }
            con.Close();
            
            dgvRows = dataGridView1.RowCount;
            dgvRows2 = dataGridView2.RowCount;

            if (dgvRows > dgvRows2)
            {
                dgvRows3 = dgvRows - dgvRows2;
            }
            else
            {
                dgvRows3 = dgvRows2 - dgvRows;
            }

            PPPP1 = GL+ PPPP1;
            SSSS1 = GP+ SSSS1;

            if (SSSS1 > PPPP1)
            {
                NP = SSSS1 - PPPP1;
                tot = SSSS1;
            }
            else
            {
                NL = PPPP1 - SSSS1;
                tot = PPPP1;
            }

            dgvRows = dataGridView1.RowCount;
            dgvRows2 = dataGridView2.RowCount;
            var row888 = new DataGridViewRow();
            if (dgvRows > dgvRows2)
            {
                dgvRows3 = dgvRows - dgvRows2;
                dgvRows4 = dgvRows;
                //row888 = new DataGridViewRow();
                //dataGridView1.Rows.Add(row888);

                for (int k1 = 1; k1 < dgvRows3 + 2; k1++)
                {
                    row888 = new DataGridViewRow();
                    dataGridView2.Rows.Add(row888);
                }
            }
            else
            {
                dgvRows3 = dgvRows2 - dgvRows;
                dgvRows4 = dgvRows2;
                //row888 = new DataGridViewRow();
                //dataGridView2.Rows.Add(row888);

                for (int k1 = 1; k1 < dgvRows3 + 2; k1++)
                {
                    row888 = new DataGridViewRow();
                    dataGridView1.Rows.Add(row888);
                }
            }

            if (NP > NL)
            {
                ProfitLoss1 = "Profit";
                dataGridView1.Rows[dgvRows4].Cells[0].Value = "   Net Profit";
                dataGridView1.Rows[dgvRows4].Cells[2].Value = NP;
                dataGridView1.Rows[dgvRows4].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Brown };
                dataGridView1.Rows[dgvRows4].Cells[2].Style.Font = label7.Font;
                dataGridView1.Rows[dgvRows4].Cells[1].Style.Font = label7.Font;
                dataGridView1.Rows[dgvRows4].Cells[0].Style.Font = label7.Font;
            }
            else
            {
                ProfitLoss1 = "Loss";
                dataGridView2.Rows[dgvRows4].Cells[0].Value = "   Net Loss";
                dataGridView2.Rows[dgvRows4].Cells[2].Value = NL;
                dataGridView2.Rows[dgvRows4].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                dataGridView2.Rows[dgvRows4].Cells[2].Style.Font = label7.Font;
                dataGridView2.Rows[dgvRows4].Cells[1].Style.Font = label7.Font;
                dataGridView2.Rows[dgvRows4].Cells[0].Style.Font = label7.Font;
            }

            row888 = new DataGridViewRow();
            dataGridView1.Rows.Add(row888);
            row888 = new DataGridViewRow();
            dataGridView2.Rows.Add(row888);
            dataGridView2.Rows[dgvRows4 + 1].Cells[2].Value = tot;
            row888 = new DataGridViewRow();
            dataGridView1.Rows.Add(row888);
            dataGridView1.Rows[dgvRows4 + 1].Cells[2].Value = tot;

            dataGridView2.Rows[dgvRows4 + 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen};
            dataGridView1.Rows[dgvRows4 + 1].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Linen};
            dataGridView2.Rows[dgvRows4 + 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen};
            dataGridView1.Rows[dgvRows4 + 1].Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Linen};
            dataGridView2.Rows[dgvRows4 + 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen};
            dataGridView1.Rows[dgvRows4 + 1].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Linen};
            dataGridView2.Rows[dgvRows4 + 1].Cells[2].Style.Font = label7.Font;
            dataGridView1.Rows[dgvRows4 + 1].Cells[2].Style.Font = label7.Font;

            dataGridView2.ClearSelection();
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void DGView3()
        {
            dataGridView3.Font = label7.Font;
            dataGridView3.DefaultCellStyle.Font = label6.Font;

            dataGridView3.ColumnCount = 7;
            dataGridView3.Columns[0].Width = 491;
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[0].HeaderText = "Particular";
            dataGridView3.Columns[1].HeaderText = "    Amount";
            dataGridView3.Columns[2].HeaderText = "    Amount";
            dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridView3.Columns[3].Width = 1;

            dataGridView3.Columns[4].Width = 491;
            dataGridView3.Columns[5].Width = 100;
            dataGridView3.Columns[6].Width = 130;
            dataGridView3.Columns[4].HeaderText = "Particular";
            dataGridView3.Columns[5].HeaderText = "    Amount";
            dataGridView3.Columns[6].HeaderText = "    Amount";
            dataGridView3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[6].DefaultCellStyle.Format = "N2";

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

            private void OCStock()//??
        {
            con.Open();
            OleDbCommand cmd4 = new OleDbCommand("select * from OpenSt where Amount > 0 ", con);
            cmd4.Connection = con;
            rdr = cmd4.ExecuteReader();
            while (rdr.Read())
            {
                OPS = Convert.ToDouble(rdr["Amount"].ToString());
            }
            con.Close();

            con.Open();
            OleDbCommand cmd5 = new OleDbCommand("select * from CloseSt where Amount > 0 ", con);
            cmd5.Connection = con;
            rdr = cmd5.ExecuteReader();
            while (rdr.Read())
            {
                CLS = Convert.ToDouble(rdr["Amount"].ToString());
            }
            con.Close();
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.TotalWidth = 580f;
            pdftable.LockedWidth = true;
            float[] widths = new float[] { 150f, 53f, 60f, 1f, 150f, 53f, 60f };
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
                    if (cell.ColumnIndex.ToString() == "0" || cell.ColumnIndex.ToString() == "4")
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                    }
                    else
                    {
                        cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
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
                    Paragraph para = new Paragraph(" Trading and Profit & Loss Account Statement ");
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
        public FrmProLos()
        {
            InitializeComponent();
        }

        private void FrmProLos_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            OCStock();
            TxtSer_TextChanged(null, null);            
           // count = 0;
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                //Purchase   
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from TB where Particular='" + "Purchase" + "' ", con);
                cmd1.Connection = con;
                rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    Pur = Convert.ToDouble(rdr["Debit"].ToString());
                }
                con.Close();//////////////////////////////

                //Purchase Return  
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from TB where Particular='" + "Purchase Return" + "' ", con);
                cmd2.Connection = con;
                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    PurRet = Convert.ToDouble(rdr["Credit"].ToString());
                }
                con.Close();//////////////////////////////

                //Sales   
                con.Open();
                OleDbCommand cmd3 = new OleDbCommand("select * from TB where Particular='" + "Sales" + "' ", con);
                cmd3.Connection = con;
                rdr = cmd3.ExecuteReader();
                while (rdr.Read())
                {
                    Sale = Convert.ToDouble(rdr["Credit"].ToString());
                }
                con.Close();//////////////////////////////

                //Sales Return
                con.Open();
                OleDbCommand cmd4 = new OleDbCommand("select * from TB where Particular='" + "Sales Return" + "' ", con);
                cmd4.Connection = con;
                rdr = cmd4.ExecuteReader();
                while (rdr.Read())
                {
                    SlRet = Convert.ToDouble(rdr["Debit"].ToString());
                }
                con.Close();//////////////////////////////

                DGViewSize();
                DGView3();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "  Error No:112 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdPDFExit_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            CmdPDFExit.BackColor = Color.Gainsboro;
            CmdPDFExit.ForeColor = Color.Black;
            CmdPDFExit.UseVisualStyleBackColor = true;
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView3, " Trading and Profit & Loss Account Statement - " + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName = (" Trading and Profit & Loss Account Statement - " + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf");
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                axAcroPDF1.LoadFile(dlg.FileName);
                axAcroPDF1.Visible = true;
                CmdPDFExit.BackColor = Color.Red;
                CmdPDFExit.ForeColor = Color.White;
            }
        }
    }
}
