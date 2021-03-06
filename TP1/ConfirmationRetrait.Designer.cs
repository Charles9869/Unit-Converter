﻿namespace TP1
{
    partial class ConfirmationRetrait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationRetrait));
            this.GroupBox_UniteMesure = new System.Windows.Forms.GroupBox();
            this.RadioButton_Poids = new System.Windows.Forms.RadioButton();
            this.RadioButton_Volume = new System.Windows.Forms.RadioButton();
            this.RadioButton_Distance = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_TypeMesure = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_ValeurMetrique = new System.Windows.Forms.TextBox();
            this.BTN_Quitter = new Calculator.FlashButton();
            this.BTN_Confirmer_Retrait = new Calculator.FlashButton();
            this.GroupBox_UniteMesure.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_UniteMesure
            // 
            this.GroupBox_UniteMesure.Controls.Add(this.RadioButton_Poids);
            this.GroupBox_UniteMesure.Controls.Add(this.RadioButton_Volume);
            this.GroupBox_UniteMesure.Controls.Add(this.RadioButton_Distance);
            this.GroupBox_UniteMesure.Enabled = false;
            this.GroupBox_UniteMesure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_UniteMesure.Location = new System.Drawing.Point(52, 13);
            this.GroupBox_UniteMesure.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_UniteMesure.Name = "GroupBox_UniteMesure";
            this.GroupBox_UniteMesure.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_UniteMesure.Size = new System.Drawing.Size(310, 66);
            this.GroupBox_UniteMesure.TabIndex = 9;
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
            this.RadioButton_Poids.TabStop = true;
            this.RadioButton_Poids.Text = "Poids";
            this.RadioButton_Poids.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Volume
            // 
            this.RadioButton_Volume.AutoSize = true;
            this.RadioButton_Volume.Location = new System.Drawing.Point(117, 23);
            this.RadioButton_Volume.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Volume.Name = "RadioButton_Volume";
            this.RadioButton_Volume.Size = new System.Drawing.Size(97, 28);
            this.RadioButton_Volume.TabIndex = 1;
            this.RadioButton_Volume.TabStop = true;
            this.RadioButton_Volume.Text = "Volume";
            this.RadioButton_Volume.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Distance
            // 
            this.RadioButton_Distance.AutoSize = true;
            this.RadioButton_Distance.Location = new System.Drawing.Point(6, 23);
            this.RadioButton_Distance.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Distance.Name = "RadioButton_Distance";
            this.RadioButton_Distance.Size = new System.Drawing.Size(103, 28);
            this.RadioButton_Distance.TabIndex = 0;
            this.RadioButton_Distance.Text = "Distance";
            this.RadioButton_Distance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_TypeMesure);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(310, 64);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nom de l\'unité";
            // 
            // TextBox_TypeMesure
            // 
            this.TextBox_TypeMesure.Location = new System.Drawing.Point(7, 28);
            this.TextBox_TypeMesure.Multiline = true;
            this.TextBox_TypeMesure.Name = "TextBox_TypeMesure";
            this.TextBox_TypeMesure.ReadOnly = true;
            this.TextBox_TypeMesure.Size = new System.Drawing.Size(296, 29);
            this.TextBox_TypeMesure.TabIndex = 0;
            this.TextBox_TypeMesure.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_TypeMesure_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_ValeurMetrique);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(310, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valeur métrique";
            // 
            // TextBox_ValeurMetrique
            // 
            this.TextBox_ValeurMetrique.Location = new System.Drawing.Point(7, 24);
            this.TextBox_ValeurMetrique.Multiline = true;
            this.TextBox_ValeurMetrique.Name = "TextBox_ValeurMetrique";
            this.TextBox_ValeurMetrique.ReadOnly = true;
            this.TextBox_ValeurMetrique.Size = new System.Drawing.Size(296, 29);
            this.TextBox_ValeurMetrique.TabIndex = 1;
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.BackgroundImage = global::TP1.Properties.Resources.ICON_Annuler_Neutral;
            this.BTN_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Quitter.ClickedImage = global::TP1.Properties.Resources.ICON_Annuler_Click;
            this.BTN_Quitter.DisabledImage = global::TP1.Properties.Resources.ICON_Annuler_Disable;
            this.BTN_Quitter.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Quitter.Image")));
            this.BTN_Quitter.Location = new System.Drawing.Point(224, 238);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.NeutralImage = global::TP1.Properties.Resources.ICON_Annuler_Neutral1;
            this.BTN_Quitter.OverImage = global::TP1.Properties.Resources.ICON_Annuler_Over;
            this.BTN_Quitter.Size = new System.Drawing.Size(48, 44);
            this.BTN_Quitter.TabIndex = 8;
            this.BTN_Quitter.Text = "flashButton1";
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // BTN_Confirmer_Retrait
            // 
            this.BTN_Confirmer_Retrait.BackgroundImage = global::TP1.Properties.Resources.ICON_Accepter_Neutral;
            this.BTN_Confirmer_Retrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Confirmer_Retrait.ClickedImage = global::TP1.Properties.Resources.ICON_Accepter_Click;
            this.BTN_Confirmer_Retrait.DisabledImage = global::TP1.Properties.Resources.ICON_Accepter_Disable;
            this.BTN_Confirmer_Retrait.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Confirmer_Retrait.Image")));
            this.BTN_Confirmer_Retrait.Location = new System.Drawing.Point(129, 238);
            this.BTN_Confirmer_Retrait.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Confirmer_Retrait.Name = "BTN_Confirmer_Retrait";
            this.BTN_Confirmer_Retrait.NeutralImage = global::TP1.Properties.Resources.ICON_Accepter_Neutral1;
            this.BTN_Confirmer_Retrait.OverImage = global::TP1.Properties.Resources.ICON_Accepter_Over;
            this.BTN_Confirmer_Retrait.Size = new System.Drawing.Size(48, 44);
            this.BTN_Confirmer_Retrait.TabIndex = 7;
            this.BTN_Confirmer_Retrait.Text = "flashButton1";
            this.BTN_Confirmer_Retrait.Click += new System.EventHandler(this.BTN_Confirmer_Retrait_Click);
            // 
            // ConfirmationRetrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_UniteMesure);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Confirmer_Retrait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfirmationRetrait";
            this.Text = "Confirmation de la valeur à effacer...";
            this.Load += new System.EventHandler(this.ConfirmationRetrait_Load);
            this.GroupBox_UniteMesure.ResumeLayout(false);
            this.GroupBox_UniteMesure.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Calculator.FlashButton BTN_Confirmer_Retrait;
        private Calculator.FlashButton BTN_Quitter;
        private System.Windows.Forms.GroupBox GroupBox_UniteMesure;
        private System.Windows.Forms.RadioButton RadioButton_Poids;
        private System.Windows.Forms.RadioButton RadioButton_Volume;
        private System.Windows.Forms.RadioButton RadioButton_Distance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox_TypeMesure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_ValeurMetrique;
    }
}