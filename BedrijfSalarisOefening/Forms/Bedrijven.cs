using BedrijfSalarisOefening.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedrijfSalarisOefening.Forms
{
    public partial class Bedrijven : Form
    {
        public Bedrijven()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void cbBedrijven_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboboxes();
        }

        private void Bedrijven_Load(object sender, EventArgs e)
        {

            cbBedrijven.DataSource = Hoofdmenu.bedrijfsLijst;
        }

        private void btnNieuweWerknemer_Click(object sender, EventArgs e)
        {
            Bedrijf geselecteerdBedrijf = cbBedrijven.SelectedItem as Bedrijf;
            NieuweWerknemer f = new NieuweWerknemer(geselecteerdBedrijf);
            f.Show();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Bedrijf geselecteedBedrijf = cbBedrijven.SelectedItem as Bedrijf;
            Werknemer geselecteerdeWerknemer = cbWerknemers.SelectedItem as Werknemer;
            geselecteedBedrijf.werknemerLijst.Remove(geselecteerdeWerknemer);

            FillComboboxes();
        }

        private void FillComboboxes()
        {
            cbBedrijven.DataSource = Hoofdmenu.bedrijfsLijst;
            Bedrijf bedrijf = cbBedrijven.SelectedItem as Bedrijf;
            cbWerknemers.DataSource = null;
            cbWerknemers.DataSource = bedrijf.werknemerLijst;
        }
    }
}
