using mertboiifpv.Data.Base;
using mertboiifpv.Models.Drones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data.Services
{
    public class PavoDronesService : EntityBaseRepository<Pavo>, IPavoDronesService
    {
        private readonly AppDbContext _context;
        public PavoDronesService(AppDbContext context) : base(context)
        {
            _context = context;
        }



        public async Task<Pavo> GetPavoDroneByIdAsync(int id)
        {
            var data = await _context.PavoDrones

                .FirstOrDefaultAsync(n => n.Id == id);

            return data;
        }
    }
}
