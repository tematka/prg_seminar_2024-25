using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Forest:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Přijdeš do lesa. Není moc velký a tak ho zvládneš projit celý." +
                "Na místě kde byl Williame nalezen není nic neobvyklého. Jediné co tam najdeš jsou" +
                "otisky bod, které jsou o něco větší než lidské šlápoty normálně bývají. Nebvěnuješ" +
                "jim nějak větší pozornost.");
        }
        public override void Decision()
        {
            Console.WriteLine("V lese máš dvě varianty kam se vydat a to buď do vesnice (klávesa v)" +
                "a nebo na zahradu (klávesa z)");
        }
        public override void Search()
        {
        }
    }
}
