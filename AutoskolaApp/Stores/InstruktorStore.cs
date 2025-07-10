using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

namespace AutoskolaApp.Stores
{
    public class InstruktorStore
    {
        private readonly List<Instruktor> _instruktori;
        public IEnumerable<Instruktor> Instruktori => _instruktori;
        private readonly InstruktorRepository _instruktorRepository;
        private Lazy<Task> _initializeLazy;

        public event Action<Instruktor> InstruktorCreated;
        public event Action<Instruktor> InstruktorDeleted;

        public InstruktorStore(InstruktorRepository instruktorRepository)
        {
            _instruktorRepository = instruktorRepository;
            _initializeLazy = new Lazy<Task>(Initialize);

            _instruktori = new List<Instruktor>();
        }

        public async Task<IEnumerable<Instruktor>> InstruktorSearch(string ime, string prezime)
        {
            return await _instruktorRepository.InstruktorSearch(ime, prezime);
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

        public async Task AddInstruktor(Instruktor instruktor)
        {
            await _instruktorRepository.CreateInstruktor(instruktor);

            _instruktori.Add(instruktor);

            OnInstruktorCreated(instruktor);
        }

        public async Task DeleteInstruktor(int instruktorID)
        {
            await _instruktorRepository.DeleteInstruktor(instruktorID);

            Instruktor instruktor = _instruktori.FirstOrDefault(instruktor => instruktor.IDInstruktora == instruktorID);

            _instruktori.RemoveAll(instruktor => instruktor.IDInstruktora == instruktorID);

            OnInstruktorDeleted(instruktor);
        }

        public async Task<int> GetInstruktorID(string ime, string prezime)
        {
            return await _instruktorRepository.GetInstruktorID(ime, prezime);
        }

        private void OnInstruktorCreated(Instruktor instruktor)
        {
            InstruktorCreated?.Invoke(instruktor);
        }

        private void OnInstruktorDeleted(Instruktor instruktor)
        {
            InstruktorDeleted?.Invoke(instruktor);
        }

        private async Task Initialize()
        {
            IEnumerable<Instruktor> korisnici = await _instruktorRepository.GetAllInstruktori();

            _instruktori.Clear();
            _instruktori.AddRange(korisnici);
        }
    }
}
