using mertboiifpv.Data.Base;
using mertboiifpv.Models.Drones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data.Services
{
    public class CetusDronesService : EntityBaseRepository<Cetus>, ICetusDronesService
    {
        private readonly AppDbContext _context;
        public CetusDronesService(AppDbContext context) : base(context)
        {
            _context = context;
        }


        

        public async Task<Cetus> GetCetusDroneByIdAsync(int id)
        {
            var data = await _context.CetusDrones

                .FirstOrDefaultAsync(n => n.Id == id);

            return data;
        }

        //create
        public async Task AddNewCetusDroneAsync(Cetus drone)
        {
            var newDrone = new Cetus()
            {
                ModelName = drone.ModelName,
                ModelDescription = drone.ModelDescription,
                ModelPrice = drone.ModelPrice,
                ImageURL = drone.ImageURL,
                
                DroneCategory = drone.DroneCategory,
                Package = drone.Package,
               
            };
            await _context.CetusDrones.AddAsync(newDrone);
            await _context.SaveChangesAsync();

           
        }
    }
}
