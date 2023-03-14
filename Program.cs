using System;
using System.Configuration;
namespace FisierConfigurari
{
    class Program
    {
        static void Main()
        {
            // Utilizare valori din fisierul de configurari
            string titlu =
            ConfigurationManager.AppSettings.Get("TitluAplicatie");
            Console.WriteLine(titlu);
            Console.ReadKey();
        }
    }
}