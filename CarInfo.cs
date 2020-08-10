using System;
namespace Week6WrapUp
{
    public class Car
    {
        // declaring the variables for each Method
        private string make = "";
        private string model = "";
        private string color = "";

        // internal will only be used within the class but can be accessed in the namespace
        internal void GetMake()
        {
            Console.WriteLine("Please enter your car make: ");
            make = Console.ReadLine();

        }
        internal void GetModel()
        {
            Console.WriteLine("Please enter your car model: ");
            model = Console.ReadLine();
        }
        internal void GetColor()
        {
            Console.WriteLine("Please enter your car color: ");
            color = Console.ReadLine();
        }
        internal void GetCarDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("Your car details");
            Console.WriteLine("Make: {0} ", make, model, color);
            Console.WriteLine("Model: {1} ", make, model, color);
            Console.WriteLine("Color: {2} ", make, model, color);

        }

    }
}
