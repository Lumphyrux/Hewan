using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan.Hewan.Habitat
{
    internal abstract class Udara : IHewan
    {
        public void Bernafas()
        {
            Console.WriteLine("Udara Segar");
        }

        public void Terbang()
        {
            Console.WriteLine("Sat set sat set");
        }
    }
}
