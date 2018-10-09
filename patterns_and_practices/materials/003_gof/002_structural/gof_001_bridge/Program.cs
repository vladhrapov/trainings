using System;

namespace gof_001_bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementor implementor;
            Abstraction abstraction;

            implementor = new ConcreteImplementorA();
            abstraction = new RefinedAbstraction(implementor);
            abstraction.Operation();

            implementor = new ConcreteImplementorB();
            abstraction = new RefinedAbstraction(implementor);
            abstraction.Operation();
        }
    }
}
