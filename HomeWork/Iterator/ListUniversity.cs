using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ListUniversity : IEnumerable<string>
    {
        private IList<University> _list = new List<University>();

        public void AddUniversity(University univer)
        {
            _list.Add(univer);
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item.Name;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
