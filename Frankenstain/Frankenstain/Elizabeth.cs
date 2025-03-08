using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Elizabeth:Person
    {
        public override void Interrogation()
        {
            Console.WriteLine("Elizabeth ti prozradí, že dala den před vraždou Williamovi medailonek, " +
                "který na sobě ale mrtvý Williame už neměl. Co se s ním stalo a kde je ale netuší." +
                "Protože už nevíš, na co jiného se zeptat, vrátíš se do haly");
        }
    }
}
