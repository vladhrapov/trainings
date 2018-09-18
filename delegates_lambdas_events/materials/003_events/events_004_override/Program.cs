using System;

namespace events_004_override
{
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;
        void InvokeEvent();
    }

    public class BaseClass : IInterface
    {
        public virtual event EventDelegate MyEvent = null;

        public virtual void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent = null;

        public override void InvokeEvent()
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
            DerivedClass instance = new DerivedClass();

            // subscribe
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // unsubscribe Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}
