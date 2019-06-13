using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    public class Client
    {
        public bool possedeCarte;
        public Table tableClient;
        public Commande commandeClient;
        public Plat platClient;
        public Recette entreeClient;
        public Recette platprincipalClient;
        public Recette dessertClient;

        public Client()
        {
            possedeCarte = false;
        }

        public Commande commmander()
        {
            List<Recette> entree = new List<Recette>();
            List<Recette> plat = new List<Recette>();
            List<Recette> dessert = new List<Recette>();
            Random aleatoire = new Random();
            Creator creator = new Creator();
            int choixEntree = aleatoire.Next(1, 3);
            int choixPlat = aleatoire.Next(1, 3);
            int choixDessert = aleatoire.Next(1, 3);


            switch (choixEntree)
            {
                case 1:
                   entree.Add(creator.searchRecetteByName("oeufs au plat"));
                   this.tableClient.clientsTable.entreesGroupe.Add(creator.searchRecetteByName("oeufs au plat"));
                   this.entreeClient = creator.searchRecetteByName("oeufs au plat");
                   break;
                case 2:
                    entree.Add(creator.searchRecetteByName("bruschetta"));
                    this.tableClient.clientsTable.entreesGroupe.Add(creator.searchRecetteByName("bruschetta"));
                    this.entreeClient = creator.searchRecetteByName("bruschetta");
                    break;
                 default:
                    break;
                }

            switch (choixPlat)
            {
                case 1:
                    plat.Add(creator.searchRecetteByName("bolognaise"));
                    this.tableClient.clientsTable.platsGroupe.Add(creator.searchRecetteByName("bolognaise"));
                    this.platprincipalClient = creator.searchRecetteByName("bolognaise");
                    break;
                case 2:
                    plat.Add(creator.searchRecetteByName("riz au poulet à la crème"));
                    this.tableClient.clientsTable.platsGroupe.Add(creator.searchRecetteByName("riz au poulet à la crème"));
                    this.platprincipalClient = creator.searchRecetteByName("riz au poulet à la crème");
                    break;
                default:
                    break;
            }

            switch (choixDessert)
            {
                case 1:
                    dessert.Add(creator.searchRecetteByName("gateau au chocolat"));
                    this.tableClient.clientsTable.dessertsGroupe.Add(creator.searchRecetteByName("gateau au chocolat"));
                    this.dessertClient = creator.searchRecetteByName("gateau au chocolat");
                    break;
                case 2:
                    dessert.Add(creator.searchRecetteByName("gateau à la vanille"));
                    this.tableClient.clientsTable.dessertsGroupe.Add(creator.searchRecetteByName("gateau à la vanille"));
                    this.dessertClient = creator.searchRecetteByName("gateau à la vanille");
                    break;
                default:
                    break;
            }
            Commande commande = new Commande(entree, plat, dessert);
            commandeClient = commande;
            return commande;
        }
    }
}
