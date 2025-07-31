using System;

namespace CalculoIMC.Models
{
    public class Dados
    {
        public double Peso { get; set; }
        public double Altura { get; set; }


        public double CalculoIMC()
        {
            return Peso / Math.Pow(Altura, 2);
        }
    }
}
