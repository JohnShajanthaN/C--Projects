using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsERP
{
    public partial class FrmChqPayment : Form
    {
        public static double Amount1 = 0.00;
        public static string uname = "";
        public static string ul = "";
        string PPP = "";
        // int count = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            dtpCDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comChqNo.Text = "";
            comBank.Text = "";
            comBranch.Text = "";
            comAccNo.Text = "";
            txtAmount.Text = "0.00";
        }

        private void fromDGView()
        {
            comPVNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpPVDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comSupID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comSup.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtpCDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comChqNo.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comBank.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comBranch.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comAccNo.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtAmount.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[10].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].Width = 54;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Width = 350;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Width = 100;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select Bank from VoucherChequePayment where Bank Like '%" + TxtSer.Text + "%' GROUP BY Bank";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comBank.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comBank.Items.Add(dr["Bank"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select Branch from VoucherChequePayment where Branch Like '%" + TxtSer.Text + "%' GROUP BY Branch";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(dt2);
                comBranch.Items.Clear();
                foreach (DataRow dr in dt2.Rows)
                {
                    comBranch.Items.Add(dr["Branch"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select AccNo from VoucherChequePayment where AccNo Like '%" + TxtSer.Text + "%' GROUP BY AccNo";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(dt3);
                comAccNo.Items.Clear();
                foreach (DataRow dr in dt3.Rows)
                {
                    comAccNo.Items.Add(dr["AccNo"].ToString());
                }
                con.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmChqPayment()
        {
            InitializeComponent();
        }

        private void FrmChqPayment_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();

            comPVNo.Text = FrmPayVoucher.PVNO;
            dtpPVDate.Text = FrmPayVoucher.PVDate;
            comSupID.Text = FrmPayVoucher.SupID;
            comSup.Text = FrmPayVoucher.Sup;
            txtAmount.Text = FrmPayVoucher.Amount;
            dtpCDate.Focus();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into VoucherChequePayment(PVNo, PVDate, SupID, Sup, CDate, ChqNo, Bank, Branch, AccNo, Amount) values('"
                + comPVNo.Text + "', '" + dtpPVDate.Value.ToString() + "', '" + comSupID.Text + "', '" + comSup.Text + "', '" + dtpCDate.Value.ToString() + "', '" + comChqNo.Text + "', '" + comBank.Text + "', '" + comBranch.Text + "', '" + comAccNo.Text + "', '" + txtAmount.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //comPONo.Text = "";
                PPP = TxtSer.Text;
                TxtSer.Text = "";
                Amount1 = Amount1 + Convert.ToDouble(txtAmount.Text);
                Blank();
                dtpCDate.Focus();
                //TxtSer.Text = comPONo.Text;
                TxtSer_TextChanged(null, null);
                ComList();
                TxtSer.Text = PPP;
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comChqNo.Focus();
            }
        }

        private void comChqNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comChqNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from VoucherChequePayment where ChqNo='" + comChqNo.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            dtpCDate.Text = rdr["CDate"].ToString();
                            comBank.Text = rdr["Bank"].ToString();
                            comBranch.Text = rdr["Branch"].ToString();
                            comAccNo.Text = rdr["AccNo"].ToString();
                            txtAmount.Text = rdr["Amount"].ToString();
                            temp = true;
                        }
                        con.Close();
                        comBank.Focus();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comBank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comBank.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comBranch.Focus();
                }
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comPVNo.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string txt = "DELETE FROM [VoucherChequePayment] Where [ID]=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                        OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // comPONo.Text = "";
                        PPP = TxtSer.Text;
                        TxtSer.Text = "";
                        Blank();
                        ComList();
                        dtpCDate.Focus();
                        TxtSer_TextChanged(null, null);
                        ComList();
                        TxtSer.Text = PPP;
                    }
                    else
                    {
                        dtpCDate.Focus();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Please Select the record(Index) from Grid List for Deleting!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-150-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Blank();
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
            dtpCDate.Focus();
            ComList();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from VoucherChequePayment where ChqNo Like '%" + TxtSer.Text + "%' or AccNo Like '%" + TxtSer.Text + "%' or Sup Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                // count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [VoucherChequePayment] Where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-166-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            // TxtSer_TextChanged(null, null);
            //ComList();
            //Refresh();
            //this.Refresh();
        }

        private void CmdComplete_Click(object sender, EventArgs e)
        {
           // Amount1 = txtAmount.Text.ToString();
            Close();
            this.Visible = false;
        }
    }
}
