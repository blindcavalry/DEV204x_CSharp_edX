using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //----Student Information----
            string studFirstName;
            string studLastName;
            DateTime studBirthDate;
            string studAddressLine1;
            string studAddressLine2;
            string studCity;
            string studStateProvince;
            string studZipCode;
            string studCountry;

            studFirstName = "Anna";
            studLastName = "ZoomZoom";
            studBirthDate = new DateTime(1993, 6, 1);
            studAddressLine1 = "Uh Yea";
            studAddressLine2 = "Dat Way";
            studCity = "Float on the track";
            studStateProvince = "Like a Segway";
            studZipCode = "Uh Yea Dat Way";
            studCountry = "I used to trap by the Subway";

            Console.WriteLine("Student Name: " + studFirstName + " " + studLastName);
            Console.WriteLine("Birthdate: " + studBirthDate);
            Console.WriteLine("Address: " + studAddressLine1 + " " + studAddressLine2 + ", " + studCity + " " + studStateProvince + ", " + studZipCode + ", " + studCountry);
            Console.WriteLine();


            //----Professor Information----
            string profFirstName;
            string profLastName;
            DateTime profBirthDate;
            int profAddressLine1p1;
            string profAddressLine1p2;
            string profAddressLine1;
            string profCity;
            string profState;
            int profZipCode;
            string profCountry;

            profFirstName = "Sonic";
            profLastName = "the Hedgehog";
            profBirthDate = new DateTime(1420, 6, 9);
            profAddressLine1p1 = 299792458;
            profAddressLine1p2 = "Chao Garden Dr.";
            profAddressLine1 = profAddressLine1p1 + " " + profAddressLine1p2;
            profCity = "Hardly";
            profState = "Nebraska";
            profZipCode = 80085;
            profCountry = "USA";

            Console.WriteLine("Professor Name: " + profFirstName + " " + profLastName);
            Console.WriteLine("Birthdate: " + profBirthDate);
            Console.WriteLine("Address: " + profAddressLine1 + ", " + profCity + ", " + profState + " " + profZipCode + ", " + profCountry);
            Console.WriteLine();


            //----Program Information----
            string programName;
            string deptHead;
            string degrees;

            programName = "Following your Rainbow";
            deptHead = "Professor Eggman";
            degrees = "Master of Stealing the Chaos Emeralds";

            Console.WriteLine("Program Name: " + programName);
            Console.WriteLine("Department Head: " + deptHead);
            Console.WriteLine("Degree: " + degrees);
            Console.WriteLine();


            //----Degree Information----
            string degreeName;
            int creditsRequired;

            degreeName = "Bachelors in Going Fastest";
            creditsRequired = 69;

            Console.WriteLine("Degree: " + degreeName);
            Console.WriteLine("Credits Required: " + creditsRequired);
            Console.WriteLine();


            //----Course Information----
            string courseName;
            int credits;
            long durationWeeks;
            string profName;

            courseName = "Running up that Hill";
            credits = 0;
            durationWeeks = 1000000000000000000;
            profName = profFirstName + " " + profLastName;

            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Credist: " + credits);
            Console.WriteLine("Duration: " + durationWeeks + " weeks");
            Console.WriteLine("Professor Name: " + profName);
            Console.WriteLine();


            //----Challenge----

            string userName;
            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("User name: " + userName);
            Console.WriteLine();

            string userDoB;
            Console.WriteLine("Please enter your date of birth: ");
            userDoB = Console.ReadLine();
            Console.WriteLine("User date of birth: " + userDoB);
            Console.WriteLine();

            string userAddress;
            Console.WriteLine("Please enter your address: ");
            userAddress = Console.ReadLine();
            Console.WriteLine("User Address: " + userAddress);
            Console.WriteLine();


        }
    }
}
