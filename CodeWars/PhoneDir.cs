using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class PhoneDir
    {
        public static string Phone(string strng, string num)
        {
            //Split the string into an array of the lines
            string separator = "\n";
            string[] people = strng.Split(separator);

            //Grab the person with the given num
            string person;
            int peopleWithNumber = 0;
            foreach (string p in people)
            {
                if (p.Contains(num))
                {
                    person = p;
                    peopleWithNumber++;
                    if (peopleWithNumber > 1) break;
                }
            }

            //Return error if the number isn't found or if more than one person has the number
            if (peopleWithNumber > 1)
            {
                return $"Error => Too many people: {num}";
            }
            else if (peopleWithNumber == 0)
            {
                return $"Error => Not found: {num}";
            }

            string number = string.Empty;
            string name = string.Empty;
            string address = string.Empty;

            //Extract the number from the line

            //Extract the name form the line

            //Extract the address from the line

            return $"Phone => {number}, Name => {name}, Address => {address}";
        }
    }
}
