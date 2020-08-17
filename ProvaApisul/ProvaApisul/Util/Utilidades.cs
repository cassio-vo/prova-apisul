using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaApisul.Util
{
    public static class Utilidades
    {
        public static char ToUpperChar(this char low)
        {
            string charactere = low.ToString();
            return charactere.ToUpper()[0];
        }

        public static float CalculaPorcentagem(int parte, int total)
        {
            float parteF = parte;
            float totalF = total;
            return (float)Math.Round((decimal)(parteF / totalF) * 100, 2);
        }
    }
}
