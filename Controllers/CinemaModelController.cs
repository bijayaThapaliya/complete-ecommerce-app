using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketbookingapp.Data;

namespace ticketbookingapp.Controllers
{
    public class CinemaModelController : Controller
    {
        private readonly AppDbContext _context;

        public CinemaModelController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var dataCinema = await _context.Cinemas.ToListAsync();
            return View(dataCinema);
        }
    }
}