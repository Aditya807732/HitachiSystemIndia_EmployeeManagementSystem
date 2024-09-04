using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Employeemanagement
{
    public partial class Employee : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Employeemanagementsyatem_dbConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Employees (EmployeeId,FirstName, LastName, Email, Department, Salary) VALUES (@EmployeeId,@FirstName, @LastName, @Email, @Department, @Salary)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", txtEmployeeId.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Employeemanagementsyatem_dbConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Employees SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Department=@Department, Salary=@Salary WHERE EmployeeID=@EmployeeID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeId.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            GridView1.DataBind(); 
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Employeemanagementsyatem_dbConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeId.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            GridView1.DataBind(); 
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            
            txtEmployeeId.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";
        }
    }
}
