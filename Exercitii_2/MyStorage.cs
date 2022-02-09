using System;

namespace Exercitii_2
{
    public class MyStorage
    {
        public object?[] storage;
        public int Limit = 20;

        public MyStorage(int limit)
        {
            Limit = limit;
            storage = new object?[limit];
        }

        public MyStorage()
        {
            storage = new object?[Limit];
        }

        public void Add(int index, object? o)
        {
            storage[index] = o;
        }

        public object? GetData(int index)
        {
            return storage[index];
        }

        public void Remove(int index)
        {
            storage[index] = null;
        }

        public int Find(object o)
        {
            for (var index = 0; index < storage.Length; index++)
            {
                var obj = storage[index];
                if (obj != null && obj.Equals(o))
                {
                    return index;
                }
            }

            return 0;
        }

        public void Swap(int i, int j)
        {
            (storage[j], storage[i]) = (storage[i], storage[j]);
        }

        public void ToString()
        {
            foreach (var o in storage)
            {
                Console.WriteLine(o == null
                    ? " Empty "
                    : "type: " + o.GetType().Name + ",\t obiectul: " + o.ToString());
            }
        }
    }
}