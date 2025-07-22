using Models.Calculadora;

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(10, 45);
calc.Dividir(10, 5);
calc.Potencia(5, 5);
calc.Tangente(30);
calc.Coseno(30);
calc.Seno(45); 
calc.RaizQuadrada(81);

int numero = 10;
Console.WriteLine($"O valor é {numero}");
numero++;
Console.WriteLine($"O valor é {numero}");
numero--;
Console.WriteLine($"O valor é {numero}");
