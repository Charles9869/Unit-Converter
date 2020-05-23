// Fichier: Unite.cs //
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
    public partial class Unite : Form
    {
        private List<Unit> TableauUnite;

        private ToolTip TP;
        private Unit mUnit;
        private ModifierUnite ModifierUniteUI;
        private ConfirmationRetrait ConfirmationRetraitUI;
        private bool ConfirmationAjouteUnite { get; set; }

        // Constructeur par défaut //
        public Unite()
        {
            InitializeComponent();
        }

        private void Unite_Load(object sender, EventArgs e)
        {
            TP = new ToolTip();
            TP.SetToolTip(BTN_AjouterUnite, "Appuyez sur CTRL+A pour ajouter un unité");
            TP.SetToolTip(BTN_Modify, "Appuyez sur CTRL+M pour modifier un unité");
            TP.SetToolTip(BTN_Effacer_Valeur, "Appuyez sur CTRL+E pour effacer un unité");
            TP.SetToolTip(BTN_Quitter_Unite, "Appuyez sur CTRL+X pour quitter la fenêtre");

            GRadioButton_Distance.Checked = true;
        }

        private void BTN_Quitter_Unite_Click(object sender, EventArgs e)
        {
            Fermer();
        }

        private void GRadioButton_Distance_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Modify.Enabled = false;
            BTN_Effacer_Valeur.Enabled = false;

            if (GRadioButton_Distance.Checked)
            {
                LBX_GererUniteMesure.Select();
                AfficherUnitéMesure(UnitType.Distance);
                LBX_GererUniteMesure.SelectedIndex = 0;
            }
            else
            {
                EffacerUnitéDeMesure(UnitType.Distance);
            }
        }

        private void BTN_AjouterUnite_Click(object sender, EventArgs e)
        {
            int IndexOfList = LBX_GererUniteMesure.SelectedIndex;
            ConfirmationAjout AjouterUniteUI = new ConfirmationAjout(TableauUnite[IndexOfList].Type.ToString());

            if (AjouterUniteUI.ShowDialog() == DialogResult.OK) { }

            if (AjouterUniteUI.ConfirmationAjoutUnite)
            {
                mUnit = AjouterUniteUI.AjouterUnite();
                CONVERTER.Add(mUnit);
                Refresh(TableauUnite[IndexOfList].Type);

                // Met l'index à la position de l'unité ajouté //
                int Index = TableauUnite.LastIndexOf(mUnit);

                LBX_GererUniteMesure.SelectedIndex = Index;
            }
            else
            {
                LBX_GererUniteMesure.SelectedIndex = IndexOfList;
            }
        }

        private void BTN_Modify_Click(object sender, EventArgs e)
        {
            int IndexOfList = LBX_GererUniteMesure.SelectedIndex;

            ModifierUniteUI = new ModifierUnite(TableauUnite[IndexOfList].Type.ToString(), TableauUnite[IndexOfList].MetricValue.ToString(), TableauUnite[IndexOfList].Name.ToString());
            if (ModifierUniteUI.ShowDialog() == DialogResult.OK) { }
            if (ModifierUniteUI.mPeutModifier)
            {
                TableauUnite[IndexOfList].Name = ModifierUniteUI.mNomUnite;
                TableauUnite[IndexOfList].MetricValue = ModifierUniteUI.mValeurMetrique;
                Refresh(TableauUnite[IndexOfList].Type);
            }

            LBX_GererUniteMesure.SelectedIndex = IndexOfList;
        }

        private void BTN_Effacer_Valeur_Click(object sender, EventArgs e)
        {
            int IndexOfList = LBX_GererUniteMesure.SelectedIndex;

            ConfirmationRetraitUI = new ConfirmationRetrait(TableauUnite[IndexOfList].Name, TableauUnite[IndexOfList].MetricValue.ToString(), TableauUnite[IndexOfList].Type.ToString());

            if (ConfirmationRetraitUI.ShowDialog() == DialogResult.OK) { }

            // Si l'utilisateur appuie sur le bouton qui confirme, l'unité est ajouté //
            if (ConfirmationRetraitUI.ConfirmationRetraitUnite)
            {
                int Index = LBX_GererUniteMesure.SelectedIndex;
                CONVERTER.Delete(TableauUnite[Index]);
                LBX_GererUniteMesure.Items.Remove(LBX_GererUniteMesure.SelectedItem);
                LBX_GererUniteMesure.SelectedIndex = IndexOfList - 1;
            }
            else
            {
                LBX_GererUniteMesure.SelectedIndex = IndexOfList;
            }
        }

        private void LBX_GererUniteMesure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_GererUniteMesure.SelectedIndex >= 0)
            {
                BTN_AjouterUnite.Enabled = true;
                BTN_Modify.Enabled = true;
                BTN_Effacer_Valeur.Enabled = true;
            }
            else
            {
                BTN_Modify.Enabled = false;
            }
        }

        private void GRadioButton_Volume_CheckedChanged(object sender, EventArgs e)
        {
            if (GRadioButton_Volume.Checked)
            {
                LBX_GererUniteMesure.Select();
                AfficherUnitéMesure(UnitType.Volume);
                LBX_GererUniteMesure.SelectedIndex = 0;
            }
            else
            {
                EffacerUnitéDeMesure(UnitType.Volume);
            }
        }

        private void GRadioButton_Poids_CheckedChanged(object sender, EventArgs e)
        {
            if (GRadioButton_Poids.Checked)
            {
                LBX_GererUniteMesure.Select();
                Refresh(UnitType.Poids);
                LBX_GererUniteMesure.SelectedIndex = 0;

            }
            else
            {
                EffacerUnitéDeMesure(UnitType.Poids);
            }
        }

        private void LBX_GererUniteMesure_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BTN_AjouterUnite.PerformClick();
        }

        /// <summary>
        /// Affiche tous les unités de mesure selon le type passé en paramètre
        /// </summary>
        /// <param name="TypeConversion"></param>
        private void AfficherUnitéMesure(UnitType TypeConversion)
        {
            TableauUnite = CONVERTER.GetUnitsByType(TypeConversion);

            foreach (Unit unit in TableauUnite)
            {
                LBX_GererUniteMesure.Items.Add(unit);
            }
        }

        /// <summary>
        /// Efface tous les unités de mesure selon le type passé en paramètre
        /// </summary>
        /// <param name="TypeConversion"></param>
        private void EffacerUnitéDeMesure(UnitType TypeConversion)
        {
            foreach (Unit unit in CONVERTER.GetUnitsByType(TypeConversion))
            {
                LBX_GererUniteMesure.Items.Remove(unit);
            }
        }

        /// <summary>
        /// Efface les unités et les rajoutes pour les mettre à jour
        /// </summary>
        /// <param name="Type"></param>
        private void Refresh(UnitType Type)
        {
            EffacerUnitéDeMesure(Type);
            AfficherUnitéMesure(Type);
        }

        /// <summary>
        /// Permet de fermer la fenêtre de navigation 
        /// </summary>
        private void Fermer()
        {
            this.Close();
        }

        private void BTN_Help_Click(object sender, EventArgs e)
        {
            Help Test = new Help();

            if (Test.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void LBX_GererUniteMesure_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    Fermer();
                    break;

                case Keys.Add:
                    BTN_AjouterUnite.PerformClick();
                    break;

                case Keys.Subtract:
                    BTN_Effacer_Valeur.PerformClick();
                    break;

                case Keys.ControlKey:
                    BTN_Modify.PerformClick();
                    break;

                case Keys.F1:
                    BTN_Help.PerformClick();
                    break;

                case Keys.Escape:
                    Fermer();
                    break;
            }
        }
    }
}
