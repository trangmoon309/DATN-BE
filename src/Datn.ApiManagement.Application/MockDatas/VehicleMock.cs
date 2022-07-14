using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.MockDatas
{
    public static class VehicleMock
    {
        public static List<VehicleTypeRequest> VehicleTypes = new List<VehicleTypeRequest>()
        {
                //Motor Scooter
                new VehicleTypeRequest()
                {
                    Name = "Motor Scooter",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "External Fuel Filling",
                            Description = "An externally placed fuel lid will allow the rider to simply refuel by twisting the key – all by remaining seated on his scoot at the fuel station.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Mobile Charger",
                            Description = "Being used as a generator converting mechanical energy to electrical energy",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Height Adjustable Seat",
                            Description = "people can easily adjust the height (increase or decrease) accordingly and can enjoy the complete comfort of the ride.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Telescopic Front Suspension System",
                            Description = "Reduce the effect of shocks and the level of vibrations and brings more comfortable riders.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Large Wheels with Tubeless tyres",
                            Description = "Belped them to enhance the maneuverability of the scooter.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "Avoiding unintentional slides on wet or slippery surfaces and improving the overall safety net.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "Improving the overall braking performance.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear Lift Prevention",
                            Description = "Prevents the bike throwing rider off from happening and makes sure that the rear wheel does not lift from the road, ensuring more control to the rider.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Hazard Lights",
                            Description = "A boon in lack of light condition.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable Clutch",
                            Description = "Be considered when a person with short fingers not pulling the brakes in a panic situation",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Liquid Cooling",
                            Description = "Makes sure that the engine temperature is optimal for extended periods of time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Crash Protection Accessories",
                            Description = "Crash guards, engine guards, frame sliders, tank protection, etc.",
                        }
                    }
                },

                //Sport Bike
                new VehicleTypeRequest()
                {
                    Name = "Sport Bike",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Colored Instrument Panels",
                            Description = "Performs well",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Big engine",
                            Description = "15 per cent increase in efficiency.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Smooth engine",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Slipper Clutch",
                            Description = "Integrated freewheel mechanism, developed for performance-oriented motorcycles to mitigate the effects of engine braking when riders decelerate.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Normal Clutch",
                            Description = "The engine braking force is transmitted to the rear wheel via its chain drive which causes the rear wheel to wobble and may eventually lose traction.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Soft-compound Tires",
                            Description = "Made with materials that are 'soft', meaning their effective life ends just above the 10,000 km mark.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Medium Compound Tyres",
                            Description = "Longer lifespan than soft compound tyres but offer less grip.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Hard Compound Tyres",
                            Description = "Longest lifespan, Least grip.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Mono-shock Rear",
                            Description = "",
                        },

                    }
                },

                //Super Bike
                new VehicleTypeRequest()
                {
                    Name = "Super Bike",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Colored Instrument Panels",
                            Description = "Performs well",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Big engine",
                            Description = "15 per cent increase in efficiency.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Smooth engine",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Slipper Clutch",
                            Description = "Integrated freewheel mechanism, developed for performance-oriented motorcycles to mitigate the effects of engine braking when riders decelerate.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Normal Clutch",
                            Description = "The engine braking force is transmitted to the rear wheel via its chain drive which causes the rear wheel to wobble and may eventually lose traction.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Soft-compound Tires",
                            Description = "Made with materials that are 'soft', meaning their effective life ends just above the 10,000 km mark.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Medium Compound Tyres",
                            Description = "Longer lifespan than soft compound tyres but offer less grip.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Hard Compound Tyres",
                            Description = "Longest lifespan, Least grip.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Mono-shock Rear",
                            Description = "",
                        },

                    }
                },

                //Electric Bike
                new VehicleTypeRequest()
                {
                    Name = "Electric Bike",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Colored Instrument Panels",
                            Description = "Performs well",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Big engine",
                            Description = "15 per cent increase in efficiency.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Smooth engine",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Slipper Clutch",
                            Description = "Integrated freewheel mechanism, developed for performance-oriented motorcycles to mitigate the effects of engine braking when riders decelerate.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Normal Clutch",
                            Description = "The engine braking force is transmitted to the rear wheel via its chain drive which causes the rear wheel to wobble and may eventually lose traction.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Soft-compound Tires",
                            Description = "Made with materials that are 'soft', meaning their effective life ends just above the 10,000 km mark.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Medium Compound Tyres",
                            Description = "Longer lifespan than soft compound tyres but offer less grip.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Hard Compound Tyres",
                            Description = "Longest lifespan, Least grip.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Mono-shock Rear",
                            Description = "",
                        },

                    }
                },

                //Motor Cruiser
                new VehicleTypeRequest()
                {
                    Name = "Motor Cruiser",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Colored Instrument Panels",
                            Description = "Performs well",
                        },

                    }
                },

                //Lightweight Bike
                new VehicleTypeRequest()
                {
                    Name = "Lightweight Bike",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Colored Instrument Panels",
                            Description = "Performs well",
                        },

                    }
                },

                //Micro
                new VehicleTypeRequest()
                {
                    Name = "Micro",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Door reinforcements",
                            Description = "All Microcar door frames are equipped with an oversized longitudinal aluminium beam, reinforcing the passenger compartment.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Front and rear disc brakes",
                            Description = "Your new microcar is the only light quadricycle equipped with front and rear disc brakes for enhanced efficiency and bite.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Power steering",
                            Description = "An exclusive technology that allows more vehicle control. Driving behaviour becomes more dynamic and unwanted jumping due to an uneven road is compensated.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Led daytime running lights",
                            Description = "LED technology ensures exceptional illumination and low energy consumption.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Door reinforcements",
                            Description = "All Microcar door frames are equipped with an oversized longitudinal aluminium beam, reinforcing the passenger compartment.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Air conditionning",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated Sear",
                            Description = "",
                        }
                    }
                },

                //Sedan
                new VehicleTypeRequest()
                {
                    Name = "Sedan",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Hatchback
                new VehicleTypeRequest()
                {
                    Name = "Hatchback",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //CUV
                new VehicleTypeRequest()
                {
                    Name = "CUV",
                     VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //SUV
                new VehicleTypeRequest()
                {
                    //xe thể thao đa dụng
                    Name = "SUV",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Couple
                new VehicleTypeRequest()
                {
                    //xe thể thao đa dụng
                    Name = "Couple",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Sports car
                new VehicleTypeRequest()
                {
                    //xe thể thao đa dụng
                    Name = "Sports car",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Supercar
                new VehicleTypeRequest()
                {
                    //xe thể thao đa dụng
                    Name = "Supercar",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //SuperCrew
                new VehicleTypeRequest()
                {
                    //xe thể thao đa dụng
                    Name = "Supercrew",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //SuperCab
                new VehicleTypeRequest()
                {
                    //xe thể thao đa dụng
                    Name = "SuperCab",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Carbiolet
                new VehicleTypeRequest()
                {
                    Name = "Carbiolet",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Coupe
                new VehicleTypeRequest()
                {
                    Name = "Coupe",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Luxury
                new VehicleTypeRequest()
                {
                    Name = "Luxury",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Compact
                new VehicleTypeRequest()
                {
                    Name = "Compact",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Roadster
                new VehicleTypeRequest()
                {
                    Name = "Roadster",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Pick-up Truck
                new VehicleTypeRequest()
                {
                    Name = "Pick-up Truck",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Crew Cab
                new VehicleTypeRequest()
                {
                    Name = "Crew Cab",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Truck
                new VehicleTypeRequest()
                {
                    Name = "Truck",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Saloon
                new VehicleTypeRequest()
                {
                    Name = "Saloon",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Van
                new VehicleTypeRequest()
                {
                    Name = "Van",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },

                //Limousine
                new VehicleTypeRequest()
                {
                    Name = "Limousine",
                    VehicleTypeDetails = new List<VehicleTypeDetailRequest>()
                    {
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Three-box configuration",
                            Description = "Three-box configuration with separate compartments for an engine, passengers, and cargo.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "Heated seats have an internal thermostat that maintains the seat's heat and limits how hot the seat gets during use.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Blind-spot monitoring",
                            Description = "The blind spot monitor or blind-spot monitoring is a vehicle-based sensor device that detects other vehicles located to the driver's side and rear.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Rear parking sensors",
                            Description = "The rear sensors can normally detect objects much further away than the front sensors.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AWD",
                            Description = "AWD is optimized for on-road use. It has the capability to send the engine's power to all four tires all of the time.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Lane-departure warning",
                            Description = "Lane departure warning is designed to help you avoid crashes due to drifting or departing your lane.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Apple CarPlay",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Android Auto",
                            Description = "You can get directions, make calls, send and receive messages, and enjoy your favorite music.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "LED lights car",
                            Description = "LED headlights are bright white and vastly improve nighttime visibility.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Memory driver's seat",
                            Description = "Save your favourite seating position in the vehicles memory and you can recall that position anytime with the push of a button.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Augmented reality head-up display",
                            Description = "This generation of HUDs supplements the exterior view of the traffic conditions in front of the vehicle with virtual information (augmentations) for the driver.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fully-autonomous",
                            Description = "A fully autonomous car would be self-aware and capable of making its own choices.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Leather seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Sunroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Moonroof",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Heated seats",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Backup camera",
                            Description = "Back-up cameras help you see objects directly behind you while backing.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Navigation system",
                            Description = "Route planning and waypoints. Planning a route is the easiest and most basic thing a navigation system should be able to do.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Bluetooth",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Remote start",
                            Description = "Smartphone start-up option available.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Third-row seating",
                            Description = "Using the third row as a cargo hold is possible in most mid- and full-size SUVs.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "CBS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "ABS",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Reverse sensing system",
                            Description = "The reverse sensors work by emitting audible beeps when it detects that something is behind you.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "AirBags",
                            Description = "An airbag is a vehicle occupant-restraint system using a bag designed to inflate extremely quickly, then quickly deflate during a collision.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Adjustable comforts",
                            Description = "Adjustable wheel so that driver can be more comfortable. ",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Traction Control",
                            Description = "Traction control is an active safety feature that helps to keep traction between the tires and the road in slippery or dangerous conditions. .",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic emergency braking",
                            Description = "A safety system that can identify when a possible collision is about to occur and responds by autonomously activating the brakes to slow a vehicle prior to impact or bring it to a stop to avoid a collision..",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Forward collision warning",
                            Description = "Warn you of an impending collision by detecting stopped or slowly moved vehicles ahead of your vehicle.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Automatic high beams",
                            Description = "Automatic high-beam systems depend on a forward-looking camera mounted in the rearview mirror.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Auto-dimming mirrors",
                            Description = "Auto dimming mirrors are the special type of rear view mirrors that have the capability to dim the light reflecting from their surface.",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Fast USR charging",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Keyless entry",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "SmartKey",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wifi hotspot",
                            Description = "",
                        },
                        new VehicleTypeDetailRequest()
                        {
                            Name = "Wireless chargin pad",
                            Description = "",
                        }
                    }
                },
        };

        public static List<VehicleLineRequest> VehicleLine()
        {
            return new List<VehicleLineRequest>()
            {
                // Car
                new VehicleLineRequest()
                {
                    Name="VinFast"
                },
                new VehicleLineRequest()
                {
                    Name="Mazda"
                },
                new VehicleLineRequest()
                {
                    Name="Toyota"
                },
                new VehicleLineRequest()
                {
                    Name="Mercedes-benz"
                },
                new VehicleLineRequest()
                {
                    Name="Lexus"
                },
                new VehicleLineRequest()
                {
                    Name="Ford"
                },
                new VehicleLineRequest()
                {
                    Name="Hyundai"
                },
                new VehicleLineRequest()
                {
                    Name="Porsche"
                },
                new VehicleLineRequest()
                {
                    Name="Honda"
                },
                new VehicleLineRequest()
                {
                    Name="Bentley"
                },
                new VehicleLineRequest()
                {
                    Name="BMW"
                },
                new VehicleLineRequest()
                {
                    Name="Audi"
                },
                new VehicleLineRequest()
                {
                    Name="Bugatti"
                },
                new VehicleLineRequest()
                {
                    Name="Ferrari"
                },
                new VehicleLineRequest()
                {
                    Name="Lamborghini"
                },
                new VehicleLineRequest()
                {
                    Name="Volvo"
                },
                new VehicleLineRequest()
                {
                    Name="Abarth"
                },
                new VehicleLineRequest()
                {
                    Name="Zenos"
                },
                new VehicleLineRequest()
                {
                    Name="Alfa Romeo"
                },
                new VehicleLineRequest()
                {
                    Name="Volkswagen"
                },
                new VehicleLineRequest()
                {
                    Name="Aston Martin"
                },
                new VehicleLineRequest()
                {
                    Name="Vauxhall"
                },
                new VehicleLineRequest()
                {
                    Name="Tesla"
                },
                new VehicleLineRequest()
                {
                    Name="Suzuki"
                },
                new VehicleLineRequest()
                {
                    Name="Subaru"
                },
                new VehicleLineRequest()
                {
                    Name="Cadillac"
                },
                new VehicleLineRequest()
                {
                    Name="Chevrolet"
                },
                new VehicleLineRequest()
                {
                    Name="Rolls-Royce"
                },
                new VehicleLineRequest()
                {
                    Name="Renault"
                },
                new VehicleLineRequest()
                {
                    Name="Fiat"
                },
                new VehicleLineRequest()
                {
                    Name="Radical"
                },
                new VehicleLineRequest()
                {
                    Name="Porsche"
                },
                new VehicleLineRequest()
                {
                    Name="Peugeot"
                },
                new VehicleLineRequest()
                {
                    Name="Hyundai"
                },
                new VehicleLineRequest()
                {
                    Name="Nissan"
                },
                new VehicleLineRequest()
                {
                    Name="Infiniti"
                },
                new VehicleLineRequest()
                {
                    Name="Noble"
                },
                new VehicleLineRequest()
                {
                    Name="Jaguar"
                },
                new VehicleLineRequest()
                {
                    Name="Jeep"
                },
                new VehicleLineRequest()
                {
                    Name="Morgan"
                },
                new VehicleLineRequest()
                {
                    Name="Kia"
                },
                new VehicleLineRequest()
                {
                    Name="Mitsubishi"
                },
                new VehicleLineRequest()
                {
                    Name="Kia"
                },
                new VehicleLineRequest()
                {
                    Name="Mini"
                },
                new VehicleLineRequest()
                {
                    Name="Land Rover"
                },
                new VehicleLineRequest()
                {
                    Name="MG"
                },
                new VehicleLineRequest()
                {
                    Name="Lotus"
                },
                new VehicleLineRequest()
                {
                    Name="Mclaren"
                },
                new VehicleLineRequest()
                {
                    Name="Maserati"
                },
                new VehicleLineRequest()
                {
                    Name="Smart"
                },
                new VehicleLineRequest()
                {
                    Name="Chrysler"
                },
                new VehicleLineRequest()
                {
                    Name="Skoda"
                },
                new VehicleLineRequest()
                {
                    Name="Citroen"
                },
                new VehicleLineRequest()
                {
                    Name="Dacia"
                },
                new VehicleLineRequest()
                {
                    Name="Saab"
                },
                new VehicleLineRequest()
                {
                    Name="Mclaren"
                },
                // Motor
                new VehicleLineRequest()
                {
                    Name="Yamaha"
                },
                new VehicleLineRequest()
                {
                    Name="Kawasaki"
                },
                new VehicleLineRequest()
                {
                    Name="Triump"
                },
                new VehicleLineRequest()
                {
                    Name="Harley-Davidson"
                },
                new VehicleLineRequest()
                {
                    Name="Aprilia"
                },
                new VehicleLineRequest()
                {
                    Name="KTM"
                },
                new VehicleLineRequest()
                {
                    Name="MV Agusta"
                },
                new VehicleLineRequest()
                {
                    Name="Moto Guzzi"
                },
                new VehicleLineRequest()
                {
                    Name="Royal Enfield"
                },
                new VehicleLineRequest()
                {
                    Name="Indian Motorcycle"
                },
                new VehicleLineRequest()
                {
                    Name="Benelli"
                },
                new VehicleLineRequest()
                {
                    Name="Bajaj"
                },
                new VehicleLineRequest()
                {
                    Name="Norton"
                },
                new VehicleLineRequest()
                {
                    Name="Victory"
                },
                new VehicleLineRequest()
                {
                    Name="Vespa"
                },
                new VehicleLineRequest()
                {
                    Name="Gas Gas"
                },
                new VehicleLineRequest()
                {
                    Name="Beta"
                },
                new VehicleLineRequest()
                {
                    Name="SYM"
                },
                new VehicleLineRequest()
                {
                    Name="Victory"
                },
                new VehicleLineRequest()
                {
                    Name="Bajaj"
                },
                new VehicleLineRequest()
                {
                    Name="Indian Motorcycle"
                },
                new VehicleLineRequest()
                {
                    Name="Royal Enfield"
                },
                new VehicleLineRequest()
                {
                    Name="Triumph"
                }
            };
        }

        #region Vehicle
        public static List<VehicleRequest> Vinfast()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Vinfast President",
                    Color = "Purple, Yellow, Green, Blue, Gray, Black, Orange, Red, White",
                    Description = "VinFast President is a full-size luxury SUV manufactured and marketed by VinFast of Vingroup from September 7, 2020.[1] This is fourth car model introduced by VinFast, after VinFast Fadil, LUX A2.0 and LUX SA2.0. The pre-concept version VinFast LUX V8 was presented at Geneva Motor Show 2019.",
                    Amount = 10,
                    ModelYear = 99,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 100,
                    DepositPrice = 90,
                    VehicleLineName = "Vinfast",
                    VehicleTypeName = "SUV"
                },
                new VehicleRequest()
                {
                    Name = "Vinfast Lux SA2.0",
                    Color = "Gray, Black, White",
                    Description = "The VinFast LUX SA2.0 is designed by Italian design company Pininfarina and is based on the F15-generation BMW X5",
                    Amount = 15,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 99,
                    DepositPrice = 89,
                    VehicleLineName = "Vinfast",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Vinfast A2.0",
                    Color = "Gray, Black, White",
                    Description = "The VinFast LUX A2.0 is a four-door executive sedan produced by Vietnamese automaker VinFast since 2019. It was revealed at the 2018 Paris Motor Show.",
                    Amount = 19,
                    ModelYear = 200,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 110,
                    DepositPrice = 100,
                    VehicleLineName = "Vinfast",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Vinfast Fadil",
                    Color = "Gray, Black, White",
                    Description = "VinFast Fadil is an A-segment crossover hatchback produced by VinFast, a member of Vingroup, since 2018. It is a continued-production version of the discontinued Opel Karl for the Vietnamese car market.",
                    Amount = 10,
                    ModelYear = 1230,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 89,
                    DepositPrice = 79,
                    VehicleLineName = "Vinfast",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Vinfast VF e34",
                    Color = "Purple, Yellow, Green, Blue, Gray, Black, Orange, Red",
                    Description = "VinFast President is a full-size luxury SUV manufactured and marketed by VinFast of Vingroup from September 7, 2020.[1] This is fourth car model introduced by VinFast, after VinFast Fadil, LUX A2.0 and LUX SA2.0. The pre-concept version VinFast LUX V8 was presented at Geneva Motor Show 2019.",
                    Amount = 10,
                    ModelYear = 980,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 85,
                    DepositPrice = 75,
                    VehicleLineName = "Vinfast",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Mazda()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Mazda CX-30",
                    Color = "Purple, Yellow, Green, Blue, Gray, Black, Orange, Red, White",
                    Description = "he Mazda CX-30 is a subcompact crossover SUV produced by Mazda. Based on the fourth-generation Mazda3, it debuted at the 2019 Geneva Motor Show, to slot in between the CX-3 and the CX-5. It went on sale in Japan on 24 October 2019,with global units being produced at Mazda's Hiroshima factory, North and South American units built in Salamanca, Guanajuato, Mexico,Thailand and initial Australian units made at the AutoAlliance Thailand plant in Rayong,and China-market units produced in Nanjing by Changan Mazda.",
                    Amount = 5,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Mazda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mazda CX-5",
                    Color = "Gray, Black, White",
                    Description = "The Mazda CX-5 is a compact crossover SUV produced by Mazda since 2012. A successor to both the Tribute and the slightly larger CX-7,[3][4] it is Mazda's first model to feature the Kodo design language and the first model to be fully developed with a range of technologies branded as Skyactiv, including a rigid, lightweight platform combined with a series of engines and transmissions to reduce emissions and fuel consumption.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Mazda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mazda CX-50",
                    Color = "Gray, Black, White",
                    Description = "The Mazda CX-50 is a compact crossover SUV produced by the Japanese automobile manufacturer Mazda for the North American market since 2022.Based on the same transverse, front-wheel-drive platform as the fourth-generation Mazda3 and the CX-30, the vehicle is sold alongside the slightly smaller CX-5 and will be positioned below the larger, rear-wheel-drive based CX-70.",
                    Amount = 9,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Mazda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mazda CX-9",
                    Color = "Gray, Black, White",
                    Description = "The Mazda CX-9 is a mid-size crossover SUV manufactured since April 2006 by Mazda in Japan, at its Ujina #1 plant in Hiroshima Prefecture.Despite being built in Japan, the CX-9 is not sold in Japan's domestic market, as it exceeds a major threshold in the Japanese dimension and engine displacement regulations which obligates a large annual road tax bill.",
                    Amount = 3,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mazda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mazda3 Sedan",
                    Color = "Black, Green, Blue,Red",
                    Description = "The BK series Mazda3 was launched in Japan in October 2003 as the Axela. The model was well received by the automotive press for its performance, handling, styling and interior, with some describing it as feeling like a more expensive sports sedan/saloon despite its value-oriented price.",
                    Amount = 10,
                    ModelYear = 1280,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Mazda",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Toyota()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Toyota Yaris",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description = "The Toyota Yaris (Japanese: トヨタ・ヤリス, Hepburn: Toyota Yarisu) is a supermini/subcompact car sold by Toyota since 1999, replacing the Starlet and Tercel.",
                    Amount = 5,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Toyota",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Toyota Camry",
                    Color = "Gray, Black, White",
                    Description = "The Toyota Camry is an automobile sold internationally by the Japanese auto manufacturer Toyota since 1982, spanning multiple generations.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Toyota",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Toyota Fortuner",
                    Color = "Gray, Black, White",
                    Description = "The Toyota Fortuner, also known as the Toyota SW4, is a mid-size SUV manufactured by the Japanese automaker Toyota since 2004.",
                    Amount = 9,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Toyota",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Toyota Vios",
                    Color = "Gray, Black, White",
                    Description = "The Toyota Vios is a subcompact car produced by the Japanese manufacturer Toyota, primarily for markets in the Asia-Pacific region since 2002.",
                    Amount = 3,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Toyota",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Toyota Innova",
                    Color = "Black, Green, Blue,Red",
                    Description = "The Toyota Innova is a car manufactured by the Japanese carmaker Toyota since 2004. It is a compact MPV and mainly sold with three-row seating.",
                    Amount = 10,
                    ModelYear = 1280,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Toyota",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Toyota Veloz cross",
                    Color = "Black, Green, Blue,Red",
                    Description = "The Toyota Avanza and Daihatsu Xenia are automobiles developed by Daihatsu and marketed by both Toyota and Daihatsu.",
                    Amount = 10,
                    ModelYear = 980,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Toyota",
                    VehicleTypeName = "Mini",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> MercedesBenz()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Mercedes-benz GLC-Class",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description = "The Mercedes-Benz GLC is a compact luxury crossover SUV introduced in 2015 for the 2016 model year that replaces the GLK-Class.",
                    Amount = 5,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Mercedes-benz",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mercedes-benz A-Class",
                    Color = "Gray, Black, White",
                    Description = "The Mercedes-Benz A-Class is a subcompact car produced by the German automobile manufacturer Mercedes-Benz as the brand's entry-level vehicle.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Mercedes-benz",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mercedes-benz C-Class",
                    Color = "Gray, Black, White",
                    Description = "The Mercedes-Benz C-Class is a series of compact executive cars produced by Mercedes-Benz Group AG.",
                    Amount = 9,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Mercedes-benz",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mercedes-benz E-Class",
                    Color = "Gray, Black, White",
                    Description = "The Mercedes-Benz E-Class is a range of executive cars manufactured by German automaker Mercedes-Benz in various engine and body configurations.",
                    Amount = 3,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mercedes-benz",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Lexus()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Lexus RX",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description = "The Lexus RX is a luxury crossover SUV sold since 1998 by Lexus, a luxury division of Toyota. Originally released in its home market of Japan in late 1997.",
                    Amount = 5,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus NX",
                    Color = "Gray, Black, White",
                    Description = "The Lexus NX (Japanese: レクサス・NX, Hepburn: Rekusasu NX) is a compact luxury crossover SUV sold by Lexus, a luxury division of Toyota. Introduced in late 2014, it is positioned between the subcompact UX and the mid-size RX. The NX was proven to be well-received, as it was a sales success. It was the best-selling Lexus model in Europe, and the best-selling luxury car in Russia.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus IS",
                    Color = "Gray, Black, White",
                    Description = "The Lexus IS (Japanese: レクサス・IS, Hepburn: Rekusasu IS) is a compact executive car sold by Lexus, a luxury division of Toyota since 1999.",
                    Amount = 9,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus LS",
                    Color = "Gray, Black, White",
                    Description = "The Lexus LS (Japanese: レクサス・LS, Rekusasu LS) is a full-size luxury sedan (F-segment in Europe) serving as the flagship model of Lexus, the luxury division of Toyota. For the first four generations, all LS models featured V8 engines and were predominantly rear-wheel-drive. In the fourth generation, Lexus offered all-wheel-drive, hybrid, and long-wheelbase variants. The fifth generation changed to using a V6 engine with no V8 option, and only one length was offered.",
                    Amount = 3,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus LX",
                    Color = "Black, Green, Blue,Red",
                    Description = "The Lexus LX is a full-size luxury SUV sold by Lexus, a luxury division of Toyota since January 1996, having entered manufacturing in November 1995.",
                    Amount = 10,
                    ModelYear = 1280,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus GX",
                    Color = "Black, Green, Blue,Red",
                    Description = "The Lexus GX is a full-size luxury SUV sold in North American and Eurasian markets by Lexus, a luxury division of Toyota.",
                    Amount = 10,
                    ModelYear = 1280,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus RC",
                    Color = "Black, Green, Blue,Red",
                    Description = "The Lexus RC is a compact executive two-door coupé manufactured by Lexus, Toyota's luxury division.",
                    Amount = 10,
                    ModelYear = 1280,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lexus LM",
                    Color = "Black, Green, Blue,Red",
                    Description = "Lexus LM. Article Talk. Language; Watch · Edit. Redirect page. Redirect to: Toyota Alphard#LM. Learn more. This page is a redirect.",
                    Amount = 10,
                    ModelYear = 1280,
                    LicensePlate = "92F1-001005",
                    RentalPrice = 66,
                    DepositPrice = 55,
                    VehicleLineName = "Lexus",
                    VehicleTypeName = "Van",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Ford()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Ford Explorer",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description = "The Ford Explorer is a range of SUVs manufactured by Ford Motor Company since the 1991 model year. The first four-door SUV produced by Ford",
                    Amount = 5,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Ford",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ford Ecosport",
                    Color = "Gray, Black, White",
                    Description = "The Ford EcoSport (pronounced Eh-koh-sport) is a subcompact crossover SUV, originally built in Brazil by Ford Brazil since 2003, at the Camaçari plant.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Ford",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ford Tourneo",
                    Color = "Gray, Black, White",
                    Description = "The Ford Tourneo Connect is a leisure activity vehicle produced by Ford, which was first put into production in 2002 to the British market.",
                    Amount = 9,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Ford",
                    VehicleTypeName = "Van",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ford Everest",
                    Color = "Gray, Black, White",
                    Description = "The Ford Everest is a mid-size SUV produced by Ford Motor Company since 2003. Developed and destined mainly for the Asia-Pacific region with production.",
                    Amount = 3,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Ford",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Hyundai()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Hyundai Tucson",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description = "The Hyundai Tucson (Korean: 현대 투싼) (pronounced Tu-són) is a compact crossover SUV[1] (C-segment) produced by the South Korean manufacturer Hyundai since 2004.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Hyundai",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Hyundai Elantra",
                    Color = "Gray, Black, White",
                    Description = "The Hyundai Elantra, also known as the Hyundai Avante (Korean: 현대 아반떼), is a compact car produced by the South Korean manufacturer Hyundai since 1990.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Hyundai",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Hyundai Kona",
                    Color = "Gray, Black, White",
                    Description = "The Hyundai Santa Fe (Korean: 현대 싼타페) is a sport utility vehicle (SUV) produced by the South Korean manufacturer Hyundai since 2000.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Hyundai",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Hyundai Creta",
                    Color = "Gray, Black, White",
                    Description = "The Hyundai Creta, also known as Hyundai ix25 in China, is an automobile produced by Hyundai since 2014 mainly for emerging markets, particularly BRICS.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Hyundai",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Hyundai Accent",
                    Color = "Gray, Black, White",
                    Description = "The Hyundai Accent (Korean: 현대 엑센트), or Hyundai Verna (현대 베르나) is a subcompact car produced by Hyundai.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Hyundai",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Hyundai Grand i10",
                    Color = "Gray, Black, White",
                    Description = "Grand i10 (BA) — The Hyundai i10 is a city car produced by the South Korean manufacturer Hyundai since 2007.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Hyundai",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Porsche()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Porsche Cayenne",
                    Color = "Gray, Black, White",
                    Description = "The Porsche Cayenne is a series of mid-size luxury crossover sport utility vehicles manufactured by the German automaker Porsche since 2002.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Porsche",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Porsche Macan",
                    Color = "Gray, Black, White",
                    Description = "The Porsche Macan (Type 95B) is a high-performance five-door luxury crossover SUV produced by the German car manufacturer Porsche from 2014.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Porsche",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Porsche Taycan",
                    Color = "Gray, Black, White",
                    Description = "The Porsche Taycan is a battery electric saloon and shooting brake produced by German automobile manufacturer Porsche.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Porsche",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Porsche Panamera",
                    Color = "Gray, Black, White",
                    Description = "The Porsche Panamera is a mid/full-sized luxury car (E-segment/F-segment in Europe) manufactured by the German automobile manufacturer Porsche.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Porsche",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Porsche 718",
                    Color = "Gray, Black, White",
                    Description = "The Porsche Boxster and Cayman are mid-engine two-seater sports cars manufactured and marketed by German automobile manufacturer Porsche.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Porsche",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Honda()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Honda Civic",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description = "The Honda Civic is a series of automobiles manufactured by Honda since 1972. Since 2000, the Civic has been categorized as a compact car.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Honda",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Honda CR-V",
                    Color = "Gray, Black, White",
                    Description = "The Honda CR-V is a compact crossover SUV manufactured by the Japanese automaker Honda since 1995 and introduced in the North American market in 1997.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Honda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Honda Accord",
                    Color = "Gray, Black, White",
                    Description = "In 1989, the Accord was the first vehicle sold under an import brand to become the best-selling automobile in the United States.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Honda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Honda HR-V",
                    Color = "Gray, Black, White",
                    Description = "According to Honda, the 'HR-V' stands for 'Hi-rider Revolutionary Vehicle', while the 'Vezel' name is coined from 'bezel', the oblique faces of a cut gem.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Honda",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Honda City",
                    Color = "Gray, Black, White",
                    Description = "The Honda City (Japanese: ホンダ・シティ, Hepburn: Honda City) is a subcompact car which has been produced by the Japanese manufacturer Honda since 1981.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Honda",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Honda Brio",
                    Color = "Gray, Black, White",
                    Description = "The Honda Brio is an automobile produced by Honda since 2011. It is a city car/subcompact car that is mainly sold in Southeast Asia and also in other regions, and positioned as an entry-level hatchback model slotted below the Fit/Jazz and the City.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Honda",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Bentley()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Bentley Continental Gt",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Bentley Continental GT is a grand tourer manufactured and marketed by British automaker Bentley Motors since 2003.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Bentley",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bentley Bentayga",
                    Color = "Gray, Black, White",
                    Description= "The Bentley Bentayga is a mid-size luxury crossover SUV marketed by Bentley since late 2015. It is the second SUV, and the first in large numbers.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Bentley",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bentley Flying Spur",
                    Color = "Gray, Black, White",
                    Description= "The Bentley Flying Spur is a full-sized luxury high performance sports saloon produced by Bentley Motors Limited since 2005, and was released in 2006.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Bentley",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> BMW()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "BMW 3-Series",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The BMW 3 Series is a line of compact executive cars manufactured by the German automaker BMW since May 1975.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW X5",
                    Color = "Gray, Black, White",
                    Description= "The BMW X5 is a mid-sized luxury SUV produced by BMW. ... The X5 made its debut in 1999 as the E53 model. It was BMW's first SUV.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW X3",
                    Color = "Gray, Black, White",
                    Description= "The BMW X3 is a compact luxury crossover SUV manufactured by German automaker BMW since 2003, based on the BMW 3 Series platform.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW X1",
                    Color = "Gray, Black, White",
                    Description= "The BMW X1 is a line of subcompact luxury crossovers produced by BMW. Debuted in 2009, the first-generation X1 has been based on the E90 3 Series and offers rear-wheel drive layout as standard. At its introduction, it was positioned as the smallest SUV in BMW line-up below the X3, aiming a wider range of customers due to its smaller size, increased efficiency, and a lower price tag due to the all-wheel drive layout (xDrive) being optional.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW 5-Series",
                    Color = "Gray, Black, White",
                    Description= "The BMW 5 Series is an executive car manufactured and marketed by BMW since 1972, succeeding the New Class Sedans, and currently in its seventh generation.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW 7-Series",
                    Color = "Gray, Black, White",
                    Description= "The BMW 7 Series is a full-size luxury sedan manufactured and marketed by the German automaker BMW since 1977.[1] It is the successor to the BMW E3 New Six sedan and is currently in its sixth generation.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW X6",
                    Color = "Gray, Black, White",
                    Description= "The BMW X6 is a mid-size luxury crossover SUV by German automaker BMW. The BMW X6 is the originator of the sports activity coupé (SAC), referencing its sloping rear roof design. It combines the attributes of an SUV (high ground clearance, all-wheel drive and all-weather ability, large wheels and tires) with the stance of a coupé (styling featuring a sloping roof).",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW Z4",
                    Color = "Gray, Black, White",
                    Description= "The BMW Z models are a line of roadsters manufactured by German automaker BMW. The Z stands for zukunft (German for future),[1] and has been produced in four different series with six generations consisting of roadster, coupé, sports car, and concept variants.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "Roadster",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW X7",
                    Color = "Gray, Black, White",
                    Description= "The BMW X7 is a full-sized luxury sport utility vehicle manufactured by BMW. It is BMW's largest and most expensive SUV in its line-up.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW 4-Series",
                    Color = "Gray, Black, White",
                    Description= "The BMW 4 Series is a range of compact executive cars manufactured by BMW since 2013. The 4 Series was created when BMW spun off the 2-door models (coupé and convertible) of the 3 Series into a separate series. The 4 Series is currently in its second generation.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW X4",
                    Color = "Gray, Black, White",
                    Description= "The BMW X4 is a compact luxury crossover SUV manufactured by BMW since 2014. It is marketed as a sports activity coupé (SAC),[1] the second model from BMW marketed as such after the X6, and features styling elements and the roofline of a traditional two-door coupé.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "BMW 8-Series",
                    Color = "Gray, Black, White",
                    Description= "The 8 Series was introduced in 1990 under the E31 model code and was only available as a two-door coupé.[1] It is powered by a range of naturally aspirated V8 and V12 petrol engines.[2] The E31 started production just as E24 6 Series production ended, however it is not considered a direct successor.[3] The E31 was discontinued in 1999 due to poor sales.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "BMW",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Audi()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Audi A4",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Audi A4 is a line of compact executive cars produced since 1994 by the German car manufacturer Audi, a subsidiary of the Volkswagen Group.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi A6",
                    Color = "Gray, Black, White",
                    Description= "The Audi A6 is an executive car made by the German automaker Audi. Now in its fifth generation, the successor to the Audi 100 is manufactured in Neckarsulm, Germany, and is available in saloon and estate configurations, the latter marketed by Audi as the Avant. Audi's internal numbering treats the A6 as a continuation of the Audi 100 lineage, with the initial A6 designated as a member of the C4-series, followed by the C5, C6, C7, and the C8.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi Q5",
                    Color = "Gray, Black, White",
                    Description= "The Audi Q5 is a series of compact luxury crossover SUVs produced by the German luxury car manufacturer Audi from 2008.[1] The original first-generation (Typ 8R) model was the third member of the B8 family to be released after the Audi A5 and fourth-generation A4, all being based on the Audi MLB platform. The second generation Q5 (Typ 80A) debuted in 2016 and shares the Audi MLB Evo platform with the corresponding B9 versions of the A4 and A5.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi Q3",
                    Color = "Gray, Black, White",
                    Description= "The Audi Q3 is a subcompact luxury crossover SUV made by Audi. The Q3 has a transverse-mounted front engine, and entered production in 2011.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi Q7",
                    Color = "Gray, Black, White",
                    Description= "The Audi Q7 is a mid-size luxury crossover SUV made by the German manufacturer Audi, unveiled in September 2005 at the Frankfurt Motor Show.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi A8",
                    Color = "Gray, Black, White",
                    Description= "The Audi A8 is a full-size luxury sedan manufactured and marketed by the German automaker Audi since 1994. Succeeding the Audi V8, and now in its fourth generation, the A8 has been offered with both front- or permanent all-wheel drive—and in short- and long-wheelbase variants. The first two generations employed the Volkswagen Group D platform, with the current generation deriving from the MLB platform.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi Q2",
                    Color = "Gray, Black, White",
                    Description= "The Audi Q2 is a subcompact luxury crossover SUV developed and manufactured by Audi. It was first unveiled to the public on 1 March 2016 at the 2016 Geneva Motor Show and built on Volkswagen Group's MQB A1 platform as the Mk7 series Volkswagen Golf. The car is manufactured at the headquarters of Audi in Ingolstadt, Germany; by FAW-Volkswagen in Foshan, China; and in Relizane, Algeria.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi Q8",
                    Color = "Gray, Black, White",
                    Description= "The Audi Q8 is a mid-size luxury crossover SUV coupé made by Audi that was launched in 2018.[4] It is the flagship of the Audi SUV line, and is being produced at the Volkswagen Bratislava Plant.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi A7",
                    Color = "Gray, Black, White",
                    Description= "The Audi A7 is an executive luxury coupe car produced by Audi since 2010. A five-door liftback (also available as a three-box, four-door saloon in China since 2021), it features a sloping roofline with a steeply raked rear window and integrated boot lid (forming the so-called Sportback), and four frameless doors.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Audi Q3 Sportback",
                    Color = "Gray, Black, White",
                    Description= "The Audi Q3 is a subcompact luxury crossover SUV made by Audi. The Q3 has a transverse-mounted front engine, and entered production in 2011.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Audi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Bugatti()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Bugatti Veyron",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Bugatti Veyron EB 16.4 is a mid-engine sports car, designed and developed in France by the Volkswagen Group and Bugatti and manufactured in Molsheim.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Bugatti",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bugatti Chiron",
                    Color = "Gray, Black, White",
                    Description= "The Bugatti Chiron is a mid-engine two-seater sports car designed and developed in Germany by Bugatti Engineering GmbH and manufactured in Molsheim, France.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Bugatti",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bugatti Divo",
                    Color = "Gray, Black, White",
                    Description= "he",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Bugatti",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bugatti Centodieci",
                    Color = "Gray, Black, White",
                    Description= "The Bugatti Divo is a mid-engine track-focused sports car developed and manufactured by Bugatti Automobiles S.A.S. The car is named after French racing.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Bugatti",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bugatti Bolide",
                    Color = "Gray, Black, White",
                    Description= "The Bugatti Bolide is a track-day-focused sportscar developed and manufactured in Wolfsburg, by French automobile manufacturer Bugatti Automobiles S.A.S.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Bugatti",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Bugatti Vision",
                    Color = "Gray, Black, White",
                    Description= "The Bugatti Vision Gran Turismo is a single-seater concept car developed by Bugatti and was manufactured in Molsheim, Alsace, France.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Bugatti",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Ferrari()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Ferrari 812 Superfast",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "A grand tourer with a whopping 789 hp, wrapped in a curvaceous Italian body, paired to one of the greatest chassis we have ever experienced. With its front-mid-mounted naturally aspirated 6.5L V12 engine and rear-wheel drive layout, it is the latest iteration of Ferrari’s super-GT car.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari SF90 Stradale",
                    Color = "Gray, Black, White",
                    Description= "Ferrari’s SF90 Stradale is a stunning new hybrid supercar that produces 989 hp from a plug-in hybrid powertrain. This hybrid setup utilizes a twin-turbocharged 4.0L V8 combustion engine, paired to three electric motors.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari SF90 Spider",
                    Color = "Gray, Black, White",
                    Description= "The Ferrari SF90 Spider has now been unveiled as Ferrari’s first plug-in hybrid roadster with close to 1,000 hp. The car is the open-top version of the SF90 Stradale. It maintains many of the Stradale’s specs, including a 211 mph top speed. It will do a 0-60 mph time in just 2.5 seconds.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari Portofino M",
                    Color = "Gray, Black, White",
                    Description= "The Portofino has been, for a couple of years, the marque’s 2+2 grand touring cabriolet. It was, and still is, a powerhouse of comfort and technology, easily able to cross continents as much as drive a few blocks to the store. It is getting its first refresh with Roma hardware throughout.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari F8 Tributo",
                    Color = "Gray, Black, White",
                    Description= "Billed as the replacement for the 488 GTB, the F8 Tributo inherits much of the outgoing model’s DNA. Mind you, this is largely – if not entirely – a positive thing, as the F8 Tributo notably improves in areas where there was room to, while keeping in the essence of what worked so well before.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari F8 Spider",
                    Color = "Gray, Black, White",
                    Description= "The F8 Spider replaces the 488 Spider and is officially on sale in Ferrari dealerships. It is powered by a twin-turbocharged 3.9-liter V-8 that produces 710 horsepower and 568 lb-ft of torque. It is rear-wheel drive, and a seven-speed automatic transmission changes the gears.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari Roma",
                    Color = "Gray, Black, White",
                    Description= "The vehicle is a stunning thing to look at, with a minimalist (by today’s standards) grille and a shark-nose front end. It’s long, lean, and so utterly Ferrari. Gets a 3.9L twin-turbo V8 engine with new cam profiles and a speed sensor that allows the maximum rpm to rise by 5,000 rpm.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari 812 GTS",
                    Color = "Gray, Black, White",
                    Description= "The 2021 Ferrari 812 GTS Spider is basically a convertible variant of the 812 Superfast. It's the most powerful Spider in the world, with the performance to match. The 812 GTS takes on more of a GT attitude rather than an all-out attack and is surprisingly docile daily driver.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Ferrari 488 Pista",
                    Color = "Gray, Black, White",
                    Description= "The 488 Pista is the marque’s latest Special Series model and – following in the footsteps of its predecessors – epitomizes the pinnacle of Ferrari road cars. Ferrari’s naturally aspirated V8s shrieked and snarled into the redline. The Pista barks and roars its way there. A different special series animal. Production ended, but still on shop floors)",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "488 Pista Spider",
                    Color = "Gray, Black, White",
                    Description= "The Ferrari 488 Pista Spider is powered by the same engine used in the coupe – a twin-turbocharged 3.9L V8 which produces a magnificent 711-horsepower and 568 lb-ft of torque. The Spider is a convertible with a removal hardtop and is 200 pounds heavier than the coupe. Production ended.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Ferrari",
                    VehicleTypeName = "Roadster",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Lamborghini()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Lamborghini Aventador",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Lamborghini Aventador (Spanish pronunciation: [aβentaˈðoɾ]) is a mid-engine sportscar produced by the Italian automotive manufacturer Lamborghini. In keeping with Lamborghini tradition, the Aventador is named after a Spanish fighting bull that fought in Zaragoza, Aragón in 1993.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Huracan",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Huracán is a sports car manufactured by Italian automotive manufacturer Lamborghini replacing the previous V10 offering, the Gallardo.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Urus",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Urus is a high performance luxury SUV manufactured by Italian automobile manufacturer Lamborghini. It was unveiled on 4 December 2017 and was put on the market for the 2018 model year.[3] The name comes from the urus, the ancestor of modern domestic cattle, also known as the aurochs.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini 350 GT",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini 350 GT was a grand tourer manufactured by Lamborghini between 1964 and 1966. It was the first production vehicle produced by Lamborghini.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini 400 GT",
                    Color = "Gray, Black, White",
                    Description= "Lamborghini 400 GT is the name given to two grand tourers produced by Italian manufacturer Lamborghini.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Miura",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Miura is a sports car produced by Italian automaker Lamborghini between 1966 and 1973. The car was the first supercar with a rear mid-engined two-seat layout, although the concept was first seen in a production road car with René Bonnet's Matra Djet, introduced in 1964.[4] This layout has since become the standard for high-performance sports and supercars.[5] When released, it was the fastest production road car.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Espada",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Lamborghini Espada is a 4-seat grand touring coupé built by Italian car manufacturer Lamborghini between 1968 and 1978.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Islero",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Islero is a grand tourer produced by Italian automaker Lamborghini between 1968 and 1969.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Jarama",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Jarama is a 2+2 grand tourer manufactured and marketed by Italian car manufacturer Lamborghini between 1970 and 1976.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Urraco",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Urraco is a 2+2 sports car manufactured by Italian automaker Lamborghini, introduced at the Turin Auto Show in 1970, marketed for model years 1972-1979, and named after a line of Miura-bred fighting bulls; the name translates to little bull.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Countach",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Countach is a rear mid-engine, rear-wheel-drive sports car produced by the Italian automobile manufacturer Lamborghini from 1974 until 1990.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Silhouette",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Silhouette P300 is a two-door two-seat mid-engined rear-wheel drive sports car, that was made in small numbers by Lamborghini between 1976 and 1979.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Jalpa",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Lamborghini Jalpa is a sports car produced by the Italian automotive manufacturer Lamborghini from 1981 until 1988. ",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini LM002",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini LM002 aka Rambo Lambo is an off-road vehicle manufactured by Lamborghini between 1986 and 1993.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Diablo",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Diablo is a high-performance mid-engine sports car built by Italian automobile manufacturer Lamborghini between 1990 and 2001.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Murciélago",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Murciélago is a sports car produced by Italian automotive manufacturer Lamborghini between 2001 and 2009.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Gallardo",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Gallardo is a sports car built by the Italian automotive manufacturer Lamborghini from 2003 to 2013.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Lamborghini Sián FKP37",
                    Color = "Gray, Black, White",
                    Description= "The Lamborghini Sián FKP 37 is a mid-engine hybrid sports car produced by the Italian automotive manufacturer Lamborghini.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Lamborghini",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Volvo()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Volvo XC60",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Volvo XC60 is a compact luxury crossover SUV manufactured and marketed by Swedish automaker Volvo Cars since 2008. It is now in its second generation.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volvo XC90",
                    Color = "Gray, Black, White",
                    Description= "The Volvo XC90 is a mid-size luxury SUV manufactured and marketed by Volvo Cars since 2002 and now in its second generation.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volvo XC40",
                    Color = "Gray, Black, White",
                    Description= "The Volvo XC40 is a subcompact luxury crossover SUV manufactured by Volvo Cars. ... It was unveiled on 21 September 2017.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volvo S60",
                    Color = "Gray, Black, White",
                    Description= "The Volvo S60 is a compact executive car manufactured and marketed by Volvo since 2000.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volvo S90",
                    Color = "Gray, Black, White",
                    Description= "The Volvo S90 is an executive sedan manufactured and marketed by Swedish automaker Volvo Cars since 2016. Its estate variant is called the Volvo V90.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volvo V60 Cross Country",
                    Color = "Gray, Black, White",
                    Description= "The Volvo V60 is a compact wagon produced by Volvo Cars related to the S60. The vehicle was first released in autumn 2010, facelifted in 2014, and is in its second generation since 2018.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volvo V90 Cross Country",
                    Color = "Gray, Black, White",
                    Description= "V90 Cross Country Ocean Race — The Volvo V90 is a mid-size luxury wagon manufactured and marketed by Swedish automaker Volvo Cars since 2016.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Volvo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> AlfaRomeo()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "AlfaRomeo Stelvio",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Alfa Romeo Stelvio (Tipo 949) is a compact luxury crossover SUV manufactured and marketed by the Alfa Romeo subdivision of Stellantis (formerly with FCA), first revealed at the 2016 Los Angeles Auto Show, and entering production at the Cassino Plant at the end of 2016.[3] It is currently Alfa Romeo's best-selling model, with roughly 43,000 sold in 2018.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Alfa Romeo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "AlfaRomeo Guilia",
                    Color = "Gray, Black, White",
                    Description= "The Alfa Romeo Giulia (Type 952) is a compact executive car produced by the Italian automobile manufacturer Alfa Romeo.[9] It was unveiled in June 2015, with market launch scheduled for February 2016,[10] and it is the first saloon offered by Alfa Romeo after the production of the 159 ended in 2011.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Alfa Romeo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "AlfaRomeo Stelvio Quadrifoglio",
                    Color = "Gray, Black, White",
                    Description= "The Alfa Romeo Stelvio (Tipo 949) is a compact luxury crossover SUV manufactured and marketed by the Alfa Romeo subdivision of Stellantis (formerly with FCA), first revealed at the 2016 Los Angeles Auto Show, and entering production at the Cassino Plant at the end of 2016.[3] It is currently Alfa Romeo's best-selling model, with roughly 43,000 sold in 2018.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Alfa Romeo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "AlfaRomeo Guilia Quadrifoglio",
                    Color = "Gray, Black, White",
                    Description= "The Alfa Romeo Giulia (Type 952) is a compact executive car produced by the Italian automobile manufacturer Alfa Romeo.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Alfa Romeo",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "AlfaRomeo Tonale",
                    Color = "Gray, Black, White",
                    Description= "The Alfa Romeo Tonale is an automobile produced by Italian car manufacturer Alfa Romeo, a brand of Stellantis. It is considered to be a crossover SUV.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Alfa Romeo",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Volkswagen()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Volkswagen Polo",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Volkswagen Polo is a supermini car (B-segment) produced by the German car manufacturer Volkswagen since 1975.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Volkswagen",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volkswagen Passat",
                    Color = "Gray, Black, White",
                    Description= "The Volkswagen Passat is a series of large family cars manufactured and marketed by the German automobile manufacturer Volkswagen since 1973, and now in its eighth generation. It has been marketed variously as the Dasher, Santana, Quantum, Magotan, Corsar and Carat. The successive generations of the Passat carry the Volkswagen internal designations B1, B2, etc.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Volkswagen",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volkswagen T-cross",
                    Color = "Gray, Black, White",
                    Description= "The Volkswagen T-Cross is a subcompact crossover SUV (B-segment) manufactured by the German automaker Volkswagen. It is based on the MQB A0 platform shared with the Polo Mk6, and was officially launched in April 2019. The car is positioned below the T-Roc and alongside the Taigo/Nivus, it is the smallest SUV model from Volkswagen.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Volkswagen",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volkswagen Touareg",
                    Color = "Gray, Black, White",
                    Description= "The Volkswagen Touareg (German pronunciation: [ˈtuːaʁɛk]) is a two-row mid-size luxury crossover SUV produced by German automaker Volkswagen Group since 2002 at the Volkswagen Bratislava Plant. The vehicle was named after the nomadic Tuareg people, inhabitants of the Saharan interior in North Africa.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Volkswagen",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Volkswagen Tiguan Allspace",
                    Color = "Gray, Black, White",
                    Description= "The Volkswagen Tiguan is an automobile produced by German manufacturer Volkswagen since 2007.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Volkswagen",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> AstonMartin()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Aston Martin DB11",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Aston Martin DB11 is a grand tourer produced by British luxury car manufacturer Aston Martin since 2016",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Aston Martin",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Aston Martin DBX",
                    Color = "Gray, Black, White",
                    Description= "The Aston Martin DBX is a mid-size luxury crossover SUV produced by British luxury car manufacturer Aston Martin.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Aston Martin",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Aston Martin Vantage",
                    Color = "Gray, Black, White",
                    Description= "The Aston Martin Vantage is a two-seater sports car manufactured by British luxury car manufacturer Aston Martin as a successor to the previous outgoing model which had been in production for 12 years. It was unveiled on 21 November 2017. Deliveries of the new Vantage began in June 2018.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Aston Martin",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Aston Martin DBS Superleggera",
                    Color = "Gray, Black, White",
                    Description= "The Aston Martin DBS, formerly called the Aston Martin DBS Superleggera before the 2022 model year,[3] is a high-performance grand tourer produced by British luxury car manufacturer Aston Martin since 2018. In June 2018, Aston Martin unveiled the car as the marque's V12 flagship grand tourer based on the DB11 V12 but featuring modifications that sets it apart from the DB11 lineage as a replacement to the Vanquish.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Aston Martin",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Tesla()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Tesla Model S",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Model S originally launched in 2012 and helped to put Tesla on the map as an automaker. Tesla has continued updating the Model S since its release, and there are currently two version: Model S and Plaid. The Long Range, Standard and Performance model names have also been recently used.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Tesla",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Tesla Model 3",
                    Color = "Gray, Black, White",
                    Description= "The Model 3 launched in the US in 2016 as the affordable alternative to the Model S, with prices having dropped to make it the most affordable Tesla. The Model 3 has been hugely successful and is the most common Tesla you'll see on the roads.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Tesla",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Tesla Model X",
                    Color = "Gray, Black, White",
                    Description= "Tesla's Model X is the soccer mom's answer to the electric car. It's an SUV-style EV capable of seating seven people, but owes a lot of its design to the original Model S, especially with that interior display.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Tesla",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Tesla Model Y",
                    Color = "Gray, Black, White",
                    Description= "The Tesla Model Y fills the space between the Model 3 and the Model X, as a compact SUV. It will seat five, offers plenty of space, but will really appeal to those looking for something more affordable than the Model X.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Tesla",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Tesla Cybertruck",
                    Color = "Gray, Black, White",
                    Description= "The Cybertruck was unveiled in November 2019, as Tesla switches its attention to a pick-up truck format. This is likely to be a lot more popular in the US than other regions, although reservations are open in other regions too.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Tesla",
                    VehicleTypeName = "Pick-up Truck",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Tesla Roadster",
                    Color = "Gray, Black, White",
                    Description= "The Tesla Roadster started the whole thing in 2008 - and was due to return in 2020 (it's been reviewed by some US sources, but otherwise is still only up for reservations only).",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Tesla",
                    VehicleTypeName = "Roadster",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Suzuki()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Suzuki Swift",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Suzuki Swift is a supermini car (B-segment) produced by Suzuki. The vehicle is classified as a B-segment marque in the European single market.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Suzuki",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Suzuki Ertiga",
                    Color = "Gray, Black, White",
                    Description= "The Suzuki Ertiga is a car manufactured by the Japanese carmaker Suzuki since 2012. It is a multi-purpose vehicle (MPV) with standard three-row seating.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Suzuki",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Suzuki XL7",
                    Color = "Gray, Black, White",
                    Description= "The Suzuki XL-7 is a mid-size SUV sold by Suzuki from 1998 to 2009, over two generations.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Suzuki",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Suzuki Ciaz",
                    Color = "Gray, Black, White",
                    Description= "The Suzuki Ciaz is a subcompact sedan produced by Suzuki since 2014. It is developed to replace the Suzuki SX4 sedan in several Asian, African.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Suzuki",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Subaru()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Subaru Outback",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Subaru Outback is an automotive nameplate used by the Japanese automaker Subaru for two different vehicles: a crossover station wagon, the Outback.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Subaru",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Subaru Forester",
                    Color = "Gray, Black, White",
                    Description= "The Subaru Forester is a compact crossover SUV that has been manufactured by Subaru since 1997.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Subaru",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Subaru XV",
                    Color = "Gray, Black, White",
                    Description= "he",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Subaru",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Subaru WRX",
                    Color = "Gray, Black, White",
                    Description= "The Subaru XV is a subcompact crossover built by Subaru as a successor to the Outback Sport in the United States and Canada, and the Impreza XV globally.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Subaru",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Subaru BRZ",
                    Color = "Gray, Black, White",
                    Description= "The Toyota 86 and the Subaru BRZ are 2+2 sports cars jointly developed by Toyota and Subaru.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Subaru",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Cadillac()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Cadillac XT4",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Cadillac XT4 is a subcompact luxury crossover SUV manufactured by General Motors since 2018 under the luxury Cadillac marque.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Cadillac",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Cadillac XT5",
                    Color = "Gray, Black, White",
                    Description= "The Cadillac XT5 (short for Crossover Touring 5) is a compact luxury / D-segment crossover SUV manufactured by General Motors.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Cadillac",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Cadillac XT6",
                    Color = "Gray, Black, White",
                    Description= "The Cadillac XT6 is a mid-size luxury crossover SUV with three-row seating manufactured by General Motors.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Cadillac",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Cadillac ESCALADE",
                    Color = "Gray, Black, White",
                    Description= "The Cadillac Escalade is a full-size luxury SUV engineered and manufactured by General Motors.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Cadillac",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Cadillac CT4",
                    Color = "Gray, Black, White",
                    Description= "The Cadillac CT4 is a compact executive sedan manufactured and marketed by Cadillac. It replaced the Cadillac ATS sedan and sits below the CT5 in Cadillac's",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Cadillac",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Cadillac CT5",
                    Color = "Gray, Black, White",
                    Description= "The Cadillac CT5 is a mid-size luxury car manufactured and marketed by General Motors under the Cadillac brand. Cadillac CT5. ",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Cadillac",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Chevrolet()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Chevrolet Trax",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Chevrolet Trax is a subcompact crossover SUV manufactured by Chevrolet since 2013. The car is based on the GM Gamma II platform, which is shared with the Chevrolet Aveo/Sonic, as well as the Opel Mokka/Buick Encore. It was also marketed as the Holden Trax in Australia, and as the Chevrolet Tracker in Russia and South America.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chevrolet TrailBlazer",
                    Color = "Gray, Black, White",
                    Description= "The Chevrolet Trailblazer or TrailBlazer is a mid-size SUV produced by Chevrolet, a division of General Motors.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chevrolet Equinox",
                    Color = "Gray, Black, White",
                    Description= "The Chevrolet Equinox is a series of mid-size, compact crossover SUVs from Chevrolet, introduced in 2004 for the 2005 model year.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chevrolet Blazer",
                    Color = "Gray, Black, White",
                    Description= "The full-size Chevrolet K5 Blazer, based on the C/K pickup chassis and built from 1969 to 1995 (renamed Blazer in 1992 and Tahoe in 1995 for the 2-door model).",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chevrolet Traverse",
                    Color = "Gray, Black, White",
                    Description= "The Chevrolet Traverse is a crossover SUV with three-row seating built by General Motors. It is built on the same platform as the GMC Acadia and Buick.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chevrolet Tahoe",
                    Color = "Gray, Black, White",
                    Description= "The Chevrolet Tahoe, and its badge engineered GMC Yukon counterpart, are full-size SUVs from General Motors, offered since 1994 and 1991, respectively. Since 1982, Chevrolet and GMC sold two different-sized SUVs under their 'Blazer' and 'Jimmy' nameplates, by introducing the smaller S-10 Blazer and GMC S-15 Jimmy for the 1983 model year, below the full-size Blazer and Jimmy models.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chevrolet Suburban",
                    Color = "Gray, Black, White",
                    Description= "The Chevrolet Suburban is a series of automobiles built by the Chevrolet division of General Motors. The name started in 1934 for the 1935 U.S. model year.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Chevrolet",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> RollsRoyce()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Rolls Royce Ghost",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Rolls-Royce Ghost is a full-sized luxury car manufactured by Rolls-Royce Motor Cars. The Ghost nameplate, named in honour of the Silver Ghost.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Rolls-Royce",
                    VehicleTypeName = "Saloon",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Rolls Royce Phantom",
                    Color = "Gray, Black, White",
                    Description= "Rolls-Royce has used the Phantom name on full-sized luxury cars over the past century: Rolls-Royce Phantom I, 1925–1931; Rolls-Royce Phantom II, 1929–1936.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Rolls-Royce",
                    VehicleTypeName = "Saloon",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Rolls Royce Cullinan",
                    Color = "Gray, Black, White",
                    Description= "The Rolls-Royce Cullinan is a full-sized luxury sport utility vehicle (SUV) produced by Rolls-Royce Motor Cars.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Rolls-Royce",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Rolls Royce Dawn",
                    Color = "Gray, Black, White",
                    Description= "The Rolls-Royce Dawn is a handmade 2+2 luxury convertible luxury grand tourer manufactured by Rolls-Royce.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Rolls-Royce",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Rolls Royce Wraith",
                    Color = "Gray, Black, White",
                    Description= "The Rolls-Royce Wraith is a full-size luxury car/grand tourer manufactured by Rolls-Royce Motor Cars and based on the chassis of the Rolls-Royce Ghost.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Rolls-Royce",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Fiat()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Fiat 500 Abarth",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Fiat 500 is an A-segment city car manufactured and marketed by the Fiat subdivision of Stellantis since 2007.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Fiat",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Fiat 500X",
                    Color = "Gray, Black, White",
                    Description= "The Fiat 500X (Type 334) is a subcompact crossover SUV manufactured and marketed by Stellantis (formerly Fiat Chrysler Automobiles), since its debut.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Fiat",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Fiat Doblo",
                    Color = "Gray, Black, White",
                    Description= "The Fiat Doblò is a panel van and leisure activity vehicle produced by Italian automaker Fiat since 2000.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Fiat",
                    VehicleTypeName = "Van",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Fiat Panda",
                    Color = "Gray, Black, White",
                    Description= "The Fiat Panda is a city car manufactured and marketed by Fiat since 1980, currently in its third generation.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Fiat",
                    VehicleTypeName = "Van",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Fiat Tipo",
                    Color = "Gray, Black, White",
                    Description= "The Fiat Tipo (Type 160) is a compact car, designed by the I.DE.A Institute design house, and produced by the Italian manufacturer Fiat.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Fiat",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Fiat Spider",
                    Color = "Gray, Black, White",
                    Description= "The Fiat 124 Sport Spider is a convertible sports car marketed by Fiat for model years 1966-1985.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Fiat",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Radical()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Radical SR8",
                    Color = "Gray, Black, White",
                    Description= "The Radical SR8 is a British sports car made by Radical Sportscars. ... Dominic Dobson drove one to victory in the 2015 Pikes Peak International Hill Climb.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Radical",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Radical SR10",
                    Color = "Gray, Black, White",
                    Description= "SR10 — Radical Sportscars is a British manufacturer and constructor of racing cars. The company was founded in January 1997 by amateur drivers and engineers.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Radical",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Radical RXC Spyder",
                    Color = "Gray, Black, White",
                    Description= "The Radical RXC is a line of track-only race cars and street-legal road cars built by British manufacturer Radical Sportscars.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Radical",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Radical RXC 600R",
                    Color = "Gray, Black, White",
                    Description= "The Radical RXC is a line of track-only race cars and street-legal road cars built by British manufacturer Radical Sportscars.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Radical",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Radical RXC GT3",
                    Color = "Gray, Black, White",
                    Description= "The Radical RXC is a line of track-only race cars and street-legal road cars built by British manufacturer Radical Sportscars.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Radical",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Radical RXC GT - ROAD",
                    Color = "Gray, Black, White",
                    Description= "The Radical RXC is a line of track-only race cars and street-legal road cars built by British manufacturer Radical Sportscars.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Radical",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Peugeot()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Peugeot 3008",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Peugeot 3008 is a compact crossover SUV manufactured and marketed by Peugeot.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Peugeot",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Peugeot 5008",
                    Color = "Gray, Black, White",
                    Description= "he",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Peugeot",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Peugeot 2008",
                    Color = "Gray, Black, White",
                    Description= "The Peugeot 5008 is a series of automobiles produced by the French manufacturer Peugeot since 2009.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Peugeot",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Peugeot Traveller",
                    Color = "Gray, Black, White",
                    Description= "The Peugeot Traveler is a van from the French car manufacturer Peugeot that was presented at the Geneva Motor Show in March 2016.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Peugeot",
                    VehicleTypeName = "Van",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Nissan()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Nissan X-TRAIL",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Nissan X-Trail is a compact crossover SUV (C-segment) produced by the Japanese automaker Nissan since 2000. It was one of Nissan's first crossover SUVs.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Nissan",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Nissan Almera Tino",
                    Color = "Gray, Black, White",
                    Description= "The Nissan Almera Tino is a car which was produced by the Japanese automaker Nissan between 1998 and 2006 in Japan, as the Nissan Tino.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Nissan",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Nissan Micra",
                    Color = "Gray, Black, White",
                    Description= "The Nissan Micra, also known as the Nissan March is a supermini car (B-segment) that has been produced by the Japanese automobile manufacturer Nissan.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Nissan",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Nissan Qashqai",
                    Color = "Gray, Black, White",
                    Description= "The Nissan Qashqai is a compact crossover SUV (C-segment) developed and produced by the Japanese car manufacturer Nissan since 2006.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Nissan",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Nissan Navara",
                    Color = "Gray, Black, White",
                    Description= "The Nissan Navara is a nameplate used for Nissan pickup trucks with D21, D22, D40 and D23 model codes.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Nissan",
                    VehicleTypeName = "Pick-up Truck",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Nissan Primera",
                    Color = "Gray, Black, White",
                    Description= "The Nissan Primera is a large family car which was produced by the Japanese automaker Nissan from 1990 to 2007, for the markets in Japan and Europe.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Nissan",
                    VehicleTypeName = "Pick-up Truck",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Kia()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Kia Optima",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Kia K5, formerly known as the Kia Optima, is a mid-size car manufactured by Kia since 2000 and marketed globally through various nameplates. First generation cars were mostly marketed as the Optima, although the Kia Magentis name was used in Europe and Canada when sales began there in 2002.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Sorento",
                    Color = "Gray, Black, White",
                    Description= "The Kia Sorento (Korean: 기아 쏘렌토, romanized: Gia Sorento) is a mid-size crossover SUV (formerly a body-on-frame SUV until 2009) produced since 2002.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Seltos",
                    Color = "Gray, Black, White",
                    Description= "The Kia Seltos (Korean: 기아 셀토스) is a subcompact crossover SUV manufactured by Kia. Introduced in mid-2019, the Seltos is positioned between the smaller Stonic, Soul, or Sonet and the larger Sportage in Kia's global SUV lineup.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Carnival",
                    Color = "Gray, Black, White",
                    Description= "The Kia Carnival (Korean: 기아 카니발) is a minivan manufactured by Kia since 1998. It is marketed globally under various nameplates — prominently as the Kia Sedona — which is now unused in favor of the Carnival.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Cerato",
                    Color = "Gray, Black, White",
                    Description= "The Kia Cerato (also known as the Kia Forte in North America, K3 in South Korea or the Forte K3 or Shuma in China) is a compact car produced by the South Korean manufacturer Kia since 2003. In 2008, the Cerato nameplate was replaced by the Forte nameplate in the North American market and the K3 nameplate in South Korea.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Sonet",
                    Color = "Gray, Black, White",
                    Description= "The Kia Sonet is a subcompact crossover SUV manufactured by Kia since 2020. Developed mainly for the Indian market, the Sonet is positioned below the Seltos and is closely related to the similarly-sized sibling Hyundai Venue",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia K3",
                    Color = "Gray, Black, White",
                    Description= "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia, New Zealand and Russia, is a compact car manufactured by South Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Soluto",
                    Color = "Gray, Black, White",
                    Description= "The Kia Pegas (Chinese: 起亚焕驰; pinyin: Qǐyà Huànchí) is an entry subcompact sedan (B-segment) manufactured in China by the Dongfeng Yueda Kia joint venture. It is sold under the Pegas nameplate in China and parts of the Middle East, and as the Kia Soluto in parts of Latin America and Southeast Asia.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Quoris",
                    Color = "Gray, Black, White",
                    Description= "The Kia K9, marketed as the Kia K900 in the United States and Canada and as the Kia Quoris in other export markets, is a full-size[1][2] luxury sedan manufactured and marketed by Kia, now in its second generation.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Morning",
                    Color = "Gray, Black, White",
                    Description= "The Kia Picanto is a city car produced by the South Korean manufacturer Kia since 2004. It is also known as the Kia Morning (Korean: 기아 모닝, romanized: Gia Moning) in South Korea, Hong Kong, Taiwan (first two generations) and Chile, Kia EuroStar in Taiwan (first generation), Kia New Morning in Vietnam[1] and the Naza Suria or Naza Picanto in Malaysia (first generation).",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "Hatchback",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kia Rondo",
                    Color = "Gray, Black, White",
                    Description= "The Kia Carens (Korean: 기아 카렌스) is a car manufactured by Kia since 1999, spanning over four generations, and was marketed worldwide under various nameplates, prominently as the Kia Rondo.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kia",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Mitsubishi()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Mitsubishi Outlander",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Mitsubishi Outlander is a compact crossover SUV manufactured by Japanese automaker Mitsubishi Motors.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Mitsubishi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mitsubishi Xpander",
                    Color = "Gray, Black, White",
                    Description= "The Mitsubishi Xpander is a car manufactured by Mitsubishi Motors. It is a compact MPV with standard three-row seating and has also been prominently marketed as a crossover MPV",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Mitsubishi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mitsubishi Pejero Sport",
                    Color = "Gray, Black, White",
                    Description= "The Mitsubishi Pajero Sport is a mid-size SUV produced by the Japanese manufacturer Mitsubishi Motors using the Pajero nameplate since 1996 that has spanned over three generations and based on the Triton pickup truck. Mitsubishi has formerly used the Mitsubishi Challenger (Japanese: 三菱・チャレンジャー, Hepburn: Mitsubishi Charenjā) name in Japan and some international markets, but since the third generation, the Pajero Sport/Montero Sport/Shogun Sport was the name used instead.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Mitsubishi",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mitsubishi Attrage",
                    Color = "Gray, Black, White",
                    Description= "The Mitsubishi Mirage is a range of cars produced by the Japanese manufacturer Mitsubishi from 1978 until 2003 and again since 2012. The hatchback models produced between 1978 and 2003 were classified as subcompact cars, while the sedan and station wagon models, marketed prominently as the Mitsubishi Lancer, were the compact offerings.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mitsubishi",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> LandRover()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Land Rover Range Rover",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Land Rover Range Rover is a 4x4 motor car produced by Land Rover, a marque and sub-brand of Jaguar Land Rover. ",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "LandRover",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Land Rover Defender",
                    Color = "Gray, Black, White",
                    Description= "The Land Rover Defender (initially introduced as the Land Rover 110 / One Ten, and in 1984 joined by the Land Rover 90 / Ninety, plus the new, extra-length Land.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "LandRover",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Land Rover Discovery",
                    Color = "Gray, Black, White",
                    Description= "The Land Rover Discovery, also commonly known as the Disco, is a series of medium to large premium SUVs, produced under the Land Rover marque.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "LandRover",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Land Rover Range Rover Sport",
                    Color = "Gray, Black, White",
                    Description= "The Land Rover Range Rover Sport, generally known simply as the Range Rover Sport, is a mid-size luxury SUV produced under their Land Rover marque.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "LandRover",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Land Rover Range Rover Evoque",
                    Color = "Gray, Black, White",
                    Description= "The Land Rover Range Rover Evoque is a series of compact luxury crossover SUVs developed and produced by Jaguar Land Rover, a British car manufacturer.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "LandRover",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Land Rover Range Rover Velar",
                    Color = "Gray, Black, White",
                    Description= "The Land Rover Range Rover Velar (generally known simply as the Range Rover Velar) (/ˈvɛlər/) is a crossover SUV produced by British automotive company.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "LandRover",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> MG()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "MG ZS",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The MG ZS is a subcompact crossover SUV produced by the Chinese automotive manufacturer SAIC Motor under the British MG marque. Announced at the 2016.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "MG",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "MG MG5",
                    Color = "Gray, Black, White",
                    Description= "The MG 5 is a series of compact cars that has been produced by SAIC Motor under the MG marque since 2012.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "MG",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "MG HS",
                    Color = "Gray, Black, White",
                    Description= "The MG HS is a compact crossover SUV manufactured by Chinese automobile manufacturer SAIC Motor under the British MG marque.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "MG",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Mclaren()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Mclaren 540C Coupe",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "A mid-mounted 533-hp 3.8-liter twin-turbo V8 drives the rear wheels of the 540C. This is McLaren’s entry level model. Despite its lower price, the 540C inherits performance-aiding technologies from its pricier siblings such as a system that brakes a rear wheel to help the car around a corner. 0-62mph in 3.5 seconds, 0-124mph in 10.5 seconds.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren 570S Coupe",
                    Color = "Gray, Black, White",
                    Description= "This is the car you buy when you are sick of your Porsche. It is a true sports car experience, very driver centric with epic performance. We have found the 570S as the perfectly positioned car in the McLaren range. It has more performance than you could ever need on the road. It is lightweight, has direct steering and amazing driving dynamics.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren McLaren 570GT",
                    Color = "Gray, Black, White",
                    Description= "The 570GT is an interesting model now that McLaren has launched a focused GT model. It adds extra comfort and practicality to the 570 body style. Performance is still tremendous, but it takes the edge off in some ways (which is good). Every bit a McLaren, it’s optimized for the road and makes the ultimate experience that’s perfect for daily use and weekends away.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren McLaren 600LT Coupe",
                    Color = "Gray, Black, White",
                    Description= "The limited-edition 600LT is the ultimate version of McLaren’s 570S/GT range (think of it like the 458 Speciale as to the 458). It uses a variation of 570S’ McLaren’s twin-turbo 3.8-liter V8, in this guise making 592 horsepower and 457 lb-ft of torque. The handling is perfectly balanced and reassures you with its predictable nature.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren GT",
                    Color = "Gray, Black, White",
                    Description= "The McLaren GT is McLaren’s answer for executives looking for a high performance luxury car. The team focused on creating space and comfort, making cross-country trips and daily driving more enjoyable. The car is also slightly more subdued in terms of design. Under the skin it is still a beast, with McLaren's all new 4.0 litre twin-turbo V8.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren 720S Coupe",
                    Color = "Gray, Black, White",
                    Description= "The McLaren 720S is a sensational supercar, easily the best of the current breed. It has a twin-turbocharged 4.0-liter V-8 that produces 710 horsepower and 568 lb-ft of torque. It looks gorgeous too. Unrivaled chassis tuning, absurd amounts of speed, unparalleled acceleration numbers and a package that looks stunning.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Couple",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren 765LT",
                    Color = "Gray, Black, White",
                    Description= "The 765LT replaces the 675LT as the newest limited-production track car in McLaren’s Super Series range. As with previous LT models, weight saving is the key focus for the 765LT, losing 160+lbs compared to the 720S. For the ﬁrst time McLaren has also adjusted some of the 765LT’s inner workings too. This is peak McLaren and peak performance.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Supercar",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren Senna",
                    Color = "Gray, Black, White",
                    Description= "Named after Formula 1 driver Ayrton Senna, the McLaren Senna is a track-focused hypercar. Its aggressive appearance tells you immediately that this thing is designed to destroy lap times. The McLaren Senna is the fastest McLaren road car ever around a racetrack, with downforce numbers up there with proper race cars.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren Speedtail",
                    Color = "Gray, Black, White",
                    Description= "This is the successor to the McLaren F1 (including iconic 3-seat layout). The McLaren Speedtail is a limited-production hypercar (only 106 will be built). Whereas other McLaren’s blend handling, acceleration, top speed, and driving dynamics in a harmonious package, the Speedtail has a more singular focus. Their first ever Hyper-GT and most aero-efficient car ever.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren Senna GTR",
                    Color = "Gray, Black, White",
                    Description= "Track-focused update to the McLaren hypercar, the Senna. Freed from all road and motorsport rules, it pushes things to the max. Pared-back, pumped-up then unleashed for track use only… it is, simply put, ferocious. Try 1000kg of downforce and a power to weight ratio of 684 horsepower per tonne. This is a serious track-only car for the serious racer.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Mclaren Artura",
                    Color = "Gray, Black, White",
                    Description= "We know it is McLaren's next-gen high-performance hybrid and that the name is Artura. Artura will feature a ton of new parts, including a new carbon-fiber chassis called the MCLA. It’ll house an entirely new powertrain and electrical architecture, too, riding on a platform optimized for the unspecified number of electric motors. Going to be insane.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Mclaren",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Maserati()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Maserati Quattroporte",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Maserati Quattroporte is a four-door full-size luxury sports sedan produced by Italian automobile manufacturer Maserati.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Maserati",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Maserati Ghibli",
                    Color = "Gray, Black, White",
                    Description= "Maserati Ghibli is the name of three different cars produced by Italian automobile manufacturer Maserati: the AM115, a V8 grand tourer from 1967 to 1973.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Maserati",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Maserati Levante",
                    Color = "Gray, Black, White",
                    Description= "The Maserati Levante (Tipo M161) is a mid-size luxury crossover SUV based on the Kubang concept car that debuted at the 2011 Frankfurt Auto Show.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Maserati",
                    VehicleTypeName = "SUV",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Chrysler()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Chrysler 200",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Chrysler 200 is a mid-size sedan that was manufactured and marketed by Chrysler from model years 2011 to 2017 across two generations in four-door sedan.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Chrysler",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chrysler Crossfire",
                    Color = "Gray, Black, White",
                    Description= "The Chrysler Crossfire is a rear-wheel drive, two-seat sports car that was sold by Chrysler and built by Karmann of Germany for the 2004 to 2008 model years.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Chrysler",
                    VehicleTypeName = "Sports car",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Chrysler Sebring",
                    Color = "Gray, Black, White",
                    Description= "The Chrysler Sebring is a line of mid-size automobiles that was sold from 1995 through 2010 by Chrysler.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Chrysler",
                    VehicleTypeName = "Sedan",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Kawasaki()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Kawasaki Ninja 300",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Kawasaki Ninja 300, or EX300, is a 296 cc (18.1 cu in) Ninja series sport bike introduced by Kawasaki in 2012 for the 2013 model year.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kawasaki Ninja H2R",
                    Color = "Gray, Black, White",
                    Description= "The Kawasaki Ninja H2 is a supercharged supersport class motorcycle in the Ninja sportbike series, manufactured by Kawasaki Heavy Industries.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kawasaki Z900",
                    Color = "Gray, Black, White",
                    Description= "The Kawasaki Z900 is a standard motorcycle of the Kawasaki Z series made by Kawasaki since 2017. It replaced the Z800.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kawasaki Ninja 650",
                    Color = "Gray, Black, White",
                    Description= "The Kawasaki Ninja 650R, also called ER-6f or EХ-6, is a motorcycle in the Ninja series from the Japanese manufacturer Kawasaki sold since 2006.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kawasaki Ninja ZX-10R",
                    Color = "Gray, Black, White",
                    Description= "The Kawasaki Ninja ZX-10R is a motorcycle in the Ninja sport bike series from the Japanese manufacturer Kawasaki, the successor to the Ninja ZX-9R.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kawasaki Z650",
                    Color = "Gray, Black, White",
                    Description= "The Kawasaki Z650 was produced as a 652 cc (39.8 cu in) standard motorcycle by Kawasaki from 1976 until 1983. It had a four-cylinder four-stroke.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Kawasaki Ninja 1000",
                    Color = "Gray, Black, White",
                    Description= "The Kawasaki Ninja 1000 SX is a motorcycle in the Ninja series from the Japanese manufacturer Kawasaki sold since 2011.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Kawasaki",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Yamaha()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Yamaha SR400",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Yamaha SR400 (1978–2021) and SR500 (1978–1999) are single-cylinder, air-cooled, two-passenger motorcycles manufactured in Japan by Yamaha Motor Company.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Yamaha",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Yamaha MT-15",
                    Color = "Gray, Black, White",
                    Description= "Yamaha MT-15 is a motorcycle manufactured by Yamaha since 2018. It based on the Yamaha YZF-R15, with 155cc water-cooled single-cylinder engine.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Yamaha",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Yamaha YZF R15",
                    Color = "Gray, Black, White",
                    Description= "The Yamaha YZF-R15 is a single cylinder sport bike made by Yamaha Motor Company since 2008.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Yamaha",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Yamaha FZS-FI",
                    Color = "Gray, Black, White",
                    Description= "In 2014, the fuel-injected version, called FZ FI, went on sale in India. Its engine displacement was reduced to 149 cc (9.1 cu in) from 153 cc (9.3 cu in),",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Yamaha",
                    VehicleTypeName = "Lightweight Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Yamaha FZ-FI",
                    Color = "Gray, Black, White",
                    Description= "In 2014, the fuel-injected version, called FZ FI, went on sale in India. Its engine displacement was reduced to 149 cc (9.1 cu in) from 153 cc (9.3 cu in).",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Yamaha",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> HarleyDavidson()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Harley Davidson Electra Glide",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The new Harley Davidson Electra Glide motorcycle is equipped with the Milwaukee-Eight 107 engine. For 2019, the new electronic cruise control system, rear dampers with manually adjustable emulsion technology, a 49 mm front suspension for the Showa valve and Brembo brakes with optional Reflex Linked and ABS features.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Dyna",
                    Color = "Gray, Black, White",
                    Description= "The 2016 MY Harley Davidson Switchback sports an air-cooled, four-stroke, 1690cc, Twin Cam 103 engine paired to a six-speed manual transmission, that produces 126 Nm of torque at 3500 rpm.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson FREEWHEELER",
                    Color = "Gray, Black, White",
                    Description= "Their iconic look, distinctive sound and massive torque make them instantly recognizable, but the Milwaukee-Eight 107 and Milwaukee-Eight 114 engines take the Harley-Davidson V-Twin to a place it’s never been. They’re the most powerful, coolest-running motors we’ve ever built. Smoother, stronger and more durable.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Street Glide",
                    Color = "Gray, Black, White",
                    Description= "The 2016 MY Harley Davidson Street Glide Special sports an air-cooled, four-stroke, 1690cc, High Output Twin Cam 103 powerhouse paired to a six-speed manual transmission and can reach its peak torque of 138 Nm at 3500 rpm.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Ultra",
                    Color = "Gray, Black, White",
                    Description= "For 2017, the Harley Davidson Ultra Limited receives the Twin-Cooled version of the 1745 cc Milwaukee-Eight engine. While the Ultra Limited has utilized the Twin-Cooled version of the Twin Cam 103 engine since 2014,",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Sportster",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The CVO Pro Street Breakout gives you dark style and premium finishes with show-stopping paint.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson CVO",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "For 2017, Harley Davidson comes with a new model CVO Pro Street Breakout. The ultimate Softail muscle cruiser features a stout 110ci engine.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Road King",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The 2016 MY Harley Davidson Road King Classic sports an air-cooled, four-stroke, 1690cc, High Output Twin Cam 103 powerplant paired to a six-speed manual transmission, and can produce 138 Nm of torque at 3500 rpm.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Firefighter",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The 2013 MY Harley Davidson Electra Glide Ultra Classic Firefighter sports an air-cooled, 1690cc, Twin Cam 103 engine that can produce 135 Nm of torque. It is one of the most capable touring motorcycles ever to have been designed by the House of Milwaukee.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Police",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The 2011 MY Harley Davidson Police XL883L Sportster sports an air-cooled, 883cc, Evolution V-twin powerhouse mated to a five-speed manual transmission that can produce 75 Nm of torque at 3500 rpm.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Harley Davidson Sport Glide",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The 2018 Harley-Davidson Sport Glide uses the same Softail chassis and Milwaukee-Eight 107 engine we quickly fell in love with. We’ve been down this route a number of times already, so you can read about the new Softail features here and the Milwaukee-Eight motor.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Harley Davidson",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> Aprilia()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Aprilia SR 125",
                    Color = "Gray, Black, White",
                    Description= "The Aprilia RS125 is a GP derived replica sport production motorcycle. It is powered by a Rotax single cylinder 124.8 cc.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Aprilia",
                    VehicleTypeName = "Electric Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Aprilia Storm 125",
                    Color = "Gray, Black, White",
                    Description= "Aprilia is an Italian motorcycle manufacturer founded immediately after World War II in Noale, Italy, by Alberto Beggio.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Aprilia",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Aprilia RS 660",
                    Color = "Gray, Black, White",
                    Description= "Aprilia is an Italian motorcycle manufacturer founded immediately after World War II in Noale, Italy, by Alberto Beggio.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Aprilia",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> KTM()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "KTM RC 390",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The KTM 390 Duke and RC 390 are 373.2 cc (22.77 cu in) displacement single-cylinder engine motorcycles assembled by Bajaj Auto.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "KTM",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "KTM Duke 390",
                    Color = "Gray, Black, White",
                    Description= "The KTM 390 Duke and RC 390 are 373.2 cc (22.77 cu in) displacement single-cylinder engine motorcycles assembled by Bajaj Auto.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "KTM",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "KTM 790 Duke",
                    Color = "Gray, Black, White",
                    Description= "The KTM 790 Duke is a naked parallel-twin motorcycle, manufactured by KTM from 2017. The Duke's 799 cc (48.8 cu in) liquid cooled eight-valve DOHC engine.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "KTM",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "KTM 250 Duke",
                    Color = "Gray, Black, White",
                    Description= "",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "KTM",
                    VehicleTypeName = "Sport Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> MotoGuzzi()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "MotoGuzzi Le Mans 1000",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "he",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "MotoGuzzi",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "MotoGuzzi Nevada 750 Aquila Nera",
                    Color = "Gray, Black, White",
                    Description= "he",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "MotoGuzzi",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "MotoGuzzi California 1400 Custom",
                    Color = "Gray, Black, White",
                    Description= "he",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "MotoGuzzi",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }

        public static List<VehicleRequest> RoyalEnfield()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Bullet",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Royal Enfield Bullet was originally an overhead-valve single-cylinder four-stroke motorcycle made by Royal Enfield in Redditch, Worcestershire.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Interceptor",
                    Color = "Gray, Black, White",
                    Description= "The Interceptor is a British motorcycle made by Royal Enfield between 1960 and 1970. The 700 Interceptor introduced in 1960.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Continental",
                    Color = "Gray, Black, White",
                    Description= "The Royal Enfield Continental GT is a Neo-retro Café Racer motorcycle produced by Royal Enfield (India).",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Classic",
                    Color = "Gray, Black, White",
                    Description= "Royal Enfield Classic 350 and Classic 500 are models of Royal Enfield motorcycles which have been in production since 2009.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Meteor",
                    Color = "Gray, Black, White",
                    Description= "The Meteor is an Indian Cruiser-style motorcycle manufactured by Royal Enfield in India. The model was developed by engineers based at Royal Enfield.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Himalayan",
                    Color = "Gray, Black, White",
                    Description= "The Himalayan is an Indian adventure touring motorcycle manufactured by Royal Enfield, premiering in February 2015 and launched early 2016.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Royal Enfieldc Scram",
                    Color = "Gray, Black, White",
                    Description= "Royal Enfield was a brand name under which The Enfield Cycle Company Limited of Redditch, Worcestershire sold motorcycles, bicycles, lawnmowers.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Royal Enfieldc",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Benelli()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Benelli Imperiale 400",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "Benelli Q.J. is an Italian company, based in the city of Pesaro in the Marche region, that produces motorcycles and scooters.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Benelli",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Benelli TRK 502",
                    Color = "Gray, Black, White",
                    Description= "Benelli Q.J. is an Italian company, based in the city of Pesaro in the Marche region, that produces motorcycles and scooters.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Benelli",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Benelli 502 C",
                    Color = "Gray, Black, White",
                    Description= "Benelli Q.J. is an Italian company, based in the city of Pesaro in the Marche region, that produces motorcycles and scooters.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Benelli",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Benelli Leoncino 500",
                    Color = "Gray, Black, White",
                    Description= "Benelli Q.J. is an Italian company, based in the city of Pesaro in the Marche region, that produces motorcycles and scooters.",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Benelli",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Benelli TRK 251",
                    Color = "Gray, Black, White",
                    Description= "Benelli Q.J. is an Italian company, based in the city of Pesaro in the Marche region, that produces motorcycles and scooters.",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Benelli",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Victory()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Victory Cross Country",
                    Color = "Gray, Black, White",
                    Description= "The 2015 MY Victory Cross Country Tour is one of the most comfortable machines ever to be designed by the House of Victory Lake.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Victory",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Victory Gunner",
                    Color = "Gray, Black, White",
                    Description= "For riders who like a form foothold on the ground when stopped, Victory has launched the 2015 MY Gunner. At its heart lies a powerful, air-cooled,",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Victory",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Victory High-ball",
                    Color = "Gray, Black, White",
                    Description= "For cruiser fans who want a more modern touch to their machine, Victory have launched the 2015 MY Hammer 8-ball. At its heart lies a powerful, air-cooled, 1731cc, 50-degree V-twin powerhouse paired to a dependable,",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "Victory",
                    VehicleTypeName = "Motor Cruiser",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> Vespa()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "Vespa GTS Super",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "The Vespa GTS range is a scooter currently manufactured by Piaggio under the Vespa brand. Piaggio Vespa GTS. Vespa GTS 250 i.e..jpg. Vespa GTS 250.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "Vespa",
                    VehicleTypeName = "Super Bike",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Vespa Primavera",
                    Color = "Gray, Black, White",
                    Description= "Vespa is an Italian luxury brand of scooter manufactured by Piaggio. The name means wasp in Italian.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "Vespa",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Vespa Sprint",
                    Color = "Gray, Black, White",
                    Description= "Vespa Sprint is a 150cc, 2 stroke scooter made by Piaggio from 1965 to 1976. ... The scooter came in two different versions.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "Vespa",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                }
            };
        }

        public static List<VehicleRequest> SYM()
        {
            return new List<VehicleRequest>()
            {
                new VehicleRequest()
                {
                    Name = "SYM Allo 50",
                    Color = " Blue, Gray, Black, Orange, Red, White",
                    Description= "Released in 2011, the Allo 50 is an excellent and reliable scooter from SYM Motors. The retro design of this ride features a 4 stroke engine performance, perfect for quick drives around the city.",
                    Amount = 15,
                    ModelYear = 190,
                    LicensePlate = "92F1-001001",
                    RentalPrice = 300,
                    DepositPrice = 290,
                    VehicleLineName = "SYM",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Sym Attila",
                    Color = "Gray, Black, White",
                    Description= "A respectable 8 hp performance is what you can expect from the wonderful Attila. This scooter comes with a variable speed transmission gearbox system for the control that you need, especially in the urban jungle.",
                    Amount = 10,
                    ModelYear = 1000,
                    LicensePlate = "92F1-001002",
                    RentalPrice = 88,
                    DepositPrice = 78,
                    VehicleLineName = "SYM",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Sym Citycom 125",
                    Color = "Gray, Black, White",
                    Description= "Enjoy an aesthetic drive today. Released in 2008, the Citycom 125 is still a respectable ride today. This fashionable scooter features a nice and stylish luggage box that can fit two helmets. A 4 valve cylinder engine powers the scooter, a modest motoring performance with a rated top speed of 106 km/h.",
                    Amount = 11,
                    ModelYear = 1899,
                    LicensePlate = "92F1-001003",
                    RentalPrice = 78,
                    DepositPrice = 60,
                    VehicleLineName = "SYM",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Sym Cruisym 125",
                    Color = "Gray, Black, White",
                    Description= "A perfect blend of sports and urban aesthetics, the Cruisym 125 is a multifunctional scooter perfect for all sorts of needs. Featuring LED signal lights and an upgraded suspension system, this is one stylish and safe ride!",
                    Amount = 12,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "SYM",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Sym Super Duke 125",
                    Color = "Gray, Black, White",
                    Description= "An early model, the Super Duke 125 was released in 1997 yet still presents itself as a reliable scooter during its time. A single cylinder performance, this scooter has a 10 hp generation that was indeed pretty impressive during its launch!",
                    Amount = 13,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "SYM",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
                new VehicleRequest()
                {
                    Name = "Sym Fiddle 125 Liquid Cooled",
                    Color = "Gray, Black, White",
                    Description= "The Fiddle 125 Liquid Cooled presents a retro style matched with some really innovative motoring features.",
                    Amount = 14,
                    ModelYear = 1234,
                    LicensePlate = "92F1-001004",
                    RentalPrice = 60,
                    DepositPrice = 55,
                    VehicleLineName = "SYM",
                    VehicleTypeName = "Motor Scooter",
                    VehicleProperties = new List<VehiclePropertyRequest>()
                    {

                    }
                },
            };
        }
        #endregion
    }
}
