using System;

namespace delegate_001_static_method
{
    public delegate void MyDelegate();

    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Method Execution!");
        }
    }

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            myDelegate.Invoke();
            myDelegate();

            Console.ReadKey();
        }
    }
}
