using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy. 
/// Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista. 
/// </summary>
namespace Harj7Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge("Kaappi", "Kaappi");
            Item item = new Item("Valo");
            Item item2 = new Item("Hylly");
            Item food = new Food("Kanapasta", "ruokaa");
            Item food2 = new Food("Sinihomejuusto", "juustoa");
            Item liquid = new Liquid("Kivennäisvesi", "vettä", 1.5);
            fridge.Items.Add(item);
            fridge.Items.Add(item2);
            fridge.Items.Add(food);
            fridge.Items.Add(food2);
            fridge.Items.Add(liquid);
            fridge.CheckFridge();
        }
    }
}
