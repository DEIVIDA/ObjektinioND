using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinioND
{
    public abstract class Preke
    {
        public int Kaina { get; set; }
        public int Svoris { get; set; }
        public string Pavadinimas { get; set; }
        Ismatavimai Ismatavimai = new Ismatavimai();
    }
}
