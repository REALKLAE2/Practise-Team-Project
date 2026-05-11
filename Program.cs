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

            //Fletch









        }
    }
}
