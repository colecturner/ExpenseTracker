using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerWeb.Controllers
{
    public class Expenses : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
