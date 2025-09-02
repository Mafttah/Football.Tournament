using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tournament.Domain.Entities;

public class Oyuncu
{
    public string Adi {  get; set; }
    public string Soyadi { get; set; }
    public int Yas { get; set; }
    public int FormaNo { get; set; }
    public string Mevki { get; set; }
}
