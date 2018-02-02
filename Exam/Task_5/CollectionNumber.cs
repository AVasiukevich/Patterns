using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class CollectionNumber : IObservable<CollectionNumber>, IEnumerable<int>
    {
        private IList<int> _listNumbers = new List<int>();
        private readonly IList<IObserver<CollectionNumber>> _listeners = new List<IObserver<CollectionNumber>>();
        private string _changeList;

        public string ChangeList
        {
            get { return _changeList; }
        }

        public void Add(int num)
        {
            _listNumbers.Add(num);
            _changeList = String.Format($"Добавлено число {num}");
            Notify();
        }
        public void Delete(int num)
        {
            _listNumbers.Remove(num);
            _changeList = String.Format($"Удалено число {num}");
            Notify();
        }

        public IDisposable Subscribe(IObserver<CollectionNumber> observer)
        {
            _listeners.Add(observer);
            return new Unsubscriber(this, observer);
        }

        private void Notify()
        {
            ((List<int>)_listNumbers).Sort();
            foreach (var listener in _listeners)
            {
                listener.OnNext(this);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _listNumbers)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Unsubscriber : IDisposable
        {
            private readonly CollectionNumber _sensor;
            private readonly IObserver<CollectionNumber> _listener;

            public Unsubscriber(CollectionNumber sensor, IObserver<CollectionNumber> listener)
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
