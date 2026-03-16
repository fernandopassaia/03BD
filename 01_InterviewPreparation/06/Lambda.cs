using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Lambda com Func (multiplicação) ===");

        Func<int, int, string> calculate = (x, y) =>
        {
            int result = x * y;
            return result.ToString();
        };

        Console.WriteLine($"Resultado: {calculate(5, 7)}"); // 35


        Console.WriteLine("\n=== Lambda simples ===");

        Func<int, int> doubleValue = x => x * 2;

        Console.WriteLine($"Dobro de 10: {doubleValue(10)}"); // 20


        Console.WriteLine("\n=== Lambda com Action (sem retorno) ===");

        Action<string> printMessage = message =>
        {
            Console.WriteLine($"Mensagem: {message}");
        };

        printMessage("Olá mundo");


        Console.WriteLine("\n=== Lambda com LINQ (filtro de números) ===");

        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        var evenNumbers = numbers.Where(x => x % 2 == 0);

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}