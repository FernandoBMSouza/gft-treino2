using System;

namespace Project.Model.Entities
{
    class Superior : Colaborator
    {
        public string University { get; set; }

        public Superior(string name, int registration, string university) : base(name, registration)
        {
            University = university;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {University}";
        }
    }
}