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
    public partial class FrmPayVoucher : Form
    {
        public static string PVNO = "", PVDate = "", SupID = "", Sup = "", Amount = "";
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            dtpPVDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comPayMethord.Text = "";
           // comChqno.Text = "";
            comSupID.Text = "";
            comSup.Text = "";            
            comDes.Text = "";
            comRefNo.Text = "";
            txtAmount.Text = "";
        }

        private void fromDGView()
        {
            comPVNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpPVDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comPayMethord.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           // comChqno.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comSupID.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comSup.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();            
            comDes.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comRefNo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAmount.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Width = 304;
            dataGridView1.Columns[7].Width = 165;
            dataGridView1.Columns[8].Width = 95;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select PVNO from Voucher where PVNO Like '%" + TxtSer.Text + "%' GROUP BY PVNO";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comPVNo.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comPVNo.Items.Add(dr["PVNO"].ToString());
                }
                con.Close();

                //con.Open();
                //OleDbCommand cmd2 = con.CreateCommand();
                //cmd2.CommandType = CommandType.Text;
                //cmd2.CommandText = "select ChqNo from Voucher where ChqNo Like '%" + TxtSer.Text + "%' GROUP BY ChqNo";
                //cmd2.ExecuteNonQuery();
                //DataTable dt2 = new DataTable();
                //OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                //da2.Fill(dt2);
                //comChqno.Items.Clear();
                //foreach (DataRow dr in dt2.Rows)
                //{
                //    comChqno.Items.Add(dr["ChqNo"].ToString());
                //}
                //con.Close();

                con.Open();
                OleDbCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select SupplierCode from Supplier where SupplierCode Like '%" + TxtSer.Text + "%' GROUP BY SupplierCode";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(dt3);
                comSupID.Items.Clear();
                foreach (DataRow dr in dt3.Rows)
                {
                    comSupID.Items.Add(dr["SupplierCode"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select SupplierName from Supplier where SupplierName Like '%" + TxtSer.Text + "%' GROUP BY SupplierName";
                cmd4.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
                da4.Fill(dt4);
                comSup.Items.Clear();
                foreach (DataRow dr in dt4.Rows)
                {
                    comSup.Items.Add(dr["SupplierName"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select Des from Voucher where Des Like '%" + TxtSer.Text + "%' GROUP BY Des";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                da5.Fill(dt5);
                comDes.Items.Clear();
                foreach (DataRow dr in dt5.Rows)
                {
                    comDes.Items.Add(dr["Des"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "select RefNo from Voucher where RefNo Like '%" + TxtSer.Text + "%' GROUP BY RefNo";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
                da6.Fill(dt6);
                comRefNo.Items.Clear();
                foreach (DataRow dr in dt6.Rows)
                {
                    comRefNo.Items.Add(dr["RefNo"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmPayVoucher()
        {
            InitializeComponent();
        }

        private void FrmPayVoucher_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into Voucher(PVNO, PVDate, Methord, SupID, Sup, Des, RefNo, Amount) values('"
                + comPVNo.Text + "', '" + dtpPVDate.Value.ToString() + "', '" + comPayMethord.Text + "', '" + comSupID.Text + "', '" + comSup.Text + "', '" + comDes.Text + "', '" + comRefNo.Text + "', '" + txtAmount.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comPVNo.Text = "";
                Blank();
                comPVNo.Focus();
                //TxtSer.Text = comPONo.Text;
                TxtSer_TextChanged(null, null);
                ComList();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void comPVNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comPVNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Voucher where PVNO='" + comPVNo.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            dtpPVDate.Text = rdr["PVDate"].ToString(); 
                            comPayMethord.Text = rdr["Methord"].ToString();
                           // comChqno.Text = rdr["ChqNo"].ToString();
                            comSupID.Text = rdr["SupID"].ToString();
                            comSup.Text = rdr["Sup"].ToString();
                            comDes.Text = rdr["Des"].ToString();
                            comRefNo.Text = rdr["RefNo"].ToString();
                            txtAmount.Text = rdr["Amount"].ToString();
                            temp = true;
                        }
                        con.Close();
                        comDes.Focus();
                        TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            dtpPVDate.Focus();
                        }
                        con.Close();
                        TxtSer.Text = comPVNo.Text;
                        TxtSer_TextChanged(null, null);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpPVDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comSupID.Focus();
            }
        }

        private void comSupID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comSupID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Supplier where SupplierCode=" + comSupID.Text.ToString() + " ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            comSup.Text = rdr["SupplierName"].ToString();
                            temp = true;
                        }
                        con.Close();
                        comPayMethord.Focus();
                        //TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            //  comStNo.Focus();
                        }
                        con.Close();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comSup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comSup.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Supplier where SupplierName='" + comSup.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            comSupID.Text = rdr["SupplierCode"].ToString();
                            temp = true;
                        }
                        con.Close();
                        comPayMethord.Focus();
                        //TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            //  comStNo.Focus();
                        }
                        con.Close();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comDes.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //con.Open();
                        //OleDbCommand cmd1 = new OleDbCommand("select * from Voucher where Des='" + comDes.Text.Trim() + "' ", con);
                        //cmd1.Connection = con;
                        //rdr = cmd1.ExecuteReader();
                        //bool temp = false;
                        //while (rdr.Read())
                        //{
                        //    comRefNo.Text = rdr["RefNo"].ToString();
                        //    txtAmount.Text = rdr["Amount"].ToString();
                        //    temp = true;
                        //}
                        //con.Close();
                        //CmdSave.Focus();
                        ////TxtSer.Text = "";
                        //if (temp == false)
                        //{
                        //   // Blank();
                        //      comRefNo.Focus();
                        //    txtAmount.Text = FrmChqPayment.Amount1;
                        //}
                        //con.Close();

                        comRefNo.Focus();
                        txtAmount.Text = FrmChqPayment.Amount1.ToString();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comRefNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comRefNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //con.Open();
                        //OleDbCommand cmd1 = new OleDbCommand("select * from Voucher where RefNo='" + comRefNo.Text.Trim() + "' ", con);
                        //cmd1.Connection = con;
                        //rdr = cmd1.ExecuteReader();
                        //bool temp = false;
                        //while (rdr.Read())
                        //{
                        //    comDes.Text = rdr["Des"].ToString();
                        //    txtAmount.Text = rdr["Amount"].ToString();
                        //    temp = true;
                        //}
                        //con.Close();
                        //CmdSave.Focus();
                        ////TxtSer.Text = "";
                        //if (temp == false)
                        //{
                        //   // Blank();
                        //    txtAmount.Focus();
                        //}
                        //con.Close();
                        txtAmount.Focus();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmount.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void comPayMethord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPayMethord.Text == "Cheque")
                {
                    PVNO = comPVNo.Text.ToString();
                    PVDate = dtpPVDate.Text.ToString();
                    SupID = comSupID.Text.ToString();
                    Sup =   comSup.Text.ToString();
                    Amount = txtAmount.Text.ToString();
                    FrmChqPayment FChqPayment = new FrmChqPayment();
                    comDes.Focus();
                    FChqPayment.Show();
                }
                else
                {
                    comDes.Focus();
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
                        string txt = "DELETE FROM [Voucher] Where [ID]=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                        OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comPVNo.Text = "";
                        Blank();
                        ComList();
                        comPVNo.Focus();
                        TxtSer_TextChanged(null, null);
                        ComList();
                    }
                    else
                    {
                        comPVNo.Focus();
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

        private void CmdComplete_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("Insert into Outstanding(GRNPVNo, GRNPVDate, SCode, Sup, Des, Amount) values('"
                + comPVNo.Text + "', '" + dtpPVDate.Value.ToString() + "', '" + comSupID.Text + "', '" + comSup.Text + "', '" + "Purchase Payment" + "', '" + (Convert.ToDouble(txtAmount.Text)*(-1)).ToString() + "')", con);
            // cmd.CommandText = "select PurchaseGRN.PONO, PurchaseGRN.GRNNo, PurchaseGRN.GRNDate, PurchaseGRN.SupplierCode, PurchaseGRN.Supplier, PurchaseGRN.StockNumber,  PurchaseGRN.Description, PurchaseGRN.Weight, PurchaseGRN.RvdQty, PurchaseGRN.Unit, Purchase.CostPrice, (Purchase.CostPrice*PurchaseGRN.RvdQty) As Payable from PurchaseGRN INNER JOIN Purchase ON PurchaseGRN.PONO=Purchase.PONO;";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Blank();
            comPVNo.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
            comPVNo.Focus();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Voucher where PVNO Like '%" + TxtSer.Text + "%' or SupID Like '%" + TxtSer.Text + "%' or Sup Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or RefNo Like '%" + TxtSer.Text + "%'";
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
                MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Voucher] Where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Refresh();
            TxtSer_TextChanged(null, null);
            ComList();
            //Blank();
           // comChqno.Refresh();
            Refresh();
            this.Refresh();
        }
    }
}
