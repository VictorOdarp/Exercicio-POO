using MaiorIdade.Entities;
using System;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Person person = new Person();

            Console.Write("Quantas pessoas você quer cadastrar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Idade: ");
                int years = int.Parse(Console.ReadLine());
                person = new Person(name, years);
                list.Add(person);
            }

            person.pessoaMaisVelha(list);

            

            

            

            
            
            
        }
    }
}
