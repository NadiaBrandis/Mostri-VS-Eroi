using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using MostriVSEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    static class AccediView
    {
        public static void Accedi()
        {
            Utente utente = RichiestaDati.InserisciUsernamePassword();


            List<Utente> utenti = UtenteServices.Utenti();
            foreach (var item in utenti)
            {
                if (item.Username == utente.Username && item.Password == utente.Password)
                {
                    Menu.MenuNonAdmin(utente);
                }
                    //if (utente.IsAuthenticated && utente.IsAdmin)
                    //{
                    //    //menu admin
                    //}
                    //else if (utente.IsAuthenticated && utente.IsAdmin)
                    //{
                    //    Menu.MenuNonAdmin(utente);
                    //}
                    else
                    {
                        Console.WriteLine("Devi prima registrarti");
                        RegistratiView.Registrati();

                    }
                }
            }


        }
    }

    

