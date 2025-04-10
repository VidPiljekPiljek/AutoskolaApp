using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
using AutoskolaApp.DTOs;
using AutoskolaApp.Models;
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

        public async Task RegisterKorisnik(Korisnik korisnik)
        {
            await _korisnikStore.AddKorisnik(korisnik);
        }

        public async Task LoadAllKorisniciAsync()
        {
            await _korisnikStore.Load();
        }
    }
}
