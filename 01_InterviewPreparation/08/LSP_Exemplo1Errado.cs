using System;

namespace LiskovViolationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Rectangle:");
            Test(new Rectangle());

            Console.WriteLine();

            Console.WriteLine("Testing Square:");
            Test(new Square());

            Console.ReadLine();
        }

        static void Test(Rectangle rect)
        {
            rect.Width = 5;
            rect.Height = 10; // Square vai fazer set de 10 no Width e Height

            Console.WriteLine($"Width: {rect.Width}");
            Console.WriteLine($"Height: {rect.Height}");
            Console.WriteLine($"Area: {rect.GetArea()}");
        }
    }

    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        // aqui existe um Override do "set" de ambos os campos, ou seja
        // quando fizer Set do Width 5 - ele vai colocar 5 e 5 em Width e Height
        // quando fizer o segundo set de 10 - ele também vai colocar 10 e 10 nos dois
        // por isso o resultado de Square dá 100 - o que altera o comportamento da classe
        public override int Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}