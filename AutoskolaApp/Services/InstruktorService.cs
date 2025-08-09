using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Stores;

namespace AutoskolaApp.Services
{
    public class InstruktorService
    {
        public readonly InstruktorStore _instruktorStore;

        public InstruktorService(InstruktorStore instruktorStore)
        {
            _instruktorStore = instruktorStore;
        }

        public async Task LoadInstruktori()
        {
            await _instruktorStore.Load();
        }

        public IEnumerable<Instruktor> GetInstruktori()
        {
            return _instruktorStore.Instruktori;
        }

        public async Task<IEnumerable<Instruktor>> InstruktorSearch(string ime, string prezime)
        {
            return await _instruktorStore.InstruktorSearch(ime, prezime);
        }

        public async Task<int> GetInstruktorID(string ime, string prezime)
        {
            return await _instruktorStore.GetInstruktorID(ime, prezime);
        }

        public async Task AddInstruktor(Instruktor instruktor)
        {
            await _instruktorStore.AddInstruktor(instruktor);
        }

        public async Task EditInstruktor(Instruktor instruktor)
        {
            await _instruktorStore.EditInstruktor(instruktor);
        }

        public async Task DeleteInstruktor(int instruktorID)
        {
            await _instruktorStore.DeleteInstruktor(instruktorID);
        }
    }
}
