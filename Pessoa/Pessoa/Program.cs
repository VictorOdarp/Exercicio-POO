using Pessoa.Entities;
using System;
using System.Globalization;

namespace PessoaInformações
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Date of birth: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());  
            Console.Write("height: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Person person = new Person(name, nascimento, altura);
            Console.WriteLine();
            person.CalcularIdade(nascimento);

            Console.WriteLine(person);
            
            
        }
    }
}
