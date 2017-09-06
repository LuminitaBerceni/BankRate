using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T> : IList<T>
    {
        private T[] listItems = new T[5];
        private int count;

        public T this[int index]
        {
            get
            {
                return listItems[index];
            }

            set
            {
                listItems[index] = value;
            }
        }

        public int Count
        {
            get
            {
                if (count == 0)
                {
                    throw new ArgumentNullException("Source is null");
                }
                if (count > Int32.MaxValue)
                {
                    throw new OverflowException("The number of elements in source is larger than MaxValue.");
                }
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            VerifySpace();
            listItems[count] = item;
            count++;
        }

        private void VerifySpace()
        {
            if (count > listItems.Length)
            {
                Array.Resize(ref listItems, listItems.Length * 2);
            }
        }

        public void Clear()
        {
            listItems = null;
            count = 0;
        }

        public bool Contains(T item)
        {
            return (IndexOf(item) == -1) ? false : true;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
                if (listItems[i].Equals(item))
                    return i;
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
