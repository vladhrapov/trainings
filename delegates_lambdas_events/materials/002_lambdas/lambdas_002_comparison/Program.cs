using System;

namespace lambdas_002_comparison
{
    public delegate int MyDelegate(int a);

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate(int x) { return x * 2; }; // anonymous method 

            myDelegate = (x) => { return x * 2; };          // lambda operator

            myDelegate = x => x * 2;                        // lambda expression

            int result = myDelegate(4);
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
