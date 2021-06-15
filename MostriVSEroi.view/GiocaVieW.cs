using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using MostriVSEroi.Services;
using System;
using System.Collections.Generic;

namespace MostriVSEroi.view
{
    internal class GiocaVieW
    {
        internal static void Gioca(Utente utente)
        {
            //stampa tutti gli eroi
            List<Eroe> eroi = RichiestaDati.ListaEroi();
            List<Mostro> mostri = RichiestaDati.ListaMostri();
            EroeServices.GetEroi(eroi);
            //scelta eroe
            int id=RichiestaDati.SceltaEroe();
            Eroe eroeScelto=EroeServices.GetEroe(id,eroi);
            //scelta mostro
            Mostro mostroScelto = MostroServices.GetMostro(mostri);
            //partita
            int punteggio=PartitaServices.GiocaPartita(eroeScelto, mostroScelto);
            //calcolo punteggio e livello
           eroeScelto.Livello=PartitaServices.CalcoloPunteggio(eroeScelto,mostroScelto);
            //giocare ancora
            GiocaVieW.Gioca(utente);
        }
    }
}