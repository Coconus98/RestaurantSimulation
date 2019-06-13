using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    class MaitreHotel
    {
        int idMaitreHotel;
        bool estActif;

        public MaitreHotel()
        {
        }

        public void acceuilClient(GroupeClient groupeclient)
        {
            bool clientAssis = false;
            if (groupeclient.clientsGroupe.Count <= 4)
            {
                foreach(Table table in Creator.tables)
                {
                    if(table.placesTable == 4 && table.estOccupe == false)
                    {
                        table.estOccupe = true;
                        table.clientsTable = groupeclient;
                        groupeclient.table = table;
                        Console.WriteLine("Le Maitre d'Hotel a assis le(s) client(s) à la table " + groupeclient.table.numTable + "\n");
                        clientAssis = true;
                        break;
                    }

                }

                if(clientAssis == false)
                {
                    Console.WriteLine("Aucune table dispo :( \n");
                }

                clientAssis = false;
                
            }
            else if (groupeclient.clientsGroupe.Count > 4)
            {
                foreach (Table table in Creator.tables)
                {
                    if (table.placesTable == 8 && table.estOccupe == false)
                    {
                        table.estOccupe = true;
                        table.clientsTable = groupeclient;
                        groupeclient.table = table;
                        clientAssis = true;
                        Console.WriteLine("Le Maitre d'Hotel a assis le(s) client(s) à la table " + groupeclient.table.numTable + "\n");
                        break;
                    }
                }

                if (clientAssis == false)
                {
                    Console.WriteLine("Aucune table dispo :( \n");
                }

                clientAssis = false;


            }
        }
    }
}
