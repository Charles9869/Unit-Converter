// Fichier: Conversion.cs //
// Charles Bertrand //
// Date de création: 2 Octobre 2018 //

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UnitConverter;

namespace TP1
{
    public partial class Conversion : Form
    {

        // Attributs //
        private decimal ValueToConvert { get; set; }
        private const char ENTER = (char)13;
        private ToolTip TP;

        protected int test;

        // Constructeur par défaut //
        public Conversion()
        {
            InitializeComponent();
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            TP = new ToolTip();
            TP.SetToolTip(BTN_Quitter_Conversion, "Fermer la fenêtre");
            TP.SetToolTip(BTN_Convertir_Valeur, "Appuyer sur ENTER pour convertir!");
            TP.SetToolTip(BTN_Effacer_Valeur, "Appuyer sur CTRL+X pour effacer le formulaire!");
            InitialiserInterface();
            TextBox_Depart.Select();
        }

        private void BTN_Distance_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Distance.Checked) AfficherUnitéMesure(UnitType.Distance);
            else EffacerUnitéDeMesure(UnitType.Distance);
        }


        private void BTN_Volume_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Volume.Checked) AfficherUnitéMesure(UnitType.Volume);
            else EffacerUnitéDeMesure(UnitType.Volume);
        }

        private void BTN_Poids_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Poids.Checked) AfficherUnitéMesure(UnitType.Poids);
            else EffacerUnitéDeMesure(UnitType.Poids);
        }

        private void LBX_End_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_Convertir_Valeur.Enabled = !string.IsNullOrWhiteSpace(TextBox_Depart.Text);
            TextBox_Depart.Select();
        }

        private void BTN_Convertir_Valeur_Click(object sender, EventArgs e)
        {
            CalculConversion();
        }

        private void TextBox_Depart_TextChanged(object sender, EventArgs e)
        {
            //// Pour que le bouton convertir soit actif, l'utilisateur doit selectionner les deux valeurs //
            //BTN_Convertir_Valeur.Enabled = LBX_Start.SelectedIndex != -1 && LBX_End.SelectedIndex != -1;
            BTN_Effacer_Valeur.Enabled = !string.IsNullOrWhiteSpace(TextBox_Depart.Text);
            GroupBox_UniteMesure.Enabled = !string.IsNullOrWhiteSpace(TextBox_Depart.Text);
            BTN_Convertir_Valeur.Enabled = !string.IsNullOrWhiteSpace(TextBox_Depart.Text);
        }

        private void BTN_Quitter_Conversion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_Depart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Down)
            {
                this.Close();
            }
        }

        private void TXValeur_Depart_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permet uniquement d'entrer des nombres //
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == CONVERTER.DecimalSymbol
                && (sender as TextBox).Text.IndexOf(CONVERTER.DecimalSymbol) > -1)
            {
                e.Handled = true;
            }

            switch (e.KeyChar)
            {
                case ENTER:
                    //MessageBox.Show("dsdsads");
                    BTN_Convertir_Valeur.PerformClick();
                    e.Handled = true;
                    break;
            }
        }

        private void LBX_End_KeyPress(object sender, KeyPressEventArgs e)
        {
            GererControle(e);
        }

        private void LBX_Start_KeyPress(object sender, KeyPressEventArgs e)
        {
            GererControle(e);
        }

        private void BTN_Effacer_Valeur_Click(object sender, EventArgs e)
        {
            // Enlèves tous les unités lorsque le l'utilisateur appuie sur le flash button //
            foreach (Unit unit in CONVERTER.GetAllUnits())
            {
                LBX_Start.Items.Remove(unit);
                LBX_End.Items.Remove(unit);
            }
            InitialiserInterface();
        }

        /// <summary>
        /// Affiche les unités de mesure de la liste selon le type
        /// </summary>
        /// <param name="TypeConversion"></param>
        private void AfficherUnitéMesure(UnitType TypeConversion)
        { 
            foreach (Unit unit in CONVERTER.GetUnitsByType(TypeConversion))
            {
                LBX_Start.Items.Add(unit);
                LBX_End.Items.Add(unit);
            }

            LBX_Start.SelectedIndex = 0;
            LBX_End.SelectedIndex = 0;
        }

        /// <summary>
        /// Efface les unités de mesure de la liste selon le type
        /// </summary>
        /// <param name="TypeConversion"></param>
        private void EffacerUnitéDeMesure(UnitType TypeConversion)
        {
            foreach (Unit unit in CONVERTER.GetUnitsByType(TypeConversion))
            {
                LBX_Start.Items.Remove(unit);
                LBX_End.Items.Remove(unit);
            }
        }

        /// <summary>
        /// Initialise les paramètres par défaut 
        /// </summary>
        private void InitialiserInterface()
        {
            BTN_Convertir_Valeur.Enabled = false;
            TextBox_Depart.Text = "";
            TextBox_Convertie.Text = "";
            AfficherUnitéMesure(UnitType.Distance);
        }

        /// <summary>
        /// Calcule la conversion et l'affiche dans TextBox_Convertie
        /// </summary>
        private void CalculConversion()
        {
            Unit UniteDepart = (Unit)LBX_Start.SelectedItem;
            Unit UniteEnd = (Unit)LBX_End.SelectedItem;
            ValueToConvert = decimal.Parse(TextBox_Depart.Text);
            TextBox_Convertie.Text = CONVERTER.Convert(ValueToConvert, UniteDepart, UniteEnd);
        }

        private void GererControle(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case ENTER:
                    BTN_Convertir_Valeur.PerformClick();
                    e.Handled = true;
                    break;
            }
        }

        private void TextBox_Depart_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    BTN_Effacer_Valeur.PerformClick();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
