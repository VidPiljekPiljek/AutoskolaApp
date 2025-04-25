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
    }
}
