using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace tinoshop_demo2.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
