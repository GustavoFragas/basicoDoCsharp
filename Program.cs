using Models.Pessoa;
using Models.Clima;
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




















// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResposavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResposavel)
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }








// Console.WriteLine("Digite uma letra por favor:");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     case "g":
//         Console.WriteLine("Gustavo");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }



// if (letra == "a" || letra == "be" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine($"A letra '{letra}' é uma vogal");
// }
// else
// {
//     Console.WriteLine($"A letra '{letra}' não é uma vogal");
// }

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("É uma consoante");
// }


//NOTA ESCOLAR
// decimal nota1 = 10;
// decimal nota2 = 6;
// decimal nota3 = 7;
// decimal nota4 = 8; 
// decimal media = (nota1 + nota2 + nota3 + nota4) / 4;

// if (media < 0 || media > 10)
// {
//     Console.WriteLine($"Nota informada é inválida");
// }
// else if (media < 6)
// {
//     Console.WriteLine($"Você está Reprovado com {media} de média");
// }
// else
// {
//     Console.WriteLine($"Você foi Aprovado com {media} de média");
// }











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







//QUARTO TEMA, Declarando variaveis e mudando
// int a = 38748324;
// int b = 42112412;
// int c = a + b;

// // c = c - 80860731;
// c -= 80860731;

// Console.WriteLine("O resultado é " + c);


//TERCEIRO TEMA = tipo date time
// DateTime dataatual = DateTime.Now;
// Console.WriteLine(dataatual.ToString("dd/mm/yyyy HH:mm"));
// Console.WriteLine(dataatual.ToString("yyyy HH:mm"));







//SEGUNDO TEMA - Tipo de variaveis e manipulação
// String apresentacao = "Olá, seja bem vindo!";

// int quantidade = 19;

// double altura = 1.80;

// decimal plata = 487.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Essa é a minha quantidade " + quantidade);
// Console.WriteLine("Essa é a minha altura " + altura.ToString("0.00"));
// Console.WriteLine("Essa é a minha plata " + plata);
// Console.WriteLine("Essa é a minha condição " + condicao);




// CTRL + K + C = deixa tudo selecionado no modo comentario








//PRIMEIRO TEMA - Sintaxe
//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Gustavo";
//pessoa1.Idade = 20;
//pessoa1.Apresentar();

//Clima clima1 = new Clima();

//clima1.Graus = "30°";
//clima1.Estacao = "Verão";
//clima1.Mostrar();