using AP204_Pronia.DAL;
using AP204_Pronia.Models;
using AP204_Pronia.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP204_Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Plants = await _context.Plants.Include(p=>p.PlantImages).ToListAsync()
            };
            return View(model);
        }
    }
}
