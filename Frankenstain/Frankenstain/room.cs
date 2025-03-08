using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal abstract class room
    {
        public bool visited = false;
        public abstract void Decision();
        public abstract void Search();
    }
}
