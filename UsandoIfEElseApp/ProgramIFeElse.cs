Console.WriteLine("Digite uma letra por favor:");
string letra = Console.ReadLine();

if (letra == "a" || letra == "b" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine($"A letra '{letra}' é uma vogal");
}
else
{
    Console.WriteLine($"A letra '{letra}' não é uma vogal");
}


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 11;

// if (quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda Realizada")
// }
// else
// {
//     Console.WriteLine("Desculpa, não temos a quantidade desejada em estoque!");
//}