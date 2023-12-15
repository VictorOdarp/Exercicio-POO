

namespace ListaItens.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public Client()
        {

        }

        public Client(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public void CadastrarClient(string name, string category)
        {
            Client client = new Client(name, category);

        }

        public override string ToString()
        {
            return "Name: " + Name + " | " + "Category: " + Category; 
        }
    }
}
