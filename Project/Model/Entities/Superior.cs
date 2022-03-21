using System;
using System.Text;

namespace Project.Model.Entities
{
    class Superior : Basic
    {
        public string University { get; set; }

        public Superior(string name, int registration, string school, string university) : base(name, registration, school)
        {
            University = university;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"University: {University}");
            return $"{base.ToString()}{sb.ToString()}";
        }
    }
}