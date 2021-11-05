using System.Reflection.Metadata;
using System.Runtime;

namespace DoubleLinked_List
{
    public class Item<T>
    {
        public T data { get; set; }
        public Item<T> previous { get; set; }
        public Item<T> next { get; set; }
        
        public Item(){}

        public Item(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}