using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Calculadora");
            Inicio:
            Console.WriteLine("Digite uma opcão:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Radiciação\n");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Calculadora.Somar();
            }
            else if (opcao == 2)
            {
                Calculadora.Subtrair();
            }
            else if (opcao == 3)
            {
                Calculadora.Multiplicar();
            }
            else if (opcao == 4)
            {
                 Calculadora.Dividir();
            }
            else if (opcao == 5)
            {
                Calculadora.CalcularPotencia();
            }
            else if (opcao == 6)
            {
                Calculadora.CalcularRaizQadrada();
            }

            else
            {
                Console.WriteLine("Opção Invalida!");
                
            }
            
            Console.WriteLine();
            Console.WriteLine("Escolha:");
            Console.WriteLine("1 - Início");
            Console.WriteLine("2 - Finalizar Programa");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                goto Inicio;
            }

            else
            {
                Console.WriteLine("Fim do Programa!");
                Console.ReadKey();
            }
            

        }
    }
}
