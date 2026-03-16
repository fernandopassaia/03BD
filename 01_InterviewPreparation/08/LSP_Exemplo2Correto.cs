using System;

namespace PersonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWalk(new Child());
            TestWalk(new Adult());

            Console.WriteLine();

            Console.WriteLine("Testing Erdely:");

            var erdely = new Erdely();
            Console.WriteLine("Erdely cannot walk");

            Console.ReadLine();
        }

        static void TestWalk(IWalkable person)
        {
            bool result = person.StartWalking();

            Console.WriteLine($"{person.GetType().Name} walking result: {result}");
        }
    }

    public class Person
    {
    }

    public interface IWalkable
    {
        bool StartWalking();
    }

    public class Child : Person, IWalkable
    {
        public bool StartWalking()
        {
            Console.WriteLine("Child tries to walk");
            return false;
        }
    }

    public class Adult : Person, IWalkable
    {
        public bool StartWalking()
        {
            Console.WriteLine("Adult starts walking");
            return true;
        }
    }

    public class Erdely : Person
    {
        // does not implement IWalkable
    }
}