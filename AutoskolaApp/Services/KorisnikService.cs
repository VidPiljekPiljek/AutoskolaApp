using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
using AutoskolaApp.DTOs;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;
using AutoskolaApp.Stores;
using Microsoft.EntityFrameworkCore;

namespace AutoskolaApp.Services
{
    public class KorisnikService
    {
        private readonly KorisnikStore _korisnikStore;
        
        public KorisnikService(KorisnikStore korisnikStore)
        {
            _korisnikStore = korisnikStore;
        }

        public Type KorisnikAuthorization()
        {
            return _korisnikStore.KorisnikAuthorization();
        }

        public async Task<bool> KorisnikAuthentication(string korisnickoIme, string lozinka)
        {
           bool authenticated = await _korisnikStore.KorisnikAuthentication(korisnickoIme, lozinka);

           return authenticated;
        }

        public async Task<Guid> GetKorisnikID(string korisnickoIme, string lozinka)
        {
            return await _korisnikStore.GetKorisnikID(korisnickoIme, lozinka);
        }

        public async Task AddKorisnik(Korisnik korisnik)
        {
            await _korisnikStore.AddKorisnik(korisnik);
        }
    }
}
