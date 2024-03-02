using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilhaKm
{
    class Converte
    {
        public string media { get; set; }

        public string getKm()
        {
            double valor = double.Parse(media);

            double converteKm = valor * 0.6214;
            
            return converteKm.ToString();
        }

        public string getMilhas()
        {
            double vl = double.Parse(media);

            double convMilhas = vl * 1.60934;
            
            return convMilhas.ToString();
        }
    }
}
