using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Stores;

namespace AutoskolaApp.Services
{
    public class UplataService
    {
        public readonly UplataStore _uplataStore;

        public UplataService(UplataStore uplataStore)
        {
            _uplataStore = uplataStore;
        }

        public async Task LoadUplate()
        {
            await _uplataStore.Load();
        }

        public IEnumerable<Uplata> GetUplate()
        {
            return _uplataStore.Uplate;
        }
    }
}
