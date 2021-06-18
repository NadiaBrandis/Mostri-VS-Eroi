using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostriVSEroi.Services
{
    public class MostroServices
    {
        public static List<Mostro> GetMostri()
        {
            List<Mostro> mostri = MostriDbRepository.GetMostri();
            int count = 1;
            foreach (var item in mostri)
            {

                count++;

            }
            return mostri;
        }
      

        public static Mostro GetMostro(List<Mostro> mostri)
        {
            Dictionary<int, Mostro> DizionarioMostri = new Dictionary<int, Mostro>();
            int i = 0;
            foreach (var item in mostri)
            {
                DizionarioMostri.Add(i,item);
                i++;
            }
            Mostro mostro = new Mostro();
            
            Random rand = new Random();
            int num = rand.Next(DizionarioMostri.Count);
            mostro = DizionarioMostri[num];


            
        
            return mostro ;
           
        }

        internal static void MostroAttaccaEroe(Eroe eroeScelto, Mostro mostroScelto)
        {
            eroeScelto.PuntiVita = eroeScelto.PuntiVita - mostroScelto.Arma.PuntiDanno;

            Console.WriteLine($"PUNTI VITA EROE: {eroeScelto.PuntiVita}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
            Console.WriteLine($"PUNTI VITA MOSTRO: {mostroScelto.PuntiVita}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");

        }

    }
}
