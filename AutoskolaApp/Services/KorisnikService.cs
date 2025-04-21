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

        public async Task<bool> KorisnikAuthentication(string korisnickoIme, string lozinka)
        {
           bool authenticated = await _korisnikStore.KorisnikAuthentication(korisnickoIme, lozinka);

           return authenticated;
        }
    }
}
