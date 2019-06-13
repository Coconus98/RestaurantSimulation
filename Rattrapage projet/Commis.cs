using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Rattrapage_projet
{
    class Commis
    {
        bool estActif;

        public Commis()
        {
            estActif = false;
        }


        public void laverVaisselle()
        {
            foreach(Vaisselle vaissellesale in Creator.vaisselleSale)
            {
                Thread.Sleep(1000);
                Creator.vaisselleSale.Remove(Creator.vaisselleSale[0]);
                Creator.vaissellePropre.Add(new Vaisselle(true));
            }

        }
    }
}
