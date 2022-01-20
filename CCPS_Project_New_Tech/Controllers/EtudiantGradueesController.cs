using CCPS_Project_New_Tech.Data;
using CCPS_Project_New_Tech.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCPS_Project_New_Tech.Controllers
{
    public class EtudiantGradueesController : Controller
    {
        private readonly ApplicationDbContext _db1;

        public EtudiantGradueesController(ApplicationDbContext db1)
        {
            _db1 = db1;
        } 

        public IActionResult Index()
        {
            IEnumerable<Gradues> objGradueList = _db1.Gradues.ToList();
            return View(objGradueList);
        }
    }
}
