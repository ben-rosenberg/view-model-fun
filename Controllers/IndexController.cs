using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Controllers
{

public class IndexController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        string message = "This is the message.";
        return View("Index", message);
    }
}

}