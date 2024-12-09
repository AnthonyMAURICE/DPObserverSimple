using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLibrary
{
    public interface ISubject
    {
        // Attach an observer to the subject.
        void AddObserver(IObserver observer);

        // Detach an observer from the subject.
        void RemoveObserver(IObserver observer);

        // Notify all observers about an event.
        void Notify();
    }
}
