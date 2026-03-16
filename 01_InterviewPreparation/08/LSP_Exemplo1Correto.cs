using System;

namespace RectangleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Rectangle:");
            TestShape(new Rectangle(5, 10));

            Console.WriteLine();

            Console.WriteLine("Testing Square:");
            TestShape(new Square(5));

            Console.ReadLine();
        }

        static void TestShape(IShape shape)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }

    public interface IShape
    {
        int GetArea();
    }

    public class Rectangle : IShape
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public int Side { get; }

        public Square(int side)
        {
            Side = side;
        }

        public int GetArea()
        {
            return Side * Side;
        }
    }
}