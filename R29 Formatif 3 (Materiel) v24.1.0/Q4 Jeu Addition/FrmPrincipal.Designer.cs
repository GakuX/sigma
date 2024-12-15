namespace JeuAddition
{
    partial class FrmPrincipal
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
            this.panSep = new System.Windows.Forms.Panel();
            this.panMath = new System.Windows.Forms.Panel();
            this.lblRéponse = new System.Windows.Forms.Label();
            this.viaRéponse = new VisualArrays.VisualCells.VisualInt();
            this.viaNombre2 = new VisualArrays.VisualCells.VisualInt();
            this.viaNombre1 = new VisualArrays.VisualCells.VisualInt();
            this.lblOpérateur = new System.Windows.Forms.Label();
            this.btnSuivante = new System.Windows.Forms.Button();
            this.btnPrécédente = new System.Windows.Forms.Button();
            this.lblNumQuestion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnScore = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMath.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSep
            // 
            this.panSep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSep.Location = new System.Drawing.Point(79, 188);
            this.panSep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panSep.Name = "panSep";
            this.panSep.Size = new System.Drawing.Size(250, 4);
            this.panSep.TabIndex = 3;
            // 
            // panMath
            // 
            this.panMath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMath.Controls.Add(this.lblRéponse);
            this.panMath.Controls.Add(this.viaRéponse);
            this.panMath.Controls.Add(this.viaNombre2);
            this.panMath.Controls.Add(this.viaNombre1);
            this.panMath.Controls.Add(this.lblOpérateur);
            this.panMath.Controls.Add(this.panSep);
            this.panMath.Location = new System.Drawing.Point(37, 140);
            this.panMath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panMath.Name = "panMath";
            this.panMath.Size = new System.Drawing.Size(354, 300);
            this.panMath.TabIndex = 1;
            // 
            // lblRéponse
            // 
            this.lblRéponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRéponse.Location = new System.Drawing.Point(16, 212);
            this.lblRéponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRéponse.Name = "lblRéponse";
            this.lblRéponse.Size = new System.Drawing.Size(133, 71);
            this.lblRéponse.TabIndex = 13;
            this.lblRéponse.Text = "votre réponse";
            this.lblRéponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viaRéponse
            // 
            this.viaRéponse.BackColor = System.Drawing.Color.White;
            this.viaRéponse.FocusColor = System.Drawing.Color.Gray;
            this.viaRéponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.viaRéponse.Location = new System.Drawing.Point(157, 201);
            this.viaRéponse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viaRéponse.Name = "viaRéponse";
            this.viaRéponse.Size = new System.Drawing.Size(160, 84);
            this.viaRéponse.TabIndex = 12;
            this.viaRéponse.WaitForEnter = false;
            this.viaRéponse.ValueChanged += new System.EventHandler(this.viaRéponse_ValueChanged);
            // 
            // viaNombre2
            // 
            this.viaNombre2.BackColor = System.Drawing.Color.LightGray;
            this.viaNombre2.FocusColor = System.Drawing.Color.Gray;
            this.viaNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.viaNombre2.Location = new System.Drawing.Point(157, 100);
            this.viaNombre2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viaNombre2.Name = "viaNombre2";
            this.viaNombre2.ReadOnly = true;
            this.viaNombre2.Size = new System.Drawing.Size(160, 71);
            this.viaNombre2.TabIndex = 2;
            this.viaNombre2.TabStop = false;
            // 
            // viaNombre1
            // 
            this.viaNombre1.BackColor = System.Drawing.Color.LightGray;
            this.viaNombre1.FocusColor = System.Drawing.Color.Gray;
            this.viaNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.viaNombre1.Location = new System.Drawing.Point(157, 16);
            this.viaNombre1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viaNombre1.Name = "viaNombre1";
            this.viaNombre1.ReadOnly = true;
            this.viaNombre1.Size = new System.Drawing.Size(160, 71);
            this.viaNombre1.TabIndex = 0;
            this.viaNombre1.TabStop = false;
            this.viaNombre1.ValueChanged += new System.EventHandler(this.viaNombre1_ValueChanged);
            // 
            // lblOpérateur
            // 
            this.lblOpérateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpérateur.Location = new System.Drawing.Point(36, 55);
            this.lblOpérateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpérateur.Name = "lblOpérateur";
            this.lblOpérateur.Size = new System.Drawing.Size(75, 90);
            this.lblOpérateur.TabIndex = 1;
            this.lblOpérateur.Text = "+";
            // 
            // btnSuivante
            // 
            this.btnSuivante.Font = new System.Drawing.Font("Wingdings 3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSuivante.Location = new System.Drawing.Point(252, 5);
            this.btnSuivante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuivante.Name = "btnSuivante";
            this.btnSuivante.Size = new System.Drawing.Size(65, 53);
            this.btnSuivante.TabIndex = 2;
            this.btnSuivante.Text = "g";
            this.btnSuivante.UseVisualStyleBackColor = true;
            this.btnSuivante.Click += new System.EventHandler(this.btnSuivante_Click);
            // 
            // btnPrécédente
            // 
            this.btnPrécédente.Font = new System.Drawing.Font("Wingdings 3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrécédente.Location = new System.Drawing.Point(179, 5);
            this.btnPrécédente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrécédente.Name = "btnPrécédente";
            this.btnPrécédente.Size = new System.Drawing.Size(65, 53);
            this.btnPrécédente.TabIndex = 1;
            this.btnPrécédente.Text = "f";
            this.btnPrécédente.UseVisualStyleBackColor = true;
            this.btnPrécédente.Click += new System.EventHandler(this.btnPrécédente_Click);
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestion.Location = new System.Drawing.Point(4, 5);
            this.lblNumQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumQuestion.Name = "lblNumQuestion";
            this.lblNumQuestion.Size = new System.Drawing.Size(167, 53);
            this.lblNumQuestion.TabIndex = 0;
            this.lblNumQuestion.Text = "0 de 0";
            this.lblNumQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.mnuFichierSep1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(66, 24);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouvellePartie
            // 
            this.mnuFichierNouvellePartie.Name = "mnuFichierNouvellePartie";
            this.mnuFichierNouvellePartie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouvellePartie.Size = new System.Drawing.Size(245, 26);
            this.mnuFichierNouvellePartie.Text = "Nouvelle Partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSep1
            // 
            this.mnuFichierSep1.Name = "mnuFichierSep1";
            this.mnuFichierSep1.Size = new System.Drawing.Size(242, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(245, 26);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(37, 468);
            this.btnScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(355, 52);
            this.btnScore.TabIndex = 2;
            this.btnScore.Text = "&Voir score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNumQuestion);
            this.panel1.Controls.Add(this.btnPrécédente);
            this.panel1.Controls.Add(this.btnSuivante);
            this.panel1.Location = new System.Drawing.Point(37, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 66);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnSuivante;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.panMath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q4 Jeu Additions ";
            this.panMath.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSep;
        private System.Windows.Forms.Panel panMath;
        private System.Windows.Forms.Label lblOpérateur;
        private System.Windows.Forms.Button btnSuivante;
        private System.Windows.Forms.Button btnPrécédente;
        private System.Windows.Forms.Label lblNumQuestion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Button btnScore;
        private VisualArrays.VisualCells.VisualInt viaRéponse;
        private VisualArrays.VisualCells.VisualInt viaNombre2;
        private VisualArrays.VisualCells.VisualInt viaNombre1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSep1;
        private System.Windows.Forms.Label lblRéponse;
    }
}

