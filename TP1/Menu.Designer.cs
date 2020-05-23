namespace TP1
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Menu_List = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerUneConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fdsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BTN_Demarrer_Conversion = new Calculator.FlashButton();
            this.BTN_Modifier_Unit = new Calculator.FlashButton();
            this.BTN_Quitter = new Calculator.FlashButton();
            this.menuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_List});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(516, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Menu_List
            // 
            this.Menu_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectuerUneConversionToolStripMenuItem,
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem,
            this.quitterAltF4ToolStripMenuItem});
            this.Menu_List.Name = "Menu_List";
            this.Menu_List.Size = new System.Drawing.Size(58, 24);
            this.Menu_List.Text = "Menu";
            // 
            // effectuerUneConversionToolStripMenuItem
            // 
            this.effectuerUneConversionToolStripMenuItem.Name = "effectuerUneConversionToolStripMenuItem";
            this.effectuerUneConversionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.effectuerUneConversionToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.effectuerUneConversionToolStripMenuItem.Text = "Effectuer une conversion ";
            this.effectuerUneConversionToolStripMenuItem.Click += new System.EventHandler(this.effectuerUneConversionToolStripMenuItem_Click);
            // 
            // gérerLesUnitésDeMesureAltGToolStripMenuItem
            // 
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem.Name = "gérerLesUnitésDeMesureAltGToolStripMenuItem";
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem.Text = "Gérer les unités de mesure";
            this.gérerLesUnitésDeMesureAltGToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUnitésDeMesureAltGToolStripMenuItem_Click);
            // 
            // quitterAltF4ToolStripMenuItem
            // 
            this.quitterAltF4ToolStripMenuItem.Name = "quitterAltF4ToolStripMenuItem";
            this.quitterAltF4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterAltF4ToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.quitterAltF4ToolStripMenuItem.Text = "Quitter";
            this.quitterAltF4ToolStripMenuItem.Click += new System.EventHandler(this.quitterAltF4ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dasdToolStripMenuItem,
            this.dsaToolStripMenuItem,
            this.dsaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 76);
            // 
            // dasdToolStripMenuItem
            // 
            this.dasdToolStripMenuItem.Name = "dasdToolStripMenuItem";
            this.dasdToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.dasdToolStripMenuItem.Text = "dasd";
            // 
            // dsaToolStripMenuItem
            // 
            this.dsaToolStripMenuItem.Name = "dsaToolStripMenuItem";
            this.dsaToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.dsaToolStripMenuItem.Text = "dsa";
            // 
            // dsaToolStripMenuItem1
            // 
            this.dsaToolStripMenuItem1.Name = "dsaToolStripMenuItem1";
            this.dsaToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.dsaToolStripMenuItem1.Text = "dsa";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdsToolStripMenuItem,
            this.fdsToolStripMenuItem1,
            this.fdsToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(99, 76);
            // 
            // fdsToolStripMenuItem
            // 
            this.fdsToolStripMenuItem.Name = "fdsToolStripMenuItem";
            this.fdsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.fdsToolStripMenuItem.Text = "fds";
            // 
            // fdsToolStripMenuItem1
            // 
            this.fdsToolStripMenuItem1.Name = "fdsToolStripMenuItem1";
            this.fdsToolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.fdsToolStripMenuItem1.Text = "fds";
            // 
            // fdsToolStripMenuItem2
            // 
            this.fdsToolStripMenuItem2.Name = "fdsToolStripMenuItem2";
            this.fdsToolStripMenuItem2.Size = new System.Drawing.Size(98, 24);
            this.fdsToolStripMenuItem2.Text = "fds";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // BTN_Demarrer_Conversion
            // 
            this.BTN_Demarrer_Conversion.BackgroundImage = global::TP1.Properties.Resources.Quitter_Neutral;
            this.BTN_Demarrer_Conversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Demarrer_Conversion.ClickedImage = global::TP1.Resource1.Quitter_Click;
            this.BTN_Demarrer_Conversion.DisabledImage = global::TP1.Resource1.Quitter_Disable;
            this.BTN_Demarrer_Conversion.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Demarrer_Conversion.Image")));
            this.BTN_Demarrer_Conversion.Location = new System.Drawing.Point(28, 51);
            this.BTN_Demarrer_Conversion.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Demarrer_Conversion.Name = "BTN_Demarrer_Conversion";
            this.BTN_Demarrer_Conversion.NeutralImage = global::TP1.Resource1.Quitter_Neutral;
            this.BTN_Demarrer_Conversion.OverImage = global::TP1.Resource1.Quitter_Over;
            this.BTN_Demarrer_Conversion.Size = new System.Drawing.Size(112, 102);
            this.BTN_Demarrer_Conversion.TabIndex = 6;
            this.BTN_Demarrer_Conversion.Text = "flashButton3";
            this.BTN_Demarrer_Conversion.Click += new System.EventHandler(this.BTN_Demarrer_Conversion_Click);
            // 
            // BTN_Modifier_Unit
            // 
            this.BTN_Modifier_Unit.BackgroundImage = global::TP1.Resource1.Pencil_Neutre;
            this.BTN_Modifier_Unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Modifier_Unit.ClickedImage = global::TP1.Resource1.Pencil_Click;
            this.BTN_Modifier_Unit.DisabledImage = global::TP1.Resource1.Pencil_Disable;
            this.BTN_Modifier_Unit.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Modifier_Unit.Image")));
            this.BTN_Modifier_Unit.Location = new System.Drawing.Point(191, 51);
            this.BTN_Modifier_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Modifier_Unit.Name = "BTN_Modifier_Unit";
            this.BTN_Modifier_Unit.NeutralImage = global::TP1.Resource1.Pencil_Neutre;
            this.BTN_Modifier_Unit.OverImage = global::TP1.Resource1.Pencil_hover;
            this.BTN_Modifier_Unit.Size = new System.Drawing.Size(124, 102);
            this.BTN_Modifier_Unit.TabIndex = 5;
            this.BTN_Modifier_Unit.Text = "flashButton2";
            this.BTN_Modifier_Unit.Click += new System.EventHandler(this.BTN_Modifier_Unit_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.BackgroundImage = global::TP1.Resource1.ICON2_Neutre;
            this.BTN_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Quitter.ClickedImage = global::TP1.Resource1.ICON2_Click;
            this.BTN_Quitter.DisabledImage = global::TP1.Resource1.ICON2_Disable;
            this.BTN_Quitter.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Quitter.Image")));
            this.BTN_Quitter.Location = new System.Drawing.Point(359, 37);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.NeutralImage = global::TP1.Resource1.ICON2_Neutre;
            this.BTN_Quitter.OverImage = global::TP1.Resource1.ICON2_hover;
            this.BTN_Quitter.Size = new System.Drawing.Size(144, 131);
            this.BTN_Quitter.TabIndex = 4;
            this.BTN_Quitter.Text = "flashButton1";
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 169);
            this.Controls.Add(this.BTN_Demarrer_Conversion);
            this.Controls.Add(this.BTN_Modifier_Unit);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion d\'unité";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fdsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Menu_List;
        private System.Windows.Forms.ToolStripMenuItem effectuerUneConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesUnitésDeMesureAltGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterAltF4ToolStripMenuItem;
        private Calculator.FlashButton BTN_Quitter;
        private Calculator.FlashButton BTN_Modifier_Unit;
        private Calculator.FlashButton BTN_Demarrer_Conversion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}

