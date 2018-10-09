namespace gof_001_bridge
{
    abstract class Abstraction
    {
        protected Implementor implementor = null;

        public Abstraction(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }

    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor)
            : base(implementor)
        {
        }

        public override void Operation()
        {
            // ...
            base.Operation();
            // ...
        }
    }
}