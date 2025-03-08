using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Player:IObject
    {
        public string position = "zahrada";
        public bool locket = false;
        public void Introduction()
        {
            Console.WriteLine("Výtej ve hře. Na obrazovce se vždy objeví část příběhu a ty se můžeš " +
                "rozhodnout, jak budeš pokračovat dále. Na základě své volby vždy stiskni " +
                "odpovídající klávesu");
            Console.WriteLine("");
            Console.WriteLine("Jsi známým a úspěšným vyšetřovatelem na začátku 19.století. Nedávno" +
                " se ti ozvala jedna vážená a vlivná rodina s prosbou, aby si vyšetřil vraždu " +
                "jejich mladdšího syna Williama. Ten byl jedním vesničanem nalezen v lese uškrcený. " +
                "Nikdo však neví kdo, jak, proč a čím ho uškrtil. Vyšetři proto tento případ a " +
                "pomoz spravedlnosti");
            Console.WriteLine();
        }
    }
}
