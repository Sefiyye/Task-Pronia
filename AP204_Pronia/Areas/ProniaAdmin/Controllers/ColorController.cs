using AP204_Pronia.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AP204_Pronia.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Models.Color> sizes = await _context.Colors.ToListAsync();
            return View();
        }
        public IActionResult Create()
        {
            return Json("Create");
        }
        public IActionResult Detail(int id)
        {
            return Json(id);
        }
        public IActionResult Edit(int id)
        {
            return Json(id);
        }

        public IActionResult Delete(int id)
        {
            return Json(id);
        }
    }
}
