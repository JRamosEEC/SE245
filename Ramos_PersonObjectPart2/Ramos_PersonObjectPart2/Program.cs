//Justin Ramos
//Lab #4
//4/23/2021
//SE245.13

//Description - Structures / Classes / Private / Public
//----------------------------------------------------#

//Import Necessary Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos_PersonObjectPart2
{
    class Program
    {
        public class Person
        {
            public string FName, LName, MName, AddressLine1, AddressLine2, City, State, ZipCode, Phone, Email;
        }
        static void Main(string[] args)
        {
            Person user = new Person();

            Console.WriteLine("Hello! Please enter a few details about yourself!");

            Console.Write("\nPlease enter your FIRST name: ");
            user.FName = Console.ReadLine();

            user.FName += "Poopy";

            Console.Write("\nPlease enter your MIDDLE name: ");
            user.MName = Console.ReadLine();

            Console.Write("\nPlease enter your LAST name: ");
            user.LName = Console.ReadLine();

            Console.Write("\nPlease enter your address line 1: ");
            user.AddressLine1 = Console.ReadLine();

            Console.Write("\nPlease enter your address line 2: ");
            user.AddressLine2 = Console.ReadLine();

            Console.Write("\nPlease enter your resident city: ");
            user.City = Console.ReadLine();

            Console.Write("\nPlease enter your resident state: ");
            user.State = Console.ReadLine();

            Console.Write("\nPlease enter your current zip code: ");
            user.ZipCode = Console.ReadLine();

            Console.Write("\nPlease enter your current phone number: ");
            user.Phone = Console.ReadLine();

            Console.Write("\nPlease enter your primary email: ");
            user.Email = Console.ReadLine();

            Console.Write("\n\nLet's see if this is all correct!");

            Console.WriteLine($"\nFirst Name: {user.FName}\nMiddle Name: {user.MName}\nLast Name: {user.LName}\nAddress 1: {user.AddressLine1}\nAddress 2: {user.AddressLine2}\nCity: {user.City}\nState: {user.State}\nZip Code: {user.ZipCode}\nPhone Number: {user.Phone}\nEmail: {user.Email}");
        }
    }
}