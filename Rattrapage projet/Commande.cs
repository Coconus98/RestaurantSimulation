using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    public class Commande
    {
        int idCommande;
        public List<Recette> recettesCommandeEntree;
        public List<Recette> recettesCommandePlat;
        public List<Recette> recettesCommandeDessert;

        public Commande(List<Recette> recettesEntree, List<Recette> recettesPlat, List<Recette> recettesDessert)
        {
            recettesCommandeEntree = recettesEntree;
            recettesCommandePlat = recettesPlat;
            recettesCommandeDessert = recettesDessert;
        }
    }
}
