using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Employeemanagement
{
    public partial class Logintab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string connectionString = "Data Source=LAPTOP-DCONSQOA\\SQLEXPRESS;Initial Catalog=Employeemanagementsyatem_db;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Logincredentials WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text); 

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                           
                            Response.Redirect("Employee.aspx");
                        }
                        else
                        {
                           
                            lblError.Visible = true;
                            lblError.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (Exception )
            {
                
                lblError.Visible = true;
                lblError.Text = "An error occurred while processing your request. Please try again later.";
            }
        }
    }
}

