using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class radiobutton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChoice=" ";
            if (RadioButtonList.SelectedItem != null)
            {
                
               selectedChoice = RadioButtonList.SelectedItem.Text;
            }
            lblPayment.Text = "Selected mode of payment "+selectedChoice;
        }
    }
}