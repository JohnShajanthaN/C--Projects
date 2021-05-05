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

namespace Dewmas_Job_Bank
{
    public partial class FrmStfSal : Form
    {
        int count;
        SqlConnection con = new SqlConnection(@"Data Source=AYNKARAN;Initial Catalog=Dewmas;Integrated Security=True");

        private void Blank()
        {
            comStfID.Text = "";
            txtStfNam.Text = "";
            txtBanNam.Text = "";
            txtBranchNam.Text = "";
            txtActNum.Text = "";
            txtBasSal.Text = "";
            comMon.Text = "";
            txtWrkDay.Text = "";
            txtTra.Text = "";
            txtPer.Text = "";
            txtVeh.Text = "";
            txtAdd.Text = "";
            txtPro.Text = "";
            txtMed.Text = "";
            txtAdd.Text = "";
            txtNoPay.Text = "";
            txtLatCom.Text = "";
            txtEPF8.Text = "";
            txtEPF12.Text = "";
            txtETF3.Text = "";
            txtGroSal.Text = "";
            txtTotDed.Text = "";
            txtNetSal.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void ComList()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select StfID from StfReg";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                comStfID.Items.Clear();                     //For Combo box List
                foreach (DataRow dr in dt.Rows)
                {
                    comStfID.Items.Add(dr["StfID"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-131-INV" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fromDGView()           
        {
            comStfID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comMon.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtWrkDay.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTra.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPer.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtVeh.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtAdd.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtPro.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtMed.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAtt.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtNoPay.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtLatCom.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtEPF8.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txtEPF12.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            txtETF3.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            txtGroSal.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            txtTotDed.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            txtNetSal.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
        }

        private void DGViewSize()
        {
            //dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);

            dataGridView1.Columns[0].HeaderText = "Staff ID";
            dataGridView1.Columns[1].HeaderText = "Working Days";
            dataGridView1.Columns[2].HeaderText = "Month";
            dataGridView1.Columns[10].HeaderText = "NoPay";
            dataGridView1.Columns[11].HeaderText = "Late Come";
            dataGridView1.Columns[15].HeaderText = "Gross Salary";
            dataGridView1.Columns[16].HeaderText = "Total Ded";
            dataGridView1.Columns[17].HeaderText = "Net Salary";


            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[10].Width = 150;
            dataGridView1.Columns[11].Width = 150;
            dataGridView1.Columns[17].Width = 150;
            dataGridView1.Columns[15].Width = 100;
            dataGridView1.Columns[16].Width = 150;
        
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;       
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;

        }
        public FrmStfSal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtWrkDay.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWrkDay.Text = txtWrkDay.Text.Remove(txtWrkDay.Text.Length - 1);
            }
        }

        private void FrmStfSal_Load(object sender, EventArgs e)
        {
            ComList();          
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from StfSal where StfID Like '%" + TxtSer.Text + "%' or WrkDay Like '%" + TxtSer.Text + "%' or GroSal Like '%" + TxtSer.Text + "%'  or TotDed Like '%" + TxtSer.Text + "%'  or NetSal Like '%" + TxtSer.Text + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //For Combo box List
                //comCSta.Items.Clear();
                comStfID.Items.Clear();
                comMon.Items.Clear();
                
                foreach (DataRow dr in dt.Rows)
                {                 
                    comStfID.Items.Add(dr["StfID"].ToString());
                    comMon.Items.Add(dr["Month"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : Txt-SER-196-EBI" + "\n" + "\n" + "[Please Note this Error Code, Take a Photo in this More Details and check the empty field." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStfNam_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comStfID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comStfID.Text=="")
            {
                MessageBox.Show("Choose The Staff ID!!","Staff Salary Details",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                    //txtStfNam.Text
                    //txtBanNam.Text
                    //txtBranchNam.Text
                    //txtActNum.Text
                    //txtBasSal.Text

                SqlCommand cmd1 = new SqlCommand("SELECT FName FROM StfReg WHERE StfID=comStfID.Text", con);
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();

                reader.Read();

                string ID = reader["StfID"].ToString().Substring(8, 3);
                int ID1 = Convert.ToInt32(ID);
                ID1++;
                comStfID.Text = "DEW-STA-" + ID1.ToString("000");

                con.Close();
                reader.Close();
            }
        }

    }
}
