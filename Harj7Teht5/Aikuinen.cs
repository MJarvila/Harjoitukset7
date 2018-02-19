using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht5
{
    class Aikuinen : Ihminen
    {
        public string Car { get; set; }
        public Aikuinen(string name, int weight, int height, int age, string car) : base(name, weight, height, age)
        {
            Car = car;
        }

        public override void Liiku()
        {
            Console.WriteLine(Name + " " + "walks.");
        }

        public override void PrintDetails()
        {
            Console.WriteLine(Name + " " + Weight + " kg " + Height + " cm " + Age + " years old " + Car);
        }
    }
}
