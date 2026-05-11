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









        }
    }
}
