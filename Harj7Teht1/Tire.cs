using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht1
{
    class Tire
    {
        public string TireName { get; set; }
        public string TireModel { get; set; }
        public string Size { get; set; }

        public Tire(string name, string model, string size)
        {
            this.TireName = name;
            this.TireModel = model;
            this.Size = size;
        }

        ~Tire()
        {

        }

        public override string ToString()
        {
            return TireName + " " + TireModel + " " + Size;
        }
    }
}
