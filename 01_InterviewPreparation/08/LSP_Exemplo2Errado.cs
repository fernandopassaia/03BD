using System;

namespace LspPersonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Child:");
            TestPerson(new Child());

            Console.WriteLine();

            Console.WriteLine("Testing Adult:");
            TestPerson(new Adult());

            Console.WriteLine();

            Console.WriteLine("Testing Erdely:");
            TestPerson(new Erdely());

            Console.ReadLine();
        }

        static void TestPerson(Person person)
        {
            try
            {
                bool result = person.StartWalking();

                Console.WriteLine($"StartWalking returned: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    public class Person
    {
        public virtual bool StartWalking()
        {
            Console.WriteLine("Person starts walking");
            return true;
        }
    }

    public class Child : Person
    {
        public override bool StartWalking()
        {
            Console.WriteLine("Child tries to start walking");
            return false;
        }
    }

    public class Adult : Person
    {
        public override bool StartWalking()
        {
            Console.WriteLine("Person starts walking");
            return true;
        }
    }

    public class Erdely : Person
    {
        public override bool StartWalking()
        {
            Console.WriteLine("Too old to walk");
            throw new NotImplementedException("Erdely cannot walk");
        }
    }
}