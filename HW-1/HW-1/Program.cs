using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //Console.WriteLine("Enter a letter");
            //string targetStr = Console.ReadLine();
            //if (targetStr.Length < 0)
            //{
            //    Console.WriteLine("Empty input");
            //}
            //else if (!targetStr.All(char.IsLetter))
            //{
            //    Console.WriteLine("Enter only letters");
            //}
            //else
            //{
            //    char alphabetChar = targetStr[0];
            //    int index = Array.IndexOf(alphabet, alphabetChar);
            //    Console.WriteLine("Index of the letter " + "'" + alphabetChar + "'" + " is " + (index + 1));
            //}

            // HW - 2

            //char[] reverseStr = "ira".ToCharArray();


            //for (int i = 0; i < reverseStr.Length / 2; i++)
            //{
            //    char temp = reverseStr[i];
            //    reverseStr[i] = reverseStr[reverseStr.Length - i - 1];
            //    reverseStr[reverseStr.Length - i - 1] = temp;
            //    Console.WriteLine("Reversed string is: " + new string(reverseStr));
            //}

            // HW - 2
            Console.Write("Enter the length of the random symbols: ");
            string length = Console.ReadLine();
            int strLength;
            if (length.Length > 0 && int.TryParse(length, out strLength)) {
                strLength = Convert.ToInt32(length);
                const string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!/?\"£$%^&*()<>,.@~#;:{}[]";
                Random random = new Random();
                string randomSymbols = "";

                for (int i = 0; i < strLength; i++)
                {
                    randomSymbols += symbols[random.Next(symbols.Length)];
                }

                Console.WriteLine("Random generated symbols: " + randomSymbols);
            } else
            {
                Console.WriteLine("You entered a non-numeric value");
            }
            

            Console.Read();
        }
    }
}


