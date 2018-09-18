using System;

namespace events_002_add_remove
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;
        public event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

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
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Unsubscribe Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}
