using System.Collections;
using System.Collections.Generic;

namespace DoubleLinked_List
{
    public class List<T>:IEnumerable<T>
    {
        public Item<T> head { get; set; }
        public Item<T> tail { get; set; }
        public int size { get; set; }

        public List(){}

        public List(T data)
        {
            var item =new Item<T>(data);
            head = item;
            tail = item;
            size = 1;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);

            if (size == 0)
            {
                head = item;
                tail = item;
                size = 1;
            }
            else
            {
                tail.next = item;
                item.previous = tail;
            }

            tail = item;
            size++;
        }

        public void Delete(T data)
        {
            var item = head;
             while (item!=null)
             {
                 if (item.data.Equals(data))
                 {
                     item.previous.next = item.next;
                     item.next.previous = item.previous;
                     size--;
                     return;
                 }

                 item = item.next;
             }
        }
        
        /// <summary>
        /// Editing of element from list
        /// </summary>
        /// <param name="element">element which you want to edit</param>
        /// <param name="data">value which you want to insert</param>
        public void Edit(T element,T data)
        {
            var item = head;
            while (item!=null)
            {
                if (item.data.Equals(element))
                {
                    item.data = data;
                    return;
                }

                item = item.next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>) GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            var item = head;
            while (item!=null)
            {
                yield return item;
                item = item.next;
            }
        }

        
    }
}