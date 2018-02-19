using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht1
{
    class Vehicle
    {
        public List<Tire> Tires { get; set; }

        public string Name { get; set; }
        public string Model { get; set; }
        public Vehicle(string name, string model)
        {
            this.Name = name;
            this.Model = model;
            this.Tires = new List<Tire>();
        }
        public override string ToString()
        {
            return Name + " " + Model;
        }
    }
}