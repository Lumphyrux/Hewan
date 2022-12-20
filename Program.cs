using Hewan.Hewan.Binatang;
using Hewan.Organisasi;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace Hewan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JalankanOrganisasi();
        }

        static void JalankanOrganisasi()
        {

            Karyawan programmer1 = new Karyawan(1,"Luis", new DateTime(2000, 05, 09), "Bekasi","085927492749",1800000,"IT");

            Manager manager1 = new Manager(2, "Nicolas", new DateTime(1999,12,08), "Cilandak", "0561293232", 30000000, "TI", new List<Karyawan> { programmer1 });

            Presiden presiden1 = new Presiden(3, "Nicolas", new DateTime(1999,09,03), "Cilandak", "0561293232", 30000000, "Kodehive", new List<Manager> { manager1 });

            Karyawan programmer2 = new Karyawan(4, "Koli", new DateTime(1954,7,12), "Jakarta", "085123132749", 3200000, "Sales");

            Karyawan sales2 = new Karyawan(5, "Giga", new DateTime(2002,2,22), "Surakarta", "02324124321", 2500000, "IT");
            Karyawan sales22 = new Karyawan(13, "Tera", new DateTime(2012, 12, 12), "Jogjakarta", "081124321", 4500000, "IT");

            Manager manager2 = new Manager(6, "Itpro", new DateTime(1999,9,19), "Cibubur", "05667754432", 450000000, "Sales", new List<Karyawan> { programmer2 });
            Manager managers2 = new Manager(7, "Salespro", new DateTime(1999,1,9), "Cicak", "05123132", 770000000, "TI", new List<Karyawan> { sales2,sales22 });

            Presiden presiden2 = new Presiden(8, "Nicolas", new DateTime(1995,6,7), "Cilandak", "0561293232", 30000000, "Kodenest", new List<Manager> { manager2,managers2 });

            Manager manager3 = new Manager(9, "Sesaon", new DateTime(1999,12,11), "Cisaon", "012455123132", 90000000, "Education", new List<Karyawan> { });
            Manager manager32 = new Manager(11, "Sesian", new DateTime(1965,4,25), "Cisson", "01246786783132", 45000000, "Tech", new List<Karyawan> { });
            Manager manager33 = new Manager(12, "Sejaon", new DateTime(1999,9,15), "Kotadon", "01243424432", 2000000, "Food", new List<Karyawan> { });

            Presiden presiden3 = new Presiden(10, "Terakhir", new DateTime(1977,7,17), "Cifinal", "0544242432", 9990000000, "Kodehome", new List<Manager> { manager3,manager32,manager33 });

            managers2.Introduction();
        }

        static void JalankanHewan()
        {
            Kambing kambing = new();
            Sapi sapi = new();
            Beo beo = new();
            Elang elang = new();
            Hiu hiuPutih = new();
            Paus paus = new();


            kambing.Bernafas();
            sapi.Jalan();
            beo.Bernafas();
            elang.Terbang();
            hiuPutih.Bernafas();
            paus.Berenang();
        }
    }
}