using Microsoft.AspNetCore.Mvc;
using LandonWebsite06.Models;
using LandonWebsite06.Data;
using System.Linq;

namespace LandonWebsite06.Controllers
{
    /// <summary>
    /// Manages convention exhibitor companies.
    /// Supports listing, adding, editing, and removing companies from the database.
    /// </summary>
    public class CompaniesController : Controller
    {
        private readonly MyDBContext _context;

        public CompaniesController(MyDBContext context)
        {
            _context = context;
        }

        // GET /Companies/ListAll — Display all registered exhibitors
        public IActionResult ListAll()
        {
            return View("ListAll", _context.Companies.ToList());
        }

        // GET /Companies/Add — Show the add-company form
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST /Companies/Add — Save a new exhibitor, with duplicate booth validation
        [HttpPost]
        public IActionResult Add(Companies company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }

            // Reject duplicate booth numbers so each company has a unique location
            if (_context.Companies.Any(c => c.boothnumber == company.boothnumber))
            {
                ModelState.AddModelError("boothnumber",
                    $"Booth {company.boothnumber} is already taken. Please choose a different number.");
                return View(company);
            }

            _context.Companies.Add(company);
            _context.SaveChanges();
            TempData["CompanySuccess"] = $"{company.companyName} was added to the exhibitor list.";
            return RedirectToAction("ListAll");
        }

        // GET /Companies/Edit/{id} — Load an existing company into the edit form
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Companies? company = _context.Companies.Find(id);
            if (company == null) return NotFound();
            return View(company);
        }

        // POST /Companies/Edit/{id} — Apply changes, checking booth uniqueness
        [HttpPost]
        public IActionResult Edit(int id, Companies changes)
        {
            if (!ModelState.IsValid)
            {
                return View(changes);
            }

            // Allow the same booth number only if it belongs to this company
            bool boothTaken = _context.Companies
                .Any(c => c.boothnumber == changes.boothnumber && c.ID != id);

            if (boothTaken)
            {
                ModelState.AddModelError("boothnumber",
                    $"Booth {changes.boothnumber} is already assigned to another company.");
                return View(changes);
            }

            Companies? company = _context.Companies.Find(id);
            if (company == null) return NotFound();

            company.companyName = changes.companyName;
            company.boothnumber = changes.boothnumber;

            _context.Companies.Update(company);
            _context.SaveChanges();
            TempData["CompanySuccess"] = $"{company.companyName} was updated successfully.";
            return RedirectToAction("ListAll");
        }

        // GET /Companies/Remove/{id} — Show delete confirmation page
        [HttpGet]
        public IActionResult Remove(int id)
        {
            Companies? company = _context.Companies.Find(id);
            if (company == null) return NotFound();
            return View(company);
        }

        // POST /Companies/Remove — Perform the deletion after confirmation
        [HttpPost]
        [ActionName("Remove")]
        public IActionResult RemoveConfirmed(int id)
        {
            Companies? company = _context.Companies.Find(id);
            if (company == null) return NotFound();

            string name = company.companyName;
            _context.Companies.Remove(company);
            _context.SaveChanges();

            TempData["CompanySuccess"] = $"{name} was removed from the exhibitor list.";
            return RedirectToAction("ListAll");
        }
    }
}
