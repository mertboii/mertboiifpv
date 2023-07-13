using mertboiifpv.Data.Base;
using mertboiifpv.Models.Drones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data.Services
{
    public interface ICetusDronesService : IEntityBaseRepository<Cetus>
    {
        Task<Cetus> GetCetusDroneByIdAsync(int id);
        Task AddNewCetusDroneAsync(Cetus data);
    }
}
