using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht2
{
    class Liquid : Item
    {
        public string Type { get; set; }
        public double Size { get; set; }
        public Liquid(string name, string type, double size) : base(name)
        {
            Name = name;
            Type = type;
            Size = size;
        }
        public override void PrintDetails()
        {
            Console.WriteLine(Name + " " + "joka on" + " " + Type + " ja " + Size + " litran verran");
        }
    }
}
