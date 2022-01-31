using System;

namespace Csharp_vezbanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a = new Automobil();
            Automobil b = new Automobil();

            Console.WriteLine("Unesite podatke o 1. automobilu:");
            a.Unos();
            Console.WriteLine("Unesite podatke o 2. automobilu:");
            b.Unos();
            Console.WriteLine("Automobil koji ima vecu cenu:");
            vecaCena(a, b);
        }
        static void vecaCena(Automobil a,Automobil b)
        {
            if (a.cena > b.cena)
            {
                a.Ispis();
            }
            else { 
                b.Ispis();
                 }

        }



    }
}
