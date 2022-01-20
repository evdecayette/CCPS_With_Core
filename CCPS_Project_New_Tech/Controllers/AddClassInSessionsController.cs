using CCPS_Project_New_Tech.Data;
using CCPS_Project_New_Tech.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCPS_Project_New_Tech.Controllers
{
    public class AddClassInSessionsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AddClassInSessionsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            
            return View();  
            
        }
       
    }
}
