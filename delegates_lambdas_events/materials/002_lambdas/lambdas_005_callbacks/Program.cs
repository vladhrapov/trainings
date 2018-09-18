﻿using System;

namespace lambdas_005_callbacks
{
    delegate MyDelegate Functional(MyDelegate delegate1, MyDelegate delegate2);
    delegate string MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate delegate1 = () => "Hello ", delegate2 = () => "world!";

            Functional functional = delegate(MyDelegate d1, MyDelegate d2) {
                return delegate() { return d1() + d2(); };
            };
            // Functional functional = delegate(MyDelegate d1, MyDelegate d2) {
            //     return () => d1.Invoke() + d2.Invoke();
            // };
            //Functional functional = (MyDelegate d1, MyDelegate d2) => () => d1() + d2();

            //Console.WriteLine((functional.Invoke(delegate1,delegate2)).Invoke());
            Console.WriteLine(functional(delegate1, delegate2)());

            Console.ReadKey();
        }
    }
}
