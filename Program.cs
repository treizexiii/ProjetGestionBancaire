using ProjetCompteBancaire.Class;
using System;

namespace ProjetCompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1, c2;
            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            if (c1.Superieur(c2))
                Console.WriteLine("superieur");
            else
                Console.WriteLine("inférieur");

            Console.ReadKey();
        }
    }
}
