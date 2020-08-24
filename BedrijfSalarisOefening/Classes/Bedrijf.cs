using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BedrijfSalarisOefening.Classes
{
    public class Bedrijf
    {
        public string Naam { get; set; }
        public List<Werknemer> werknemerLijst = new List<Werknemer>();
        public string BTWNummer { get; set; }
        public Bedrijf(string naam)
        {
            Naam = naam;
            GenereerBTWNummer();
        }

        public void GenereerBTWNummer()
        {
            Random rng = new Random();

            BTWNummer = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(9999);
                BTWNummer += " " + randomnr.ToString().PadLeft(4, '0');
            }
        }

        public override string ToString()
        {
            return Naam;
        }

        public void GenereerWerknemers()
        {
            string[] naamBestand = File.ReadAllLines(@"C:\Users\Machiel\source\repos\BedrijfSalarisOefening\BedrijfSalarisOefening\naamlijst.txt");

            Random rng = new Random();

            for (int i = 3; i > 0; i--)
            {
                string v = naamBestand[rng.Next(0, 500)];
                Werknemer nieuweWerknemer = new Werknemer(v);

                foreach (var item in Hoofdmenu.bedrijfsLijst)
                {
                    if (item.Naam == Naam)
                    {
                        item.werknemerLijst.Add(nieuweWerknemer);
                    }
                }
            }
        }
    }
}
