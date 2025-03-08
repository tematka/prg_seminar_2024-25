using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class ViktorRoom:room, IObject
    {
        public void Introduction()
        {
            Console.WriteLine();
        }
        public override void Decision()
        {
            Console.WriteLine("Zkusíš vstoupit do Viktorova pokoje, ale je zamčený. Zeptáš se " +
                "kolem jdoucí služebné, ale ta ti zdělí, že jediný klíč má pan Viktor usebe." +
                "To znamená, že se dovnitř nedostaneš, ale zároveň by tam nemělo být nic důležitého," +
                "protože tam neměl přístup už pár let nikdo. Můžeš buď pokračovat ve vyšetřování jinde " +
                "(klávesa p) a nebo už si vše prohlédl a všechny vyslechl a chceš přejít k obžalobě svého podezřelého" +
                "před soudem (klávesa s)");
        }
        public override void Search()
        {
        }
    }
}
