using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Tournament.Domain.Entities;

namespace Football.Tournament.Application.Interfaces;

public interface ITournamentService
{
    void CreateTeams(int takimSayisi);

    List <Mac> FikstureOlustur();

    void MacOyna(Mac mac);
}
