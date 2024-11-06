using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcCsTypes
{
    internal class Task03
    {
        public static void Run()
        {
            Fruit myFruit1 = new Fruit("Apple");
            Fruit myFruit2 = new Fruit("Orange");
            Fruit myFruit1Copy = myFruit1;
            myFruit1.Hello();

            Console.WriteLine(myFruit1.GetType());
            Console.WriteLine(Object.ReferenceEquals(myFruit1, myFruit2));
            Console.WriteLine(Object.ReferenceEquals(myFruit1, myFruit1Copy));
            Console.WriteLine(myFruit2.ToString());
        }
    }

    class Fruit
    {
        public string Name { get; set; }

        public Fruit(string name)
        {
            Name = name;
        }

        public void Hello()
        {
            Console.WriteLine($"The fruit {Name} says hello!");
        }

    }
}
