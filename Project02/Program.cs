using System;
using System.Globalization;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("Options Menu: ");
                System.Console.WriteLine("1. Age");
                System.Console.WriteLine("2. IMC");
                System.Console.WriteLine("3. Sair");

                System.Console.Write("Enter Option: ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        System.Console.Write("BirthYear: ");
                        int birthYear = int.Parse(Console.ReadLine());
                        System.Console.Write("Year: ");
                        int year = int.Parse(Console.ReadLine());
                        System.Console.WriteLine($"Age: {AgeCalculator(birthYear, year)}");
                        break;
                    case 2:
                        System.Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        System.Console.Write("Weight: ");
                        double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        System.Console.WriteLine($"IMC: {IMCCalculator(height, weight).ToString("F2", CultureInfo.InvariantCulture)}");
                        break;
                    case 3:
                        System.Console.WriteLine("Application Finished");
                        break;
                    default:
                        System.Console.WriteLine("Invalid Option");
                        break;
                }
                System.Console.WriteLine();
            } 
            while(option != 3);
        }

        static int AgeCalculator(int birthYear, int year)
        {
            return year - birthYear;
        }
        static double IMCCalculator(double height, double weight)
        {
            return weight / Math.Pow(height, 2);
        }
    }
}