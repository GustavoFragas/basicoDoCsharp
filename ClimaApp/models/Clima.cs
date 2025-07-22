using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Clima
{
    public class Clima
    {
        public string Graus { get; set; } = string.Empty;
        public String Estacao { get; set; } = string.Empty;

        public void Mostrar()
        {
            Console.WriteLine($"O clima é de {Graus}, \n e felizmente \n ainda estamos no {Estacao}");
        }
    }
}