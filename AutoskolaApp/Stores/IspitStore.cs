using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

namespace AutoskolaApp.Stores
{
    public class IspitStore
    {
        private readonly List<Ispit> _ispiti;
        public IEnumerable<Ispit> Ispiti => _ispiti;
        private readonly IspitRepository _ispitRepository;
        private Lazy<Task> _initializeLazy;

        public event Action<Ispit> IspitCreated;
        public event Action<Ispit> IspitDeleted;

        public IspitStore(IspitRepository ispitRepository)
        {
            _ispitRepository = ispitRepository;
            _initializeLazy = new Lazy<Task>(Initialize);

            _ispiti = new List<Ispit>();
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

        private void OnIspitCreated(Ispit ispit)
        {
            IspitCreated?.Invoke(ispit);
        }

        private void OnIspitDeleted(Ispit ispit)
        {
            IspitDeleted?.Invoke(ispit);
        }

        private async Task Initialize()
        {
            IEnumerable<Ispit> korisnici = await _ispitRepository.GetAllIspiti();

            _ispiti.Clear();
            _ispiti.AddRange(korisnici);
        }

        public async Task AddIspit(Ispit ispit)
        {
            await _ispitRepository.CreateIspit(ispit);

            _ispiti.Add(ispit);

            OnIspitCreated(ispit);
        }

        public async Task DeleteIspit(Ispit ispit)
        {
            await _ispitRepository.DeleteIspit(ispit);

            _ispiti.Remove(ispit);

            OnIspitCreated(ispit);
        }
    }
}
