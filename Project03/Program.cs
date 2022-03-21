using System;
using System.Collections.Generic;
using Project03.Model.Entities;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Resident> residents = new List<Resident>();

            System.Console.Write("How many residents? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                System.Console.WriteLine($"Resident #{i}");
                System.Console.Write("Phone Number: ");
                int phoneNumber = int.Parse(Console.ReadLine());
                System.Console.Write("Residence Number: ");
                int residenceNumber = int.Parse(Console.ReadLine());
                System.Console.Write("Do you have dogs? (y/n) - ");
                string answer = Console.ReadLine().ToLower();

                if(residenceNumber % 2 != 0 && answer == "n")
                {
                    residents.Add(new Resident(phoneNumber, residenceNumber));
                }

                System.Console.WriteLine($"Odd houses where correspondence was delivered: {residents.Count()}");
            }

        }
    }
}