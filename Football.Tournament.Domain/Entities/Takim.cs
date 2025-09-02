using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tournament.Domain.Entities;

public class Takim
{
    public string TakimAdi { get; set; }
    public string UlkeAdi { get; set; }
    public List <Oyuncu> Oyuncular { get; set; }
}
