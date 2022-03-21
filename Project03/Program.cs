using System;
using Project03.Model.Entities;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            Resident r = new Resident();
            r.PhoneNumber = 2134;
            System.Console.WriteLine(r.PhoneNumber);
        }
    }
}