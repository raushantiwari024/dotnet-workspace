using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInAsp.Models;
using ModelsInAsp.Repository;

namespace ModelsInAsp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStudent _studentRepo=null;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _studentRepo = new StudentRepo();
    }

    public List<StudentModel> GetAllStudents(int id)
    {
        return _studentRepo.GetAllStudents();
    }

    public StudentModel GetById(int id)
    {
        return _studentRepo.GetStudentById(id);
    }

    public IActionResult Index()
    {
        var students =new List<StudentModel>
        {
            new StudentModel{RollNo = 1,Name = "Raushan Tiwari", Standard = "MCA", Age = 22},
            new StudentModel{RollNo = 2,Name = "Ujjawal Tiwari", Standard = "B.Com", Age = 23},
            new StudentModel{RollNo = 3,Name = "Abhi Tiwari", Standard = "MCA", Age = 20},
            new StudentModel{RollNo = 4,Name = "Rohan", Standard = "MCA", Age = 22}
        };

        ViewData["students"] = students;
        return View();
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
