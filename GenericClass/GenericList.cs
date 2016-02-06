namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class GenericList<T> : IEnumerable<T>, IComparable<T> where T: IComparable 
    {
        private T[] elements;
        private const int DEFAULTCAPACITY = 4;
        private int count;
        private int currentCapacity;

        //public static T Max<T>(T x, T y)
        //{
        //    return (Comparer<T>.Default.Compare(x, y) > 0) ? x : y;
        //}
        //public static T Min(T x, T y) 
        //{
        //    return (Comparer<T>.Default.Compare(x, y) < 0) ? x : y;
        //}
        public GenericList(int capacity = GenericList<T>.DEFAULTCAPACITY)
        {
            this.elements = new T[capacity];
            currentCapacity = capacity;
            this.count = 0;
        }
        public T this[int index]
        {
            get { return this.elements[index]; }
            set { this.elements[index] = value; }
        }
        public void AddElement(T element)
        {
            if (count + 1 >= currentCapacity)
            {
                Expand();
            }
            elements[count++] = element;
        }

        private void Expand()
        {
            currentCapacity *= 2;
            var newElement = new T[currentCapacity];
            
            for (int i = 0; i < count; i++)
            {
                newElement[i] = elements[i];
            }

            elements = newElement;
        }

        public T AccessByIndex(int index)
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new ArgumentOutOfRangeException("This is not a valid index");
            }
            var result = this.elements.ElementAt<T>(index);
            return result;
        }
        public void RemoveByIndex(int index)
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new ArgumentOutOfRangeException("This is not a valid index");
            }
            for (int i = index; i < count; i++)
            {
                elements[i] = elements[i + 1];     //we are shifting the values by 1 position
            }
            //elements[count--] = default(T);      //giving the last element it's default value
        }
        internal void InsertAtIndex(int index, T element)
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new ArgumentOutOfRangeException("This is not a valid index");
            }
            for (int i = count; i >= index ; i--)
            {
                if (i == index)
                {
                    elements[i] = element; 
                }
                else
                {
                    elements[i] = elements[i - 1];
                }
            }
        }
        public T Max()
        {
            var maxElement = elements[0];
            
            for (int i = 0; i < this.count; i++)
            {
                if (maxElement.CompareTo(elements[i]) < 0)
                {
                    maxElement = elements[i]; 
                }
            }
            return maxElement;
        }
        public T Min()
        {
            var minElement = elements[0];

            for (int i = 0; i < this.count; i++)
            {
                if (minElement.CompareTo(elements[i]) > 0)
                {
                     minElement = elements[i];
                }
                
            }
            return minElement;
        }
        public void ClearList()
        {
            this.elements = new T[DEFAULTCAPACITY];
        }
        public bool FindByValue(T element)
        {
            if(elements.Contains(element))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.AppendFormat("{0} ", elements[i]); 
            }
            return builder.ToString();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in this.elements)
            {
                yield return t;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        int IComparable<T>.CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
