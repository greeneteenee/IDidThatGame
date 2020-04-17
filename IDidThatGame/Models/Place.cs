using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Models
{
    /// <summary>
    /// A noun to describe what place a player must go during turn
    /// </summary>
    public class Place
    {

        public int PlaceId { get; set; }

        public string PlaceName { get; set; }

        public string Category { get; set; }

    }
}
