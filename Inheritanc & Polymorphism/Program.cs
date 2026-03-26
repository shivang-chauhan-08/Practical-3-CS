namespace Inheritance___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Inheritance
            Console.WriteLine("Inheritance Output : ");
            Team t1 = new Team("Dot Net");
            Console.WriteLine(t1.PrintInfo());
            Console.WriteLine();


            // 2) Polymorphism
            Console.WriteLine("Polymorphism Output : ");
            Bird myBird = new Bird();
            Bird myDuck = new Duck();
            myBird.Voice();
            myDuck.Voice();
            Console.WriteLine();


            // 3) Abstraction
            Console.WriteLine("Abstraction Output : ");
            Laptop mac = new Laptop();
            mac.Brand = "Apple";
            mac.Model = "MacBook Air M4";
            mac.LaptopDetails();
            // Not Allowed, To access this method we can call the method in the same class
            //mac.MotherBoardInfo();
        }
    }
}
