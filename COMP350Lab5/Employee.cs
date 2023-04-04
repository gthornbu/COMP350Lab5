using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP350Lab5
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string dob;
        private string homeAddr;
        private string payRate;
        private string hours;

        private string testString;

        //----------------------------
        //Constructors
        //----------------------------

        public Employee() 
        {
            firstName = "";
            lastName = "";
            dob = "";
            homeAddr = "";
            payRate = "";
            hours = "";
        }

        public Employee(string firstName, string lastName, string dob, string homeAddr, string payRate, string hours)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.homeAddr = homeAddr;
            this.payRate = payRate;
            this.hours = hours;
        }

        //----------------------------
        //Properties with encapsulation
        //----------------------------

        public string FirstName 
        { get 
            { return firstName; } 
            set 
            {
                if (FirstName == "")
                {
                    throw new Exception("The first name field cannot be empty");
                }
                foreach (char c in FirstName)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new Exception("The first name field must contain only letters");
                    }
                }
                firstName = value; 
            } 
        }
        public string LastName 
        { get 
            { return lastName; } 
            set 
            {
                if (LastName == "")
                {
                    throw new Exception("The last name field cannot be empty");
                }
                foreach (char c in LastName)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new Exception("The last name field must contain only letters");
                    }
                }
                lastName = value; 
            } 
        }
        public string Dob 
        { get 
            {  return dob; } 
            set 
            {
                if (Dob == "")
                {
                    throw new Exception("The first name field cannot be empty");
                }
                string[] strings = Dob.Split('/');
                if (strings.Length == 3)
                {
                    int intYear;
                    int intMonth;
                    int intDay;

                    if (!int.TryParse(strings[0], out intMonth))
                    {
                        throw new Exception("The month value must be an integer");
                    }
                    else
                    {
                        if (intMonth > 12 || intMonth < 1)
                        {
                            throw new Exception("The month's value must be a value between 1 and 12");
                        }
                    }
                    if (!int.TryParse(strings[1], out intDay))
                    {
                        throw new Exception("The day value must be an integer");
                    }
                    else
                    {
                        if (intDay > 31 || intDay < 1)
                        {
                            throw new Exception("The day value must be a value between 1 and 31");
                        }
                    }
                    if (!int.TryParse(strings[2], out intYear))
                    {
                        throw new Exception("The year value must be an integer");
                    }
                    else
                    {
                        if (intYear > 99 || intYear < 0)
                        {
                            throw new Exception("The year value must be an integer between 00 and 99");
                        }
                    }
                }
                else
                {
                    throw new Exception("the date of birth format must be mm/dd/yy");
                }
                dob = value; 
            } 
        }
        public string HomeAddr 
        { get 
            {  return homeAddr; } 
            set 
            {
                if (HomeAddr == "")
                {
                    throw new Exception("The home address field cannot be empty");
                }
                homeAddr = value; 
            } 
        }
        public string PayRate 
        { get 
            {  return payRate; } 
            set 
            {
                if (PayRate == "")
                {
                    throw new Exception("The pay rate field cannot be empty");
                }
                if (!float.TryParse(PayRate, out float floatPayRate))
                {
                    throw new Exception("The pay rate field must be an integer or a decimal number");
                }
                payRate = value; 
            } 
        }
        public string Hours 
        { get 
            { return hours; } 
            set 
            {
                if (Hours == "")
                {
                    throw new Exception("The hours worked field cannot be empty");
                }
                if (!float.TryParse(Hours, out float floatHours))
                {
                    throw new Exception("The hours worked field must be an integer or a decimal number");
                }
                hours = value; 
            } 
        }

        //----------------------------
        //Methods
        //----------------------------

        //method to write the object to the .csv file
        public void writeFile() 
        {
            string fileName = @"employees.csv";
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine(FirstName + "," + LastName + "," + Dob + "," + HomeAddr + "," + PayRate + "," + Hours);
            sw.Close();
            
        } 
    }
}
