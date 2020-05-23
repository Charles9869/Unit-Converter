// Fichier: ModifierUnite.cs //
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

namespace TP1
{
    public partial class ModifierUnite : Form
    {
        private string mType { get; set; }
        public Decimal mValeurMetrique { get; set; }
        public string mNomUnite { get; set; }
        public bool mPeutModifier { get; set; }
        private const char ENTER = (char)13;
        public string Nom { get; set; }
        private string mNomTypeMesure { get; set; }
        private string mValeurMetrique2 { get; set; }
        private string mName { get; set; }
        private ToolTip TP;

        // Constructeur par défaut //
        public ModifierUnite()
        {
            InitializeComponent();
        }

        // Constructeur avec paramètre //
        public ModifierUnite(string Type, string ValeurMetrique, string Name)
        {
            InitializeComponent();
            mType = Type;

            switch (mType)
            {
                case "Distance":
                    RadioButton_Distance.Checked = true;
                    break;

                case "Volume":
                    RadioButton_Volume.Checked = true;
                    break;

                case "Poids":
                    RadioButton_Poids.Checked = true;
                    break;
                default:
                    break;
            }

            mValeurMetrique2 = ValeurMetrique;
            mName = Name;
        }

        private void ModifierUnite_Load(object sender, EventArgs e)
        {
            TextBox_TypeMesure.Text = mName;
            TextBox_ValeurMetrique.Text = mValeurMetrique2;
            TP = new ToolTip();
            TP.SetToolTip(BTN_Confirmation_Modifier, "Appuyez sur ENTER pour confirmer la modification");
            TP.SetToolTip(BTN_Quitter, "Appuyez sur CTRL+X pour annuler et quitter");
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            mPeutModifier = false;
            Fermer();
        }

        private void TextBox_ValeurMetrique_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permet uniquement les nombres décimaux //
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permet uniquement d'utiliser la virgule comme signe de ponctuation //
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            switch (e.KeyChar)
            {
                case ENTER:
                    BTN_Confirmation_Modifier.PerformClick();
                    e.Handled = true;
                    break;
            }
        }

        private void TextBox_TypeMesure_TextChanged(object sender, EventArgs e)
        {
            // Pour que le flash button qui permet la conversion soit activer les deux textbox doivent avoir du texte à l'intérieur //
            BTN_Confirmation_Modifier.Enabled = !string.IsNullOrWhiteSpace(TextBox_TypeMesure.Text) && !string.IsNullOrWhiteSpace(TextBox_ValeurMetrique.Text);
        }

        private void TextBox_ValeurMetrique_TextChanged(object sender, EventArgs e)
        {
            // Pour que le flash button qui permet la conversion soit activer les deux textbox doivent avoir du texte à l'intérieur //
            BTN_Confirmation_Modifier.Enabled = !string.IsNullOrWhiteSpace(TextBox_TypeMesure.Text) && !string.IsNullOrWhiteSpace(TextBox_ValeurMetrique.Text);
        }

        private void BTN_Confirmation_Modifier_Click(object sender, EventArgs e)
        {
            mPeutModifier = true;
            mNomUnite = TextBox_TypeMesure.Text;

            // Converti la valeur du textbox en decimal //
            mValeurMetrique = Decimal.Parse(TextBox_ValeurMetrique.Text);
            Fermer();
        }

        private void TextBox_TypeMesure_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case ENTER:
                    // Donne le focus au textbox responsable de la valeur métrique //
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
        /// Permet de fermer la fenêtre de dialogue
        /// </summary>
        private void Fermer()
        {
            this.Close();
        }
    }
}