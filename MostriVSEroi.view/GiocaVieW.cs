using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;

namespace MostriVSEroi.view
{
    internal class GiocaVieW
    {
        internal static void Gioca(Utente utente)
        {
            EroiMockRepository.StampaListaEroi();
            //scelta eroe
            Console.Write("Inserisci Id del Eroe che vuoi far combattere:");
            int id = int.Parse(Console.ReadLine());
            //scelta mostro
            MostriMockRepository.SceltaMostro();
           //partita
           //calcolo punteggio e livello
           //giocare ancora
        }
    }
}