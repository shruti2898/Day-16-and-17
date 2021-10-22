using System;
using System.Text.RegularExpressions;

namespace AlgorithmPrograms
{
    class P12_CustomizedMessage
    {
        public static string Regex_name = "^[A-Z][a-z]{2,}$";
        public static string Regex_MobileNumber = "^([0-9]{2}[ -]{1})?[6-9][0-9]{9}$";
        public static string Regex_Date = "^(0?[1-9]|[12][0-9]|3[01])[/.-]{1}(0?[1-9]|1[012])[/.-]{1}([1-2][0-9]{3})$";

        class Person
        {  
            //default values
            public string firstName = "abc";      
            public string lastName = "xyz";
            public string mobile = "91-XXXXXXXXXX";
            public string date = "01/01/2016";
            
        }
        public void printMessage()
        {
            
            Person user = new Person();
            Console.WriteLine("Please Enter User details:  ");
            Console.Write("First Name:  ");
            string fName = Console.ReadLine();
            Console.Write("Last Name:  ");
            string lName = Console.ReadLine();
            Console.Write("Mobile Number:  ");
            string mNo = Console.ReadLine();
            Console.Write("Date:  ");
            string dd = Console.ReadLine();
            
            string fullName = checkRegex(user, fName, lName, mNo, dd);
            Console.Clear();
            string str = "Hello " + user.firstName + ", \n\nWe have your full name as " + fullName + " in our system. Your contact number is " + user.mobile + ". \nPlease let us know in case of any clarification. \n\nThank you \n\n\nBridgeLabz \n" + user.date + ".";
            Console.WriteLine(str);
        }


        string checkRegex(Person user, string fName, string lName, string mNo, string dd )
        {
            string fullName = user.firstName + " " + user.lastName;     // default full name = abc xyz
            if (Regex.IsMatch(fName, Regex_name) && Regex.IsMatch(lName,Regex_name))
            {
                user.firstName = fName;
                user.lastName = lName;
                fullName = user.firstName + " " + user.lastName;
            }

            if (Regex.IsMatch(mNo, Regex_MobileNumber))
            {
                user.mobile = mNo;
            }

            if (Regex.IsMatch(dd, Regex_Date))
            {
                user.date = dd;
            }
            return fullName;
        }
    }
}
