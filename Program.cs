// Class: ERAU ISTA220 PROGRAMMING FUNDAMENTALS
// STUDENT: HAYDEN BARNES 
// INSTRUCTOR: CHRISTINE E LEE, INSTRUCTOR
// DATE: 08/05/2020

/******************************************************************
 * This project contains the code to demonstrate all things learned through
 * personal study and classroom instruction
 * 
 * Revisions:
 * 
 * Revisions Date:
 * 
 * Revised By:
 * 
 *****************************************************************/

using System;

namespace Week6WrapUp
{
    internal delegate void ReturnDetails();

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Car c = new Car();
            ReturnDetails d = null;

            // d will use the return detail to invoke the response
            // p is a refernce to the Person class which is now a object 
            // c is a refernce to the Car class which is now a object
            try
            {
                d += p.Getfname;
                d += p.Getlname;
                d += p.Getphoneno;

                d += c.GetMake;
                d += c.GetModel;
                d += c.GetColor;

                d += p.GetPersonDetails;
                d += c.GetCarDetails;
            }
            catch (FormatException fEx)// Will catch format exceptions
            {
                Console.WriteLine(fEx.Message);
            }
            finally
            {
                //Nothing happens here
            }


            d.Invoke(); // Invoke will write (Invoke) all result to console
            Console.ReadKey(); // keeps console open
        

        }
    }
}
