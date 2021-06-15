using MostriVSEroi.Modelli;
using MostriVSEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    class RegistratiView
    {
        internal static void Registrati()
        {
            Utente utente = RichiestaDati.InserisciUsernamePassword();
            List<Utente> utenti = RichiestaDati.ListaUtenti();
            UtenteServices.CreaNuovoUtente(utente, utenti);
        }
    }
}
