using CL_Temperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TestTemp
{
    class Program
    {
        static void Main(string[] args)
        {
           Temperature temperature = new Temperature();
            temperature.Alerte += Temperature_Alerte;
            temperature.Monter();
            temperature.Monter();
            temperature.Monter();
            temperature.Monter();
            temperature.Monter();
        }

        private static void Temperature_Alerte(float temperatureDAlerte)
        {
            Console.WriteLine(" Il y a eu une alerte pour la temperature " + temperatureDAlerte);
        }
    }
}
