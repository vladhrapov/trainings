using System;

namespace closures_001_sample
{
    public delegate int MyDelegate();

    class Program
    {
        static MyDelegate GetDelegate() {
            int num = 0;

            return delegate() {
                num += 50;

                return num;
            };
        }
        static void Main(string[] args)
        {
            var del = GetDelegate();

            Console.WriteLine(del());
            Console.WriteLine(del());
            Console.WriteLine(del());

            Console.ReadKey();
        }
    }
}
