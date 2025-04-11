using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Villager:Person
    {
        public override void Interrogation()
        {
            Console.WriteLine("Zeptáš se na vraždu vesničana. Ten ti řekne, že o tom slyšel, ale" +
                "že to není jediná vražda, co se v okolí stala. Jedna vesničanka prý přišla o otce." +
                "Tvrdí, že byl udušen a že když přišla domů a spatřila ho, tak tam byl nějaký netvor." +
                "Několik mužů z vesnice se tam šlo podívat, ale žádný netvor tam nebyl. Všichni " +
                "si myslí že se asi zbláznila při pohledu na mrtvolu. Vesničanovi poděkuješ a pokračuješ" +
                "v pátrání");
        }
    }
}
