using mertboiifpv.Models.Drones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data.ViewModels
{
    public class AllDronesVM
    {
        
        public List<Cetus> CetusDrones { get; set; }
        public List<Meteor> MeteorDrones { get; set; }
        public List<Pavo> PavoDrones { get; set; }


        public int Id { get; set; }

        [Display(Name = "Model name")]
        [Required(ErrorMessage = "Name is required")]
        public string ModelName { get; set; }

        [Display(Name = "Model description")]
        [Required(ErrorMessage = "Description is required")]
        public string ModelDescription { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public int ModelPrice { get; set; }

        [Display(Name = "Drone Image URL")]
        [Required(ErrorMessage = "Drone Image URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Package")]
        [Required(ErrorMessage = "Package is required")]
        public string Package { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public DroneCategory DroneCategory { get; set; }



    }

}


