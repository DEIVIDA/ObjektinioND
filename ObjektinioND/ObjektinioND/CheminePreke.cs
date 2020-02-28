using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinioND
{
    class CheminePreke : Preke
    {
        public string Paskirtis { get; set; }
        public CheminePreke(string pavadinimas, int kaina) : base (pavadinimas, kaina)
        {
        }
    }
}
