using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class dropdownlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nationality = " ";
            if (ddlNationality.SelectedItem != null)
            {
                nationality = ddlNationality.SelectedItem.ToString();
            }
            lblNationality.Text = "Your nationality is" +nationality;
        }
    }
}