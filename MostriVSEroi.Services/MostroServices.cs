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
        //public static void StampaMostri()
        //{
        //    List<Mostro> mostri = MostriMockRepository.GetMostri();
        //    foreach (var item in mostri)
        //    {
        //        Console.WriteLine(item.CategoriaMostro);
        //    }
        //}

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
        //public static Mostro GetMostro(List<Mostro> mostri)
        //{
        //    string nomeMostro=GetNomeMostro(mostri);
        //    Mostro mostro;
           
        //    CercaMostroPerNome(nomeMostro, mostri,out mostro);
        //    //foreach (var item in mostri)
        //    //{
        //    //    if (nomeMostro == item.NomeMostro)

        //    //        mostro.NomeMostro = item.NomeMostro;
        //    //         mostro.Arma.NomeArma = item.Arma.NomeArma;
        //    //         mostro.Arma.PuntiDanno = item.Arma.PuntiDanno;

        //    //}
        //    return mostro;
            
        //}

        //private static void CercaMostroPerNome(string nomeMostro, List<Mostro> mostri,out Mostro mostro)
        //{
        //    mostro = new Mostro();
        //    foreach (var item in mostri)
        //    {
        //        if (nomeMostro == item.NomeMostro)
        //        {
        //            mostro.NomeMostro = item.NomeMostro;
        //            mostro.Arma.NomeArma = item.Arma.NomeArma;
        //            mostro.Arma.PuntiDanno = item.Arma.PuntiDanno;
                    
        //        }
        //    }
        //}
    }
}
