using System;

namespace gof_002_decorator
{
    abstract class Decorator : Component
    {
        public Component Component { protected get; set; }

        public override void Operation()
        {
            if (Component != null)
                Component.Operation();
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        string addedState = "Some State";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addedState);
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        void AddedBehavior()
        {
            Console.WriteLine("AddedBehavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}