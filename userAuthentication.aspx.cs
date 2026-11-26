using Class_Portfolio.DataSet1TableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace testproj
{
    public partial class userAuthentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session.Remove("Regno");
            lblLogin.Text = string.Empty;

            int regno;
            if (!int.TryParse(txtRegNo.Text.Trim(), out regno) ||
                string.IsNullOrWhiteSpace(txtPasswd.Text))
            {
                lblLogin.Text = "Enter a valid Registration Number and Password";
                lblLogin.ForeColor = System.Drawing.Color.Red;
                lblLogin.Font.Bold = true;
                return;
            }

            try
            {
                DataTable dt;
                using (studentTableAdapter login = new studentTableAdapter())
                {
                    dt = login.GetData(txtPasswd.Text, regno);
                }

                if (dt.Rows.Count > 0)
                {
                    Session["Regno"] = regno;
                    Response.Redirect("~/dashbar.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    lblLogin.Text = "Login failed. Check your Registration Number and Password.";
                    lblLogin.ForeColor = System.Drawing.Color.Red;
                    lblLogin.Font.Bold = true;
                }
            }
            catch (SqlException)
            {
                lblLogin.Text = "Unable to complete login because of a database error";
                lblLogin.ForeColor = System.Drawing.Color.Red;
                lblLogin.Font.Bold = true;
            }
        }
    }
}