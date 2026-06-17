using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertisseur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convertisseur d'unités
            Console.WriteLine("Entrer le nombre de degés :");
            double nbr = double.Parse(Console.ReadLine());
            Celsius(nbr);
        }
        static double Celsius(double nbrSaisie)
        {
            Console.WriteLine(+nbrSaisie + " °C");
            Fareneith(nbrSaisie);
            return nbrSaisie;
        }
        static double Fareneith(double nbrFareneith)
        {
            nbrFareneith = (nbrFareneith*1.8 + 32);

            Console.WriteLine(nbrFareneith + " °F");
            return nbrFareneith;
        }



    }
}
