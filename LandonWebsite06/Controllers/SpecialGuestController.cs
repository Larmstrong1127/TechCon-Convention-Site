using Microsoft.AspNetCore.Mvc;
using LandonWebsite06.Models;
using LandonWebsite06.Data;
using System.Linq;

namespace LandonWebsite06.Controllers
{
    /// <summary>
    /// Full CRUD controller for convention special guests.
    /// </summary>
    public class SpecialGuestController : Controller
    {
        private readonly MyDBContext _context;

        public SpecialGuestController(MyDBContext context)
        {
            _context = context;
        }

        // GET /SpecialGuest/ViewAll — List all special guests
        public IActionResult ViewAll()
        {
            return View("ViewAll", _context.SpecialGuests.ToList());
        }

        // GET /SpecialGuest/Add — Show the add-guest form
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST /SpecialGuest/Add — Save a new guest
        [HttpPost]
        public IActionResult Add(SpecialGuests guest)
        {
            if (!ModelState.IsValid)
            {
                return View(guest);
            }

            _context.SpecialGuests.Add(guest);
            _context.SaveChanges();
            TempData["GuestSuccess"] = $"{guest.guestName} was added to the guest list.";
            return RedirectToAction("ViewAll");
        }

        // GET /SpecialGuest/Edit/{id} — Load guest into the edit form
        [HttpGet]
        public IActionResult Edit(int id)
        {
            SpecialGuests? guest = _context.SpecialGuests.Find(id);
            if (guest == null) return NotFound();
            return View(guest);
        }

        // POST /SpecialGuest/Edit/{id} — Save changes
        [HttpPost]
        public IActionResult Edit(int id, SpecialGuests changes)
        {
            if (!ModelState.IsValid)
            {
                return View(changes);
            }

            SpecialGuests? guest = _context.SpecialGuests.Find(id);
            if (guest == null) return NotFound();

            guest.guestName = changes.guestName;
            guest.Title     = changes.Title;
            guest.Company   = changes.Company;
            guest.Bio       = changes.Bio;

            _context.SaveChanges();
            TempData["GuestSuccess"] = $"{guest.guestName} was updated successfully.";
            return RedirectToAction("ViewAll");
        }

        // GET /SpecialGuest/Delete/{id} — Show confirmation page
        [HttpGet]
        public IActionResult Delete(int id)
        {
            SpecialGuests? guest = _context.SpecialGuests.Find(id);
            if (guest == null) return NotFound();
            return View(guest);
        }

        // POST /SpecialGuest/Delete/{id} — Perform deletion
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            SpecialGuests? guest = _context.SpecialGuests.Find(id);
            if (guest == null) return NotFound();

            string name = guest.guestName;
            _context.SpecialGuests.Remove(guest);
            _context.SaveChanges();

            TempData["GuestSuccess"] = $"{name} was removed from the guest list.";
            return RedirectToAction("ViewAll");
        }
    }
}
