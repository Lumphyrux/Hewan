namespace Hewan
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.Write("Suara kambing adalah ");
            kambing.Bersuara();
            Console.Write("Suara sapi adalah ");
            sapi.Bersuara();
        }
    }
}