using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Modelli
{
    public class Eroe 
    {
       

        public string NomeEroe { get; set; }
        public string Categoria { get; set; }
        public ArmaEroe Arma { get; set; }

        public Eroe(string nome,string categoria,ArmaEroe arma)
        {
            NomeEroe = nome;
            Categoria = categoria;
            Arma = arma;

        }

    }
}
