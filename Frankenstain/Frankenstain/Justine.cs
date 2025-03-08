using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Justine:Person
    {
        public override void Interrogation()
        {
            Console.WriteLine("JUstine se první vyleká když ji oslovíš, ale pak začne vypovídat. " +
                "Celou dobu však vypadá celkem nervózní. Řekne, že si s Williamem hrála, pak odběhl " +
                "do lese a našli ho až ráno mrtvého. Prý ale během hledání zahlédla v lese nějakého netvora." +
                "Nic víc však prý neví a tak se vrátíš zpět do haly");
        }
    }
}
