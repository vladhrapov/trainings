using System;

namespace gof_001_factory_method
{
    abstract class Product
    {
    }

    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}