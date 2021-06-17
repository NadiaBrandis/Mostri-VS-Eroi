using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.Services
{
    public class PartitaServices
    {
        public static int GiocaPartita(Utente utente,Eroe eroeScelto, Mostro mostroScelto)
        {
            //i punti vita del eroe in realtà sono quelli del utente
            
            
           
            Console.WriteLine($"PUNTI VITA EROE: {eroeScelto.PuntiVita}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
            Console.WriteLine($"PUNTI VITA MOSTRO: {mostroScelto.PuntiVita}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");

            Console.WriteLine("Premi 1 per Attaccare!!");
            string scelta1 = Console.ReadLine();
                switch (scelta1)
                {
                    case "1":

                    string scelta;
                    do
                    {
                        Console.WriteLine("1. Attacco");
                        Console.WriteLine("2. Fuga");
                        
                            scelta = Console.ReadLine();
                     
                        int nuoviPuntivitaMostro;
                        int nuoviPuntivitaEroe;
                        
                            Console.WriteLine($"----1 Round----");
                            nuoviPuntivitaMostro = mostroScelto.PuntiVita - eroeScelto.Arma.PuntiDanno;
                            Console.WriteLine($"PUNTI VITA EROE: {eroeScelto.PuntiVita}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
                            Console.WriteLine($"PUNTI VITA MOSTRO: {nuoviPuntivitaMostro}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");
                           
                            Console.WriteLine($"----2 Round----");
                            nuoviPuntivitaEroe = eroeScelto.PuntiVita - mostroScelto.Arma.PuntiDanno;
                            Console.WriteLine($"PUNTI VITA EROE: {nuoviPuntivitaEroe}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
                            Console.WriteLine($"PUNTI VITA MOSTRO: {nuoviPuntivitaMostro}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");
                            
                        
                    } while (scelta!="2"); ;
                    
                    break;

                    case "2":
                        return 10;

                }

            return 0;
           
        }

        private static int CalcolaPuntiVitaEroe(int nuoviPuntivitaEroe, Eroe eroeScelto, int PuntivitaMostro, Mostro mostroScelto)
        {
           int  PuntivitaEroe = nuoviPuntivitaEroe - mostroScelto.Arma.PuntiDanno;
            Console.WriteLine($"PUNTI VITA EROE: {nuoviPuntivitaEroe}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
            Console.WriteLine($"PUNTI VITA MOSTRO: {PuntivitaMostro}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");
            
            return CalcolaPuntiVitaEroe(nuoviPuntivitaEroe, eroeScelto, PuntivitaMostro, mostroScelto);
        }

        private static int CalcoloPuntiVitaMostro(int puntiVitaMostro,Eroe eroeScelto,int nuoviPuntivitaEroe,Mostro mostroScelto)
        {
            int nuoviPuntivitaMostro= puntiVitaMostro - eroeScelto.Arma.PuntiDanno;
            Console.WriteLine($"PUNTI VITA EROE: {nuoviPuntivitaEroe}----ARMA EROE: {eroeScelto.Arma.NomeArma}={eroeScelto.Arma.PuntiDanno}");
            Console.WriteLine($"PUNTI VITA MOSTRO: {nuoviPuntivitaMostro}-----ARMA MOSTRO:{mostroScelto.Arma.NomeArma}={mostroScelto.Arma.PuntiDanno}");
            return CalcoloPuntiVitaMostro(nuoviPuntivitaMostro, eroeScelto, nuoviPuntivitaEroe, mostroScelto);
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
