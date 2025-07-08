using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

namespace AutoskolaApp.Stores
{
    public class UplataStore
    {
        private readonly List<Uplata> _uplate;
        public IEnumerable<Uplata> Uplate => _uplate;
        private readonly UplataRepository _uplateRepository;
        private Lazy<Task> _initializeLazy;

        public event Action<Uplata> UplataCreated;
        public event Action<Uplata> UplataDeleted;

        public UplataStore(UplataRepository studentRepository)
        {
            _uplateRepository = studentRepository;
            _initializeLazy = new Lazy<Task>(Initialize);

            _uplate = new List<Uplata>();
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

        private void OnUplataCreated(Uplata uplata)
        {
            UplataCreated?.Invoke(uplata);
        }

        private void OnUplataDeleted(Uplata uplata)
        {
            UplataDeleted?.Invoke(uplata);
        }

        public async Task AddUplata(Uplata uplata)
        {
            await _uplateRepository.CreateUplata(uplata);

            _uplate.Add(uplata);

            OnUplataCreated(uplata);
        }

        public async Task DeleteUplata(Uplata uplata)
        {
            await _uplateRepository.DeleteUplata(uplata);

            _uplate.Remove(uplata);

            OnUplataDeleted(uplata);
        }

        private async Task Initialize()
        {
            IEnumerable<Uplata> uplate = await _uplateRepository.GetAllUplate();

            _uplate.Clear();
            _uplate.AddRange(uplate);
        }
    }
}
