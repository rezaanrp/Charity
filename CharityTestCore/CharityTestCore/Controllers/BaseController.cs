using CharityTestCore.Repository;
using CharityTestCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CharityTestCore.Controllers
{
    public class BaseController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
