using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu02IvanMocilac
{
    class KlasaB
    {
        public string BezPrvogiZadnjeg(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
