using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Services.KorisnikCreators;
using AutoskolaApp.Services.KorisnikProviders;

namespace AutoskolaApp.Models
{
    public class KorisnikManager
    {
        private readonly IKorisnikCreator _korisnikCreator;
        private readonly IKorisnikProvider _korisnikProvider;

        public KorisnikManager(IKorisnikCreator korisnikCreator, IKorisnikProvider korisnikProvider)
        {
            _korisnikCreator = korisnikCreator;
            _korisnikProvider = korisnikProvider;
        }

        public async Task<IEnumerable<Korisnik>> GetAllKorisnici()
        {
            return await _korisnikProvider.GetAllKorisnici();
        }

        public async Task AddKorisnik(Korisnik korisnik)
        {
            await _korisnikCreator.CreateKorisnik(korisnik);
        }
    }
}
