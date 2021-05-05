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
    public partial class FrmPurchaseOrder : Form
    {
        public static string uname = "";
        public static string ul = "";
        string PPP = "";
        int count = 0;
        //int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            comStNo.Text = "";            
            comDes.Text = "";
            comUnit.Text = "";
            txtUCost.Text = "0.00";
            txtOQty.Text = "";
            txtWeight.Text = "";
            txtIValue.Text = "0.00";
        }

        private void fromDGView()
        {
            comPONo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpPODate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comSupID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comSup.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comStNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comDes.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comUnit.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtUCost.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtOQty.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();            
            txtIValue.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();            
            txtPOValue.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[11].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].Width = 44;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Width = 240;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Width = 95;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
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
                
                foreach (DataRow dr in dt6.Rows)
                {
                    comUnit.Items.Add(dr["UOMes"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void FrmPurchaseOrder_Load(object sender, EventArgs e)
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
                OleDbCommand cmd = new OleDbCommand("Insert into Purchase(PONO, PODate, SupplierCode, Supplier, StockNumber, Description, Unit, CostPrice, Weight, OrderQty, ItemValue, POValue) values('"
                + comPONo.Text + "', '" + dtpPODate.Value.ToString() + "', '" + comSupID.Text + "', '" + comSup.Text + "', '" + comStNo.Text + "', '" + comDes.Text + "', '" + comUnit.Text + "', '" + txtUCost.Text + "', '" + txtWeight.Text + "', '" + txtOQty.Text + "', '" + txtIValue.Text + "', '" + txtPOValue.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //comPONo.Text = "";
                PPP = TxtSer.Text;
                TxtSer.Text = "";
                Blank();
                comStNo.Focus();
                //TxtSer.Text = comPONo.Text;
                TxtSer_TextChanged(null, null);
                ComList();
                TxtSer.Text= PPP;
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
                            dtpPODate.Text = rdr["PODate"].ToString();
                            comSupID.Text = rdr["SupplierCode"].ToString();
                            comSup.Text = rdr["Supplier"].ToString();
                            temp = true;
                        }
                        con.Close();
                        comStNo.Focus();
                        TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            ComList();
                            dtpPODate.Focus();
                        }
                        con.Close();
                        TxtSer.Text = comPONo.Text;
                        TxtSer_TextChanged(null, null);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : JONO-KDW-235-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpPODate_KeyDown(object sender, KeyEventArgs e)
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
                        comStNo.Focus();
                        //TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            ComList();
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
                        comStNo.Focus();
                        //TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            ComList();
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

        private void comStNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comStNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Item where StNo='" + comStNo.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            comDes.Text = rdr["Des"].ToString();
                            comUnit.Text = rdr["UOMes"].ToString();
                            txtUCost.Text = rdr["CashPrice"].ToString();
                            txtWeight.Text = rdr["PPWt"].ToString();
                            temp = true;
                        }
                        con.Close();
                        txtWeight.Focus();
                        //TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            ComList();
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
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Item where Des='" + comDes.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            comStNo.Text = rdr["StNo"].ToString();
                            comUnit.Text = rdr["UOMes"].ToString();
                            txtUCost.Text = rdr["CashPrice"].ToString();
                            txtWeight.Text = rdr["PPWt"].ToString();
                            temp = true;
                        }
                        con.Close();
                        txtWeight.Focus();
                        //TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            ComList();
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

        private void comUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comUnit.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtUCost.Focus();
                }
            }
        }

        private void txtUCost_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtIValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIValue.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //double qq = 0.00, pp = 0.00, rr = 0.00;
                    //qq = Convert.ToDouble(txtOQty.Text);
                    //pp = Convert.ToDouble(txtIValue.Text);
                    //rr = pp * qq;
                    //pp = Convert.ToDouble(txtIValue.Text);
                    txtPOValue.Text = (Convert.ToDouble(txtPOValue.Text) + Convert.ToDouble(txtIValue.Text)).ToString();//rr.ToString("#,###.00");
                    //txtIValue.Text = pp.ToString("#,###.00");
                    CmdSave.Focus();
                }
            }
        }

        private void txtPOValue_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comPONo.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string txt = "DELETE FROM [Purchase] Where [ID]=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                        OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // comPONo.Text = "";
                        PPP = TxtSer.Text;
                        TxtSer.Text = "";
                        Blank();
                        ComList();
                        comPONo.Focus();
                        TxtSer_TextChanged(null, null);
                        ComList();
                        TxtSer.Text = PPP;
                    }
                    else
                    {
                        comPONo.Focus();
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
            comStNo.Text = "";
            comPONo.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
            comPONo.Focus();
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
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Purchase where PONO Like '%" + TxtSer.Text + "%' or SupplierCode Like '%" + TxtSer.Text + "%' or StockNumber Like '%" + TxtSer.Text + "%'";
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
                string txt = "SELECT * FROM [Purchase] Where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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
            //TxtSer_TextChanged(null, null);
            //ComList();
            //Refresh();
            //this.Refresh();
        }

        private void txtOQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //try
                //{
                    if (comStNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtIValue.Text = (Convert.ToDouble(txtOQty.Text)* Convert.ToDouble(txtUCost.Text)).ToString();
                    }
                //}
            }
        }

    }
}
