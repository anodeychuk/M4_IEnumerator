using System;
using System.Collections;

namespace M4_IEnumerator
{
    public class ElementsArray<T> : IEnumerator, IEnumerable       
    {
        const int reservePlaceInArray = 10;
        int Counter { get; set; }
        int Count { get; set; }

        T[] array;

        public ElementsArray()
        {
            Counter = -1;
            Count = 0;
            array = new T[reservePlaceInArray];
        }
        
        public void Add(T value)
        {
            Counter++;
            Count++;
            if(Count > array.Length)
            {
                IncreaseArray();
            }

            array[Counter] = value;
        }

        private void IncreaseArray()
        {
            var newArray = new T[Count+reservePlaceInArray];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public object Current
        {
            get
            {
                if (Counter == -1) throw new IndexOutOfRangeException();
                else return array[Counter];
            }
        }

        public bool MoveNext()
        {
            Counter++;
            if (Counter < Count) return true;
            else
            {
                Counter--;
                return false;
            }
        }

        public void Reset()
        {
            Counter = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
