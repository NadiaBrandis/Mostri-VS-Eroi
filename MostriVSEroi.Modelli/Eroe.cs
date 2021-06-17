using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Modelli
{
    public class Eroe 
    {

        public int idEroe { get; set; }
        public string NomeEroe { get; set; }
        public string Categoria { get; set; }
        public ArmaEroe Arma { get; set; }
        public int Livello { get; set; } = 1;
        public int PuntiVita { get; set; } = 20;

        public Eroe(int ideroe,string nome,string categoria,ArmaEroe arma,int livello,int punti)
        {
            idEroe = ideroe;
            NomeEroe = nome;
            Categoria = categoria;
            Arma = arma;
            Livello = livello;
            PuntiVita = punti;
           
        }
        public Eroe()
        {

        }

    }
}
