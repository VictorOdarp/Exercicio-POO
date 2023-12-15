using ControleDeAnimais.Entities;
using System;

namespace ControleAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> list = new List<Animals>();
            Animals animals = new Animals();

            int Cachorros = 0;
            int Gatos = 0;
            int Peixe = 0;

            Console.Write("Quantos animais você quer cadastrar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("What type of animal? (Cachorro/Gato/Peixe): ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (type == "Cachorro")
                {
                    animals = new Animals(name, type);
                    list.Add(animals);
                    Cachorros++;
                }
                else if (type == "Gato")
                {
                    animals = new Animals(name, type);
                    list.Add(animals);
                    Gatos++;
                }
                else if (type != "Cachorro" || type != "Gato")
                {
                    animals = new Animals(name, "Peixe");
                    list.Add(animals);
                    Peixe++;
                }

            }

            animals.Dados(list);
            Console.WriteLine();

            Console.WriteLine("Cachorros: " + Cachorros);
            Console.WriteLine("Gatos: " + Gatos);
            Console.WriteLine("Peixes: " + Peixe);


        }
    }
}
