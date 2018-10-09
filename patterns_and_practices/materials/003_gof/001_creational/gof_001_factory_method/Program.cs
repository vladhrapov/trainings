using System;

namespace gof_001_factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}
