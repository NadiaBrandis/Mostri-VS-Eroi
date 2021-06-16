using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Services
{
    public class PartitaServices
    {
        public static int GiocaPartita(Eroe eroeScelto, Mostro mostroScelto)
        {
            //i punti vita del eroe in realtà sono quelli del utente
            int nuoviPuntiVitaMostro;
            int nuoviPuntiVitaEroe;
            string scelta;
            int puntiTotali;
          
                Console.WriteLine("Vuoi Attaccare o Fuggire?");
                Console.WriteLine("1. Attacco");
                Console.WriteLine("2. Fuga");
               scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        do
                        {
                            nuoviPuntiVitaMostro = ConteggioPuntiMostro(eroeScelto, mostroScelto);//mostro-eroe
                            nuoviPuntiVitaEroe = ConteggioPuntiEroe(eroeScelto, mostroScelto);//eroe-mostro
                        puntiTotali = nuoviPuntiVitaEroe - nuoviPuntiVitaMostro;
                        Console.WriteLine(puntiTotali);
                        } while (puntiTotali > 0);
                        if (nuoviPuntiVitaEroe <= 0 && nuoviPuntiVitaMostro > nuoviPuntiVitaEroe)
                        {

                            Console.WriteLine("HAI PERSO!!");
                        }
                        else if (nuoviPuntiVitaEroe >= 0 && nuoviPuntiVitaMostro < nuoviPuntiVitaEroe)
                        {
                            Console.WriteLine("HAI VINTO!!");
                            return nuoviPuntiVitaEroe;
                        }
                        break;

                    case "2":
                        return 10;

                }

            return 0;
           
        }

        public static int CalcoloPunteggio(Eroe eroeScelto,Mostro mostroScelto)
        {
           int livelloEroe = eroeScelto.Livello;
           int LivelloMostro = mostroScelto.Livello;
           int punteggioAccumulato = eroeScelto.Arma.PuntiDanno * LivelloMostro;
           if(punteggioAccumulato >0 && punteggioAccumulato <= 29)
            {
                livelloEroe = 1;
                
            }
           else if(punteggioAccumulato > 30 && punteggioAccumulato <= 59)
            {
                livelloEroe = 2;
            }
            else if (punteggioAccumulato > 60 && punteggioAccumulato <= 89)
            {
                livelloEroe = 3;
            }
            else if (punteggioAccumulato > 90 && punteggioAccumulato <= 119)
            {
                livelloEroe = 4;
            }
            else
            {
                livelloEroe = 4;
            }
            return livelloEroe;

        }

        private static int ConteggioPuntiEroe(Eroe eroe, Mostro mostroScelto)
        {
            int nuoviPuntiVitaEroe = eroe.PuntiVita - mostroScelto.Arma.PuntiDanno;
            Console.WriteLine($"-{nuoviPuntiVitaEroe} Punti vita per {eroe.NomeEroe}");
            return nuoviPuntiVitaEroe;
        }

        private static int ConteggioPuntiMostro(Eroe eroeScelto, Mostro mostroScelto)
        {
            int nuoviPuntivitaMostro = mostroScelto.PuntiVita - eroeScelto.Arma.PuntiDanno;
            Console.WriteLine($"-{nuoviPuntivitaMostro} Punti vita per {mostroScelto.NomeMostro}");
            return nuoviPuntivitaMostro;
        }
    }
}
