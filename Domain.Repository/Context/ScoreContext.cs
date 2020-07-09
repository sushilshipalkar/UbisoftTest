using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Repository.Context
{
   public class ScoreContext:DbContext
    {
        public ScoreContext(DbContextOptions<ScoreContext> options) : base(options)
        {

        }
        public  DbSet<Score> Scores { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Score>().HasData(new Score
        //    {
        //        ScoreId = 2
        //    });
        //}

    }
}
