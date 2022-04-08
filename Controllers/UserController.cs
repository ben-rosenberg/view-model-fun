using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{

public class UserController : Controller
{
    [HttpGet("/users")]
    public IActionResult Users()
    {
        return View(_Users);
    }

    [HttpGet("/user")]
    public IActionResult ShowUser()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _Users.Count);
        return View(_Users[randomNum]);
    }
        
    private List<User> _Users = new List<User> {
        new User("Ben", "Rosenberg"),
        new User("Daniel", "Rosenberg"),
        new User("Emily", "Keane")
    };
}

}