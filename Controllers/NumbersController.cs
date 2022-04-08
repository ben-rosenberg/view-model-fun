using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Controllers
{

public class NumbersController : Controller
{
    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        int[] numbers = { 1, 6, 3, 5, 8, 12 };
        return View(numbers);
    }
}

}