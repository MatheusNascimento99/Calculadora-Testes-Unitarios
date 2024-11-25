using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Calculadora.Models;

int escolha = 10;
Metodo metodo = new();

int numero;


while (escolha != 0)
{
    Console.WriteLine("Bem vindo a Calculadora!");
    Console.WriteLine("Informe o primeiro valor:");
    string valor1 = Console.ReadLine();
    while (!int.TryParse(valor1, out numero))
    {
        Console.WriteLine("Entrada não válida, por favor informe apenas números!");
        Console.WriteLine("Informe o primeiro valor:");
        valor1 = Console.ReadLine();

    }


    Console.WriteLine("Informe o segundo valor:");
    string valor2 = Console.ReadLine();
    while (!int.TryParse(valor2, out numero))
    {
        Console.WriteLine("Entrada não válida, por favor informe apenas números!");
        Console.WriteLine("Informe o segundo valor:");
        valor2 = Console.ReadLine();
    }

    Console.WriteLine("Escolha a ação a ser realizada:");
    Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Resto da Divisão\n6 - Potenciação\n0 - Sair");

    escolha = Convert.ToInt32(Console.ReadLine());
    int num1 = Convert.ToInt32(valor1);
    int num2 = Convert.ToInt32(valor2);

    switch (escolha)
    {
        case 1:
            Console.WriteLine($"{num1} + {num2} = {metodo.Somar(num1, num2)}\n");
            break;
        case 2:
            Console.WriteLine($"{num1} - {num2} = {metodo.Subtrair(num1, num2)}\n");
            break;
        case 3:
            Console.WriteLine($"{num1} * {num2} = {metodo.Multiplicar(num1, num2)}\n");
            break;
        case 4:
            Console.WriteLine($"{num1} / {num2} = {metodo.Dividir(num1, num2)}\n");
            break;
        case 5:
            Console.WriteLine($"{num1} % {num2} = {metodo.RestoDaDivisao(num1, num2)}\n");
            break;
        case 6:
            Console.WriteLine($"{num1} ^ {num2} = {metodo.Potenciacao(num1, num2)}\n");
            break;
        case 0:
            Console.WriteLine("Programa Finalizado!");
            break;
        default:
            if (escolha < 0 || escolha > 5)
            {
                Console.WriteLine("Opção inválida, informe novamente a opção:");
            }
            break;
    }
}


