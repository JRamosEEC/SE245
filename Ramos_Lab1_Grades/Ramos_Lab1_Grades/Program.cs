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
namespace Ramos_Lab1_Grades
{
    //Create a class for the program in this case I left it called program and named the parent named as the project
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            String strFirst, strGrade1, strGrade2, strGrade3, strGrade4, strGrade5, strTotalStudents;
            //Ints from the user input later converted from string and the resulting answer from the math equation
            Int32 intGrade1 = 0, intGrade2 = 0, intGrade3 = 0, intGrade4 = 0, intGrade5 = 0, intTotal = 0, intlabTotals1 = 0, intlabTotals2 = 0, intlabTotals3 = 0, intlabTotals4 = 0, intlabTotals5 = 0, intTotalStudents = 0 ;
            //Double for the result which will be a float value
            Double dblResult = 0;

            String[] nameList = new String[999];

            String[] letterGradeList = new String[999];

            Double[] avgGradeList = new Double[999];

            Double[] labAvgGrade = new double[5];

            Int32[] gradeList1 = new Int32[999];
            Int32[] gradeList2 = new Int32[999];
            Int32[] gradeList3 = new Int32[999];
            Int32[] gradeList4 = new Int32[999];
            Int32[] gradeList5 = new Int32[999];

            //Output to the user a greeting
            Console.WriteLine("Hello There!");

            //Initialize a loop that runs as long as the users answer isn't valid
            do
            {
                //Get the first number from the user
                Console.Write("How many student's grades are you entering? : ");
                strTotalStudents = Console.ReadLine();

                //Check if it's a valid response if it isn't loop and try again
                if (!(Int32.TryParse(strTotalStudents, out intTotalStudents)) || intTotalStudents < 0 || intTotalStudents >= 999)
                {
                    Console.WriteLine("Sorry, that was not a valid response! Please try again...\n");
                }

            } while (!(Int32.TryParse(strTotalStudents, out intTotalStudents)) || intTotalStudents < 0 || intTotalStudents >= 999);

            for (int i = 0; i < intTotalStudents; i++)
            {
                //Prompt the user for input and then read the input line
                Console.Write("\nPlease enter the student's first name: ");
                //This reads the input line and stores the value in strFirst
                strFirst = Console.ReadLine();
                nameList[i] = strFirst;

                //loop until the user inputs a proper response
                do
                {
                    //Get the first number from the user
                    Console.Write("Please enter the first grade: ");
                    strGrade1 = Console.ReadLine();

                    if (!(Int32.TryParse(strGrade1, out intGrade1)) || intGrade1 < 0)
                    {
                        Console.WriteLine("Sorry, that was not a valid response! Please try again...\n");
                    }

                    else
                    {
                        //Store values to the lists
                        gradeList1[i] = intGrade1;
                    }

                } while (!(Int32.TryParse(strGrade1, out intGrade1)) || intGrade1 < 0);

                do
                {
                    //Get the first number from the user
                    Console.Write("Please enter the second grade: ");
                    strGrade2 = Console.ReadLine();

                    if (!(Int32.TryParse(strGrade2, out intGrade2)) || intGrade2 < 0)
                    {
                        Console.WriteLine("Sorry, that was not a valid response! Please try again...\n");
                    }

                    else
                    {
                        gradeList2[i] = intGrade2;
                    }

                } while (!(Int32.TryParse(strGrade2, out intGrade2)) || intGrade2 < 0);

                do
                {
                    //Get the first number from the user
                    Console.Write("Please enter the third grade: ");
                    strGrade3 = Console.ReadLine();

                    if (!(Int32.TryParse(strGrade3, out intGrade3)) || intGrade3 < 0)
                    {
                        Console.WriteLine("Sorry, that was not a valid response! Please try again...\n");
                    }

                    else
                    {
                        gradeList3[i] = intGrade3;
                    }

                } while (!(Int32.TryParse(strGrade3, out intGrade3)) || intGrade3 < 0);

                do
                {
                    //Get the first number from the user
                    Console.Write("Please enter the fourth grade: ");
                    strGrade4 = Console.ReadLine();

                    if (!(Int32.TryParse(strGrade4, out intGrade4)) || intGrade4 < 0)
                    {
                        Console.WriteLine("Sorry, that was not a valid response! Please try again...\n");
                    }

                    else
                    {
                        gradeList4[i] = intGrade4;
                    }

                } while (!(Int32.TryParse(strGrade4, out intGrade4)) || intGrade4 < 0);

                do
                {
                    //Get the first number from the user
                    Console.Write("Please enter the fifth grade: ");
                    strGrade5 = Console.ReadLine();

                    if (!(Int32.TryParse(strGrade5, out intGrade5)) || intGrade5 < 0)
                    {
                        Console.WriteLine("Sorry, that was not a valid response! Please try again...\n");
                    }

                    else
                    {
                        gradeList5[i] = intGrade5;
                    }

                } while (!(Int32.TryParse(strGrade5, out intGrade5)) || intGrade5 < 0);


                //Calculate the total average grade by adding them all together then dividing by the 5 total labs
                intTotal = intGrade1 + intGrade2 + intGrade3 + intGrade4 + intGrade5;

                dblResult = (double)intTotal / 5;

                //Add the result to the list of avg grades
                avgGradeList[i] = dblResult;

                //Determine which letter grade the student falls under and add it to the array
                if(dblResult < 999 && dblResult >= 98)
                {
                    letterGradeList[i] = "A+";
                }

                else if (dblResult < 98 && dblResult >= 93)
                {
                    letterGradeList[i] = "A";
                }

                else if (dblResult < 93 && dblResult >= 90)
                {
                    letterGradeList[i] = "A-";
                }

                else if (dblResult < 90 && dblResult >= 87)
                {
                    letterGradeList[i] = "B+";
                }

                else if (dblResult < 87 && dblResult >= 83)
                {
                    letterGradeList[i] = "B";
                }

                else if (dblResult < 83 && dblResult >= 80)
                {
                    letterGradeList[i] = "B-";
                }

                else if (dblResult < 80 && dblResult >= 77)
                {
                    letterGradeList[i] = "C+";
                }

                else if (dblResult < 77 && dblResult >= 73)
                {
                    letterGradeList[i] = "C";
                }

                else if (dblResult < 73 && dblResult >= 70)
                {
                    letterGradeList[i] = "C-";
                }

                else if (dblResult < 70 && dblResult >= 67)
                {
                    letterGradeList[i] = "D+";
                }

                else if (dblResult < 67 && dblResult >= 60)
                {
                    letterGradeList[i] = "D";
                }

                else if (dblResult < 60)
                {
                    letterGradeList[i] = "F";
                }

                else
                {
                    Console.WriteLine("\nWow you have some astronomically high grades huh!? Nah stop cheating :( . Now you get an F!");
                    letterGradeList[i] = "F";
                }


                if (intTotalStudents - (i + 1) > 0)
                {
                    //Tell the user how many students are left
                    Console.WriteLine($"\nStudents Remaining To Grade : {intTotalStudents - (i + 1)}");
                }

            }


            //Print out the final results of all the students
            Console.WriteLine("\n\n ------------------------\n\nFinal Results:\n");
            
            //Begin a for loop that cycles through every student
            for (int i = 0; i < intTotalStudents; i++)
            {
                //Print the given students name / average grade / and letter grade
                Console.WriteLine($"{nameList[i]} || Average Grade: {avgGradeList[i]} || Letter Grade: {letterGradeList[i]}");

                //For each lab add up all the scores (This will be used to calculate the average)
                intlabTotals1 += gradeList1[i];
                intlabTotals2 += gradeList2[i];
                intlabTotals3 += gradeList3[i];
                intlabTotals4 += gradeList4[i];
                intlabTotals5 += gradeList5[i];
            }

            //Then divide the lab grades totaled by the total number of students that took the lab to find it's average
            labAvgGrade[0] = (Double)intlabTotals1 / (Double)intTotalStudents;
            labAvgGrade[1] = (Double)intlabTotals2 / (Double)intTotalStudents;
            labAvgGrade[2] = (Double)intlabTotals3 / (Double)intTotalStudents;
            labAvgGrade[3] = (Double)intlabTotals4 / (Double)intTotalStudents;
            labAvgGrade[4] = (Double)intlabTotals5 / (Double)intTotalStudents;

            //Just a line break
            Console.WriteLine("");

            //print out the averages
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nLab {i+1} Average Grade of All Student : {labAvgGrade[i]}");
            }

            //Prompt the user to press a key then read line for a key press to keep the window open until the user decides to exit
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
