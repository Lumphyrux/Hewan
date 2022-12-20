using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan.Organisasi
{
    internal class Manager : Pegawai
    {
        private string ManagerType;
        private List<Karyawan> bawahan;
        public Manager(int id, string name, DateTime BirthDate, string Address, string Phone, double salary, string ManagerType,List<Karyawan> bawahan) : base(id, name, BirthDate, Address, Phone, salary)
        {
            this.ManagerType = ManagerType;
            this.bawahan= bawahan;
        }

        protected override void InitialPosition()
        {
            Position = "Manager";
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
            Console.WriteLine("ManagerType\t : " + ManagerType);
            Console.Write("Bawahan \t : ");
            foreach(Karyawan i in bawahan)
            {
                if (i != bawahan.Last() && bawahan.Count() != 2)
                {
                    Console.Write(i.getID() + " " + i.getNama() + " ,");
                }
                else if (i != bawahan.Last())
                {
                    Console.Write(i.getID() + " " + i.getNama() + " ");
                }
                else
                {
                    Console.Write("dan " + i.getID() + " " + i.getNama());
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public string getNama()
        {
            return name;
        }

        public int getID()
        {
            return id;
        }
    }
}
