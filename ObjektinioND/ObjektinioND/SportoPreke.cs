using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinioND
{
    class SportoPreke : Preke
    {
        public string SportoSaka { get; set; }
        public SportoPreke(string pavadinimas, int kaina) : base (pavadinimas, kaina)
        {
        }
    }
}
