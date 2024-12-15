namespace Examen2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnQ1A5 = new System.Windows.Forms.Button();
            this.BtnQ1A3 = new System.Windows.Forms.Button();
            this.BtnQ1A2 = new System.Windows.Forms.Button();
            this.btnQ1A1 = new System.Windows.Forms.Button();
            this.vcaGrille1D = new VisualArrays.VisualCharArray();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRésultat = new System.Windows.Forms.TextBox();
            this.lblRésultat = new System.Windows.Forms.Label();
            this.btnQ1A4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChaîne = new System.Windows.Forms.Label();
            this.txtChaîne = new System.Windows.Forms.TextBox();
            this.numNbVoyelles = new System.Windows.Forms.NumericUpDown();
            this.btnQ1C3 = new System.Windows.Forms.Button();
            this.vcaGrille2D = new VisualArrays.VisualCharArray();
            this.BtnQ1B4 = new System.Windows.Forms.Button();
            this.BtnQ1B2 = new System.Windows.Forms.Button();
            this.btnQ1B1 = new System.Windows.Forms.Button();
            this.btnQ1C2 = new System.Windows.Forms.Button();
            this.lblNbVoyelles = new System.Windows.Forms.Label();
            this.btnQ1C1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQ1B5 = new System.Windows.Forms.Button();
            this.btnQ1B3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbVoyelles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnQ1A5);
            this.panel1.Controls.Add(this.BtnQ1A3);
            this.panel1.Controls.Add(this.BtnQ1A2);
            this.panel1.Controls.Add(this.btnQ1A1);
            this.panel1.Controls.Add(this.vcaGrille1D);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRésultat);
            this.panel1.Controls.Add(this.lblRésultat);
            this.panel1.Controls.Add(this.btnQ1A4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 459);
            this.panel1.TabIndex = 0;
            // 
            // BtnQ1A5
            // 
            this.BtnQ1A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQ1A5.Location = new System.Drawing.Point(12, 370);
            this.BtnQ1A5.Name = "BtnQ1A5";
            this.BtnQ1A5.Size = new System.Drawing.Size(346, 65);
            this.BtnQ1A5.TabIndex = 8;
            this.BtnQ1A5.Text = "A5- En utilisant le principe de permutation. Échanger les caractères de la premiè" +
    "re moitié avec ceux de la deuxième moitié de la grille.";
            this.BtnQ1A5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQ1A5.UseVisualStyleBackColor = true;
            this.BtnQ1A5.Click += new System.EventHandler(this.BtnQ1A5_Click);
            // 
            // BtnQ1A3
            // 
            this.BtnQ1A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQ1A3.Location = new System.Drawing.Point(12, 219);
            this.BtnQ1A3.Name = "BtnQ1A3";
            this.BtnQ1A3.Size = new System.Drawing.Size(346, 60);
            this.BtnQ1A3.TabIndex = 4;
            this.BtnQ1A3.Text = "A3- En utilisant la méthode RandomValue(\'0\',\'Z\') de la grille. Placer des caractè" +
    "res aléatoires dans toutes les cellules.";
            this.BtnQ1A3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQ1A3.UseVisualStyleBackColor = true;
            this.BtnQ1A3.Click += new System.EventHandler(this.BtnQ1A3_Click);
            // 
            // BtnQ1A2
            // 
            this.BtnQ1A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQ1A2.Location = new System.Drawing.Point(12, 164);
            this.BtnQ1A2.Name = "BtnQ1A2";
            this.BtnQ1A2.Size = new System.Drawing.Size(346, 48);
            this.BtnQ1A2.TabIndex = 3;
            this.BtnQ1A2.Text = "A2- Placer les lettres \'A\' à \'D\' dans la deuxième moitié de la grille";
            this.BtnQ1A2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQ1A2.UseVisualStyleBackColor = true;
            this.BtnQ1A2.Click += new System.EventHandler(this.BtnQ1A2_Click);
            // 
            // btnQ1A1
            // 
            this.btnQ1A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1A1.Location = new System.Drawing.Point(12, 110);
            this.btnQ1A1.Name = "btnQ1A1";
            this.btnQ1A1.Size = new System.Drawing.Size(346, 48);
            this.btnQ1A1.TabIndex = 2;
            this.btnQ1A1.Text = "A1- Placer le caractère \'8\' dans la première moitié de la grille.";
            this.btnQ1A1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1A1.UseVisualStyleBackColor = true;
            this.btnQ1A1.Click += new System.EventHandler(this.btnQ1A1_Click);
            // 
            // vcaGrille1D
            // 
            this.vcaGrille1D.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.vcaGrille1D.AllowCellDrag = false;
            this.vcaGrille1D.AllowSelfDrop = true;
            this.vcaGrille1D.BackColor = System.Drawing.Color.White;
            this.vcaGrille1D.CellMargin = 1;
            this.vcaGrille1D.CellSize = new System.Drawing.Size(39, 38);
            this.vcaGrille1D.ColumnCount = 8;
            this.vcaGrille1D.DefaultValue = ' ';
            this.vcaGrille1D.DisabledAppearance.StrikeAppearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vcaGrille1D.DisabledAppearance.StrikeAppearance.PenWidth = 1;
            this.vcaGrille1D.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.vcaGrille1D.DragAppearance.ShowSource = false;
            this.vcaGrille1D.EnabledAppearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaGrille1D.EnabledAppearance.Image = global::Formatif3Q1.Properties.Resources.FondBleu40X40;
            this.vcaGrille1D.EnabledAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vcaGrille1D.EnabledAppearance.TextColor = System.Drawing.Color.DodgerBlue;
            this.vcaGrille1D.GridAppearance.Color = System.Drawing.Color.PowderBlue;
            this.vcaGrille1D.Location = new System.Drawing.Point(11, 40);
            this.vcaGrille1D.Name = "vcaGrille1D";
            this.vcaGrille1D.RowCount = 1;
            this.vcaGrille1D.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaGrille1D.Size = new System.Drawing.Size(349, 54);
            this.vcaGrille1D.SpecialValue = '!';
            this.vcaGrille1D.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Questions sur l\'adressage 1D";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRésultat
            // 
            this.txtRésultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRésultat.Location = new System.Drawing.Point(296, 339);
            this.txtRésultat.Margin = new System.Windows.Forms.Padding(2);
            this.txtRésultat.Name = "txtRésultat";
            this.txtRésultat.Size = new System.Drawing.Size(63, 26);
            this.txtRésultat.TabIndex = 7;
            this.txtRésultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRésultat
            // 
            this.lblRésultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRésultat.Location = new System.Drawing.Point(115, 342);
            this.lblRésultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRésultat.Name = "lblRésultat";
            this.lblRésultat.Size = new System.Drawing.Size(176, 19);
            this.lblRésultat.TabIndex = 6;
            this.lblRésultat.Text = "Résultat :";
            this.lblRésultat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQ1A4
            // 
            this.btnQ1A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1A4.Location = new System.Drawing.Point(12, 285);
            this.btnQ1A4.Name = "btnQ1A4";
            this.btnQ1A4.Size = new System.Drawing.Size(346, 48);
            this.btnQ1A4.TabIndex = 5;
            this.btnQ1A4.Text = "A4- Calculer le nombre de caractères qui sont des lettres entre \'A\' et \'Z\'";
            this.btnQ1A4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1A4.UseVisualStyleBackColor = true;
            this.btnQ1A4.Click += new System.EventHandler(this.BtnQ1A4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblChaîne);
            this.panel2.Controls.Add(this.txtChaîne);
            this.panel2.Controls.Add(this.numNbVoyelles);
            this.panel2.Controls.Add(this.btnQ1C3);
            this.panel2.Controls.Add(this.vcaGrille2D);
            this.panel2.Controls.Add(this.BtnQ1B4);
            this.panel2.Controls.Add(this.BtnQ1B2);
            this.panel2.Controls.Add(this.btnQ1B1);
            this.panel2.Controls.Add(this.btnQ1C2);
            this.panel2.Controls.Add(this.lblNbVoyelles);
            this.panel2.Controls.Add(this.btnQ1C1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnQ1B5);
            this.panel2.Controls.Add(this.btnQ1B3);
            this.panel2.Location = new System.Drawing.Point(402, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 459);
            this.panel2.TabIndex = 2;
            // 
            // lblChaîne
            // 
            this.lblChaîne.AutoSize = true;
            this.lblChaîne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaîne.Location = new System.Drawing.Point(687, 391);
            this.lblChaîne.Name = "lblChaîne";
            this.lblChaîne.Size = new System.Drawing.Size(90, 13);
            this.lblChaîne.TabIndex = 13;
            this.lblChaîne.Text = "Texte à recopier :";
            // 
            // txtChaîne
            // 
            this.txtChaîne.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChaîne.Location = new System.Drawing.Point(687, 406);
            this.txtChaîne.MaxLength = 8;
            this.txtChaîne.Name = "txtChaîne";
            this.txtChaîne.Size = new System.Drawing.Size(108, 32);
            this.txtChaîne.TabIndex = 12;
            this.txtChaîne.Text = "Bonjour!";
            this.txtChaîne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numNbVoyelles
            // 
            this.numNbVoyelles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbVoyelles.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numNbVoyelles.Location = new System.Drawing.Point(556, 361);
            this.numNbVoyelles.Name = "numNbVoyelles";
            this.numNbVoyelles.ReadOnly = true;
            this.numNbVoyelles.Size = new System.Drawing.Size(72, 26);
            this.numNbVoyelles.TabIndex = 9;
            this.numNbVoyelles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnQ1C3
            // 
            this.btnQ1C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1C3.Location = new System.Drawing.Point(417, 391);
            this.btnQ1C3.Name = "btnQ1C3";
            this.btnQ1C3.Size = new System.Drawing.Size(264, 47);
            this.btnQ1C3.TabIndex = 11;
            this.btnQ1C3.Text = "C3- Copier le contenu de la zone de texte dans chacune des rangées de la grille.";
            this.btnQ1C3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1C3.UseVisualStyleBackColor = true;
            this.btnQ1C3.Click += new System.EventHandler(this.btnQ1C3_Click);
            // 
            // vcaGrille2D
            // 
            this.vcaGrille2D.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.vcaGrille2D.AllowCellDrag = false;
            this.vcaGrille2D.AllowSelfDrop = true;
            this.vcaGrille2D.BackColor = System.Drawing.Color.White;
            this.vcaGrille2D.CellMargin = 1;
            this.vcaGrille2D.CellSize = new System.Drawing.Size(41, 41);
            this.vcaGrille2D.ColumnCount = 8;
            this.vcaGrille2D.DefaultValue = ' ';
            this.vcaGrille2D.DisabledAppearance.StrikeAppearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vcaGrille2D.DisabledAppearance.StrikeAppearance.PenWidth = 1;
            this.vcaGrille2D.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.vcaGrille2D.DragAppearance.ShowSource = false;
            this.vcaGrille2D.EnabledAppearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaGrille2D.EnabledAppearance.Image = global::Formatif3Q1.Properties.Resources.FondBleu40X40;
            this.vcaGrille2D.EnabledAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vcaGrille2D.EnabledAppearance.TextColor = System.Drawing.Color.DodgerBlue;
            this.vcaGrille2D.GridAppearance.Color = System.Drawing.Color.PowderBlue;
            this.vcaGrille2D.Location = new System.Drawing.Point(19, 39);
            this.vcaGrille2D.Name = "vcaGrille2D";
            this.vcaGrille2D.RowCount = 9;
            this.vcaGrille2D.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaGrille2D.Size = new System.Drawing.Size(365, 409);
            this.vcaGrille2D.TabIndex = 10;
            // 
            // BtnQ1B4
            // 
            this.BtnQ1B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQ1B4.Location = new System.Drawing.Point(417, 163);
            this.BtnQ1B4.Name = "BtnQ1B4";
            this.BtnQ1B4.Size = new System.Drawing.Size(378, 35);
            this.BtnQ1B4.TabIndex = 4;
            this.BtnQ1B4.Text = "B4- Reproduire le motif en utilisant PlacerLettres (voir démo)";
            this.BtnQ1B4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQ1B4.UseVisualStyleBackColor = true;
            this.BtnQ1B4.Click += new System.EventHandler(this.BtnQ1B4_Click);
            // 
            // BtnQ1B2
            // 
            this.BtnQ1B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQ1B2.Location = new System.Drawing.Point(417, 62);
            this.BtnQ1B2.Name = "BtnQ1B2";
            this.BtnQ1B2.Size = new System.Drawing.Size(378, 46);
            this.BtnQ1B2.TabIndex = 2;
            this.BtnQ1B2.Text = "B2- En utilisant la notion de boucles imbriquées. \r\nReproduire le motif (voir dém" +
    "o)";
            this.BtnQ1B2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQ1B2.UseVisualStyleBackColor = true;
            this.BtnQ1B2.Click += new System.EventHandler(this.BtnQ1B2_Click);
            // 
            // btnQ1B1
            // 
            this.btnQ1B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1B1.Location = new System.Drawing.Point(417, 10);
            this.btnQ1B1.Name = "btnQ1B1";
            this.btnQ1B1.Size = new System.Drawing.Size(378, 46);
            this.btnQ1B1.TabIndex = 1;
            this.btnQ1B1.Text = "B1- En utilisant la notion de boucles imbriquées. \r\nReproduire le motif (voir dém" +
    "o)";
            this.btnQ1B1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1B1.UseVisualStyleBackColor = true;
            this.btnQ1B1.Click += new System.EventHandler(this.BtnQ1B1_Click);
            // 
            // btnQ1C2
            // 
            this.btnQ1C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1C2.Location = new System.Drawing.Point(417, 310);
            this.btnQ1C2.Name = "btnQ1C2";
            this.btnQ1C2.Size = new System.Drawing.Size(378, 47);
            this.btnQ1C2.TabIndex = 7;
            this.btnQ1C2.Text = "C2- En utilisant la méthode NbVoyelles que vous devez compléter. Afficher le nomb" +
    "re de voyelles dans la grille.";
            this.btnQ1C2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1C2.UseVisualStyleBackColor = true;
            this.btnQ1C2.Click += new System.EventHandler(this.btnQ1C2_Click);
            // 
            // lblNbVoyelles
            // 
            this.lblNbVoyelles.AutoSize = true;
            this.lblNbVoyelles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVoyelles.Location = new System.Drawing.Point(421, 365);
            this.lblNbVoyelles.Name = "lblNbVoyelles";
            this.lblNbVoyelles.Size = new System.Drawing.Size(136, 16);
            this.lblNbVoyelles.TabIndex = 8;
            this.lblNbVoyelles.Text = "Nombre de voyelles :";
            // 
            // btnQ1C1
            // 
            this.btnQ1C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1C1.Location = new System.Drawing.Point(417, 257);
            this.btnQ1C1.Name = "btnQ1C1";
            this.btnQ1C1.Size = new System.Drawing.Size(378, 47);
            this.btnQ1C1.TabIndex = 6;
            this.btnQ1C1.Text = "C1- En utilisant la méthode EstUneVoyelle(). Désactiver toutes les cellules conte" +
    "nant une voyelle.";
            this.btnQ1C1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1C1.UseVisualStyleBackColor = true;
            this.btnQ1C1.Click += new System.EventHandler(this.btnQ1C1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Questions sur l\'adressage 2D";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQ1B5
            // 
            this.btnQ1B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1B5.Location = new System.Drawing.Point(417, 204);
            this.btnQ1B5.Name = "btnQ1B5";
            this.btnQ1B5.Size = new System.Drawing.Size(378, 33);
            this.btnQ1B5.TabIndex = 5;
            this.btnQ1B5.Text = "B5- Reproduire le motif en utilisant PlacerLettres (voir démo)";
            this.btnQ1B5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1B5.UseVisualStyleBackColor = true;
            this.btnQ1B5.Click += new System.EventHandler(this.BtnQ1B5_Click);
            // 
            // btnQ1B3
            // 
            this.btnQ1B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1B3.Location = new System.Drawing.Point(417, 114);
            this.btnQ1B3.Name = "btnQ1B3";
            this.btnQ1B3.Size = new System.Drawing.Size(378, 43);
            this.btnQ1B3.TabIndex = 3;
            this.btnQ1B3.Text = "B3- Désactiver toutes les cellules contenant \r\n       les lettres \'B\' ou \'G\'";
            this.btnQ1B3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQ1B3.UseVisualStyleBackColor = true;
            this.btnQ1B3.Click += new System.EventHandler(this.BtnQ1B3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q1 Synthèse modules 1 et 2 ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbVoyelles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQ1A4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQ1B5;
        private System.Windows.Forms.Button btnQ1B3;
        private VisualArrays.VisualCharArray vcaGrille1D;
        private System.Windows.Forms.TextBox txtRésultat;
        private System.Windows.Forms.Label lblRésultat;
        private System.Windows.Forms.Button btnQ1A1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnQ1A2;
        private System.Windows.Forms.Button BtnQ1A3;
        private System.Windows.Forms.Button BtnQ1A5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQ1C2;
        private System.Windows.Forms.Label lblNbVoyelles;
        private System.Windows.Forms.Button btnQ1C1;
        private System.Windows.Forms.NumericUpDown numNbVoyelles;
        private System.Windows.Forms.Button btnQ1B1;
        private System.Windows.Forms.Button BtnQ1B2;
        private System.Windows.Forms.Button BtnQ1B4;
        private VisualArrays.VisualCharArray vcaGrille2D;
        private System.Windows.Forms.Label lblChaîne;
        private System.Windows.Forms.TextBox txtChaîne;
        private System.Windows.Forms.Button btnQ1C3;
    }
}

