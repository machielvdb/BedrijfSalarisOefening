using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrijfSalarisOefening.Classes
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public Salaris Loon = new Salaris();
        public string Herkomst { get; set; }

        public Werknemer(string naam, Salaris salaris, string herkomst)
        {
            Naam = naam;
            Loon = salaris;
            Herkomst = herkomst;
        }

        public Werknemer(string naam, Salaris salaris)
        {
            Naam = naam;
            Loon = salaris;
            Herkomst = "Belgie";
        }

        public Werknemer(string naam, string herkomst)
        {
            Naam = naam;
            Loon = new Salaris();
            Loon.Brutobedrag = 2440.55;
            Herkomst = herkomst;
        }

        public Werknemer(string naam)
        {
            Naam = naam;
            Loon = new Salaris();
            Loon.Brutobedrag = 2440.55;
            Herkomst = "Belgie";
        }

        public Werknemer()
        {
            Naam = string.Empty;
            Loon = new Salaris();
            Loon.Brutobedrag = 2440.55;
            Herkomst = "Belgie";
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
