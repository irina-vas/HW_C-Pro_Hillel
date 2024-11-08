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
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's', 't', 'y', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Enter a letter");
            string targetStr = Console.ReadLine();
            if (targetStr.Length < 0)
            {
                Console.WriteLine("Empty input");
            } else if (!targetStr.All(char.IsLetter))
            {
                Console.WriteLine("Enter only letters");
            } else
            {
                char alphabetChar = targetStr[0];
                int index = Array.IndexOf(alphabet, alphabetChar);
                Console.WriteLine("Index of the letter " + "'" + alphabetChar + "'" + " is " + (index + 1));
                Console.Read();
            }
        }
    }
}

