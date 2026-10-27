using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class pANEL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //show login panel and hide registeration panel
            Pnllogin.Visible = true;
            PnlRegistration.Visible = false;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //SHOW REGISTRATION PANEL AND HIDE LOGIN PANEL
            PnlRegistration.Visible = true;
            Pnllogin.Visible = false;

        }
    }
}