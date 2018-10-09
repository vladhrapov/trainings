namespace gof_003_adapter
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            base.SpecificRequest();
        }
    }
}