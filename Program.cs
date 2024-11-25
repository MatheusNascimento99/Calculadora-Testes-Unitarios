using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Calculadora.Models;

int escolha = 10;
Metodo metodo = new();



while (escolha != 0)
{
    Console.WriteLine("Bem vindo a Calculadora!");
    Console.WriteLine("Informe o primeiro valor:");
    int valor1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor:");
    int valor2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escolha a ação a ser realizada:");
    Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Resto da Divisão\n6 - Potenciação\n0 - Sair");

    escolha = Convert.ToInt32(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.WriteLine($"{valor1} + {valor2} = {metodo.Somar(valor1, valor2)}\n");
            break;
        case 2:
            Console.WriteLine($"{valor1} - {valor2} = {metodo.Subtrair(valor1, valor2)}\n");
            break;
        case 3:
            Console.WriteLine($"{valor1} * {valor2} = {metodo.Multiplicar(valor1, valor2)}\n");
            break;
        case 4:
            Console.WriteLine($"{valor1} / {valor2} = {metodo.Dividir(valor1, valor2)}\n");
            break;
        case 5:
            Console.WriteLine($"{valor1} % {valor2} = {metodo.RestoDaDivisao(valor1, valor2)}\n");
            break;
        case 6:
            Console.WriteLine($"{valor1} ^ {valor2} = {metodo.Potenciacao(valor1, valor2)}\n");
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

