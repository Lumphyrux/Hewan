using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan
{
    internal abstract class Air : IHewan
    {
        public void Bernafas()
        {
            Console.WriteLine("Help im under the water");
        }

        public void Berenang()
        {
            Console.WriteLine("Blubub blubub");
        }
    }
}
