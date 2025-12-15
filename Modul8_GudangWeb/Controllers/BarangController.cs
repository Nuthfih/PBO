using Microsoft.AspNetCore.Mvc;
using Modul8_GudangWeb.Models;

namespace Modul8_GudangWeb.Controllers
{
    public class BarangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarangController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Barang.ToList();
            return View(data);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Barang barang)
        {
            if (ModelState.IsValid)
            {
                _context.Barang.Add(barang);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(barang);

        }

        // GET: Barang/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var barang = _context.Barang.Find(id.Value);
            if (barang == null) return NotFound();

            return View(barang);
        }

        // POST: Barang/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Barang barang)
        {
            if (id != barang.Id) return BadRequest();

            if (!ModelState.IsValid) return View(barang);

            _context.Update(barang);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Barang/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var barang = _context.Barang.Find(id.Value);
            if (barang == null) return NotFound();

            return View(barang);
        }

        // POST: Barang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var barang = _context.Barang.Find(id);
            if (barang == null) return NotFound();

            _context.Barang.Remove(barang);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
