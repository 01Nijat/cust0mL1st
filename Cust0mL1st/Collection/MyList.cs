using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cust0mL1st.Collection
{
    public class MyList<T>
    {
        private T[] arr;
        public int Count { get; set; }
        public MyList()
        {
            arr = new T[10];
        }
        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                add(item);
            }
        }
        public void add(T obj)
        {
            if (Count%10==0)
            {
                ArrayResize();
            }
            arr[Count] = obj;
            Count++;
        }
        private void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 10);
        }
        public void Clear()
        {
            arr= new T[10];
            Count= 0;
        }
        public T Find(Predicate<T> func)
        {
            foreach (var item in arr)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return default;
        }
        public bool Contains(T obj)
        {
            foreach (var item in arr)
            {
                if (Comparer<T>.Default.Compare(item, obj) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
