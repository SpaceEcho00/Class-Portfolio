using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace testproj
{
    public partial class viewStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string connectionString = ConfigurationManager
                        .ConnectionStrings["cueaConnectionString"].ConnectionString;
                    const string sql = "SELECT Regno, Name, Email, Gender, Mobile FROM dbo.student";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                    {
                        DataTable students = new DataTable();
                        adapter.Fill(students);
                        gvStudents.DataSource = students;
                        gvStudents.DataBind();
                    }
                }
                catch (SqlException)
                {
                    gvStudents.EmptyDataText = "Unable to load student records because of a database error.";
                    gvStudents.DataSource = new DataTable();
                    gvStudents.DataBind();
                }
            }
        }
    }
}