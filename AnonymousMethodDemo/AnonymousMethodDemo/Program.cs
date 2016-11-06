using System;

public delegate void PrintSStrUsingAnonymousMethod(int number);
namespace AnonymousMethodDemo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            PrintSStrUsingAnonymousMethod printString = delegate(int x)
           {
               Console.WriteLine("Anonymous method: {0}", x);
           };

            printString(2);

            Console.ReadKey();
        }
    }
}



