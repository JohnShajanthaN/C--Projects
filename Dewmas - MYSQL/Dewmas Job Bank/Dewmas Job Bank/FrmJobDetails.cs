using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dewmas_Job_Bank
{
    public partial class FrmJobDetails : Form
    {

        int count;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=Dewmas;Integrated Security=True");

        private void Blank()
        {
            comJobID.Text = "";
            comJobCat.Text = "";
            txtJobPos.Text = "";
            txtComNam.Text = "";
            txtComPla.Text = "";
            txtBas.Text = "";
            dtpJCD.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comVac.Text = "";
            txtReq.Text = "";
            comVacFro.Text = "";
            comJobSta.Text = "";
            TxtSer_TextChanged(null, null);

            if (count == 0)
            {
                comJobID.Text = "DEW-JOB-001";
                comJobCat.Focus();
            }

            else
            {
                SqlCommand cmd1 = new SqlCommand("SELECT TOP(1) JobID FROM JobDet ORDER BY 1 DESC", con);
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();

                reader.Read();

                string ID = reader["JobID"].ToString().Substring(8, 3);
                int ID1 = Convert.ToInt32(ID);
                ID1++;
                comJobID.Text = "DEW-JOB-" + ID1.ToString("000");
                comJobCat.Focus();

                con.Close();
                reader.Close();
            }

        }

        private void fromDGView()
        {
            comJobID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comJobCat.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtJobPos.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtComNam.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtComPla.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtBas.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comVac.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comVacFro.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtReq.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpJCD.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            comJobSta.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);          
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[2].HeaderText = "Position";
            dataGridView1.Columns[3].HeaderText = "Company Name";
            dataGridView1.Columns[4].HeaderText = "Company Place";
            dataGridView1.Columns[5].HeaderText = "Basic Salary";
            dataGridView1.Columns[6].HeaderText = "No Of Vac";
            dataGridView1.Columns[10].HeaderText = "Job Status";

            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[10].Width = 100;


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;       
        } 
        public FrmJobDetails()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmJobDetails_Load(object sender, EventArgs e)
        {
            Blank();
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from JobDet  where JobID Like '%" + TxtSer.Text + "%' or JobCat Like '%" + TxtSer.Text + "%' or JobPos Like '%" + TxtSer.Text + "%' or ComName Like '%" + TxtSer.Text + "%' or ComPlace Like '%" + TxtSer.Text + "%' or BasSal Like '%" + TxtSer.Text + "%' or Req Like '%" + TxtSer.Text + "%' or JobStatus Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                comJobCat.Focus();

                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : Txt-SER-196-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void comJobCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comJobCat.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtJobPos.Focus();
                }
            }
        }

        private void txtJobPos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtJobPos.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtComNam.Focus();
                }
            }
        }

        private void txtComNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtComNam.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtComPla.Focus();
                }
            }
        }

        private void txtComPla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtComPla.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtBas.Focus();
                }
            }
        }

        private void txtBas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBas.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpJCD.Focus();
                }
            }
        }

        private void dtpJCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtpJCD.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comVac.Focus();
                }
            }
        }

        private void comVac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comVac.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtReq.Focus();
                }
            }
        }

        private void txtReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtReq.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comVacFro.Focus();
                }
            }
        }

        private void comVacFro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comVacFro.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comJobSta.Focus();
                }
            }
        }

        private void txtBas_TextChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBas.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBas.Text = txtBas.Text.Remove(txtBas.Text.Length - 1);
            }
            */
           
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {  
                SqlCommand cmd = new SqlCommand("Insert into JobDet values ('"
                    + comJobID.Text + "', '" + comJobCat.Text + "', '" + txtJobPos.Text + "', '" + txtComNam.Text + "', '" + txtComPla.Text + "', '" + txtBas.Text + "', '" + comVac.Text + "', '" + comVacFro.Text + "', '" + txtReq.Text + "', '" + dtpJCD.Value.ToString() + "' ,'" + comJobSta.Text + "')", con); 
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Added Successfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comJobID.Text = "";
                Blank();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-ADD-158-EBI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            try
            {            
                SqlCommand cmd = new SqlCommand("Update JobDet SET JobID='" + comJobID.Text + "', JobCat='" + comJobCat.Text + "', JobPos='" + txtJobPos.Text + "', ComName='" + txtComNam.Text + "', ComPlace='" + txtComPla.Text + "', BasSal='" + txtBas.Text + "', NoVac='" + comVac.Text + "', VacFrom='" + comVacFro.Text + "', Req='" + txtReq.Text + "', JobCredate='" + dtpJCD.Text + "',JobStatus='" + comJobSta.Text + "' WHERE JobID='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);               
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comJobID.Text = "";
                Blank();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-305-EBI" + "\n" + "\n" + "[Please check blank textboxes, check the number value on phone numbers, " + "\n" + "\n" + " check profile photo and Note this Error Code and Take a Photo or Screenshot in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [JobDet] Where [JobID]='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comJobID.Text = "";
                    Blank();
                }
                else
                {
                    comJobCat.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-130-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRep_Click(object sender, EventArgs e)
        {
            FrmJobDetRep JDR = new FrmJobDetRep();
            JDR.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            Blank();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {             
                string txt = "SELECT * FROM [JobDet] Where JobID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

        private void comVac_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBas.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBas.Text = txtBas.Text.Remove(txtBas.Text.Length - 1);
            }
            */
            
        }

        private void comJobSta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comJobSta.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdAdd.Focus();
                }
            }
        }
    }
}
