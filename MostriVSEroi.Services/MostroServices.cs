using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostriVSEroi.Services
{
    public class MostroServices
    {
        public static Mostro GetMostro(List<Mostro> mostri)
        {
            Mostro mostro = new Mostro();
            List<string> nomeMostri = new List<string>();
            foreach (var item in mostri)
            {
                nomeMostri.Add(item.ToString());
            }

            int x = nomeMostri.Count();
            Random r = new Random();
            int index = r.Next(x);
            foreach (var item in mostri)
            {
                if(item.NomeMostro==nomeMostri[index])
                {
                    return item;
                }
            }
            return mostro;
        }
    }
}
