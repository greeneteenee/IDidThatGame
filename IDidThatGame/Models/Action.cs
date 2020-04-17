using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Models
{

    /// <summary>
    /// A verb to describe what action a player must take during turn
    /// </summary>
    public class Action
    {

        [Key]
        public int ActionId { get; set; }

        public string ActionName { get; set; }

        public string Category { get; set; }

        public bool Advanced { get; set; }

        
    }
}
