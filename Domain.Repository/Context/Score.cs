using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Repository.Context
{
    public class Score
    {
       
        public int ScoreId { get; set; }
        public string userName { get; set; }

        public int rank { get; set; }

        public  int kills { get; set; }

        public  int score { get; set; }

        public  DateTime CreatedDate { get; set; }

        public  string createdBy { get; set; }

    }
}
