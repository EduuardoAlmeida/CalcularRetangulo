using System;
using System.Globalization;

namespace CalcularRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Qual a largura do retangulo?");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual a altura do retangulo?");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = r.Area(r.Largura, r.Altura);

            double perimetro = r.Perimetro(r.Largura, r.Altura);

            double diagonal = r.Diagonal(r.Largura, r.Altura);

            Console.WriteLine("A área do retângulo é: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O perímetro do retângulo é: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A diagonal do retângulo é: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}