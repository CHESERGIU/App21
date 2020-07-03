using System;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] city = new string[] { "Paris", "Londra", "Madrid", "Berlin", "Roma" };
            string inputData = Console.ReadLine();

            switch (inputData)
            {
                case "Paris":
                    Console.WriteLine("Franța");
                    break;
                case "Londra":
                    Console.WriteLine("Marea Britanie");
                    break;
                case "Madrid":
                    Console.WriteLine("Spania");
                    break;
                case "Berlin":
                    Console.WriteLine("Germania");
                    break;
                case "Roma":
                    Console.WriteLine("Italia");
                    break;
                default:
                    Console.WriteLine("oras invalid");
                    break;
            }
        }
    }
}
