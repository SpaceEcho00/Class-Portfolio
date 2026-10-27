using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class_Portfolio
{
    public partial class Checkbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
            //loop through selected item
            foreach(ListItem item in CheckBoxList1.Items)
            {
                if(item.Selected)//user has selected an item
                {
                    //add item to list box
                    LstBox.Items.Add(item.ToString());
                }
            }
            //DISPLAY TOTAL ITEMS
            Lbl2.Text="Total items added\t"+ LstBox.Items.Count;
        }
    }
}