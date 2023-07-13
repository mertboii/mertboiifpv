using mertboiifpv.Data;
using mertboiifpv.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Models.Drones
{
    public class Pavo : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string ModelName { get; set; }
        public int ModelPrice { get; set; }
        public string ImageURL { get; set; }
        public string ModelDescription { get; set; }
        public string Package { get; set; }
        public DroneCategory DroneCategory { get; set; }
    }
}

