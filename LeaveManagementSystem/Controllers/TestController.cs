using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Brian",
                DateOfBirth = new DateTime(1990, 1, 1)
            };
            return View(data);
        }

    }
}
