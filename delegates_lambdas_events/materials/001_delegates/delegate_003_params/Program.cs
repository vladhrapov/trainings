using System;

namespace delegate_003_params
{
    public delegate void MyDelegate(string name);

    class Worker {
        public void Hello(string name) {
            Console.WriteLine($"Hello {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            var mydel = new MyDelegate(worker.Hello);

            mydel.Invoke("Mark");
            mydel("Anthony");

            Console.ReadKey();
        }
    }
}
