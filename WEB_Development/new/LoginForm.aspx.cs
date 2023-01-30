using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Practice
{
	public partial class LoginForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            string cionstr = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString.ToString();
            SqlConnection con =new SqlConnection(cionstr);
            SqlCommand cmd = new SqlCommand("select* from employees where employeeid = @employeeid", con);
            con.Open();
            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                ddlEmployeeId.Items.Add(reader["EmployeeID"].ToString());
            }
    }

        protected void ddlEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int empId = Convert.ToInt16(ddlEmployeeId.SelectedValue);
            string cionstr = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(cionstr);
            SqlCommand cmd = new SqlCommand("select* from employees where employeeid = @employeeid", con);
            cmd.Parameters.AddWithValue("@emplyeeid", empId);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            txtFName.Text = reader["Firstname"].ToString();
            txtLName.Text = reader["Lastname"].ToString();
            txtAddress.Text = reader["Address"].ToString();
            reader.Close();
            con.Close();
        }
    }
}