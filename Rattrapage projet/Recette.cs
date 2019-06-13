using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    public class Recette
    {
        int idRecette;
        public string nomRecette;
        public List<Ingredient> ingredientsRecette;
        public int tempsRealisation;
        public int prixRecette;
        public enum typePlat { ENTREE, PLAT, DESSERT };
        public typePlat typeRecette;

        public Recette(string nom, List<Ingredient> ingredients , int temps, typePlat type, int prix)
        {
            nomRecette = nom;
            ingredientsRecette = ingredients;
            tempsRealisation = temps * 1000;
            typeRecette = type;
            prixRecette = prix;
        }
    }


}
