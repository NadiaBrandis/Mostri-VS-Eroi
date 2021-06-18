using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    public class CreaEroeView
    {
        
        internal static void CreaEroe(Utente utente)
        {
            List<Eroe> eroi = EroiDbRepository.GetEroi();
            List<ArmaEroe> armi = EroiDbRepository.GetArma();
            Eroe nuovoEroe = RichiestaDati.InserisciDatiEroe(armi,eroi);
            EroiDbRepository.CreaEroe(nuovoEroe.NomeEroe, nuovoEroe.Categoria, nuovoEroe.Arma.NomeArma, nuovoEroe.Livello, nuovoEroe.PuntiVita);
            eroi.Add(nuovoEroe);

        }
    }
}
