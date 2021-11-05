using System;

namespace DoubleLinked_List
{
    public class Minion
    {
        public string name { get; set; }

        public int age
        {
            get;
            set;
        }

        public Minion()
        {
            
        }
        public Minion(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
        
        
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}