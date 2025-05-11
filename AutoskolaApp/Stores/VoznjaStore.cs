using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

namespace AutoskolaApp.Stores
{
    public class VoznjaStore
    {
        private readonly List<Voznja> _voznje;
        public IEnumerable<Voznja> Voznje => _voznje;
        private readonly VoznjaRepository _voznjaRepository;
        private Lazy<Task> _initializeLazy;

        public event Action<Voznja> VoznjaCreated;

        public VoznjaStore(VoznjaRepository voznjaRepository)
        {
            _voznjaRepository = voznjaRepository;
            _initializeLazy = new Lazy<Task>(Initialize);

            _voznje = new List<Voznja>();
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

        private void OnVoznjaCreated(Voznja voznja)
        {
            VoznjaCreated?.Invoke(voznja);
        }

        private async Task Initialize()
        {
            IEnumerable<Voznja> voznje = await _voznjaRepository.GetAllVoznje();

            _voznje.Clear();
            _voznje.AddRange(voznje);
        }
    }
}

