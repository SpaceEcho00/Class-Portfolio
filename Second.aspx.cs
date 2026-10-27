using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class Second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click()
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBPay.Text))
            {
                lblError.Text = "Please provide basic pay";
                lblError.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else if (string.IsNullOrEmpty(TxtCallowance.Text))
            {
                lblError.Text = "please provide commuter allowance";
                lblError.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else if (string.IsNullOrEmpty(TxtHallowance.Text))
            {
                lblError.Text = "please provide house allowance";
                lblError.ForeColor = System.Drawing.Color.Red;
                return;
            }

            else
            {
                //declare program variables
                double bpay, callowance, hallowance, gpay, npay;
                //assign variables values
                bpay = Convert.ToSingle(TxtBPay.Text);
                callowance = Convert.ToSingle(TxtCallowance.Text);
                hallowance = Convert.ToSingle(TxtHallowance.Text);
                //compute gross pay
                gpay = bpay + callowance + hallowance;
                //compute net pay
                npay = 0.2 * gpay;
                //display program output
                lblGrosspay.Text = "Your gross pay is\t" + gpay;
                lblNetpay.Text = "Your Net pay is\t" + npay;
                lblError.Visible = false;
            }


        }
    }
}