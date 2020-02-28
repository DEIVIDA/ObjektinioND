using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinioND
{
    class LaisvalaikioPreke : Preke
    {
        public string Hobis { get; set; }
        public LaisvalaikioPreke(string pavadinimas, int kaina) : base (pavadinimas, kaina)
        {
        }
    }
}
