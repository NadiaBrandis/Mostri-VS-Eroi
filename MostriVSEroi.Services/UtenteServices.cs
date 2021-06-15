using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;

namespace MostriVSEroi.Services
{
    public class UtenteServices
    {
        static UtenteMokRepository umr = new UtenteMokRepository();
        public static Utente VerificaAutenticazione( Utente utente)
        {
            return umr.GetUser(utente);
        }
       
    }
}
