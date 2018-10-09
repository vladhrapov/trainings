using System;

namespace oop_003_composition
{    
    public class Engine {
        public string Name { get; set; }
    }

    public class Car
    {
        public string Brand { get; private set; }
        public Engine Engine { get; private set; } = new Engine {
            Name = "V8"
        };

        public Car(string brand)
        {
            this.Brand = brand;
        }

        public void ShowInfo() {
            System.Console.WriteLine($"{Brand} {Engine?.Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ferrari = new Car("Ferrari");

            ferrari.ShowInfo();
        }
    }
}
