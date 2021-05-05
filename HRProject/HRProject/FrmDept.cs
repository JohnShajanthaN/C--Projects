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
using System.Data.SqlClient;

namespace HRProject
{
    public partial class FrmDept : Form
    {
        int count = 0;
        int found1 = 0;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtDeptName.Text = "";
            txtDeptFunctions.Text = "";
            txtNOS.Text = "";
            comSupervisor.Text = "";
            comManager.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            txtDeptID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtDeptName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDeptFunctions.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtNOS.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comSupervisor.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comManager.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = " ID";
            dataGridView1.Columns[1].HeaderText = " Department";
            dataGridView1.Columns[2].HeaderText = " Functions";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 30;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 120;

            //dataGridView1.Columns[2].Visible = false;
        }

        public FrmDept()
        {
            InitializeComponent();
        }

        private void FrmDept_Load(object sender, EventArgs e)
        {
            TxtSer_TextChanged(null, null);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Dept values('"
                    + txtDeptID.Text + "', '" + txtDeptName.Text + "', '" + txtDeptFunctions.Text + "', '" + txtNOS.Text + "', '" + comSupervisor.Text + "', '" + comManager.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeptID.Text = "";
                Blank();
                txtDeptID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-98-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Dept where DeptID Like '%" + TxtSer.Text + "%' or DeptName Like '%" + TxtSer.Text + "%' or Supervisor Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                 comSupervisor.Items.Clear();
                 comManager.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comSupervisor.Items.Add(dr["Supervisor"].ToString());
                    comManager.Items.Add(dr["Manager"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-196-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Dept] Where DeptID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-161-ACC-PAY" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDeptID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtDeptID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == txtDeptID.Text)
                            {
                                string txt = "SELECT * FROM [Dept] Where DeptID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        txtDeptName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : BCD-KDW-236-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDeptName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDeptName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtDeptFunctions.Focus();
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Dept SET DeptID='" + txtDeptID.Text + "', DeptName='" + txtDeptName.Text + "', DeptFunctions='" + txtDeptFunctions.Text + "', NOS='" + txtNOS.Text + "', Supervisor='" + comSupervisor.Text + "', Manager='" + comManager.Text
                    + "' WHERE DeptID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeptID.Text = "";
                Blank();
                txtDeptID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-118-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Dept] Where [DeptID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeptID.Text = "";
                    Blank();
                    txtDeptID.Focus();
                }
                else
                {
                    txtDeptID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-145-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmDeptRep FDeptRep = new FrmDeptRep();
            FDeptRep.Show();
        }
    }
}
