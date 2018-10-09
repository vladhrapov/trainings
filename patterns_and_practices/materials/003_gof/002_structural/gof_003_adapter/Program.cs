using System;

namespace gof_003_adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
