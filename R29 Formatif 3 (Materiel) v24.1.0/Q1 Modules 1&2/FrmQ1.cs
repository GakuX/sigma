using System;
using System.Linq;
using System.Windows.Forms;

namespace Examen2
{
    /// <summary>
    /// Formation Q1
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const string APP_INFO = "(DÉMO)";
        //===========================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
        }
        //===========================================================================================================

        #region Q1A - Adressage à 1D
        //===============================================================================================
        private void btnQ1A1_Click(object sender, EventArgs e)
        {
            // TODO Q1A1 : Placer le caractère '8' dans la première moitié de la grille.
            // REMARQUE : Vous devez utiliser la propriété Length et une boucle pour obtenir le maximum des points.
            // À COMPLÉTER
            for (int index = 0; index < vcaGrille1D.Length / 2; index++)
            {
                vcaGrille1D[index] = '8'; 
            }

        }
        //===============================================================================================
        private void BtnQ1A2_Click(object sender, EventArgs e)
        {
            // TODO Q1A2 : Placer les lettres 'A' à 'D' dans la deuxième moitié de la grille.
            // REMARQUE : Vous devez utiliser la propriété Length et une boucle pour obtenir le maximum des points.
            // À COMPLÉTER
            char lettre = 'A'; 
            for (int index = 4; index < vcaGrille1D.Length; index++)
            { 
                vcaGrille1D[index] = lettre; lettre++;  
            }

        }
        //===============================================================================================
        private void BtnQ1A3_Click(object sender, EventArgs e)
        {
            // TODO Q1A3 : Placer des caractères aléatoires dans toutes les cellules.
            // REMARQUE #1 : Vous devez utiliser la propriété Length et une boucle pour obtenir le maximum des points.
            // REMARQUE #2 : La méthode RandomValue('0','Z') sur l'objet vcaGrille1D retourne comme valeur un caractère aléatoire. 
            // À COMPLÉTER
            for (int index = 0; index < vcaGrille1D.Length; ++index)
            {
                vcaGrille1D[index] = vcaGrille1D.RandomValue('0', 'Z'); 
            }
        }
        //===============================================================================================
        private void BtnQ1A4_Click(object sender, EventArgs e)
        {
            // TODO Q1A4 : Calculer le nombre de caractères qui sont des lettres entre 'A' et 'Z'.
            // REMARQUE : Vous devez utiliser la propriété Length et une boucle pour obtenir le maximum des points.
            // À COMPLÉTER
            int compteur = 0; 
            for (int index = 0; index < vcaGrille1D.Length; index++)
            {
                if (vcaGrille1D[index] >= 'A' && vcaGrille1D[index] <= 'Z')
                {
                    compteur++;
                     
                }
            }
            txtRésultat.Text = compteur.ToString();
        }
        //===============================================================================================
        private void BtnQ1A5_Click(object sender, EventArgs e)
        {
            // TODO Q1A5 : Échanger les caractères de la première moitié avec ceux de la deuxième moitié de la grille (voir démo).
            // REMARQUE #1 : Vous devez utiliser la propriété Length et une boucle pour obtenir le maximum des points.
            // REMARQUE #2 : Vous devez utiliser le principe de permutation.
            // 
            // À COMPLÉTER
            int milieu = vcaGrille1D.Length / 2; 
            for (int index = 0; index < vcaGrille1D.Length / 2; index++)
            {
                char temporaire = vcaGrille1D[index];
                vcaGrille1D[index] = vcaGrille1D[index + milieu];
                vcaGrille1D[index + milieu] = temporaire;
            }
        }
        //===============================================================================================

        #endregion

        #region Q1B - Reproduire différents motifs dans une grille 2D
        //=====================================================================================
        private void BtnQ1B1_Click(object sender, EventArgs e)
        {
            vcaGrille2D.Clear(); //  NE PAS MODIFIER

            // TODO Q1B1 : En utilisant la notion de boucles imbriquées. Reproduire le motif (voir démo).
            // REMARQUE : Vous ne pouvez PAS utiliser la méthode PlacerLettres pour répondre à cette sous-question.
            // À COMPLÉTER
            char lettre = 'A'; 
            for (int row = 0; row < vcaGrille2D.RowCount; row++)
            {
                for (int col = 0; col < vcaGrille2D.ColumnCount; col++)
                {
                    vcaGrille2D[row, col] = lettre;
                }
                lettre++; 
            }
        }
        //=====================================================================================
        private void BtnQ1B2_Click(object sender, EventArgs e)
        {
            vcaGrille2D.Clear(); //  NE PAS MODIFIER

            // TODO Q1B2 : En utilisant la notion de boucles imbriquées. Reproduire le motif (voir démo).
            // REMARQUE : Vous ne pouvez PAS utiliser la méthode PlacerLettres pour répondre à cette sous-question.
            // À COMPLÉTER
            char lettre = 'A'; 
            for (int col = 0; col < vcaGrille2D.ColumnCount; col++)
            {
                for (int row = 0; row < vcaGrille2D.RowCount; row++)
                {
                    vcaGrille2D[row, col] = lettre;
                }
                lettre++; 
            }

        }
        //=====================================================================================
        private void BtnQ1B3_Click(object sender, EventArgs e)
        {

            // TODO Q1B3 : Désactiver toutes les cellules contenant les lettres 'B' ou 'G'
            // À COMPLÉTER
            for (int row = 0; row < vcaGrille2D.RowCount; row++)
            {
                for (int col = 0; col < vcaGrille2D.ColumnCount; col++)
                {
                    if (vcaGrille2D[row, col] == 'B' || vcaGrille2D[row, col] == 'G')
                    {
                        vcaGrille2D.DisableCell(row,col);
                    }
                }
            }

        }


        #region PlacerLettres (NE PAS MODIFIER)
        /// <summary>
        /// Place une suite de lettres débutant par la lettre reçu en paramètre sur une rangée de la grille
        /// Le nombre de lettres est déterminé par le paramètre pLongueur et le paramètre pSautLettre permet 
        /// de fixer le pas entre chaque lettre, par exemple 2 donnerais A C E et -1 donnerais C B A
        /// </summary>
        /// <param name="pRangée">Rangée où placer la séquence de lettres</param>
        /// <param name="pLettreDebut">Lettre du début de la séquence</param>
        /// <param name="pLongueur">Longueur de la séquence</param>
        /// <param name="pSautLettre">Saut d'une lettre à l'autre</param>
        private void PlacerLettres(int pRangée, char pLettreDebut, int pLongueur, int pSautLettre)
        {
            char lettre = pLettreDebut;

            for (int col = 0; col < pLongueur; col++)
            {
                vcaGrille2D[pRangée, col] = lettre;
                lettre = (char)(lettre + pSautLettre);
            }
        }

        #endregion 

        //=====================================================================================
        private void BtnQ1B4_Click(object sender, EventArgs e)
        {
            vcaGrille2D.Clear(); //  NE PAS MODIFIER

            // TODO Q1B4 : Reproduire le motif en utilisant PlacerLettres (voir démo).
            // REMARQUE #1 : Aucun point est accordé si votre code n'utilise pas la méthode PlacerLettres
            // REMARQUE #2 : Vous devez utiliser une boucle pour obtenir le maximum des points.
            // À COMPLÉTER
            char lettre = 'Z';
            for (int row = 2; row < 6 ; row++)
            {
                PlacerLettres(row, lettre, vcaGrille2D.ColumnCount, -1);
                lettre--; 

            }

        }
        //=====================================================================================
        private void BtnQ1B5_Click(object sender, EventArgs e)
        {
            vcaGrille2D.Clear(); //  NE PAS MODIFIER


            // TODO Q1B5 : Reproduire le motif en utilisant PlacerLettres (voir démo).
            // REMARQUE #1 : Aucun point est accordé si votre code n'utilise pas la méthode PlacerLettres
            // REMARQUE #2 : Vous devez utiliser une boucle pour obtenir le maximum des points.
            // À COMPLÉTER

        }
        #endregion
        //=====================================================================================

        #region Q2C Méthode avec valeur de retour

        #region EstUNeVoyelle(char pCarac) (NE PAS MODIFIER)
        /// <summary>
        /// Détermine si un caractère est une voyelle
        /// </summary>
        /// <param name="pCarac">Le caractère à vérifier</param>
        /// <returns>Vrai si pCarac est une voyelle, faux autrement</returns>
        private bool EstUNeVoyelle(char pCarac)
        {
            string voyelles = "AEIOUY";
            pCarac = char.ToUpper(pCarac);
            return voyelles.Contains(pCarac);
        }
        #endregion
        //===========================================================================================================
        private void btnQ1C1_Click(object sender, EventArgs e)
        {

            // TODO Q1C2 : Désactiver toutes les cellules contenant une voyelle.
            // REMARQUE #1 : Aucun point est accordé si votre code n'utilise pas la méthode EstUneVoyelle.
            // REMARQUE #2 : Observer la signature de la méthode EstUneVoyelle et utiliser la convenablement dans votre code.
            // À COMPLÉTER

        }
        /// <summary>
        /// Calcul le nombre de voyelles qui se trouvent dans la grille
        /// </summary>
        /// <returns>Nombre de voyelles dans la grille</returns>
        private int NbVoyelles()
        {
            int cptVoyelles = 0;

            //TODO Q1C2 : Compléter cette méthode. Elle doit retourner le nombre de voyelles dans la grille. 
            // À COMPLÉTER

            return 0;   //  instruction temporaire pour éviter des erreurs
        }
        //===========================================================================================================
        private void btnQ1C2_Click(object sender, EventArgs e)
        {
            // Vous devez appeler la méthode NbVoyelles que vous devez avoir complétée préalablement,

            // TODO Q1C2 : Afficher le nombre de voyelles dans le contrôle numNbVoyelles.
            // REMARQUE #1 : Aucun point est accordé si votre code n'utilise pas la méthode NbVoyelles.
            // REMARQUE #2 : Observer la signature de la méthode NbVoyelles et utiliser la convenablement dans votre code.
            // À COMPLÉTER

        }
        //===========================================================================================================
        private void btnQ1C3_Click(object sender, EventArgs e)
        {
            vcaGrille2D.Clear(); //  NE PAS MODIFIER

            // TODO Q1C3 : Copier le contenu de la zone de texte dans chacune des rangées de la grille.
            // À COMPLÉTER


        }

        #endregion


    }
}
