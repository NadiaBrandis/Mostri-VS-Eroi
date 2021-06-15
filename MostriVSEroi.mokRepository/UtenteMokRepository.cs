using MostriVSEroi.Modelli;
using System;

namespace MostriVSEroi.mokRepository
{
    public class UtenteMokRepository : IUtenteRepository
    {
        public Utente GetUser(Utente utente)
        {
           // utente.IsAuthenticated = true;
            return utente;
        }
    }
}
