using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrijfSalarisOefening.Classes
{
    public class Salaris
    {
        public bool Contracttype { get; set; }
        public double Brutobedrag { get; set; }
        public double BTWPercentage { get; set; }
        public Salaris(double salaris = 2440.55)
        {
            Contracttype = false;
            Brutobedrag = salaris;
            BTWPercentage = 21;
        }
        
        public Salaris(bool contracttype, double brutobedrag = 2440)
        {
            Contracttype = contracttype;
            Brutobedrag = brutobedrag;
            BTWPercentage = 21;
        }
        public double BerekenNetto()
        {
            double nettobedrag = Brutobedrag - (Brutobedrag / 100 * BTWPercentage);
            return Math.Round(nettobedrag, 2);
        }

        public override string ToString()
        {
            return "Nettobedrag: " + " " + BerekenNetto() + "\n" + "Brutobedrag: " + " " + Math.Round(Brutobedrag, 2);
        }

        public string GetContractType()
        {
            if (Contracttype)
            {
                return "Maandcontract";
            }

            else return "Weekcontract";
        }
    }
}
