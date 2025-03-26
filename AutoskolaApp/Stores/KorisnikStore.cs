using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.Stores
{
    public class KorisnikStore
    {
        // Pojedini korisnik -> za Login
        // private readonly Korisnik _korisnik;
        // public Korisnik Korisnik => _korisnik;

        // Lista korisnika -> za SignUp
        private readonly List<Korisnik> _korisnici;
        public IEnumerable<Korisnik> Korisnici => _korisnici;
        private Lazy<Korisnik> _initializeLazy;

        public event Action<Korisnik> KorisnikAdded;

        public KorisnikStore()
        {
            _initializeLazy = new Lazy<Task>(Initialize);

            _korisnici = new List<Korisnik>();
        }

        public async Task Load()
        {
            try
            {
                await _initializeLazy.Value;
            }
            catch (Exception)
            {
                _initializeLazy = new Lazy<Task>(Initialize); // Pokusaj ponovo
                throw;
            }
        }

        public async Task MakeKorisnik(Korisnik korisnik)
        {
            KorisnikAdded?.Invoke(korisnik);
            _korisnici.Add(korisnik);
            await Task.CompletedTask;
        }
    }
}
