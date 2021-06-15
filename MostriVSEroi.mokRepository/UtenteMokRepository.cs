using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;

namespace MostriVSEroi.mokRepository
{
    public class UtenteMokRepository : IUtenteRepository
    {
        public Utente GetUser(Utente utente)
        {
           // utente.IsAuthenticated = true;
            return utente;
        }
        public List<Utente> ListaUtenti(List<Utente> utenti)
        {
            return utenti;
        }
    }
}
