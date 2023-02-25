using System;

namespace Atividade
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(double largura, Double altura)
        {
            return largura * altura;
        }

        public double Perimetro(double largura, double altura)
        {
            return 2*(largura + altura);
        }

        public double Diagonal (double largura, double altura)
        {
            double resultado = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);

            resultado = Math.Sqrt(resultado);

            return resultado;
        }
    }
}
