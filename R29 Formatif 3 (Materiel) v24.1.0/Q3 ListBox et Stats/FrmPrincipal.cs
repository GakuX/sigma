using System;
using System.Windows.Forms;

namespace EditeurListeMots
{
    public partial class FrmPrincipal : Form
    {
        const string APP_INFOS = "(DÉMO)";
        //==============================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFOS;
        }

        //==============================================================================================
        private void BtnAjouterNombre_Click(object sender, EventArgs e)
        {
            //TODO Q3A1 : Ajouter, dans la liste de nombres (à gauche), le nombre saisi dans le contrôle "numNombre" (à droite) .
            //            Après l'ajout, mettre la valeur 0 dans le contrôle "numNombre" et mettez le focus sur ce contrôle.
            //            Appeler la méthode "AfficherStatistiques" (l'affichage des statistiques fonctionnera à partir des TODOs Q3B1 à Q3B3 )
            // À COMPLÉTER
            int nouveauchar = int.Parse(numNombre.Value.ToString());
            lstNombres.Items.Add(nouveauchar);
            AfficherStatistiques(); 


        }
        //==============================================================================================
        private void BtnSupprimerNombre_Click_1(object sender, EventArgs e)
        {
            //TODO Q3A2 : Retirer le nombre sélectionné de la liste, puis appelez la méthode "AfficherStatistiques".
            // À COMPLÉTER
           

            lstNombres.Items.Remove(lstNombres.SelectedItems);
        }
        //==============================================================================================
        private void mnuFichierVider_Click(object sender, EventArgs e)
        {
            //TODO Q3A3 : Retirer tous les nombres de la liste, puis appelez la méthode "AfficherStatistiques".
            // À COMPLÉTER
            lstNombres.Items.Clear();
            AfficherStatistiques(); 

        }

        //==============================================================================================
        private void LstMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Q3A4 : Rendre le bouton "supprimer" fonctionnel uniquement si une sélection a été fait dans la liste (dans le cas contraire le désactiver). 
            // À COMPLÉTER
            if (lstNombres.SelectedIndex != -1)
            {
                btnSupprimerNombre.Enabled = true; 
                lstNombres.Items.Remove(lstNombres.SelectedIndex); 
            }


        }

        //==============================================================================================
        #region "AfficherStatistiques (NA PAS MODIFIER)"
        private void AfficherStatistiques()
        {
            if (lstNombres.Items.Count > 0)
            {
                txtCount.Text = lstNombres.Items.Count.ToString();
                txtTotal.Text = Total().ToString();
                txtMoyenne.Text = Moyenne().ToString("F1");
                txtMinimum.Text = Minimum().ToString();
                txtMaximum.Text = Maximum().ToString();
            }
            else
            {
                txtCount.Clear();
                txtTotal.Clear();
                txtMoyenne.Clear();
                txtMinimum.Clear();
                txtMaximum.Clear();
            }
        }
        #endregion

        //==============================================================================================
        private int Total()
        {
            //TODO Q3B1 : Calculer le total (la somme) des nombres de la liste.
            //REMARQUE : Afin de récupérer en format numérique un nombre inscrit dans la liste, vous aurez besoin de faire des conversions.
            //           Par exemple, pour récupérer le premier nombre en format numérique, vous pourriez écrire :
            //                   int nombreLu = int.Parse(lstNombres.Items[0].ToString());
            // À COMPLÉTER
            int total = 0;
            for (int index = 0; index < lstNombres.Items.Count; index++)
            {
                total += int.Parse(lstNombres.Items[index].ToString());  
            }


            return total;    // instruction temporaire pour éviter des erreurs

        }
        //==============================================================================================
        private double Moyenne()
        {
            //TODO Q3B2 : Calculer la moyenne des nombres de la liste.
            //REMARQUE : Pour obtenir le maximum de points, vous devez réutilisez la méthode "Total".
            // À COMPLÉTER
            if (lstNombres.Items.Count > 0)
            {
                return Total() / lstNombres.Items.Count;
            }else
            {
                return 0;
            }

            return 0;    // instruction temporaire pour éviter des erreurs
        }
        //==============================================================================================
        private int Minimum()
        {
            //TODO Q3B2 : Déterminer le nombre le plus petit de la liste.
            // À COMPLÉTER

            int minimum = int.MaxValue;
            for (int index = 0; index < lstNombres.Items.Count; index++)
            {
                int nombrecourant = int.Parse(lstNombres.Items[index].ToString());
                if (nombrecourant < minimum)
                {
                    minimum = nombrecourant;
                }
            }


            return minimum;    // instruction temporaire pour éviter des erreurs
        }
        //==============================================================================================
        private int Maximum()
        {
            //TODO Q3B3 : Déterminer le nombre le plus grand de la liste.
            // À COMPLÉTER
            int maximum = int.MinValue;
            for (int index = 0; index < lstNombres.Items.Count; index++)
            {
                int nombrecourant2 = int.Parse(lstNombres.Items[index].ToString());
                if (nombrecourant2 > maximum)
                {
                    maximum = nombrecourant2;
                }
            }

            return maximum;    // instruction temporaire pour éviter des erreurs
        }
        
        //==============================================================================================
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
