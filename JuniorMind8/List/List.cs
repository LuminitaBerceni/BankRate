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
            return (IndexOf(item) >= 0);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            CheckArray(array, arrayIndex);
            for (int i = 0; i < count; i++)
            {
                array[i + arrayIndex] = listItems[i];
            }
        }

        private void CheckArray(T[] array, int arrayIndex)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException("Array is null");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("ArrayIndex is less than 0");
            }
            if (array.Length - arrayIndex < count)
            {
                throw new ArgumentException(
                    "The number of elements in the source List<T> is greater than the available space from arrayIndex to the end of the destination array");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in listItems)
            {
                yield return item;
            }
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
            CheckIndex(index);
            if (index == count)
            {
                Add(item);
            }
            ShiftRight(index);
            listItems[index] = item;
        }

        private void ShiftRight(int index)
        {
            Array.Resize(ref listItems, listItems.Length + 1);
            for (int i = listItems.Length - 2; i >= index; i--)
            {
                listItems[i] = listItems[i + 1];
            }
            count++;
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public bool Remove(T item)
        {
            var indexOfItem = IndexOf(item);

            if (indexOfItem > -1)
            {
                RemoveAt(indexOfItem);
                return true;
            }
            return true;
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);
            ShiftLeft(index);
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < listItems.Length - 1; i++)
            {
                listItems[i] = listItems[i + 1];
            }
            count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
