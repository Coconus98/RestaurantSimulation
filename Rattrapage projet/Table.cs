using System;
using System.Collections.Generic;
using System.Text;

namespace Rattrapage_projet
{
    public class Table
    {
        public int numTable;
        public int placesTable;
        public GroupeClient clientsTable;
        public bool estOccupe;
        public int rangTable;
        public bool commandePrise;
        public List<Vaisselle> vaisselleTable = new List<Vaisselle>();

        public Table(int places, bool occupe, int num, int rang)
        {
            placesTable = places;
            estOccupe = occupe;
            numTable = num;
            rangTable = rang;
            commandePrise = false;
        }
    }
}
