namespace TP1
{
    partial class Unite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unite));
            this.GroupBox_Change_Unit = new System.Windows.Forms.GroupBox();
            this.LBX_GererUniteMesure = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GRadioButton_Poids = new System.Windows.Forms.RadioButton();
            this.GRadioButton_Volume = new System.Windows.Forms.RadioButton();
            this.GRadioButton_Distance = new System.Windows.Forms.RadioButton();
            this.BTN_Help = new Calculator.FlashButton();
            this.BTN_Effacer_Valeur = new Calculator.FlashButton();
            this.BTN_Quitter_Unite = new Calculator.FlashButton();
            this.BTN_Modify = new Calculator.FlashButton();
            this.BTN_AjouterUnite = new Calculator.FlashButton();
            this.GroupBox_Change_Unit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Change_Unit
            // 
            this.GroupBox_Change_Unit.Controls.Add(this.LBX_GererUniteMesure);
            this.GroupBox_Change_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Change_Unit.Location = new System.Drawing.Point(21, 121);
            this.GroupBox_Change_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox_Change_Unit.Name = "GroupBox_Change_Unit";
            this.GroupBox_Change_Unit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox_Change_Unit.Size = new System.Drawing.Size(311, 370);
            this.GroupBox_Change_Unit.TabIndex = 0;
            this.GroupBox_Change_Unit.TabStop = false;
            this.GroupBox_Change_Unit.Text = "Unités de mesure";
            // 
            // LBX_GererUniteMesure
            // 
            this.LBX_GererUniteMesure.FormattingEnabled = true;
            this.LBX_GererUniteMesure.ItemHeight = 22;
            this.LBX_GererUniteMesure.Location = new System.Drawing.Point(5, 25);
            this.LBX_GererUniteMesure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBX_GererUniteMesure.Name = "LBX_GererUniteMesure";
            this.LBX_GererUniteMesure.Size = new System.Drawing.Size(299, 356);
            this.LBX_GererUniteMesure.TabIndex = 0;
            this.LBX_GererUniteMesure.SelectedIndexChanged += new System.EventHandler(this.LBX_GererUniteMesure_SelectedIndexChanged);
            this.LBX_GererUniteMesure.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LBX_GererUniteMesure_KeyUp);
            this.LBX_GererUniteMesure.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBX_GererUniteMesure_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GRadioButton_Poids);
            this.groupBox1.Controls.Add(this.GRadioButton_Volume);
            this.groupBox1.Controls.Add(this.GRadioButton_Distance);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(311, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types de mesure";
            // 
            // GRadioButton_Poids
            // 
            this.GRadioButton_Poids.AutoSize = true;
            this.GRadioButton_Poids.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRadioButton_Poids.Location = new System.Drawing.Point(218, 23);
            this.GRadioButton_Poids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GRadioButton_Poids.Name = "GRadioButton_Poids";
            this.GRadioButton_Poids.Size = new System.Drawing.Size(78, 28);
            this.GRadioButton_Poids.TabIndex = 2;
            this.GRadioButton_Poids.TabStop = true;
            this.GRadioButton_Poids.Text = "Poids";
            this.GRadioButton_Poids.UseVisualStyleBackColor = true;
            this.GRadioButton_Poids.CheckedChanged += new System.EventHandler(this.GRadioButton_Poids_CheckedChanged);
            // 
            // GRadioButton_Volume
            // 
            this.GRadioButton_Volume.AutoSize = true;
            this.GRadioButton_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRadioButton_Volume.Location = new System.Drawing.Point(115, 23);
            this.GRadioButton_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GRadioButton_Volume.Name = "GRadioButton_Volume";
            this.GRadioButton_Volume.Size = new System.Drawing.Size(97, 28);
            this.GRadioButton_Volume.TabIndex = 1;
            this.GRadioButton_Volume.TabStop = true;
            this.GRadioButton_Volume.Text = "Volume";
            this.GRadioButton_Volume.UseVisualStyleBackColor = true;
            this.GRadioButton_Volume.CheckedChanged += new System.EventHandler(this.GRadioButton_Volume_CheckedChanged);
            // 
            // GRadioButton_Distance
            // 
            this.GRadioButton_Distance.AutoSize = true;
            this.GRadioButton_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRadioButton_Distance.Location = new System.Drawing.Point(5, 23);
            this.GRadioButton_Distance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GRadioButton_Distance.Name = "GRadioButton_Distance";
            this.GRadioButton_Distance.Size = new System.Drawing.Size(103, 28);
            this.GRadioButton_Distance.TabIndex = 0;
            this.GRadioButton_Distance.TabStop = true;
            this.GRadioButton_Distance.Text = "Distance";
            this.GRadioButton_Distance.UseVisualStyleBackColor = true;
            this.GRadioButton_Distance.CheckedChanged += new System.EventHandler(this.GRadioButton_Distance_CheckedChanged);
            // 
            // BTN_Help
            // 
            this.BTN_Help.BackgroundImage = global::TP1.Resource1.Neutral;
            this.BTN_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Help.ClickedImage = global::TP1.Resource1.Click;
            this.BTN_Help.DisabledImage = global::TP1.Resource1.Disable;
            this.BTN_Help.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Help.Image")));
            this.BTN_Help.Location = new System.Drawing.Point(347, 49);
            this.BTN_Help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Help.Name = "BTN_Help";
            this.BTN_Help.NeutralImage = global::TP1.Resource1.Neutral;
            this.BTN_Help.OverImage = global::TP1.Resource1.Over;
            this.BTN_Help.Size = new System.Drawing.Size(48, 41);
            this.BTN_Help.TabIndex = 11;
            this.BTN_Help.Text = "flashButton1";
            this.BTN_Help.Click += new System.EventHandler(this.BTN_Help_Click);
            // 
            // BTN_Effacer_Valeur
            // 
            this.BTN_Effacer_Valeur.BackgroundImage = global::TP1.Properties.Resources.ICON_Effacer_Neutral;
            this.BTN_Effacer_Valeur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Effacer_Valeur.ClickedImage = global::TP1.Properties.Resources.ICON_Effacer_Click;
            this.BTN_Effacer_Valeur.DisabledImage = global::TP1.Properties.Resources.ICON_Effacer_Disable;
            this.BTN_Effacer_Valeur.Enabled = false;
            this.BTN_Effacer_Valeur.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Effacer_Valeur.Image")));
            this.BTN_Effacer_Valeur.Location = new System.Drawing.Point(347, 268);
            this.BTN_Effacer_Valeur.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Effacer_Valeur.Name = "BTN_Effacer_Valeur";
            this.BTN_Effacer_Valeur.NeutralImage = global::TP1.Properties.Resources.ICON_Effacer_Neutral1;
            this.BTN_Effacer_Valeur.OverImage = global::TP1.Properties.Resources.ICON_Effacer_Over;
            this.BTN_Effacer_Valeur.Size = new System.Drawing.Size(48, 44);
            this.BTN_Effacer_Valeur.TabIndex = 10;
            this.BTN_Effacer_Valeur.Text = "flashButton1";
            this.BTN_Effacer_Valeur.Click += new System.EventHandler(this.BTN_Effacer_Valeur_Click);
            // 
            // BTN_Quitter_Unite
            // 
            this.BTN_Quitter_Unite.BackgroundImage = global::TP1.Properties.Resources.ICON_Annuler_Neutral;
            this.BTN_Quitter_Unite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Quitter_Unite.ClickedImage = global::TP1.Properties.Resources.ICON_Annuler_Click;
            this.BTN_Quitter_Unite.DisabledImage = global::TP1.Properties.Resources.ICON_Annuler_Disable;
            this.BTN_Quitter_Unite.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Quitter_Unite.Image")));
            this.BTN_Quitter_Unite.Location = new System.Drawing.Point(347, 450);
            this.BTN_Quitter_Unite.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Quitter_Unite.Name = "BTN_Quitter_Unite";
            this.BTN_Quitter_Unite.NeutralImage = global::TP1.Properties.Resources.ICON_Annuler_Neutral1;
            this.BTN_Quitter_Unite.OverImage = global::TP1.Properties.Resources.ICON_Annuler_Over;
            this.BTN_Quitter_Unite.Size = new System.Drawing.Size(44, 42);
            this.BTN_Quitter_Unite.TabIndex = 7;
            this.BTN_Quitter_Unite.Text = "flashButton1";
            this.BTN_Quitter_Unite.Click += new System.EventHandler(this.BTN_Quitter_Unite_Click);
            // 
            // BTN_Modify
            // 
            this.BTN_Modify.BackgroundImage = global::TP1.Resource1.Pencil_Neutre;
            this.BTN_Modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Modify.ClickedImage = global::TP1.Resource1.Pencil_Click;
            this.BTN_Modify.DisabledImage = global::TP1.Resource1.Pencil_Disable;
            this.BTN_Modify.Enabled = false;
            this.BTN_Modify.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Modify.Image")));
            this.BTN_Modify.Location = new System.Drawing.Point(351, 215);
            this.BTN_Modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Modify.Name = "BTN_Modify";
            this.BTN_Modify.NeutralImage = global::TP1.Resource1.Pencil_Neutre;
            this.BTN_Modify.OverImage = global::TP1.Resource1.Pencil_hover;
            this.BTN_Modify.Size = new System.Drawing.Size(36, 36);
            this.BTN_Modify.TabIndex = 3;
            this.BTN_Modify.Text = "flashButton2";
            this.BTN_Modify.Click += new System.EventHandler(this.BTN_Modify_Click);
            // 
            // BTN_AjouterUnite
            // 
            this.BTN_AjouterUnite.BackgroundImage = global::TP1.Resource1.ICON_Ajouter_Neutral;
            this.BTN_AjouterUnite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AjouterUnite.ClickedImage = global::TP1.Resource1.ICON_Ajouter_Click;
            this.BTN_AjouterUnite.DisabledImage = global::TP1.Resource1.ICON_Ajouter_Disable;
            this.BTN_AjouterUnite.Enabled = false;
            this.BTN_AjouterUnite.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AjouterUnite.Image")));
            this.BTN_AjouterUnite.Location = new System.Drawing.Point(347, 149);
            this.BTN_AjouterUnite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_AjouterUnite.Name = "BTN_AjouterUnite";
            this.BTN_AjouterUnite.NeutralImage = global::TP1.Resource1.ICON_Ajouter_Neutral;
            this.BTN_AjouterUnite.OverImage = global::TP1.Resource1.ICON_Ajouter_Over;
            this.BTN_AjouterUnite.Size = new System.Drawing.Size(49, 49);
            this.BTN_AjouterUnite.TabIndex = 2;
            this.BTN_AjouterUnite.Text = "flashButton1";
            this.BTN_AjouterUnite.Click += new System.EventHandler(this.BTN_AjouterUnite_Click);
            // 
            // Unite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 505);
            this.Controls.Add(this.BTN_Help);
            this.Controls.Add(this.BTN_Effacer_Valeur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Quitter_Unite);
            this.Controls.Add(this.BTN_Modify);
            this.Controls.Add(this.BTN_AjouterUnite);
            this.Controls.Add(this.GroupBox_Change_Unit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Unite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer unité de mesure";
            this.Load += new System.EventHandler(this.Unite_Load);
            this.GroupBox_Change_Unit.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Change_Unit;
        private Calculator.FlashButton BTN_AjouterUnite;
        private Calculator.FlashButton BTN_Modify;
        private Calculator.FlashButton BTN_Quitter_Unite;
        private System.Windows.Forms.RadioButton GRadioButton_Distance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GRadioButton_Poids;
        private System.Windows.Forms.RadioButton GRadioButton_Volume;
        private Calculator.FlashButton BTN_Effacer_Valeur;
        private System.Windows.Forms.ListBox LBX_GererUniteMesure;
        private Calculator.FlashButton BTN_Help;
    }
}