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
            string phrase = "the quick brown fox jumps over the lazy dog";
            string temp, newphrase;
            Console.WriteLine("Enter THE PHRASE");
            temp = Console.ReadLine();
            newphrase = temp.TrimEnd();
            string hairy = " hairy";
            string finalphrase = newphrase.Replace("dog", "chicken");
            Console.WriteLine(finalphrase);
            Console.WriteLine(newphrase.Insert(10, hairy));
            Console.ReadLine();

            finalphrase = finalphrase.ToUpper();
            Console.WriteLine(finalphrase);
            finalphrase = finalphrase.ToLower();
            Console.WriteLine(finalphrase);

            //Luke


            //Juan
            int[] counts = new int[7];
            Random rng = new Random();

            for (int rollNumber = 0; rollNumber < 6000; rollNumber++)
            {
                int result = rng.Next(1, 7);
                counts[result]++;
            }
            Console.WriteLine("||=======================================||");
            Console.WriteLine("||    Face    ||     Count    ||    %    ||");
            Console.WriteLine("||=======================================||");

            for (int face = 1; face <= 6; face++)
            {
                double percentage = (counts[face] / 6000.0) * 100;
                Console.WriteLine($"||     {face}     ||   {counts[face],4}   ||    {percentage,6:F2}%   ||");
            }
            Console.WriteLine("||=======================================||");

            Console.ReadLine();
            //
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('*', 120));
            Console.WriteLine(new string('*', 5));
            Console.WriteLine("Juan Marcus Sumaya");
            Console.WriteLine("Dunedin");
            Console.WriteLine("My favourite BIT subject is : Programming");
            Console.WriteLine(new string('*', 120));
            Console.WriteLine(2.3456 + 1);
            Console.Write("what goes \nup \nmust come \tdown \n");

            //

            //Fletch
            int[] listOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in listOfNumbers)
            {
                //Console.WriteLine(listOfNumbers.Where(listOfNumbers % 2 == 0));
            }
            Console.WriteLine("These are all the even numbers in the list");


        }

    }




}

    

