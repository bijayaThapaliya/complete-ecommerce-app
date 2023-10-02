using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketbookingapp.Data;

namespace ticketbookingapp.Controllers
{
    public class ProducerModelController : Controller
    {
        private readonly AppDbContext _context;

        public ProducerModelController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allproducer = await _context.Producers.ToListAsync();
            return View(allproducer);
        }
    }
}