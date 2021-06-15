using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    class EliminaEroeView
    {
        internal static void EliminaEroe(Utente utente)
        {
            
                List<Eroe> eroi = RichiestaDati.ListaEroi();
                Eroe eroeDaEliminare = RichiestaDati.InserisciIdEroe(eroi);
                eroi.Remove(eroeDaEliminare);

           
        }
    }
}
