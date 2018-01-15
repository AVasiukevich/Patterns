using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class MyRandomPool
    {
        private readonly int _maxSize;
        private readonly int _minSize;
        private readonly IList<MyRandom> _list;

        public MyRandomPool(int maxSize, int minSize)
        {
            _maxSize = maxSize;
            _minSize = minSize;
            _list = new List<MyRandom>();
            Console.WriteLine("Create min size pool!");
            for (int i = 0; i < _minSize; i++)
            {
                _list.Add(new MyRandom());
            }
        }
        public MyRandom GetFactorial()
        {
            var fact = _list.FirstOrDefault(c => !c.IsCreate) ?? CreateFactorial();

            if(fact != null)
                fact.IsCreate = true;

            return fact;
        }

        public void ReleaseConnection(MyRandom num)
        {
            if(_list.Count > _minSize)
                _list.Remove(num);
            else
                Console.WriteLine("Pool min!");
        }
        private MyRandom CreateFactorial()
        {
            if (_list.Count < _maxSize)
            {
                Console.WriteLine("Create new factorial!");
                var num = new MyRandom();
                _list.Add(num);
                return num;
            }
            else
                Console.WriteLine("Pool max!");
            return null;
        }
    }
}
