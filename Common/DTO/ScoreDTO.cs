using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTO
{
  public  class ScoreDTO
    {
        public int ScoreId { get; set; }
        public string userName { get; set; }
        public string matchName { get; set; }

        public int rank { get; set; }

        public int kills { get; set; }

        public int score { get; set; }

        public DateTime CreatedDate { get; set; }

        public string createdBy { get; set; }
    }
}
