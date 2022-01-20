using Microsoft.AspNetCore.Mvc;
using CCPS_Project_New_Tech.Data;
using CCPS_Project_New_Tech.Models;

namespace CCPS_Project_New_Tech.Controllers
{
    public class ListeDeTousLesEtudiantsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ListeDeTousLesEtudiantsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Personne> objPersonneList = _db.Personnes.ToList();
            return View(objPersonneList);
        }
    }
}
