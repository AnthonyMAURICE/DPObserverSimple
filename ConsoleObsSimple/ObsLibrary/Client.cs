namespace ObsLibrary
{
    public class Client : ISubject
    {
        private string name;
        private bool subscription = false;
        private readonly List<IObserver> observers = [];
        public Client(string _name) 
        {
            this.name = _name;
        }

        public string Name { get => name; set => name = value; }
        public bool Subscription { get => subscription;}

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void GetSubscription() 
        {
            if (!this.subscription)
            {
                this.subscription = true;
            }
            this.Notify();
        }

        public void Notify()
        {
            Console.WriteLine("Notifying observers...");
            foreach (IObserver observer in observers) 
            {
                // the modified state is passed in parameters
                // wrapped in a object ("pull" method)
                // rather than directly ("push" method)
                observer.Update(this);
            }
        }
    }
}
