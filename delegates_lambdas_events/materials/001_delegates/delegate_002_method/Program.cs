using System;

namespace delegate_002_method
{
    public delegate void MyDelegate();

    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Method.");
        }
    }


    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            MyDelegate myDelegate = new MyDelegate(myClass.Method);

            myDelegate.Invoke();
            myDelegate();

            Console.ReadKey();
        }
    }
}
