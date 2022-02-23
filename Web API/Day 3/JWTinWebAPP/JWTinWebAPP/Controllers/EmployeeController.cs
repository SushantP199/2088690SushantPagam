using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using JWTinWebAPP.Models;
using Newtonsoft.Json;

namespace JWTinWebAPP.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HttpClient httpClient;

        public EmployeeController(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient("employeeAPI");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IActionResult> Index()
        {
            var response = await httpClient.GetAsync("api/Employee");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(json);

            return View(employees);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var json = JsonConvert.SerializeObject(employee);

            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/Employee", content);
            response.EnsureSuccessStatusCode();

            return (response.IsSuccessStatusCode) ? RedirectToAction("Index", "Employee") : new EmptyResult();
        }
    }
}
