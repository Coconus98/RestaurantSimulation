using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Rattrapage___Supervision
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            //Préparation et démarrage du thread en charge d'écouter.
            Thread threadEcoute = new Thread(() => Listener.Ecouter());
            threadEcoute.Start();

            bool continuer = true;

            while (continuer)
            {

                Application.Run(new Form1());
            }
        }
    }
}
