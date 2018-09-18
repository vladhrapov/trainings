using System;

namespace events_005_lambda
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Handler 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Handler 2");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            // subscribe
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);
            instance.MyEvent += delegate { Console.WriteLine("Anonymous 1."); };

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // unsubscribe Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);
            
            instance.MyEvent -= delegate { Console.WriteLine("Anonymous 1."); };

            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}
