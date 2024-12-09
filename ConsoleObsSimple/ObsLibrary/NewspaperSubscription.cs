using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLibrary
{
    public class NewspaperSubscription : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Hey " + 
                ((Client)subject).Name + 
                " ! Here's your newspaper.");
        }
    }
}
