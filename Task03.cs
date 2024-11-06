namespace NcCsTypes
{
    internal class Task03
    {
        public static void Run()
        {
            //Fruit myFruit1 = new Fruit("Apple");
            //Fruit myFruit2 = new Fruit("Orange");
            //Fruit myFruit1Copy = myFruit1;
            //myFruit1.Hello();

            //Console.WriteLine(myFruit1.GetType());
            //Console.WriteLine(Object.ReferenceEquals(myFruit1, myFruit2));
            //Console.WriteLine(Object.ReferenceEquals(myFruit1, myFruit1Copy));
            //Console.WriteLine(myFruit2.ToString());

            //banana.Hello();
            //Console.WriteLine(banana.ToString());

            Fruit fruitBanana = new Fruit("banana");
            Banana banana = new Banana();
            Console.WriteLine("Equals override test: " + banana.Equals(fruitBanana));
        }
    }

    class Fruit
    {
        public string Name { get; set; }

        public Fruit(string name)
        {
            Name = name;
        }

        public virtual void Hello()
        {
            Console.WriteLine($"The fruit {Name} says hello!");
        }

    }

    class Banana : Fruit
    {
        public Banana(string name = "banana") : base(name)
        {
            Name = name;
        }

        public override void Hello()
        {
            Console.WriteLine("This is a hijack, from the banana class!");
        }

        public override string ToString()
        {
            return "lol banana";
        }

        public override bool Equals(object? obj)
        {
            Fruit fruitObject = obj as Fruit;
            return fruitObject.Name == this.Name;
        }
    }
}
