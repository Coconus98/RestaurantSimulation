using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Rattrapage_projet
{
    public class GroupeClient
    {
        public int quantiteClient;
        public bool possedeCarte;
        public List<Client> clientsGroupe = new List<Client>();
        public Table table;
        public List<Recette> entreesGroupe = new List<Recette>();
        public List<Recette> platsGroupe = new List<Recette>();
        public List<Recette> dessertsGroupe = new List<Recette>();
        public bool attendsEntree;
        public bool attendsPlat;
        public bool attendsDessert;
        public bool preparationEntrees;
        public bool preparationPlats;
        public bool preparationsDesserts;
        public bool entreesPretes;
        public bool platsPrets;
        public bool dessertsPrets;
        public bool entreesServies;
        public bool platsServis;
        public bool dessertsServis;
        public bool finiDeManger;
        public bool seFaitServir;
        public bool entreesFinies;
        public bool platsFinis;
        public bool dessertsFinis;
        public bool payementEffectue;
        public int nbrEntreesPretes;
        public int nbrPlatsPrets;
        public int nbrDessertsPrets;

        public GroupeClient(List<Client> clientsDuGroupe)
        {
            clientsDuGroupe = clientsGroupe;
            attendsPlat = false;
            attendsEntree = false;
            attendsDessert = false;
            preparationEntrees = false;
            preparationPlats = false;
            preparationsDesserts = false;
            entreesPretes = false;
            platsPrets = false;
            dessertsPrets = false;
            entreesServies = false;
            platsServis = false;
            dessertsServis = false;
            finiDeManger = false;
            seFaitServir = false;
            nbrEntreesPretes = 0;
            nbrPlatsPrets = 0;
            nbrDessertsPrets = 0;
        }

        internal Caisse Caisse
        {
            get => default;
            set
            {
            }
        }

        public Client Client
        {
            get => default;
            set
            {
            }
        }

        public void mangerEntrees()
        {
            this.attendsPlat = true;
            Thread.Sleep(7000);
            this.entreesFinies = true;
            Console.WriteLine("Le groupe de la table " + this.table.numTable + " a fini les entrées ! Ils attendent le plat avec impatience...");
        }

        public void mangerPlats()
        {
            this.attendsDessert = true;
            Thread.Sleep(7000);
            this.platsFinis = true;
            Console.WriteLine("Le groupe de la table " + this.table.numTable + " a fini les plats ! Ils attendent le dessert avec impatience...");
        }

        public void mangerDesserts()
        {
            Thread.Sleep(7000);
            this.dessertsFinis = true;
            this.finiDeManger = true;
            Console.WriteLine("Le groupe de la table " + this.table.numTable + " a fini de manger ! Ils attendent l'addition, mais sans impatience cette fois !");
        }

        public void payer()
        {
            foreach(Recette recette in this.entreesGroupe)
            {
                Creator.caisse.argent += recette.prixRecette;
            }
            foreach (Recette recette in this.platsGroupe)
            {
                Creator.caisse.argent += recette.prixRecette;
            }
            foreach (Recette recette in this.dessertsGroupe)
            {
                Creator.caisse.argent += recette.prixRecette;
            }

            Console.WriteLine("Cling cling ! Les clients ont payé, il y a désormais " + Creator.caisse.argent + " euros dans la caisse");
            payementEffectue = true;

        }

        public void partir()
        {
            foreach(Client client in this.clientsGroupe)
            {
                Creator.commandesEnAttente.Remove(client.commandeClient);
            }
            this.table.estOccupe = false;
        }
    }

}
