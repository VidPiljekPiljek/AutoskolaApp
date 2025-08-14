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
        private bool _isInitialized;
        public bool IsInitialized => _isInitialized;

        public event Action<Uplata> UplataCreated;
        public event Action<Uplata> UplataEdited;
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

                _isInitialized = true;
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

        private void OnUplataEdited(Uplata uplata)
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

        public async Task EditUplata(Uplata uplata)
        {
            await _uplateRepository.UpdateUplata(uplata);

            var existingUplata = _uplate.FirstOrDefault(s => s.IDUplate == uplata.IDUplate);
            if (existingUplata != null)
            {
                existingUplata.GetType().GetProperties()
                    .Where(p => p.CanWrite)
                    .ToList()
                    .ForEach(p => p.SetValue(existingUplata, p.GetValue(uplata)));
                await _uplateRepository.UpdateUplata(existingUplata);

                OnUplataEdited(existingUplata);
            }
        }

        public async Task DeleteUplata(int uplataID)
        {
            await _uplateRepository.DeleteUplata(uplataID);

            Uplata uplata = _uplate.FirstOrDefault(uplata => uplata.IDUplate == uplataID);

            _uplate.RemoveAll(uplata => uplata.IDUplate == uplataID);

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
