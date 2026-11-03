using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class EmployeePay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEmployeePay_Click(object sender, EventArgs e)
        {
            double basicPay,housingAllowance,transportAllowance,grossPay =0;
            string jobTitle = ddlJobTitle.SelectedItem.ToString();
            switch(jobTitle)
            {
                case "Engineer":
                    basicPay = 100000;
                    housingAllowance = 20000;
                    transportAllowance = 10000;

                    break;
                case "Intern":
                    basicPay = 50000;
                    housingAllowance = 10000;
                    transportAllowance = 5000;
                    break;
                case "DatabaseAdministrator":
                    basicPay = 120000;
                    housingAllowance = 25000;
                    transportAllowance = 15000;
                    break;
                default:
                    basicPay = 0;
                    housingAllowance = 0;
                    transportAllowance = 0;
                    break;
            }
            grossPay = basicPay + housingAllowance + transportAllowance;
            //display output
            lblBasic.Text = "Basic Pay: " + basicPay.ToString();
            lblHousing.Text = "Housing Allowance: " + housingAllowance.ToString();
            lblTransport.Text = "Transport Allowance: " + transportAllowance.ToString();
            lblGross.Text = "Gross Pay: " + grossPay.ToString();
        }
    }
}