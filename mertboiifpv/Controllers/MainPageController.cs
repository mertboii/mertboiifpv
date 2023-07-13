using mertboiifpv.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Controllers
{
    public class MainPageController : Controller
    {
        private readonly AppDbContext _context;

        public MainPageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var allMeteorDrones = await _context.MeteorDrones.ToListAsync();
            return View();
        }
    }
}
