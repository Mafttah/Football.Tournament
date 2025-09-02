using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tournament.Domain.Entities;

public class Mac
{
    public string EvSahibi { get; set; } = string.Empty;
    public string? Deplasman { get; set; }
    public string? MacHakemi { get; set; }
    public int EvSahibiSkoru {  get; set; }
    public int DeplasmanSkoru { get; set; }
    public DateTime MacTarihi { get; set; }
}
