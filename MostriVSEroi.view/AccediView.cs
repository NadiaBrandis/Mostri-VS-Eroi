using MostriVSEroi.Modelli;
using MostriVSEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    static class AccediView
    {
        public static  void Accedi()
        {
           Utente utente= RichiestaDati.InserisciUsernamePassword();
           utente= UtenteServices.VerificaAutenticazione(utente);
        if(utente.IsAuthenticated && utente.IsAdmin)
            {
                //menu admin
            }
        else if(utente.IsAuthenticated && utente.IsAdmin)
            {
                Menu.MenuNonAdmin(utente);
            }
            else
            {
                Console.WriteLine("Devi prima refistrarti");
            }
        }
    }
}
