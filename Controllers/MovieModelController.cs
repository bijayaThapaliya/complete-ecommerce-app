using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketbookingapp.Data;

namespace ticketbookingapp.Controllers
{
    public class MovieModelController : Controller
    {
        private readonly AppDbContext _context;

        public MovieModelController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dataMovies = await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(dataMovies);
        }
      
    }
}