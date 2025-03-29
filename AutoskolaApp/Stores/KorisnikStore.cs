using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

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
        private readonly KorisnikRepository _korisnikRepository;
        private Lazy<Task> _initializeLazy;

        public event Action<Korisnik> KorisnikAdded;

        public KorisnikStore(KorisnikRepository korisnikRepository)
        {
            _korisnikRepository = korisnikRepository;
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

        public async Task AddKorisnik(Korisnik korisnik)
        {
            await _korisnikRepository.CreateKorisnik(korisnik);

            _korisnici.Add(korisnik);

            OnKorisnikAdded(korisnik);
        }

        private void OnKorisnikAdded(Korisnik korisnik)
        {
            KorisnikAdded?.Invoke(korisnik);
        }

        private async Task Initialize()
        {
            IEnumerable<Korisnik> korisnici = await _korisnikRepository.GetAllKorisnici();

            _korisnici.Clear();
            _korisnici.AddRange(korisnici);
        }
    }
}
