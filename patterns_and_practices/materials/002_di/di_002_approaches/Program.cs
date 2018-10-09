using System;
using System.Collections.Generic;
using System.Linq;

namespace di_002_approaches
{
    interface IPerson {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Owner: IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Car
    {
        public IPerson Owner { get; set; }
        private IEnumerable<IPart> parts;
        private string brand;

        public Car(IEnumerable<IPart> parts, string brand)
        {
            this.parts = parts;
            this.brand = brand;
        }

        public void ShowInfo()
        {
            string parts = String.Join(",", this.parts.Select(part => $" {part?.Name} - {part?.Price}"));

            System.Console.WriteLine($"{this.Owner?.FirstName} {this.Owner.LastName}'s {this.brand}:{parts}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IPart> parts = new List<IPart> {
                new Wheel { Name = "Toyo", Price = 125.99 },
                new Engine { Name = "V8", Price = 3500 }
            };
            var ferrari = new Car(parts, "Ferrari");

            ferrari.Owner = new Owner { FirstName = "Lionel", LastName = "Messi" };

            ferrari.ShowInfo();
        }
    }
}
