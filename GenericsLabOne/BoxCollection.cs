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
        //Constructor
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
        //Add-method which checks if added boxes are unique in the collection before adding 
        public void Add(Box item)
        {
            if (!boxCollection.Contains(item))
            {
                boxCollection.Add(item);
            }
            else
            {
                Console.WriteLine("The properties are not unique for box '" + item.name + "' and can´t be added! ");
            }
        }
        public void Clear()
        {
            boxCollection.Clear();
        }
        //Checking if a box exists in the collection
        public bool Contains(Box item)
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
        //overloading Contains, takeing a specified EqualityComparer<T>-object
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
        }
        // Remove method to remove chosen box
        public void Remove(Box item)
        {
            for (int i = 0; i < boxCollection.Count; i++)
            {
                if (boxCollection[i].Equals(item))
                {
                    boxCollection.RemoveAt(i);
                    Console.WriteLine(" -'{0}' was removed!", item.name);
                }
                else { }
            }
        }
        bool ICollection<Box>.Remove(Box item)
        {
            return boxCollection.Remove(item);
        }
        //Display method to write out all items in the BoxCollection
        public void Display()
        {
            foreach (var item in this)
            {
                Console.WriteLine(" -" + item.name);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
