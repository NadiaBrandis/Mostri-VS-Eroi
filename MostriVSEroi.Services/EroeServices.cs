using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Services
{
    public static class EroeServices
    {
        static EroiDbRepository emr = new EroiDbRepository();
        public static List<Eroe> GetEroi()
        {
            List<Eroe> eroi = EroiDbRepository.GetEroi();
            int count = 1;
            foreach (var item in eroi)
            {

                Console.WriteLine($"[{item.idEroe}]-Nome Eroe:{item.NomeEroe} -Categoria:{item.Categoria}" +
                    $"-Arma:{item.Arma.NomeArma} -Punti Danno: {item.Arma.PuntiDanno}");
                count++;

            }
            return eroi;
        }

        public static Eroe GetEroe(int id, List<Eroe> eroi)
        {
            Eroe eroe = new Eroe();
            foreach (var item in eroi)
            {
                if (item.idEroe == id)
                {

                    return item;
                }

            }
            return eroe;

        }

        
        public static void EroeAttaccaMostro(Eroe eroe, Mostro mostro)
        {
            mostro.PuntiVita = mostro.PuntiVita - eroe.Arma.PuntiDanno;

            Console.WriteLine($"PUNTI VITA EROE: {eroe.PuntiVita}----ARMA EROE: {eroe.Arma.NomeArma}={eroe.Arma.PuntiDanno}");
            Console.WriteLine($"PUNTI VITA MOSTRO: {mostro.PuntiVita}-----ARMA MOSTRO:{mostro.Arma.NomeArma}={mostro.Arma.PuntiDanno}");

        }
    }
}
