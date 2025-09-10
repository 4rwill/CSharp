using System;

public class SomaEMedia
{

    static void Main(string[] args)
    {
        int quantidade;
        double valor;
        List<double> numbers = new List<double>();
       
        Console.Clear();

        Console.Write("Quantos numeros sua lista terá? ");

        if (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade > 10 || quantidade < 3)
        {
            Console.WriteLine("Quantidade inválida");
            return;
        }

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Insira o Valor {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out valor)){
                Console.WriteLine("Valor inválido\n");
                i--;
                continue;

            }
            numbers.Add(valor);
        }


        double sum = numbers.Sum();
        double average = numbers.Average();
        Console.WriteLine($"A Soma é {Math.Round(sum, 2)}");
        Console.WriteLine($"A média é {Math.Round(average, 2)}");

    }   
 
}