using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Nisakas human = new Ihminen("Arnold", 110, 190, 28);
            Nisakas adult = new Aikuinen("Kekkonen", 70, 175, 40, "Lada");
            Nisakas human2 = new Ihminen("Iisakki", 60, 150, 10);
            Nisakas baby = new Vauva("Aatos", 5, 50, 1, "Pampers");

            List<Nisakas> Nisakkaat = new List<Nisakas> { human, adult, human2, baby };

            foreach (Nisakas nisakas in Nisakkaat)
            {
                nisakas.Liiku();
                nisakas.PrintDetails();
                //Console.WriteLine(nisakas.GetType());
            }

        }
    }
}
