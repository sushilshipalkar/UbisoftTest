using System;
using System.Collections.Generic;
using System.Text;
using Common.DTO;
using Domain.Repository.Context;


namespace Domain.Repository.Interfaces
{
  public  interface IScoreRepository
    {
        int Score(int Id);
        List<ScoreDTO> getScoreByTime(DateTime playDateTime , string matchName);
        List<ScoreDTO> getScoreById(int id);

        int insertScore(ScoreDTO playerData);


    }
}
