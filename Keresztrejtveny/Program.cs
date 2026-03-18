using System.Runtime.InteropServices;

namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeresztrejtvenyRacs rejtveny = new KeresztrejtvenyRacs("kr1.txt");
            Console.WriteLine($"5. feladat: A keresztrejtvény mérete:\n\tSorok száma: {rejtveny.SorokDb}\n\tOszlopok száma: {rejtveny.OszlopokDb}");
            Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");
            rejtveny.Megjelenites();
        }
    }
}
