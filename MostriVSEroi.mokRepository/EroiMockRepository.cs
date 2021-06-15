using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVSEroi.mokRepository
{
    public static class EroiMockRepository
    {
        public static void StampaListaEroi()
        {
            List<Eroe> Eroi = new List<Eroe>();
            foreach(var item in Eroi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
