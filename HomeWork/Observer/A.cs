using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class A : IObservable<A>
    {
        private int _value;
        private readonly IList<IObserver<A>> _listeners = new List<IObserver<A>>();

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Notify();
                }
            }
        }
        public IDisposable Subscribe(IObserver<A> observer)
        {
            _listeners.Add(observer);
            return new Unsubscriber(this, observer);
        }

        private void Notify()
        {
            foreach (var listener in _listeners)
            {
                listener.OnNext(this);
            }
        }

        private class Unsubscriber : IDisposable
        {
            private readonly A _sensor;
            private readonly IObserver<A> _listener;

            public Unsubscriber(A sensor, IObserver<A> listener)
            {
                _sensor = sensor;
                _listener = listener;
            }

            public void Dispose()
            {
                _sensor._listeners.Remove(_listener);
            }
        }
    }
}
