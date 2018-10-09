using System;

namespace gof_001_chain_of_responsibility
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int request);
    }

    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
                Console.WriteLine("One");
            else if (Successor != null)
                Successor.HandleRequest(request);
        }
    }

    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
                Console.WriteLine("Two");
            else if (Successor != null)
                Successor.HandleRequest(request);
        }
    }
}