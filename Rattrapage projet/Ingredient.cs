using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    public class Ingredient
    {
        int idIngredient;
        public string nomIngredient;
        public int quantiteIngredient;

        public Ingredient(string nom, int quantite)
        {
            nomIngredient = nom;
            quantiteIngredient = quantite;
        }


    }
}
