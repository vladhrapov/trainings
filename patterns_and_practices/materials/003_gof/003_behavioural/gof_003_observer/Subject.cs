using System;
using System.Collections;

namespace gof_003_observer
{
    abstract class Subject
    {
        ArrayList observers = new ArrayList();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract string State { get; set;}

        public void Notify()
        {
            foreach (Observer observer in observers)
                observer.Update(State);
        }
    }

    class ConcreteSubject : Subject
    {
        public override string State { get; set; }
    }
}