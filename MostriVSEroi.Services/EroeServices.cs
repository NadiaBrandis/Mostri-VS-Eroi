using MostriVSEroi.Modelli;
using MostriVSEroi.mokRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Services
{
    public static class EroeServices
    {
        static EroiMockRepository emr = new EroiMockRepository();
        public static List<Eroe> GetEroi(List<Eroe> eroi)
        {
            
            int count = 1;
            foreach (var item in eroi)
            {

                Console.WriteLine($"[{count}]-Nome Eroe:{item.NomeEroe} -Categoria:{item.Categoria}" +
                    $"-Arma:{item.Arma} -Punti Vita{item.PuntiVita}");
                count++;
                
            }
            return emr.ListaEroi(eroi);
        }

        public static Eroe GetEroe(int id ,List<Eroe>eroi)
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
    }
}
