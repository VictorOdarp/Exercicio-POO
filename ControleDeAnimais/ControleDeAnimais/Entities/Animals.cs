

namespace ControleDeAnimais.Entities
{
    internal class Animals
    {
        public string Name { get; }
        public string Type { get; }

        public Animals()
        {

        }

        public Animals(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Dados(List<Animals> animals)
        {
            Console.WriteLine();

            foreach (Animals animal in animals)
            {
                Console.WriteLine(animal.Name + " - " + animal.Type);

            }

        }


    }
}
