Console.WriteLine("Digite uma letra por favor:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    case "g":
        Console.WriteLine("Gustavo");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;

}