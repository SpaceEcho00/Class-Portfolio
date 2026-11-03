using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class FindJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnJobs_Click(object sender, EventArgs e)
        {
            string jcategory=ddlSelectJobCategory.SelectedItem.ToString();
            string jLocation = ddlLocation.SelectedItem.ToString();
            string jType = ddlJobType.SelectedItem.ToString();
            string result=" ";
            bool find=false;
            if (jcategory == "Accounting" && jLocation=="Mombasa" && jType == "Contract")
            {
                result = "Company\t: Blue Fish\tSalary:120,000";
                find = true;

            }
            else if(jcategory == "IT" && jLocation == "Nairobi" && jType == "Contract")
            {
                result = "Company\t: Safaricom\tSalary:200,000";
                find= true;

            }
            else if (jcategory == "Accounting" && jLocation == "Nairobi" && jType == "Fulltime")
            {
                result = "Company\t: PwC\tSalary:350,000";
                find = true;
            }
            else
            {
                result = "Search operation didnt yield any results";
                find = false;
            }
            if (find == true)
            {
                lblJobCategory.ForeColor=System.Drawing.Color.Green;
                lblJobCategory.Text = result;
            }
            else
            {
                lblJobCategory.ForeColor = System.Drawing.Color.Red;
                lblJobCategory.Text= result;
            }
            //display output
            lblJobCategory.Text = result;
        }
    }
}