using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.DTO;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    
    [Route("api/Score")]
    public class ScoreController : Controller
    {
        private readonly IScoreService _scoreService;

        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;

        }

        [HttpGet]
        [Route("/api/GetScore")]
        public ScoreDTO GetScore(int id)
        {
           
            var score = 0;
            ScoreDTO result= new ScoreDTO();
            try
            {
                score = _scoreService.Score(id);
                result.ScoreId = score;
            }
            catch (Exception e)
            {
               
                throw e;
            }

            return result;
        }

        /// <summary>
        /// //Fetch player stats for the given match and time window
        /// </summary>
        /// <param name="matchName"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/LeaderBoard/{matchName}/{time}")]
        public List<ScoreDTO> LeaderBoard(string matchName,DateTime time)
        {

           
            var result = new List<ScoreDTO>();
          
            try
            {
                result = _scoreService.getScoreByTime(time, matchName);
            }
            catch (Exception e)
            {

                throw e;
            }

            return result;
        }
	
        /// <summary>
        ///  //Fetch stats for the logged in player
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/PlayerStats")]
        public List<ScoreDTO> PlayerStats(int id)
        {


            var result = new List<ScoreDTO>();
            try
            {
                result = _scoreService.getScoreById(id);
            }
            catch (Exception e)
            {

                throw e;
            }

            return result;
        }
	

        /// <summary>
        ///  //insert player data
        /// </summary>
        /// <param name="playerData"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/insertPlayerData")]
        public int insertPlayerData([FromBody] ScoreDTO playerData)
        {
            int id = 0;
            try
            {
                id = _scoreService.insertScore(playerData);
            }
            catch (Exception e)
            {

                throw e;
            }

            return id;
        }

	[HttpGet]
        public IActionResult Get(int id)
        {
             ScoreDTO model= new ScoreDTO();

            List<ScoreDTO> scoreList = new List<ScoreDTO>() {
                new ScoreDTO() { ScoreId = 1, matchName="csGo", userName = "abc", rank = 1, score = 400,createdBy = "abc", kills = 20, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377")},
                new ScoreDTO() {ScoreId =  2,matchName="csGo", userName = "xyz", rank = 2, score = 320,createdBy = "xyz", kills = 16, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377") },
                new ScoreDTO() { ScoreId = 3,matchName="csGo", userName = "suresh", rank = 3, score = 200,createdBy = "suresh", kills = 10, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377") },
                new ScoreDTO() { ScoreId = 4,matchName="pubG", userName = "asd", rank = 5, score = 100,createdBy = "asd", kills = 5, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377") },
                new ScoreDTO() { ScoreId = 5,matchName="csGo", userName = "zxc", rank = 4, score = 300,createdBy = "zxc", kills = 15, CreatedDate = DateTime.Parse("2020-07-09 08:35:04.377")},
                new ScoreDTO() { ScoreId = 6,matchName="csGo", userName = "asd", rank = 2, score = 100,createdBy = "asd", kills = 5, CreatedDate = DateTime.Parse("2020-07-09 08:36:04.377") },
                new ScoreDTO() { ScoreId = 7,matchName="csGo", userName = "zxc", rank = 1, score = 300,createdBy = "zxc", kills = 15, CreatedDate = DateTime.Parse("2020-07-09 08:36:04.377")}
            };
            try
            {
                model = scoreList.FirstOrDefault(x => x.ScoreId == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return Json(model);



        }



        // GET: api/Score
       // [HttpGet]
       // public IEnumerable<string> Get()
       // {
       //     return new string[] { "value1", "value2" };
       // }

        // GET: api/Score/5
        //[HttpGet("{id}", Name = "Get")]
       // public string Get(int id)
       // {
        //    return "value";
        //}

        
        // POST: api/Score
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Score/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
