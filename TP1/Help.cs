// Fichier: Help.cs //
// Charles Bertrand //
// Date de création: 3 Octobre 2018 //

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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Fermer();
        }

        /// <summary>
        /// Permet de fermer la fenêtre de dialogue 
        /// </summary>
        private void Fermer()
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Quitter_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Fermer();
                    break;
            }
        }
    }
}
