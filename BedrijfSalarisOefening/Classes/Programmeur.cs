using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrijfSalarisOefening.Classes
{
    public class Programmeur : Werknemer
    {
        public List<string> Programmeertalen = new List<string>();
        public bool Bedrijfswagen { get; set; }
        public bool Vergoeding { get; set; }
        public Programmeur(string naam, string herkomst, bool wagen, bool vergoeding) : base(naam, herkomst)
        {
            Naam = naam;
            Herkomst = herkomst;
            Programmeertalen.Add("HTML");
            Programmeertalen.Add("C#");
            Bedrijfswagen = wagen;
            Vergoeding = vergoeding;
        }

        public override string ToString()
        {
            return "Programmeur";
        }
    }
}
