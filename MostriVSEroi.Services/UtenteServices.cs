using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;
using System.Collections.Generic;

namespace MostriVSEroi.Services
{
    public class UtenteServices
    {
        static UtenteMokRepository umr = new UtenteMokRepository();
        public static Utente VerificaAutenticazione( Utente utente)
        {
            return umr.GetUser(utente);
        }

        public static void CreaNuovoUtente(Utente utente, List<Utente> utenti)
        {
            foreach (var item in utenti)
            {
                if (item.Username != utente.Username)
                {
                    utenti.Add(item);
                }
                else
                {
                    Console.WriteLine("Username già esistente, inseriscine un altro!!");
                }
            }
        }
    }
}
