using mertboiifpv.Data.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Models
{
    public class Battery
    {
        [Key]
        public int Id { get; set; }


        public string ModelName { get; set; }
        public int ModelPrice { get; set; }
        public string ImageURL { get; set; }

        public string ModelDescription { get; set; }
        public string Package { get; set; }
        public string BulletPoint { get; set; }
        public string Specification { get; set; }

        public BatteryCellCount BatteryCellCount { get; set; }
    }
}
