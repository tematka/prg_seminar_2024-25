using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class WilliamRoom:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Vstoupíš do Williamova pokoje a uvidíš tu jeho chůvu Justine. Nevíš co " +
                "tu dělá a ona se zatím nevšiml, že jsi vstoipil na místnosti. Jen sedí na jeho " +
                "posteli a dívá se z okna");
        }
        public override void Decision()
        {
            Console.WriteLine("Rozhoduješ se co uděláš. Buď se můžeš vrátit do haly (klávesa h) " +
                "a nebo můžeš vyslechnout Justine (klávesa j)");
        }
        public override void Search()
        {
        }
    }
}
