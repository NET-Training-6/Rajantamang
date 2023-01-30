using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }

    public class DropdownController : Controller
    {
        public ActionResult Items()
        {
            // Logic to retrieve items for the dropdown menu
            List<DropdownItem> items = new List<DropdownItem>
            {
                new DropdownItem { Name = "Item 1", Link = "#1" },
                new DropdownItem { Name = "Item 2", Link = "#2" },
                new DropdownItem { Name = "Item 3", Link = "#3" },
            };
            return View(items);
        }
    }

    public class DropdownItem
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
}

