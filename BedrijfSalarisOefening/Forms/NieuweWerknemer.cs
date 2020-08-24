using BedrijfSalarisOefening.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedrijfSalarisOefening.Forms
{
    public partial class NieuweWerknemer : Form
    {
        private static Bedrijf geselecteerdBedrijf;
        public NieuweWerknemer(Bedrijf bedrijf)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            geselecteerdBedrijf = bedrijf;
        }

        private void NieuweWerknemer_Load(object sender, EventArgs e)
        {
            var landLijst = File.ReadAllLines($"countries");
            cbHerkomst.DataSource = landLijst;
            cbContractType.Items.Add("Weekcontract");
            cbContractType.Items.Add("Maancontract");
            Bedrijven.ActiveForm.Close();
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text != string.Empty && Double.TryParse(tbLoon.Text, out double loon) && cbContractType.Text != string.Empty)
            {
                Salaris nieuwSalaris = new Salaris(loon);

                if (cbContractType.Text == "Weekcontract")
                {
                    nieuwSalaris.Contracttype = false;
                }

                else nieuwSalaris.Contracttype = true;

                Werknemer nieuweWerknemer = new Werknemer(tbNaam.Text, nieuwSalaris, cbHerkomst.Text);

                foreach (var item in Hoofdmenu.bedrijfsLijst)
                {
                    if (item.Naam == geselecteerdBedrijf.Naam)
                    {
                        item.werknemerLijst.Add(nieuweWerknemer);
                    }
                }
                Close();
            }

            else MessageBox.Show("Gelieve ervoor te zorgen dat alle velden correct ingevuld zijn.");
        }
    }
}
