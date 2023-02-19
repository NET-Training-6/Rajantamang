using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Diagnostics;
using WorkForceManagement.web.Data;
using WorkForceManagement.web.Enum;
using WorkForceManagement.web.Helpers;
using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Controllers;

public class EmployeesController : Controller
{
	WorkforceContext dbContext = new WorkforceContext();
	public IActionResult Index()
	{		
		List<Employee> employees = dbContext.Employees.ToList();
		return View(employees);
	}
	public IActionResult Details(int Id)
	{
		var employee= dbContext.Employees.Find(Id);
		return View(employee); 
	}
	[HttpGet]
	public IActionResult Add()
	{
		return View();
	}

	[HttpPost]
    public IActionResult Add(Employee employee)
    {
		var relativePath = ImageHelper.SaveImage(employee.ProfileImage);
		employee.ProfileImagePath = relativePath;
        dbContext.Employees.Add(employee);
		dbContext.SaveChanges();

		return RedirectToAction("Index");

    }

	public	IActionResult Edit(int Id)
	{
		var employee = dbContext.Employees.Find(Id);
		return View(employee);

	}

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        var relativePath1 = ImageHelper.SaveImage(employee.ProfileImage);
        employee.ProfileImagePath = relativePath1;
        dbContext.Employees.Update(employee);
        dbContext.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int Id)
    {

        var employee = dbContext.Employees.Find(Id);
        return View(employee);

    }
	[HttpPost]
    public IActionResult Delete(Employee employee)
    {
		dbContext.Employees.Remove(employee);
        dbContext.SaveChanges();
        return RedirectToAction("Index");

    }



    public IActionResult GetData()
	{
		List<Employee> employees = new List<Employee>();
		string connectionString ="Data Source=(localdb)\\mssqllocaldb;Initial Catalog=WorkForce_Test;Integrated Security=true";

		// Provide the query string with a parameter placeholder.
		string queryString ="SELECT * from dbo.employee ";

		// Specify the parameter value.
		

		// Create and open the connection in a using block. This
		// ensures that all resources will be closed and disposed
		// when the code exits.
		using (SqlConnection connection =new SqlConnection(connectionString))
		{
			// Create the Command and Parameter objects.
			SqlCommand command = new SqlCommand(queryString, connection);
			

			// Open the connection in a try/catch block.
			// Create and execute the DataReader, writing the result
			// set to the console window.
			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					var employee = new Employee()
					{
						Id = reader.GetInt32(0),
						Name = reader.GetString(1),
						Address = reader.GetString(2),
						Dob = reader.GetDateTime(4),
						Contact = reader.GetString(5)
					};
				 employees.Add(employee);
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}
		return View(employees);
	}

	
}
