using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedActionItems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionItem>().HasData(

                  new ActionItem
                  {
                      ActionId = 1,
                      ActionName = "Crab walk",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 2,
                      ActionName = "Take giant steps",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 3,
                      ActionName = "Crawl",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 4,
                      ActionName = "Dance",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 5,
                      ActionName = "Skip",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 6,
                      ActionName = "Penguin walk",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 7,
                      ActionName = "Tip toe",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 8,
                      ActionName = "Hop",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 9,
                      ActionName = "Walk backwards",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 10,
                      ActionName = "Spin",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 11,
                      ActionName = "Gallop",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 12,
                      ActionName = "Roll",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 13,
                      ActionName = "Run",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 14,
                      ActionName = "Frog hop",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 15,
                      ActionName = "Jumping jack",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 16,
                      ActionName = "Lunge",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 17,
                      ActionName = "Tightrope",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 18,
                      ActionName = "Hop on one leg",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 19,
                      ActionName = "March",
                      Category = "default",
                      Advanced = false
                  },
                  new ActionItem
                  {
                      ActionId = 20,
                      ActionName = "Skate",
                      Category = "default",
                      Advanced = false
                  }
          );
        }
        
        public static void SeedPlaceItems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaceItem>().HasData(

                new PlaceItem
                {
                    PlaceId = 1,
                    PlaceName = "to the fridge",
                    Category = "home"                     
                },
                new PlaceItem
                {
                    PlaceId = 2,
                    PlaceName = "to a sink",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 3,
                    PlaceName = "to the front door",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 4,
                    PlaceName = "to four walls",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 5,
                    PlaceName = "to two lightswitches",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 6,
                    PlaceName = "to a tv",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 7,
                    PlaceName = "to a mirror",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 8,
                    PlaceName = "to a plant",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 9,
                    PlaceName = "to a bathtub",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 10,
                    PlaceName = "to a shower",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 11,
                    PlaceName = "to a bookcase",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 12,
                    PlaceName = "to a trashcan",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 13,
                    PlaceName = "around a chair",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 14,
                    PlaceName = "to a bedroom",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 15,
                    PlaceName = "to three rooms",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 16,
                    PlaceName = "around a table",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 17,
                    PlaceName = "under a table and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 18,
                    PlaceName = "over a bed",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 19,
                    PlaceName = "over a sofa and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 20,
                    PlaceName = "to two rugs",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 21,
                    PlaceName = "to two doors",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 22,
                    PlaceName = "to a toilet",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 23,
                    PlaceName = "to a closet",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 24,
                    PlaceName = "to a window and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 25,
                    PlaceName = "to something red",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 26,
                    PlaceName = "to something blue",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 27,
                    PlaceName = "to something yellow",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 28,
                    PlaceName = "to something green",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 29,
                    PlaceName = "to something purple",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 30,
                    PlaceName = "to something orange",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 31,
                    PlaceName = "to something pink",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 32,
                    PlaceName = "behind a curtain and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 33,
                    PlaceName = "to a toy and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 34,
                    PlaceName = "to a picture and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 35,
                    PlaceName = "to a laundry basket",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 36,
                    PlaceName = "to a computer",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 37,
                    PlaceName = "to two lamps",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 38,
                    PlaceName = "to a shoe and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 39,
                    PlaceName = "over a pillow and back",
                    Category = "home"
                },
                new PlaceItem
                {
                    PlaceId = 40,
                    PlaceName = "to your favorite thing",
                    Category = "home"
                }

                );
        }

        public static void SeedChallengeItems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChallengeItem>().HasData(
                               
                new ChallengeItem
                {
                    ChallengeId = 1,
                    ChallengeName = "with a book in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 2,
                    ChallengeName = "with a book in your right hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 3,
                    ChallengeName = "with a book on your head!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 4,
                    ChallengeName = "with a book inside your clothes!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 5,
                    ChallengeName = "with a book under your arm!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 6,
                    ChallengeName = "with a book between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 7,
                    ChallengeName = "with a book between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 8,
                    ChallengeName = "with a book under your chin!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 9,
                    ChallengeName = "with a book behind your back!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 10,
                    ChallengeName = "with a ball in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 11,
                    ChallengeName = "with a ball in your right hand!",
                    Category = "default",
                    Advanced = false
                },              
                new ChallengeItem
                {
                    ChallengeId = 12,
                    ChallengeName = "with a ball inside your clothes!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 13,
                    ChallengeName = "with a ball under your arm!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 14,
                    ChallengeName = "with a ball between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 15,
                    ChallengeName = "with a ball between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 16,
                    ChallengeName = "with a ball under your chin!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 17,
                    ChallengeName = "with a bottle in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 18,
                    ChallengeName = "with a bottle in your right hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 19,
                    ChallengeName = "with a bottle inside your clothes!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 20,
                    ChallengeName = "with a bottle under your arm!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 21,
                    ChallengeName = "with a bottle between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 22,
                    ChallengeName = "with a bottle between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 23,
                    ChallengeName = "with a bottle under your chin!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 24,
                    ChallengeName = "with a stuffed animal in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 25,
                    ChallengeName = "with a stuffed animal in your right hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 26,
                    ChallengeName = "with a stuffed animal on your head!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 27,
                    ChallengeName = "with a stuffed animal inside your clothes!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 28,
                    ChallengeName = "with a stuffed animal under your arm!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 29,
                    ChallengeName = "with a stuffed animal between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 30,
                    ChallengeName = "with a stuffed animal between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 31,
                    ChallengeName = "with a stuffed animal under your chin!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 32,
                    ChallengeName = "with a stuffed animal behind your back!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 33,
                    ChallengeName = "with a pillow in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 34,
                    ChallengeName = "with a pillow in your right hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 35,
                    ChallengeName = "with a pillow on your head!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 36,
                    ChallengeName = "with a pillow inside your clothes!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 37,
                    ChallengeName = "with a pillow under your arm!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 38,
                    ChallengeName = "with a pillow between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 39,
                    ChallengeName = "with a pillow between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 40,
                    ChallengeName = "with a pillow under your chin!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 41,
                    ChallengeName = "with a pillow behind your back!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 42,
                    ChallengeName = "with a broom in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 43,
                    ChallengeName = "with a broom in your right hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 44,
                    ChallengeName = "with a broom over your head!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 45,
                    ChallengeName = "with a broom behind your back!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 46,
                    ChallengeName = "with a broom under your arm!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 47,
                    ChallengeName = "with a broom between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 48,
                    ChallengeName = "with a broom between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 49,
                    ChallengeName = "with a broom under your chin!",
                    Category = "default",
                    Advanced = false
                },      
                new ChallengeItem
                {
                    ChallengeId = 50,
                    ChallengeName = "with a blanket over your head!",
                    Category = "default",
                    Advanced = false
                },                
                new ChallengeItem
                {
                    ChallengeId = 51,
                    ChallengeName = "with a blanket behind your back!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 52,
                    ChallengeName = "with a spoon between your teeth!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 53,
                    ChallengeName = "with a spoon on your nose!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 54,
                    ChallengeName = "with a cup in your left hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 55,
                    ChallengeName = "with a cup in your right hand!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 56,
                    ChallengeName = "with a cup on your head!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 57,
                    ChallengeName = "with a cup inside your clothes!",
                    Category = "default",
                    Advanced = false
                },                
                new ChallengeItem
                {
                    ChallengeId = 58,
                    ChallengeName = "with a cup between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 59,
                    ChallengeName = "with a cup between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 60,
                    ChallengeName = "with a cup under your chin!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 61,
                    ChallengeName = "with a cup on your shoulder!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 62,
                    ChallengeName = "with a paper on your head!",
                    Category = "default",
                    Advanced = false
                },            
                new ChallengeItem
                {
                    ChallengeId = 63,
                    ChallengeName = "with a paper between your elbows!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 64,
                    ChallengeName = "with a paper between your knees!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 65,
                    ChallengeName = "while bouncing a ball!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 66,
                    ChallengeName = "in a pillow case!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 67,
                    ChallengeName = "backwards!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 68,
                    ChallengeName = "sideways!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 69,
                    ChallengeName = "with your hands behind your back!",
                    Category = "default",
                    Advanced = false
                },
                new ChallengeItem
                {
                    ChallengeId = 70,
                    ChallengeName = "with your hands on your head!",
                    Category = "default",
                    Advanced = false
                }

                );
        }

    }
}
