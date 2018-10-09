using System;

namespace gof_003_strategy
{
    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyB");
        }
    }

    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyC");
        }
    }
}