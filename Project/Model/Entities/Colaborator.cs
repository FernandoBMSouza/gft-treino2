using System;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Registration: {Registration}");
            return sb.ToString();
        }
    }
}