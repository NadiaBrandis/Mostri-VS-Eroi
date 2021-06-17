using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.SchermataServices
{
    public class EroeSchermataServices
    {
        public static Eroe GetEroe(int Id,string nome, string categoria, string arma, int puntiDanno,int livello,int puntiVita)
        {
            ArmaEroe armaE = new ArmaEroe(arma, puntiDanno);
            return new Eroe(Id,nome, categoria, armaE,livello,puntiVita);
        }
    }
}
