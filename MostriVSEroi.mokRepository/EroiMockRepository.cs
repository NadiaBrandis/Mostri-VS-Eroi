using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.mokRepository
{
    public  class EroiMockRepository
    {
       
        public List<Eroe> ListaEroi(List<Eroe> eroi)
        {
            Eroe eroe1 = new Eroe();
            string nome = "Falco Assassino";
            eroe1.Categoria= "Guerriero";
            eroe1.Arma.NomeArma= "spada";
            eroe1.Arma.PuntiDanno= 10;
            eroe1.Livello= 1;
            eroe1.PuntiVita= 30;
            eroe1.NomeEroe = nome;
            eroe1.idEroe = 1;


            return eroi;
        }
    }
}
