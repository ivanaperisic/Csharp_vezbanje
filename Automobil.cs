using System;

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Csharp_vezbanje
{
    class Automobil
    {
        public string marka;
        public int godProizvodnje;
        public decimal cena;
        public string regBroj;

        public void Unos()
        {
            Console.WriteLine("Unesite marku:");
            this.marka = Console.ReadLine();
            Console.WriteLine("Unesite godinu proizvodnje:");
            this.godProizvodnje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite cenu:");
            this.cena = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Unesite registarski broj");
            this.regBroj = Console.ReadLine();
        }
            public void Ispis()
        {
            Console.WriteLine("Marka:{0}",this.marka);
            Console.WriteLine("Godina proizvodnje:{0}",this.godProizvodnje);
            Console.WriteLine("Cena:{0}",this.cena);
            Console.WriteLine("Registarski broj:{0}",this.regBroj);
           



        }













        }
    }

