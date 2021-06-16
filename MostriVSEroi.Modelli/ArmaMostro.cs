using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Modelli
{
    public class ArmaMostro
    {
        public string NomeArma { get; set; }
        public int PuntiDanno { get; set; }
        public ArmaMostro(string nome,int danno)
        {
            NomeArma = nome;
            PuntiDanno = danno;

        }
        public ArmaMostro()
        {

        }
    }
}
