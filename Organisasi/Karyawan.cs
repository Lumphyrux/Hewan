using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan.Organisasi
{
    internal class Karyawan:Pegawai
    {
        private string divisi;
        public Karyawan(int id, string name, DateTime BirthDate, string Address, string Phone, double salary, string divisi) : base(id, name, BirthDate, Address, Phone,salary)
        {
            this.divisi= divisi;
        }
        protected override void InitialPosition()
        {
            Position = "Karyawan";
        }

        public override void Introduction()
        {
            Console.WriteLine("Id\t\t : " + id);
            Console.WriteLine("Nama \t\t : " + name);
            Console.WriteLine("Alamat\t\t : "+Address);
            Console.WriteLine("Nomor HP\t : " + Phone);
            Console.WriteLine("Position\t : " + Position);
            Console.WriteLine("Tgl Lahir \t : " +BirthDate);
            Console.WriteLine("Gaji\t\t : " + salary);
            Console.WriteLine("Divisi\t\t : "+ divisi);
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
