using ListaItens.Entities;
using System;
using System.Globalization;

namespace ListaItens
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            List<Product> products = new List<Product>();

            Console.Write("Quantos clientes você gostaria de cadastrar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nome do cliente: ");
                string name = Console.ReadLine();
                Console.Write("Categoria: ");
                string categoria = Console.ReadLine();
                Client client = new Client(name, categoria);
                clients.Add(client);
                Console.WriteLine();

                Console.Write("Gostaria de adicionar algum item ao cadastro? (S/N)");
                char Validação = char.Parse(Console.ReadLine()); 
                if (Validação == 'S')
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok! Vamos registar o item");
                    Console.Write("Nome do item: ");
                    string nameItem = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new Product();
                    product = new Product(product.GerarNumero(1, 100), nameItem, price, client);
                    products.Add(product);

                    Console.WriteLine();
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    Console.WriteLine();
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Cliente cadastrado com sucesso!");
                }

                Console.WriteLine();

            }

            Console.WriteLine("Lista de Clientes cadastrados");
            foreach (Client client in clients)
            {
                Console.WriteLine(client);
            }

            Console.WriteLine();

            Console.WriteLine("Lista de Cliente com produtos cadastrados");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();

            Console.WriteLine("Nomes dos clientes");
            foreach (Client client in clients)
            {
                Console.WriteLine(client.Name);
            }
            Console.WriteLine();

            var maiorValor = products.Max(p => p.Price);
            Console.WriteLine("Item com maior valor: " + maiorValor);

        }
    }
}