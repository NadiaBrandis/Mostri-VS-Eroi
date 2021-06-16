using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;
using System.Collections.Generic;

namespace MostriVSEroi.Services
{
    public class UtenteServices
    {
        static UtenteDbRepository umr = new UtenteDbRepository();
        
        
        public static List<Utente> Utenti()
        {
            List<Utente> utenti = UtenteDbRepository.GetUtenti();
            return utenti;
        }

        public static void CreaNuovoUtente(Utente utente, List<Utente> utenti)
        {
            foreach (var item in utenti)
            {
                if (item.Username != utente.Username)
                {
                    //utenti.Add(item);
                    UtenteDbRepository.InserisciUtente(utente.Username, utente.Password);
                    break;
                }
                else
                {
                    
                    Console.WriteLine("Username già esistente, inseriscine un altro!!");
                    //RegistratiView.Registrati();
                }
            }
        }
    }
}
