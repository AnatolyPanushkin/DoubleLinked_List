using System;

namespace DoubleLinked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var minion = new Minion("Kevin", 32);
            var minion1 = new Minion("Struart", 52);
            var minion2 = new Minion("bob", 62);
            var list = new List<Minion>
            {
                minion,
                minion1,
                minion2
            };

            //list.Delete(3);
            // list.Edit(minion,minion2);
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}