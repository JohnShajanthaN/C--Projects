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
    public partial class FrmItem : Form
    {
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");

        private void Blank()
        {
            txtDes.Text = "";
            comKW.Text = "";
            comGr.Text = "";
            txtSNum.Text = "";
            txtPNum.Text = "";
            txtCPC.Text = "";
            txtCPMn.Text = "";
            txtMPYs.Text = "";
            txtMPTs.Text = "";
            txtMPEI.Text = "";
            txtPPWt.Text = "";
            txtPPWidth.Text = "";
            txtPPThick.Text = "";
            comUOMes.Text = "";
            comGrade.Text = "";
            comModel.Text = "";
            comManu.Text = "";
            dtpDoMFR.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpDOE.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtMin.Text = "";
            txtMax.Text = "";
            txtROL.Text = "";
            picImg.Image = Image.FromFile("Photo.jpg");//null;
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {          
            txtStNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDes.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comKW.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comGr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtSNum.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPNum.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCPC.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtCPMn.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtMPYs.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtMPTs.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtMPEI.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtPPWt.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txtPPWidth.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            txtPPThick.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            comUOMes.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            comGrade.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            comModel.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            comManu.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
            dtpDoMFR.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[19].Value);
            dtpDOE.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[20].Value);
            txtMin.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
            txtMax.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
            txtROL.Text = dataGridView1.SelectedRows[0].Cells[23].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Width = 110;
            dataGridView1.Columns[29].Width = 80;
            dataGridView1.Columns[30].Width = 80;
            dataGridView1.Columns[31].Width = 80;

            /*
            dataGridView1.Columns[0].HeaderText ="Stock_Number";
            dataGridView1.Columns[1].HeaderText ="Description";
            dataGridView1.Columns[2].HeaderText ="";
            dataGridView1.Columns[3].HeaderText ="";
            dataGridView1.Columns[4].HeaderText ="";
            dataGridView1.Columns[5].HeaderText ="";
            dataGridView1.Columns[6].HeaderText ="";
            dataGridView1.Columns[7].HeaderText ="";
            dataGridView1.Columns[8].HeaderText ="";
            dataGridView1.Columns[9].HeaderText ="";
            dataGridView1.Columns[10].HeaderText ="";
            dataGridView1.Columns[11].HeaderText ="";
            */

            if (lblULevel1.Text == "Administrator")
            {
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[20].Width = 35;
                dataGridView1.Columns[24].Width = 35;
                dataGridView1.Columns[25].Width = 45;
                dataGridView1.Columns[26].Width = 35;
                dataGridView1.Columns[27].Width = 45;
                dataGridView1.Columns[28].Width = 100;
            }
            else if (lblULevel1.Text == "USER")
            {
                dataGridView1.Columns[24].Visible = false;
                dataGridView1.Columns[25].Visible = false;
                dataGridView1.Columns[26].Visible = false;
                dataGridView1.Columns[27].Visible = false;
            }
        }

        public FrmItem()
        {
            InitializeComponent();
        }

        private void CmdImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                picImg.Image = Image.FromFile(fd.FileName);
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                 picImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                 byte[] Photo = new byte[ms.Length];

                 ms.Position = 0;
                 ms.Read(Photo, 0, Photo.Length);

                OleDbCommand cmd = new OleDbCommand("Insert into Item(StNo, Des, Kw, Gr, SNum, PNum, CPC, CPMn, MPYs, MPTs, MPEI, PPWt, PPWidth, PPThick, UOMes, Grade, Model, Manu, DoMFR, DOE, Min1, Max1, ROL, AddUser, AddTime, EditUser, EditTime, CashPrice, Qty, IImg) values('"
                    + txtStNo.Text + "', '" + txtDes.Text + "', '" + comKW.Text + "', '" + comGr.Text + "', '" + txtSNum.Text + "', '" + txtPNum.Text + "', '" + txtCPC.Text + "', '" + txtCPMn.Text + "', '"
                    + txtMPYs.Text + "', '" + txtMPTs.Text + "', '" + txtMPEI.Text + "', '" + txtPPWt.Text + "', '" + txtPPWidth.Text + "', '" + txtPPThick.Text + "', '" + comUOMes.Text + "', '"
                    + comGrade.Text + "', '" + comModel.Text + "', '" + comManu.Text + "', '" + dtpDoMFR.Value.ToString() + "', '" + dtpDOE.Value.ToString() + "', '" + txtMin.Text.ToString() + "', '" + txtMax.Text.ToString() + "', '" + txtROL.Text.ToString() + "', '" + lblUser1.Text + "', '" + DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + "', '" + "Not Changed!" + "', '" + DateTime.Now.ToString() + "', '" + txtCashPrice.Text.ToString() + "', '" + txtQty.Text.ToString() + "', @photo)", con);
                cmd.Parameters.AddWithValue("@photo", Photo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtStNo.Text = "";
                Blank();
                txtStNo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-174-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                picImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];

                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                OleDbCommand cmd = new OleDbCommand("Update Item SET StNo='" + txtStNo.Text + "', Des='" + txtDes.Text + "', Kw='" + comKW.Text 
                    + "', Gr='" + comGr.Text + "', SNum='" + txtSNum.Text + "', PNum='" + txtPNum.Text + "', CPC='" + txtCPC.Text + "', CPMn='" + txtCPMn.Text
                    + "', MPYs='" + txtMPYs.Text + "', MPTs='" + txtMPTs.Text + "', MPEI='" + txtMPEI.Text + "', PPWt='" + txtPPWt.Text + "', PPWidth='" + txtPPWidth.Text
                    + "', PPThick='" + txtPPThick.Text + "', UOMes='" + comUOMes.Text + "', Grade='" + comGrade.Text + "', Model='" + comModel.Text 
                    + "', Manu='" + comManu.Text + "', DoMFR='" + dtpDoMFR.Value.ToString() + "', DOE='" + dtpDOE.Value.ToString() + "', Min1='" + txtMin.Text.ToString() 
                    + "', Max1='" + txtMax.Text.ToString() + "', ROL='" + txtROL.Text.ToString() + "', EditUser='" + lblUser1.Text + "', CashPrice='" + txtCashPrice.Text + "', Qty='" + txtQty.Text + "', EditTime='" + DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + "', IImg=@photo WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                cmd.Parameters.AddWithValue("@photo", Photo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStNo.Text = "";
                Blank();
                txtStNo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-207-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null,null);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Item] Where [id]=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStNo.Text = "";
                    Blank();
                    txtStNo.Focus();
                }
                else
                {
                    txtStNo.Focus();
                }                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-241-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Item] Where id='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                MemoryStream ms = new MemoryStream(Photo);
                picImg.Image = Image.FromStream(ms);
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-260-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Item where StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
                //Multi search
                //cmd.CommandText = "select * from table1 where sname='" + textBox1.Text + "' and city='"+textBox2.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                //comKW.Items.Clear();
               // comGr.Items.Clear();
                comGrade.Items.Clear();
                comManu.Items.Clear();
                comModel.Items.Clear();
                comUOMes.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                   // comKW.Items.Add(dr["Kw"].ToString());
                  //  comGr.Items.Add(dr["Gr"].ToString());
                    comGrade.Items.Add(dr["Grade"].ToString());
                    comManu.Items.Add(dr["Manu"].ToString());
                    comModel.Items.Add(dr["Model"].ToString());
                    comUOMes.Items.Add(dr["UOMes"].ToString());
                }

                con.Close();
                if (count == 0)
                {
                   // MessageBox.Show("Record Not Found!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-307-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {                    
                    if (txtStNo.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtStNo.Text)
                            {                                
                                string txt = "SELECT * FROM [Item] Where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                                MemoryStream ms = new MemoryStream(Photo);
                                picImg.Image = Image.FromStream(ms);
                            }
                        }
                        txtDes.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                         }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : SNO-KDW-351-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtStNo.Text == "")
                    {
                        MessageBox.Show("Please Enter Stock Number...", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStNo.Focus();
                    }
                    else
                    {
                        comKW.Focus();
                        comKW.Text = txtDes.Text.Substring(0,txtDes.Text.IndexOf(" "));
                        comKW.Text = comKW.Text+txtDes.Text.Substring((txtDes.Text.IndexOf(" ")+1),txtDes.Text.IndexOf(" ",( txtDes.Text.IndexOf(" ")+1)) );


                    }                    
                }
            }
        }

        private void comGr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGr.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSNum.Focus();
                }
            }
        }

        private void comKW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comKW.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGr.Focus();
                }
            }
        }

        private void txtSNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSNum.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPNum.Focus();
                }
            }
        }

        private void txtPNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPNum.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCPC.Focus();
                }
            }
        }

        private void txtCPC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPC.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCPMn.Focus();
                }
            }
        }

        private void txtCPMn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPMn.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMPYs.Focus();
                }
            }
        }

        private void txtMPYs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMPYs.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMPTs.Focus();
                }
            }
        }

        private void txtMPTs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMPTs.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMPEI.Focus();
                }
            }
        }

        private void txtMPEI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMPEI.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPPWt.Focus();
                }
            }
        }

        private void txtPPWt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPPWt.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPPWidth.Focus();
                }
            }
        }

        private void txtPPWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPPWidth.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPPThick.Focus();
                }
            }
        }

        private void txtPPThick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPPThick.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comUOMes.Focus();
                }
            }
        }

        private void comUOMes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comUOMes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGrade.Focus();
                }
            }
        }

        private void comGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGrade.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdImg.Focus();
                }
            }
        }

        private void comModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comModel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comManu.Focus();
                }
            }
        }

        private void comManu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comManu.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpDoMFR.Focus();
                }
            }
        }

        private void dtpDoMFR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDOE.Focus();
            }
        }

        private void dtpDOE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMin.Focus();
            }
        }

        private void txtMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMin.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMax.Focus();
                }
            }
        }

        private void txtMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMax.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtROL.Focus();
                }
            }
        }

        private void txtROL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtROL.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void comKW_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            uname = lblUser1.Text;
            ul = lblULevel1.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();
        }
        public static string uname = "";
        public static string ul = "";

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDes.Text, @"[^A-Za-z0-9\s]"))
            {
                MessageBox.Show("Please Enter Only AlphaNumberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDes.Text = txtDes.Text.Remove(txtDes.Text.Length - 1);
                txtDes.Text = "";
            }
        }

        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Refresh();
            dtpDOE.Refresh();
            dtpDoMFR.Refresh();
            comGr.Refresh();
            comKW.Refresh();
            comManu.Refresh();
            comModel.Refresh();
            txtDes.Refresh();
            TxtSer.Refresh();
            txtStNo.Refresh();
            dataGridView1.Refresh();
            txtStNo.Text = "";
            Blank();
            txtStNo.Focus();
            this.Refresh();
            Refresh();
        }

        private void CmdImgSer_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtStNo.Text = "";
            Blank();
            txtStNo.Focus();
        }

        private void CmdImg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comModel.Focus();
            }                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDes_Click(object sender, EventArgs e)
        {
            if (txtDes.Text == "")
            {
                MessageBox.Show("Please Use Enter key! (Enter Key usage Speder than Mouse Click and some founctions are included in Enter Key. If Enter Key is not Working, You may use Tab Key.)", "Data Entry Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStNo.Focus();
            }
            if (txtStNo.Text=="")
            {
                MessageBox.Show("Please Enter the Stock Number!", "Invalid Data Entry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStNo.Focus();
            }
        }

        private void txtStNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStNo.Text, @"[^A-Za-z0-9]"))
            {
                MessageBox.Show("Please Enter Only AlphaNumberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStNo.Text = txtStNo.Text.Remove(txtStNo.Text.Length - 1);
                txtStNo.Text = "";
            }
        }

        private void comGr_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comGr.Text, @"[^A-Za-z0-9]"))
            {
                MessageBox.Show("Please Enter Only AlphaNumberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comGr.Text = comGr.Text.Remove(comGr.Text.Length - 1);
                comGr.Text = "";
            }
        }

        private void txtPPWt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPPWt.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPWt.Text = txtPPWt.Text.Remove(txtPPWt.Text.Length - 1);
                txtPPWt.Text = "";
            }
        }

        private void txtPPWidth_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPPWidth.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPWidth.Text = txtPPWidth.Text.Remove(txtPPWidth.Text.Length - 1);
                txtPPWidth.Text = "";
            }
        }

        private void txtPPThick_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPPThick.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPThick.Text = txtPPThick.Text.Remove(txtPPThick.Text.Length - 1);
                txtPPThick.Text = "";
            }
        }

        private void comUOMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(comUOMes.Text, @"[^A-Za-z]"))
            {
                MessageBox.Show("Please Enter Only Alphabetic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comUOMes.Text = comUOMes.Text.Remove(comUOMes.Text.Length - 1);
                comUOMes.Text = "";
            }
        }

        private void txtCashPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 

            if (System.Text.RegularExpressions.Regex.IsMatch(txtCashPrice.Text, @"['RS'£$'Rs']\s[0-9]{0,}\.[0-9]"))
            {
                    txtQty.Focus();
            }    
            else
              {
                   MessageBox.Show("Please Enter Valid Curreny Format!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtCashPrice.Text = txtCashPrice.Text.Remove(txtCashPrice.Text.Length - 1);
                   txtCashPrice.Text = "";

              }

            }

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMin.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMin.Text = txtMin.Text.Remove(txtMin.Text.Length - 1);
                txtMin.Text = "";
            }
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMax.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMax.Text = txtMax.Text.Remove(txtMax.Text.Length - 1);
                txtMax.Text = "";
            }
        }

        private void txtROL_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtROL.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numberic Characters!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtROL.Text = txtROL.Text.Remove(txtROL.Text.Length - 1);
                txtROL.Text = "";
            }
        }
    }
}
