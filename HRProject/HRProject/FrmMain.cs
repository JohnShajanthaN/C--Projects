using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void basicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpBasicInfo FEmpBasicInfo = new FrmEmpBasicInfo();
            FEmpBasicInfo.Show();
        }

        private void qualificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQualification FQualification = new FrmQualification();
            FQualification.Show();
        }

        private void previousWorkExperenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWorkExp FWorkExp = new FrmWorkExp();
            FWorkExp.Show();
        }

        private void medicalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicalInfo FMedicalInfo = new FrmMedicalInfo();
            FMedicalInfo.Show();
            
        }

        private void phycicalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhysicalInfo FPhysicalInfo = new FrmPhysicalInfo();
            FPhysicalInfo.Show();
        }

        private void bankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBank FBank = new FrmBank();
            FBank.Show();
        }

        private void sportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSports FSports = new FrmSports();
            FSports.Show();
        }

        private void nonRelatedReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNonRelRef FNonRelRef = new FrmNonRelRef();
            FNonRelRef.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDept FDept = new FrmDept();
            FDept.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupervisor FSupervisor = new FrmSupervisor();
            FSupervisor.Show();
        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAttendance FAttendance = new FrmAttendance();
            FAttendance.Show();
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLeave FLeave = new FrmLeave();
            FLeave.Show();
        }

        private void overTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOT FOT = new FrmOT();
            FOT.Show();
        }

        private void shortLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShortLeave FShortLeave = new FrmShortLeave();
            FShortLeave.Show();
        }

        private void basicSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBasicSal FBasicSal = new FrmBasicSal();
            FBasicSal.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayment FPayment = new FrmPayment();
            FPayment.Show();
        }

        private void deductionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeduction FDeduction = new FrmDeduction();
            FDeduction.Show();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoan FLoan = new FrmLoan();
            FLoan.Show();
        }

        private void ePFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEPF FEPF = new FrmEPF();
            FEPF.Show();
        }

        private void employeeBasicSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBasicSalRep FBasicSalRep = new FrmBasicSalRep();
            FBasicSalRep.Show();
        }

        private void employeeQualificationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmQualificationRep FQualificationRep = new FrmQualificationRep();
            FQualificationRep.Show();
        }

        private void employeeMedicalReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMedicalInformationRep FMedicalRep = new FrmMedicalInformationRep();
            FMedicalRep.Show();
        }

        private void bankDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void employeeFullDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void departmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeptRep FDeptRep = new FrmDeptRep();
            FDeptRep.Show();
        }

        private void suppervisorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupervisorRep FSupervisorRep = new FrmSupervisorRep();
            FSupervisorRep.Show();
        }

        private void attendanceDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAttendanceRep FAttendanceRep = new FrmAttendanceRep();
            FAttendanceRep.Show();
        }

        private void leaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLeaveRep FLeaveRep = new FrmLeaveRep();
            FLeaveRep.Show();
        }

        private void overTimeSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOTRep FOTRep = new FrmOTRep();
            FOTRep.Show();
        }

        private void shortLeaveSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShortLeave FShortLeave = new FrmShortLeave();
            FShortLeave.Show();
        }

        private void shiftDutyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShift FShift = new FrmShift();
            FShift.Show();
        }

        private void paymentCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaymentCreation FPaymentCreation = new FrmPaymentCreation();
            FPaymentCreation.Show();
        }

        private void deductionCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeductionCreation FDeductionCreation = new FrmDeductionCreation();
            FDeductionCreation.Show();
        }

        private void adjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdjustment FAdjustment = new FrmAdjustment();
            FAdjustment.Show();
        }

        private void myTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMyTask FMyTask = new FrmMyTask();
            FMyTask.Show();
        }

        private void dailyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDailyPlan FDailyPlan = new FrmDailyPlan();
            FDailyPlan.Show();
        }

        private void taskCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTask FTask = new FrmTask();
            FTask.Show();
        }

        private void officeUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOffice1 FOffice = new FrmOffice1();
            FOffice.Show();
        }
    }
}
