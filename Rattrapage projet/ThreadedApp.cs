using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Permissions;

namespace Rattrapage_projet
{
    public class ThreadedApp
    {
        static List<GroupeClient> clientsEnAttente = new List<GroupeClient>();

        // Cette méthode est appelé lors du lancement du thread
        // C'est ici qu'il faudra faire notre travail.
        public static void arrivageClients()
        {


            // Tant que le thread n'est pas tué, on travaille
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(5000);
                Random aleatoire = new Random();
                int quantiteClients = aleatoire.Next(1, 9);
                List<Client> lesClients = new List<Client>();
                clientsEnAttente.Add(new GroupeClient(lesClients));
                for (var index = 0; index < quantiteClients; index++)
                {
                    clientsEnAttente[0].clientsGroupe.Add(new Client());
                }
                // Attente de 10000 ms             
                // Affichage dans la console
                Console.WriteLine(clientsEnAttente[0].clientsGroupe.Count + " clients sont arrivés !\n");
                Thread.Sleep(55000);
            }
        }

        public static void gestionMaitreHotel()
        {
            MaitreHotel maitrehotel = new MaitreHotel();
            Creator creator = new Creator();
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(3000);
                if (clientsEnAttente?.Any() != false)
                {
                    maitrehotel.acceuilClient(clientsEnAttente[0]);
                    creator.creationThreadGroupeClient(clientsEnAttente[0]);
                    clientsEnAttente.Remove(clientsEnAttente[0]);
                }
            }
        }

        public static void chefDeRang(int rang)
        {
            ChefDeRang chefderang = new ChefDeRang(rang);
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(5000);
                foreach (Table table in Creator.tables)
                {
                    if (table.rangTable == rang)
                    {
                        if (table.estOccupe == true & table.commandePrise == false)
                        {
                            chefderang.prendreCommande(table);
                            Console.WriteLine("Les commandes de la table " + table.numTable + "a été ajouté à la liste !");
                            Console.WriteLine("La liste est désormais composée de :");
                            foreach (Commande commande in Creator.commandesEnAttente)
                            {
                                Console.WriteLine(commande.recettesCommandeEntree[0].nomRecette + " + " + commande.recettesCommandePlat[0].nomRecette + " + " + commande.recettesCommandeDessert[0].nomRecette);
                            }
                        }
                    }
                }

            }
        }

        public static void Cuisine(int rang)
        {
            Cuisinier cuisinier = new Cuisinier();
            cuisinier.estActif = false;
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(1000);


                foreach (Table table in Creator.tables)
                {
                    if (table.estOccupe == true & table.rangTable == rang)
                    {

                        if (table.clientsTable.attendsEntree == true & table.clientsTable.preparationEntrees == false)
                        {
                            table.clientsTable.preparationEntrees = true;
                            foreach (Recette recette in table.clientsTable.entreesGroupe)
                            {
                                    cuisinier.estActif = true;
                                    cuisinier.Cuisiner(recette);
                                    cuisinier.estActif = false;
                            }
                            table.clientsTable.entreesPretes = true;
                        }

                        if (table.clientsTable.attendsPlat == true & table.clientsTable.preparationPlats == false)
                        {
                            table.clientsTable.preparationPlats = true;
                            foreach (Recette recette in table.clientsTable.platsGroupe)
                            {
                                    cuisinier.estActif = true;
                                    cuisinier.Cuisiner(recette);
                                    cuisinier.estActif = false;
                            }
                            table.clientsTable.platsPrets = true;
                        }

                        if (table.clientsTable.attendsDessert == true & table.clientsTable.preparationsDesserts == false & table.clientsTable.dessertsPrets == false)
                        {
                            foreach (Recette recette in table.clientsTable.dessertsGroupe)
                            {
                                    cuisinier.estActif = true;
                                    cuisinier.Cuisiner(recette);
                                    cuisinier.estActif = false;
                            }
                            table.clientsTable.dessertsPrets = true;
                        }
                    }

                }
            }

        }


        public static void Service(int rang, int synchronisation)
        {
            Serveur serveur = new Serveur(rang);
            Serveur serveur2 = new Serveur(rang);
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(1000);
                foreach (Table table in Creator.tables)
                {
                    if (table.estOccupe == true & table.rangTable == rang)
                    {
                        if (table.clientsTable.attendsEntree == true & table.clientsTable.seFaitServir == false & table.clientsTable.entreesPretes)
                        {
                            if(serveur.estActif == false)
                            {
                                serveur.estActif = true;
                                table.clientsTable.seFaitServir = true;
                                serveur.apporterEntree(table.clientsTable);
                                table.clientsTable.seFaitServir = false;
                                serveur.estActif = false;
                            }
                            else if(serveur2.estActif == false)
                            {
                                serveur2.estActif = true;
                                table.clientsTable.seFaitServir = true;
                                serveur.apporterEntree(table.clientsTable);
                                table.clientsTable.seFaitServir = false;
                                serveur2.estActif = false;
                            }
                            
                        }

                        if (table.clientsTable.attendsPlat == true & table.clientsTable.seFaitServir == false & table.clientsTable.platsPrets)
                        {
                            if (serveur.estActif == false)
                            {
                                serveur.estActif = true;
                                table.clientsTable.seFaitServir = true;
                                serveur.apporterPlat(table.clientsTable);
                                table.clientsTable.seFaitServir = false;
                                serveur.estActif = false;
                            }
                            else if (serveur2.estActif == false)
                            {
                                serveur2.estActif = true;
                                table.clientsTable.seFaitServir = true;
                                serveur.apporterPlat(table.clientsTable);
                                table.clientsTable.seFaitServir = false;
                                serveur2.estActif = false;
                            }
                        }

                        if (table.clientsTable.attendsDessert == true & table.clientsTable.seFaitServir == false & table.clientsTable.dessertsPrets)
                        {
                            if (serveur.estActif == false)
                            {
                                serveur.estActif = true;
                                table.clientsTable.seFaitServir = true;
                                serveur.apporterDessert(table.clientsTable);
                                table.clientsTable.seFaitServir = false;
                                serveur.estActif = false;
                            }
                            else if (serveur2.estActif == false)
                            {
                                serveur2.estActif = true;
                                table.clientsTable.seFaitServir = true;
                                serveur.apporterDessert(table.clientsTable);
                                table.clientsTable.seFaitServir = false;
                                serveur2.estActif = false;
                            }
                        }
                    }
                }
            }

        }


        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        public static void gestionClient(GroupeClient groupe)
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(1000);
                if (groupe.entreesServies == true & groupe.entreesFinies == false)
                {
                    groupe.mangerEntrees();
                }

                if (groupe.platsServis == true & groupe.platsFinis == false)
                {
                    groupe.mangerPlats();
                }

                if (groupe.dessertsServis == true & groupe.dessertsFinis == false)
                {
                    groupe.mangerDesserts();
                }

                if (groupe.finiDeManger == true & groupe.payementEffectue == false)
                {
                    groupe.payer();
                    groupe.partir();
                    break;
                }


            }

        }

        public static void sendData()
        {
            Creator creator = new Creator();
            while (Thread.CurrentThread.IsAlive)
            {
                foreach (Table table in Creator.tables)
                {
                    if (table.estOccupe == true)
                    {
                        creator.communicationServeur("Occupee");
                        string quantite = table.clientsTable.clientsGroupe.Count.ToString();
                        creator.communicationServeur(quantite);
                        if (table.clientsTable.entreesServies == true & table.clientsTable.entreesFinies == false)
                        {
                            creator.communicationServeur("Entrees");
                        }
                        else if (table.clientsTable.platsServis == true & table.clientsTable.platsFinis == false)
                        {
                            creator.communicationServeur("Plats");
                        }
                        else if (table.clientsTable.dessertsServis == true & table.clientsTable.dessertsFinis == false)
                        {
                            creator.communicationServeur("Desserts");
                        }
                        else
                        {
                            creator.communicationServeur("/");
                        }

                    }
                    else
                    {
                        creator.communicationServeur("Libre");
                        creator.communicationServeur("/");
                        creator.communicationServeur("/");
                    }
                }

                creator.communicationServeur(Creator.vaissellePropre.Count.ToString());
                creator.communicationServeur(Creator.vaisselleSale.Count.ToString());
                creator.communicationServeur(creator.searchIngredientByName("riz").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("pates").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("creme").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("tomate").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("mozzarella").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("poulet").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("boeuf").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("pain").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("chocolat").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("vanille").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("oeuf").quantiteIngredient.ToString());
                creator.communicationServeur(creator.searchIngredientByName("sauce tomate").quantiteIngredient.ToString());
                Thread.Sleep(2000);
                creator.communicationServeur("clear");
            }

        }

        public static void commisDeCuisine()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(1000);
                Commis commis = new Commis();
                if (Creator.vaisselleSale?.Any() != false)
                {
                    commis.laverVaisselle();
                }                
            }
        }

    }
}
