using System.Globalization;

namespace ListaItens.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } 
        public Client Client { get; set; }

        public Product(int id, string name, double price, Client client)
        {
            Id = id;
            Name = name;
            Price = price;
            Client = client;
        }

        public Product()
        {

        }

        public int GerarNumero(int valor1, int valor2)
        {
            Random random = new Random();
            int numeroAleatório = random.Next(valor1, valor2);
            return numeroAleatório;
        }

        public override string ToString()
        {
            return "Id: " + Id + " - " + Name + " - " + Price.ToString("F2", CultureInfo.InvariantCulture) + " - " + Client.Category.ToUpper() + " - " + Client.Name;
        }
    }
}
