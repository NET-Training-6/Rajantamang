using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //List of students
            Student student1 = new()
            {
                Name = "Ram",
                Address = "KTM",
                Email = "Ram@gmail.com",
                Gender = Sex.Male,
				Dob = DateTime.Now
			};

            Student student2 = new()
            {
                Name = "RamHari",
                Address = "Bhaktapur",
				Email = "RamHari@gmail.com",
                Gender = Sex.Male,
                Dob =  DateTime.Now
            };

            Student student3 = new()
            {
                Name = "Shiya",
                Address = "lalitpur",
                Email = "Shiya@gmail.com",
				Gender = Sex.Female,
				Dob = DateTime.Now
			};

            List<Student> students = new() { student1, student2, student3 };
            return View(students);
        }

        public IActionResult Test()
        {
			int[] numbers = { 9, 8, 4, 3, 1, 2, 1, 3, 0, 9 };
			return View(numbers);
        }
    }
 }

