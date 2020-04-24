using IDidThatGame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Data
{
    /// <summary>
    /// Database helper methods for <see cref="Models.PlaceItem"/>
    /// </summary>
    public class PlaceDb
    {

        /// <summary>
        /// Returns list of Place items from database
        /// </summary>
        /// <param name="context"></param>
        /// <returns>List of Place items</returns>
        public static async Task<List<PlaceItem>> GetPlaceItems(ApplicationDbContext context)
        {
            List<PlaceItem> places = await context.Places.ToListAsync();
            return places;
        }

        /// <summary>
        /// Adds Place item to the database
        /// </summary>
        /// <param name="newPlace"></param>
        /// <param name="context"></param>
        /// <returns>PlaceItem</returns>
        public static async Task<PlaceItem> AddPlace(ApplicationDbContext context, PlaceItem newPlace)
        {
            await context.AddAsync(newPlace);
            await context.SaveChangesAsync();
            return newPlace;
        }

        /// <summary>
        /// Returns a single Place item or null if there is no match
        /// </summary>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <returns>PlaceItem</returns>
        public static async Task<PlaceItem> GetPlaceById(ApplicationDbContext context, int id)
        {
            PlaceItem placeItem = await (from place in context.Places where place.PlaceId == id select place).SingleOrDefaultAsync();
            return placeItem;
        }

        /// <summary>
        /// Edits existing Place item in database 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="place"></param>
        /// <returns>PlaceItem</returns>
        public static async Task<PlaceItem> EditPlace(ApplicationDbContext context, PlaceItem place)
        {

            await context.AddAsync(place);
            context.Entry(place).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return place;
        }

        /// <summary>
        /// Deletes Place item from database
        /// </summary>
        /// <param name="context"></param>
        /// <param name="place"></param>
        public static async Task DeletePlace(ApplicationDbContext context, PlaceItem place)
        {
            await context.AddAsync(place);
            context.Entry(place).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

    }
}
