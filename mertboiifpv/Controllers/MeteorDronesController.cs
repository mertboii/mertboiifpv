using mertboiifpv.Data;
using mertboiifpv.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Controllers
{
    public class MeteorDronesController : Controller
    {

        private readonly IMeteorDronesService _service;

        public MeteorDronesController(IMeteorDronesService service)
        {
            _service = service;
        }
        

        public async Task<IActionResult> Index()
        {
            

            var data = await _service.GetAllAsync();
            return View("~/Views/Drones/Meteor/Index.cshtml", data);

            
        }

        



        //Get: Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View("~/Views/Drones/Meteor/Details.cshtml", data);
        }

        //Get: Cinemas/Details/1
        


    }
}
