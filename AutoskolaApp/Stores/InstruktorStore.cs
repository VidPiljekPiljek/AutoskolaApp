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

        public InstruktorStore(InstruktorRepository hotel)
        {
            _instruktorRepository = hotel;
            _initializeLazy = new Lazy<Task>(Initialize);

            _instruktori = new List<Instruktor>();
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

        private void OnInstruktorCreated(Instruktor instruktor)
        {
            InstruktorCreated?.Invoke(instruktor);
        }

        private async Task Initialize()
        {
            IEnumerable<Instruktor> korisnici = await _instruktorRepository.GetAllInstruktori();

            _instruktori.Clear();
            _instruktori.AddRange(korisnici);
        }
    }
}
