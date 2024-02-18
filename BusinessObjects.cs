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
        public string? gameName { get; set; } //This field may be excluded from the response if the account doesn't have a gameName.
        public string? tagLine { get; set; } //This field may be excluded from the response if the account doesn't have a tagLine. 
    }

    public class WinRateObject
    {
        public List<string>? error { get; set; }
        public string? winRatePercent { get; set; }
    }

    public class MatchDto
    {
        public MetaDataDto? metadata { get; set; }
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
    }
}
