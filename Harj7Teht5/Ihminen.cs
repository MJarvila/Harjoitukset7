using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht5
{
    class Ihminen : Nisakas
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Ihminen(string name, int weight, int height, int age) : base(age)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override void Liiku()
        {
            Console.WriteLine(Name + " " + "moves.");
        }

        public override void PrintDetails()
        {
            Console.WriteLine(Name + " " + Weight + " kg " + Height + " cm " + Age + " years old.");
        }
    }
}
