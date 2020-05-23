// Fichier: ConfirmationAjout.cs //
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
    public partial class ConfirmationAjout : Form
    {
        private int mValeurMetrique { get; set; }
        private string mNomValeur { get; set; }
        private string Type_ { get; set; }
        private UnitType mType;
        private const char ENTER = (char)13;
        public bool ConfirmationAjoutUnite { get; set; }
        private ToolTip TP;

        // Constructeur par défaut //
        public ConfirmationAjout(string Type)
        {
            InitializeComponent();
            Type_ = Type;
            InitUi();
        }

        private void ConfirmationAjout_Load(object sender, EventArgs e)
        {
            TP = new ToolTip();
            TP.SetToolTip(BTN_Confirmer_Ajout, "Appuyez sur ENTER pour confirmer l'ajout de l'unité");
            TP.SetToolTip(BTN_Quitter, "Appuyez sur CTRL+X pour quitter et annuler l'ajout de l'unité");
            TextBox_TypeMesure.Select();

            //AjouterUnite();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Fermer();
        }

        private void TextBox_ValeurMetrique_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permet uniquement la virgule comme signe de ponctuation //
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            switch (e.KeyChar)
            {
                case ENTER:
                    BTN_Confirmer_Ajout.PerformClick();
                    e.Handled = true;
                    break;
            }
        }

        private void BTN_Confirmer_Ajout_Click(object sender, EventArgs e)
        {
            BTN_Confirmer_Ajout.Enabled = !string.IsNullOrWhiteSpace(TextBox_TypeMesure.Text);
            AjouterUnite();
            ConfirmationAjoutUnite = true;
            Fermer();
        }

        private void RadioButton_Distance_CheckedChanged(object sender, EventArgs e)
        {
            InitUi();
        }

        private void RadioButton_Volume_CheckedChanged(object sender, EventArgs e)
        {
            InitUi();
        }

        private void RadioButton_Poids_CheckedChanged(object sender, EventArgs e)
        {
            InitUi();
        }

        private void TextBox_TypeMesure_TextChanged(object sender, EventArgs e)
        {
            BTN_Confirmer_Ajout.Enabled = !string.IsNullOrWhiteSpace(TextBox_TypeMesure.Text) && !string.IsNullOrWhiteSpace(TextBox_ValeurMetrique.Text);
        }

        private void TextBox_ValeurMetrique_TextChanged(object sender, EventArgs e)
        {
            BTN_Confirmer_Ajout.Enabled = !string.IsNullOrWhiteSpace(TextBox_TypeMesure.Text) && !string.IsNullOrWhiteSpace(TextBox_ValeurMetrique.Text);
        }

        private void TextBox_TypeMesure_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case ENTER:
                    // Donne le focus à l'autre textbox //
                    TextBox_ValeurMetrique.Select();
                    e.Handled = true;
                    break;
            }
        }

        private void TextBox_TypeMesure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.X)
            {
                Fermer();
            }
        }

        private void TextBox_ValeurMetrique_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.X)
            {
                Fermer();
            }
        }
        /// <summary>
        /// Retourne le type selon le bouton radio qui est sélectionné
        /// </summary>
        /// <returns></returns>
        private UnitType GetUnitType()
        {
            if (RadioButton_Volume.Checked)
            {
                mType = UnitType.Volume;
            }
            else if (RadioButton_Distance.Checked)
            {
                mType = UnitType.Distance;
            }
            else if (RadioButton_Poids.Checked)
            {
                mType = UnitType.Poids;
            }
            return mType;
        }

        /// <summary>
        ///    Créer un unite à l'aide des donnéées pour ensuite la retourner 
        /// </summary>
        /// <returns></returns>
        public Unit AjouterUnite()
        {
            Unit unit = new Unit { Type = GetUnitType(), Name = TextBox_TypeMesure.Text, MetricValue = decimal.Parse(TextBox_ValeurMetrique.Text) };
            return unit;
        }

        /// <summary>
        /// Set les valeurs de départ pour certain paramètre
        /// </summary>
        private void InitUi()
        {

            //TextBox_TypeMesure.Focus();
            if (RadioButton_Poids.Checked || RadioButton_Distance.Checked || RadioButton_Volume.Checked)
            {
                TextBox_ValeurMetrique.Enabled = true;
                TextBox_TypeMesure.Enabled = true;
            }

            //switch (Type_)
            //{
            //    case "Distance":
            //        RadioButton_Distance.Checked = true;
            //        break;

            //    case "Volume":
            //        RadioButton_Volume.Checked = true;
            //        break;

            //    case "Poids":
            //        RadioButton_Poids.Checked = true;
            //        break;
            //}
        }

        /// <summary>
        /// Permet de fermer la fenêtre de dialogue 
        /// </summary>
        private void Fermer()
        {
            this.Close();
        }
    }
}
