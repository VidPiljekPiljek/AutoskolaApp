using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.Services.KorisnikCreators
{
    public interface IKorisnikCreator
    {
        Task CreateKorisnik(Korisnik korisnik);
    }
}
