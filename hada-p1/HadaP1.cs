using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
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
        public static double Minutes2Seconds(double m)
        {
            double total = 0;
            total = m *60;
            return total;
        }
    }
}
