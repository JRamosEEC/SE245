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

namespace Ramos_PersonObjectPart3
{
    class Program
    {

        //Create and object reference to a person with personal variables including name and address
        public class Person
        {
            //Initialize strings for user data, make them private for encapsulation and security
            private string fName, lName, mName, addressLine1, addressLine2, city, state, zipCode, phone, email;

            //Create get/set mustators for each of the variables
            public string FName
            {
                //called when FName is called in the program
                get
                {
                    //Output the fName variable value
                    return fName;
                }

                //called when FName is set to = (a value) in the program
                set
                {
                    //Check if string is empty
                    if (value.Length > 0)
                    {
                        //Set the fName variable = to the sent value
                        fName = value;
                    }

                    //If the string is empty
                    else
                    {
                        //Set first name to an invalid input to notify the user
                        fName = "Invalid Input";
                    }
                }
            }

            public string LName
            {
                get
                {
                    return lName;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        lName = value;
                    }

                    else
                    {
                        //Not everyone has a last name so set N/A
                        lName = "N/A";
                    }
                }
            }

            public string MName
            {
                get
                {
                    return mName;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        mName = value;
                    }

                    else
                    {
                        //Not everyone has a middle name so set N/A
                        mName = "N/A";
                    }
                }
            }

            public string AddressLine1
            {
                get
                {
                    return addressLine1;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        addressLine1 = value;
                    }

                    else
                    {
                        addressLine1 = "Invalid Address";
                    }
                }
            }

            public string AddressLine2
            {
                get
                {
                    return addressLine2;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        addressLine2 = value;
                    }

                    else
                    {
                        //Not everyone has a line 2 address so set N/A
                        addressLine2 = "N/A";
                    }
                }
            }

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        city = value;
                    }

                    else
                    {
                        city = "Invalid City";
                    }
                }
            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        state = value;
                    }

                    else
                    {
                        state = "Invalid State";
                    }
                }
            }

            public string ZipCode
            {
                get
                {
                    return zipCode;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        zipCode = value;
                    }

                    else
                    {
                        zipCode = "Invalid Zip Code";
                    }
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        phone = value;
                    }

                    else
                    {
                        phone = "Invalid Phone Number";
                    }
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    if (value.Length > 0)
                    {
                        email = value;
                    }

                    else
                    {
                        email = "Invalid Email";
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Person[] user = new Person[99];
            string temp;
            string userResponse = "Y";
            int userListResponse = 1;
            int ctr = 0;

            do
            {
                user[ctr] = new Person();

                Console.WriteLine("Hello! Please enter a few details about the person!");

                Console.Write("\nPlease enter your FIRST name: ");
                user[ctr].FName = Console.ReadLine();

                Console.Write("\nPlease enter your MIDDLE name: ");
                user[ctr].MName = Console.ReadLine();

                Console.Write("\nPlease enter your LAST name: ");
                user[ctr].LName = Console.ReadLine();

                Console.Write("\nPlease enter your address line 1: ");
                user[ctr].AddressLine1 = Console.ReadLine();

                Console.Write("\nPlease enter your address line 2: ");
                user[ctr].AddressLine2 = Console.ReadLine();

                Console.Write("\nPlease enter your resident city: ");
                user[ctr].City = Console.ReadLine();

                Console.Write("\nPlease enter your resident state: ");
                user[ctr].State = Console.ReadLine();

                Console.Write("\nPlease enter your current zip code: ");
                user[ctr].ZipCode = Console.ReadLine();

                Console.Write("\nPlease enter your current phone number: ");
                user[ctr].Phone = Console.ReadLine();

                Console.Write("\nPlease enter your primary email: ");
                user[ctr].Email = Console.ReadLine();

                Console.Write("\n\nLet's see if this is all correct!");

                Console.WriteLine($"\nFirst Name: {user[ctr].FName}\nMiddle Name: {user[ctr].MName}\nLast Name: {user[ctr].LName}\nAddress 1: {user[ctr].AddressLine1}\nAddress 2: {user[ctr].AddressLine2}\nCity: {user[ctr].City}\nState: {user[ctr].State}\nZip Code: {user[ctr].ZipCode}\nPhone Number: {user[ctr].Phone}\nEmail: {user[ctr].Email}");

                Console.Write("\n\nWould you like to add another person? Y/N : ");
                userResponse = Console.ReadLine();

                ctr++;

            } while (userResponse == "y" || userResponse == "Y");

            do
            {
                do
                {
                    //Get the first number from the user
                    Console.Write("\n\nWould you like to call on one of the people you input? Enter list position number... Eg. The first person entered is in position 1 : ");
                    temp = Console.ReadLine();

                    if (!(Int32.TryParse(temp, out userListResponse)) || userListResponse <= 0 || userListResponse > (ctr))
                    {
                        Console.WriteLine("\nSorry, that was not a valid response! Please try again...\n");
                    }

                } while (!(Int32.TryParse(temp, out userListResponse)) || userListResponse <= 0 || userListResponse > (ctr));

                userListResponse--;

                Console.WriteLine($"\nFirst Name: {user[userListResponse].FName}\nMiddle Name: {user[userListResponse].MName}\nLast Name: {user[userListResponse].LName}\nAddress 1: {user[userListResponse].AddressLine1}\nAddress 2: {user[userListResponse].AddressLine2}\nCity: {user[userListResponse].City}\nState: {user[userListResponse].State}\nZip Code: {user[userListResponse].ZipCode}\nPhone Number: {user[userListResponse].Phone}\nEmail: {user[userListResponse].Email}");

                Console.Write("\n\nWould you like to check another input? Y/N : ");
                userResponse = Console.ReadLine();

            } while (userResponse == "y" || userResponse == "Y");
        }
    }
}