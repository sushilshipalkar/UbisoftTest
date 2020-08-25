using System;
using System.Collections.Generic;
using System.Text;
using Common.DTO;


namespace Domain.Services.Interfaces
{
   public interface IScoreService
    {
        int Score(int Id);
        List<ScoreDTO> getScoreByTime(DateTime playDateTime, string matchName);
        List<ScoreDTO> getScoreById(int id);
        int insertScore(ScoreDTO playerData);
	ScoreDTO getPlayerById(int id);
    }
}
