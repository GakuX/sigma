using System;
using System.Drawing;
using System.Windows.Forms;

namespace JeuAddition
{
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO = "(DÉMO)";
        //==============================================================================================
        private const int NB_QUESTIONS = 5;

        //Constantes à utiliser pour indexer le tableau
        private const int OPÉRANDE_1 = 0;       // Rangée 0 : premier nombre
        private const int OPÉRANDE_2 = 1;       // Rangée 1 : deuxième nombre
        private const int RÉPONSE_CLIENT = 2;   // Rangée 2 : Réponse du client


        private int[,] m_tabNombres = new int[NB_QUESTIONS, 3]; // Tableau des questions et réponses

        private int m_indexQuestionCourante = 0; // Index de la question courante
        private Random m_objRandom;
        //==============================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            m_objRandom = new Random();
            PréparerNouvellePartie();
        }
        //==============================================================================================
        /// <summary>
        /// Prépare une nouvelle partie
        /// </summary>
        private void PréparerNouvellePartie()
        {
            CréerLesQuestions();
            AfficherQuestionCourante();
            viaRéponse.Select();
        }

        /// <summary>
        /// Génére un nombre aléatoire entre 1 et 10
        /// </summary>
        /// <returns>Le nombre aléatoire généré</returns>
        private int GenererNombreAleatoireEntre1Et10()
        {
            return m_objRandom.Next(10) + 1;
        }

        //==============================================================================================
        /// <summary>
        /// Préparer les questions. 
        /// Une question sur l'addition est formée de deux opérandes et d'une réponse à zéro
        /// </summary>
        private void CréerLesQuestions()
        {
            // TODO Q4A1 : La variable membre m_tabNombres contient un tableau à 2D représentant pour chacune des 10 questions (les rangées) 
            //             les 3 informations suivantes (les colonnes) : la première opérande, la deuxième opérande et la réponse de l'utilisateur.
            //             À l'aide d'une boucle et en utilisant la méthode "GenererNombreAleatoireEntre1Et10",
            //             indiquez une valeur aléatoire pour toutes les premières et deuxièmes opérandes.
            // À COMPLÉTER
            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                m_tabNombres[i, OPÉRANDE_1] = GenererNombreAleatoireEntre1Et10();
                m_tabNombres[i, OPÉRANDE_2] = GenererNombreAleatoireEntre1Et10();
                m_tabNombres[i, RÉPONSE_CLIENT] = 0; 
            }

        }

        //==============================================================================================
        /// <summary>
        /// Affiche les informations de la question courante.
        /// </summary>
        private void AfficherQuestionCourante()
        {
            // TODO Q4A2 :  L'index correspondant à la question courante (celle affichée dans l'interface) est représenté par la variable membre "m_indexQuestionCourante".
            //              Récupérer les informations dans le tableau "m_tabNombres" correspondantes à la question courante et affichez-les dans l'interface (voir démo).
            //              Par la suite appelez la méthode "MettreAJourSelonLeContexte".
            //              Attention, la méthode MettreAJourSelonLeContexte ne fait rien pour le moment. Vous coderez cette méthode plus tard dans Q4A7
            // À COMPLÉTER
            
            viaNombre1.Value = m_tabNombres[m_indexQuestionCourante, OPÉRANDE_1];
            viaNombre2.Value = m_tabNombres[m_indexQuestionCourante, OPÉRANDE_2];
            viaRéponse.Value = m_tabNombres[m_indexQuestionCourante, RÉPONSE_CLIENT];

        }


        //==============================================================================================
        //Passe à la question suivante.
        private void btnPrécédente_Click(object sender, EventArgs e)
        {
            // TODO Q4A3 : Revenir à la question précédente puis appeler la méthode "AfficherQuestionCourante"
            // À COMPLÉTER
            m_indexQuestionCourante--; 
            AfficherQuestionCourante(); 
        }

        //==============================================================================================
        //Revient à la question précédente
        private void btnSuivante_Click(object sender, EventArgs e)
        {
            // TODO Q4A4 : Passer à la question suivante puis appeler la méthode "AfficherQuestionCourante"
            // À COMPLÉTER
            m_indexQuestionCourante++;
            AfficherQuestionCourante();

        }

        //==============================================================================================
        /// <summary>
        /// Vérifier si chaque question a été répondue.
        /// </summary>
        /// <returns>Retourne true si chaque question a une réponse, sinon false</returns>
        private bool QuestionsTerminées()
        {
            // TODO Q4A5 : Retourner vrai si toutes les questions ont été répondues et dans le cas contraire faux.
            //             Une question est considérée comme non-répondue si la réponse est 0.
            // À COMPLÉTER


            return false;    // instruction temporaire pour éviter des erreurs
        }

        //==============================================================================================
        private void viaRéponse_ValueChanged(object sender, EventArgs e)
        {
            if (viaRéponse.Value == 0)                  //Ne pas modifier
                viaRéponse.ForeColor = Color.White;     //Ne pas modifier
            else                                        //Ne pas modifier
                viaRéponse.ForeColor = Color.Black;     //Ne pas modifier

            //TODO Q4A6 : Sauvegarder la réponse de l'utilisateur dans le tableau "m_tabNombres" à l'emplacement approprié
            // À COMPLÉTER




            MettreAJourSelonLeContexte();               //Ne pas modifier
        }

        
        //==============================================================================================
        private void MettreAJourSelonLeContexte()
        {
            //TODO Q4A7 : Rendez disponibles ou non les boutons btnSuivante, btnPrécédente et btnScore
            //Les boutons btnSuivante et btnPrécédente seront disponibles selon la valeur de m_indexQuestionCourante
            //Le bouton btnScore sera disponible si toutes les questions sont terminées.
            // À COMPLÉTER


        }

        //==============================================================================================
        private void btnScore_Click(object sender, EventArgs e)
        {
            //TODO Q4A8 : Calculez le score
            //  Il faut examiner chacune des questions et compter le nombre de bonnes réponses.
            //  Pour savoir si un point doit être ajouté au score regardez si la somme des deux opérandes correspond à la réponse donnée
            //  Utilisez l'instruction MessageBox.Show() pour afficher le score (voir la démo) dans un popup.
            //  L'instruction suivante: MessageBox.Show("Bonne chance")  afficherait "Bonne chance" dans un popup.
            // À COMPLÉTER
            

        }

        //==============================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        //==============================================================================================
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }

        private void viaNombre1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
