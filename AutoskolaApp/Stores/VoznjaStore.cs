using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AutoskolaApp.Stores
{
    public class VoznjaStore
    {
        private readonly List<Voznja> _voznje;
        public IEnumerable<Voznja> Voznje => _voznje;
        private readonly VoznjaRepository _voznjaRepository;
        private Lazy<Task> _initializeLazy;
        private bool _isInitialized;
        public bool IsInitialized => _isInitialized;

        public event Action<Voznja> VoznjaCreated;
        public event Action<Voznja> VoznjaEdited;
        public event Action<Voznja> VoznjaDeleted;

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

                _isInitialized = true;
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

        private void OnVoznjaEdited(Voznja voznja)
        {
            VoznjaEdited?.Invoke(voznja);
        }

        private void OnVoznjaDeleted(Voznja voznja)
        {
            VoznjaDeleted?.Invoke(voznja);
        }

        public async Task AddVoznja(Voznja voznja)
        {
            await _voznjaRepository.CreateVoznja(voznja);

            _voznje.Add(voznja);

            OnVoznjaCreated(voznja);
        }

        public async Task EditVoznja(Voznja voznja)
        {
            await _voznjaRepository.UpdateVoznja(voznja);

            var existingVoznja = _voznje.FirstOrDefault(v => v.IDVoznje == voznja.IDVoznje);
            if (existingVoznja != null)
            {
                existingVoznja.GetType().GetProperties()
                    .Where(p => p.CanWrite)
                    .ToList()
                    .ForEach(p => p.SetValue(existingVoznja, p.GetValue(voznja)));
                await _voznjaRepository.UpdateVoznja(existingVoznja);

                OnVoznjaEdited(existingVoznja);
            }
        }

        public async Task DeleteVoznja(int voznjaID)
        {
            await _voznjaRepository.DeleteVoznja(voznjaID);

            Voznja voznja = _voznje.FirstOrDefault(voznja => voznja.IDVoznje == voznjaID);

            _voznje.RemoveAll(voznja => voznja.IDVoznje == voznjaID);

            OnVoznjaDeleted(voznja);
        }

        private async Task Initialize()
        {
            IEnumerable<Voznja> voznje = await _voznjaRepository.GetAllVoznje();

            _voznje.Clear();
            _voznje.AddRange(voznje);
        }
    }
}

