using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // value Type
            int numeroIntero;
            float numeroVirgola32;
            double numeroVirgola64;
            bool valoreLogico;
            char carattere;
            decimal valoreDecimale128;

            int i = 10;
            int j = i;

            Console.WriteLine(i);
            Console.WriteLine(j);

            i = 5;

            Console.WriteLine(i);
            Console.WriteLine(j);

            // reference Type
            string insiemeCaratteri;

            string stringa1 = "la mia casa è bella";
            string stringa2 = stringa1;

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            stringa1 = "la mia casa è brutta";

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            object oggetto;

            Person luca = new Person("Luca", "Lippi");
            luca.eta = 18;

            Console.WriteLine(luca.Anagrafica());

            Person giovanni = luca;
            giovanni.nome = "Giovanni";

            Console.WriteLine(luca.Anagrafica());
            Console.WriteLine(giovanni.Anagrafica());



        }
    }
}
