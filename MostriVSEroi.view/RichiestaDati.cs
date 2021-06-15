using MostriVSEroi.Modelli;
using MostriVSEroi.SchermataServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    class RichiestaDati
    {
        internal static Utente InserisciUsernamePassword()
        {
            Console.WriteLine("Inserisci Username");
            string username = Console.ReadLine();
            Console.WriteLine("Inserisci password");
            string password = Console.ReadLine();
           return UtenteSchermataServices.GetUtente(username, password);
            
        }
    }
}
