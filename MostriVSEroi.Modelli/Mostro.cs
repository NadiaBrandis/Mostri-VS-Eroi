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
        public int PuntiVita { get; set; }
        public int Livello { get; set; }
        public Mostro(string nome,string categoria,ArmaMostro arma, int puntiVita)
        {
            NomeMostro = nome;
            CategoriaMostro = categoria;
            Arma = arma;
            PuntiVita=puntiVita;
        }
        public Mostro(string nome,ArmaMostro arma ,int puntiVita)
        {
            NomeMostro = nome;
            Arma = arma;
            PuntiVita = puntiVita;
        }
        public Mostro()
        {

        }
    }
}
