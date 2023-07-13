using mertboiifpv.Data;
using mertboiifpv.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Controllers
{
    public class AllDronesController : Controller
    {

        private readonly AppDbContext _context;

        public AllDronesController(AppDbContext context)
        {
            _context = context;
        }

       

        public ActionResult AllDronesIndex()
        {
            ViewBag.Message = "welcome";
            
            AllDronesVM  mymodel = new AllDronesVM();
            mymodel.CetusDrones = _context.CetusDrones.ToList();
            mymodel.MeteorDrones = _context.MeteorDrones.ToList();
            mymodel.PavoDrones = _context.PavoDrones.ToList();

            
            
            
            return View("~/Views/Drones/Index.cshtml", mymodel);
        }

        

    }
}
