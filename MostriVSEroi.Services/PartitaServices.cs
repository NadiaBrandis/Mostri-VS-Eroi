using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Services
{
    public class PartitaServices
    {
        public static void GiocaPartita(Utente utente,Eroe eroeScelto, Mostro mostroScelto)
        {
            //i punti vita del eroe in realtà sono quelli del utente
            
            
           
            Console.WriteLine($"PUNTI VITA EROE: {eroeScelto.PuntiVita}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
            Console.WriteLine($"PUNTI VITA MOSTRO: {mostroScelto.PuntiVita}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");
          

            Console.WriteLine("");
            string scelta1;
             Console.WriteLine("1. Attacco");
                Console.WriteLine("2. Fuga");
                
              
                scelta1 = Console.ReadLine();
           
                switch (scelta1)
                {
                    case "1":

                   
                    do
                    {
                       

                        int i = 1;
                        Console.WriteLine($"----{i} Round----");
                        EroeServices.EroeAttaccaMostro(eroeScelto, mostroScelto);
                        if (mostroScelto.PuntiVita > 0)
                        {
                         Console.WriteLine($"----{i} Round----");
                         MostroServices.MostroAttaccaEroe(eroeScelto, mostroScelto);
                        }
                        i++;   
                        
                    } while (eroeScelto.PuntiVita >0 && mostroScelto.PuntiVita > 0 ); 
                    if(eroeScelto.PuntiVita > mostroScelto.PuntiVita)
                    {
                        Console.WriteLine("HAI VINTO!!");
                        CalcoloPunteggio(eroeScelto, mostroScelto);
                        int punteggio = eroeScelto.Arma.PuntiDanno * mostroScelto.Livello;
                        Console.WriteLine($"HAI TOTALIZZATO {punteggio} PUNTI");
                        
                    }
                    else
                    {
                        Console.WriteLine("HAI PERSO!!");
                    }
                    
                    break;

                    case "2":

                    break;
                }

           
           
        }

      

      

        public static void CalcoloPunteggio(Eroe eroeScelto,Mostro mostroScelto)
        {
           int livelloEroe = eroeScelto.Livello;
           int LivelloMostro = mostroScelto.Livello;
           int punteggioAccumulato = eroeScelto.Arma.PuntiDanno * mostroScelto.Livello;
           if(punteggioAccumulato >0 && punteggioAccumulato <= 29)
            {
                livelloEroe = 1;
                Console.WriteLine($"NUOVO LIVELLO EROE :{livelloEroe}");
            }
           else if(punteggioAccumulato > 30 && punteggioAccumulato <= 59)
            {
                livelloEroe = 2;
                Console.WriteLine($"NUOVO LIVELLO EROE :{livelloEroe}");
            }
            else if (punteggioAccumulato > 60 && punteggioAccumulato <= 89)
            {
                livelloEroe = 3;
                Console.WriteLine($"NUOVO LIVELLO EROE :{livelloEroe}");
            }
            else if (punteggioAccumulato > 90 && punteggioAccumulato <= 119)
            {
                livelloEroe = 4;
                Console.WriteLine($"NUOVO LIVELLO EROE :{livelloEroe}");
            }
            else
            {
                livelloEroe = 5;
                Console.WriteLine($"NUOVO LIVELLO EROE :{livelloEroe}");
            }
           
            

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
