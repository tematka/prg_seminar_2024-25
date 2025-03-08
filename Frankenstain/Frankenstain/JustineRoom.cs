using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class JustineRoom:room,IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Vstoupíš do pokoje Justine. Nikdo tu není");
        }
        public override void Decision()
        {
            Console.WriteLine("V pokoji Justine máš na výběr dvě možnosti. Buď jeji pokoj prohledáš" +
                " (klávesa p) a nebo se vrátíš zpět do haly (klávesa h)");
        }
        public override void Search()
        {
            Console.WriteLine("Pořádně prohledáš celý pokoj a nemůžeš uvěřit tomu co najdeš." +
                "V jedné skřínce nalezneš medailonek, celý od krve. Vezmeš si ho k sobě a zatím nikomu nebudeš " +
                "říkat, co si našel a bvrátíš se zpět do haly");
        }
        public void Search2()
        {
            Console.WriteLine("Znovu důkladně prohledáš pokoj, ale tentokrát už nic dalšího nenajdeš " +
                "a tak se vrátíš zpět do haly");
        }
    }
}
