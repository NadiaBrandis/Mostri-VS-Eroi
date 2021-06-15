using MostriVSEroi.Modelli;
using System;

namespace MostriVSEroi.view
{
    public static class Menu
    {
        public static void MenuPrincipale()
        {
            bool continua = true;
            do
            {
                Console.WriteLine("--------MOSTRI VS EROI--------");
                Console.WriteLine("1. Accedi");
                Console.WriteLine("2. Registrati");
                Console.WriteLine("0. Esci");
                Console.WriteLine("seleziona il percorso che vuoi seguire");

                string scelta = Console.ReadLine();
                switch(scelta)
                {
                    case "1":
                        AccediView.Accedi();
                        break;
                    case "2":
                        break;
                    case "0":
                        Console.WriteLine("Alla prossima partita!!");
                        continua = false;
                        break;


                }

            } while (continua);

        }

        public static void MenuNonAdmin(Utente utente)
        {
            Console.WriteLine("-------ACCESSO EFFETTUATO-----");
            bool continua = true;
            do
            {
                Console.WriteLine("1. Gioca");
                Console.WriteLine("2. Crea nuovo Eroe");
                Console.WriteLine("3. Elimina Eroe");
                Console.WriteLine("0. Esci");
                Console.WriteLine("Seleziona il percorso che vuoi seguire");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        GiocaVieW.Gioca(utente);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "0":
                        MenuPrincipale();
                        Console.WriteLine("Alla prossima partita!!");
                        continua = false;
                        break;
                }

            } while (continua);
        }
    }
}
