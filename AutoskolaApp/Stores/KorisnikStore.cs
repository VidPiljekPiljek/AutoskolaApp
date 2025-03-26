using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.Stores
{
    public class KorisnikStore
    {
        private readonly List<Korisnik> _korisnici;
        public IEnumerable<Korisnik> Korisnici => _korisnici;

        public event Action<Korisnik> KorisnikAdded;

    }
}
