

using System.Globalization;

namespace AreaRetangulo.Entities
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Base { get; set; }
        public double Area {  get; set; }

        public Retangulo()
        {

        }

        public Retangulo(double altura, double baze, double area)
        {
            Altura = altura;
            Base = baze;
            Area = area;
        }
        public Retangulo(double altura, double baze)
        {
            Altura = altura;
            Base = baze;
        }
        
        public Retangulo(double area)
        {
            Area = area;
        }

        public double CalculoAreaRetangulo(double altura, double baze)
        {
            return altura * baze;
        }

        public override string ToString()
        {
            return "Altura: " + Altura.ToString("F1", CultureInfo.InvariantCulture) + "\n" +
            "Base: " + Base.ToString("F1", CultureInfo.InvariantCulture) + "\n" +
            "Area Retangulo = " + Area.ToString("F1", CultureInfo.InvariantCulture);
        }


    }
}
