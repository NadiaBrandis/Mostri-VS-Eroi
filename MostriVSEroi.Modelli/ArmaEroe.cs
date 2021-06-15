using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Modelli
{
    public class ArmaEroe
    {
        public string NomeArma { get; set; }
        public int PuntiDanno { get; set; }

        public ArmaEroe(string arma,int danno)
        {
            NomeArma = arma;
            PuntiDanno = danno;
        }
        public ArmaEroe()
        {

        }
    }
}
