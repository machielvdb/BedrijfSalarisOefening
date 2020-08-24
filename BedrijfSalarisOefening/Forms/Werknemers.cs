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
    public partial class Werknemers : Form
    {
        public Werknemers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Werknemers_Load(object sender, EventArgs e)
        {
            cbWerknemers.DataSource = Hoofdmenu.Hoehel.werknemerLijst;
        }

        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbWerknemers.DataSource = Hoofdmenu.Hoehel.werknemerLijst;
            Werknemer selectedWerknemer = cbWerknemers.SelectedItem as Werknemer;
            lblSalaris.Text = selectedWerknemer.Loon.ToString();
            lblAfkomst.Text = selectedWerknemer.Herkomst;
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
