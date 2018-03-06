using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DJCodingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF STATEMENT
            Console.WriteLine("Please enter your name");
            //string name = "Debaba";
            string enterUserName = Console.ReadLine();
           // int number = Convert.ToInt32(Console.ReadLine());

            //if (enterUserName.Equals("Debaba")
            //if (enterUserName.Equals("Debaba") || 
            //    enterUserName.Equals("Folake") || 
            //    enterUserName.Equals("Chinwe"))
            //{
            //    //Console.WriteLine("My name is Debaba");
            //    Console.WriteLine("My name {0}", enterUserName);
            //}
            ////else if (enterUserName.Equals("Folake"))
            ////{
            ////    Console.WriteLine("My name is Folake");

            ////}
            ////else if (enterUserName.Equals("Chinwe"))
            ////{
            ////    Console.WriteLine("My name is Chinwe");
            ////}
            //else
            //{
            //    Console.WriteLine("Your name is not recognise");

            //}

            //SWITCH STATEMENT
            switch (enterUserName)
            {
                case "Debaba":
                    Console.WriteLine("My name is Debaba");
                    break;
                case "folake":
                    Console.WriteLine("My name is Folake");
                    break;
                case "Chinwe":
                    Console.WriteLine("My name is Chinwe");
                    break;
                default:
                    Console.WriteLine("Your name is not recognise");
                    break;
                 }
            Console.ReadKey();


        }
    }
}
