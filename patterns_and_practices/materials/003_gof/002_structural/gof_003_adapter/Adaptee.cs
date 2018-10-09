using System;

namespace gof_003_adapter
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee.SpecificRequest");
        }
    }
}