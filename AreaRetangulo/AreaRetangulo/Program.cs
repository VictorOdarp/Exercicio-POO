using AreaRetangulo.Entities;
using System;
using System.Globalization;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a altura do retangulo? ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a base do retangulo? ");
            double baze = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Retangulo retangulo = new Retangulo(altura, baze);
            retangulo = new Retangulo(altura, baze, retangulo.CalculoAreaRetangulo(altura, baze));

            Console.WriteLine(retangulo);
            
            
            
            
        }
    }
}
