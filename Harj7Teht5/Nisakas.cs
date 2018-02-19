using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht5
{
    abstract class Nisakas
    {
        public int Age { get; set; }

        public Nisakas()
        {

        }

        public Nisakas(int age)
        {
            Age = age;
        }

        abstract public void Liiku();

        abstract public void PrintDetails();

    }
}
