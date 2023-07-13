using mertboiifpv.Data.Base;
using mertboiifpv.Models.Drones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data.Services
{
    public class MeteorDronesService : EntityBaseRepository<Meteor>, IMeteorDronesService
    {
        private readonly AppDbContext _context;
        public MeteorDronesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

       

        public async Task<Meteor> GetMeteorDroneByIdAsync(int id)
        {
            var data = await _context.MeteorDrones
              
                .FirstOrDefaultAsync(n => n.Id == id);

            return data;
        }
    }
}
