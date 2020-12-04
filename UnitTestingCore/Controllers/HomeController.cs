using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnitTestingCore.Models;

namespace UnitTestingCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeInterface employee;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public HomeController()
        {

        }
        public HomeController(IEmployeeInterface _employee)
        {
            employee = _employee;
        }
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Arpit",
                IsExist = true
            };
            return View("Index", employee);
        }

        public string GetEmployeeById(int id)
        {
            return employee.GetEmployeeById(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }
    }
}
