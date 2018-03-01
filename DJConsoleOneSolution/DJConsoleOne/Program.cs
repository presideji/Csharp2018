using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJConsoleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world");
           // Console.ReadKey();

            //this a single line comments
            /*for multi lines
             * test
             * ggggg
             * 
             */

            string greetings = "Good evening Class";
            Console.WriteLine(greetings);
            Console.WriteLine(greetings);
            
            //the below is interpolation
            string firstname = "deji";
            string lastname = "ayo";
            string comment = "This is the man";
            Console.WriteLine("My name is " + firstname + " " + lastname );
            Console.WriteLine("My name is {0} {1}", firstname, lastname);
            Console.WriteLine();
            Console.WriteLine("My name is " + firstname + " " + lastname + "." + " " + comment);
            Console.WriteLine();


            Console.ReadKey();




        }
    }
}
