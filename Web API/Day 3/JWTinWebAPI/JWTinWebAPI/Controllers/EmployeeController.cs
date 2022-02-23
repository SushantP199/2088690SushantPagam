using JWTinWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JWTinWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly GenericRepository<Employee> employeeRepository;

        public EmployeeController()
        {
            employeeRepository = new GenericRepository<Employee>();
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = employeeRepository.Get();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = employeeRepository.Get(e => e.Id == id).FirstOrDefault();
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            employeeRepository.Add(employee);
            int row = await employeeRepository.SaveAsync();

            return (row > 0) ? Ok(row) : BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            employeeRepository.Update(employee);
            int row = await employeeRepository.SaveAsync();

            return (row > 0) ? Ok(row) : BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = employeeRepository.Get(e => e.Id == id).FirstOrDefault();

            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                employeeRepository.Delete(employee);
                int row = await employeeRepository.SaveAsync();

                return (row > 0) ? Ok(row) : BadRequest();
            }
        }
    }
}
