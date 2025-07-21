using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFísica { get;set; } = string.Empty;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}