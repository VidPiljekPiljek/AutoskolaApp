using AutoskolaApp.Models;
using AutoskolaApp.Repositories;
using AutoskolaApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.Services
{
    public class IspitService
    {
        public readonly IspitStore _ispitStore;

        public IspitService(IspitStore ispitStore)
        {
            _ispitStore = ispitStore;
        }

        public async Task LoadInstruktori()
        {
            await _ispitStore.Load();
        }

        public IEnumerable<Ispit> GetInstruktori()
        {
            return _ispitStore.Ispiti;
        }

        public async Task AddIspit(Ispit ispit)
        {
            await _ispitStore.AddIspit(ispit);
        }

        public async Task DeleteIspit(Ispit ispit)
        {
            await _ispitStore.DeleteIspit(ispit);
        }
    }
}
