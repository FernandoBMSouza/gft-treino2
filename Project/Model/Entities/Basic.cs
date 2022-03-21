using System;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"School: {School}");
            return $"{base.ToString()}{sb.ToString()}";
        }
    }
}