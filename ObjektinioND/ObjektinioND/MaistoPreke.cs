using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinioND
{
    class MaistoPreke : Preke
    {
        public string Skonis { get; set; }
        public MaistoPreke(string pavadinimas, int kaina) : base (pavadinimas, kaina)
        {
        }
    }
}
