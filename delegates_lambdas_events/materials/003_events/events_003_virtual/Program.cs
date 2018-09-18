using System;

namespace events_003_virtual
{
    public delegate void EventDelegate();

    interface IInterface
    {
        // abstract
        event EventDelegate MyEvent;
    }

    public class BaseClass : IInterface
    {
        EventDelegate myEvent = null;

        // virtual.
        public virtual event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine("Handler added - {0}", value.Method.Name);
            }
            remove
            {
                base.MyEvent -= value;
                Console.WriteLine("Handler removed - {0}", value.Method.Name);
            }
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

            // Subscribe.
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
