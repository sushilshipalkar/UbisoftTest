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
        [Route("/api/GetScore/{id}")]
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
        [Route("/api/PlayerStats/{id}")]
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

        // GET: api/Score
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Score/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
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
