using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._10._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Osztalyoz(3));
            Console.ReadKey();
        }
        static String Osztalyoz(int szam)
        {
            switch (szam)
            {
                case 1: return "elégtelen";
                case 2: return "elégséges";
                case 3: return "közepes";
                case 4: return "jó";
                case 5: return "jeles";
                default:return "Nem megfelelő érték";
            }

        }
        
    }
}
