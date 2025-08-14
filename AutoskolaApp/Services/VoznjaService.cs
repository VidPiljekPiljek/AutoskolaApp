using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Stores;

namespace AutoskolaApp.Services
{
    public class VoznjaService
    {
        public readonly VoznjaStore _voznjaStore;

        public VoznjaService(VoznjaStore voznjaStore)
        {
            _voznjaStore = voznjaStore;
        }

        public async Task LoadVoznje()
        {
            await _voznjaStore.Load();
        }

        public IEnumerable<Voznja> GetVoznje()
        {
            return _voznjaStore.Voznje;
        }

        public async Task AddVoznja(Voznja voznja)
        {
            await _voznjaStore.AddVoznja(voznja);
        }

        public async Task EditVoznja(Voznja voznja)
        {
            await _voznjaStore.EditVoznja(voznja);
        }

        public async Task DeleteVoznja(int voznjaID)
        {
            await _voznjaStore.DeleteVoznja(voznjaID);
        }
    }
}
