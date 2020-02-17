using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta clase contiene métodos para convertir de
    /// segundo a minutos y viceversa
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Este método transfoma los segundos a minutos.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s)
        {
            double total = 0;
            if (s == 0)
            {
                total = 0;
            }
            else
            {
                total = s / 60;
            }
            return total;
        }
        /// <summary>
        /// Este método transforma los minutos a segundos.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m)
        {
            double total = 0;
            total = m *60;
            return total;
        }
        
        /// <summary>
        /// Este método pasa las horas a minutos
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public static double Hours2Minutes(double h)
        {
            double total = 0;
            total = h * 60;
            return total;
        }
    }
}
