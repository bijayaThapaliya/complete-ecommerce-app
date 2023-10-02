using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketbookingapp.Data;

namespace ticketbookingapp.Controllers
{
    public class ActorModelController : Controller
    {
        private readonly AppDbContext _context;

        public ActorModelController(AppDbContext context)
        {
            _context = context;

        }

        public  IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }

    }
}