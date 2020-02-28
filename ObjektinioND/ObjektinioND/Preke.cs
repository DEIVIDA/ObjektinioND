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
        public Ismatavimai PrIsmatavimai;

        public Preke()
        {
            PrIsmatavimai = new Ismatavimai();
        }
        public Preke(string pavadinimas, int kaina)
        {
            this.Pavadinimas = pavadinimas;
            this.Kaina = kaina;
            PrIsmatavimai = new Ismatavimai();
        }
    }
}
