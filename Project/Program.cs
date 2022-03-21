using System;
using System.Collections.Generic;
using Project.Model.Entities;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Colaborator> colaborators = new List<Colaborator>();

            try
            {
                System.Console.Write("Enter colaborators quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantity; i++)    
                {
                    System.Console.WriteLine($"Enter Colaborator #{i} Data:");
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Registry: ");
                    int registry = int.Parse(Console.ReadLine());
                    System.Console.Write("Level (1- none, 2- basic, 3- superior): ");
                    int level = int.Parse(Console.ReadLine());
                    switch(level)
                    {
                        case 1:
                            colaborators.Add(new Colaborator(name, registry));
                            break;
                        case 2:
                            System.Console.Write("School: ");
                            string school = Console.ReadLine();
                            colaborators.Add(new Basic(name, registry, school));
                            break;
                        case 3:
                            System.Console.Write("School: ");
                            school = Console.ReadLine();
                            System.Console.Write("University: ");
                            string university = Console.ReadLine();
                            colaborators.Add(new Superior(name, registry, school, university));
                            break;
                        default:
                            System.Console.WriteLine("Invalid");
                            break;
                    }
                }

                System.Console.WriteLine();
                System.Console.WriteLine("Colaborators List:");
                System.Console.WriteLine();
                foreach (Colaborator colaborator in colaborators)
                {
                    System.Console.WriteLine(colaborator);
                }
            }
            catch(FormatException e)
            {
                System.Console.WriteLine("Format Error: " + e.Message);
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}