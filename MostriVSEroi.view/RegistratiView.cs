using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using MostriVSEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    public class RegistratiView
    {
        public static void Registrati()
        {
            Utente utente = RichiestaDati.InserisciUsernamePassword();
            List<Utente> utenti = UtenteDbRepository.GetUtenti();
            UtenteServices.CreaNuovoUtente(utente, utenti);
            Menu.MenuNonAdmin(utente);
        }
    }
}
