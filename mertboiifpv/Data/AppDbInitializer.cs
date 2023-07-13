using mertboiifpv.Models;
using mertboiifpv.Models.Accessories;
using mertboiifpv.Models.Drones;
using mertboiifpv.Models.Motors;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mertboiifpv.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cetus
                if (!context.CetusDrones.Any())
                {
                    context.CetusDrones.AddRange(new List<Cetus>()
                    {
                        new Cetus()
                        {
                            ModelName = "Cetus Lite FPV Kit",
                            ModelPrice = 120,
                            ModelDescription = "Cetus Lite FPV Kit is an excellent choice for new FPV beginners to start flying, and also a safe miniature toy for children to play with. The Cetus Lite has an auxiliary altitude hold function that helps users to control and fly easily. It features a durable frame with a protective guard for extremely safe flight and the kit comes with everything to fly including a radio transmitter, FPV goggles, and spare batteries. The Cetus Lite FPV Kit is a great purchase for customers who want an economical and affordable RTF FPV kit.",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/CetusliteFPV_1_720x.jpg?v=1666693913",
                            Package="",
                            DroneCategory = DroneCategory.Beginner,
                            
                        },
                        new Cetus()
                        {
                            ModelName = "Cetus FPV Kit",
                            ModelPrice = 160,
                            ModelDescription = "The highly anticipated Cetus FPV Kit comes! It will be the best choice for FPV beginners to explore the FPV world and bring their family and friends into this hobby. Cetus brushed quadcopter, LiteRadio2 SE transmitter, and VR02 FPV Goggles, everything you need is in a pack!",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/3f89305fb1dabad87b9b93324e3c25cd_24d4cc1d-755a-4017-9ec3-4ed040c6acd3_720x.jpg?v=1648086724",
                            Package="",
                            DroneCategory = DroneCategory.Beginner,
                        },
                        new Cetus()
                        {
                            ModelName = "Cetus Pro FPV Kit",
                            ModelPrice = 230,
                            ModelDescription = "The Cetus Pro FPV Kit is finally here! It is the best ideal choice for beginners to advance currently. Comes with a Cetus Pro brushless quadcopter, LiteRadio2 SE transmitter, and VR02 FPV Goggles, it's more powerful and maneuverable for all starters as well as FPV pros to practice indoor and outdoor.",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/e6daf90e0e73e13cc28988e90079f7ff_720x.jpg?v=1624932386",
                            Package="",
                            DroneCategory = DroneCategory.Beginner,
                        },


                    }); ;
                    context.SaveChanges();
                }
                //Meteor
                if (!context.MeteorDrones.Any())
                {
                    context.MeteorDrones.AddRange(new List<Meteor>()
                    {
                        new Meteor()
                        {
                            ModelName = "Meteor85 Brushless Whoop Quadcopter (2022)",
                            ModelPrice = 110,
                            ModelDescription = "Meteor85 brushless whoop quadcopter, optimized weight, provides a smoother flight experience that's easier to control at high speed and easier on battery life as well. This new Meteor85 (2022) has been upgraded from its frame, canopy, props, battery, flight controller, and camera, offering pilots up to 7 mins flight time and stable flying for freestyle tricks. With the combination of those electronics and parts, it reaches the best balance between performance, weight, durability, and premium build design.",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/74b96dbb2d19db9758ba306fc55ad040_2ee46477-d292-40a7-b9a5-29d8385fbffc_720x.jpg?v=1668504403",
                            Package="",
                            DroneCategory = DroneCategory.Brushless,

                        },
                        new Meteor()
                        {
                            ModelName = "Meteor85 Brushless Whoop Quadcopter (2S HD Digital VTX)",
                            ModelPrice = 230,
                            ModelDescription = "Experiencing super clear and sharper images, stepping into the HD world with BETAFPV Meteor85 HD. Based on the newest Meteor85 (2022), it comes with Walksnail Avatar Mini HD VTX or HDZero Whoop Lite Bundle, bringing conspicuous images and exceptional visuals to your eyes and capturing details that make the footage look as exciting as the flight. Together with 1103 11000KV motors and GF2015 2-blade props that feature strong propulsion, it gives pilots powerful and impressive results. Enjoy an immersive flight experience for freestyle tricks outdoors, and get the perfect shots with the new HD VTX system.",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/74b96dbb2d19db9758ba306fc55ad040_ccb853ae-2b48-40de-824b-0fcd464e4166_720x.jpg?v=1668511246",
                            Package="",
                            DroneCategory = DroneCategory.Brushless,
                        },
                        new Meteor()
                        {
                            ModelName = "Meteor65 Pro Brushless Whoop Quadcopter (2022)",
                            ModelPrice = 110,
                            ModelDescription = "Meteor65 Pro comes with a 35mm propeller for power improvement and a flexible flying experience. Beyond that, it has almost the same components and features as Meteor65, like F4 1S 5A FC (2022) with built-in serial ExpressLRS 2.4G, Frsky, or TBS RX version, up to 350mW M03 VTX, 19500KV 0802SE motors, C03 FPV camera etc, All aspects of performance are perfectly balanced.",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/74b96dbb2d19db9758ba306fc55ad040_677b9476-23a2-41bf-ac6c-c37b86c22ea4_720x.jpg?v=1668077426",
                            Package="",
                            DroneCategory = DroneCategory.Brushless,
                        },
                        
                    });
                    context.SaveChanges();
                }
                //Pavo
                if (!context.PavoDrones.Any())
                {
                    context.PavoDrones.AddRange(new List<Pavo>()
                    {
                        new Pavo()
                        {
                            ModelName = "Pavo25 Whoop Quadcopter",
                            ModelPrice = 350,
                            ModelDescription = "The Pavo25 Whoop Quadcopter is a 2.5-inch FPV pusher drone developed by BETAFPV. The new frame design optimizes its structure to decrease complex components and only requires 6 screws to assemble the whoop duct and drone, which is convenient to build. Made of high-quality PA12 material, it features a strong injected mold frame for durable use. What's more, it supports carrying many FPV cameras available in the market for FPV shots. Also, it adopts Caddx Nebula Pro Nano Vista Kit for the HD Digital version, and Caddx Baby Ratel2+A03 400mW 5.8G for the Analog VTX version. Pavo25 is the cinewhoop for you to fly both indoors and outdoors!",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/pavo25-whoop-quadcopter_7_4bd247b6-2bc1-4b88-96f2-b20120eee7aa_720x.jpg?v=1669723784",
                            Package="",
                            DroneCategory = DroneCategory.Cinewhoop,

                        },
                        new Pavo()
                        {
                            ModelName = "Pavo25 Whoop Quadcopter",
                            ModelPrice = 350,
                            ModelDescription = "The Pavo25 Whoop Quadcopter is a 2.5-inch FPV pusher drone developed by BETAFPV. The new frame design optimizes its structure to decrease complex components and only requires 6 screws to assemble the whoop duct and drone, which is convenient to build. Made of high-quality PA12 material, it features a strong injected mold frame for durable use. What's more, it supports carrying many FPV cameras available in the market for FPV shots. Also, it adopts Caddx Nebula Pro Nano Vista Kit for the HD Digital version, and Caddx Baby Ratel2+A03 400mW 5.8G for the Analog VTX version. Pavo25 is the cinewhoop for you to fly both indoors and outdoors!",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/pavo25-whoop-quadcopter_7_4bd247b6-2bc1-4b88-96f2-b20120eee7aa_720x.jpg?v=1669723784",
                            Package="",
                            DroneCategory = DroneCategory.Cinewhoop,
                        },
                        new Pavo()
                        {
                            ModelName = "Pavo360 FPV Quadcopter",
                            ModelPrice = 470,
                            ModelDescription = "Pavo360, the newest generation of 360 FPV quadcopter, generated by BETAFPV, has superb performance in its recording, flying performance, stability, and design. The drone comes with landing gear, protecting the camera lens when the quadcopter lands on the surface, giving the Pavo360 ability to land anywhere. The ultra-thin and flat frame design made sure the drone is completely invisible when recording a video with the SMO360 panoramic camera.",
                            ImageURL="https://cdn.shopify.com/s/files/1/1778/6615/products/fd9f4d7ebae0c44beef96844176bb35e_b2475db9-c9c2-4516-8a8d-b4cb2fa25a77_720x.jpg?v=1669723768",
                            Package="",
                            DroneCategory = DroneCategory.Cinewhoop,
                        },
                        
                    });
                    context.SaveChanges();
                }
                //Frame
                /*
                if (!context.Frames.Any())
                {
                    context.Frames.AddRange(new List<Frame>()
                    {
                        new Frame()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Frame()
                        {
                            
                        },
                        new Frame()
                        {
                           
                        },
                        
                    });
                    context.SaveChanges();
                }

                //Propeller
                if (!context.Propellers.Any())
                {
                    context.Propellers.AddRange(new List<Propeller>()
                    {
                        new Propeller()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Propeller()
                        {

                        },
                        new Propeller()
                        {

                        },

                    });
                    context.SaveChanges();
                }

                //Battery
                if (!context.Batteries.Any())
                {
                    context.Batteries.AddRange(new List<Battery>()
                    {
                        new Battery()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Battery()
                        {

                        },
                        new Battery()
                        {

                        },

                    });
                    context.SaveChanges();
                }

                //Motor
                if (!context.BrushlessMotors.Any())
                {
                    context.BrushlessMotors.AddRange(new List<BrushlessMotor>()
                    {
                        new BrushlessMotor()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new BrushlessMotor()
                        {

                        },
                        new BrushlessMotor()
                        {

                        },

                    });
                    context.SaveChanges();
                }
                //Propeller
                if (!context.Antennas.Any())
                {
                    context.Antennas.AddRange(new List<Antenna>()
                    {
                        new Antenna()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Antenna()
                        {

                        },
                        new Antenna()
                        {

                        },

                    });
                    context.SaveChanges();
                }
                //Transmitter
                if (!context.Transmitters.Any())
                {
                    context.Transmitters.AddRange(new List<Transmitter>()
                    {
                        new Transmitter()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Transmitter()
                        {

                        },
                        new Transmitter()
                        {

                        },

                    });
                    context.SaveChanges();
                }
                */

            }

        }
    }
}

