using System;
namespace Week6WrapUp
{
    public class Person
    {
        // declaring the variables for each Method
        private string fname = "";
        private string lname = "";
        private string phoneno = "";

        // internal will only be used within the class but can be accessed in the namespace
        internal void Getfname()
        {
            Console.WriteLine("Please enter your firstname: ");
            fname = Console.ReadLine();
        }
        internal void Getlname()
        {
            Console.WriteLine("Please enter your lastname: ");
            lname = Console.ReadLine();
        }
        internal void Getphoneno()
        {
            Console.WriteLine("Please enter your phone number: ");
            phoneno = Console.ReadLine();
        }
        internal void GetPersonDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("Your personal details");
            Console.WriteLine("Firstname: {0} ", fname, lname, phoneno);
            Console.WriteLine("Lastname: {1} ", fname, lname, phoneno);
            Console.WriteLine("Phone number: {2} ", fname, lname, phoneno);


        }
    }
}
