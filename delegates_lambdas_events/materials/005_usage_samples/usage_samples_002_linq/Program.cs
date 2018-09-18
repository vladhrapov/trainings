using System;
using System.Linq;
using System.Collections.Generic;

namespace usage_samples_002_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(string.Join(", ", arr.Where(i => i > 5)));
            Console.WriteLine(string.Join(", ", arr.Where(i => i % 2 == 0)));
            Console.WriteLine(string.Join(", ", arr.FindAll(i => i > 3 && i < 7)));

            var arr2 = new List<dynamic>() {
                new { value = 6 },
                new { value = 35 },
                new { value = 1 },
                new { value = 78 },
                new { value = 39 },
            };

            Console.WriteLine(string.Join(", ", arr2.Select(i => i.value)));

            Console.ReadKey();
        }
    }
}
