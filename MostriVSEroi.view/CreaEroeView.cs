using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    public class CreaEroeView
    {
        
        internal static void CreaEroe(Utente utente)
        {
            List<Eroe> eroi = RichiestaDati.ListaEroi();
            Eroe nuovoEroe = RichiestaDati.InserisciDatiEroe(eroi);
            eroi.Add(nuovoEroe);

        }
    }
}
