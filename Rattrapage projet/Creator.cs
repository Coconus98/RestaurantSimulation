using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;

namespace Rattrapage_projet
{
    class Creator
    {
        public static List<Recette> recettes = new List<Recette>();
        public static List<Ingredient> ingredients = new List<Ingredient>();
        public static List<Table> tables = new List<Table>();
        public static List<Commande> commandesEnAttente = new List<Commande>();
        public static List<Plat> platsEnAttente = new List<Plat>();
        public static List<Vaisselle> vaissellePropre = new List<Vaisselle>();
        public static List<Vaisselle> vaisselleSale = new List<Vaisselle>();
        public static Caisse caisse = new Caisse();
        public Creator()
        {
        }



        public void instanciation()
        {
            tables.Add(new Table(4, false, 1, 1));
            tables.Add(new Table(4, false, 2, 1));
            tables.Add(new Table(4, false, 3, 1));
            tables.Add(new Table(4, false, 4, 1));
            tables.Add(new Table(4, false, 5, 2));
            tables.Add(new Table(4, false, 6, 2));
            tables.Add(new Table(4, false, 7, 2));
            tables.Add(new Table(4, false, 8, 2));
            tables.Add(new Table(8, false, 9, 3));
            tables.Add(new Table(4, false, 10, 3));
            tables.Add(new Table(8, false, 11, 3));
            tables.Add(new Table(4, false, 12, 4));
            tables.Add(new Table(8, false, 13, 4));
            tables.Add(new Table(4, false, 14, 4));
            Ingredient pates = new Ingredient("pates", 99);
            Ingredient riz = new Ingredient("riz", 99);
            Ingredient poulet = new Ingredient("poulet", 99);
            Ingredient boeuf = new Ingredient("boeuf", 99);
            Ingredient saucetomate = new Ingredient("sauce tomate", 99);
            Ingredient creme = new Ingredient("creme", 99);
            Ingredient chocolat = new Ingredient("chocolat", 99);
            Ingredient vanille = new Ingredient("vanille", 99);
            Ingredient oeuf = new Ingredient("oeuf", 99);
            Ingredient pain = new Ingredient("pain", 99);
            Ingredient tomate = new Ingredient("tomate", 99);
            Ingredient mozzarella = new Ingredient("mozzarella", 99);
            Recette bolognaise = new Recette("spaghetti bolognaise", new List<Ingredient> { pates, boeuf, saucetomate }, 5, Recette.typePlat.PLAT, 15);
            Recette rizpoulet = new Recette("riz au poulet à la crème", new List<Ingredient> { riz, creme, poulet }, 5, Recette.typePlat.PLAT, 12);
            Recette gateauchocolat = new Recette("gateau au chocolat", new List<Ingredient> { chocolat, oeuf }, 5, Recette.typePlat.DESSERT, 8);
            Recette gateauvanille = new Recette("gateau à la vanille", new List<Ingredient> { vanille, oeuf }, 5, Recette.typePlat.DESSERT, 7);
            Recette oeufsauplat = new Recette("oeufs au plat", new List<Ingredient> { oeuf }, 5, Recette.typePlat.ENTREE, 6);
            Recette bruschetta = new Recette("bruschetta", new List<Ingredient> { pain, tomate, mozzarella }, 5, Recette.typePlat.ENTREE, 5);
            recettes.Add(bolognaise);
            recettes.Add(rizpoulet);
            recettes.Add(gateauchocolat);
            recettes.Add(gateauvanille);
            recettes.Add(oeufsauplat);
            recettes.Add(bruschetta);
            ingredients.Add(pates);
            ingredients.Add(riz);
            ingredients.Add(pain);
            ingredients.Add(tomate);
            ingredients.Add(mozzarella);
            ingredients.Add(vanille);
            ingredients.Add(chocolat);
            ingredients.Add(creme);
            ingredients.Add(saucetomate);
            ingredients.Add(oeuf);
            ingredients.Add(boeuf);
            ingredients.Add(poulet);
            for (int i = 0; i < 80; i++)
            {
                vaissellePropre.Add(new Vaisselle(true));
            }



            // Déclaration du thread
            Thread threadClients = new Thread(() => ThreadedApp.arrivageClients());
            Thread threadMaitreHotel = new Thread(() => ThreadedApp.gestionMaitreHotel());
            Thread threadChefDeRang1 = new Thread(() => ThreadedApp.chefDeRang(1));
            Thread threadChefDeRang2 = new Thread(() => ThreadedApp.chefDeRang(2));
            Thread threadChefDeRang3 = new Thread(() => ThreadedApp.chefDeRang(3));
            Thread threadChefDeRang4 = new Thread(() => ThreadedApp.chefDeRang(4));
            Thread threadCuisinier = new Thread(() => ThreadedApp.Cuisine(1));
            Thread threadCuisinier2 = new Thread(() => ThreadedApp.Cuisine(2));
            Thread threadCuisinier3 = new Thread(() => ThreadedApp.Cuisine(3));
            Thread threadCuisinier4 = new Thread(() => ThreadedApp.Cuisine(4));
            Thread threadServeur1 = new Thread(() => ThreadedApp.Service(1, 0));
            Thread threadServeur2 = new Thread(() => ThreadedApp.Service(1, 1000));
            Thread threadServeur3 = new Thread(() => ThreadedApp.Service(2, 0));
            Thread threadServeur4 = new Thread(() => ThreadedApp.Service(2, 1000));
            Thread threadServeur5 = new Thread(() => ThreadedApp.Service(3, 0));
            Thread threadServeur6 = new Thread(() => ThreadedApp.Service(3, 1000));
            Thread threadServeur7 = new Thread(() => ThreadedApp.Service(4, 0));
            Thread threadServeur8 = new Thread(() => ThreadedApp.Service(4, 1000));
            Thread threadCommisCuisine = new Thread(() => ThreadedApp.commisDeCuisine());
            Thread threadSendData = new Thread(() => ThreadedApp.sendData());


            // Instanciation du thread, on spécifie dans le 
            // délégué ThreadStart le nom de la méthode qui
            // sera exécutée lorsque l'on appele la méthode
            // Start() de notre thread.


            // Lancement du thread
            threadClients.Start();
            threadMaitreHotel.Start();
            threadChefDeRang1.Start();
            threadChefDeRang2.Start();
            threadChefDeRang3.Start();
            threadChefDeRang4.Start();
            threadCuisinier.Start();
            threadCuisinier2.Start();
            threadCuisinier3.Start();
            threadCuisinier4.Start();
            threadServeur1.Start();
            //threadServeur2.Start();
            threadServeur3.Start();
            //threadServeur4.Start();
            threadServeur5.Start();
            //threadServeur6.Start();
            threadServeur7.Start();
            //threadServeur8.Start();
            threadCommisCuisine.Start();
            threadSendData.Start();

        }
        public void creationThreadGroupeClient(GroupeClient groupe)
        {
            Thread threadGroupeClient = new Thread(() => ThreadedApp.gestionClient(groupe));
            threadGroupeClient.Start();
        }


        public Recette searchRecetteByName(string name)
        {
            switch (name)
            {
                case "bolognaise":
                    var bolognaise = recettes.First(item => item.nomRecette == "spaghetti bolognaise");
                    return bolognaise;
                case "riz au poulet à la crème":
                    var rizpoulet = recettes.First(item => item.nomRecette == "riz au poulet à la crème");
                    return rizpoulet;
                case "gateau au chocolat":
                    var gateauchocolat = recettes.First(item => item.nomRecette == "gateau au chocolat");
                    return gateauchocolat;
                case "gateau à la vanille":
                    var gateauvanille = recettes.First(item => item.nomRecette == "gateau à la vanille");
                    return gateauvanille;
                case "oeufs au plat":
                    var oeufsauplat = recettes.First(item => item.nomRecette == "oeufs au plat");
                    return oeufsauplat;
                case "bruschetta":
                    var bruschetta = recettes.First(item => item.nomRecette == "bruschetta");
                    return bruschetta;
                default:
                    return new Recette("erreur", new List<Ingredient>(), 1, Recette.typePlat.PLAT, 0);
            }
        }

        public Plat searchPlatByName(string name)
        {
            switch (name)
            {
                case "bolognaise":
                    var bolognaise = platsEnAttente.First(item => item.nomPlat == "spaghetti bolognaise");
                    return bolognaise;
                case "riz au poulet à la crème":
                    var rizpoulet = platsEnAttente.First(item => item.nomPlat == "riz au poulet à la crème");
                    return rizpoulet;
                case "gateau au chocolat":
                    var gateauchocolat = platsEnAttente.First(item => item.nomPlat == "gateau au chocolat");
                    return gateauchocolat;
                case "gateau à la vanille":
                    var gateauvanille = platsEnAttente.First(item => item.nomPlat == "gateau à la vanille");
                    return gateauvanille;
                case "oeufs au plat":
                    var oeufsauplat = platsEnAttente.First(item => item.nomPlat == "oeufs au plat");
                    return oeufsauplat;
                case "bruschetta":
                    var bruschetta = platsEnAttente.First(item => item.nomPlat == "bruschetta");
                    return bruschetta;
                default:
                    return new Plat("erreur");
            }
        }

        public Ingredient searchIngredientByName(string name)
        {
            switch (name)
            {
                case "pates":
                    var pates = ingredients.First(item => item.nomIngredient == "pates");
                    return pates;
                case "riz":
                    var riz = ingredients.First(item => item.nomIngredient == "riz");
                    return riz;
                case "poulet":
                    var poulet = ingredients.First(item => item.nomIngredient == "poulet");
                    return poulet;
                case "boeuf":
                    var boeuf = ingredients.First(item => item.nomIngredient == "boeuf");
                    return boeuf;
                case "sauce tomate":
                    var saucetomate = ingredients.First(item => item.nomIngredient == "sauce tomate");
                    return saucetomate;
                case "creme":
                    var creme = ingredients.First(item => item.nomIngredient == "creme");
                    return creme;
                case "chocolat":
                    var chocolat = ingredients.First(item => item.nomIngredient == "chocolat");
                    return chocolat;
                case "vanille":
                    var vanille = ingredients.First(item => item.nomIngredient == "vanille");
                    return vanille;
                case "oeuf":
                    var oeuf = ingredients.First(item => item.nomIngredient == "oeuf");
                    return oeuf;
                case "pain":
                    var pain = ingredients.First(item => item.nomIngredient == "pain");
                    return pain;
                case "tomate":
                    var tomate = ingredients.First(item => item.nomIngredient == "tomate");
                    return tomate;
                case "mozzarella":
                    var mozzarella = ingredients.First(item => item.nomIngredient == "mozzarella");
                    return mozzarella;
                default:
                    return new Ingredient("erreur", 1);
            }
        }

            /// <summary>
            /// Point d'entrée principal de l'application.
            /// </summary>
            [STAThread]
            public void communicationServeur(string message)
            {


                    //Sérialisation du message en tableau de bytes.
                    byte[] msg = Encoding.Default.GetBytes(message);

                    UdpClient udpClient = new UdpClient();

                    //La méthode Send envoie un message UDP.
                    udpClient.Send(msg, msg.Length, "127.0.0.1", 5035);

                    udpClient.Close();
            }
        }
}
