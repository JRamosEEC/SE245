//Justin Ramos
//Lab #1
//4/7/2021
//SE245.13

//Description - Grade Book calculator that takes four student grades and averages them and diplays a letter grade 
//----------------------------------------------------#

//Import Necessary Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create Name Space for the project
namespace Ramos_Lab1_GradeBook
{
    //Create a class for the program in this case I left it called program and named the parent named as the project
    class Class1
    {
        static void Main(string[] args)
        {
            //Initialize variables
            String strFirst, strLetterGrade, strGrade1, strGrade2, strGrade3, strGrade4;
            //Ints from the user input later converted from string and the resulting answer from the math equation
            Int32 intGrade1 = 0, intGrade2 = 0, intGrade3 = 0, intGrade4 = 0, intAvgGrade = 0;
            //Double for the result which would be a float value, however it is equated to the intResult and stays a whole number
            Double dblResult = 0;

            //Output to the user a greeting
            Console.WriteLine("Hello There!");

            //Prompt the user for input and then read the input line
            Console.Write("Please enter your first name: ");
            //This reads the input line and stores the value in strFirst
            strFirst = Console.ReadLine();

            //Take the user input and display it to them
            Console.WriteLine("Hello " + strFirst + "! Let's calculate your grades!");

            //Get the first number from the user
            Console.Write("Please enter the first grade: ");
            strGrade1 = Console.ReadLine();

            Console.Write("Please enter the first grade: ");
            strGrade2 = Console.ReadLine();

            Console.Write("Please enter the first grade: ");
            strGrade3 = Console.ReadLine();

            Console.Write("Please enter the first grade: ");
            strGrade4 = Console.ReadLine();

            if (Int32.TryParse(strGrade1, out intGrade1))
            {
                Console.WriteLine(intGrade1);
            }

            else
            {
                Console.WriteLine("Was not successful");
            }

            //Prompt the user to press a key then read line for a key press to keep the window open until the user decides to exit
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
