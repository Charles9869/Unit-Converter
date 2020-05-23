// Fichier: ConfirmationRetrait.cs //
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
    public partial class ConfirmationRetrait : Form
    {
        public bool ConfirmationRetraitUnite { get; set; }
        public string Nom { get; set; }
        private string mNomTypeMesure { get; set; }
        private string mValeurMetrique { get; set; }
        private string mName { get; set; }
        private ToolTip TP;

        // Constructeur par défaut //
        public ConfirmationRetrait()
        {
            InitializeComponent();
        }

        // Constructeur avec paramètre //
        public ConfirmationRetrait(string TypeMesure, string ValeurMetrique, string Name)
        {
            InitializeComponent();
            mNomTypeMesure = TypeMesure;
            mValeurMetrique = ValeurMetrique;
            mName = Name;
        }

        private void ConfirmationRetrait_Load(object sender, EventArgs e)
        {
            TextBox_TypeMesure.Text = mNomTypeMesure;
            TextBox_ValeurMetrique.Text = mValeurMetrique;

            TP = new ToolTip();
            TP.SetToolTip(BTN_Confirmer_Retrait, "Appuzer sur CTRL+R pour retirer l'unité de meusure");
            TP.SetToolTip(BTN_Quitter, "Appuyez sur CTRL+X pour annuler et quitter");

            TextBox_TypeMesure.Focus();
            switch (mName)
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
                    RadioButton_Distance.Checked = true;
                    break;
            }
        }

        private void BTN_Confirmer_Retrait_Click(object sender, EventArgs e)
        {
            ConfirmationRetraitUnite = true;
            Fermer();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Fermer();
        }

        /// <summary>
        /// Ferme la fenêtre de dialogue 
        /// </summary>
        private void Fermer()
        {
            this.Close();
        }

        private void TextBox_TypeMesure_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    BTN_Quitter.PerformClick();
                    break;

                case Keys.Enter:
                    BTN_Confirmer_Retrait.PerformClick();
                    break;
            }
        }
    }
}
