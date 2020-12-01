using Observer.Observers;
using System.Collections.Generic;

namespace Observer.Subjects
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Broadcaster
    {
        private List<IRadio> _observers = new List<IRadio>();

        public void Attach(IRadio observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IRadio observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IRadio radio in _observers)
            {
                radio.Output(this);
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                Notify();
            }
        }
    }
}