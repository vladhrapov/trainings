using System;

namespace gof_001_bridge
{    
    abstract class Implementor
    {
        public abstract void OperationImp();
    }

    class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA");
        }
    }

    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB");
        }
    }
}