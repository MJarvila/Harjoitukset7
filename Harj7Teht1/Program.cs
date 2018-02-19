using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. 
/// Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) 
/// ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina 
/// esim. taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa). 
/// Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. 
/// Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa. 
/// </summary>
namespace Harj7Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Porsche = new Vehicle("Porsche", "911RS");
            Tire Nokia = new Tire("Nokia", "Hakkapeliitta", "205R16");
            Porsche.Tires.Add(Nokia);
            Porsche.Tires.Add(Nokia);
            Porsche.Tires.Add(Nokia);
            Porsche.Tires.Add(Nokia);
            Console.WriteLine(Porsche.ToString());
            foreach (Tire tire in Porsche.Tires)
            {
                Console.WriteLine(tire.ToString());
            }
        }
    }
}
