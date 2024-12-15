using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Q2_Fichier_Texte
{
    public partial class FrmPrincipal : Form
    {
        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //========================================================================================
        private void mnuFichierViderGrilles_Click(object sender, EventArgs e)
        {
            vdaGrilleSalaires.Clear();
            vsaGrilleNoms.Clear();
        }
        //========================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Q2A - Code pour la lecture à partir de fichiers textes
        //========================================================================================
        private void MnuFichierLireNoms_Click(object sender, EventArgs e)
        {

            // TODO Q2A1  : Compléter le code cette méthode qui doit lire les valeurs contenues dans le fichier "Noms.txt"
            // et les AFFICHER dans la grille vsaGrilleNoms.
            // REMARQUE : Ouvrez le fichier "Noms.txt" afin d'analyser sa structure. Vous remarquerez qu'il y a un seul nom par ligne.
            // À COMPLÉTER
            StreamReader objFichier = new StreamReader("Noms.txt");

            int indexLigne = 0;
            while (!objFichier.EndOfStream)
            {
                string ligneLue = objFichier.ReadLine();
                vsaGrilleNoms[indexLigne] = ligneLue;
                indexLigne++;
            }
            objFichier.Close();
        }

        //========================================================================================
        private void MnuFichierLireSalaires_Click(object sender, EventArgs e)
        {

            // TODO Q2A2  : Compléter le code cette méthode qui doit lire les valeurs contenues dans le fichier "Salaires.txt"
            // ET les AFFICHER dans la grille vdaGrilleSalaires.
            // REMARQUE : Ouvrez le fichier "Salaires.txt" afin d'analyser sa structure.
            // Vous remarquerez qu'il y a un seul salaire par ligne.
            // À COMPLÉTER

            StreamReader objsalaire = new StreamReader("Salaires.txt");

            int indexligne = 0;
            while (!objsalaire.EndOfStream)
            {
                string lignelue = objsalaire.ReadLine();
                decimal salaire = decimal.Parse(lignelue);
                vdaGrilleSalaires[indexligne] = salaire;
                indexligne++;
            }
            objsalaire.Close();


        }
        #endregion

        #region Q2B - Code pour l'écriture dans des fichiers textes
        //========================================================================================

        private void mnuFichierEnregistrerNoms_Click(object sender, EventArgs e)
        {
            // TODO Q2B1  : Compléter le code cette méthode qui doit enregistrer les valeurs de la grille vsaGrilleNoms
            //              dans le fichier "Noms.txt".
            //              On doit écrire dans le fichier une ligne par nom apparaissant dans la grille.
            // À COMPLÉTER
            StreamWriter objecrit = new StreamWriter("Noms.txt");

            for (int i = 0; i < vsaGrilleNoms.Length; i++)
            {
                objecrit.WriteLine(vsaGrilleNoms[i]);
            }

        }
        //========================================================================================
        private void mnuFichierEnregistrerSalaires_Click(object sender, EventArgs e)
        {

            // TODO Q2B2  : Compléter le code cette méthode qui doit enregistrer les valeurs de la grille vdaGrilleSalaires
            //              dans le fichier "Salaires.txt".
            //              On doit écrire dans le fichier une ligne par salaire apparaissant dans la grille.
            // À COMPLÉTER
            StreamWriter objecrit2 = new StreamWriter("Salaires.txt");

            for (int i = 0; i < vdaGrilleSalaires.Length; i++)
            {
                objecrit2.WriteLine(vdaGrilleSalaires[i]);
            }

        }

        #endregion

        #region Q2C - Commandes du menu Spécial
        private void MnuSpécialAugmenterSalairesDe500_Click(object sender, EventArgs e)
        {
            // TODO Q2C1  : Cette méthode doit augmenter de 500 les valeurs de la grille des salaires.
            //              L'augmentation doit se faire uniquement si la nouvelle valeur serait inférieure ou égale à la valeur "Maximum" autorisée.
            //              La valeur maximum autorisée peut être obtenu à l'aide de la propriété "Maximum" de l'objet "vdaGrilleSalaires".
            // À COMPLÉTER
            for (int i = 0; i < vdaGrilleSalaires.Length; i++)
            {
                if (vdaGrilleSalaires[i] <= vdaGrilleSalaires.Maximum)
                {
                    vdaGrilleSalaires[i] += 500;
                }
            }

        }

        private void MnuSpécialDiminuerSalairesDe250_Click(object sender, EventArgs e)
        {
            // TODO Q2C2  : Cette méthode doit diminuer de 250 les valeurs de la grille des salaires.
            //              L'augmentation doit se faire uniquement si la nouvelle valeur serait supérieure ou égale à la valeur "Minimum" autorisée.
            //              La valeur minimum autorisée peut être obtenu à l'aide de la propriété "Minimum" de l'objet "vdaGrilleSalaires".
            // À COMPLÉTER
            for (int i = 0; i < vdaGrilleSalaires.Length; i++)
            {
                if (vdaGrilleSalaires[i] >= vdaGrilleSalaires.Minimum)
                {
                    vdaGrilleSalaires[i] -= 250; 
                }
            }

        }

        private void MnuSpécialNomsEnMajuscules_Click(object sender, EventArgs e)
        {
            // TODO Q2C3  : Cette méthode doît mettre tous les noms de la grille "vsaGrilleNoms" en majuscule.
            // À COMPLÉTER
            for (int i = 0; i < vsaGrilleNoms.Length; i++)
            {
                vsaGrilleNoms[i].ToUpper(); 
            }

        }

        private void mettreTousLesNomsEnMinusculesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO Q2C4  : Cette méthode doît mettre tous les noms de la grille "vsaGrilleNoms" en minuscule.
            // À COMPLÉTER
            for (int i = 0; i < vsaGrilleNoms.Length; i++)
            {
                vsaGrilleNoms[i].ToLower();
            }
        }

        #endregion

        #region Q2D - Lecture et écriture dans un fichier texte avec séparateur
        private void MnuFichierLireComplet_Click(object sender, EventArgs e)
        {
            vsaGrilleNoms.Clear();   //NE PAS MODIFIER
            vdaGrilleSalaires.Clear(); //NE PAS MODIFIER

            // TODO Q2D1  : Compléter le code cette méthode qui doit lire le contenu du fichier "Complet.txt"
            // ET AFFICHER LES INFOS dans la grille vsaGrilleNoms et vsaGrilleSalaires.
            // REMARQUE : Ouvrez le fichier "Complet.txt" afin d'analyser sa structure.
            // Vous remarquerez qu'il y a deux informations par ligne séparées par un '|'.
            // À COMPLÉTER
            StreamReader objcomplet = new StreamReader("Complet.txt");

            for (int i = 0; i < vsaGrilleNoms.Length; i++)
            {
                string lignecomplet = objcomplet.ReadLine();
                string[] tabcomplet = lignecomplet.Split('|');
                vsaGrilleNoms[i] = tabcomplet[0];
                vdaGrilleSalaires[i] = int.Parse(tabcomplet[1]);
            }
            objcomplet.Close();
            //string lignecomplet = objcomplet.ReadLine();
            //string[] tabcomplet = lignecomplet.Split('|');
            //vsaGrilleNoms[0] = tabcomplet[0];
            //vdaGrilleSalaires[0]
        }

        private void MnuFichierEnregistrerComplet_Click(object sender, EventArgs e)
        {
            // TODO Q2D2  : Compléter le code cette méthode qui doit enregistrer les valeurs des grilles vsaGrilleNoms et vdaGrilleSalaires dans le fichier "Complet.txt".
            // REMARQUE : On doit écrire dans le fichier une ligne par combinaison de nom et de salaire (avec comme séparateur un '|').
            // À COMPLÉTER
            StreamWriter objenregistrer = new StreamWriter("Complets.txt");

            

        }

        #endregion

        private void vsaGrilleNoms_Click(object sender, EventArgs e)
        {

        }
    }
}
