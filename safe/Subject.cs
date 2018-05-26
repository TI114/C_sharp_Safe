using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeNamespace
{
    public abstract class Subject
    {
        List<IObserver> observerList = new List<IObserver>();

        public void Attach(IObserver observer, IState state)
        {
            observerList.Add(observer);
            Notify(state);
        }

        public void Detach(IObserver observer)
        {
            observerList.Remove(observer);

        }

        public void Notify(IState state)
        {
            foreach (IObserver observer in observerList)
            {
                observer.Update(state);
            }
        }
    }
}
