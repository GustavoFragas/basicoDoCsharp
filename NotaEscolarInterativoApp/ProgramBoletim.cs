using NotaEscolarInterativoApp.Models;
using System;

class Boletim
{
    static void Main(string[] args)
    {
        Media boletimEscolar = new Media();

        Console.WriteLine("--- Calculadora de Boletim Escolar ---");

        Console.WriteLine("Qual foi a nota do seu primeiro bimestre?");
        boletimEscolar.Nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual foi a nota do seu segundo bimestre?");
        boletimEscolar.Nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual foi a nota do seu terceiro bimestre?");
        boletimEscolar.Nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual foi a nota do seu quarto bimestre?");
        boletimEscolar.Nota4 = double.Parse(Console.ReadLine());

        double mediaFinal = boletimEscolar.CalcularMedia();
        
       


        if (mediaFinal >= 6.0 && mediaFinal <= 10)
        {
             Console.WriteLine($"\n--- Resultado ---");
            Console.WriteLine($"Sua média final é: {mediaFinal:F2}");
            Console.WriteLine("Parabéns! Você foi APROVADO(A)!");
        }
        else if (mediaFinal < 6 && mediaFinal >= 0)
        {
             Console.WriteLine($"\n--- Resultado ---");
            Console.WriteLine($"Sua média final é: {mediaFinal:F2}");
            Console.WriteLine("Que pena! Você foi REPROVADO(A). Precisa estudar mais!");
        }
        else
        {
                Console.WriteLine("Valores inválidos, digite novamente!");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
    }
}