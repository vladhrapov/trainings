using System;

namespace oop_002_aggregation {
    public class Engine {
        public string Name { get; set; }
    }

    public class Car
    {
        public string Brand { get; private set; }
        public Engine Engine { get; private set; }

        public Car(Engine engine, string brand)
        {
            this.Brand = brand;
            this.Engine = engine;
        }

        public void ShowInfo() {
            System.Console.WriteLine($"{Brand} {Engine?.Name}");
        }
    }

    class Program {
        static void Main (string[] args)
        {
            var engine = new Engine { Name = "V8" };
            var ferrari = new Car(engine, "Ferrari");

            ferrari.ShowInfo();

            Console.WriteLine ("Hello World!");
        }
    }
}