using CCPS_Project_New_Tech.Data;
using CCPS_Project_New_Tech.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCPS_Project_New_Tech.Controllers
{
    public class PersonneController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PersonneController(ApplicationDbContext db)
        {
            _db = db;
        } 

        public IActionResult Index()
        {
            IEnumerable<Personne> objPersonneList = _db.Personnes.ToList();
            return View(objPersonneList);  
        }

        //GET Action Methode
        public IActionResult Create()
        {
            return View();
        }

        //Post Action Methode
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Personne obj)
        {
            if(ModelState.IsValid)
            {
                ViewBag.statut = obj.Statut;
                ViewBag.adminStaff = obj.AdminStaff;

                if (ViewBag.statut == "Etudiant")
                    {
                       if(ViewBag.adminStaff == 1)
                        {
                            obj.Etudiant = 1;
                            obj.Statut = "Etudiant et Staff";
                            _db.Personnes.Add(obj);
                            _db.SaveChanges();
                            return RedirectToAction("Index", "AjouterEtudiantDansClasse");
                        }
                       else
                         {
                            obj.Etudiant = 1;
                            obj.Statut = "Etudiant";
                            _db.Personnes.Add(obj);
                            _db.SaveChanges();
                            return RedirectToAction("Index", "AjouterEtudiantDansClasse");
                         }
                    }

                else if (ViewBag.statut == "Professeur")
                {
                   if (ViewBag.adminStaff == 1)
                    {
                        obj.Professeur = 1;
                        obj.Statut = "Professeur et Staff";
                        _db.Personnes.Add(obj);
                        _db.SaveChanges();
                        return RedirectToAction("Create");
                    }
                    else 
                        {
                            obj.Professeur = 1;
                            obj.Statut = "Professeur";
                            obj.AdminStaff = 0;
                            _db.Personnes.Add(obj);
                            _db.SaveChanges();
                            return RedirectToAction("Create");
                    }                       
                }
               else if(obj.Etudiant == 0 && obj.Professeur == 0)
                {
                    obj.Etudiant = 0;
                    obj.Professeur = 0;
                    obj.Statut = "Staff";
                    _db.Personnes.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Create");
                }       
            }

            return View(obj);
            
        } 

        //GET Action Methode
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var personneFromDb = _db.Personnes.Find(id);
            //var personneFromDbFirst = _db.Personnes.FirstOrDefault(u=>u.personneID== id);
            //var personneFromDbSingle = _db.Personnes.SingleOrDefault(u=>u.personneID== id);
            if(personneFromDb == null)
            {
                return NotFound();
            }

            return View(personneFromDb);
        } 

        //Post Action Methode
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Personne obj)
        {
            if (ModelState.IsValid)
            {
                _db.Personnes.Update(obj);  
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        //GET Action Methode
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var personneFromDb = _db.Personnes.Find(id);
            //var personneFromDbFirst = _db.Personnes.FirstOrDefault(u=>u.personneID== id);
            //var personneFromDbSingle = _db.Personnes.SingleOrDefault(u=>u.personneID== id);
            if (personneFromDb == null)
            {
                return NotFound();
            }

            return View(personneFromDb);
        }

        //Post Action Methode
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost (int? id)
        {
           var obj = _db.Personnes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Personnes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    } 
}
