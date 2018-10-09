using System;

namespace gof_002_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate a = new ConcreteAggregate();

            a[0] = "Element A";
            a[1] = "Element B";
            a[2] = "Element C";
            a[3] = "Element D";

            Iterator i = a.CreateIterator();

            for (object e = i.First(); !i.IsDone(); e = i.Next())
                Console.WriteLine(e);

            Console.WriteLine(new string('-', 10));

            for (object e = i.First(); !i.IsDone(); e = i.Next())
                Console.WriteLine(e);
        }
    }
}
