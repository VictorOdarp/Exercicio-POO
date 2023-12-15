using System.Globalization;

namespace SomarContas.Entities
{
    internal class Account
    {
        Company Company { get; set; }
        public double Price { get; set; }
        public DateTime Maturity {  get; set; }

        public Account()
        {

        }

        public Account(Company company, double price, DateTime maturity)
        {
            Company = company;
            Price = price;
            Maturity = maturity;
        }
        
        public double Total(List<Account> accounts)
        {
            var result = accounts.Sum(p  => p.Price);
            return result;
        }

        public int DiasVencimento(DateTime maturity)
        {
            DateTime data_atual = DateTime.Now;
            DateTime Vencimento = maturity;
            TimeSpan Diferença =  Vencimento.Subtract(data_atual);
            return Diferença.Days;
            
        }

        public override string ToString()
        {
            return Company.Name.ToUpper() + " - " + Company.Type.ToUpper() + " - " + Price.ToString("F2", CultureInfo.InvariantCulture) + " - " + Maturity.ToString("dd/MM/yyyy");
        }
    }
}
