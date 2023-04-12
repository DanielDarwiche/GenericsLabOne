using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabOne
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> boxCollection;
        public BoxCollection()
        {
            boxCollection = new List<Box>();
        }
        public Box this[int index]
        {
            get { return (Box)boxCollection[index]; }
            set { boxCollection[index] = value; }
        }

        public int Count
        {
            get { return boxCollection.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Box item)
        {
            if (!boxCollection.Contains(item))
            {
                boxCollection.Add(item);
            }
            else
            {
                Console.WriteLine("The properties are not unique for box: '" + item + "' and can´t be added! ");
            }
        }
        public void Clear()
        {
            boxCollection.Clear();
        }

        public bool Contains(Box item)  //Ska kolla om  en låda finns i samlingen.
        {
            bool found = false;
            foreach (Box bo in boxCollection)
            {
                if (bo.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }
        //en överlagring av metoden Contains som tar
        //ett specificerat EqualityComparer<T>-objekt,
        public bool Contains(Box item, EqualityComparer<Box> comparer)
        {
            bool found = false;
            foreach (Box b in boxCollection)
            {
                if (comparer.Equals(b, item))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cant be negative");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elementen than the collection");
            }
            for (int i = 0; i < boxCollection.Count; i++)
            {
                array[i + arrayIndex] = boxCollection[i];
            }
        }
        public IEnumerator<Box> GetEnumerator()
        {
            return boxCollection.GetEnumerator();
            //return new BoxEnumerator(this);
        }
        public void Remove(Box item)
        {
            for (int i = 0; i < boxCollection.Count; i++)
            {
                if (boxCollection.Contains(item))
                {
                    boxCollection.RemoveAt(i);
                    Console.WriteLine(" -'{0}' was removed!", item.ToString());
                }
            }
        }
        bool ICollection<Box>.Remove(Box item)
        {
            return boxCollection.Remove(item);
        }
        public void Display()
        {
            foreach (var item in this)
            {
                Console.WriteLine(" -" + item);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            // return new BoxEnumerator(this);
        }
    }
}
