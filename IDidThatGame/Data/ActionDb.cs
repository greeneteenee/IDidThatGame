using IDidThatGame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Data
{
    /// <summary>
    /// Database helper methods for <see cref="Models.ActionItem"/>
    /// </summary>
    public class ActionDb
    {
        /// <summary>
        /// Returns list of Action items from database
        /// </summary>
        /// <param name="context"></param>
        /// <returns>List of Action items</returns>
        public static async Task<List<ActionItem>> GetActionsItems(ApplicationDbContext context)
        {
            List<ActionItem> actions = await context.Actions.ToListAsync();
            return actions;
        }

        /// <summary>
        /// Adds an Action item to the database
        /// </summary>
        /// <param name="newAction"></param>
        /// <param name="context"></param>
        /// <returns>ActionItem</returns>
        public static async Task<ActionItem> AddAction(ApplicationDbContext context, ActionItem newAction)
        {
            await context.AddAsync(newAction);
            await context.SaveChangesAsync();
            return newAction;
        }

        /// <summary>
        /// Returns a single Action item or null if there is no match
        /// </summary>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<ActionItem> GetActionById(ApplicationDbContext context, int id)
        {
            ActionItem actionItem = await (from action in context.Actions where action.ActionId == id select action).SingleOrDefaultAsync();
            return actionItem;
        }

        /// <summary>
        /// Edits existing Actions item in database 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="action"></param>
        /// <returns>ActionItem</returns>
        public static async Task<ActionItem> EditAction(ApplicationDbContext context, ActionItem action)
        {

            await context.AddAsync(action);
            context.Entry(action).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return action;
        }
            
        /// <summary>
        /// Deletes Action item from database
        /// </summary>
        /// <param name="context"></param>
        /// <param name="action"></param>
        public static async Task DeleteAction(ApplicationDbContext context, ActionItem action)
        {
            await context.AddAsync(action);
            context.Entry(action).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

    }
}
