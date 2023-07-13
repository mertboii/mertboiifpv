using mertboiifpv.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Controllers
{
    public class BatteriesController : Controller
    {
        private readonly AppDbContext _context;

        public BatteriesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.CetusDrones.ToListAsync();
            return View();
        }
    }
}
