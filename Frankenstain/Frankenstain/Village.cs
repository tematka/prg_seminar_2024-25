using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Village:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Vesnice do které přijdeš je malinká a žije v ní pár lidí. O to spíš by ale" +
                "mohl někdo něco vědět. Na tokovychto vesnicích se totiž nikdy nic neutají");
        }
        public override void Decision()
        {
            Console.WriteLine("Ve vesnici máš následující možnosti .Můžeš vyslechnout nějakého " +
                "vesničana, jestli něco neví o vraždě malého Wiliama (klávesa v), jít do lesa (klávesa l)" +
                "a nebo na zahradu (klávesa z)");
        }
        public override void Search()
        {
        }
    }
}
