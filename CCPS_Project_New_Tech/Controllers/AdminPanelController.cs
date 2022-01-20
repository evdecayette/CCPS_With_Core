using CCPS_Project_New_Tech.Data;
using CCPS_Project_New_Tech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace CCPS_Project_New_Tech.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminPanelController(ApplicationDbContext db)

        {
            _db = db;
        }
        public IActionResult Index()
        {
           return View();
        }
     

        public IActionResult SessionCreat()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CreerSession obj)
        {
            if (ModelState.IsValid)
            {
                _db.CreerSessions.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult AddClasseInSession()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClasseInSession(Classes addClasse)
        {
            if (ModelState.IsValid)
            {
                await _db.Classes.AddAsync(addClasse);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(AddClasseInSession));

            }

            return View(addClasse);
        }

        // AddNewSalles Get
        public IActionResult AddNewSalles()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewSalles(SalleDeClasses obj)
        {
            if (ModelState.IsValid)
            {
                _db.SalleDeClasses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("AddNewSalles");
            }
            return View(obj);
        }

        // AddJourDeClasse Get
        public IActionResult AddJourDeClasse()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddJourDeClasse(JoursDeClasses obj)
        {
            if (ModelState.IsValid)
            {
                _db.JoursDeClasses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("AddJourDeClasse");
            }
            return View(obj);
        }


        // AddHeureDeClasse Get
        public IActionResult AddHeurDeClasse()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddHeurDeClasse(HeuresDeClasses obj)
        {
            if (ModelState.IsValid)
            {
                _db.HeuresClasse.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("AddHeurDeClasse");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult ChoixProfesseur()
        {
           
            List<SelectListItem> Prof = (from Personne in _db.Personnes
                                             select new SelectListItem
                                             {
                                                 Text = Personne.Prenom + " " + Personne.Nom,
                                                 Value = Personne.Professeur.ToString()
                                             }).ToList();
           
                ViewBag.Personne = Prof;
                return View();            
        }

        //[HttpPost]
        //public IActionResult ChoixProfesseur(string lstProf)
        //{
        //   var profs = (from Personne in _db.Personnes
        //                 select new SelectListItem
        //                 {
        //                     Text = Personne.Nom,
        //                     Value = Personne.Professeur.ToString()
        //                 }).ToList();
        //    ViewBag.Personne = profs;
        //    string[] PersonneIds = Request.Form["lstProf"].ToString().Split(",");
        //    foreach(string id in PersonneIds)
        //    {
        //        if (!string.IsNullOrEmpty(id))
        //        {
        //            string name = ((List<SelectListItem>)ViewBag.Personne)
        //                .Where(x => x.Value == "1").FirstOrDefault().Text;
        //            ViewBag.Message += "Id: " + id + "Prof Name: " + name + "\\n";
        //        }
        //    }
        //    return View();
        //}
 
        public IActionResult AddAnonce()
        {
            return View();
        }
        public IActionResult EditerUneSession()
        {
            return View();
        }
    }
}
