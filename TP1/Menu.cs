// Fichier: Menu.cs //
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
    public partial class Menu : Form
    {

        // Attributs //
        private ToolTip Tp;

        // Constructeur par défaut //
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Tp = new ToolTip();

            Tp.SetToolTip(BTN_Demarrer_Conversion, "Effectuer une conversion");
            Tp.SetToolTip(BTN_Modifier_Unit, "Gérer les unités de mesure");
            Tp.SetToolTip(BTN_Quitter, "Quitter");
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Fermer();
        }

        private void BTN_Modifier_Unit_Click(object sender, EventArgs e)
        {
            OuvrirFenetreUniteMesure();
        }

        private void BTN_Demarrer_Conversion_Click(object sender, EventArgs e)
        {
            OuvrirFenetreConversion();
        }

        private void effectuerUneConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFenetreConversion();
        }

        private void gérerLesUnitésDeMesureAltGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFenetreUniteMesure();
        }

        private void quitterAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fermer();
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre de conversion
        /// </summary>
        private void OuvrirFenetreConversion()
        {
            Conversion ConversionUI = new Conversion();
            if (ConversionUI.ShowDialog() == DialogResult.OK) { }
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre de gestion des unités de mesure
        /// </summary>
        private void OuvrirFenetreUniteMesure()
        {
            Unite UniteUI = new Unite();
            if (UniteUI.ShowDialog() == DialogResult.OK) { }
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
