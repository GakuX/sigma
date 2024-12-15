namespace EditeurListeMots
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
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierVider = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterNombre = new System.Windows.Forms.Button();
            this.numNombre = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.grbStatistiques = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnSupprimerNombre = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).BeginInit();
            this.grbStatistiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNombres
            // 
            this.lstNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 25;
            this.lstNombres.Location = new System.Drawing.Point(22, 53);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(128, 329);
            this.lstNombres.TabIndex = 0;
            this.lstNombres.SelectedIndexChanged += new System.EventHandler(this.LstMots_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierVider,
            this.toolStripMenuItem1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierVider
            // 
            this.mnuFichierVider.Name = "mnuFichierVider";
            this.mnuFichierVider.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierVider.Size = new System.Drawing.Size(180, 22);
            this.mnuFichierVider.Text = "Vider la liste";
            this.mnuFichierVider.Click += new System.EventHandler(this.mnuFichierVider_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(180, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste de nombres :";
            // 
            // btnAjouterNombre
            // 
            this.btnAjouterNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterNombre.Location = new System.Drawing.Point(180, 53);
            this.btnAjouterNombre.Name = "btnAjouterNombre";
            this.btnAjouterNombre.Size = new System.Drawing.Size(142, 36);
            this.btnAjouterNombre.TabIndex = 5;
            this.btnAjouterNombre.Text = "&Ajouter le nombre";
            this.btnAjouterNombre.UseVisualStyleBackColor = true;
            this.btnAjouterNombre.Click += new System.EventHandler(this.BtnAjouterNombre_Click);
            // 
            // numNombre
            // 
            this.numNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNombre.Location = new System.Drawing.Point(180, 95);
            this.numNombre.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNombre.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numNombre.Name = "numNombre";
            this.numNombre.Size = new System.Drawing.Size(142, 31);
            this.numNombre.TabIndex = 10;
            this.numNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(9, 56);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 16);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total :";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.Location = new System.Drawing.Point(9, 120);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(67, 16);
            this.lblMinimum.TabIndex = 16;
            this.lblMinimum.Text = "Minimum :";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(9, 152);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(71, 16);
            this.lblMax.TabIndex = 17;
            this.lblMax.Text = "Maximum :";
            // 
            // lblMoyenne
            // 
            this.lblMoyenne.AutoSize = true;
            this.lblMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyenne.Location = new System.Drawing.Point(9, 88);
            this.lblMoyenne.Name = "lblMoyenne";
            this.lblMoyenne.Size = new System.Drawing.Size(70, 16);
            this.lblMoyenne.TabIndex = 18;
            this.lblMoyenne.Text = "Moyenne :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(80, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(62, 26);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoyenne.Location = new System.Drawing.Point(80, 82);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.ReadOnly = true;
            this.txtMoyenne.Size = new System.Drawing.Size(62, 26);
            this.txtMoyenne.TabIndex = 20;
            this.txtMoyenne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinimum
            // 
            this.txtMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimum.Location = new System.Drawing.Point(80, 114);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.ReadOnly = true;
            this.txtMinimum.Size = new System.Drawing.Size(62, 26);
            this.txtMinimum.TabIndex = 21;
            this.txtMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaximum
            // 
            this.txtMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximum.Location = new System.Drawing.Point(80, 146);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.ReadOnly = true;
            this.txtMaximum.Size = new System.Drawing.Size(62, 26);
            this.txtMaximum.TabIndex = 22;
            this.txtMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbStatistiques
            // 
            this.grbStatistiques.Controls.Add(this.txtCount);
            this.grbStatistiques.Controls.Add(this.lblCount);
            this.grbStatistiques.Controls.Add(this.txtTotal);
            this.grbStatistiques.Controls.Add(this.txtMaximum);
            this.grbStatistiques.Controls.Add(this.lblTotal);
            this.grbStatistiques.Controls.Add(this.txtMinimum);
            this.grbStatistiques.Controls.Add(this.lblMinimum);
            this.grbStatistiques.Controls.Add(this.txtMoyenne);
            this.grbStatistiques.Controls.Add(this.lblMax);
            this.grbStatistiques.Controls.Add(this.lblMoyenne);
            this.grbStatistiques.Location = new System.Drawing.Point(168, 196);
            this.grbStatistiques.Name = "grbStatistiques";
            this.grbStatistiques.Size = new System.Drawing.Size(162, 185);
            this.grbStatistiques.TabIndex = 23;
            this.grbStatistiques.TabStop = false;
            this.grbStatistiques.Text = "Statistiques";
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(80, 18);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(62, 26);
            this.txtCount.TabIndex = 24;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(9, 24);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(48, 16);
            this.lblCount.TabIndex = 23;
            this.lblCount.Text = "Count :";
            // 
            // btnSupprimerNombre
            // 
            this.btnSupprimerNombre.Enabled = false;
            this.btnSupprimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerNombre.Location = new System.Drawing.Point(180, 132);
            this.btnSupprimerNombre.Name = "btnSupprimerNombre";
            this.btnSupprimerNombre.Size = new System.Drawing.Size(142, 36);
            this.btnSupprimerNombre.TabIndex = 24;
            this.btnSupprimerNombre.Text = "&Supprimer nombre";
            this.btnSupprimerNombre.UseVisualStyleBackColor = true;
            this.btnSupprimerNombre.Click += new System.EventHandler(this.BtnSupprimerNombre_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnAjouterNombre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 403);
            this.Controls.Add(this.btnSupprimerNombre);
            this.Controls.Add(this.grbStatistiques);
            this.Controls.Add(this.numNombre);
            this.Controls.Add(this.btnAjouterNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q3 ListBox et Stats ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).EndInit();
            this.grbStatistiques.ResumeLayout(false);
            this.grbStatistiques.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterNombre;
        private System.Windows.Forms.NumericUpDown numNombre;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.GroupBox grbStatistiques;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierVider;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnSupprimerNombre;
    }
}

