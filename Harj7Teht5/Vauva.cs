using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht5
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string name, int weight, int height, int age, string vaippa) : base(name, weight, height, age)
        {
            Vaippa = vaippa;
        }

        public override void Liiku()
        {
            Console.WriteLine(Name + " " + "crawls.");
        }

        public override void PrintDetails()
        {
            Console.WriteLine(Name + " " + Weight + " kg " + Height + " cm " + Age + " years old " + Vaippa);
        }
    }
}
