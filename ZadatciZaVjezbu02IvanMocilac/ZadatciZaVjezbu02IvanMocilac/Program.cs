using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu02IvanMocilac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite niz znakova: ");
            string s = Console.ReadLine();
            KlasaB b = new KlasaB();
            if(s.Length > 2)
            {
                s = b.BezPrvogiZadnjeg(s);
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Molimo Vas da upišete više od 2 znaka.");
            }
            
            Console.ReadKey();
        }
    }
}
