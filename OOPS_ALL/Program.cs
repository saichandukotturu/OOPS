using System;

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Speed = 80;

        car1.Drive();
        Console.WriteLine("\n----- ENCAPSULATION -----");

        BankAccount account = new BankAccount();
        account.Deposit(500m);
        Console.WriteLine("Current Balance: " + account.GetBalance());
                // ----- INHERITANCE -----
        Console.WriteLine("\n----- INHERITANCE -----");
        Dog dog = new Dog();
        dog.Eat();   // From Animal
        dog.Bark();  // From Dog
                // ----- POLYMORPHISM -----
        Console.WriteLine("\n----- POLYMORPHISM -----");
        Shape shapeObj = new Circle();   // Parent reference → Child object
        shapeObj.Draw();                  // Calls Circle.Draw()

                // ----- ABSTRACTION -----
        Console.WriteLine("\n----- ABSTRACTION -----");
        Vehicle bike = new Bike();
        bike.Start();
    }
}