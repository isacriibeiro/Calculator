using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal static class Calculadora
    {
        private static double num1, num2;

        public static void Somar()
        {
            num1 = 0;
            num2 = 0;
            Console.WriteLine("Digite um número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = double.Parse(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine("O resultado é: " + result);
        }

        public static void Subtrair()
        {
            num1 = 0;
            num2 = 0;
            Console.WriteLine("Digite um número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = double.Parse(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine("O resultado é: " + result);
        }

        public static void Multiplicar()
        {
            num1 = 0;
            num2 = 0;
            Console.WriteLine("Digite um número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = double.Parse(Console.ReadLine());

            double result = num1 * num2;
            Console.WriteLine("O resultado é: " + result);
        }

        public static void Dividir()
        {
            num1 = 0;
            num2 = 0;
            Console.WriteLine("Digite um número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = double.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine("O resultado é: " + result);
            }

            else
            {
                Console.WriteLine("Não existe divisão por 0");
            }

        }

        public static void CalcularPotencia()
        {
            num1 = 0;
            num2 = 0;
            Console.WriteLine("Digite um número para base:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            num2 = double.Parse(Console.ReadLine());

            double result = Math.Pow(num1, num2);
            Console.WriteLine("O resultado é: " + result);
        }

        public static void CalcularRaizQadrada()
        {
            num1 = 0;
            Console.WriteLine("Digite qual número deseja saber a raíz quadrada:");
            num1 = double.Parse(Console.ReadLine());

            double result = Math.Sqrt(num1);
            Console.WriteLine("O resultado é: " + result);
        }


    }
}