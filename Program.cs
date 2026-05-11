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


            //Fletch








        }
    }
}
