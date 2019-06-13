using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    class Serveur
    {
        public bool estActif;
        int rangServeur;

        public Serveur(int rang)
        {
            estActif = false;
            rangServeur = rang;
        }

        public void apporterEntree(GroupeClient groupe)
        {
            Creator creator = new Creator();
            for (int i = 0; i < groupe.quantiteClient; i++)
            {
                Creator.vaissellePropre.Remove(Creator.vaissellePropre[0]);
            }

            foreach(Client client in groupe.clientsGroupe)
            {
                client.platClient = creator.searchPlatByName(client.entreeClient.nomRecette);
                Creator.platsEnAttente.Remove(creator.searchPlatByName(client.entreeClient.nomRecette));
            }

            groupe.entreesServies = true;
            groupe.attendsEntree = false;
            Console.WriteLine("Entrées apportées à la table " + groupe.table.numTable + " !");


        }

        public void apporterPlat(GroupeClient groupe)
        {
            Creator creator = new Creator();
            for (int i = 0; i < groupe.quantiteClient; i++)
            {
                Creator.vaissellePropre.Remove(Creator.vaissellePropre[0]);
            }

            foreach (Client client in groupe.clientsGroupe)
            {
                client.platClient = creator.searchPlatByName(client.platprincipalClient.nomRecette);
                Creator.platsEnAttente.Remove(creator.searchPlatByName(client.platprincipalClient.nomRecette));
            }

            groupe.platsServis = true;
            groupe.attendsPlat = false;


        }

        public void apporterDessert(GroupeClient groupe)
        {
            Creator creator = new Creator();
            for (int i = 0; i < groupe.quantiteClient; i++)
            {
                Creator.vaissellePropre.Remove(Creator.vaissellePropre[0]);
            }

            foreach (Client client in groupe.clientsGroupe)
            {
                client.platClient = creator.searchPlatByName(client.dessertClient.nomRecette);
                Creator.platsEnAttente.Remove(creator.searchPlatByName(client.dessertClient.nomRecette));
            }

            groupe.dessertsServis = true;
            groupe.attendsDessert = false;


        }

        public void debarasserTable(GroupeClient groupe)
        {
            for (int i = 0; i < groupe.quantiteClient; i++)
            {
                Creator.vaisselleSale.Add(new Vaisselle(false)) ;
            }

        }

    }
}
