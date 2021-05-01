using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Week4_Class1;

namespace Week4_BookClassinWindows
{
    public class Person
    {
        //Initialize strings for user data, make them private for encapsulation and security
        private string fName, lName, mName, addressLine1, addressLine2, city, state, zipCode, phone, email;
        private bool validResponse = true;
        
        //Create get/set mustators for each of the variables
        public bool ValidResponse
        {
            get
            {
                return validResponse;
            }
        }

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
                if (ValidationLibrary.IsItFilledIn(value, 2))
                {
                    //Set the fName variable = to the sent value
                    fName = value;
                }

                //If the string is empty
                else
                {
                    //Set first name to an invalid input to notify the user
                    fName = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsItFilledIn(value, 2))
                {
                    lName = value;
                }

                else
                {
                    //Not everyone has a last name so set N/A
                    lName = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsItFilledIn(value, 2))
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
                if (ValidationLibrary.IsItFilledIn(value, 2))
                {
                    addressLine1 = value;
                }

                else
                {
                    addressLine1 = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsItFilledIn(value, 2))
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
                if (ValidationLibrary.IsItFilledIn(value, 2))
                {
                    city = value;
                }

                else
                {
                    city = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsItFilledIn(value, 2, 25)) //Longest state name is "The State of Rhode Island" which used to be longer until they dropped the end. Set max cap to 25 which is the length of that name.
                {
                    state = value;
                }

                else
                {
                    state = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsItFilledIn(value, 5, 10)) //zip code is either a 5 digit or a 5digit + hypen + 4digit which is 10 total characters
                {
                    zipCode = value;
                }

                else
                {
                    zipCode = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsItFilledIn(value, 10, 20)) // Most phone # formats are 10 digits with optional 3 hyphens the longest reccommended internationally is 15 digits with a few hyphens so if response is any larger than 20 it must be invalid
                {
                    phone = value;
                }

                else
                {
                    phone = "Invalid";
                    validResponse = false;
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
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }

                else
                {
                    email = "Invalid";
                    validResponse = false;
                }
            }
        }
    }
}
