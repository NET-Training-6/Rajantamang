using Microsoft.EntityFrameworkCore;
using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Data;

public class WorkforceContext: DbContext
{
	public DbSet<Employee> Employees { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Work-forceManage;Integrated Security=true;");
	}

}
