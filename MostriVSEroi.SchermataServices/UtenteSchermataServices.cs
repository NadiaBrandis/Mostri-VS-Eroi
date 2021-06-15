using MostriVSEroi.Modelli;
using System;

namespace MostriVSEroi.SchermataServices
{
    public class UtenteSchermataServices
    {
        public static Utente GetUtente(string username, string password)
        {
            return new Utente(username,password);
        }
    }
}
