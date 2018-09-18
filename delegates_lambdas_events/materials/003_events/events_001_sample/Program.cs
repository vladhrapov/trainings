using System;

namespace events_001_sample
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate myEvent = null;

        public void InvokeEvent()
        {
            myEvent.Invoke();
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

            // Subscribe
            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += Handler2;

            // Invoke method
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Unsubscribe
            instance.myEvent -= new EventDelegate(Handler2);

            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}
