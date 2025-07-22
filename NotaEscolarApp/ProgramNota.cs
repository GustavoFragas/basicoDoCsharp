decimal nota1 = 100;
decimal nota2 = 6;
decimal nota3 = 7;
decimal nota4 = 7; 
decimal media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media < 0 || media > 10)
{
    Console.WriteLine($"Nota informada é inválida");
}
else if (media < 6)
{
    Console.WriteLine($"Você está Reprovado com {media} de média");
}
else
{
    Console.WriteLine($"Você foi Aprovado com {media} de média");
}