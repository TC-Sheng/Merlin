using Microsoft.AspNetCore.Mvc;
using Merlin.Models;

namespace Merlin.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(UserForm form)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", form);
            }
            return View("Success", form);
        }
    }
} 