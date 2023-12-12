using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCodeTest
{
    public class GenericValueCollection<T> where T : struct
    {
        private List<T> items;

        public GenericValueCollection()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public List<T> GetSortedDescendingCollection()
        {
            List<T> sortedList = new List<T>(items);
            sortedList.Sort();
            sortedList.Reverse();
            return sortedList;
        }
    }
}
