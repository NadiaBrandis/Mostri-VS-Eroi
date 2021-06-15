using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostriVSEroi.mokRepository
{
    public class MostriMockRepository
    {

        public static string SceltaMostro()
        {
            List<Mostro> Mostri = new List<Mostro>();
            List<string> nomeMostri = new List<string>();
            foreach (var item in Mostri)
            {
                nomeMostri.Add(item.ToString());
            }

            int x = nomeMostri.Count();
            Random r = new Random();
            int index = r.Next(x);
            return nomeMostri[index];

        }
    }
}
