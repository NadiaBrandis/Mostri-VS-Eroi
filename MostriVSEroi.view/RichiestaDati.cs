using MostriVSEroi.Modelli;
using MostriVSEroi.SchermataServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.view
{
    public class RichiestaDati
    {
        internal static Utente InserisciUsernamePassword()
        {
            Console.WriteLine("Inserisci Username");
            string username = Console.ReadLine();
            Console.WriteLine("Inserisci password");
            string password = Console.ReadLine();
           return UtenteSchermataServices.GetUtente(username, password);
            
        }

       
        internal static Eroe InserisciIdEroe(List<Eroe> eroi)
        {
            Eroe eroeDaEliminare = new Eroe();
            foreach (var item in eroi)
            {
                Console.WriteLine($"ID: {item.idEroe}- NOME EROE: {item.NomeEroe}");
            }
            Console.Write("inserisci l'Id del eroe che vuoi eliminare: ");
            int id = int.Parse(Console.ReadLine());
            id = eroeDaEliminare.idEroe;
            foreach (var item in eroi)
            {
                if (item.idEroe == id)
                {
                    string nomeEroe = item.NomeEroe;
                    string categoria = item.Categoria;
                    string arma = item.Arma.NomeArma;
                    int puntiDanno = item.Arma.PuntiDanno;
                    return EroeSchermataServices.GetEroe(nomeEroe, categoria, arma, puntiDanno);
                }
                
            }


            return eroeDaEliminare;     
            
            
        }

        internal static List<Mostro> ListaMostri()
        {
            List<Mostro> mostri = new List<Mostro>();
            return mostri;
        }

        internal static int SceltaEroe()
        {
            Console.Write("Digita l' Id del Eroe che vuoi far combattere: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        internal static List<Eroe> ListaEroi()
        {
            List<Eroe> eroi = new List<Eroe>();
            
            return eroi;
        }
        internal static Eroe InserisciDatiEroe(List<Eroe> eroi)
        {
            Eroe eroeDaCreare = new Eroe();

            Console.Write("Nome del Eroe: ");
            string nome = Console.ReadLine();
            foreach (var item in eroi)
            {
                Console.WriteLine(item.Categoria);
            }
            Console.Write("Categoria Eroe tra quelle proposte: ");
            string categoria = Console.ReadLine();
            foreach (var item in eroi)
            {
                if(item.Categoria== categoria)
                Console.WriteLine(item.Arma.NomeArma);
            }
            Console.Write("Selezione l'arma del tuo eroe tra quelle proposte: ");

            string nomeArma = Console.ReadLine();
            ArmaEroe arma = new ArmaEroe();
            int puntiDanno = arma.PuntiDanno;
            nomeArma = arma.NomeArma;

            return EroeSchermataServices.GetEroe(nome, categoria, nomeArma,puntiDanno);

        }

    }
}
