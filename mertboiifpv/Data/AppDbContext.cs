using mertboiifpv.Models;
using mertboiifpv.Models.Accessories;
using mertboiifpv.Models.Drones;
using mertboiifpv.Models.Motors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cetus> CetusDrones { get; set; }

        public DbSet<Meteor> MeteorDrones { get; set; }

        public DbSet<Pavo> PavoDrones { get; set; }
        public DbSet<BrushlessMotor> BrushlessMotors { get; set; }
        public DbSet<Antenna> Antennas { get; set; }
        public DbSet<Transmitter> Transmitters { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Propeller> Propellers { get; set; }
        public DbSet<CustomerReview> CustomerReviews { get; set; }
    }
}
