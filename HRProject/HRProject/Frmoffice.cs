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
    public partial class Frmoffice : Form
    {
        int count = 0;
        int found1 = 0;
        SqlDataReader rdr;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=DatabaseHR;Integrated Security=True");
        private void Blank()
        {
            txtEmpName.Text = "";
            comEmpID.Text = "";
            comDepa.Text = "";
            comShift.Text = "";
            TxtSer.Text = "";    
        }

        private void fromDGView()
        {
            comEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comDepa.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comShift.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();  
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            //dataGridView1.Columns[0].HeaderText = " ID";
            //dataGridView1.Columns[1].HeaderText = " Name";
            dataGridView1.Columns[0].HeaderText = "Employee ID";
            dataGridView1.Columns[1].HeaderText = "Employee Name";
            dataGridView1.Columns[2].HeaderText = "Department";
            dataGridView1.Columns[3].HeaderText = "Shift";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 110;

        }

        private void ComList()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from EmpBasic where EmpID Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                comEmpID.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt.Rows)
                {
                    comEmpID.Items.Add(dr["EmpID"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-131-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Frmoffice()
        {
            InitializeComponent();
        }

        private void Frmoffice_Load(object sender, EventArgs e)
        {
            ComList();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Insert into OfficeUse values('"
                    + comEmpID.Text + "', '" + txtEmpName.Text + "', '" + comDepa.Text + "', '" + comShift.Text + "')", con);
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
                MessageBox.Show("ERROR CODE : CMD-SAV-116-BNK" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frmoffice_Load_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
