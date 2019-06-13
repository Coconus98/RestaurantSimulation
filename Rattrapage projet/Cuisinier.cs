using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    class Cuisinier
    {
        int idCuisinier;
        public bool estActif;

        public Cuisinier()
        {
            estActif = false;
        }

        public Ingredient Ingredient
        {
            get => default;
            set
            {
            }
        }

        public Recette Recette
        {
            get => default;
            set
            {
            }
        }

        public Plat Plat
        {
            get => default;
            set
            {
            }
        }

        public void Cuisiner(Recette recette)
        {
            Creator creator = new Creator();
            estActif = true;
            Console.WriteLine("Le cuisinier commence la préparation de " + recette.nomRecette);
            System.Threading.Thread.Sleep(recette.tempsRealisation);
            foreach (Ingredient ingredient in recette.ingredientsRecette)
            {
                creator.searchIngredientByName(ingredient.nomIngredient).quantiteIngredient = creator.searchIngredientByName(ingredient.nomIngredient).quantiteIngredient - 1;
            }
            estActif = false;
            Creator.platsEnAttente.Add(new Plat(recette.nomRecette));
            Console.WriteLine("Mmmmmh... Un cuisinier vient de cuisiner un délicieux plat nommé " + recette.nomRecette + " !");
        }
    }
}
