using System;
using System.Threading;

namespace lambdas_006_delegate_suppose
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Method");
        }
    }
       
    public delegate void MyDelegate(); 

    class Program
    {
        static void Main()
        {
            // MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            var thr = new Thread(MyClass.Method);
            thr.Start();
            
            MyDelegate myDelegate = MyClass.Method; // dont have delegate key word, but it supposed to be
            myDelegate(); 

            Console.ReadKey();
        }
    }
}
