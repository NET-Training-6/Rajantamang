using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

}