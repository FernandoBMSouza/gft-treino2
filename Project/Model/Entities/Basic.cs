using System;

namespace Project.Model.Entities
{
    class Basic : Colaborator
    {
        public string School { get; set; }

        public Basic(string name, int registration, string school) : base(name, registration)
        {
            School = school;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {School}";
        }
    }
}