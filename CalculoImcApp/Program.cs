using System;
using System.Globalization;
using CalculoIMC.Models;

class Program
{
    static void Main(string[] args)
    {
        Dados dadosCalculo = new Dados();

        Console.WriteLine("--- Calcule seu IMC ---");

        Console.WriteLine("Qual é sua altura? ex: 1,79");
        dadosCalculo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Qual é seu Peso? ex: 70,3");
        dadosCalculo.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = dadosCalculo.CalculoIMC();

        Console.WriteLine("--- Resultado ---");

        if (resultado < 18.5)
        {
            Console.WriteLine($"Seu IMC é de {resultado:F2} e você está na categoria Magreza, ou seja, necessita a ajuda de um especialista");
        }

        else if (resultado >= 18.5 && resultado <= 24.9)
        {
            Console.WriteLine($"Seu IMC é de {resultado:F2}, parabéns, você esta na categoria normal, siga assim para viver de uma maneira sáudavel");
        }

        else if (resultado >= 25 && resultado < 30)
        {
            Console.WriteLine($"Seu IMC é de {resultado:F2} e você está na categoria sobrepeso, ou seja, necessita a ajuda de um especialista");
        }

        else if (resultado > 30)
        {
            Console.WriteLine($"Seu IMC é de {resultado:F2} e você está na categoria obeso, por favor, busque ajuda médica, obesidade não é brincadeira");
        }


        Console.WriteLine("--- Pressione qualquer tecla para sair ");
        Console.ReadKey();


    }
}