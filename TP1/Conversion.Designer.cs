namespace TP1
{
    partial class Conversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversion));
            this.GroupBox_UniteMesure = new System.Windows.Forms.GroupBox();
            this.RadioButton_Poids = new System.Windows.Forms.RadioButton();
            this.RadioButton_Volume = new System.Windows.Forms.RadioButton();
            this.RadioButton_Distance = new System.Windows.Forms.RadioButton();
            this.GBox_Start = new System.Windows.Forms.GroupBox();
            this.LBX_Start = new System.Windows.Forms.ListBox();
            this.TextBox_Depart = new System.Windows.Forms.TextBox();
            this.GroupBox_Convertir_Valeur = new System.Windows.Forms.GroupBox();
            this.BTN_Effacer_Valeur = new Calculator.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Convertir_Valeur = new Calculator.FlashButton();
            this.TextBox_Convertie = new System.Windows.Forms.TextBox();
            this.LBX_End = new System.Windows.Forms.ListBox();
            this.GBox_End = new System.Windows.Forms.GroupBox();
            this.BTN_Quitter_Conversion = new Calculator.FlashButton();
            this.GroupBox_UniteMesure.SuspendLayout();
            this.GBox_Start.SuspendLayout();
            this.GroupBox_Convertir_Valeur.SuspendLayout();
            this.GBox_End.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_UniteMesure
            // 
            this.GroupBox_UniteMesure.Controls.Add(this.RadioButton_Poids);
            this.GroupBox_UniteMesure.Controls.Add(this.RadioButton_Volume);
            this.GroupBox_UniteMesure.Controls.Add(this.RadioButton_Distance);
            this.GroupBox_UniteMesure.Enabled = false;
            this.GroupBox_UniteMesure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_UniteMesure.Location = new System.Drawing.Point(16, 15);
            this.GroupBox_UniteMesure.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_UniteMesure.Name = "GroupBox_UniteMesure";
            this.GroupBox_UniteMesure.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_UniteMesure.Size = new System.Drawing.Size(310, 66);
            this.GroupBox_UniteMesure.TabIndex = 0;
            this.GroupBox_UniteMesure.TabStop = false;
            this.GroupBox_UniteMesure.Text = "Type de mesure";
            // 
            // RadioButton_Poids
            // 
            this.RadioButton_Poids.AutoSize = true;
            this.RadioButton_Poids.Location = new System.Drawing.Point(215, 23);
            this.RadioButton_Poids.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Poids.Name = "RadioButton_Poids";
            this.RadioButton_Poids.Size = new System.Drawing.Size(78, 28);
            this.RadioButton_Poids.TabIndex = 2;
            this.RadioButton_Poids.Text = "Poids";
            this.RadioButton_Poids.UseVisualStyleBackColor = true;
            this.RadioButton_Poids.CheckedChanged += new System.EventHandler(this.BTN_Poids_CheckedChanged);
            // 
            // RadioButton_Volume
            // 
            this.RadioButton_Volume.AutoSize = true;
            this.RadioButton_Volume.Location = new System.Drawing.Point(117, 23);
            this.RadioButton_Volume.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Volume.Name = "RadioButton_Volume";
            this.RadioButton_Volume.Size = new System.Drawing.Size(97, 28);
            this.RadioButton_Volume.TabIndex = 1;
            this.RadioButton_Volume.Text = "Volume";
            this.RadioButton_Volume.UseVisualStyleBackColor = true;
            this.RadioButton_Volume.CheckedChanged += new System.EventHandler(this.BTN_Volume_CheckedChanged);
            // 
            // RadioButton_Distance
            // 
            this.RadioButton_Distance.AutoSize = true;
            this.RadioButton_Distance.Checked = true;
            this.RadioButton_Distance.Location = new System.Drawing.Point(8, 23);
            this.RadioButton_Distance.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Distance.Name = "RadioButton_Distance";
            this.RadioButton_Distance.Size = new System.Drawing.Size(103, 28);
            this.RadioButton_Distance.TabIndex = 0;
            this.RadioButton_Distance.TabStop = true;
            this.RadioButton_Distance.Text = "Distance";
            this.RadioButton_Distance.UseVisualStyleBackColor = true;
            this.RadioButton_Distance.CheckedChanged += new System.EventHandler(this.BTN_Distance_CheckedChanged);
            // 
            // GBox_Start
            // 
            this.GBox_Start.Controls.Add(this.LBX_Start);
            this.GBox_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_Start.Location = new System.Drawing.Point(354, 15);
            this.GBox_Start.Margin = new System.Windows.Forms.Padding(4);
            this.GBox_Start.Name = "GBox_Start";
            this.GBox_Start.Padding = new System.Windows.Forms.Padding(4);
            this.GBox_Start.Size = new System.Drawing.Size(208, 264);
            this.GBox_Start.TabIndex = 1;
            this.GBox_Start.TabStop = false;
            this.GBox_Start.Text = "Unité de départ";
            // 
            // LBX_Start
            // 
            this.LBX_Start.FormattingEnabled = true;
            this.LBX_Start.ItemHeight = 22;
            this.LBX_Start.Location = new System.Drawing.Point(8, 32);
            this.LBX_Start.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_Start.Name = "LBX_Start";
            this.LBX_Start.Size = new System.Drawing.Size(192, 224);
            this.LBX_Start.TabIndex = 0;
            this.LBX_Start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LBX_Start_KeyPress);
            // 
            // TextBox_Depart
            // 
            this.TextBox_Depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Depart.Location = new System.Drawing.Point(12, 48);
            this.TextBox_Depart.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Depart.Multiline = true;
            this.TextBox_Depart.Name = "TextBox_Depart";
            this.TextBox_Depart.Size = new System.Drawing.Size(290, 30);
            this.TextBox_Depart.TabIndex = 3;
            this.TextBox_Depart.TextChanged += new System.EventHandler(this.TextBox_Depart_TextChanged);
            this.TextBox_Depart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Depart_KeyDown);
            this.TextBox_Depart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXValeur_Depart_KeyPress);
            this.TextBox_Depart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Depart_KeyUp);
            // 
            // GroupBox_Convertir_Valeur
            // 
            this.GroupBox_Convertir_Valeur.Controls.Add(this.BTN_Effacer_Valeur);
            this.GroupBox_Convertir_Valeur.Controls.Add(this.label2);
            this.GroupBox_Convertir_Valeur.Controls.Add(this.label1);
            this.GroupBox_Convertir_Valeur.Controls.Add(this.BTN_Convertir_Valeur);
            this.GroupBox_Convertir_Valeur.Controls.Add(this.TextBox_Convertie);
            this.GroupBox_Convertir_Valeur.Controls.Add(this.TextBox_Depart);
            this.GroupBox_Convertir_Valeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Convertir_Valeur.Location = new System.Drawing.Point(16, 100);
            this.GroupBox_Convertir_Valeur.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_Convertir_Valeur.Name = "GroupBox_Convertir_Valeur";
            this.GroupBox_Convertir_Valeur.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_Convertir_Valeur.Size = new System.Drawing.Size(310, 247);
            this.GroupBox_Convertir_Valeur.TabIndex = 4;
            this.GroupBox_Convertir_Valeur.TabStop = false;
            this.GroupBox_Convertir_Valeur.Text = "Convertir";
            // 
            // BTN_Effacer_Valeur
            // 
            this.BTN_Effacer_Valeur.BackgroundImage = global::TP1.Properties.Resources.ICON_Effacer_Neutral;
            this.BTN_Effacer_Valeur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Effacer_Valeur.ClickedImage = global::TP1.Properties.Resources.ICON_Effacer_Click;
            this.BTN_Effacer_Valeur.DisabledImage = global::TP1.Properties.Resources.ICON_Effacer_Disable;
            this.BTN_Effacer_Valeur.Enabled = false;
            this.BTN_Effacer_Valeur.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Effacer_Valeur.Image")));
            this.BTN_Effacer_Valeur.Location = new System.Drawing.Point(182, 116);
            this.BTN_Effacer_Valeur.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Effacer_Valeur.Name = "BTN_Effacer_Valeur";
            this.BTN_Effacer_Valeur.NeutralImage = global::TP1.Properties.Resources.ICON_Effacer_Neutral1;
            this.BTN_Effacer_Valeur.OverImage = global::TP1.Properties.Resources.ICON_Effacer_Over;
            this.BTN_Effacer_Valeur.Size = new System.Drawing.Size(48, 44);
            this.BTN_Effacer_Valeur.TabIndex = 9;
            this.BTN_Effacer_Valeur.Text = "flashButton1";
            this.BTN_Effacer_Valeur.Click += new System.EventHandler(this.BTN_Effacer_Valeur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valeur de départ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valeur convertie";
            // 
            // BTN_Convertir_Valeur
            // 
            this.BTN_Convertir_Valeur.BackgroundImage = global::TP1.Properties.Resources.ICON_Accepter_Neutral;
            this.BTN_Convertir_Valeur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Convertir_Valeur.ClickedImage = global::TP1.Properties.Resources.ICON_Accepter_Click;
            this.BTN_Convertir_Valeur.DisabledImage = global::TP1.Properties.Resources.ICON_Accepter_Disable;
            this.BTN_Convertir_Valeur.Enabled = false;
            this.BTN_Convertir_Valeur.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Convertir_Valeur.Image")));
            this.BTN_Convertir_Valeur.Location = new System.Drawing.Point(63, 116);
            this.BTN_Convertir_Valeur.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Convertir_Valeur.Name = "BTN_Convertir_Valeur";
            this.BTN_Convertir_Valeur.NeutralImage = global::TP1.Properties.Resources.ICON_Accepter_Neutral1;
            this.BTN_Convertir_Valeur.OverImage = global::TP1.Properties.Resources.ICON_Accepter_Over;
            this.BTN_Convertir_Valeur.Size = new System.Drawing.Size(48, 44);
            this.BTN_Convertir_Valeur.TabIndex = 5;
            this.BTN_Convertir_Valeur.Text = "flashButton1";
            this.BTN_Convertir_Valeur.Click += new System.EventHandler(this.BTN_Convertir_Valeur_Click);
            // 
            // TextBox_Convertie
            // 
            this.TextBox_Convertie.Location = new System.Drawing.Point(9, 203);
            this.TextBox_Convertie.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Convertie.Multiline = true;
            this.TextBox_Convertie.Name = "TextBox_Convertie";
            this.TextBox_Convertie.ReadOnly = true;
            this.TextBox_Convertie.Size = new System.Drawing.Size(293, 30);
            this.TextBox_Convertie.TabIndex = 4;
            // 
            // LBX_End
            // 
            this.LBX_End.FormattingEnabled = true;
            this.LBX_End.ItemHeight = 22;
            this.LBX_End.Location = new System.Drawing.Point(8, 32);
            this.LBX_End.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_End.Name = "LBX_End";
            this.LBX_End.Size = new System.Drawing.Size(194, 224);
            this.LBX_End.TabIndex = 1;
            this.LBX_End.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LBX_End_KeyPress);
            // 
            // GBox_End
            // 
            this.GBox_End.Controls.Add(this.LBX_End);
            this.GBox_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_End.Location = new System.Drawing.Point(570, 15);
            this.GBox_End.Margin = new System.Windows.Forms.Padding(4);
            this.GBox_End.Name = "GBox_End";
            this.GBox_End.Padding = new System.Windows.Forms.Padding(4);
            this.GBox_End.Size = new System.Drawing.Size(210, 264);
            this.GBox_End.TabIndex = 2;
            this.GBox_End.TabStop = false;
            this.GBox_End.Text = "Unité de conversion";
            // 
            // BTN_Quitter_Conversion
            // 
            this.BTN_Quitter_Conversion.BackgroundImage = global::TP1.Properties.Resources.ICON_Annuler_Neutral;
            this.BTN_Quitter_Conversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Quitter_Conversion.ClickedImage = global::TP1.Properties.Resources.ICON_Annuler_Click;
            this.BTN_Quitter_Conversion.DisabledImage = global::TP1.Properties.Resources.ICON_Annuler_Disable;
            this.BTN_Quitter_Conversion.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Quitter_Conversion.Image")));
            this.BTN_Quitter_Conversion.Location = new System.Drawing.Point(732, 309);
            this.BTN_Quitter_Conversion.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Quitter_Conversion.Name = "BTN_Quitter_Conversion";
            this.BTN_Quitter_Conversion.NeutralImage = global::TP1.Properties.Resources.ICON_Annuler_Neutral1;
            this.BTN_Quitter_Conversion.OverImage = global::TP1.Properties.Resources.ICON_Annuler_Over;
            this.BTN_Quitter_Conversion.Size = new System.Drawing.Size(48, 44);
            this.BTN_Quitter_Conversion.TabIndex = 7;
            this.BTN_Quitter_Conversion.Text = "flashButton1";
            this.BTN_Quitter_Conversion.Click += new System.EventHandler(this.BTN_Quitter_Conversion_Click);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 366);
            this.Controls.Add(this.BTN_Quitter_Conversion);
            this.Controls.Add(this.GroupBox_Convertir_Valeur);
            this.Controls.Add(this.GBox_End);
            this.Controls.Add(this.GBox_Start);
            this.Controls.Add(this.GroupBox_UniteMesure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXValeur_Depart_KeyPress);
            this.GroupBox_UniteMesure.ResumeLayout(false);
            this.GroupBox_UniteMesure.PerformLayout();
            this.GBox_Start.ResumeLayout(false);
            this.GroupBox_Convertir_Valeur.ResumeLayout(false);
            this.GroupBox_Convertir_Valeur.PerformLayout();
            this.GBox_End.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_UniteMesure;
        private System.Windows.Forms.RadioButton RadioButton_Poids;
        private System.Windows.Forms.RadioButton RadioButton_Volume;
        private System.Windows.Forms.RadioButton RadioButton_Distance;
        private System.Windows.Forms.GroupBox GBox_Start;
        private System.Windows.Forms.ListBox LBX_Start;
        private System.Windows.Forms.TextBox TextBox_Depart;
        private System.Windows.Forms.GroupBox GroupBox_Convertir_Valeur;
        private Calculator.FlashButton BTN_Convertir_Valeur;
        private System.Windows.Forms.TextBox TextBox_Convertie;
        private System.Windows.Forms.ListBox LBX_End;
        private System.Windows.Forms.GroupBox GBox_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Calculator.FlashButton BTN_Effacer_Valeur;
        private Calculator.FlashButton BTN_Quitter_Conversion;
    }
}