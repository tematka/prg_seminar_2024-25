using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Garden:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine("Přijel si na sídlo rodiny, jež tě žádá o vyšetření té vraždy. " +
                "Přivítá tě otec mrtvého Williama a děkuje ti za tvůj rychlý příjezd. Zároveň " +
                "tě ujišťuje, že jsou ti všichni členové rodiny i služebnictvo plně k dispozici" +
                "v případdě jakýchkoliv dotazů. Kromě něj tu žije ještě jeho starší syn Viktor," +
                "který ale studuje v Ingolštatu a tudíž během vyšetřování nebude přítomný," +
                "Viktorova snoubenka Elizabeth, Williamova chůva Justine a dalších několik služebných." +
                "Kývneš, že rozumíš a otec odejde dovnitř, aby jsi mohl v klidu pracovat.");
        }
        public override void Decision()
        {
            Console.WriteLine("Stojíš na zahradě, co uděláš? Můžeš jí prozkoumat (klávesa p)," +
                "jíd dovnitř (klávesa d), jít do vesnice (klávesa v) nebo do lesa (klávesa l)");
        }
        public override void Search()
        {
            Console.WriteLine("Prozkoual si celou zahradu, ale nic" +
                                        " zajímavého si nenašel. Asi budeš muset jít někam" +
                                        " jinam");
        }
    }
}
