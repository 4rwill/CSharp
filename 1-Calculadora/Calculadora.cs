using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=====Calculadora=====");
                Console.WriteLine("1-Somar");
                Console.WriteLine("2-Subtrair");
                Console.WriteLine("3-Multiplicar");
                Console.WriteLine("4-Dividir");
                Console.WriteLine("0-Sair");
                Console.Write("\nInsira sua opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Insira uma opção válida. Pressione Enter para continuar");
                    Console.ReadLine();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Somar();
                        break;
                    
                    case 2:
                        Subtrair();
                        break;
                    
                    case 3:
                        Multiplicar();
                        break;
                    
                    case 4:
                        Dividir();
                        break;
                    
                    default:
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione Enter para voltar ao menu...");
                    Console.ReadLine();
                }

            }
            while (opcao !=0);

            
        }

        static void Somar()
        {
            (double a, double b) = LerValores();
            Console.WriteLine($"\nO Resultado da soma é {a + b}");
        }

        static void Subtrair()
        {
            (double a, double b) = LerValores();
            Console.WriteLine($"\nO Resultado da subtração é {a - b}");
        }

        static void Multiplicar()
        {
            (double a, double b) = LerValores();
            Console.WriteLine($"\nO Resultado da multiplicação é {a * b}");
        }

        static void Dividir()
        {
            (double a, double b) = LerValores();
            if (b == 0)
            {
                Console.WriteLine("\nDivisão por 0 não é possível");
            }
            else
            {
                Console.WriteLine($"\nO Resultado da divisão é {a / b}");
            }
        }

        static (double a, double b) LerValores()
        {
            Console.Write("Digite o Valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            return (valor1,valor2);

        }

        
        
    }
}
