using Microsoft.AspNetCore.Mvc;
using PartialViewToReuseEmployeeList.Models;

namespace PartialViewToReuseEmployeeList.Controllers
{
    public class EmployeeController : Controller
    {
        public List<Employee> emplist = new List<Employee>
            {
                new Employee{Id=1,Name="John",Salary=10000,IsPermanent=true},
                new Employee{Id=2,Name="Mary",Salary=20000,IsPermanent=false},
                new Employee { Id = 3, Name = "Clare", Salary = 30000, IsPermanent = true },
                new Employee { Id = 4, Name = "Michel", Salary = 40000, IsPermanent = false }
            };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetEmployeeList()
        {
            return View(emplist);
        }
        public IActionResult GetEmpById(int Id)
        {
            var emp = emplist.Find(m => m.Id == Id);
            if (emp != null)
                return View(emp);
            else
                return GetEmployeeList();
        }

        public IActionResult DeleteConfirmation(int Id)
        {
            var emp = emplist.Find(m => m.Id == Id);
            return View(emp);
        }

        public IActionResult DeleteEmpById(int Id)
        {
            var emp = emplist.Find(m => m.Id == Id);
            emplist.Remove(emp);
            return View("GetEmployeeList", emplist);
        }
    }
}
