using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if(ImageButton1.ImageUrl=="~/Images/imaes.jpg")
            {
                ImageButton1.ImageUrl = "~/Images/images.jpg";
                return;
            }
            if (ImageButton1.ImageUrl == "~/Images/images.jpg")
            {
                ImageButton1.ImageUrl = "~/Images/imags.jpg";
                return;
            }
            if (ImageButton1.ImageUrl == "~/Images/imags.jpg")
            {
                ImageButton1.ImageUrl = "~/Images/imaes.jpg";
                return;
            }
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            if (ImageButton1.ImageUrl == "~/Images/imags.jpg")
            {
                ImageButton1.ImageUrl = "~/Images/images.jpg";
                return;
            }
            if (ImageButton1.ImageUrl == "~/Images/images.jpg")
            {
                ImageButton1.ImageUrl = "~/Images/imaes.jpg";
                return;
            }
            if (ImageButton1.ImageUrl == "~/Images/imaes.jpg")
            {
                ImageButton1.ImageUrl = "~/Images/imags.jpg";
                return;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            }
        }
    }
}