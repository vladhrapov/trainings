namespace gof_003_observer
{
    abstract class Observer
    {
        public abstract void Update(string state);
    }

    class ConcreteObserver : Observer
    {
        string observerState;
        ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update(string state)
        {
            observerState = state;
            System.Console.WriteLine($"State Update To: {state}");
        }
    }
}