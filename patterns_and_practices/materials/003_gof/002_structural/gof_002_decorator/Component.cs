using System;

namespace gof_002_decorator
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}