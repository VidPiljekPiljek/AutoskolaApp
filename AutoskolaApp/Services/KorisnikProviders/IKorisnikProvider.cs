using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.Services.KorisnikProviders
{
    public interface IKorisnikProvider
    {
        Task<IEnumerable<Korisnik>> GetAllKorisnici();
    }
}
