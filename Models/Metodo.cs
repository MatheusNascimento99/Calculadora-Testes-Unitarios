using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Metodo
    {
        public int Somar(int valor1, int valor2)
        {
            Console.WriteLine("Método Somar");
            int resultado = valor1 + valor2;
            return resultado;
        }

        public int Subtrair(int valor1, int valor2)
        {
            Console.WriteLine("Método Subtrair");
            int resultado = valor1 - valor2;
            return resultado;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            return resultado;
        }

        public int Dividir(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            int resultado = valor1 / valor2;
            return resultado;
        }

        public int RestoDaDivisao(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            int resultado = valor1 % valor2;
            return resultado;
        }

        public double Potenciacao(int valor1, int valor2)
        {
            double resultado = Math.Pow(valor1, valor2);
            return resultado;
        }
    }
}


