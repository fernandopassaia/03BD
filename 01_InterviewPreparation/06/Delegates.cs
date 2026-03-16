using System;

public delegate void MessageDelegate();
public delegate int MathOperation(int a, int b);
public delegate double FeeCalculator(double value);

class Program
{
    static void Main()
    {
        MessageDelegate messages = SayHello1;

        // adicionando outro método
        messages += SayHello2;

        // executa os dois
        messages();

        MathOperation mathOperation = Add;
        mathOperation += Multiply;

        int result = mathOperation(5, 7);
        Console.WriteLine($"Resultado da soma: {result}"); // 35 - vai retornar APENAS o ultimo resultado

        foreach (MathOperation op in mathOperation.GetInvocationList())
        {
            int resultOp = op(5, 7); //Imprime 12 primeira vez, 35 segunda
            Console.WriteLine(resultOp);
        }

        FeeCalculator calculator;
        calculator = CalculatePix;
        //doublefee = calculator(1000);

        Console.WriteLine($"Taxa calculada por Pix: {calculator(1000)}");
        calculator = CalculateCreditCard;
        Console.WriteLine($"Taxa calculada por CreditCard: {calculator(1000)}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void SayHello1()
    {
        Console.WriteLine("Oi, eu sou o Delegate 1");
    }

    static void SayHello2()
    {
        Console.WriteLine("Oi, eu sou o Delegate 2");
    }

    static double CalculatePix(double value)
    {
        return value * 0.01;
    }

    static double CalculateCreditCard(double value)
    {
        return value * 0.05;
    }
}