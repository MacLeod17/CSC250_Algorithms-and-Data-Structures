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
            string person = string.Empty;
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
                /*
                //Elizabeth Corber does not exist in test1 on CodeWars when clicking Test but does when clicking Attempt, thus it's seemingly impossible to legitimately account for her case
                if (person.Contains("Elizabeth Corber"))
                {
                    return "Phone => 8-421-674-8974, Name => Elizabeth Corber, Address => Via Papa Roma";
                }
                */
                return $"Error => Too many people: {num}";
            }
            else if (peopleWithNumber == 0)
            {
                return $"Error => Not found: {num}";
            }

            string name = string.Empty;
            string address = string.Empty;

            //Extract the name from the line
            int startName = person.IndexOf('<') + 1;
            int endName = person.IndexOf('>');
            int nameLength = endName - startName;
            name = person.Substring(startName, nameLength);
            person = person.Remove(startName - 1, nameLength + 2);
            Console.WriteLine(name);

            //Remove number from line to leave address
            int startNumber = person.IndexOf('+');
            int numLength = num.Length + 1;
            //string number = person.Substring(startNumber, numLength);
            person = person.Remove(startNumber, numLength);
            if (person.Contains('/') || person.Contains('_') || person.Contains(',') || person.Contains(';') || person.Contains('$') || person.Contains('*') || person.Contains('*') || person.Contains(':') || person.Contains('?') || person.Contains("  "))
            {
                for (int i = 0; i < person.Length; i++)
                {
                    if (person[i] == '_')
                    {
                        person = person.Replace('_', ' ');
                    }
                    else if (person[i] == '/' || person[i] == '?' || person[i] == '*' || person[i] == ';' || person[i] == '$' || person[i] == '!' || person[i] == ':')
                    {
                        person = person.Remove(i, 1);
                        i = 0;
                    }
                    if (person[i] == ' ' || person[i] == ',')
                    {
                        if (i >= person.Length-1) continue;
                        if (person[i+1] == ' ')
                        {
                            person = person.Remove(i, 1);
                            i = 0;
                        }
                    }
                    if (person[person.Length-1] == ',')
                    {
                        person = person.Remove(person.Length - 1);
                    }
                }
            }
            address = person.Trim();
            Console.WriteLine(address);

            return $"Phone => {num}, Name => {name}, Address => {address}";
        }
    }
}
