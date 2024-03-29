﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Rattrapage___Supervision
{
    public class Listener
    {
        public static List<String> dataReceived = new List<String>();

        public Listener()
        {

        }

        public static void Ecouter()
        {
            //Console.WriteLine("Préparation à l'écoute...");

            //On crée le serveur en lui spécifiant le port sur lequel il devra écouter.
            UdpClient serveur = new UdpClient(5035);

            //Création d'une boucle infinie qui aura pour tâche d'écouter.
            while (true)
            {
                //Création d'un objet IPEndPoint qui recevra les données du Socket distant.
                IPEndPoint client = null;
                //Console.WriteLine("ÉCOUTE...");

                //On écoute jusqu'à recevoir un message.
                byte[] data = serveur.Receive(ref client);
                //Console.WriteLine("Données reçues en provenance de {0}:{1}.", client.Address, client.Port);

                //Décryptage et affichage du message.
                string message = Encoding.Default.GetString(data);
                dataReceived.Add(message);
                if (message == "clear")
                {
                    dataReceived.Clear();
                }
                //Console.WriteLine("CONTENU DU MESSAGE : {0}\n", message);
            }
        }
    }
}