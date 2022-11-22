using System;

namespace GenericsPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics Means General form of, means does't specify any data type.

            DataStore<String> store = new DataStore<string>();
            store.Data = "Hello World";
            Console.WriteLine(store.Data);
        }
    }

    class DataStore<T>
    {
        public T Data { get; set; }
    }

    class DataStoreArray<T>
    {
        public T[] data = new T[10];
    }

    class KeyValuePair<TKey,TValue>
    {
        public TValue Value { get; set; }
        public TKey Key { get; set; }
    }
}
