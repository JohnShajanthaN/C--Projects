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
    public partial class FrmMisl : Form
    {
        //string PPP = "", CCC = "";
        //int count = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");
        private void Blank()
        {
            dtpMDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comDes.Text = "";
            comPur.Text = "";
            comCat.Text = "";
            comRem.Text = "";
            txtQty.Text = "";
            comUOM.Text = "";
            txtAmo.Text = "";
        }

        private void fromDGView()
        {
            comMID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpMDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comDes.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comPur.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comCat.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comRem.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtQty.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comUOM.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAmo.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }
        private void DGViewSize()
        {
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.Columns[9].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           // dataGridView1.Columns[3].HeaderText = " Unit";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Width = 100;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select MID from Misl where MID Like '%" + TxtSer.Text + "%' GROUP BY MID";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comMID.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comMID.Items.Add(dr["MID"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select DESCRIPTION from Misl where DESCRIPTION Like '%" + TxtSer.Text + "%' GROUP BY DESCRIPTION";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(dt2);
                comDes.Items.Clear();
                foreach (DataRow dr2 in dt2.Rows)
                {
                    comDes.Items.Add(dr2["DESCRIPTION"].ToString());
                }
                con.Close();

                con.Open();
                OleDbCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select UnitOfMeasure from Misl where UnitOfMeasure Like '%" + TxtSer.Text + "%' GROUP BY UnitOfMeasure";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(dt3);
                comUOM.Items.Clear();
                foreach (DataRow dr3 in dt3.Rows)
                {
                    comUOM.Items.Add(dr3["UnitOfMeasure"].ToString());
                }
                con.Close();    
                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-70-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public FrmMisl()
        {
            InitializeComponent();
        }

        private void FrmMisl_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into Misl(MID, MDate, DESCRIPTION, Purpose, Category, Remarks, Qty, UnitOfMeasure, Amount) values('"
                + comMID.Text + "', '" + dtpMDate.Value.ToString() + "', '" + comDes.Text + "', '" + comPur.Text + "', '" + comCat.Text + "', '" + comRem.Text + "', '" + txtQty.Text + "', '" + comUOM.Text + "', '" + txtAmo.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comMID.Text = "";
                Blank();
                comMID.Focus();
                TxtSer_TextChanged(null, null);
                ComList();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-95-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comMID.Text)
                {
                    OleDbCommand cmd = new OleDbCommand("Update Misl SET MID='" + comMID.Text + "', MDate='" + dtpMDate.Value.ToString() + "', DESCRIPTION='" + comDes.Text + "', Purpose='" + comPur.Text + "', Category='" + comCat.Text + "', Remarks='" + comRem.Text + "', Qty='" + txtQty.Text + "', UnitOfMeasure='" + comUOM.Text + "', Amount='" + txtAmo.Text
                    + "' WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comMID.Text = "";
                    Blank();
                    comMID.Focus();
                    TxtSer_TextChanged(null, null);
                    ComList();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Please Select the record(Index) on Grid List for Editing!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-115-JOB-ODR" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == comMID.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string txt = "DELETE FROM [Misl] Where [ID]=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                        OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comMID.Text = "";
                        Blank();
                        ComList();
                        comMID.Focus();
                        TxtSer_TextChanged(null, null);
                        ComList();
                    }
                    else
                    {
                        comMID.Focus();
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

        private void comMID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comMID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from Misl where MID='" + comMID.Text.Trim() + "' ", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            dtpMDate.Text = rdr["MDate"].ToString();
                            comDes.Text = rdr["DESCRIPTION"].ToString();
                            comPur.Text = rdr["Purpose"].ToString();
                            comCat.Text = rdr["Category"].ToString();
                            comRem.Text = rdr["Remarks"].ToString();
                            txtQty.Text = rdr["Qty"].ToString();
                            comUOM.Text = rdr["UnitOfMeasure"].ToString();
                            txtAmo.Text = rdr["Amount"].ToString();
                            temp = true;
                        }
                        con.Close();
                        comDes.Focus();
                        TxtSer.Text = "";
                        if (temp == false)
                        {
                            Blank();
                            comDes.Focus();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Misl] Where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Misl where MID Like '%" + TxtSer.Text + "%' or DESCRIPTION Like '%" + TxtSer.Text + "%'";
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

        private void comDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comUOM.Focus();
                }
            }
        }
    }
}
