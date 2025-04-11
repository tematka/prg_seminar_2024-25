using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class FatherRoom:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Vstoupíš do ložnice Williamova otce. Ten sedí na posteli a vypadá jako by přemíšlel," +
                "ty si ale všimneš, že se mu v očích lesknou slzy.");
        }
        public override void Decision()
        {
            Console.WriteLine("V otcově ložnici máš dvě možnosti na výběr. Buď se vrátíš zpět " +
                "do haly (klávesa h) nebo otce vyslechneš (klávesa v) ");
        }
        public override void Search()
        {
        }
    }
}
