using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class ElizabethRoom:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Vstoupíš do místnosti kde sedí Elizabeth");
        }
        public override void Decision()
        {
            Console.WriteLine("Buď se můžeš vrátit zpět do haly (klávesa h) a nebo vyslechnout " +
                "Elizabeth (klávesa E)");
        }
        public override void Search()
        {
        }
    }
}
