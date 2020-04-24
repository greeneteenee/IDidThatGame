using IDidThatGame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Data
{
    /// <summary>
    /// Database helper methods for <see cref="Models.ChallengeItem"/>
    /// </summary>
    public class ChallengeDb
    {

        /// <summary>
        /// Returns list of Challenge items from database
        /// </summary>
        /// <param name="context"></param>
        /// <returns>List of Challenge items</returns>
        public static async Task<List<ChallengeItem>> GetChallengeItems(ApplicationDbContext context)
        {
            List<ChallengeItem> challenges = await context.Challenges.ToListAsync();
            return challenges;
        }

        /// <summary>
        /// Adds a Challenge item to the database
        /// </summary>
        /// <param name="newChallenge"></param>
        /// <param name="context"></param>
        /// <returns>ChallengeItem</returns>
        public static async Task<ChallengeItem> AddChallege(ApplicationDbContext context, ChallengeItem newChallenge)
        {
            await context.AddAsync(newChallenge);
            await context.SaveChangesAsync();
            return newChallenge;
        }

        /// <summary>
        /// Returns a single Challenge item or null if there is no match
        /// </summary>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <returns>Challenge item</returns>
        public static async Task<ChallengeItem> GetChallengeById(ApplicationDbContext context, int id)
        {
            ChallengeItem challengeItem = await (from challenge in context.Challenges where challenge.ChallengeId == id select challenge).SingleOrDefaultAsync();
            return challengeItem;
        }

        /// <summary>
        /// Edits existing Challenge item in database 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="challenge"></param>
        /// <returns>ChallengeItem</returns>
        public static async Task<ChallengeItem> EditChallege(ApplicationDbContext context, ChallengeItem challenge)
        {

            await context.AddAsync(challenge);
            context.Entry(challenge).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return challenge;
        }

        /// <summary>
        /// Deletes Challenge item from database
        /// </summary>
        /// <param name="context"></param>
        /// <param name="challenge"></param>
        public static async Task DeleteChallenge(ApplicationDbContext context, ChallengeItem challenge)
        {
            await context.AddAsync(challenge);
            context.Entry(challenge).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }
    }
}
