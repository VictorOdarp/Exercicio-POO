

using System.Runtime.CompilerServices;

namespace SomarContas.Entities
{
    internal class Company
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Company()
        {

        }

        public Company(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
