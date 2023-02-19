using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
	public class ArithmeticController : Controller
	{
		public IActionResult MTable(int from, int to) // fornumhttp://localhost:5260/Arithmetic/mtable?from=10$to=20
		{
			var x = (from, to);
			return View(x);
		}
	}
}
