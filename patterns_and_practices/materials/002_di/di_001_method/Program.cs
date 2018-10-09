using System;

namespace di_001_method
{
    class Dependency
    {
        public string Name { get; set; }
    }

    class UsageContainer
    {
        public void Show(Dependency dep) 
        {
            System.Console.WriteLine(dep?.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var container = new UsageContainer();

            container.Show(new Dependency { Name = "Dependency param" });
        }
    }
}
