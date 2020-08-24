using BedrijfSalarisOefening.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedrijfSalarisOefening.Forms
{
    public partial class Salarissen : Form
    {
        public Salarissen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Salarissen_Load(object sender, EventArgs e)
        {
            cbWerknemers.DataSource = Hoofdmenu.Hoehel.werknemerLijst;
        }

        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbWerknemers.DataSource = Hoofdmenu.Hoehel.werknemerLijst;
            Werknemer geselecteerdeWerknemer = cbWerknemers.SelectedItem as Werknemer;

            lblNaam.Text = geselecteerdeWerknemer.Naam;
            lblContractType.Text = geselecteerdeWerknemer.Loon.GetContractType();
            lblHerkomst.Text = geselecteerdeWerknemer.Herkomst;
            lblLoon.Text = geselecteerdeWerknemer.Loon.ToString();
        }
    }
}
