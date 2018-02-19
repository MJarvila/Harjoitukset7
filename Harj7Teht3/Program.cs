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
    class Program
    {
        static void Main(string[] args)
        {
            Team Jotkut = new Team("Jotkut", "Jokula");
            Team Toiset = new Team("Toiset", "Toisela");
            Player Asa = new Player("Asa", "Aasala", "Maalivahti", "R");
            Player Basi = new Player("Basi", "Basala", "Maalivahti", "L");
            Player Casey = new Player("Casey", "Caccala", "Hyökkääjä", "R");
            Player Daavid = new Player("Daavid", "Depopopo", "Hyökkääjä", "L");
            Player Esa = new Player("Esa", "Erkkilä", "Puolustaja", "R");
            Player Faffa = new Player("Faffa", "Farkkula", "Maalivahti", "R");
            Jotkut.Players.Add(Asa);
            Jotkut.Players.Add(Basi);
            Jotkut.Players.Add(Casey);

            Toiset.Players.Add(Daavid);
            Toiset.Players.Add(Esa);
            Toiset.Players.Add(Faffa);
 
            foreach (Player player in Jotkut.Players)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine();
            foreach (Player player in Toiset.Players)
            {
                Console.WriteLine(player.ToString());
            }
        }
    }
}
