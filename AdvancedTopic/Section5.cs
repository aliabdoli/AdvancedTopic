using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public class Section5
    {
    }

    public class GenericClient
    {
        public void Main()
        {
            var item = new Item(){Id = 1};

            //var numbers = new List();
            var items = new GenericIndexer<int>();
            items.Add(2);

            var items1 = new GenericIndexer<Item>();
            items1.Add(item);

            
        }


    }


    public class Nullable<T> where T : struct
    {
        private object _value;
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue => _value != null;

        public T GetValueOrDefault()
        {
            if (HasValue) return (T) _value;
            return default(T);
        }
    }
    //non generic class with generic method
    // new constraint and use it to new an object
    public class Utility<T> where T : IComparable, new()
    {
        //public T Max<T>(T a, T b) //where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething()
        {
            var obj = new T();
        }
    }
    
    public class Item
    {
        public int Id { get; set; }
    }

    public class GenericIndexer<T>
    {
        public void Add(T value)
        {
            
        }
        public T this[int index]
        {
            get {throw new NotImplementedException();}
        }
    }
}
