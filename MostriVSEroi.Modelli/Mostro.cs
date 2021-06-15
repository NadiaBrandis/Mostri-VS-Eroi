using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Modelli
{
    public class Mostro
    {
        public string NomeMostro { get; set; }
        public string CategoriaMostro { get; set; }
        public ArmaMostro Arma { get; set; }
        public Mostro(string nome,string categoria,ArmaMostro arma)
        {
            NomeMostro = nome;
            CategoriaMostro = categoria;
            Arma = arma;
        }
    }
}
