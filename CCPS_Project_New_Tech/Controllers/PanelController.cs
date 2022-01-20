using Microsoft.AspNetCore.Mvc;

namespace CCPS_Project_New_Tech.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
