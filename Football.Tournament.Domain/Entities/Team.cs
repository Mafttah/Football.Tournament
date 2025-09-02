using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tournament.Domain.Entities;

public class Team
{
    public string TeamName { get; set; }
    public string CountryName { get; set; }
    public List <Player> Players { get; set; }
}
