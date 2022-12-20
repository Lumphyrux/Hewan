using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hewan.Organisasi
{
    internal class Presiden:Pegawai
    {
        private string namaPerusahaan;
        private List<Manager> managers;

        public Presiden(int id, string name, DateTime BirthDate, string Address, string Phone, double salary, string namaPerusahaan,List<Manager> managers) : base(id, name, BirthDate, Address, Phone, salary)
        {
            this.namaPerusahaan = namaPerusahaan;
            this.managers = managers;
        }
        protected override void InitialPosition()
        {
            Position = "Presiden";
        }

        public override void Introduction()
        {
            Console.WriteLine("Id\t\t : " + id);
            Console.WriteLine("Nama \t\t : " + name);
            Console.WriteLine("Alamat\t\t : " + Address);
            Console.WriteLine("Nomor HP\t : " + Phone);
            Console.WriteLine("Position\t : " + Position);
            Console.WriteLine("Tgl Lahir \t : " + BirthDate);
            Console.WriteLine("Gaji\t\t : " + salary);
            Console.WriteLine("Nama Perusahaan\t : " + namaPerusahaan);
            Console.Write("Bawahan \t : ");
            foreach (Manager i in managers)
            {
                if (i != managers.Last() && managers.Count()!=2)
                {
                    Console.Write(i.getID() + " " + i.getNama() + " ,");
                }
                else if(i != managers.Last())
                {
                    Console.Write(i.getID() + " " + i.getNama() +" ");
                }
                else
                {
                    Console.Write("dan " + i.getID() + " " + i.getNama());
                }
            }
            Console.WriteLine();
        }
    }
}
