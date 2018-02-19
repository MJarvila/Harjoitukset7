using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht2
{
    class Food : Item
    {
        public string Type { get; set; }
        public Food(string name, string type) : base(name)
        {
            Name = name;
            Type = type;
        }

        public override void PrintDetails()
        {
            Console.WriteLine(Name + " joka on " + Type);
        }
    }
}
