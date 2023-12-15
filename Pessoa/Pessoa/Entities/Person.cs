

namespace Pessoa.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime Nascimento { get; set; }
        public double Altura { get; set; }

        public Person()
        {

        }

        public Person(string name, DateTime nascimento, double altura)
        {
            Name = name;
            Nascimento = nascimento;
            Altura = altura;
        }

        public int CalcularIdade(DateTime nascimento)
        {
            DateTime Data_atual = DateTime.Today; 
            var Idade = Data_atual.Year - nascimento.Year;
            if (nascimento.Date > Data_atual.AddYears(-Idade)) Idade--;
            return Idade;
             
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n"
                + "Date of birth: " + Nascimento.ToString("dd/MM/yyyy") + "\n"
                + "height: " + Altura + "\n"
                + "Year: " + CalcularIdade(Nascimento);
        }


    }
}