using ObsLibrary;

namespace ConsoleObsSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new("Bob");
            Client client2 = new("Bill");

            NewspaperSubscription subscription = new NewspaperSubscription();

            client1.AddObserver(subscription);
            client2.AddObserver(subscription);
            client1.GetSubscription();
            client2.RemoveObserver(subscription);
            client2.GetSubscription();

        }
    }
}
