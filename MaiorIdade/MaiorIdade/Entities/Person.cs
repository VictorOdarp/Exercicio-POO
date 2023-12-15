

namespace MaiorIdade.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public int Years { get; set; }

        public Person()
        {

        }

        public Person(string name, int years)
        {
            Name = name;
            Years = years;
        }

        public void pessoaMaisVelha(List<Person> pessoa)
        {
            int MaiorIdade = 0;
            string PessoaMaisVelha = null;

            foreach (Person person in pessoa)
            {
                if (MaiorIdade < person.Years)
                {
                    MaiorIdade = person.Years;
                    PessoaMaisVelha = person.Name;
                }
            }

            Console.WriteLine(PessoaMaisVelha + " é a pessoa mais velha com " + MaiorIdade + " anos de idade");
        }

    }
}
