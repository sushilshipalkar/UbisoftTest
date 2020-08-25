using System;
using System.Collections.Generic;
using System.Text;
using Common.DTO;
using Domain.Repository.Interfaces;
using Domain.Services.Interfaces;

namespace Domain.Services.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }
        public int Score(int Id)
        {
            var score = 0;
            try
            {
                score = _scoreRepository.Score(Id);
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
                result = _scoreRepository.getScoreByTime(playDateTime, matchName);
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
                result = _scoreRepository.getScoreById(id);
            }
            catch (Exception e)
            {

                throw e;
            }

            return result;

        }

	public ScoreDTO getPlayerById(int id)
        {
            var result = new ScoreDTO();
            try
            {
                result = _scoreRepository.getPlayerById(id);
            }
            catch (Exception e)
            {

                throw e;
            }

            return result;
        }

        public int insertScore(ScoreDTO playerData)
        {
            int id = 0;
            try
            {
                id = _scoreRepository.insertScore(playerData);
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }


    }
}
