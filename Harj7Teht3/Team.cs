using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Jääkiekon SM-liigassa on viisitoista joukkuetta ja jokaisessa joukkuuessa on noin 25 pelaajaa. 
/// Tee Pelaaja-luokka, jolla on ominaisuudet: etunimi, sukunimi, pelipaikka (mv, p, h), kätisyys (L tai R). 
/// Luo myös luokka Seura, jolla on ominaisuudet: nimi, kaupunki ja kokoelma Pelaaja-olioita. 
/// Tee konsolisovellus, joka osaa esittää valitun seuran pelaajat. Voit "kovakoodata" pelaajatiedot pelaajaolioihin. 
/// </summary>
namespace Har7Teht3
{
     class Team
    {
        public List<Player> Players { get; set; }
        public string TeamName { get; set; }
        public string City { get; set; }
        public Team (string teamName, string city)
        {
            this.TeamName = teamName;
            this.City = city;
            this.Players = new List<Player>();
        }
        public override string ToString()
        {
            return TeamName + " " + City;
        }
    }
}
