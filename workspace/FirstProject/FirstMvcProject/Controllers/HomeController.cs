using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMvcProject.Models;

namespace FirstMvcProject.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View("MyView");
    }
}
