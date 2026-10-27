using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFullName_Click(object sender, EventArgs e)
        {



        }

        protected void btnCompletePay_Click(object sender, EventArgs e)
        {

            //declare program constants
            const double FA = 40000, PAYE = 0.3, SHA = 0.025, HL = 0.015, NSSF = 0.06;
            //DECLARE VARIABLES
            double grossPay, netPay, overTimePay = 0, overTimeHours;
            overTimeHours = Convert.ToDouble(TxtOHours.Text);
            if (overTimeHours >= 0 && overTimeHours <= 5)
            {
                overTimePay = overTimeHours * 1500;
            }
            else if (overTimeHours > 5)
            {
                overTimePay = overTimeHours * 2000;
            }
            //compute gross pay
            grossPay = FA + overTimePay;
            //compute net pay
            netPay = grossPay - ((PAYE * grossPay) + (SHA * grossPay) + (HL * grossPay) + (NSSF * grossPay));
            //display program output
            LitFixedAllowance.Text = "Fixed allowance\t" + FA;
            litOverTimePay.Text = "OverTime Pay\t" + overTimePay;
            litGrossPay.Text = "Gross Pay\t" + grossPay;
            litPaye.Text = "PAYE Amount\t" + PAYE + grossPay;
            LitSha.Text = "SHA Amount\t" + SHA + grossPay;
            litHousinglevy.Text = "Housing Levy Amount\t" + HL + grossPay;
            litNSSF.Text = "NSSF Amount\t" + NSSF + grossPay;
            litNetPay.Text = "Net pay\t" + netPay;


            

        }
    }
}