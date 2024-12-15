
namespace Q2_Fichier_Texte
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierViderGrilles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierLireNoms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierLireSalaires = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSéparateur = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierEnregistrerNoms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrerSalaires = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFichierLireComplet = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFichierEnregistrerComplet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialAugmenterSalairesDe500 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialDiminuerSalairesDe250 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSpécialNomsEnMajuscules = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsaGrilleNoms = new VisualArrays.VisualStringArray();
            this.lblNoms = new System.Windows.Forms.Label();
            this.vdaGrilleSalaires = new VisualArrays.VisualDecimalArray();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpécial});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuPrincipal";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierViderGrilles,
            this.toolStripMenuItem2,
            this.mnuFichierLireNoms,
            this.mnuFichierLireSalaires,
            this.mnuFichierSéparateur,
            this.mnuFichierEnregistrerNoms,
            this.mnuFichierEnregistrerSalaires,
            this.toolStripMenuItem4,
            this.MnuFichierLireComplet,
            this.MnuFichierEnregistrerComplet,
            this.toolStripMenuItem1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierViderGrilles
            // 
            this.mnuFichierViderGrilles.Name = "mnuFichierViderGrilles";
            this.mnuFichierViderGrilles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierViderGrilles.Size = new System.Drawing.Size(293, 22);
            this.mnuFichierViderGrilles.Text = "Vider les grilles";
            this.mnuFichierViderGrilles.Click += new System.EventHandler(this.mnuFichierViderGrilles_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(290, 6);
            // 
            // mnuFichierLireNoms
            // 
            this.mnuFichierLireNoms.Name = "mnuFichierLireNoms";
            this.mnuFichierLireNoms.Size = new System.Drawing.Size(293, 22);
            this.mnuFichierLireNoms.Text = "Lire et afficher \"Noms.txt\"";
            this.mnuFichierLireNoms.Click += new System.EventHandler(this.MnuFichierLireNoms_Click);
            // 
            // mnuFichierLireSalaires
            // 
            this.mnuFichierLireSalaires.Name = "mnuFichierLireSalaires";
            this.mnuFichierLireSalaires.Size = new System.Drawing.Size(293, 22);
            this.mnuFichierLireSalaires.Text = "Lire et afficher \"Salaires.txt\"";
            this.mnuFichierLireSalaires.Click += new System.EventHandler(this.MnuFichierLireSalaires_Click);
            // 
            // mnuFichierSéparateur
            // 
            this.mnuFichierSéparateur.Name = "mnuFichierSéparateur";
            this.mnuFichierSéparateur.Size = new System.Drawing.Size(290, 6);
            // 
            // mnuFichierEnregistrerNoms
            // 
            this.mnuFichierEnregistrerNoms.Name = "mnuFichierEnregistrerNoms";
            this.mnuFichierEnregistrerNoms.Size = new System.Drawing.Size(293, 22);
            this.mnuFichierEnregistrerNoms.Text = "Enregister \"Noms.txt\"";
            this.mnuFichierEnregistrerNoms.Click += new System.EventHandler(this.mnuFichierEnregistrerNoms_Click);
            // 
            // mnuFichierEnregistrerSalaires
            // 
            this.mnuFichierEnregistrerSalaires.Name = "mnuFichierEnregistrerSalaires";
            this.mnuFichierEnregistrerSalaires.Size = new System.Drawing.Size(293, 22);
            this.mnuFichierEnregistrerSalaires.Text = "Enregistrer \"Salaires.txt\"";
            this.mnuFichierEnregistrerSalaires.Click += new System.EventHandler(this.mnuFichierEnregistrerSalaires_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(290, 6);
            // 
            // MnuFichierLireComplet
            // 
            this.MnuFichierLireComplet.Name = "MnuFichierLireComplet";
            this.MnuFichierLireComplet.Size = new System.Drawing.Size(293, 22);
            this.MnuFichierLireComplet.Text = "Lire noms et salaires \"Complet.txt\"";
            this.MnuFichierLireComplet.Click += new System.EventHandler(this.MnuFichierLireComplet_Click);
            // 
            // MnuFichierEnregistrerComplet
            // 
            this.MnuFichierEnregistrerComplet.Name = "MnuFichierEnregistrerComplet";
            this.MnuFichierEnregistrerComplet.Size = new System.Drawing.Size(293, 22);
            this.MnuFichierEnregistrerComplet.Text = "Enregistrer noms et salaires \"Complet.txt\"";
            this.MnuFichierEnregistrerComplet.Click += new System.EventHandler(this.MnuFichierEnregistrerComplet_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(293, 22);
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpécialAugmenterSalairesDe500,
            this.mnuSpécialDiminuerSalairesDe250,
            this.toolStripMenuItem3,
            this.mnuSpécialNomsEnMajuscules,
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpécial.Text = "Spécial";
            // 
            // mnuSpécialAugmenterSalairesDe500
            // 
            this.mnuSpécialAugmenterSalairesDe500.Name = "mnuSpécialAugmenterSalairesDe500";
            this.mnuSpécialAugmenterSalairesDe500.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.mnuSpécialAugmenterSalairesDe500.Size = new System.Drawing.Size(357, 22);
            this.mnuSpécialAugmenterSalairesDe500.Text = "Augmenter tous les salaires de 500$";
            this.mnuSpécialAugmenterSalairesDe500.Click += new System.EventHandler(this.MnuSpécialAugmenterSalairesDe500_Click);
            // 
            // mnuSpécialDiminuerSalairesDe250
            // 
            this.mnuSpécialDiminuerSalairesDe250.Name = "mnuSpécialDiminuerSalairesDe250";
            this.mnuSpécialDiminuerSalairesDe250.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.mnuSpécialDiminuerSalairesDe250.Size = new System.Drawing.Size(357, 22);
            this.mnuSpécialDiminuerSalairesDe250.Text = "Diminuer tous les salaires de 250$";
            this.mnuSpécialDiminuerSalairesDe250.Click += new System.EventHandler(this.MnuSpécialDiminuerSalairesDe250_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(354, 6);
            // 
            // mnuSpécialNomsEnMajuscules
            // 
            this.mnuSpécialNomsEnMajuscules.Name = "mnuSpécialNomsEnMajuscules";
            this.mnuSpécialNomsEnMajuscules.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Up)));
            this.mnuSpécialNomsEnMajuscules.Size = new System.Drawing.Size(357, 22);
            this.mnuSpécialNomsEnMajuscules.Text = "Mettre tous les noms en majuscules";
            this.mnuSpécialNomsEnMajuscules.Click += new System.EventHandler(this.MnuSpécialNomsEnMajuscules_Click);
            // 
            // mettreTousLesNomsEnMinusculesToolStripMenuItem
            // 
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem.Name = "mettreTousLesNomsEnMinusculesToolStripMenuItem";
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Down)));
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem.Text = "Mettre tous les noms en minuscules";
            this.mettreTousLesNomsEnMinusculesToolStripMenuItem.Click += new System.EventHandler(this.mettreTousLesNomsEnMinusculesToolStripMenuItem_Click);
            // 
            // vsaGrilleNoms
            // 
            this.vsaGrilleNoms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vsaGrilleNoms.CellContentAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.vsaGrilleNoms.CellMargin = 8;
            this.vsaGrilleNoms.CellSize = new System.Drawing.Size(228, 26);
            this.vsaGrilleNoms.ColumnCount = 1;
            this.vsaGrilleNoms.DefaultValue = "";
            this.vsaGrilleNoms.DisabledAppearance.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.vsaGrilleNoms.DisabledAppearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaGrilleNoms.DisabledAppearance.StrikeAppearance.Color = System.Drawing.Color.Teal;
            this.vsaGrilleNoms.DisabledAppearance.StrikeAppearance.PenWidth = 2;
            this.vsaGrilleNoms.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vsaGrilleNoms.DisabledAppearance.TextColor = System.Drawing.Color.Gainsboro;
            this.vsaGrilleNoms.EnabledAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaGrilleNoms.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.vsaGrilleNoms.EnabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsaGrilleNoms.GridAppearance.Color = System.Drawing.Color.Silver;
            this.vsaGrilleNoms.Location = new System.Drawing.Point(17, 85);
            this.vsaGrilleNoms.MaxLength = 20;
            this.vsaGrilleNoms.Name = "vsaGrilleNoms";
            this.vsaGrilleNoms.Padding = new System.Windows.Forms.Padding(2);
            this.vsaGrilleNoms.RowCount = 5;
            this.vsaGrilleNoms.RowHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.vsaGrilleNoms.RowHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaGrilleNoms.RowHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsaGrilleNoms.RowHeader.ValueStyle = VisualArrays.enuDataStyle.IndexBase1;
            this.vsaGrilleNoms.RowHeader.Visible = true;
            this.vsaGrilleNoms.RowHeader.Width = 18;
            this.vsaGrilleNoms.SelectionAppearance.Color = System.Drawing.Color.DodgerBlue;
            this.vsaGrilleNoms.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2);
            this.vsaGrilleNoms.SelectionAppearance.PenWidth = 5;
            this.vsaGrilleNoms.Size = new System.Drawing.Size(268, 220);
            this.vsaGrilleNoms.TabIndex = 8;
            this.vsaGrilleNoms.Click += new System.EventHandler(this.vsaGrilleNoms_Click);
            // 
            // lblNoms
            // 
            this.lblNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoms.Location = new System.Drawing.Point(32, 62);
            this.lblNoms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoms.Name = "lblNoms";
            this.lblNoms.Size = new System.Drawing.Size(75, 19);
            this.lblNoms.TabIndex = 9;
            this.lblNoms.Text = "Noms :";
            // 
            // vdaGrilleSalaires
            // 
            this.vdaGrilleSalaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vdaGrilleSalaires.CellContentAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vdaGrilleSalaires.CellMargin = 8;
            this.vdaGrilleSalaires.CellSize = new System.Drawing.Size(101, 24);
            this.vdaGrilleSalaires.ColumnCount = 1;
            this.vdaGrilleSalaires.ColumnHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.vdaGrilleSalaires.ColumnHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaGrilleSalaires.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaGrilleSalaires.DecimalPlaces = 0;
            this.vdaGrilleSalaires.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.vdaGrilleSalaires.EnabledAppearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaGrilleSalaires.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.vdaGrilleSalaires.EnabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vdaGrilleSalaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaGrilleSalaires.Location = new System.Drawing.Point(292, 85);
            this.vdaGrilleSalaires.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.vdaGrilleSalaires.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vdaGrilleSalaires.Name = "vdaGrilleSalaires";
            this.vdaGrilleSalaires.RowCount = 5;
            this.vdaGrilleSalaires.RowHeader.BackgroundColor = System.Drawing.Color.SlateGray;
            this.vdaGrilleSalaires.RowHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaGrilleSalaires.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vdaGrilleSalaires.RowHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaGrilleSalaires.RowHeader.Width = 100;
            this.vdaGrilleSalaires.SelectionAppearance.Color = System.Drawing.Color.DodgerBlue;
            this.vdaGrilleSalaires.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.vdaGrilleSalaires.Size = new System.Drawing.Size(131, 218);
            this.vdaGrilleSalaires.TabIndex = 10;
            this.vdaGrilleSalaires.TabStop = false;
            this.vdaGrilleSalaires.ValueFormat = VisualArrays.enuValueFormat.Currency;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Salaires :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vdaGrilleSalaires);
            this.Controls.Add(this.lblNoms);
            this.Controls.Add(this.vsaGrilleNoms);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q2 Lecture et écriture dans un fichier texte ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierLireNoms;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierLireSalaires;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSéparateur;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public VisualArrays.VisualStringArray vsaGrilleNoms;
        private System.Windows.Forms.Label lblNoms;
        private VisualArrays.VisualDecimalArray vdaGrilleSalaires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrerNoms;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrerSalaires;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierViderGrilles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialAugmenterSalairesDe500;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialDiminuerSalairesDe250;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialNomsEnMajuscules;
        private System.Windows.Forms.ToolStripMenuItem mettreTousLesNomsEnMinusculesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFichierLireComplet;
        private System.Windows.Forms.ToolStripMenuItem MnuFichierEnregistrerComplet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}