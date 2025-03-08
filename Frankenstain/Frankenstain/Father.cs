using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Father:Person
    {
        public override void Interrogation()
        {
            Console.WriteLine("Otec ti řekne, že Williama našel mrtvého v lese on. Jeho chůva Justine " +
                "si s ním předešlý den předtím měla hrát. Večer je viděl ještě spolu a ráno " +
                "Justine přiběhla úplně zoufalá, že Williama hledá celou noc a nemůže ho najít " +
                "a tudíž jsme ho začali hledat. Když jsme ho našli, měl na krku nodřinu, jako by byl" +
                "něčím uškrcen, ale nic v okolí, čím by mohl být uškrcen v okolí nebylo. Otci" +
                "za jeho výpověď poděkuješ a vrátíš se zpět do haly");
        }
    }
}
