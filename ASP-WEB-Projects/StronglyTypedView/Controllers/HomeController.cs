using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedView.Models;

namespace StronglyTypedView.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // This way is called Strongly Typed View
        // Employee emp = new Employee()
        // {
        //     EmpId = 1,
        //     EmpName = "Raushan Tiwari",
        //     EmpDesignation = "Developer",
        //     EmpAddress = "Bagaha",
        //     EmpSalary = 54000
        // };

        List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmpId = 1,EmpName = "Raushan Tiwari",EmpDesignation = "Developer",EmpAddress = "Bagaha",EmpSalary = 54000},
            new Employee(){EmpId = 2,EmpName = "Ujjawal Tiwari",EmpDesignation = "Developer",EmpAddress = "Bagaha",EmpSalary = 34000},
            new Employee(){EmpId = 3,EmpName = "Abhishek",EmpDesignation = "Network Marketing",EmpAddress = "Delhi",EmpSalary = 24000},
            new Employee(){EmpId = 4,EmpName = "Nikhil Kumar",EmpDesignation = "Researcher",EmpAddress = "Bijnor",EmpSalary = 53000},
            new Employee(){EmpId = 5,EmpName = "Zunaid",EmpDesignation = "Developer",EmpAddress = "Narkatiyaganj",EmpSalary = 50000},
            
        };

        // In strongly typed view, Parameter is passes as View
        return View(employees);
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
