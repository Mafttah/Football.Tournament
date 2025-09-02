using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tournament.Domain.Entities;

public class Match
{
    public string HomeTeam { get; set; } = string.Empty;
    public string? AwayTeam { get; set; }
    public string? MatchReferee { get; set; }
    public int HomeScore {  get; set; }
    public int AwayScore { get; set; }
    public DateTime MatchDate { get; set; }
}
