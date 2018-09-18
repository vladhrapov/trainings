using System;

namespace lambdas_001_anonymous_methods
{
    // Simple delegate
    public delegate void MessageDelegate();

    // Delegate with passed params
    // Support ref and out params
    public delegate int AddDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MessageDelegate del1 = delegate { Console.WriteLine("Greetings!"); };

            del1();

            AddDelegate del2 = delegate(int a, int b) { return a + b; };

            int sum = del2(5, 5);

            Console.WriteLine($"{sum}");

            Console.ReadKey();
        }
    }
}
