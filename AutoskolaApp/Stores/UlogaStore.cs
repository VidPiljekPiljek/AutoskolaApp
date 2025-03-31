using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

namespace AutoskolaApp.Stores
{
    public class UlogaStore
    {
        private readonly UlogaRepository _ulogaRepository;
        private readonly List<Uloga> _uloge;
        public IEnumerable<Uloga> Uloge => _uloge;
        private Lazy<Task> _initializeLazy;

        public UlogaStore(UlogaRepository ulogaRepository, List<Uloga> uloge, Lazy<Task> initializeLazy)
        {
            _ulogaRepository = ulogaRepository;
            _uloge = new List<Uloga>();
            _initializeLazy = new Lazy<Task>(Initialize);
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

        private async Task Initialize()
        {
            IEnumerable<Uloga> uloge = await _ulogaRepository.GetAllUloge();

            _uloge.Clear();
            _uloge.AddRange(uloge);
        }

        
    }
}
