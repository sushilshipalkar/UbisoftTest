using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Common.DTO;
using Domain.Repository.Context;
using Domain.Repository.Interfaces;

namespace Domain.Repository.Repository
{
   public class ScoreRepository : IScoreRepository
   {
       private ScoreContext _scoreContext;
       //private List<ScoreDTO> scoreList = new List<ScoreDTO>();
       static List<ScoreDTO> scoreList;
        public ScoreRepository(ScoreContext context)
        {
            _scoreContext = context;
        }

        public int Score(int Id)
        {
            var score = 0;
            try
            {
                score = 1;
               // var data = _scoreContext.Scores.Where(x=>x.ScoreId==2).Select(x=>x.ScoreId).FirstOrDefault();
                
            }
            catch (Exception e)
            {
               throw e;
            }

            return score;
        }

       public List<ScoreDTO> getScoreByTime(DateTime playDateTime, string matchName)
        {
            var result = new List<ScoreDTO>();
            try
            {
                result = scoreList.Where(x => x.CreatedDate == playDateTime && x.matchName== matchName).ToList();
            }
            catch (Exception e)
            {
              
                throw e;
            }

            return result;

        }
       public List<ScoreDTO> getScoreById(int id)
       {
           var result = new List<ScoreDTO>();
           try
           {
               result = scoreList.Where(x => x.ScoreId == id).ToList();
           }
           catch (Exception e)
           {

               throw e;
           }

           return result;

       }
public ScoreDTO getPlayerById(int id)
       {
           var result =new  ScoreDTO();
           try
           {
               result = scoreList.FirstOrDefault(x=>x.ScoreId==id);
           }
           catch (Exception e)
           {

               throw e;
           }

           return result;

       }
        public List<ScoreDTO> setData()
        {

            scoreList = new List<ScoreDTO>() {
                new ScoreDTO() { ScoreId = 1, matchName="csGo", userName = "abc", rank = 1, score = 400,createdBy = "abc", kills = 20, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377")},
                new ScoreDTO() {ScoreId =  2,matchName="csGo", userName = "xyz", rank = 2, score = 320,createdBy = "xyz", kills = 16, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377") },
                new ScoreDTO() { ScoreId = 3,matchName="csGo", userName = "suresh", rank = 3, score = 200,createdBy = "suresh", kills = 10, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377") },
                new ScoreDTO() { ScoreId = 4,matchName="pubG", userName = "asd", rank = 5, score = 100,createdBy = "asd", kills = 5, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377") },
                new ScoreDTO() { ScoreId = 5,matchName="csGo", userName = "zxc", rank = 4, score = 300,createdBy = "zxc", kills = 15, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377")},
                new ScoreDTO() { ScoreId = 6,matchName="csGo", userName = "asd", rank = 2, score = 100,createdBy = "asd", kills = 5, CreatedDate = DateTime.Parse("2020-07-09 08:36:04.377") },
                new ScoreDTO() { ScoreId = 7,matchName="csGo", userName = "zxc", rank = 1, score = 300,createdBy = "zxc", kills = 15, CreatedDate = DateTime.Parse("2020-07-09 08:36:04.377")}
            };
            return scoreList;
        }

        public int insertScore(ScoreDTO playerData)
        {
            int id = setData().Count() + 1;
           
            try
            {
                playerData.ScoreId = id;
                scoreList.Add(playerData);
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }


    }
}
