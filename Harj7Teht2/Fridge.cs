using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht2
{
    class Fridge
    {
        public List<Item> Items { get; set; }

        public string Name { get; set; }
        public string Model { get; set; }
        public Fridge()
        {
            Items = new List<Item>();
        }

        public Fridge(string name, string model)
        {
            Name = name;
            Model = model;
            Items = new List<Item>();
        }

        public override string ToString()
        {
            return Name + " " + Model;
        }

        public void CheckFridge()
        {
            Console.WriteLine("Jääkaapista löytyy: ");
            foreach (Item item in Items)
            {
                item.PrintDetails();
            }
        }
    }
}
