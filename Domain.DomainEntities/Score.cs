using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DomainEntities
{
   public class Score
    {
        [Key]
        public int ScoreId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
