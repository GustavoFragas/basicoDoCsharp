using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaEscolarInterativoApp.Models
{
    public class Media
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }


        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4
            ; 
        }
    }
}