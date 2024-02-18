using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueWinRateVsSummoner
{
    public class AccountDto
    {
        public string? puuid { get; set; }
        public string? gameName { get; set; }
        public string? tagLine { get; set; } 
    }

    public class WinRateObject
    {
        public List<string>? error { get; set; }
        public string? winRatePercent { get; set; }
        
        public int? numOfTimes_WithPlayer2_OnSameTeam { get; set; }
        public int? numOfTimes_WonWithPlayer2_OnSameTeam { get; set; }
        public int? numOfTimes_LostWithPlayer2_OnSameTeam { get; set; }



        public int? numOfTimes_WithPlayer2_OnEnemyTeam { get; set; }
        public int? numOfTimes_WonWithPlayer2_OnEnemyTeam { get; set; }
        public int? numOfTimes_LostWithPlayer2_OnEnemyTeam { get; set; }

    }

    public class MatchDto
    {
        public MetaDataDto? metadata { get; set; }
        public InfoDto? info { get; set; }
    }

    public class MetaDataDto
    {
        public string? matchId { get; set; }
        public List<string>? participants { get; set; }


    }

    public class InfoDto
    {
        public List<ParticipantDto>? participants { get; set; }
    }

    public class ParticipantDto
    {
        public string? puuid { get; set; }
        public int? teamId { get; set; }
        public bool? win { get; set; }
    }
}
