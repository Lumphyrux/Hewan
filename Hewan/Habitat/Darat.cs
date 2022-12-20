using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan.Hewan.Habitat
{
    internal abstract class Darat : IHewan
    {
        public void Bernafas()
        {
            Console.WriteLine("Tarik nafasssss keluarrrrr");
        }

        public void Jalan()
        {
            Console.WriteLine("Step step step step");
        }
    }
}
