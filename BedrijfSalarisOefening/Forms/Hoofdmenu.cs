using BedrijfSalarisOefening.Classes;
using BedrijfSalarisOefening.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedrijfSalarisOefening
{
    public partial class Hoofdmenu : Form
    {
        public static Bedrijf Hoehel = new Bedrijf("Hoehel");
        public static List<Bedrijf> bedrijfsLijst = new List<Bedrijf>();
        public Hoofdmenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Hoofdmenu_Load(object sender, EventArgs e)
        {
            Werknemer geert = new Werknemer("Geert", new Salaris(contracttype: false));
            Werknemer daniel = new Werknemer("Daniel", new Salaris(contracttype: false), "Nederland");
            Werknemer frank = new Werknemer("Frank", new Salaris(contracttype: true, brutobedrag: 2200));
            Werknemer sofia = new Werknemer("Sofia", new Salaris(contracttype: true, brutobedrag: 3110), "Nederland");

            Hoehel.werknemerLijst.Add(geert);
            Hoehel.werknemerLijst.Add(daniel);
            Hoehel.werknemerLijst.Add(frank);
            Hoehel.werknemerLijst.Add(sofia);
            bedrijfsLijst.Add(Hoehel);

            Bedrijf nvidia = new Bedrijf("Nvidia");
            Bedrijf intel = new Bedrijf("Intel");
            nvidia.GenereerBTWNummer();
            intel.GenereerBTWNummer();
            Hoofdmenu.bedrijfsLijst.Add(nvidia);
            Hoofdmenu.bedrijfsLijst.Add(intel);
            intel.GenereerWerknemers();
            System.Threading.Thread.Sleep(50);
            nvidia.GenereerWerknemers();
        }

        private void btnWerknemers_Click(object sender, EventArgs e)
        {
            Werknemers f = new Werknemers();
            f.Show();
        }

        private void btnSalarissen_Click(object sender, EventArgs e)
        {
            Salarissen f = new Salarissen();
            f.Show();
        }

        private void btnBedrijven_Click(object sender, EventArgs e)
        {
            Bedrijven f = new Bedrijven();
            f.Show();
        }
    }
}