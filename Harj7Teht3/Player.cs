using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Jääkiekon SM-liigassa on viisitoista joukkuetta ja jokaisessa joukkuuessa on noin 25 pelaajaa. 
/// Tee Pelaaja-luokka, jolla on ominaisuudet: etunimi, sukunimi, pelipaikka (mv, p, h), kätisyys (L tai R). 
/// Luo myös luokka Seura, jolla on ominaisuudet: nimi, kaupunki ja kokoelma Pelaaja-olioita. 
/// Tee konsoli sovellus, joka osaa esittää valitun seuran pelaajat. Voit "kovakoodata" pelaajatiedot pelaajaolioihin. 
/// </summary>
namespace Har7Teht3
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Handed { get; set; }
        public string TeamName { get; set; }

        public Player(string firstName, string lastName, string position, string handed)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.Handed = handed;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Position + " " + Handed;
        }
    }
}
