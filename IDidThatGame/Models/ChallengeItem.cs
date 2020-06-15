using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Models
{
    /// <summary>
    /// Describes an added challenge that player must do when they perform action during turn
    /// </summary>
    public class ChallengeItem
    {
        [Key]
        public int ChallengeId { get; set; }

        [DisplayName("Challenge")]
        public string ChallengeName { get; set; }

        public string Category { get; set; }

        public bool Advanced { get; set; }

        }
}
