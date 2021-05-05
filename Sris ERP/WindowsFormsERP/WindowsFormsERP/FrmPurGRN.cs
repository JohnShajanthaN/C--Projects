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
    public partial class FrmPurGRN : Form
    {
        public static string uname = "";
        public static string ul = "";
        string PPP = "";
        double UPrice = 0.00, GRNAmount= 0.00;
        int count = 0;
        //int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            //dtpGRNDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //comSupID.Text = "";
            //comSup.Text = "";
            //comStNo.Text = "";
            comDes.Text = "";
            comUnit.Text = "";
            txtPOQty.Text = "";
            txtRvdQty.Text = "";
            txtWeight.Text = "";
            comLOC.Text = "";
        }

        private void fromDGView()
        {
            comPONo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comGRNNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dtpGRNDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comSupID.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comSup.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comStNo.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comDes.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comUnit.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtPOQty.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtRvdQty.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();            
            comLOC.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void fromDGView2()
        {
            comPONo.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comSupID.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            comSup.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            comStNo.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            comDes.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            comUnit.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            txtWeight.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
            txtPOQty.Text = dataGridView2.SelectedRows[0].Cells[10].Value.ToString();
           // txtRvdQty.Text = dataGridView2.SelectedRows[0].Cells[10].Value.ToString();
           // comLOC.Text = dataGridView2.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[6].HeaderText = " StNo";
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
          //  dataGridView1.Columns[11].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Width = 64;
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 65;
            dataGridView1.Columns[10].Width = 65;
            dataGridView1.Columns[11].Width = 65;
            dataGridView1.Columns[12].Width = 120;
            //dataGridView1.Columns[13].Visible = false;
            //dataGridView1.Columns[14].Visible = false;
            //dataGridView1.Columns[15].Visible = false;
            //dataGridView1.Columns[16].Visible = false;
        }

        private void DGViewSize2()
        {
            dataGridView2.Columns[5].HeaderText = " StNo";
            dataGridView2.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //   dataGridView2.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView2.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Width = 70;
            dataGridView2.Columns[6].Width = 200;
            dataGridView2.Columns[7].Width = 50;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Width = 80;
            dataGridView2.Columns[10].Width = 80;
            dataGridView2.Columns[11].Visible = false;
            dataGridView2.Columns[12].Visible = false;
            dataGridView2.Columns[13].Visible = false;
            dataGridView2.Columns[14].Visible = false;
            dataGridView2.Columns[15].Visible = false;
            dataGridView2.Columns[16].Visible = false;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select PONO from Purchase where PONO Like '%" + TxtSer.Text + "%' GROUP BY PONO";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comPONo.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comPONo.Items.Add(dr["PONO"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select SupplierCode from Supplier where SupplierCode Like '%" + TxtSer.Text + "%' GROUP BY SupplierCode";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(dt2);
                comSupID.Items.Clear();
                foreach (DataRow dr in dt2.Rows)
                {
                    comSupID.Items.Add(dr["SupplierCode"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select SupplierName from Supplier where SupplierName Like '%" + TxtSer.Text + "%' GROUP BY SupplierName";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(dt3);
                comSup.Items.Clear();
                foreach (DataRow dr in dt3.Rows)
                {
                    comSup.Items.Add(dr["SupplierName"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select StNo from Item where StNo Like '%" + TxtSer.Text + "%' GROUP BY StNo";
                cmd4.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
                da4.Fill(dt4);
                comStNo.Items.Clear();
                foreach (DataRow dr in dt4.Rows)
                {
                    comStNo.Items.Add(dr["StNo"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select Des from Item where Des Like '%" + TxtSer.Text + "%' GROUP BY Des";
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
                cmd6.CommandText = "select UOMes from Item where UOMes Like '%" + TxtSer.Text + "%' GROUP BY UOMes";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
                da6.Fill(dt6);
                comUnit.Items.Clear();
                foreach (DataRow dr in dt6.Rows)
                {
                    comUnit.Items.Add(dr["UOMes"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd7 = con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "select LocationName from Location where LocationName Like '%" + TxtSer.Text + "%' GROUP BY LocationName";
                cmd7.ExecuteNonQuery();
                DataTable dt7 = new DataTable();
                OleDbDataAdapter da7 = new OleDbDataAdapter(cmd7);
                da7.Fill(dt7);
                comLOC.Items.Clear();
                foreach (DataRow dr in dt7.Rows)
                {
                    comLOC.Items.Add(dr["LocationName"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd8 = con.CreateCommand();
                cmd8.CommandType = CommandType.Text;
                cmd8.CommandText = "select GRNNo from PurchaseGRN where GRNNo Like '%" + TxtSer.Text + "%' GROUP BY GRNNo";
                cmd8.ExecuteNonQuery();
                DataTable dt8 = new DataTable();
                OleDbDataAdapter da8 = new OleDbDataAdapter(cmd8);
                da8.Fill(dt8);
                comGRNNo.Items.Clear();
                foreach (DataRow dr in dt8.Rows)
                {
                    comGRNNo.Items.Add(dr["GRNNo"].ToString());
                }
                con.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public FrmPurGRN()
        {
            InitializeComponent();
        }

        private void FrmPurGRN_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            txtSer2_TextChanged(null, null);
            ComList();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {

        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {

        }

        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into PurchaseGRN(PONO, GRNNo, GRNDate, SupplierCode, Supplier, StockNumber, Description, Unit, Weight, POQty, RvdQty, LOC) values('"
                + comPONo.Text + "', '" + comGRNNo.Text + "', '" + dtpGRNDate.Value.ToString() + "', '" + comSupID.Text + "', '" + comSup.Text + "', '" + comStNo.Text + "', '" + comDes.Text + "', '" + comUnit.Text + "', '" + txtWeight.Text + "', '" + txtPOQty.Text + "', '" + txtRvdQty.Text + "', '" + comLOC.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PPP = TxtSer.Text;
                TxtSer.Text = "";
                //comPONo.Text = "";
                //comGRNNo.Text = "";
                GRNAmount = Convert.ToDouble(GRNAmount) + Convert.ToDouble(UPrice) * Convert.ToDouble(txtRvdQty.Text);
                Blank();
                comPONo.Focus();
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
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void comPONo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comPONo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Purchase where PONO='" + comPONo.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                         //   dtpGRNDate.Text = rdr["PODate"].ToString();
                            comSupID.Text = rdr["SupplierCode"].ToString();
                            comSup.Text = rdr["Supplier"].ToString();
                            UPrice = Convert.ToDouble(rdr["CostPrice"]);
                            //GRNAmount = 
                            temp = true;
                        }
                        con.Close();
                        comGRNNo.Focus();
                        txtSer2.Text = "";
                        TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                         //   dtpGRNDate.Focus();
                        }
                        con.Close();
                       
                        PPP = TxtSer.Text;
                        TxtSer.Text = "";
                        txtSer2.Text = comPONo.Text;
                        txtSer2_TextChanged(null, null);
                        TxtSer.Text = comPONo.Text;
                        TxtSer_TextChanged(null, null);
                        ComList();
                        TxtSer.Text = PPP;
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comGRNNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comGRNNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //con.Open();
                        //OleDbCommand cmd1 = new OleDbCommand("select * from PurchaseGRN where GRNNo='" + comGRNNo.Text.Trim() + "' ", con);
                        //cmd1.Connection = con;
                        //rdr = cmd1.ExecuteReader();
                        //bool temp = false;
                        //while (rdr.Read())
                        //{
                        //    comPONo.Text = rdr["PONO"].ToString();
                        //    dtpGRNDate.Text = rdr["PODate"].ToString();
                        //    comSupID.Text = rdr["SupplierCode"].ToString();
                        //    comSup.Text = rdr["Supplier"].ToString();
                        //    temp = true;
                        //}
                        //con.Close();
                        //dataGridView2.Focus();
                        //TxtSer.Text = "";
                        ////if (temp == false)
                        ////{
                        ////    Blank();
                        ////   // dtpGRNDate.Focus();
                        ////}
                        //con.Close();
                        //TxtSer.Text = comGRNNo.Text;
                        //TxtSer_TextChanged(null, null);
                        dtpGRNDate.Focus();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpGRNDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comSupID.Focus();
            }
        }

        private void comStNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtRvdQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRvdQty.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comLOC.Focus();
                }
            }
        }

        private void comLOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comLOC.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void CmdDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comPONo.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string txt = "DELETE FROM [PurchaseGRN] Where [ID]=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                        OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comPONo.Text = "";
                        comGRNNo.Text = "";
                        Blank();
                        ComList();
                        comStNo.Focus();
                        TxtSer_TextChanged(null, null);
                        ComList();
                    }
                    else
                    {
                        comStNo.Focus();
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
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into Outstanding(GRNPVNo, GRNPVDate, SCode, Sup, Des, Amount) values('"
                + comGRNNo.Text + "', '" + dtpGRNDate.Value.ToString("dd/MM/yyyy") + "', '" + comSupID.Text + "', '" + comSup.Text + "', '" + "Purchase" + "', '" + GRNAmount + "')", con);
               // cmd.CommandText = "select PurchaseGRN.PONO, PurchaseGRN.GRNNo, PurchaseGRN.GRNDate, PurchaseGRN.SupplierCode, PurchaseGRN.Supplier, PurchaseGRN.StockNumber,  PurchaseGRN.Description, PurchaseGRN.Weight, PurchaseGRN.RvdQty, PurchaseGRN.Unit, Purchase.CostPrice, (Purchase.CostPrice*PurchaseGRN.RvdQty) As Payable from PurchaseGRN INNER JOIN Purchase ON PurchaseGRN.PONO=Purchase.PONO;";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //comPONo.Text = "";
                //comGRNNo.Text = "";
                //Blank();
                //comPONo.Focus();
                ////TxtSer.Text = comPONo.Text;
                //TxtSer_TextChanged(null, null);
                //ComList();
            

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
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Blank();
            comStNo.Text = "";
            comPONo.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
            txtSer2.Text = "";
            txtSer2_TextChanged(null, null);
            comPONo.Focus();
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
                cmd.CommandText = "select * from PurchaseGRN where PONO Like '%" + TxtSer.Text + "%'";
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
                string txt = "SELECT * FROM [PurchaseGRN] Where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void txtSer2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Purchase where PONO='"  + txtSer2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView2.DataSource = dt;
                DGViewSize2();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-195-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Purchase] Where ID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView2();                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-166-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            TxtSer.Text = "";
            txtSer2.Text = "";
            ComList();
            TxtSer_TextChanged(null, null);
            txtSer2_TextChanged(null, null);
            Refresh();
            this.Refresh();
            ComList();
            Refresh();
            this.Refresh();
        }

        private void comSupID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView2_CellClick(null, null);
                txtRvdQty.Focus();
            }      
            else
            {
               // dataGridView2_CellClick(null, null);
            }
        }
    }
}
