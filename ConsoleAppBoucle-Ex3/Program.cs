using System;
namespace ConsoleAppBoucle_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double capital = 1200;
            int annees = 0;

            Console.Write("Quelle somme veux-tu atteindre ? ");
            double objectif = double.Parse(Console.ReadLine());

            while (capital < objectif)
            {
                capital = capital + capital * 1.3 / 100;   // on ajoute 1,3% d'intérêts
                annees = annees + 1;
            }

            Console.WriteLine("Il faut " + annees + " ans pour atteindre " + objectif + "€.");
        }
    }
}
