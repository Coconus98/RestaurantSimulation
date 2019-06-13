using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    class ChefDeRang
    {
        public int idChefDeRang;
        public int rangChefDeRang;

        public ChefDeRang(int rang)
        {
            rangChefDeRang = rang;
        }

        public void donnerCarte(Table table)
        {
            table.clientsTable.possedeCarte = true;
            //retirer carte du stock par quantité client
        }

        public void prendreCommande(Table table)
        {
            foreach (Client client in table.clientsTable.clientsGroupe)
            {
                client.tableClient = table;
                Creator.commandesEnAttente.Add(client.commmander());
                client.possedeCarte = false;
            }
            table.commandePrise = true;
            table.clientsTable.attendsEntree = true;
        }

        public void recupererCarte(Table table)
        {

        }
    }
}
