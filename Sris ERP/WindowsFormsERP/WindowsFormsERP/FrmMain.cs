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
       
    public partial class FrmMain : Form
    {
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\InvDatabase.mdb");//|DataDirectory|\
       
        private void UserIDKW()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + lblID.Text.Trim() + "'", con);
                cmd1.Connection = con;
                rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["NNewUser"].ToString() == "False")
                    {
                        newUserToolStripMenuItem.Enabled = false;
                        usersToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NUserLogin"].ToString() == "False")
                    {
                        loginToolStripMenuItem.Enabled = false;
                        userLoginToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NUserControl"].ToString() == "False")
                    {
                        exitToolStripMenuItem.Enabled = false;
                        userControlToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NUserLevel"].ToString() == "False")
                    {
                        userLevelToolStripMenuItem.Enabled = false;
                        userLevelToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NExit"].ToString() == "False")
                    {
                        exitToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NInvoice"].ToString() == "False")
                    {
                        invoiveToolStripMenuItem.Enabled = false;
                        invoiceItemWiseToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NPurchase"].ToString() == "False")
                    {
                        toolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NJobOrder"].ToString() == "False")
                    {
                        jobOrderToolStripMenuItem.Enabled = false;
                        jobOrderToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NPayments"].ToString() == "False")
                    {
                        paymentsToolStripMenuItem.Enabled = false;
                        tTPaymentToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NCheque"].ToString() == "False")
                    {
                        chequeToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NBank"].ToString() == "False")
                    {
                        bankToolStripMenuItem.Enabled = false;
                        bankToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NAccounts"].ToString() == "False")
                    {
                        accountsToolStripMenuItem.Enabled = false;
                        accountsToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NStockItem"].ToString() == "False")
                    {
                        stockItemToolStripMenuItem.Enabled = false;
                        stockItemToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NCustomer"].ToString() == "False")
                    {
                        customerToolStripMenuItem.Enabled = false;
                        customerSumarryToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NVendor"].ToString() == "False")
                    {
                        vendorToolStripMenuItem.Enabled = false;
                        supplierSummaryToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NInventoryItems"].ToString() == "False")
                    {
                        //inventoryItemsToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NFixedAssets"].ToString() == "False")
                    {
                        fixedAssetsToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NMiscellaneous"].ToString() == "False")
                    {
                        miscellaneousToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NReports"].ToString() == "False")
                    {
                        reportsToolStripMenuItem.Enabled = false;
                    }
                    if (PicImg.Image != null)
                    {
                        byte[] Photo = (byte[])(rdr["IImg"]);
                        MemoryStream ms = new MemoryStream(Photo);
                        PicImg.Image = Image.FromStream(ms);                                        
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                return;
            }
        }

        public FrmMain()
        {
            InitializeComponent();         
        }
        
        private void user_level_check()
        {

            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserName='" + FrmLogin.usrname + "' ", con);
            cmd1.Connection = con;
            OleDbDataReader rdr = cmd1.ExecuteReader();

            rdr.Read();
            //user_level = rdr["UserLevel"].ToString();           

            if (Convert.ToBoolean(rdr["NSystem"].ToString()) == true)
            {
                systemToolStripMenuItem.Enabled = true;
            }
            else
            {
                systemToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NNewUser"].ToString()) == true)
            {
                newUserToolStripMenuItem.Enabled = true;
            }
            else
            {
                newUserToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NUserLogin"].ToString()) == true)
            {
                loginToolStripMenuItem.Enabled = true;
            }
            else
            {
                loginToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NUserControl"].ToString()) == true)
            {
                exitToolStripMenuItem.Enabled = true;
            }
            else
            {
                exitToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NUserLevel"].ToString()) == true)
            {
                userLevelToolStripMenuItem.Enabled = true;
            }
            else
            {
                userLevelToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NExit"].ToString()) == true)
            {
                exitToolStripMenuItem1.Enabled = true;
            }
            else
            {
                exitToolStripMenuItem1.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NInvoice"].ToString()) == true)
            {
                invoiveToolStripMenuItem.Enabled = true;
            }
            else
            {
                invoiveToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NPurchase"].ToString()) == true)
            {
                toolStripMenuItem1.Enabled = true;
            }
            else
            {
                toolStripMenuItem1.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NJobOrder"].ToString()) == true)
            {
                jobOrderToolStripMenuItem.Enabled = true;
            }
            else
            {
                jobOrderToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NPayments"].ToString()) == true)
            {
                paymentsToolStripMenuItem.Enabled = true;
            }
            else
            {
                paymentsToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NCheque"].ToString()) == true)
            {
                chequeToolStripMenuItem.Enabled = true;
            }
            else
            {
                chequeToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NBank"].ToString()) == true)
            {
                bankToolStripMenuItem.Enabled = true;
            }
            else
            {
                bankToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NAccounts"].ToString()) == true)
            {
                accountsToolStripMenuItem.Enabled = true;
            }
            else
            {
                accountsToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NStockItem"].ToString()) == true)
            {
                stockItemToolStripMenuItem.Enabled = true;
            }
            else
            {
                stockItemToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NCustomer"].ToString()) == true)
            {
                customerToolStripMenuItem.Enabled = true;
            }
            else
            {
                customerToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NVendor"].ToString()) == true)
            {
                vendorToolStripMenuItem.Enabled = true;
            }
            else
            {
                vendorToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NInventoryItems"].ToString()) == true)
            {
                stockItemToolStripMenuItem.Enabled = true;
            }
            else
            {
                stockItemToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NFixedAssets"].ToString()) == true)
            {
                fixedAssetsToolStripMenuItem.Enabled = true;
            }
            else
            {
                fixedAssetsToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NMiscellaneous"].ToString()) == true)
            {
                miscellaneousToolStripMenuItem.Enabled = true;
            }
            else
            {
                miscellaneousToolStripMenuItem.Enabled = false;
            }

            if (Convert.ToBoolean(rdr["NReports"].ToString()) == true)
            {
                reportsToolStripMenuItem.Enabled = true;
            }
            else
            {
                reportsToolStripMenuItem.Enabled = false;
            }

            con.Close();
        }
                 

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //newUserToolStripMenuItem.Enabled = false;
            //exitToolStripMenuItem.Enabled = false;
            user_level_check();

            FrmLoad FLoad = new FrmLoad();
            FLoad.Close();
            FrmLogin FLogin = new FrmLogin();
            FLogin.Close();

            if (lblULevel.Text == "Administrator")
            {
                exitToolStripMenuItem.Enabled = true;
            }

            lblUL.Text = lblULevel.Text;
            lblUID.Text = lblUser.Text;
            lblID.Refresh();
            Refresh();
            this.Refresh();
            panel2.Left = Convert.ToInt32((this.Width)) / 2 - Convert.ToInt32(panel2.Width)/2;
            panel2.Top = Convert.ToInt32((this.Height)) / 2 - Convert.ToInt32(panel2.Height)*2/3;
            //try
            //{
            //    this.BackColor = Color.FromArgb(Convert.ToInt32(lblColor.Text));
            //}
            //catch (Exception)
            //{
            //    return;
            //}
            UserIDKW();

            monthCalendar1.SetDate(DateTime.Now);
            if (invoiveToolStripMenuItem.Enabled==false)
            {
                aaaToolStripMenuItem.Enabled = false;
                taxInvoiceToolStripMenuItem1.Enabled = false;                
                suspendedTaxInvoiceToolStripMenuItem1.Enabled = false;
                manufactureInvoiceToolStripMenuItem1.Enabled = false;
            }

            if (jobOrderToolStripMenuItem.Enabled == false)
            {
                jobOrderToolStripMenuItem3.Enabled = false;                
            }

            if (toolStripMenuItem1.Enabled == false)
            {
                purchaseOrderToolStripMenuItem1.Enabled = false;
                purchaseGRNToolStripMenuItem.Enabled = false;
            }

            if (chequeToolStripMenuItem.Enabled == false)
            {
                chequePaymentToolStripMenuItem2.Enabled = false;
            }

            if (accountsToolStripMenuItem.Enabled == false)
            {
                currencyExchangeToolStripMenuItem.Enabled = false;
                cashBookToolStripMenuItem1.Enabled = false;
                generalLedgerSumarryToolStripMenuItem.Enabled = false;
                iOUToolStripMenuItem1.Enabled = false;
                pettyCashToolStripMenuItem1.Enabled = false;
            }

            if (stockItemToolStripMenuItem.Enabled == false)
            {
                stockReportToolStripMenuItem1.Enabled = false;
                stockImageToolStripMenuItem1.Enabled = false;
            }

            lblUID.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width)) / 2 - Convert.ToInt32(lblUID.Width)/2;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmItem FItem = new FrmItem();            
            FItem.Show();
        }
        public static string uname = "";
        public static string ul = "";

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();            
        }

        private void newVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSup FSup = new FrmSup();
            FSup.Show();
        }

        private void supplierSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupRep FSupRep = new FrmSupRep();
            FSupRep.Show();
        }

        private void stockImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin FLogin = new FrmLogin();
            FLogin.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUReg FUReg = new FrmUReg();
            FUReg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUControl FUControl = new FrmUControl();
            FUControl.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoice FInvoice = new FrmInvoice();
            FInvoice.Show();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmPurOrder FmPurOrder = new FrmPurOrder();
            //FmPurOrder.Show();
        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurGRN FPurGRN = new FrmPurGRN();
            FPurGRN.Show();
        }

        private void newJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobOdr FJobOdr = new FrmJobOdr();
            FJobOdr.Show();
        }

        private void orderWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void receivedEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmCheque FCheque = new FrmCheque();
            //FCheque.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBank FBank = new FrmBank();
            FBank.Show();
        }

        private void bankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankDtl FBankDtl = new FrmBankDtl();
            FBankDtl.Show();
        }

        private void entryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBankRecn FBankRecn = new FrmBankRecn();
            FBankRecn.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRecnRep FBankRecnRep = new FrmBankRecnRep();
            FBankRecnRep.Show();
        }

        private void newCustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCus FCus = new FrmCus();
            FCus.Show();
        }

        private void customerSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCusRep FCusRep = new FrmCusRep();
            FCusRep.Show();
        }

        private void accountReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARInv FAccRec = new FrmARInv();
            FAccRec.Show();
        }

        private void accountPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPInv FAccPay = new FrmAPInv();
            FAccPay.Show();
        }

        private void fixedAssetSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmFxdAst FFxdAst = new FrmFxdAst();
            //FFxdAst.Show();
        }

        private void fixedAssetSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmFxdAstRep FFxdAstRep = new FrmFxdAstRep();
            //FFxdAstRep.Show();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmMislns FMislns = new FrmMislns();
            //FMislns.Show();
        }

        private void accountTypeCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGLAccount FGLAccount = new FrmGLAccount();
            FGLAccount.Show();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaOAcc FChaOAcc = new FrmChaOAcc();
            FChaOAcc.Show();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCrncy FCrncy = new FrmCrncy();
            FCrncy.Show();
        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrncyExc FCrncyExc = new FrmCrncyExc();
            FCrncyExc.Show();
        }

        private void cashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmCshBok FCshBok = new FrmCshBok();
            //FCshBok.Show();
        }

        private void registrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTaxReg FTaxReg = new FrmTaxReg();
            FTaxReg.Show();
        }

        private void entryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPtyCsh FPtyCsh = new FrmPtyCsh();
            FPtyCsh.Show();
        }

        private void profitAndLossStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProLos FProLos = new FrmProLos();
            FProLos.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmBalSht FBalSht = new FrmBalSht();
            //FBalSht.Show();
        }

        private void incomeStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmIncome FIncome = new FrmIncome();
            //FIncome.Show();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmTriBal FTriBal = new FrmTriBal();
            //FTriBal.Show();
        }

        private void transportationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmTransport FTransport = new FrmTransport();
            //FTransport.Show();
        }

        private void iOUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIOU FIOU = new FrmIOU();
            FIOU.Show();
        }

        private void chequePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmChqPay FChqPay = new FrmChqPay();
            //FChqPay.Show();
        }

        private void chequeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //FrmChqPay FChqPay = new FrmChqPay();
            //FChqPay.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmGenLeg FGenLeg = new FrmGenLeg();
            //FGenLeg.Show();
        }

        private void taxInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTxtInv1 FTxtInv1 = new FrmTxtInv1();
            FTxtInv1.Show();
        }

        private void suspendedTaxInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInv FSTaxInv = new FrmSTaxInv();
            FSTaxInv.Show();
        }

        private void manufactureInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMnuInv FMnuInv = new FrmMnuInv();
            FMnuInv.Show();
        }

        private void totalsByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Show();
        }

        private void salesInvoiceTotalsByItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Show();
        }

        private void bankWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmChqRep FChqRep = new FrmChqRep();
            //FChqRep.Show();
        }

        private void customerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmChqRep FChqRep = new FrmChqRep();
            //FChqRep.Show();
        }

        private void branchWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmChqRep FChqRep = new FrmChqRep();
            //FChqRep.Show();
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPtyCshRep FPtyCshRep = new FrmPtyCshRep();
            FPtyCshRep.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmPurRep FPurRep = new FrmPurRep();
            //FPurRep.Show();
        }

        private void numberWiseReportRevenueExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void customerWiseJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void aPInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void cashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void aRInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void creditMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARCMemo FARCMemo = new FrmARCMemo();
            FARCMemo.Show();
        }

        private void debitMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPCMemo FAPCMemo = new FrmAPCMemo();
            FAPCMemo.Show();
        }

        private void outgoingPayment1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgPay1 FOgPay1 = new FrmOgPay1();
            FOgPay1.Show();
        }

        private void outgoingPayment2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgPay2 FOgPay2 = new FrmOgPay2();
            FOgPay2.Show();
        }

        private void tTPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTTPay FTTPay = new FrmTTPay();
            FTTPay.Show();
        }

        private void cashToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void cashToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmBill FBill = new FrmBill();
            //FBill.Show();
        }

        private void paymentReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmPayRec FPayRec = new FrmPayRec();
            //FPayRec.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmJOPay FJOPay = new FrmJOPay();
            //FJOPay.Show();
        }

        private void salesStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSStaff FSStaff = new FrmSStaff();
            FSStaff.Show();
        }

        private void locationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocation FLocation = new FrmLocation();
            FLocation.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPassword FPassword = new FrmPassword();

            Control[] ctrlsIDD = FPassword.Controls.Find("lblID", false);
            Label lbl3 = (Label)ctrlsIDD[0];
            lbl3.Text = lblID.Text;

            FPassword.Show();
        }

        private void businessMasterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBMaster FBMaster = new FrmBMaster();
            FBMaster.Show();
        }

        private void stockItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stockReportToolStripMenuItem_Click(null, null);
        }

        private void customerSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerSummaryToolStripMenuItem_Click(null, null);
        }

        private void supplierSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplierSummaryToolStripMenuItem_Click(null, null);
        }

        private void jobOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void bankReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void bankEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void bankDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBankDetailsRep FBankDetailsRep = new FrmBankDetailsRep();
            FBankDetailsRep.Show();
        }

        private void tTPaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTTPaymentRep FTTPaymentRep = new FrmTTPaymentRep();
            FTTPaymentRep.Show();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsersRep FUsersRep = new FrmUsersRep();
            FUsersRep.Show();
        }

        private void userLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUserLevelRep FUserLevelRep = new FrmUserLevelRep();
            FUserLevelRep.Show();
        }

        private void taxRegistrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTaxRegRep FTaxRegRep = new FrmTaxRegRep();
            FTaxRegRep.Show();
        }

        private void accountTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAccountTypeRep FAccountTypeRep = new FrmAccountTypeRep();
            FAccountTypeRep.Show();
        }

        private void chartOfAccountsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCOAccountRep FCOAccountRep = new FrmCOAccountRep();
            FCOAccountRep.Show();
        }

        private void currencyRegistrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCurrencyRegRep FCurrencyRegRep = new FrmCurrencyRegRep();
            FCurrencyRegRep.Show();
        }

        private void currencyExchangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCurrencyExcRep FCurrencyExcRep = new FrmCurrencyExcRep();
            FCurrencyExcRep.Show();
        }

        private void pettyCashToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reportToolStripMenuItem1_Click(null, null);
        }

        private void iOUToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmIOURep FIOURep = new FrmIOURep();
            FIOURep.Show();
        }

        private void locationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLocationRep FLocationRep = new FrmLocationRep();
            FLocationRep.Show();
        }

        private void salesStaffToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmSalesStaffRep FSalesStaffRep = new FrmSalesStaffRep();
            FSalesStaffRep.Show();
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Show();
        }

        private void taxInvoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Show();
        }

        private void manufactureInvoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMInvRep FMInvRep = new FrmMInvRep();
            FMInvRep.Show();
        }

        private void suspendedTaxInvoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Show();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserLoginRep FUserLoginRep = new FrmUserLoginRep();
            FUserLoginRep.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            FrmLogin FLogin = new FrmLogin();
            FLogin.Show();
            this.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoice FInvoice = new FrmInvoice();
            FInvoice.Show();
        }

        private void taxInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTxtInv1 FTxtInv1 = new FrmTxtInv1();
            FTxtInv1.Show();
        }

        private void suspendedTaxInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSTaxInv FSTaxInv = new FrmSTaxInv();
            FSTaxInv.Show();
        }

        private void manufactureInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMnuInv FMnuInv = new FrmMnuInv();
            FMnuInv.Show();
        }

        private void jobOrderToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmJobOdr FJobOdr = new FrmJobOdr();
            FJobOdr.Show();
        }

        private void purchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmPurOrder FmPurOrder = new FrmPurOrder();
            //FmPurOrder.Show();
        }

        private void currencyExchangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCrncyExc FCrncyExc = new FrmCrncyExc();
            FCrncyExc.Show();
        }

        private void purchaseGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurGRN FPurGRN = new FrmPurGRN();
            FPurGRN.Show();
        }

        private void chequePaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //FrmChqPay FChqPay = new FrmChqPay();
            //FChqPay.Show();
        }

        private void cashBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //    FrmCshBok FCshBok = new FrmCshBok();
            //    FCshBok.Show();
        }

        private void generalLedgerSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmGenLeg FGenLeg = new FrmGenLeg();
            //FGenLeg.Show();
        }

        private void iOUToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmIOU FIOU = new FrmIOU();
            FIOU.Show();
        }

        private void pettyCashToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmPtyCsh FPtyCsh = new FrmPtyCsh();
            FPtyCsh.Show();
        }

        private void stockReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();
        }

        private void stockImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void userLevelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*
            FrmUserLevel FUserLevel = new FrmUserLevel();
            FUserLevel.Show();
            */
        }

        private void invoiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menuStrip4.Visible = true;
        }

        private void invoiveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*
            if (mInv.Visible == true)
            {
                mInv.Visible = false;
               // menuBlank.Visible = true;
            }
            else
            {
                mInv.Visible = true;
              //  menuBlank.Visible = false;
            }       
            */

        }

        private void invoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void taxInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbTInv_Click(object sender, EventArgs e)
        {
            
        }

        private void suspendedTaxInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbSTInv_Click(object sender, EventArgs e)
        {
            
        }

        private void manufactureInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbMInv_Click(object sender, EventArgs e)
        {
            
        }

        private void aPInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbAPInv_Click(object sender, EventArgs e)
        {
            
        }

        private void aRInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbARInv_Click(object sender, EventArgs e)
        {
            
        }

        private void salesStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbSStf_Click(object sender, EventArgs e)
        {
            
        }

        private void locationEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbLoc_Click(object sender, EventArgs e)
        {
            
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (mPay.Visible == true)
            {
                mPay.Visible = false;
               // menuBlank.Visible = true;
            }
            else
            {
                mPay.Visible = true;
              //  menuBlank.Visible = false;
            }
            */
        }

        private void outgoingPayment1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbOP1_Click(object sender, EventArgs e)
        {
            
        }

        private void outgoingPayment2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbOP2_Click(object sender, EventArgs e)
        {
            
        }

        private void tTPaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbTTPay_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void tsInv_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mInv_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InvM_Click(object sender, EventArgs e)
        {
            FrmInvoice FInvoice = new FrmInvoice();
            FInvoice.Show();
        }

        private void TInvM_Click(object sender, EventArgs e)
        {
            FrmTxtInv1 FTxtInv1 = new FrmTxtInv1();
            FTxtInv1.Show();
        }

        private void SInvM_Click(object sender, EventArgs e)
        {
            FrmSTaxInv FSTaxInv = new FrmSTaxInv();
            FSTaxInv.Show();
        }

        private void MInvM_Click(object sender, EventArgs e)
        {
            FrmMnuInv FMnuInv = new FrmMnuInv();
            FMnuInv.Show();
        }

        private void APInvM_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void ARInvM_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void SSInvM_Click(object sender, EventArgs e)
        {
            FrmSStaff FSStaff = new FrmSStaff();
            FSStaff.Show();
        }

        private void LInvM_Click(object sender, EventArgs e)
        {
            
        }

        private void mPay_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OP1M_Click(object sender, EventArgs e)
        {
            FrmOgPay1 FOgPay1 = new FrmOgPay1();
            FOgPay1.Show();
        }

        private void OP2M_Click(object sender, EventArgs e)
        {
            FrmOgPay2 FOgPay2 = new FrmOgPay2();
            FOgPay2.Show();
        }

        private void TTPM_Click(object sender, EventArgs e)
        {
            FrmTTPay FTTPay = new FrmTTPay();
            FTTPay.Show();
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bankReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void registrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void BRegM_Click(object sender, EventArgs e)
        {
            FrmBank FBank = new FrmBank();
            FBank.Show();
        }

        private void bankDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void BDetM_Click(object sender, EventArgs e)
        {
            FrmBankDtl FBankDtl = new FrmBankDtl();
            FBankDtl.Show();
        }

        private void entryToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void reconciliationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RecEM_Click(object sender, EventArgs e)
        {
            FrmBankRecn FBankRecn = new FrmBankRecn();
            FBankRecn.Show();
        }

        private void reportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void RecRM_Click(object sender, EventArgs e)
        {
            FrmBankRecnRep FBankRecnRep = new FrmBankRecnRep();
            FBankRecnRep.Show();
        }

        private void mAcc_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (mBank.Visible == true)
            {
                mBank.Visible = false;
                // menuBlank.Visible = true;
            }
            else
            {
                mBank.Visible = true;
                //  menuBlank.Visible = false;
            }
            */
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (mAcc.Visible == true)
            {
                mAcc2.Visible = false;
                mAcc.Visible = false;
                // menuBlank.Visible = true;
            }
            else
            {
                mAcc2.Visible = true;
                mAcc.Visible = true;
                //  menuBlank.Visible = false;
            }
            */
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FrmGLAccount FGLAccount = new FrmGLAccount();
            FGLAccount.Show();
        }

        private void entryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void iOUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            FrmTaxReg FTaxReg = new FrmTaxReg();
            FTaxReg.Show();
        }

        private void accountTypeCreationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void chartOfAccountsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void CAM_Click(object sender, EventArgs e)
        {
            FrmChaOAcc FChaOAcc = new FrmChaOAcc();
            FChaOAcc.Show();
        }

        private void currencyRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void CRM_Click(object sender, EventArgs e)
        {
            FrmCrncy FCrncy = new FrmCrncy();
            FCrncy.Show();
        }

        private void exchangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void CEM_Click(object sender, EventArgs e)
        {
            FrmCrncyExc FCrncyExc = new FrmCrncyExc();
            FCrncyExc.Show();
        }

        private void taxRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entryToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void PCM_Click(object sender, EventArgs e)
        {
            FrmPtyCsh FPtyCsh = new FrmPtyCsh();
            FPtyCsh.Show();
        }

        private void reportToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void PCRM_Click(object sender, EventArgs e)
        {
            FrmPtyCshRep FPtyCshRep = new FrmPtyCshRep();
            FPtyCshRep.Show();
        }

        private void financialStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IOUM_Click(object sender, EventArgs e)
        {
            FrmIOU FIOU = new FrmIOU();
            FIOU.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iOUToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmIOURep FIOURep = new FrmIOURep();
            FIOURep.Show();
        }

        private void IOURM_Click(object sender, EventArgs e)
        {
            FrmIOURep FIOURep = new FrmIOURep();
            FIOURep.Show();
        }

        private void cashBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pettyCashToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cashFlowStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUReg FUReg = new FrmUReg();
            FUReg.Show();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmLogin FLogin = new FrmLogin();
            FLogin.Show();
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPassword FPassword = new FrmPassword();

            Control[] ctrlsIDD = FPassword.Controls.Find("lblID", false);
            Label lbl3 = (Label)ctrlsIDD[0];
            lbl3.Text = lblID.Text;

            FPassword.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUControl FUControl = new FrmUControl();
            FUControl.Show();
        }

        private void userLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserLevel FUserLevel = new FrmUserLevel();
            FUserLevel.Show();
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void purchaseOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPurchaseOrder FPurchaseOrder = new FrmPurchaseOrder();
            FPurchaseOrder.Show();
        }

        private void gRNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPurGRN FPurGRN = new FrmPurGRN();
            FPurGRN.Show();
        }

        private void purchaseReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPurOrderRep FPurOrderRep = new FrmPurOrderRep();
            FPurOrderRep.Show();
        }

        private void jobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newJobOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmJobOdr FJobOdr = new FrmJobOdr();
            FJobOdr.Show();
        }

        private void orderWiseReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Text = "Job Order Number wise Report";
            FJobORep.Show();
        }

        private void numberWiseReportRevenueExpensesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void customerWiseJobOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmJOCusList FJOCusList = new FrmJOCusList();
           // FJOCusList.Text = "Job Order Customer wise Report";
            FJOCusList.Show();
        }

        private void paymentReceivedToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmJOPayRecRep FPayRec = new FrmJOPayRecRep();
            FPayRec.Show();
        }

        private void paymentToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmJOPayment FJOPay = new FrmJOPayment();
            FJOPay.Show();
        }

        private void receivedEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmChqPaymentReceived FChqPaymentReceived = new FrmChqPaymentReceived();
            FChqPaymentReceived.Show();
        }

        private void bankWiseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmChqRecCusList FChqRecCusList = new FrmChqRecCusList();
            FChqRecCusList.Show();
        }

        private void customerWiseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmChqRecDateList FChqRecDateList = new FrmChqRecDateList();
            FChqRecDateList.Show();
        }

        private void branchWiseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmChqPaymentPaid FChqPaymentPaid = new FrmChqPaymentPaid();
            FChqPaymentPaid.Show();
        }

        private void chequePaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmChqPaySupList FChqPaySupList = new FrmChqPaySupList();
            FChqPaySupList.Show();
        }

        private void newItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmItem FItem = new FrmItem();            
            FItem.Show();
            
        }

        private void stockReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Text = "Stock Report";
            FStkRep.Show();
        }

        private void stockImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void newCustToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCus FCus = new FrmCus();
            FCus.Show();
        }

        private void customerSummaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCusRep FCusRep = new FrmCusRep();
            FCusRep.Show();
        }

        private void creditMemoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmARCMemo FARCMemo = new FrmARCMemo();
            FARCMemo.Show();
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newVendorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmSup FSup = new FrmSup();
            FSup.Show();
        }

        private void supplierSummaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmSupRep FSupRep = new FrmSupRep();
            FSupRep.Show();
        }

        private void debitMemoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAPCMemo FAPCMemo = new FrmAPCMemo();
            FAPCMemo.Show();
        }

        private void stockItemToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //stockReportToolStripMenuItem_Click(null, null);
        }

        private void customerSumarryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //customerSummaryToolStripMenuItem_Click(null, null);
        }

        private void supplierSummaryToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //supplierSummaryToolStripMenuItem_Click(null, null);
        }

        private void jobOrderToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void bankToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bankEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void bankDetailsToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmBankDetailsRep FBankDetailsRep = new FrmBankDetailsRep();
            FBankDetailsRep.Show();
        }

        private void usersToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmUsersRep FUsersRep = new FrmUsersRep();
            FUsersRep.Text = "User";
            FUsersRep.Show();
        }

        private void userLevelToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmUserLevelRep FUserLevelRep = new FrmUserLevelRep();
            FUserLevelRep.Show();
        }

        private void userLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUserLoginRep FUserLoginRep = new FrmUserLoginRep();
            FUserLoginRep.Show();
        }

        private void invoiceToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Text = "Invoice Report (Total by Item)";
            FInvRep.Show();
        }

        private void taxInvoiceItemWiseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Text = "Tax Invoice Report (Total by Item)";
            FTaxInvRep.Show();
        }

        private void manufactureInvoiceItemWiseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMInvRep FMInvRep = new FrmMInvRep();
            FMInvRep.Text = "Manufacture Invoice Report (Total by Item)";
            FMInvRep.Show();
        }

        private void suspendedTaxInvoiceItemWiseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Text = "Suspended Tax Invoice Report (Total by Item)";
            FSTaxInvRep.Show();
        }

        private void accountsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void taxRegistrationToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmTaxRegRep FTaxRegRep = new FrmTaxRegRep();
            FTaxRegRep.Show();
        }

        private void accountTypeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmAccountTypeRep FAccountTypeRep = new FrmAccountTypeRep();
            FAccountTypeRep.Show();
        }

        private void chartOfAccountsToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmCOAccountRep FCOAccountRep = new FrmCOAccountRep();
            FCOAccountRep.Show();
        }

        private void currencyRegistrationToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmCurrencyRegRep FCurrencyRegRep = new FrmCurrencyRegRep();
            FCurrencyRegRep.Show();
        }

        private void currencyExchangeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmCurrencyExcRep FCurrencyExcRep = new FrmCurrencyExcRep();
            FCurrencyExcRep.Show();
        }

        private void pettyCashToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            reportToolStripMenuItem1_Click(null, null);
        }

        private void invoiceCustomerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Text = "Invoice Report (Total by Customer)";
            FInvRep.Show();
        }

        private void taxInvoiceCustomerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Text = "Tax Invoice Report (Total by Customer)";
            FTaxInvRep.Show();
        }

        private void suspendTaxInvoiceCustomerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Text = "Suspended Tax Invoice Report (Total by Customer)";
            FSTaxInvRep.Show();
        }

        private void manufactureInvoiceCustomerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMInvRep FMInvRep = new FrmMInvRep();
            FMInvRep.Text = "Manufacture Invoice Report (Total by Customer)";
            FMInvRep.Show();
        }

        private void JournalM_Click(object sender, EventArgs e)
        {
            
        }

        private void JEM_Click(object sender, EventArgs e)
        {
            FrmJournal FJournal = new FrmJournal();
            FJournal.Show();
        }

        private void JRM_Click(object sender, EventArgs e)
        {
            FrmJournalRep FJournalRep = new FrmJournalRep();
            FJournalRep.Show();
        }

        private void TrnsB_Click(object sender, EventArgs e)
        {
            FrmTransection FTransection = new FrmTransection();
            FTransection.Show();
        }

        private void CashM_Click(object sender, EventArgs e)
        {
            FrmCashbook FCashbook = new FrmCashbook();
            FCashbook.Show();
        }

        private void LegM_Click(object sender, EventArgs e)
        {
            FrmLedgerList FLedgerList = new FrmLedgerList();
            FLedgerList.Show();
        }

        private void TrBM_Click(object sender, EventArgs e)
        {
            FrmTB FTB = new FrmTB();
            FTB.Show();
        }

        private void PLSM_Click(object sender, EventArgs e)
        {
            FrmProLos FProLos = new FrmProLos();
            FProLos.Show();
        }

        private void BlShM_Click(object sender, EventArgs e)
        {
            FrmBalanceSheet frmBalanceSheet = new FrmBalanceSheet();
            frmBalanceSheet.Show();
        }

        private void InStM_Click(object sender, EventArgs e)
        {
            FrmIncomeStatement FIncomeStatement = new FrmIncomeStatement();
            FIncomeStatement.Show();
        }

        private void CFStM_Click(object sender, EventArgs e)
        {
            FrmCashFlow FCashFlow = new FrmCashFlow();
            FCashFlow.Show();
        }

        private void stockQtyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Text = "Inventory Quantity Sumarry";
            FStkRep.Show();
        }

        private void stockValueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Text = "Inventory Value Sumarry";
            FStkRep.Show();
        }

        private void inventoryProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Text = "Inventory Profit Sumarry";
            FStkRep.Show();
        }

        private void fixedAssetSummaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmFAssets FFAssets = new FrmFAssets();
            FFAssets.Show();
        }

        private void fixedAssetSummaryToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmFAssetsRep FFAssetsRep = new FrmFAssetsRep();
            FFAssetsRep.Show();
        }

        private void entryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmMisl FMisl = new FrmMisl();
            FMisl.Show();
        }

        private void statementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmMislRep FMislRep = new FrmMislRep();
            FMislRep.Show();
        }

        private void purchaseGRNReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmPurGRNRep FPurGRNRep = new FrmPurGRNRep();
            FPurGRNRep.Show();
        }

        private void jobOrderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            orderWiseReportToolStripMenuItem_Click_1(null, null);
        }

        private void tTPaymentToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmTTPaymentRep FTTPaymentRep = new FrmTTPaymentRep();
            FTTPaymentRep.Show();
        }

        private void userControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersRep FUsersRep = new FrmUsersRep();
            FUsersRep.Text = "User Level";
            FUsersRep.Show();
        }

        private void locationToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmLocationRep FLocationRep = new FrmLocationRep();
            FLocationRep.Show();
        }

        private void salesStaffToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmSalesStaffRep FSalesStaffRep = new FrmSalesStaffRep();
            FSalesStaffRep.Show();
        }

        private void customerStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCusStatement FCusStatement = new FrmCusStatement();
            FCusStatement.Show();
        }

        private void accountReceaveableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccReceiveable FAccReceiveable = new FrmAccReceiveable();
            FAccReceiveable.Show();
        }

        private void accountsPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccPayable FAccPayable = new FrmAccPayable();
            FAccPayable.Show();
        }

        private void creditPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJOPayment FJOPay = new FrmJOPayment();
            FJOPay.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmJOPayment FJOPay = new FrmJOPayment();
            FJOPay.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmPayVoucher FPayVoucher = new FrmPayVoucher();
            FPayVoucher.Show();
        }

        private void debitPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayVoucher FPayVoucher = new FrmPayVoucher();
            FPayVoucher.Show();
        }

        private void voucherPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmVoucherRep FVoucherRep = new FrmVoucherRep();
            //FVoucherRep.Show();
        }

        private void voucherPaymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVoucherSupList FVoucherSupList = new FrmVoucherSupList();
            FVoucherSupList.Show();
        }

        private void outstandingPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOutstanding FOutstanding = new FrmOutstanding();
            FOutstanding.Show();
        }

        private void supplierStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupStatement FSupStatement = new FrmSupStatement();
            FSupStatement.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmJOPayRecRep FPayRec = new FrmJOPayRecRep();
            FPayRec.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmVoucherRep FVoucherRep = new FrmVoucherRep();
            FVoucherRep.Show();
        }

        private void chequePaymentReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmChqPaymentReceived FChqPaymentReceived = new FrmChqPaymentReceived();
            //FChqPaymentReceived.Show();
        }

        private void chequePaymentPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmChqPaymentPaid FChqPaymentPaid = new FrmChqPaymentPaid();
            //FChqPaymentPaid.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmChqPaymentReceived FChqPaymentReceived = new FrmChqPaymentReceived();
            FChqPaymentReceived.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmChqPaymentPaid FChqPaymentPaid = new FrmChqPaymentPaid();
            FChqPaymentPaid.Show();
        }

        private void paymentReceivedCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJOPayCusList FJOPayCusList = new FrmJOPayCusList();
            FJOPayCusList.Show();
        }

        private void purchaseOrderSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPOSupList FPOSupList = new FrmPOSupList();
            FPOSupList.Show();
        }

        private void purchaseGRNSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGRNSupList FGRNSupList = new FrmGRNSupList();
            FGRNSupList.Show();
        }

        private void voucherPaymentsSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmVoucherSupList FVoucherSupList = new FrmVoucherSupList();
            //FVoucherSupList.Show();
        }

        private void issuedDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqPayDateList FChqPayDateList = new FrmChqPayDateList();
            FChqPayDateList.Show();
        }

        private void issuedBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqPayBankList FChqPayBankList = new FrmChqPayBankList();
            FChqPayBankList.Show();
        }

        private void invoiceDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Text = "Invoice Full Details Report";
            FInvRep.Show();
        }

        private void taxInvoiceDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Text = "Tax Invoice Full Details Report";
            FTaxInvRep.Show();
        }

        private void suspendedTaxInvoiceDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Text = "Suspended Tax Invoice Full Details Report";
            FSTaxInvRep.Show();
        }

        private void manufactureDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMInvRep FMInvRep = new FrmMInvRep();
            FMInvRep.Text = "Manufacture Invoice Full Details Report";
            FMInvRep.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocation FLocation = new FrmLocation();
            FLocation.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Text = "Invoice Full Details Report";
            FInvRep.Show();
        }

        private void LInvM_Click_1(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Text = "Tax Invoice Full Details Report";
            FTaxInvRep.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Text = "Suspended Tax Invoice Full Details Report";
            FSTaxInvRep.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmMInvRep FMInvRep = new FrmMInvRep();
            FMInvRep.Text = "Manufacture Invoice Full Details Report";
            FMInvRep.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            FrmChqPayBankList FChqPayBankList = new FrmChqPayBankList();
            FChqPayBankList.Show();
        }

        private void stockItemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            stockReportToolStripMenuItem_Click(null, null);
        }

        private void valueSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockValueReportToolStripMenuItem_Click(null, null);
        }

        private void qtySumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockQtyReportToolStripMenuItem_Click(null, null);
        }

        private void profitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryProfitToolStripMenuItem_Click(null, null);
        }

        private void sumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerSummaryToolStripMenuItem_Click_1(null, null);
        }

        private void statementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customerStatementsToolStripMenuItem_Click(null, null);
        }

        private void sumarryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplierSummaryToolStripMenuItem_Click_1(null, null);
        }

        private void statementToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            supplierStatementsToolStripMenuItem_Click(null, null);
        }

        private void customerWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customerWiseJobOrderToolStripMenuItem_Click_1(null, null);
        }

        private void paymentReceivedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paymentReceivedToolStripMenuItem_Click_1(null, null);
        }

        private void paymentReceivedCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paymentReceivedCustomerToolStripMenuItem_Click(null, null);
        }

        private void reconciliationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RecRM_Click(null, null);
        }

        private void chequeIssuedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem12_Click(null, null);
        }

        private void customerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7_Click(null, null);
        }

        private void supplierPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem8_Click(null, null);
        }

        private void fixedAssetsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fixedAssetSummaryToolStripMenuItem1_Click_1(null, null);
        }

        private void miscellaneousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            statementToolStripMenuItem_Click(null, null);
        }

        private void receivedJONoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receivedEntryToolStripMenuItem_Click_1(null, null);
        }

        private void receivedCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankWiseToolStripMenuItem_Click_1(null, null);
        }

        private void receivedDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerWiseToolStripMenuItem_Click_1(null, null);
        }

        private void issuedVoucherNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            branchWiseToolStripMenuItem_Click_1(null, null);
        }

        private void issuedSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequePaymentToolStripMenuItem_Click_1(null, null);
        }

        private void issuedDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            issuedDateToolStripMenuItem_Click(null, null);
        }

        private void issuedBankToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            issuedBankToolStripMenuItem_Click(null, null);
        }

        private void pOItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseReportToolStripMenuItem_Click_1(null, null);
        }

        private void pOSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseOrderSupplierToolStripMenuItem_Click(null, null);
        }

        private void gRNItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseGRNReportToolStripMenuItem_Click(null, null);
        }

        private void gRNSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseGRNSupplierToolStripMenuItem_Click(null, null);
        }

        private void jobOrderPaymentReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJOPayCusList FJOPayCusList = new FrmJOPayCusList();
            FJOPayCusList.Show();
        }

        private void transectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransection FTransection = new FrmTransection();
            FTransection.Show();
        }

        private void journalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJournalRep FJournalRep = new FrmJournalRep();
            FJournalRep.Show();
        }

        private void cashBookToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmCashbook FCashbook = new FrmCashbook();
            FCashbook.Show();
        }

        private void ledgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLedgerList FLedgerList = new FrmLedgerList();
            FLedgerList.Show();
        }

        private void trialBalanceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmTB FTB = new FrmTB();
            FTB.Show();
        }

        private void profitAndLossStatementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProLos FProLos = new FrmProLos();
            FProLos.Show();
        }

        private void balanceSheetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmBalanceSheet frmBalanceSheet = new FrmBalanceSheet();
            frmBalanceSheet.Show();
        }

        private void incomeStatementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmIncomeStatement FIncomeStatement = new FrmIncomeStatement();
            FIncomeStatement.Show();
        }

        private void accountsReceaveableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccReceiveable FAccReceiveable = new FrmAccReceiveable();
            FAccReceiveable.Show();
        }

        private void accountsPayableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAccPayable FAccPayable = new FrmAccPayable();
            FAccPayable.Show();
        }

        private void outstandingPayableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOutstanding FOutstanding = new FrmOutstanding();
            FOutstanding.Show();
        }

        private void NewMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void invoiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmInvoice FInvoice = new FrmInvoice();
            FInvoice.Show();
        }

        private void taxInvoiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmTxtInv1 FTxtInv1 = new FrmTxtInv1();
            FTxtInv1.Show();
        }

        private void suspendedTaxInvoiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmSTaxInv FSTaxInv = new FrmSTaxInv();
            FSTaxInv.Show();
        }

        private void manufactureInvoiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmMnuInv FMnuInv = new FrmMnuInv();
            FMnuInv.Show();
        }

        private void aPInvoiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void aRInvoiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void salesStaffToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmSStaff FSStaff = new FrmSStaff();
            FSStaff.Show();
        }

        private void invoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Text = "Invoice Full Details Report";
            FInvRep.Show();
        }

        private void taxInvoiceDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Text = "Tax Invoice Full Details Report";
            FTaxInvRep.Show();
        }

        private void sTaxInvoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Text = "Suspended Tax Invoice Full Details Report";
            FSTaxInvRep.Show();
        }

        private void gLAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGLAccount FGLAccount = new FrmGLAccount();
            FGLAccount.Show();
        }

        private void chartOfAccountsToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmChaOAcc FChaOAcc = new FrmChaOAcc();
            FChaOAcc.Show();
        }

        private void currencyRegistrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCrncy FCrncy = new FrmCrncy();
            FCrncy.Show();
        }

        private void currencyExchangeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCrncyExc FCrncyExc = new FrmCrncyExc();
            FCrncyExc.Show();
        }

        private void taxRegistrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmTaxReg FTaxReg = new FrmTaxReg();
            FTaxReg.Show();
        }

        private void pettycashToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPtyCsh FPtyCsh = new FrmPtyCsh();
            FPtyCsh.Show();
        }

        private void pettycashReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPtyCshRep FPtyCshRep = new FrmPtyCshRep();
            FPtyCshRep.Show();
        }

        private void iOUReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIOU FIOU = new FrmIOU();
            FIOU.Show();
        }

        private void iOUReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIOURep FIOURep = new FrmIOURep();
            FIOURep.Show();
        }

        private void journalEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmJournal FJournal = new FrmJournal();
            FJournal.Show();
        }

        private void journalReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJournalRep FJournalRep = new FrmJournalRep();
            FJournalRep.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransection FTransection = new FrmTransection();
            FTransection.Show();
        }

        private void cshBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCashbook FCashbook = new FrmCashbook();
            FCashbook.Show();
        }

        private void ledgersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLedgerList FLedgerList = new FrmLedgerList();
            FLedgerList.Show();
        }

        private void trialBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTB FTB = new FrmTB();
            FTB.Show();
        }

        private void profitAndLossStatementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProLos FProLos = new FrmProLos();
            FProLos.Show();
        }

        private void balanceSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBalanceSheet frmBalanceSheet = new FrmBalanceSheet();
            frmBalanceSheet.Show();
        }

        private void incomeStatementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIncomeStatement FIncomeStatement = new FrmIncomeStatement();
            FIncomeStatement.Show();
        }

        private void cashFlowStatementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCashFlow FCashFlow = new FrmCashFlow();
            FCashFlow.Show();
        }

        private void oP1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgPay1 FOgPay1 = new FrmOgPay1();
            FOgPay1.Show();
        }

        private void outgoingPayment2ToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmOgPay2 FOgPay2 = new FrmOgPay2();
            FOgPay2.Show();
        }

        private void jobOrderPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJOPayment FJOPay = new FrmJOPayment();
            FJOPay.Show();
        }

        private void paymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayVoucher FPayVoucher = new FrmPayVoucher();
            FPayVoucher.Show();
        }

        private void tTPaymentToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmTTPay FTTPay = new FrmTTPay();
            FTTPay.Show();
        }

        private void jobOrderPaymentReceivedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJOPayRecRep FPayRec = new FrmJOPayRecRep();
            FPayRec.Show();
        }

        private void voucherPaymentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVoucherRep FVoucherRep = new FrmVoucherRep();
            FVoucherRep.Show();
        }

        private void chequeReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqPaymentReceived FChqPaymentReceived = new FrmChqPaymentReceived();
            FChqPaymentReceived.Show();
        }

        private void chequeReceivedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChqPaymentPaid FChqPaymentPaid = new FrmChqPaymentPaid();
            FChqPaymentPaid.Show();
        }

        private void bankRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBank FBank = new FrmBank();
            FBank.Show();
        }

        private void bankReportToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void bankDetailsToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FrmBankDtl FBankDtl = new FrmBankDtl();
            FBankDtl.Show();
        }

        private void reconciliationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRecn FBankRecn = new FrmBankRecn();
            FBankRecn.Show();
        }

        private void reconciliationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRecnRep FBankRecnRep = new FrmBankRecnRep();
            FBankRecnRep.Show();
        }

        private void chequeIssuedBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqPayBankList FChqPayBankList = new FrmChqPayBankList();
            FChqPayBankList.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }
   

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show();
            //this.WindowState = FormWindowState.Normal;
            //notifyIcon.Visible = false;
        }

        private void FrmMain_Resize_1(object sender, EventArgs e)
        {
            //if(this.WindowState==FormWindowState.Minimized)
            //{
            //    Hide();           
            //    notifyIcon.Visible = true;               
            //}
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      
    }
}
