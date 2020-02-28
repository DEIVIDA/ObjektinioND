using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinioND
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Preke> prekiuListas = new List<Preke>();

            listoPildymasObjektais(100, prekiuListas);

            Preke brangiausiaPreke = prekiuListas[prekiuListas.FindIndex(x => x.Kaina.Equals(prekiuListas.Max(k => k.Kaina)))];
            Console.WriteLine($"Brangiausia preke vadinasi: {brangiausiaPreke.Pavadinimas} ir jos kaina {brangiausiaPreke.Kaina}");
            
            Console.ReadLine();
        }
        public static void listoPildymasObjektais(int objSkaicius, List<Preke> listoPavadinimas)
        {
            Random random = new Random();
            int rndKlase;
            for (int i = 0; i < objSkaicius; i++)
            {
                rndKlase = random.Next(1, 5);
                switch (rndKlase)
                {
                    case 1:
                            listoPavadinimas.Add(new MaistoPreke(random.Next(1000,9999).ToString(),random.Next(100,999)));
                        break;
                    case 2:
                            listoPavadinimas.Add(new CheminePreke(random.Next(1000, 9999).ToString(), random.Next(100, 999)));
                        break;
                    case 3: 
                            listoPavadinimas.Add(new LaisvalaikioPreke(random.Next(1000, 9999).ToString(), random.Next(100, 999)));
                        break;
                    case 4: 
                            listoPavadinimas.Add(new SportoPreke(random.Next(1000, 9999).ToString(), random.Next(1, 999)));
                        break;
                    default: i--;
                        break;
                }
            }
        }
    }
}
