using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan.Organisasi
{
    internal abstract class Pegawai
    {
        protected int id { get; set; }
        protected string name { get; set; }
        protected string BirthDate;
        protected string Address;
        protected string Phone;
        protected string Position;
        protected double salary;
        protected DateTime BirthDateDT;

        protected Pegawai(int id, string name, DateTime BirthDate, string Address, string Phone,double salary) {
            this.id = id;
            this.name = name;
            this.BirthDateDT = BirthDate;
            this.BirthDate = BirthDate.ToString("dd/MM/yyyy");
            this.Address = Address;
            this.Phone = Phone;
            this.salary= salary;
            InitialPosition();
        }

        protected abstract void InitialPosition();

        public abstract void Introduction();
     }
}
