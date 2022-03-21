using System;

namespace Project.Model.Entities
{
    class Colaborator
    {
        public string Name { get; set; }    
        public int Registration { get; set; }

        public Colaborator(string name, int registration)
        {
            Name = name;
            Registration = registration;
        }
        public override string ToString()
        {
            return $"{Name}, {Registration}";
        }
    }
}