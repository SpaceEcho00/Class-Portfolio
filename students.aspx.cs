using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace testproj
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblSave.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtRegNo.Text) ||
                string.IsNullOrWhiteSpace(txtSName.Text) ||
                string.IsNullOrWhiteSpace(txtSEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPasswd.Text) ||
                string.IsNullOrWhiteSpace(txtCPasswd.Text))
            {
                ShowError("Please fill in all required fields");
                return;
            }

            if (txtSName.Text.Trim().Length > 50 || txtMNo.Text.Trim().Length > 15)
            {
                ShowError("Name must be at most 50 characters and Mobile at most 15 characters");
                return;
            }

            if (rblGender.SelectedItem == null)
            {
                ShowError("Please select a gender");
                return;
            }

            if (txtPasswd.Text != txtCPasswd.Text)
            {
                ShowError("Passwords do not match");
                return;
            }

            int regno;
            if (!int.TryParse(txtRegNo.Text.Trim(), out regno))
            {
                ShowError("Registration Number must be numeric");
                return;
            }

            const string sql = "INSERT INTO student (Regno, Name, Email, Gender, Mobile, Passwd) " +
                               "VALUES (@Regno, @Name, @Email, @Gender, @Mobile, @Passwd)";

            try
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["cueaConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    string name = txtSName.Text.Trim();
                    string email = txtSEmail.Text.Trim();
                    string gender = rblGender.SelectedItem.Text;
                    string mobile = txtMNo.Text.Trim();

                    command.Parameters.Add(new SqlParameter("@Regno", SqlDbType.Int)
                    {
                        Value = regno
                    });
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, -1).Value = email;
                    command.Parameters.Add("@Gender", SqlDbType.VarChar, 6).Value = gender;
                    command.Parameters.Add("@Mobile", SqlDbType.VarChar, 15).Value =
                        string.IsNullOrEmpty(mobile) ? (object)DBNull.Value : mobile;
                    command.Parameters.Add("@Passwd", SqlDbType.VarChar, -1).Value = txtPasswd.Text;

                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                    {
                        lblSave.Text = "Record saved successfully in the database";
                        lblSave.ForeColor = System.Drawing.Color.Green;

                        txtRegNo.Text = string.Empty;
                        txtSName.Text = string.Empty;
                        txtSEmail.Text = string.Empty;
                        rblGender.ClearSelection();
                        txtMNo.Text = string.Empty;
                        txtPasswd.Text = string.Empty;
                        txtCPasswd.Text = string.Empty;
                    }
                    else
                    {
                        lblSave.Text = "The record was not saved";
                        lblSave.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (SqlException ex)
            {
                ShowError(ex.Number == 2627 || ex.Number == 2601
                    ? "Registration Number already exists"
                    : "Unable to save the record because of a database error");
            }
        }

        private void ShowError(string message)
        {
            lblSave.Text = message;
            lblSave.ForeColor = System.Drawing.Color.Red;
        }
    }
}