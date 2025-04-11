using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Hall:room,IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Vejdeš dovnitř a ocitneš se ve velké, krásně vyzdobené hale." +
                "Kdyby se tu nedávno nestala vražda působilo to tu jako velmi klidné místo, ale " +
                "nyní je ve vzduchu cíit smutek a na oknech vysí černé závěsy");
        }
        public override void Decision()
        {
            Console.WriteLine("Stojíš v hale odkud vede několik různých dveří do různých pokojů." +
                "Kam půjdeš? Williamův pokoj (klávesa w), Viktorův pokoj (klávesa v), pokoj " +
                "Elizabeth (klávvesa e), pokoj Justine (klávesa j) pokoj otce (klávesa o) nebo" +
                " se vrátíš zpět na zahradu (klávesa z)");
        }
        public override void Search()
        {
        }
    }
}
