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
    public partial class FrmLoan : Form
    {
        int count = 0;
        int found1 = 0;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
       
        private void Blank()
        {
            txtEmpName.Text = "";
            comPurpose.Text = "";
            txtBSal.Text = "";
            txtLoan.Text = "";
            dtpPFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpPTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtYears.Text = "";
            txtSAmount.Text = "";
            txtMPayment.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comPurpose.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBSal.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtLoan.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtpPFrom.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);
            dtpPTo.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value);
            txtYears.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtSAmount.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtMPayment.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = " EmpID";
            dataGridView1.Columns[1].HeaderText = " EmpName";
            dataGridView1.Columns[2].HeaderText = " Purpuse";
            dataGridView1.Columns[4].HeaderText = " Loan";
            dataGridView1.Columns[7].HeaderText = " Years";
            dataGridView1.Columns[9].HeaderText = " MonthlyPay";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[4].Width = 30;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[9].Width = 120;

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        public FrmLoan()
        {
            InitializeComponent();
        }

        private void FrmLoan_Load(object sender, EventArgs e)
        {
            TxtSer_TextChanged(null, null);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into LoanEntry values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + comPurpose.Text + "', '" + txtBSal.Text + "', '" + txtLoan.Text + "', '" + dtpPFrom.Value.ToString() + "', '" + dtpPTo.Value.ToString() + "', '" + txtYears.Text + "', '" + txtSAmount.Text + "', '" + txtMPayment.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
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
                cmd.CommandText = "select * from LoanEntry where EmpID Like '%" + TxtSer.Text + "%' or EmpName Like '%" + TxtSer.Text + "%' or Purpose Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                comPurpose.Items.Clear();
                //comManager.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    comPurpose.Items.Add(dr["Purpose"].ToString());
                   // comManager.Items.Add(dr["Manager"].ToString());
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
                string txt = "SELECT * FROM [LoanEntry] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

        private void comEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comEmpID.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == comEmpID.Text)
                            {
                                string txt = "SELECT * FROM [LoanEntry] Where EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                                SqlDataAdapter da = new SqlDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        txtEmpName.Focus();
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

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comPurpose.Focus();
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
                SqlCommand cmd = new SqlCommand("Update LoanEntry SET EmpID='" + comEmpID.Text + "', EmpName='" + txtEmpName.Text + "', Purpose='" + comPurpose.Text + "', BasicSalary='" + txtBSal.Text + "', LoanAmount='" + txtLoan.Text + "', PFrom='" + dtpPFrom.Value.ToString() + "', PTo='" + dtpPTo.Value.ToString() + "', Years='" + txtYears.Text + "', SAmount='" + txtSAmount.Text + "', MonthlyPayment='" + txtMPayment.Text
                    + "' WHERE EmpID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comEmpID.Text = "";
                Blank();
                comEmpID.Focus();
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
                    string txt = "DELETE FROM [LoanEntry] Where [EmpID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comEmpID.Text = "";
                    Blank();
                    comEmpID.Focus();
                }
                else
                {
                    comEmpID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-145-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmLoanRep FLoanrep = new FrmLoanRep();
            FLoanrep.Show();
        }
    }
}
