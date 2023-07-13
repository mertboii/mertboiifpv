using mertboiifpv.Data;
using mertboiifpv.Data.Services;
using mertboiifpv.Models.Drones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Controllers
{
    public class CetusDronesController : Controller
    {

        private readonly ICetusDronesService _service;

        public CetusDronesController(ICetusDronesService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {


            var data = await _service.GetAllAsync();
            return View("~/Views/Drones/Cetus/Index.cshtml", data);


        }





        //Get: Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View("~/Views/Drones/Cetus/Details.cshtml", data);
        }

        //GET: Movies/Create
        public IActionResult Create()
        {


            return View("~/Views/Drones/Cetus/Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cetus drone)
        {
            if (!ModelState.IsValid)
            {




                return View(drone);
            }

            await _service.AddNewCetusDroneAsync(drone);
            return RedirectToAction(nameof(Index));
        }
    }
}
