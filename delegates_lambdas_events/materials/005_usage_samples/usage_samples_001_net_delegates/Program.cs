using System;

namespace usage_samples_001_net_delegates
{
    class Program
    {
        public static void Greet(Action action) {
            action();
        }

        public static string Greet(Func<string, string> formatter, string message) {
            return formatter(message);
        }

        static void Main(string[] args)
        {
            // action
            Greet(() => { Console.WriteLine("Greetings!"); });

            // func
            var result = Greet((message) => message.ToUpper(), "Greetings!");
            Console.WriteLine(result);

            result = Greet((message) => message.ToLower(), "Greetings!");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
