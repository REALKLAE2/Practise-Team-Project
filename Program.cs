using System;

namespace Practise_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();


            //Stephanie
            //Lab 13 Activity 4
            int uppercase = 0;
            int lowercase = 0;
            int others = 0;

            Console.WriteLine("Enter a line of text: ");
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                {
                    uppercase++;
                }
                else if (char.IsLower(ch))
                {
                    lowercase++;
                }
                else
                {
                    others++;
                }
            }

            Console.WriteLine("/nResults");
            Console.WriteLine($"Uppercase letters: {uppercase}");
            Console.WriteLine($"Lowercase letters: {lowercase}");
            Console.WriteLine($"Other characters: {others}");
            Console.ReadLine();

            //Klae


            //Luke


            //Juan


            //Fletch








        }
    }
}
