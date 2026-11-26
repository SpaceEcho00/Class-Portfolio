using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace testproj
{
    public partial class dashbar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            if (!(Session["Regno"] is int))
            {
                Response.Redirect("~/userAuthentication.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            try
            {
                const string sql = "SELECT Name FROM dbo.student WHERE Regno = @Regno";
                string connectionString = ConfigurationManager
                    .ConnectionStrings["cueaConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Regno", SqlDbType.Int).Value = (int)Session["Regno"];
                    connection.Open();
                    object name = command.ExecuteScalar();
                    if (name == null || name == DBNull.Value)
                    {
                        Session.Remove("Regno");
                        Response.Redirect("~/userAuthentication.aspx", false);
                        Context.ApplicationInstance.CompleteRequest();
                        return;
                    }

                    litWelcome.Text = "Welcome, " + Convert.ToString(name);
                }
            }
            catch (SqlException)
            {
                lblDashboardMessage.Text = "Unable to load your dashboard because of a database error.";
                lblDashboardMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}